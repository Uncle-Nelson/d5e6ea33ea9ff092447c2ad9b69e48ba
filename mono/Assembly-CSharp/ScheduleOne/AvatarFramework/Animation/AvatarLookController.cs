using System;
using System.Collections.Generic;
using System.Linq;
using RootMotion.FinalIK;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200099A RID: 2458
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x060042A0 RID: 17056 RVA: 0x001174EC File Offset: 0x001156EC
		private void Awake()
		{
			this.avatar = base.GetComponent<Avatar>();
			this.avatar.onRagdollChange.AddListener(new UnityAction<bool, bool, bool>(this.RagdollChange));
			this.defaultIKWeight = this.Aim.solver.GetIKPositionWeight();
			this.lookAtTarget = new GameObject("LookAtTarget (" + base.gameObject.name + ")").transform;
			Transform transform = this.lookAtTarget;
			GameObject gameObject = GameObject.Find("_Temp");
			transform.SetParent((gameObject != null) ? gameObject.transform : null);
			this.LookForward();
			this.lookAtTarget.transform.position = this.lookAtPos;
			this.lastFrameOffset = this.LookOrigin.InverseTransformPoint(this.lookAtTarget.position);
			this.NPC = base.GetComponentInParent<NPC>();
			base.InvokeRepeating("UpdateNearestPlayer", 0f, 0.5f);
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x001175DC File Offset: 0x001157DC
		private void UpdateShit()
		{
			if (this.ForceLookTarget != null && this.CanLookAt(this.ForceLookTarget.position))
			{
				this.OverrideLookTarget(this.ForceLookTarget.position, 100, this.ForceLookRotateBody);
				return;
			}
			if (this.AutoLookAtPlayer && Player.Local != null && (Player.Local.Paranoid || Player.Local.Schizophrenic))
			{
				this.OverrideLookTarget(Player.Local.MimicCamera.position, 200, false);
				this.Aim.enabled = (this.nearestPlayerDist < 20f * QualitySettings.lodBias);
				this.Aim.solver.clampWeight = Mathf.MoveTowards(this.Aim.solver.clampWeight, this.AimIKWeight, Time.deltaTime * 2f);
				return;
			}
			if (this.DEBUG)
			{
				Console.Log("Nearest player: " + ((this.nearestPlayer != null) ? this.nearestPlayer.name : "null") + " dist: " + this.nearestPlayerDist.ToString(), null);
				Console.Log("Visibility: " + this.NPC.awareness.VisionCone.GetPlayerVisibility(this.nearestPlayer).ToString(), null);
				Console.Log("AutoLookAtPlayer: " + this.AutoLookAtPlayer.ToString(), null);
				Console.Log("CanLookAt: " + this.CanLookAt(this.nearestPlayer.EyePosition).ToString(), null);
			}
			if (this.nearestPlayer != null && this.AutoLookAtPlayer && this.CanLookAt(this.nearestPlayer.EyePosition) && (this.NPC == null || this.NPC.awareness.VisionCone.GetPlayerVisibility(this.nearestPlayer) > this.NPC.awareness.VisionCone.MinVisionDelta))
			{
				Vector3 a = this.nearestPlayer.EyePosition;
				if (this.nearestPlayer.IsOwner)
				{
					a = this.nearestPlayer.MimicCamera.position;
				}
				if (this.nearestPlayerDist < 4f)
				{
					this.lookAtPos = a;
					if (this.DEBUG)
					{
						Console.Log("Looking at player: " + this.nearestPlayer.name, null);
					}
				}
				else if (this.nearestPlayerDist < 10f && Vector3.Angle(a - this.HeadBone.position, this.HeadBone.forward) < 45f)
				{
					Transform mimicCamera = this.nearestPlayer.MimicCamera;
					if (Vector3.Angle(mimicCamera.forward, (this.HeadBone.position - mimicCamera.position).normalized) < 15f)
					{
						this.lookAtPos = a;
						if (this.DEBUG)
						{
							Console.Log("Looking at player: " + this.nearestPlayer.name, null);
						}
					}
					else
					{
						this.LookForward();
					}
				}
				else
				{
					this.LookForward();
				}
			}
			else
			{
				this.LookForward();
			}
			if (this.Aim != null)
			{
				if (this.avatar.Ragdolled || this.avatar.Anim.StandUpAnimationPlaying)
				{
					this.Aim.solver.clampWeight = 0f;
					this.Aim.enabled = false;
					return;
				}
				this.Aim.enabled = (this.nearestPlayerDist < 20f * QualitySettings.lodBias);
				this.Aim.solver.clampWeight = Mathf.MoveTowards(this.Aim.solver.clampWeight, this.AimIKWeight, Time.deltaTime * 2f);
			}
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x001179C4 File Offset: 0x00115BC4
		private void UpdateNearestPlayer()
		{
			if (Player.Local == null)
			{
				return;
			}
			this.localPlayerDist = Vector3.Distance(Player.Local.Avatar.CenterPoint, base.transform.position);
			this.cullRange = 30f * QualitySettings.lodBias;
			if (this.localPlayerDist > this.cullRange)
			{
				return;
			}
			List<Player> list = new List<Player>();
			foreach (Player player in Player.PlayerList)
			{
				if (player.Avatar.LookController == this)
				{
					list.Add(player);
				}
			}
			this.nearestPlayer = Player.GetClosestPlayer(base.transform.position, out this.nearestPlayerDist, list);
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x00117AA0 File Offset: 0x00115CA0
		private void LateUpdate()
		{
			if (this.localPlayerDist > this.cullRange)
			{
				if (this.Aim != null && this.Aim.enabled)
				{
					this.Aim.enabled = false;
				}
				this.lastFrameLookOriginPos = this.LookOrigin.position;
				this.lastFrameLookOriginForward = this.LookOrigin.forward;
				return;
			}
			this.UpdateShit();
			if (this.overrideLookAt)
			{
				this.lookAtPos = this.overriddenLookTarget;
			}
			if (!this.avatar.Ragdolled)
			{
				if (this.overrideLookAt && this.overrideRotateBody)
				{
					Vector3 to = this.lookAtPos - base.transform.position;
					to.y = 0f;
					to.Normalize();
					float y = Vector3.SignedAngle(base.transform.parent.forward, to, Vector3.up);
					if (this.DEBUG)
					{
						Console.Log("Body rotation: " + y.ToString(), null);
					}
					this.avatar.transform.localRotation = Quaternion.Lerp(this.avatar.transform.localRotation, Quaternion.Euler(0f, y, 0f), Time.deltaTime * this.BodyRotationSpeed);
				}
				else if (this.avatar.transform.parent != null)
				{
					this.avatar.transform.localRotation = Quaternion.Lerp(this.avatar.transform.localRotation, Quaternion.identity, Time.deltaTime * this.BodyRotationSpeed);
				}
			}
			this.LerpTargetTransform();
			this.Eyes.LookAt(this.lookAtPos, false);
			this.overrideLookAt = false;
			this.overriddenLookTarget = Vector3.zero;
			this.overrideLookPriority = 0;
			this.overrideRotateBody = false;
			this.lastFrameLookOriginPos = this.LookOrigin.position;
			this.lastFrameLookOriginForward = this.LookOrigin.forward;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x00117C98 File Offset: 0x00115E98
		public void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
			if (this.overrideLookAt && priority < this.overrideLookPriority)
			{
				return;
			}
			if (this.DEBUG)
			{
				Debug.DrawLine(base.transform.position, targetPosition, Color.red, 0.1f);
				string str = "Overriding look target to: ";
				Vector3 vector = targetPosition;
				Console.Log(str + vector.ToString() + " priority: " + priority.ToString(), null);
			}
			this.overrideLookAt = true;
			this.overriddenLookTarget = targetPosition;
			this.overrideLookPriority = priority;
			this.overrideRotateBody = rotateBody;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x00117D24 File Offset: 0x00115F24
		private void LookForward()
		{
			if (this.DEBUG)
			{
				Console.Log("Looking forward", null);
			}
			this.LookForwardTarget.position = this.HeadBone.position + base.transform.forward * 1f;
			this.lookAtPos = this.LookForwardTarget.position;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x00117D88 File Offset: 0x00115F88
		private void LerpTargetTransform()
		{
			this.lookAtTarget.position = this.LookOrigin.TransformPoint(this.lastFrameOffset);
			Vector3 normalized = (this.lookAtTarget.position - this.LookOrigin.position).normalized;
			Vector3 normalized2 = (this.lookAtPos - this.LookOrigin.position).normalized;
			Vector3 b = Vector3.Lerp(normalized, normalized2, Time.deltaTime * this.LookLerpSpeed);
			this.lookAtTarget.position = this.LookOrigin.position + b;
			if (this.Aim != null)
			{
				this.Aim.solver.target = this.lookAtTarget;
			}
			this.lastFrameOffset = this.LookOrigin.InverseTransformPoint(this.lookAtTarget.position);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x00117E64 File Offset: 0x00116064
		private Player GetNearestPlayer()
		{
			List<Player> playerList = Player.PlayerList;
			if (playerList.Count <= 0)
			{
				return null;
			}
			return (from p in playerList
			orderby Vector3.Distance(p.transform.position, base.transform.position)
			select p).First<Player>();
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x00117E9C File Offset: 0x0011609C
		private bool CanLookAt(Vector3 position)
		{
			Vector3 forward = this.avatar.transform.forward;
			Vector3 normalized = (position - this.avatar.transform.position).normalized;
			return Vector3.SignedAngle(forward, normalized, Vector3.up) < 90f;
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000045B1 File Offset: 0x000027B1
		protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00117EEA File Offset: 0x001160EA
		public void OverrideIKWeight(float weight)
		{
			this.Aim.solver.SetIKPositionWeight(weight);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x00117EFD File Offset: 0x001160FD
		public void ResetIKWeight()
		{
			this.Aim.solver.SetIKPositionWeight(this.defaultIKWeight);
		}

		// Token: 0x04003044 RID: 12356
		public const float LookAtPlayerRange = 4f;

		// Token: 0x04003045 RID: 12357
		public const float EyeContractRange = 10f;

		// Token: 0x04003046 RID: 12358
		public const float AimIKRange = 20f;

		// Token: 0x04003047 RID: 12359
		public bool DEBUG;

		// Token: 0x04003048 RID: 12360
		[Header("References")]
		public AimIK Aim;

		// Token: 0x04003049 RID: 12361
		public Transform HeadBone;

		// Token: 0x0400304A RID: 12362
		public Transform LookForwardTarget;

		// Token: 0x0400304B RID: 12363
		public Transform LookOrigin;

		// Token: 0x0400304C RID: 12364
		public EyeController Eyes;

		// Token: 0x0400304D RID: 12365
		[Header("Optional NPC reference")]
		public NPC NPC;

		// Token: 0x0400304E RID: 12366
		[Header("Settings")]
		public bool AutoLookAtPlayer = true;

		// Token: 0x0400304F RID: 12367
		public float LookLerpSpeed = 1f;

		// Token: 0x04003050 RID: 12368
		public float AimIKWeight = 0.6f;

		// Token: 0x04003051 RID: 12369
		public float BodyRotationSpeed = 1f;

		// Token: 0x04003052 RID: 12370
		private Avatar avatar;

		// Token: 0x04003053 RID: 12371
		private Vector3 lookAtPos = Vector3.zero;

		// Token: 0x04003054 RID: 12372
		private Transform lookAtTarget;

		// Token: 0x04003055 RID: 12373
		private Vector3 lastFrameOffset = Vector3.zero;

		// Token: 0x04003056 RID: 12374
		private bool overrideLookAt;

		// Token: 0x04003057 RID: 12375
		private Vector3 overriddenLookTarget = Vector3.zero;

		// Token: 0x04003058 RID: 12376
		private int overrideLookPriority;

		// Token: 0x04003059 RID: 12377
		private bool overrideRotateBody;

		// Token: 0x0400305A RID: 12378
		private Vector3 lastFrameLookOriginPos;

		// Token: 0x0400305B RID: 12379
		private Vector3 lastFrameLookOriginForward;

		// Token: 0x0400305C RID: 12380
		public Transform ForceLookTarget;

		// Token: 0x0400305D RID: 12381
		public bool ForceLookRotateBody;

		// Token: 0x0400305E RID: 12382
		private float defaultIKWeight = 0.6f;

		// Token: 0x0400305F RID: 12383
		private Player nearestPlayer;

		// Token: 0x04003060 RID: 12384
		private float nearestPlayerDist;

		// Token: 0x04003061 RID: 12385
		private float localPlayerDist;

		// Token: 0x04003062 RID: 12386
		private float cullRange = 100f;
	}
}
