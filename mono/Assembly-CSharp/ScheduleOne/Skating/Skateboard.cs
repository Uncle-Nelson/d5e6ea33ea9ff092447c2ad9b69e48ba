using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	// Token: 0x020002C9 RID: 713
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000431E1 File Offset: 0x000413E1
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x000431E9 File Offset: 0x000413E9
		public float CurrentSteerInput { get; protected set; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000431F2 File Offset: 0x000413F2
		public bool IsPushing
		{
			get
			{
				return this.isPushing;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000431FA File Offset: 0x000413FA
		public float TimeSincePushStart
		{
			get
			{
				return this.timeSincePushStart;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00043202 File Offset: 0x00041402
		public bool isGrounded
		{
			get
			{
				return this.timeGrounded > 0f;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00043211 File Offset: 0x00041411
		public float AirTime
		{
			get
			{
				return this.timeAirborne;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00043219 File Offset: 0x00041419
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00043221 File Offset: 0x00041421
		public float JumpBuildAmount
		{
			[CompilerGenerated]
			get
			{
				return this.SyncAccessor_<JumpBuildAmount>k__BackingField;
			}
			[CompilerGenerated]
			[ServerRpc]
			set
			{
				this.RpcWriter___Server_set_JumpBuildAmount_431000436(value);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x0004322D File Offset: 0x0004142D
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00043235 File Offset: 0x00041435
		public Player Rider { get; private set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0004323E File Offset: 0x0004143E
		public float TopSpeed_Ms
		{
			get
			{
				return this.TopSpeed_Kmh / 3.6f;
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0004324C File Offset: 0x0004144C
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.Skating.Skateboard_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0004326B File Offset: 0x0004146B
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (base.IsOwner)
			{
				this.Rider = Player.Local;
			}
			else
			{
				this.Rider = Player.GetPlayer(base.Owner);
			}
			this.ApplyPlayerScale();
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004329F File Offset: 0x0004149F
		public void Update()
		{
			this.GetInput();
			if (base.IsOwner)
			{
				this.Rb.interpolation = 1;
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000432BC File Offset: 0x000414BC
		private void GetInput()
		{
			if (!base.IsOwner)
			{
				return;
			}
			if (Player.Local.IsTased || Player.Local.Seizure)
			{
				if (Random.Range(0f, 1f) > 0.9f)
				{
					this.horizontalInput = Random.Range(-1, 2);
				}
			}
			else
			{
				this.horizontalInput = 0;
				if (GameInput.GetButton(GameInput.ButtonCode.Left))
				{
					if (Player.Local.Disoriented)
					{
						this.horizontalInput++;
					}
					else
					{
						this.horizontalInput--;
					}
				}
				if (GameInput.GetButton(GameInput.ButtonCode.Right))
				{
					if (Player.Local.Disoriented)
					{
						this.horizontalInput--;
					}
					else
					{
						this.horizontalInput++;
					}
				}
			}
			this.jumpReleased = false;
			if (GameInput.GetButton(GameInput.ButtonCode.Jump))
			{
				this.jumpHeldTime += Time.deltaTime;
			}
			else if (this.jumpHeldTime > 0f)
			{
				this.jumpReleased = true;
			}
			this.JumpBuildAmount = Mathf.Clamp01(this.jumpHeldTime / 0.5f);
			this.braking = GameInput.GetButton(GameInput.ButtonCode.Backward);
			if (GameInput.GetButton(GameInput.ButtonCode.Forward) && !this.isPushing && this.timeGrounded > 0.1f && !this.braking && this.timeSincePushStart >= 1f && this.jumpHeldTime == 0f && PlayerSingleton<PlayerMovement>.Instance.CurrentStaminaReserve >= 12.5f && !Player.Local.IsTased)
			{
				this.pushQueued = true;
				PlayerSingleton<PlayerMovement>.Instance.ChangeStamina(-12.5f, true);
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00043448 File Offset: 0x00041648
		private void FixedUpdate()
		{
			if (!base.IsOwner)
			{
				this.CurrentSpeed_Kmh = this.VelocityCalculator.Velocity.magnitude * 3.6f;
				this.CheckGrounded();
				return;
			}
			this.ApplyInput();
			this.ApplyLateralFriction();
			this.UpdateHover();
			this.CheckGrounded();
			this.CheckJump();
			this.ApplyGravity();
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000434A4 File Offset: 0x000416A4
		private void LateUpdate()
		{
			if (!base.IsOwner)
			{
				return;
			}
			this.ClampRotation();
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000434B8 File Offset: 0x000416B8
		private void ApplyInput()
		{
			Vector3 vector = base.transform.InverseTransformVector(this.Rb.velocity);
			bool flag = false;
			if (this.horizontalInput == 1)
			{
				this.CurrentSteerInput = Mathf.MoveTowards(this.CurrentSteerInput, 1f, Time.fixedDeltaTime * this.TurnChangeRate);
				flag = true;
			}
			else if (this.horizontalInput == -1)
			{
				this.CurrentSteerInput = Mathf.MoveTowards(this.CurrentSteerInput, -1f, Time.fixedDeltaTime * this.TurnChangeRate);
				flag = true;
			}
			else
			{
				this.CurrentSteerInput = Mathf.MoveTowards(this.CurrentSteerInput, 0f, Time.fixedDeltaTime * this.TurnReturnToRestRate);
			}
			float num = this.CurrentSteerInput * this.TurnForce * this.TurnForceMap.Evaluate(Mathf.Clamp01(Mathf.Abs(this.CurrentSpeed_Kmh / this.TopSpeed_Kmh)));
			if (vector.z < 0f)
			{
				num *= -1f;
			}
			this.Rb.AddTorque(base.transform.up * num, 5);
			if (flag)
			{
				this.Rb.AddForce(base.transform.forward * Mathf.Abs(this.CurrentSteerInput) * this.TurnSpeedBoost, 5);
			}
			this.timeSincePushStart += Time.deltaTime;
			if (this.pushQueued)
			{
				this.Push();
			}
			if (this.isPushing)
			{
				float d = this.PushForceMultiplierMap.Evaluate(Mathf.Clamp01(this.Rb.velocity.magnitude / this.TopSpeed_Ms));
				this.Rb.AddForce(base.transform.forward * this.thisFramePushForce * this.PushForceMultiplier * d, 5);
			}
			if (this.timeGrounded == 0f && this.AirMovementEnabled)
			{
				float d2 = 1f;
				if (this.timeAirborne < this.AirMovementJumpReductionDuration)
				{
					d2 = this.AirMovementJumpReductionCurve.Evaluate(this.timeAirborne / this.AirMovementJumpReductionDuration);
				}
				this.Rb.AddTorque(base.transform.right * GameInput.MotionAxis.y * this.AirMovementForce * d2, 5);
			}
			if (this.braking)
			{
				float d3 = 1f;
				if (vector.z < 0f)
				{
					float num2 = Mathf.Clamp01(vector.z / -this.ReverseTopSpeed_Kmh);
					d3 = 1f - num2;
				}
				this.Rb.AddForce(-base.transform.forward * this.BrakeForce * d3, 5);
			}
			float magnitude = this.Rb.velocity.magnitude;
			this.CurrentSpeed_Kmh = magnitude * 3.6f;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00043788 File Offset: 0x00041988
		private void ApplyLateralFriction()
		{
			if (!this.FrictionEnabled)
			{
				return;
			}
			Vector3 vector = base.transform.InverseTransformVector(this.Rb.velocity);
			Vector3 vector2 = Vector3.zero;
			float d = vector.x * this.LateralFrictionForceMultiplier;
			vector2 += -base.transform.right * d;
			float num = this.LongitudinalFrictionCurve.Evaluate(Mathf.Clamp01(vector.z) / this.TopSpeed_Ms);
			float d2 = vector.z * num;
			Vector3 a = Vector3.ProjectOnPlane(base.transform.forward, Vector3.up);
			vector2 += -a * d2;
			this.Rb.AddForce(vector2, 5);
			Vector3 velocity = this.Rb.velocity;
			float surfaceSmoothness = this.GetSurfaceSmoothness();
			this.Rb.AddForce(-velocity * (1f - surfaceSmoothness), 5);
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0004387C File Offset: 0x00041A7C
		private void UpdateHover()
		{
			List<float> list = new List<float>();
			for (int i = 0; i < this.HoverPoints.Length; i++)
			{
				RaycastHit raycastHit;
				if (Physics.Raycast(this.HoverPoints[i].position, -this.HoverPoints[i].up, ref raycastHit, this.HoverRayLength, this.GroundDetectionMask))
				{
					list.Add(raycastHit.distance);
					Debug.DrawLine(this.HoverPoints[i].position, raycastHit.point, Color.red);
					PID pid = this.hoverPIDs[i];
					pid.pFactor = this.Hover_P;
					pid.iFactor = this.Hover_I;
					pid.dFactor = this.Hover_D;
					float num = pid.Update(this.HoverHeight, raycastHit.distance, Time.fixedDeltaTime);
					num *= this.HoverForce;
					num = Mathf.Max(num, 0f);
					this.Rb.AddForceAtPosition(this.HoverPoints[i].up * num, this.HoverPoints[i].position, 5);
				}
				else
				{
					list.Add(this.HoverRayLength);
					Debug.DrawRay(this.HoverPoints[i].position, -this.HoverPoints[i].up * this.HoverRayLength, Color.blue);
					this.hoverPIDs[i].Update(this.HoverHeight, this.HoverRayLength, Time.fixedDeltaTime);
				}
			}
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000439FD File Offset: 0x00041BFD
		private void ApplyGravity()
		{
			this.Rb.AddForce(Vector3.down * this.Gravity * Mathf.Sqrt(PlayerMovement.GravityMultiplier), 5);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00043A2C File Offset: 0x00041C2C
		private void CheckGrounded()
		{
			if (this.IsGrounded())
			{
				this.timeGrounded += Time.fixedDeltaTime;
				if (this.timeGrounded > 0.02f)
				{
					if (this.timeAirborne > 0.2f && this.OnLand != null)
					{
						this.OnLand.Invoke();
					}
					this.timeAirborne = 0f;
					return;
				}
			}
			else
			{
				this.timeAirborne += Time.fixedDeltaTime;
				this.timeGrounded = 0f;
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00043AAC File Offset: 0x00041CAC
		private void CheckJump()
		{
			this.timeSinceLastJump += Time.fixedDeltaTime;
			if (this.frontAxleForce > 0f)
			{
				this.Rb.AddForceAtPosition(Vector3.up * this.frontAxleForce, this.FrontAxlePosition.position, 5);
			}
			if (this.frontAxleForce > 0f)
			{
				this.Rb.AddForceAtPosition(Vector3.up * this.rearAxleForce, this.RearAxlePosition.position, 5);
			}
			if (this.jumpForwardForce > 0f)
			{
				this.Rb.AddForce(Vector3.ProjectOnPlane(base.transform.forward, Vector3.up) * this.jumpForwardForce, 5);
			}
			if (this.jumpReleased)
			{
				if (this.timeGrounded > 0.3f)
				{
					this.Jump();
				}
				this.jumpHeldTime = 0f;
			}
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00043B92 File Offset: 0x00041D92
		[ServerRpc(RunLocally = true)]
		private void SendJump(float jumpHeldTime)
		{
			this.RpcWriter___Server_SendJump_431000436(jumpHeldTime);
			this.RpcLogic___SendJump_431000436(jumpHeldTime);
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00043BA8 File Offset: 0x00041DA8
		[ObserversRpc(RunLocally = true)]
		private void ReceiveJump(float _jumpHeldTime)
		{
			this.RpcWriter___Observers_ReceiveJump_431000436(_jumpHeldTime);
			this.RpcLogic___ReceiveJump_431000436(_jumpHeldTime);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00043BCC File Offset: 0x00041DCC
		private void Jump()
		{
			Skateboard.<>c__DisplayClass112_0 CS$<>8__locals1 = new Skateboard.<>c__DisplayClass112_0();
			CS$<>8__locals1.<>4__this = this;
			this.SendJump(this.jumpHeldTime);
			float t = Mathf.Clamp01(this.jumpHeldTime / 0.5f);
			CS$<>8__locals1.JumpDuration = Mathf.Lerp(this.JumpDuration_Min, this.JumpDuration_Max, t);
			base.StartCoroutine(CS$<>8__locals1.<Jump>g__Jump|0());
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00043C29 File Offset: 0x00041E29
		private void Push()
		{
			this.pushQueued = false;
			this.isPushing = true;
			this.timeSincePushStart = 0f;
			if (this.OnPushStart != null)
			{
				this.OnPushStart.Invoke();
			}
			base.StartCoroutine(this.<Push>g__Push|113_0());
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00043C64 File Offset: 0x00041E64
		public bool IsGrounded()
		{
			RaycastHit raycastHit;
			return this.IsGrounded(out raycastHit);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00043C7C File Offset: 0x00041E7C
		public bool IsGrounded(out RaycastHit hit)
		{
			return Physics.Raycast(this.FrontAxlePosition.position + base.transform.up * 0.01f, -base.transform.up, ref hit, 0.1f, this.GroundDetectionMask) || Physics.Raycast(this.RearAxlePosition.position + base.transform.up * 0.01f, -base.transform.up, ref hit, 0.1f, this.GroundDetectionMask);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00043D28 File Offset: 0x00041F28
		public void SetVelocity(Vector3 velocity)
		{
			this.Rb.isKinematic = false;
			this.Rb.velocity = velocity;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00043D44 File Offset: 0x00041F44
		private void ClampRotation()
		{
			Vector3 normalized = Vector3.ProjectOnPlane(base.transform.forward, Vector3.up).normalized;
			Vector3 normalized2 = Vector3.ProjectOnPlane(base.transform.right, Vector3.up).normalized;
			float num = Vector3.SignedAngle(base.transform.forward, normalized, base.transform.right);
			float num2 = Vector3.SignedAngle(normalized2, base.transform.right, base.transform.forward);
			if (Mathf.Abs(num) > 60f)
			{
				this.Rb.AddTorque(base.transform.right * num * this.RotationClampForce, 5);
			}
			if (Mathf.Abs(num2) > 20f)
			{
				this.Rb.AddTorque(base.transform.forward * -num2 * this.RotationClampForce, 5);
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00043E30 File Offset: 0x00042030
		public void ApplyPlayerScale()
		{
			if (this.Rider == null)
			{
				return;
			}
			this.IKAlignmentsContainer.localScale = Vector3.one * this.Rider.Scale;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00043E64 File Offset: 0x00042064
		public float GetSurfaceSmoothness()
		{
			RaycastHit raycastHit;
			if (!this.IsGrounded(out raycastHit))
			{
				return 1f;
			}
			if (raycastHit.collider.gameObject.tag == "Terrain")
			{
				return 0.4f;
			}
			return 1f;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0004400C File Offset: 0x0004220C
		[CompilerGenerated]
		private IEnumerator <Push>g__Push|113_0()
		{
			yield return new WaitForSeconds(this.PushDelay);
			float i = 0f;
			while (i < this.PushForceDuration && !this.braking && this.timeGrounded != 0f)
			{
				this.thisFramePushForce = this.PushForceCurve.Evaluate(i / this.PushForceDuration);
				yield return new WaitForEndOfFrame();
				i += Time.deltaTime;
			}
			this.isPushing = false;
			this.thisFramePushForce = 0f;
			yield break;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0004401C File Offset: 0x0004221C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<JumpBuildAmount>k__BackingField = new SyncVar<float>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Unreliable, this.<JumpBuildAmount>k__BackingField);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_set_JumpBuildAmount_431000436));
			base.RegisterServerRpc(1U, new ServerRpcDelegate(this.RpcReader___Server_SendJump_431000436));
			base.RegisterObserversRpc(2U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveJump_431000436));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Skating.Skateboard));
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000440BC File Offset: 0x000422BC
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted = true;
			this.syncVar___<JumpBuildAmount>k__BackingField.SetRegistered();
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x000440DA File Offset: 0x000422DA
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000440E8 File Offset: 0x000422E8
		private void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(value, AutoPackType.Unpacked);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000441EE File Offset: 0x000423EE
		public void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
			this.sync___set_value_<JumpBuildAmount>k__BackingField(value, true);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000441F8 File Offset: 0x000423F8
		private void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			this.RpcLogic___set_JumpBuildAmount_431000436(value);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00044240 File Offset: 0x00042440
		private void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			if (!base.IsOwner)
			{
				NetworkManager networkManager2 = base.NetworkManager;
				if (networkManager2 == null)
				{
					networkManager2 = InstanceFinder.NetworkManager;
				}
				if (networkManager2 != null)
				{
					networkManager2.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because you are not the owner of this object. .");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(jumpHeldTime, AutoPackType.Unpacked);
			base.SendServerRpc(1U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00044346 File Offset: 0x00042546
		private void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
			this.ReceiveJump(jumpHeldTime);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00044350 File Offset: 0x00042550
		private void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			float num = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (!base.OwnerMatches(conn))
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SendJump_431000436(num);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000443A4 File Offset: 0x000425A4
		private void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteSingle(_jumpHeldTime, AutoPackType.Unpacked);
			base.SendObserversRpc(2U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00044460 File Offset: 0x00042660
		private void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
			if (this.timeSinceLastJump < 0.3f)
			{
				return;
			}
			this.timeSinceLastJump = 0f;
			this.timeGrounded = 0f;
			float arg = Mathf.Clamp01(_jumpHeldTime / 0.5f);
			if (this.OnJump != null)
			{
				this.OnJump.Invoke(arg);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000444B4 File Offset: 0x000426B4
		private void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
			float num = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___ReceiveJump_431000436(num);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000444F4 File Offset: 0x000426F4
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000444FC File Offset: 0x000426FC
		public float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			get
			{
				return this.<JumpBuildAmount>k__BackingField;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.<JumpBuildAmount>k__BackingField = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___<JumpBuildAmount>k__BackingField.SetValue(value, value);
				}
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00044538 File Offset: 0x00042738
		public virtual bool Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_<JumpBuildAmount>k__BackingField(this.syncVar___<JumpBuildAmount>k__BackingField.GetValue(true), true);
				return true;
			}
			float value = PooledReader0.ReadSingle(AutoPackType.Unpacked);
			this.sync___set_value_<JumpBuildAmount>k__BackingField(value, Boolean2);
			return true;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00044590 File Offset: 0x00042790
		private void dll()
		{
			this.Rb.centerOfMass = this.Rb.transform.InverseTransformPoint(this.CoM.position);
			this.Rb.useGravity = false;
			this.Rb.automaticInertiaTensor = false;
			for (int i = 0; i < this.HoverPoints.Length; i++)
			{
				PID item = new PID(this.Hover_P, this.Hover_I, this.Hover_D);
				this.hoverPIDs.Add(item);
			}
			this.Rider = Player.Local;
			this.ApplyPlayerScale();
		}

		// Token: 0x04000FA0 RID: 4000
		public const float GroundedRaycastDistance = 0.1f;

		// Token: 0x04000FA1 RID: 4001
		public const float JumpCooldown = 0.3f;

		// Token: 0x04000FA2 RID: 4002
		public const float JumpForceMin = 0.5f;

		// Token: 0x04000FA3 RID: 4003
		public const float JumpForceBuildTime = 0.5f;

		// Token: 0x04000FA4 RID: 4004
		public const float PushCooldown = 1f;

		// Token: 0x04000FA5 RID: 4005
		public const float PushStaminaConsumption = 12.5f;

		// Token: 0x04000FA6 RID: 4006
		public const float PitchLimit = 60f;

		// Token: 0x04000FA7 RID: 4007
		public const float RollLimit = 20f;

		// Token: 0x04000FA8 RID: 4008
		[Header("Info - Readonly")]
		public float CurrentSpeed_Kmh;

		// Token: 0x04000FAC RID: 4012
		[Header("References")]
		public Rigidbody Rb;

		// Token: 0x04000FAD RID: 4013
		public Transform CoM;

		// Token: 0x04000FAE RID: 4014
		public Transform[] HoverPoints;

		// Token: 0x04000FAF RID: 4015
		public Transform FrontAxlePosition;

		// Token: 0x04000FB0 RID: 4016
		public Transform RearAxlePosition;

		// Token: 0x04000FB1 RID: 4017
		public Transform PlayerContainer;

		// Token: 0x04000FB2 RID: 4018
		public SkateboardAnimation Animation;

		// Token: 0x04000FB3 RID: 4019
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04000FB4 RID: 4020
		public AverageAcceleration Accelerometer;

		// Token: 0x04000FB5 RID: 4021
		public Skateboard_Equippable Equippable;

		// Token: 0x04000FB6 RID: 4022
		public Transform IKAlignmentsContainer;

		// Token: 0x04000FB7 RID: 4023
		[Header("Turn Settings")]
		public float TurnForce = 1f;

		// Token: 0x04000FB8 RID: 4024
		public float TurnChangeRate = 2f;

		// Token: 0x04000FB9 RID: 4025
		public float TurnReturnToRestRate = 1f;

		// Token: 0x04000FBA RID: 4026
		public float TurnSpeedBoost = 1f;

		// Token: 0x04000FBB RID: 4027
		public AnimationCurve TurnForceMap;

		// Token: 0x04000FBC RID: 4028
		[Header("Settings")]
		public float Gravity = 10f;

		// Token: 0x04000FBD RID: 4029
		public float BrakeForce = 1f;

		// Token: 0x04000FBE RID: 4030
		public float ReverseTopSpeed_Kmh = 5f;

		// Token: 0x04000FBF RID: 4031
		public LayerMask GroundDetectionMask;

		// Token: 0x04000FC0 RID: 4032
		public Collider[] MainColliders;

		// Token: 0x04000FC1 RID: 4033
		public float RotationClampForce = 1f;

		// Token: 0x04000FC2 RID: 4034
		[Header("Friction Settings")]
		public bool FrictionEnabled = true;

		// Token: 0x04000FC3 RID: 4035
		public AnimationCurve LongitudinalFrictionCurve;

		// Token: 0x04000FC4 RID: 4036
		public float LongitudinalFrictionMultiplier = 1f;

		// Token: 0x04000FC5 RID: 4037
		public float LateralFrictionForceMultiplier = 1f;

		// Token: 0x04000FC6 RID: 4038
		[Header("Jump Settings")]
		public float JumpForce = 1f;

		// Token: 0x04000FC7 RID: 4039
		public float JumpDuration_Min = 0.2f;

		// Token: 0x04000FC8 RID: 4040
		public float JumpDuration_Max = 0.5f;

		// Token: 0x04000FC9 RID: 4041
		public AnimationCurve FrontAxleJumpCurve;

		// Token: 0x04000FCA RID: 4042
		public AnimationCurve RearAxleJumpCurve;

		// Token: 0x04000FCB RID: 4043
		public AnimationCurve JumpForwardForceCurve;

		// Token: 0x04000FCC RID: 4044
		public float JumpForwardBoost = 1f;

		// Token: 0x04000FCD RID: 4045
		[Header("Hover Settings")]
		public float HoverForce = 1f;

		// Token: 0x04000FCE RID: 4046
		public float HoverRayLength = 0.1f;

		// Token: 0x04000FCF RID: 4047
		public float HoverHeight = 0.05f;

		// Token: 0x04000FD0 RID: 4048
		public float Hover_P = 1f;

		// Token: 0x04000FD1 RID: 4049
		public float Hover_I = 1f;

		// Token: 0x04000FD2 RID: 4050
		public float Hover_D = 1f;

		// Token: 0x04000FD3 RID: 4051
		[Header("Pushing Setings")]
		[Tooltip("Top speed in m/s")]
		public float TopSpeed_Kmh = 10f;

		// Token: 0x04000FD4 RID: 4052
		public float PushForceMultiplier = 1f;

		// Token: 0x04000FD5 RID: 4053
		public AnimationCurve PushForceMultiplierMap;

		// Token: 0x04000FD6 RID: 4054
		public float PushForceDuration = 0.4f;

		// Token: 0x04000FD7 RID: 4055
		public float PushDelay = 0.35f;

		// Token: 0x04000FD8 RID: 4056
		public AnimationCurve PushForceCurve;

		// Token: 0x04000FD9 RID: 4057
		[Header("Air Movement")]
		public bool AirMovementEnabled = true;

		// Token: 0x04000FDA RID: 4058
		public float AirMovementForce = 1f;

		// Token: 0x04000FDB RID: 4059
		public float AirMovementJumpReductionDuration = 0.25f;

		// Token: 0x04000FDC RID: 4060
		public AnimationCurve AirMovementJumpReductionCurve;

		// Token: 0x04000FDD RID: 4061
		[Header("Events")]
		public UnityEvent OnPushStart;

		// Token: 0x04000FDE RID: 4062
		public UnityEvent<float> OnJump;

		// Token: 0x04000FDF RID: 4063
		public UnityEvent OnLand;

		// Token: 0x04000FE0 RID: 4064
		private int horizontalInput;

		// Token: 0x04000FE1 RID: 4065
		private bool jumpReleased;

		// Token: 0x04000FE2 RID: 4066
		private float timeSinceLastJump;

		// Token: 0x04000FE3 RID: 4067
		private float timeGrounded;

		// Token: 0x04000FE4 RID: 4068
		private float timeAirborne = 0.21f;

		// Token: 0x04000FE5 RID: 4069
		private float jumpHeldTime;

		// Token: 0x04000FE6 RID: 4070
		private float frontAxleForce;

		// Token: 0x04000FE7 RID: 4071
		private float rearAxleForce;

		// Token: 0x04000FE8 RID: 4072
		private float jumpForwardForce;

		// Token: 0x04000FE9 RID: 4073
		private List<PID> hoverPIDs = new List<PID>();

		// Token: 0x04000FEA RID: 4074
		private bool pushQueued;

		// Token: 0x04000FEB RID: 4075
		private bool isPushing;

		// Token: 0x04000FEC RID: 4076
		private float thisFramePushForce;

		// Token: 0x04000FED RID: 4077
		private float timeSincePushStart = 2f;

		// Token: 0x04000FEE RID: 4078
		private bool braking;

		// Token: 0x04000FEF RID: 4079
		public SyncVar<float> syncVar___<JumpBuildAmount>k__BackingField;

		// Token: 0x04000FF0 RID: 4080
		private bool dll_Excuted;

		// Token: 0x04000FF1 RID: 4081
		private bool dll_Excuted;
	}
}
