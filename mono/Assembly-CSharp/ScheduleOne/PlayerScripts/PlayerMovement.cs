using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.UI;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005FE RID: 1534
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000A3C86 File Offset: 0x000A1E86
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x000A3C8D File Offset: 0x000A1E8D
		public static float GravityMultiplier { get; set; } = 1f;

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000A3C95 File Offset: 0x000A1E95
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x000A3C9D File Offset: 0x000A1E9D
		public float playerHeight { get; protected set; }

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000A3CA6 File Offset: 0x000A1EA6
		public Vector3 Movement
		{
			get
			{
				return this.movement;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x000A3CAE File Offset: 0x000A1EAE
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x000A3CB6 File Offset: 0x000A1EB6
		public LandVehicle currentVehicle { get; protected set; }

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000A3CBF File Offset: 0x000A1EBF
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x000A3CC7 File Offset: 0x000A1EC7
		public float airTime { get; protected set; }

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000A3CD0 File Offset: 0x000A1ED0
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x000A3CD8 File Offset: 0x000A1ED8
		public bool isCrouched { get; protected set; }

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000A3CE1 File Offset: 0x000A1EE1
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x000A3CE9 File Offset: 0x000A1EE9
		public float standingScale { get; protected set; } = 1f;

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000A3CF2 File Offset: 0x000A1EF2
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x000A3CFA File Offset: 0x000A1EFA
		public bool isRagdolled { get; protected set; }

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000A3D03 File Offset: 0x000A1F03
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x000A3D0B File Offset: 0x000A1F0B
		public bool isSprinting { get; protected set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000A3D14 File Offset: 0x000A1F14
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x000A3D1C File Offset: 0x000A1F1C
		public float CurrentSprintMultiplier { get; protected set; } = 1f;

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000A3D25 File Offset: 0x000A1F25
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x000A3D2D File Offset: 0x000A1F2D
		public bool IsGrounded { get; private set; } = true;

		// Token: 0x060027FE RID: 10238 RVA: 0x000A3D38 File Offset: 0x000A1F38
		protected override void Awake()
		{
			base.Awake();
			this.playerHeight = this.Controller.height;
			this.Controller.detectCollisions = false;
			for (int i = 0; i < this.visibilityPointsToScale.Count; i++)
			{
				this.originalVisibilityPointOffsets.Add(this.visibilityPointsToScale[i], this.visibilityPointsToScale[i].localPosition.y);
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000A3DAC File Offset: 0x000A1FAC
		protected override void Start()
		{
			base.Start();
			Player local = Player.Local;
			local.onEnterVehicle = (Player.VehicleEvent)Delegate.Combine(local.onEnterVehicle, new Player.VehicleEvent(this.EnterVehicle));
			Player local2 = Player.Local;
			local2.onExitVehicle = (Player.VehicleTransformEvent)Delegate.Combine(local2.onExitVehicle, new Player.VehicleTransformEvent(this.ExitVehicle));
			Player.Local.Health.onRevive.AddListener(new UnityAction(delegate()
			{
				this.SetStamina(PlayerMovement.StaminaReserveMax, false);
			}));
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000A3E2C File Offset: 0x000A202C
		protected virtual void Update()
		{
			this.UpdateHorizontalAxis();
			this.UpdateVerticalAxis();
			if (this.isCrouched)
			{
				this.standingScale = Mathf.MoveTowards(this.standingScale, 0f, Time.deltaTime / PlayerMovement.CrouchTime);
			}
			else
			{
				this.standingScale = Mathf.MoveTowards(this.standingScale, 1f, Time.deltaTime / PlayerMovement.CrouchTime);
			}
			this.UpdatePlayerHeight();
			if (this.residualVelocityTimeRemaining > 0f)
			{
				this.residualVelocityTimeRemaining -= Time.deltaTime;
			}
			this.timeSinceStaminaDrain += Time.deltaTime;
			if (this.timeSinceStaminaDrain > 1f && this.CurrentStaminaReserve < PlayerMovement.StaminaReserveMax)
			{
				this.ChangeStamina(25f * Time.deltaTime, true);
			}
			this.Move();
			this.UpdateCrouchVignetteEffect();
			this.UpdateMovementEvents();
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000A3F06 File Offset: 0x000A2106
		private void FixedUpdate()
		{
			this.IsGrounded = this.isGrounded();
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000A3F14 File Offset: 0x000A2114
		private void LateUpdate()
		{
			if (this.teleport)
			{
				this.Controller.enabled = false;
				this.Controller.transform.position = this.teleportPosition;
				this.Controller.enabled = true;
				this.teleport = false;
			}
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000A3F54 File Offset: 0x000A2154
		protected virtual void Move()
		{
			this.isSprinting = false;
			if (!this.Controller.enabled)
			{
				this.CurrentSprintMultiplier = Mathf.MoveTowards(this.CurrentSprintMultiplier, 1f, Time.deltaTime * 4f);
				return;
			}
			if (this.currentVehicle != null)
			{
				return;
			}
			if (this.IsGrounded)
			{
				this.timeGrounded += Time.deltaTime;
			}
			else
			{
				this.timeGrounded = 0f;
			}
			if (this.canMove && this.canJump && this.IsGrounded && !this.isJumping && !GameInput.IsTyping && !Singleton<PauseMenu>.Instance.IsPaused && GameInput.GetButtonDown(GameInput.ButtonCode.Jump))
			{
				if (!this.isCrouched)
				{
					this.isJumping = true;
					if (this.onJump != null)
					{
						this.onJump();
					}
					Player.Local.PlayJumpAnimation();
					base.StartCoroutine(this.Jump());
				}
				else
				{
					this.TryToggleCrouch();
				}
			}
			if (this.canMove && !GameInput.IsTyping && !Singleton<PauseMenu>.Instance.IsPaused && GameInput.GetButtonDown(GameInput.ButtonCode.Crouch))
			{
				this.TryToggleCrouch();
			}
			if (!this.IsGrounded)
			{
				this.airTime += Time.deltaTime;
			}
			else
			{
				this.isJumping = false;
				if (this.airTime > 0.1f && this.onLand != null)
				{
					this.onLand();
				}
				this.airTime = 0f;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Sprint) && !this.sprintActive)
			{
				this.sprintActive = true;
				this.sprintReleased = false;
			}
			else if (GameInput.GetButton(GameInput.ButtonCode.Sprint) && Singleton<Settings>.Instance.SprintMode == InputSettings.EActionMode.Hold)
			{
				this.sprintActive = true;
			}
			else if (Singleton<Settings>.Instance.SprintMode == InputSettings.EActionMode.Hold)
			{
				this.sprintActive = false;
			}
			if (!GameInput.GetButton(GameInput.ButtonCode.Sprint))
			{
				this.sprintReleased = true;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Sprint) && this.sprintReleased)
			{
				this.sprintActive = !this.sprintActive;
			}
			this.isSprinting = false;
			if (this.sprintActive && this.canMove && !this.isCrouched && !Player.Local.IsTased && (this.horizontalAxis != 0f || this.verticalAxis != 0f) && this.sprintBlockers.Count == 0)
			{
				if (this.CurrentStaminaReserve > 0f || !this.SprintingRequiresStamina)
				{
					this.CurrentSprintMultiplier = Mathf.MoveTowards(this.CurrentSprintMultiplier, PlayerMovement.SprintMultiplier, Time.deltaTime * 4f);
					if (this.SprintingRequiresStamina)
					{
						this.ChangeStamina(-12.5f * Time.deltaTime, true);
					}
					this.isSprinting = true;
				}
				else
				{
					this.sprintActive = false;
					this.CurrentSprintMultiplier = Mathf.MoveTowards(this.CurrentSprintMultiplier, 1f, Time.deltaTime * 4f);
				}
			}
			else
			{
				this.sprintActive = false;
				this.CurrentSprintMultiplier = Mathf.MoveTowards(this.CurrentSprintMultiplier, 1f, Time.deltaTime * 4f);
			}
			if (!this.isSprinting && this.timeSinceStaminaDrain > 1f)
			{
				this.CurrentSprintMultiplier = Mathf.MoveTowards(this.CurrentSprintMultiplier, 1f, Time.deltaTime * 4f);
			}
			float num = 1f;
			if (this.isCrouched)
			{
				num = 1f - (1f - this.crouchSpeedMultipler) * (1f - this.standingScale);
			}
			float num2 = PlayerMovement.WalkSpeed * this.CurrentSprintMultiplier * num * PlayerMovement.StaticMoveSpeedMultiplier * this.MoveSpeedMultiplier;
			if (Player.Local.IsTased)
			{
				num2 *= 0.5f;
			}
			if ((Application.isEditor || Debug.isDebugBuild) && this.isSprinting)
			{
				num2 *= 1f;
			}
			if (this.Controller.isGrounded)
			{
				if (this.canMove)
				{
					Vector3 vector = this.movement;
					this.movement = new Vector3(this.horizontalAxis, -this.Controller.stepOffset, this.verticalAxis);
					this.movement = base.transform.TransformDirection(this.movement);
					this.ClampMovement();
					this.movement.x = this.movement.x * num2;
					this.movement.z = this.movement.z * num2;
				}
				else
				{
					this.movement = new Vector3(0f, -this.Controller.stepOffset, 0f);
				}
			}
			else if (this.canMove)
			{
				Vector3 vector2 = this.movement;
				this.movement = new Vector3(this.horizontalAxis, this.movement.y, this.verticalAxis);
				this.movement = base.transform.TransformDirection(this.movement);
				this.ClampMovement();
				this.movement.x = this.movement.x * num2;
				this.movement.z = this.movement.z * num2;
			}
			else
			{
				this.movement = new Vector3(0f, this.movement.y, 0f);
			}
			if (!this.canMove)
			{
				this.movement.x = Mathf.MoveTowards(this.movement.x, 0f, this.sensitivity * Time.deltaTime);
				this.movement.z = Mathf.MoveTowards(this.movement.z, 0f, this.sensitivity * Time.deltaTime);
			}
			this.movement.y = this.movement.y + Physics.gravity.y * this.gravityMultiplier * Time.deltaTime * PlayerMovement.GravityMultiplier;
			this.movement.y = this.movement.y + this.movementY;
			this.movementY = 0f;
			if (this.residualVelocityTimeRemaining > 0f)
			{
				this.movement += this.residualVelocityDirection * this.residualVelocityForce * Mathf.Clamp01(this.residualVelocityTimeRemaining / this.residualVelocityDuration) * Time.deltaTime;
			}
			if (Player.Local.Slippery)
			{
				this.movement = Vector3.Lerp(this.movement, new Vector3(this.lastFrameMovement.x, this.movement.y, this.lastFrameMovement.z), this.SlipperyMovementMultiplier);
			}
			float surfaceAngle = this.GetSurfaceAngle();
			if ((this.horizontalAxis != 0f || this.verticalAxis != 0f) && surfaceAngle > 5f)
			{
				float d = Mathf.Clamp01(surfaceAngle / this.Controller.slopeLimit);
				Vector3 b = Vector3.down * Time.deltaTime * this.slopeForce * d;
				this.Controller.Move(this.movement * Time.deltaTime + b);
			}
			else
			{
				this.Controller.Move(this.movement * Time.deltaTime);
			}
			this.lastFrameMovement = this.movement;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000A4630 File Offset: 0x000A2830
		private void ClampMovement()
		{
			float y = this.movement.y;
			this.movement = Vector3.ClampMagnitude(new Vector3(this.movement.x, 0f, this.movement.z), 1f);
			this.movement.y = y;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000A4688 File Offset: 0x000A2888
		protected float GetSurfaceAngle()
		{
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position, Vector3.down, ref raycastHit, this.slopeForceRayLength, this.groundDetectionMask))
			{
				return Vector3.Angle(raycastHit.normal, Vector3.up);
			}
			return 0f;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000A46D6 File Offset: 0x000A28D6
		private bool isGrounded()
		{
			return Player.Local.GetIsGrounded();
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000A46E4 File Offset: 0x000A28E4
		protected void UpdateHorizontalAxis()
		{
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				this.horizontalAxis = 0f;
				return;
			}
			int num = (!GameInput.IsTyping) ? Mathf.RoundToInt(GameInput.MotionAxis.x) : 0;
			if (this.Player.Disoriented)
			{
				num = -num;
			}
			if (this.Player.Schizophrenic && Time.timeSinceLevelLoad % 20f < 1f)
			{
				num = -num;
			}
			float num2 = Mathf.MoveTowards(this.horizontalAxis, (float)num, this.sensitivity * Time.deltaTime);
			this.horizontalAxis = ((Mathf.Abs(num2) < this.dead) ? 0f : num2);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000A478C File Offset: 0x000A298C
		protected void UpdateVerticalAxis()
		{
			if (Singleton<PauseMenu>.Instance.IsPaused)
			{
				this.verticalAxis = 0f;
				return;
			}
			int num = (!GameInput.IsTyping) ? Mathf.RoundToInt(GameInput.MotionAxis.y) : 0;
			if (this.Player.Schizophrenic && (Time.timeSinceLevelLoad + 5f) % 25f < 1f)
			{
				num = -num;
			}
			float num2 = Mathf.MoveTowards(this.verticalAxis, (float)num, this.sensitivity * Time.deltaTime);
			this.verticalAxis = ((Mathf.Abs(num2) < this.dead) ? 0f : num2);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000A4829 File Offset: 0x000A2A29
		private IEnumerator Jump()
		{
			float savedSlopeLimit = this.Controller.slopeLimit;
			this.Controller.velocity.Set(this.Controller.velocity.x, 0f, this.Controller.velocity.y);
			this.movementY += this.jumpForce * PlayerMovement.JumpMultiplier;
			this.timeGrounded = 0f;
			do
			{
				yield return new WaitForEndOfFrame();
			}
			while (this.timeGrounded < 0.05f && this.Controller.collisionFlags != 2 && this.currentVehicle == null);
			this.Controller.slopeLimit = savedSlopeLimit;
			yield break;
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000A4838 File Offset: 0x000A2A38
		private void TryToggleCrouch()
		{
			if (this.isCrouched)
			{
				if (this.CanStand())
				{
					this.SetCrouched(false);
					return;
				}
			}
			else
			{
				this.SetCrouched(true);
			}
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000A485C File Offset: 0x000A2A5C
		public bool CanStand()
		{
			float num = this.Controller.radius * 0.75f;
			float num2 = 0.1f;
			Vector3 vector = base.transform.position - Vector3.up * this.Controller.height * 0.5f + Vector3.up * num + Vector3.up * num2;
			float num3 = this.playerHeight - num * 2f - num2;
			RaycastHit raycastHit;
			return !Physics.SphereCast(vector, num, Vector3.up, ref raycastHit, num3, this.groundDetectionMask);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000A4900 File Offset: 0x000A2B00
		public void SetCrouched(bool c)
		{
			this.isCrouched = c;
			this.Player.SendCrouched(this.isCrouched);
			this.Player.SetCrouchedLocal(this.isCrouched);
			VisibilityAttribute visibilityAttribute = Player.Local.Visibility.GetAttribute("Crouched");
			if (this.isCrouched)
			{
				if (visibilityAttribute == null)
				{
					visibilityAttribute = new VisibilityAttribute("Crouched", 0f, 0.8f, 1);
					return;
				}
			}
			else if (visibilityAttribute != null)
			{
				visibilityAttribute.Delete();
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000A4978 File Offset: 0x000A2B78
		private void UpdateCrouchVignetteEffect()
		{
			if (!Singleton<PostProcessingManager>.InstanceExists)
			{
				return;
			}
			float intensity = Mathf.Lerp(this.Crouched_VigIntensity, Singleton<PostProcessingManager>.Instance.Vig_DefaultIntensity, this.standingScale);
			float smoothness = Mathf.Lerp(this.Crouched_VigSmoothness, Singleton<PostProcessingManager>.Instance.Vig_DefaultSmoothness, this.standingScale);
			Singleton<PostProcessingManager>.Instance.OverrideVignette(intensity, smoothness);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000A49D4 File Offset: 0x000A2BD4
		private void UpdatePlayerHeight()
		{
			float height = this.Controller.height;
			this.Controller.height = this.playerHeight - this.playerHeight * (1f - PlayerMovement.CrouchHeightMultiplier) * (1f - this.standingScale);
			float num = this.Controller.height - height;
			if (this.IsGrounded && Mathf.Abs(num) > 1E-05f)
			{
				this.movementY += num * 0.5f;
			}
			if (Mathf.Abs(num) > 0.0001f)
			{
				for (int i = 0; i < this.visibilityPointsToScale.Count; i++)
				{
					this.visibilityPointsToScale[i].localPosition = new Vector3(this.visibilityPointsToScale[i].localPosition.x, this.originalVisibilityPointOffsets[this.visibilityPointsToScale[i]] * (this.Controller.height / this.playerHeight), this.visibilityPointsToScale[i].localPosition.z);
				}
			}
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000A4AE7 File Offset: 0x000A2CE7
		public void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
			if (this.playerRotCoroutine != null)
			{
				base.StopCoroutine(this.playerRotCoroutine);
			}
			this.playerRotCoroutine = base.StartCoroutine(this.LerpPlayerRotation_Process(rotation, lerpTime));
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000A4B11 File Offset: 0x000A2D11
		private IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			Quaternion startRot = this.Player.transform.rotation;
			this.Controller.enabled = false;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.Player.transform.rotation = Quaternion.Lerp(startRot, endRotation, i / lerpTime);
				yield return new WaitForEndOfFrame();
			}
			this.Player.transform.rotation = endRotation;
			this.Controller.enabled = true;
			this.playerRotCoroutine = null;
			yield break;
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000A4B30 File Offset: 0x000A2D30
		private void EnterVehicle(LandVehicle vehicle)
		{
			this.currentVehicle = vehicle;
			this.canMove = false;
			this.Controller.enabled = false;
			if (this.recentlyDrivenVehicles.Contains(vehicle))
			{
				this.recentlyDrivenVehicles.Remove(vehicle);
			}
			this.recentlyDrivenVehicles.Insert(0, vehicle);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000A4B7F File Offset: 0x000A2D7F
		private void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
			this.currentVehicle = null;
			this.canMove = true;
			this.Controller.enabled = true;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000A4B9C File Offset: 0x000A2D9C
		public void Teleport(Vector3 position)
		{
			string str = "Player teleported: ";
			Vector3 vector = position;
			Console.Log(str + vector.ToString(), null);
			if (this.Player.ActiveSkateboard != null)
			{
				this.Player.ActiveSkateboard.Equippable.Dismount();
			}
			this.Controller.enabled = false;
			this.Controller.transform.position = position;
			this.Controller.enabled = true;
			this.teleport = true;
			this.teleportPosition = position;
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000A4C27 File Offset: 0x000A2E27
		public void SetResidualVelocity(Vector3 dir, float force, float time)
		{
			this.residualVelocityDirection = dir.normalized;
			this.residualVelocityForce = force;
			this.residualVelocityDuration = time;
			this.residualVelocityTimeRemaining = time;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000A4C4C File Offset: 0x000A2E4C
		public void WarpToNavMesh()
		{
			NavMeshQueryFilter navMeshQueryFilter = default(NavMeshQueryFilter);
			navMeshQueryFilter.agentTypeID = Singleton<PlayerManager>.Instance.PlayerRecoverySurface.agentTypeID;
			navMeshQueryFilter.areaMask = -1;
			NavMeshHit navMeshHit;
			if (NavMesh.SamplePosition(PlayerSingleton<PlayerMovement>.Instance.transform.position, ref navMeshHit, 100f, navMeshQueryFilter))
			{
				PlayerSingleton<PlayerMovement>.Instance.Teleport(navMeshHit.position + Vector3.up * 1f);
				return;
			}
			Console.LogError("Failed to find recovery point!", null);
			PlayerSingleton<PlayerMovement>.Instance.Teleport(Vector3.up * 5f);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000A4CE8 File Offset: 0x000A2EE8
		public void RegisterMovementEvent(int threshold, Action action)
		{
			if (threshold < 1)
			{
				Console.LogWarning("Movement events min. threshold is 1m!", null);
				return;
			}
			if (!this.movementEvents.ContainsKey(threshold))
			{
				this.movementEvents.Add(threshold, new PlayerMovement.MovementEvent());
			}
			this.movementEvents[threshold].actions.Add(action);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000A4D3C File Offset: 0x000A2F3C
		public void DeregisterMovementEvent(Action action)
		{
			foreach (int key in this.movementEvents.Keys)
			{
				PlayerMovement.MovementEvent movementEvent = this.movementEvents[key];
				if (movementEvent.actions.Contains(action))
				{
					movementEvent.actions.Remove(action);
					break;
				}
			}
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000A4DB8 File Offset: 0x000A2FB8
		private void UpdateMovementEvents()
		{
			foreach (int num in this.movementEvents.Keys.ToList<int>())
			{
				PlayerMovement.MovementEvent movementEvent = this.movementEvents[num];
				if (Vector3.Distance(this.Player.Avatar.CenterPoint, movementEvent.LastUpdatedDistance) > (float)num)
				{
					movementEvent.Update(this.Player.Avatar.CenterPoint);
				}
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000A4E50 File Offset: 0x000A3050
		public void ChangeStamina(float change, bool notify = true)
		{
			if (change < 0f)
			{
				this.timeSinceStaminaDrain = 0f;
			}
			this.SetStamina(this.CurrentStaminaReserve + change, notify);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000A4E74 File Offset: 0x000A3074
		public void SetStamina(float value, bool notify = true)
		{
			if (this.CurrentStaminaReserve == value)
			{
				return;
			}
			float currentStaminaReserve = this.CurrentStaminaReserve;
			this.CurrentStaminaReserve = Mathf.Clamp(value, 0f, PlayerMovement.StaminaReserveMax);
			if (notify && this.onStaminaReserveChanged != null)
			{
				this.onStaminaReserveChanged(this.CurrentStaminaReserve - currentStaminaReserve);
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000A4EC6 File Offset: 0x000A30C6
		public void AddSprintBlocker(string tag)
		{
			if (!this.sprintBlockers.Contains(tag))
			{
				this.sprintBlockers.Add(tag);
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000A4EE2 File Offset: 0x000A30E2
		public void RemoveSprintBlocker(string tag)
		{
			if (this.sprintBlockers.Contains(tag))
			{
				this.sprintBlockers.Remove(tag);
			}
		}

		// Token: 0x04001CEE RID: 7406
		public const float DEV_SPRINT_MULTIPLIER = 1f;

		// Token: 0x04001CEF RID: 7407
		public const float GROUNDED_THRESHOLD = 0.05f;

		// Token: 0x04001CF0 RID: 7408
		public const float SLOPE_THRESHOLD = 5f;

		// Token: 0x04001CF1 RID: 7409
		public static float WalkSpeed = 3.25f;

		// Token: 0x04001CF2 RID: 7410
		public static float SprintMultiplier = 1.9f;

		// Token: 0x04001CF3 RID: 7411
		public static float StaticMoveSpeedMultiplier = 1f;

		// Token: 0x04001CF4 RID: 7412
		public const float StaminaRestoreDelay = 1f;

		// Token: 0x04001CF5 RID: 7413
		public static float JumpMultiplier = 1f;

		// Token: 0x04001CF6 RID: 7414
		public static float ControllerRadius = 0.35f;

		// Token: 0x04001CF7 RID: 7415
		public static float StandingControllerHeight = 1.85f;

		// Token: 0x04001CF8 RID: 7416
		public static float CrouchHeightMultiplier = 0.65f;

		// Token: 0x04001CF9 RID: 7417
		public static float CrouchTime = 0.2f;

		// Token: 0x04001CFB RID: 7419
		public const float StaminaDrainRate = 12.5f;

		// Token: 0x04001CFC RID: 7420
		public const float StaminaRestoreRate = 25f;

		// Token: 0x04001CFD RID: 7421
		public static float StaminaReserveMax = 100f;

		// Token: 0x04001CFE RID: 7422
		public const float SprintChangeRate = 4f;

		// Token: 0x04001CFF RID: 7423
		[Header("References")]
		public Player Player;

		// Token: 0x04001D00 RID: 7424
		public CharacterController Controller;

		// Token: 0x04001D01 RID: 7425
		[Header("Move settings")]
		[SerializeField]
		protected float sensitivity = 6f;

		// Token: 0x04001D02 RID: 7426
		[SerializeField]
		protected float dead = 0.001f;

		// Token: 0x04001D03 RID: 7427
		public bool canMove = true;

		// Token: 0x04001D04 RID: 7428
		public bool canJump = true;

		// Token: 0x04001D05 RID: 7429
		public bool SprintingRequiresStamina = true;

		// Token: 0x04001D06 RID: 7430
		public float MoveSpeedMultiplier = 1f;

		// Token: 0x04001D07 RID: 7431
		public float SlipperyMovementMultiplier = 1f;

		// Token: 0x04001D08 RID: 7432
		[Header("Jump/fall settings")]
		[SerializeField]
		protected float jumpForce = 4.5f;

		// Token: 0x04001D09 RID: 7433
		[SerializeField]
		protected float gravityMultiplier = 1f;

		// Token: 0x04001D0A RID: 7434
		[SerializeField]
		protected LayerMask groundDetectionMask;

		// Token: 0x04001D0B RID: 7435
		[Header("Slope Settings")]
		[SerializeField]
		protected float slopeForce;

		// Token: 0x04001D0C RID: 7436
		[SerializeField]
		protected float slopeForceRayLength;

		// Token: 0x04001D0D RID: 7437
		[Header("Crouch Settings")]
		[SerializeField]
		protected float crouchSpeedMultipler = 0.5f;

		// Token: 0x04001D0E RID: 7438
		[SerializeField]
		protected float Crouched_VigIntensity = 0.8f;

		// Token: 0x04001D0F RID: 7439
		[SerializeField]
		protected float Crouched_VigSmoothness = 1f;

		// Token: 0x04001D10 RID: 7440
		[Header("Visibility Points")]
		[SerializeField]
		protected List<Transform> visibilityPointsToScale = new List<Transform>();

		// Token: 0x04001D11 RID: 7441
		private Dictionary<Transform, float> originalVisibilityPointOffsets = new Dictionary<Transform, float>();

		// Token: 0x04001D13 RID: 7443
		protected Vector3 movement = Vector3.zero;

		// Token: 0x04001D14 RID: 7444
		protected float movementY;

		// Token: 0x04001D16 RID: 7446
		public List<LandVehicle> recentlyDrivenVehicles = new List<LandVehicle>();

		// Token: 0x04001D17 RID: 7447
		private bool isJumping;

		// Token: 0x04001D1E RID: 7454
		public float CurrentStaminaReserve = PlayerMovement.StaminaReserveMax;

		// Token: 0x04001D20 RID: 7456
		public Action<float> onStaminaReserveChanged;

		// Token: 0x04001D21 RID: 7457
		public Action onJump;

		// Token: 0x04001D22 RID: 7458
		public Action onLand;

		// Token: 0x04001D23 RID: 7459
		public UnityEvent onCrouch;

		// Token: 0x04001D24 RID: 7460
		public UnityEvent onUncrouch;

		// Token: 0x04001D25 RID: 7461
		protected float horizontalAxis;

		// Token: 0x04001D26 RID: 7462
		protected float verticalAxis;

		// Token: 0x04001D27 RID: 7463
		protected float timeGrounded;

		// Token: 0x04001D28 RID: 7464
		private Dictionary<int, PlayerMovement.MovementEvent> movementEvents = new Dictionary<int, PlayerMovement.MovementEvent>();

		// Token: 0x04001D29 RID: 7465
		private float timeSinceStaminaDrain = 10000f;

		// Token: 0x04001D2A RID: 7466
		private bool sprintActive;

		// Token: 0x04001D2B RID: 7467
		private bool sprintReleased;

		// Token: 0x04001D2C RID: 7468
		private Vector3 residualVelocityDirection = Vector3.zero;

		// Token: 0x04001D2D RID: 7469
		private float residualVelocityForce;

		// Token: 0x04001D2E RID: 7470
		private float residualVelocityDuration;

		// Token: 0x04001D2F RID: 7471
		private float residualVelocityTimeRemaining;

		// Token: 0x04001D30 RID: 7472
		private bool teleport;

		// Token: 0x04001D31 RID: 7473
		private Vector3 teleportPosition = Vector3.zero;

		// Token: 0x04001D32 RID: 7474
		private List<string> sprintBlockers = new List<string>();

		// Token: 0x04001D33 RID: 7475
		private Vector3 lastFrameMovement = Vector3.zero;

		// Token: 0x04001D34 RID: 7476
		private Coroutine playerRotCoroutine;

		// Token: 0x020005FF RID: 1535
		public class MovementEvent
		{
			// Token: 0x06002820 RID: 10272 RVA: 0x000A50A4 File Offset: 0x000A32A4
			public void Update(Vector3 newPosition)
			{
				this.LastUpdatedDistance = newPosition;
				foreach (Action action in this.actions)
				{
					action();
				}
			}

			// Token: 0x04001D35 RID: 7477
			public List<Action> actions = new List<Action>();

			// Token: 0x04001D36 RID: 7478
			public Vector3 LastUpdatedDistance = Vector3.zero;
		}
	}
}
