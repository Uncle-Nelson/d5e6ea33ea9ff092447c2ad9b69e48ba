using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200060A RID: 1546
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x000A5D79 File Offset: 0x000A3F79
		protected float calculatedJumpJoltHeight
		{
			get
			{
				return this.jumpJoltHeight;
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x000A5D81 File Offset: 0x000A3F81
		protected override void Start()
		{
			base.Start();
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000A5D89 File Offset: 0x000A3F89
		protected override void Awake()
		{
			base.Awake();
			this.initialPos = base.transform.localPosition;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000A5DA4 File Offset: 0x000A3FA4
		public override void OnStartClient(bool IsOwner)
		{
			base.OnStartClient(IsOwner);
			this.timeSinceLanded = this.landJoltTime;
			PlayerMovement instance = PlayerSingleton<PlayerMovement>.Instance;
			instance.onJump = (Action)Delegate.Combine(instance.onJump, new Action(this.StartJump));
			PlayerMovement instance2 = PlayerSingleton<PlayerMovement>.Instance;
			instance2.onLand = (Action)Delegate.Combine(instance2.onLand, new Action(this.Land));
			PlayerInventory instance3 = PlayerSingleton<PlayerInventory>.Instance;
			instance3.onInventoryStateChanged = (Action<bool>)Delegate.Combine(instance3.onInventoryStateChanged, new Action<bool>(this.InventoryStateChanged));
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000A5E38 File Offset: 0x000A4038
		protected void Update()
		{
			if (Time.timeScale == 0f)
			{
				return;
			}
			if (this.breatheBobbingEnabled)
			{
				this.BreatheBob();
			}
			if (this.swayingEnabled)
			{
				this.Sway();
			}
			if (this.walkBobbingEnabled)
			{
				this.WalkBob();
			}
			if (this.jumpJoltEnabled)
			{
				this.UpdateJump();
			}
			Vector3 vector = this.landPos;
			if (PlayerSingleton<PlayerInventory>.Instance.currentEquipTime < this.equipBopTime)
			{
				this.equipBopPos = new Vector3(0f, this.equipBopVerticalOffset * (1f - Mathf.Sqrt(Mathf.Clamp(PlayerSingleton<PlayerInventory>.Instance.currentEquipTime / this.equipBopTime, 0f, 1f))), 0f);
			}
			else
			{
				this.equipBopPos = Vector3.zero;
			}
			if (!PlayerSingleton<PlayerInventory>.Instance.HotbarEnabled)
			{
				this.equipBopPos = new Vector3(0f, this.equipBopVerticalOffset, 0f);
			}
			if (!PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped)
			{
				this.equipBopPos = Vector3.zero;
			}
			this.RefreshViewmodel();
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000A5F3B File Offset: 0x000A413B
		private void InventoryStateChanged(bool active)
		{
			if (active)
			{
				this.Update();
			}
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x000A5F48 File Offset: 0x000A4148
		public void RefreshViewmodel()
		{
			try
			{
				base.transform.localPosition = this.swayPos + this.breatheBobPos + this.walkBobPos + this.jumpPos + this.landPos + this.fallOffsetPos + this.equipBopPos;
			}
			catch
			{
				Console.LogWarning("Viewmodel pos set failed.", null);
			}
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x000A5FC8 File Offset: 0x000A41C8
		protected void BreatheBob()
		{
			this.lastHeight = this.breatheBobPos.y + (Mathf.Sin(Time.timeSinceLevelLoad * this.breathingSpeedMultiplier) - this.lastHeight) * this.breathingHeightMultiplier;
			this.breatheBobPos = new Vector3(0f, this.lastHeight, 0f);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000A6024 File Offset: 0x000A4224
		protected void Sway()
		{
			float x = this.swayPos.x;
			float y = this.swayPos.y;
			float num = 0f;
			float num2 = 0f;
			if (PlayerSingleton<PlayerCamera>.Instance.canLook)
			{
				num = x - GameInput.MouseDelta.x * this.horizontalSwayMultiplier;
				num2 = y - GameInput.MouseDelta.y * this.verticalSwayMultiplier;
			}
			num = Mathf.Clamp(num, -this.maxHorizontal, this.maxHorizontal);
			num2 = Mathf.Clamp(num2, -this.maxVertical, this.maxVertical);
			Vector3 a = Vector3.Lerp(new Vector3(num, num2, 0f), Vector3.zero, Time.deltaTime * this.returnMultiplier / (1f + Mathf.Sqrt(Mathf.Abs(GameInput.MouseDelta.x) + Mathf.Abs(GameInput.MouseDelta.y))));
			this.swayPos = Vector3.Lerp(this.swayPos, a + this.initialPos, Time.deltaTime * this.swaySmooth);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x000A612C File Offset: 0x000A432C
		protected void WalkBob()
		{
			bool flag = false;
			float d = Mathf.Abs(PlayerSingleton<PlayerMovement>.Instance.Movement.x) + Mathf.Abs(PlayerSingleton<PlayerMovement>.Instance.Movement.z);
			if (Mathf.Abs(PlayerSingleton<PlayerMovement>.Instance.Movement.x) > 0f || Mathf.Abs(PlayerSingleton<PlayerMovement>.Instance.Movement.z) > 0f)
			{
				flag = true;
			}
			if (!flag)
			{
				this.timeSinceWalkStart_vert = 0f;
				this.timeSinceWalkStart_horiz = 0f;
			}
			float num = 1f;
			if (PlayerSingleton<PlayerMovement>.Instance.isSprinting)
			{
				num = 1.4f;
			}
			this.walkBobPos = Vector3.Lerp(this.walkBobPos, new Vector3(this.horizontalMovement.Evaluate(this.timeSinceWalkStart_horiz % 1f) * this.horizontalBobWidth * num, this.verticalMovement.Evaluate(this.timeSinceWalkStart_vert % 1f) * this.verticalBobHeight * num, 0f) * d, Time.deltaTime * this.walkBobSmooth);
			if (flag)
			{
				float num2 = 1f;
				if (PlayerSingleton<PlayerMovement>.Instance.isSprinting)
				{
					num2 = 1.6f;
				}
				this.timeSinceWalkStart_vert += Time.deltaTime * this.verticalBobSpeed * num2;
				this.timeSinceWalkStart_horiz += Time.deltaTime * this.horizontalBobSpeed * num2;
			}
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000A628C File Offset: 0x000A448C
		protected void StartJump()
		{
			this.timeSinceJumpStart = 0f;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x000A629C File Offset: 0x000A449C
		protected void UpdateJump()
		{
			if (!PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped || !PlayerSingleton<PlayerInventory>.Instance.HotbarEnabled)
			{
				return;
			}
			if (PlayerSingleton<PlayerMovement>.Instance.airTime > 0f)
			{
				this.timeSinceJumpStart += Time.deltaTime;
				Vector3 b = new Vector3(0f, this.jumpCurve.Evaluate(Mathf.Clamp(this.timeSinceJumpStart / this.jumpJoltTime, 0f, 1f)) * this.calculatedJumpJoltHeight, 0f);
				this.jumpPos = Vector3.Lerp(this.jumpPos, b, Time.deltaTime * this.jumpJoltSmooth);
			}
			else if (PlayerSingleton<PlayerMovement>.Instance.IsGrounded)
			{
				this.timeSinceJumpStart = 0f;
				Vector3 b2 = new Vector3(0f, this.landCurve.Evaluate(Mathf.Clamp(this.timeSinceLanded / this.landJoltTime, 0f, 1f)) * this.landJoltMultiplier, 0f);
				if (this.landJoltMultiplier > 0f)
				{
					this.landPos = Vector3.Lerp(this.landPos, b2, Mathf.Abs(Time.deltaTime * this.landJoltSmooth / this.landJoltMultiplier));
				}
				else
				{
					this.landPos = Vector3.zero;
				}
				this.timeSinceLanded += Time.deltaTime;
				Vector3 zero = Vector3.zero;
				this.jumpPos = Vector3.Lerp(this.jumpPos, zero, Time.deltaTime * this.jumpJoltSmooth);
			}
			if (!PlayerSingleton<PlayerMovement>.Instance.IsGrounded && (this.timeSinceJumpStart > this.jumpJoltTime || PlayerSingleton<PlayerMovement>.Instance.airTime == 0f))
			{
				this.fallOffsetPos.y = this.fallOffsetPos.y + this.fallOffsetRate * Time.deltaTime;
				this.fallOffsetPos.y = Mathf.Clamp(this.fallOffsetPos.y, 0f, this.maxFallOffsetAmount);
				return;
			}
			this.fallOffsetPos.y = 0f;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000A6498 File Offset: 0x000A4698
		protected void Land()
		{
			this.landJoltMultiplier = this.jumpPos.y + this.fallOffsetPos.y + this.landPos.y;
			this.landPos.y = this.landCurve.Evaluate(Mathf.Clamp(0f / this.landJoltTime, 0f, 1f)) * this.landJoltMultiplier;
			this.timeSinceLanded = 0f;
			this.jumpPos.y = 0f;
			this.fallOffsetPos.y = 0f;
		}

		// Token: 0x04001D65 RID: 7525
		[Header("Settings - Breathing")]
		public bool breatheBobbingEnabled = true;

		// Token: 0x04001D66 RID: 7526
		[Range(0f, 0.0004f)]
		[SerializeField]
		protected float breathingHeightMultiplier = 5E-05f;

		// Token: 0x04001D67 RID: 7527
		[Range(0f, 10f)]
		[SerializeField]
		protected float breathingSpeedMultiplier = 1f;

		// Token: 0x04001D68 RID: 7528
		private float lastHeight;

		// Token: 0x04001D69 RID: 7529
		private Vector3 breatheBobPos;

		// Token: 0x04001D6A RID: 7530
		[Header("Settings - Sway - Movement")]
		public bool swayingEnabled = true;

		// Token: 0x04001D6B RID: 7531
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float horizontalSwayMultiplier = 1f;

		// Token: 0x04001D6C RID: 7532
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float verticalSwayMultiplier = 1f;

		// Token: 0x04001D6D RID: 7533
		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxHorizontal = 0.1f;

		// Token: 0x04001D6E RID: 7534
		[Range(0f, 0.5f)]
		[SerializeField]
		protected float maxVertical = 0.1f;

		// Token: 0x04001D6F RID: 7535
		[SerializeField]
		protected float swaySmooth = 3f;

		// Token: 0x04001D70 RID: 7536
		[SerializeField]
		protected float returnMultiplier = 0.1f;

		// Token: 0x04001D71 RID: 7537
		private Vector3 initialPos = Vector3.zero;

		// Token: 0x04001D72 RID: 7538
		private Vector3 swayPos;

		// Token: 0x04001D73 RID: 7539
		[Header("Settings - Walk Bob")]
		public bool walkBobbingEnabled = true;

		// Token: 0x04001D74 RID: 7540
		[SerializeField]
		protected AnimationCurve verticalMovement;

		// Token: 0x04001D75 RID: 7541
		[SerializeField]
		protected AnimationCurve horizontalMovement;

		// Token: 0x04001D76 RID: 7542
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float verticalBobHeight = 0.1f;

		// Token: 0x04001D77 RID: 7543
		[Range(0f, 5f)]
		[SerializeField]
		protected float verticalBobSpeed = 2f;

		// Token: 0x04001D78 RID: 7544
		[Range(0f, 0.1f)]
		[SerializeField]
		protected float horizontalBobWidth = 0.1f;

		// Token: 0x04001D79 RID: 7545
		[Range(0f, 5f)]
		[SerializeField]
		protected float horizontalBobSpeed = 2f;

		// Token: 0x04001D7A RID: 7546
		[SerializeField]
		protected float walkBobSmooth = 3f;

		// Token: 0x04001D7B RID: 7547
		[SerializeField]
		protected float sprintSpeedMultiplier = 1.25f;

		// Token: 0x04001D7C RID: 7548
		[HideInInspector]
		public float walkBobMultiplier = 1f;

		// Token: 0x04001D7D RID: 7549
		private Vector3 walkBobPos;

		// Token: 0x04001D7E RID: 7550
		private float timeSinceWalkStart_vert;

		// Token: 0x04001D7F RID: 7551
		private float timeSinceWalkStart_horiz;

		// Token: 0x04001D80 RID: 7552
		[Header("Settings - Jump Jolt")]
		public bool jumpJoltEnabled = true;

		// Token: 0x04001D81 RID: 7553
		[SerializeField]
		protected AnimationCurve jumpCurve;

		// Token: 0x04001D82 RID: 7554
		[SerializeField]
		protected float jumpJoltTime = 0.6f;

		// Token: 0x04001D83 RID: 7555
		[SerializeField]
		protected float jumpJoltHeight = 0.2f;

		// Token: 0x04001D84 RID: 7556
		[SerializeField]
		protected float jumpJoltSmooth = 5f;

		// Token: 0x04001D85 RID: 7557
		[Header("Settings - Equip Bop")]
		[SerializeField]
		protected float equipBopVerticalOffset = -0.5f;

		// Token: 0x04001D86 RID: 7558
		[SerializeField]
		protected float equipBopTime = 0.2f;

		// Token: 0x04001D87 RID: 7559
		private Vector3 equipBopPos;

		// Token: 0x04001D88 RID: 7560
		private float timeSinceJumpStart;

		// Token: 0x04001D89 RID: 7561
		private Vector3 jumpPos = Vector3.zero;

		// Token: 0x04001D8A RID: 7562
		[Header("Settings - Falling")]
		[Range(0f, 1f)]
		[SerializeField]
		protected float fallOffsetRate = 0.1f;

		// Token: 0x04001D8B RID: 7563
		[Range(0f, 2f)]
		[SerializeField]
		protected float maxFallOffsetAmount = 0.2f;

		// Token: 0x04001D8C RID: 7564
		private Vector3 fallOffsetPos = Vector3.zero;

		// Token: 0x04001D8D RID: 7565
		[Header("Settings - Land Jolt")]
		[SerializeField]
		protected AnimationCurve landCurve;

		// Token: 0x04001D8E RID: 7566
		[SerializeField]
		protected float landJoltTime = 0.6f;

		// Token: 0x04001D8F RID: 7567
		[SerializeField]
		protected float landJoltSmooth = 5f;

		// Token: 0x04001D90 RID: 7568
		private Vector3 landPos = Vector3.zero;

		// Token: 0x04001D91 RID: 7569
		private float timeSinceLanded;

		// Token: 0x04001D92 RID: 7570
		private float landJoltMultiplier = 1f;
	}
}
