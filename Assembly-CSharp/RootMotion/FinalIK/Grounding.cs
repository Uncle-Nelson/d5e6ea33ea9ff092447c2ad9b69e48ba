using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000038 RID: 56
	[Serializable]
	public class Grounding
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000BB4A File Offset: 0x00009D4A
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000BB52 File Offset: 0x00009D52
		public Grounding.Leg[] legs { get; private set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000BB5B File Offset: 0x00009D5B
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000BB63 File Offset: 0x00009D63
		public Grounding.Pelvis pelvis { get; private set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000BB6C File Offset: 0x00009D6C
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000BB74 File Offset: 0x00009D74
		public bool isGrounded { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000BB7D File Offset: 0x00009D7D
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000BB85 File Offset: 0x00009D85
		public Transform root { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000BB8E File Offset: 0x00009D8E
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000BB96 File Offset: 0x00009D96
		public RaycastHit rootHit { get; private set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		public bool rootGrounded
		{
			get
			{
				return this.rootHit.distance < this.maxStep * 2f;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			RaycastHit result = default(RaycastHit);
			Vector3 up = this.up;
			Vector3 a = Vector3.zero;
			foreach (Grounding.Leg leg in this.legs)
			{
				a += leg.transform.position;
			}
			a /= (float)this.legs.Length;
			result.point = a - up * this.maxStep * 10f;
			float num = maxDistanceMlp + 1f;
			result.distance = this.maxStep * num;
			if (this.maxStep <= 0f)
			{
				return result;
			}
			if (this.quality != Grounding.Quality.Best)
			{
				this.Raycast(a + up * this.maxStep, -up, out result, this.maxStep * num, this.layers, QueryTriggerInteraction.Ignore);
			}
			else
			{
				this.SphereCast(a + up * this.maxStep, this.rootSphereCastRadius, -this.up, out result, this.maxStep * num, this.layers, QueryTriggerInteraction.Ignore);
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000BD08 File Offset: 0x00009F08
		public bool IsValid(ref string errorMessage)
		{
			if (this.root == null)
			{
				errorMessage = "Root transform is null. Can't initiate Grounding.";
				return false;
			}
			if (this.legs == null)
			{
				errorMessage = "Grounding legs is null. Can't initiate Grounding.";
				return false;
			}
			if (this.pelvis == null)
			{
				errorMessage = "Grounding pelvis is null. Can't initiate Grounding.";
				return false;
			}
			if (this.legs.Length == 0)
			{
				errorMessage = "Grounding has 0 legs. Can't initiate Grounding.";
				return false;
			}
			return true;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000BD64 File Offset: 0x00009F64
		public void Initiate(Transform root, Transform[] feet)
		{
			this.root = root;
			this.initiated = false;
			this.rootHit = default(RaycastHit);
			if (this.legs == null)
			{
				this.legs = new Grounding.Leg[feet.Length];
			}
			if (this.legs.Length != feet.Length)
			{
				this.legs = new Grounding.Leg[feet.Length];
			}
			for (int i = 0; i < feet.Length; i++)
			{
				if (this.legs[i] == null)
				{
					this.legs[i] = new Grounding.Leg();
				}
			}
			if (this.pelvis == null)
			{
				this.pelvis = new Grounding.Pelvis();
			}
			string empty = string.Empty;
			if (!this.IsValid(ref empty))
			{
				Warning.Log(empty, root, false);
				return;
			}
			if (Application.isPlaying)
			{
				for (int j = 0; j < feet.Length; j++)
				{
					this.legs[j].Initiate(this, feet[j]);
				}
				this.pelvis.Initiate(this);
				this.initiated = true;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public void Update()
		{
			if (!this.initiated)
			{
				return;
			}
			if (this.layers == 0)
			{
				this.LogWarning("Grounding layers are set to nothing. Please add a ground layer.");
			}
			this.maxStep = Mathf.Clamp(this.maxStep, 0f, this.maxStep);
			this.footRadius = Mathf.Clamp(this.footRadius, 0.0001f, this.maxStep);
			this.pelvisDamper = Mathf.Clamp(this.pelvisDamper, 0f, 1f);
			this.rootSphereCastRadius = Mathf.Clamp(this.rootSphereCastRadius, 0.0001f, this.rootSphereCastRadius);
			this.maxFootRotationAngle = Mathf.Clamp(this.maxFootRotationAngle, 0f, 90f);
			this.prediction = Mathf.Clamp(this.prediction, 0f, this.prediction);
			this.footSpeed = Mathf.Clamp(this.footSpeed, 0f, this.footSpeed);
			this.rootHit = this.GetRootHit(10f);
			float num = float.NegativeInfinity;
			float num2 = float.PositiveInfinity;
			this.isGrounded = false;
			foreach (Grounding.Leg leg in this.legs)
			{
				leg.Process();
				if (leg.IKOffset > num)
				{
					num = leg.IKOffset;
				}
				if (leg.IKOffset < num2)
				{
					num2 = leg.IKOffset;
				}
				if (leg.isGrounded)
				{
					this.isGrounded = true;
				}
			}
			num = Mathf.Max(num, 0f);
			num2 = Mathf.Min(num2, 0f);
			this.pelvis.Process(-num * this.lowerPelvisWeight, -num2 * this.liftPelvisWeight, this.isGrounded);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		public Vector3 GetLegsPlaneNormal()
		{
			if (!this.initiated)
			{
				return Vector3.up;
			}
			Vector3 up = this.up;
			Vector3 vector = up;
			for (int i = 0; i < this.legs.Length; i++)
			{
				Vector3 vector2 = this.legs[i].IKPosition - this.root.position;
				Vector3 vector3 = up;
				Vector3 fromDirection = vector2;
				Vector3.OrthoNormalize(ref vector3, ref fromDirection);
				vector = Quaternion.FromToRotation(fromDirection, vector2) * vector;
			}
			return vector;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000C064 File Offset: 0x0000A264
		public void Reset()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.pelvis.Reset();
			Grounding.Leg[] legs = this.legs;
			for (int i = 0; i < legs.Length; i++)
			{
				legs[i].Reset();
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000C0A1 File Offset: 0x0000A2A1
		public void LogWarning(string message)
		{
			Warning.Log(message, this.root, false);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000C0B0 File Offset: 0x0000A2B0
		public Vector3 up
		{
			get
			{
				if (!this.useRootRotation)
				{
					return Vector3.up;
				}
				return this.root.up;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000C0CB File Offset: 0x0000A2CB
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			if (this.useRootRotation)
			{
				return (Quaternion.Inverse(this.root.rotation) * (p1 - p2)).y;
			}
			return p1.y - p2.y;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000C104 File Offset: 0x0000A304
		public Vector3 Flatten(Vector3 v)
		{
			if (this.useRootRotation)
			{
				Vector3 onNormal = v;
				Vector3 up = this.root.up;
				Vector3.OrthoNormalize(ref up, ref onNormal);
				return Vector3.Project(v, onNormal);
			}
			v.y = 0f;
			return v;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000C145 File Offset: 0x0000A345
		private bool useRootRotation
		{
			get
			{
				return this.rotateSolver && !(this.root.up == Vector3.up);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000C16B File Offset: 0x0000A36B
		public Vector3 GetFootCenterOffset()
		{
			return this.root.forward * this.footRadius + this.root.forward * this.footCenterOffset;
		}

		// Token: 0x0400015D RID: 349
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		// Token: 0x0400015E RID: 350
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep = 0.5f;

		// Token: 0x0400015F RID: 351
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		// Token: 0x04000160 RID: 352
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed = 2.5f;

		// Token: 0x04000161 RID: 353
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius = 0.15f;

		// Token: 0x04000162 RID: 354
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		// Token: 0x04000163 RID: 355
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction = 0.05f;

		// Token: 0x04000164 RID: 356
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight = 1f;

		// Token: 0x04000165 RID: 357
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed = 7f;

		// Token: 0x04000166 RID: 358
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle = 45f;

		// Token: 0x04000167 RID: 359
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		// Token: 0x04000168 RID: 360
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed = 5f;

		// Token: 0x04000169 RID: 361
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		// Token: 0x0400016A RID: 362
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight = 1f;

		// Token: 0x0400016B RID: 363
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		// Token: 0x0400016C RID: 364
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius = 0.1f;

		// Token: 0x0400016D RID: 365
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown = true;

		// Token: 0x0400016E RID: 366
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Grounding.Quality quality = Grounding.Quality.Best;

		// Token: 0x04000174 RID: 372
		public Grounding.OnRaycastDelegate Raycast = new Grounding.OnRaycastDelegate(Physics.Raycast);

		// Token: 0x04000175 RID: 373
		public Grounding.OnCapsuleCastDelegate CapsuleCast = new Grounding.OnCapsuleCastDelegate(Physics.CapsuleCast);

		// Token: 0x04000176 RID: 374
		public Grounding.OnSphereCastDelegate SphereCast = new Grounding.OnSphereCastDelegate(Physics.SphereCast);

		// Token: 0x04000177 RID: 375
		private bool initiated;

		// Token: 0x020000D8 RID: 216
		[Serializable]
		public enum Quality
		{
			// Token: 0x04000615 RID: 1557
			Fastest,
			// Token: 0x04000616 RID: 1558
			Simple,
			// Token: 0x04000617 RID: 1559
			Best
		}

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x06000670 RID: 1648
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x06000674 RID: 1652
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x06000678 RID: 1656
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		// Token: 0x020000DC RID: 220
		public class Leg
		{
			// Token: 0x17000084 RID: 132
			// (get) Token: 0x0600067B RID: 1659 RVA: 0x0002B29D File Offset: 0x0002949D
			// (set) Token: 0x0600067C RID: 1660 RVA: 0x0002B2A5 File Offset: 0x000294A5
			public bool isGrounded { get; private set; }

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x0600067D RID: 1661 RVA: 0x0002B2AE File Offset: 0x000294AE
			// (set) Token: 0x0600067E RID: 1662 RVA: 0x0002B2B6 File Offset: 0x000294B6
			public Vector3 IKPosition { get; private set; }

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002B2BF File Offset: 0x000294BF
			// (set) Token: 0x06000680 RID: 1664 RVA: 0x0002B2C7 File Offset: 0x000294C7
			public bool initiated { get; private set; }

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x0002B2D0 File Offset: 0x000294D0
			// (set) Token: 0x06000682 RID: 1666 RVA: 0x0002B2D8 File Offset: 0x000294D8
			public float heightFromGround { get; private set; }

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002B2E1 File Offset: 0x000294E1
			// (set) Token: 0x06000684 RID: 1668 RVA: 0x0002B2E9 File Offset: 0x000294E9
			public Vector3 velocity { get; private set; }

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002B2F2 File Offset: 0x000294F2
			// (set) Token: 0x06000686 RID: 1670 RVA: 0x0002B2FA File Offset: 0x000294FA
			public Transform transform { get; private set; }

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002B303 File Offset: 0x00029503
			// (set) Token: 0x06000688 RID: 1672 RVA: 0x0002B30B File Offset: 0x0002950B
			public float IKOffset { get; private set; }

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002B314 File Offset: 0x00029514
			// (set) Token: 0x0600068A RID: 1674 RVA: 0x0002B31C File Offset: 0x0002951C
			public RaycastHit heelHit { get; private set; }

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x0600068B RID: 1675 RVA: 0x0002B325 File Offset: 0x00029525
			// (set) Token: 0x0600068C RID: 1676 RVA: 0x0002B32D File Offset: 0x0002952D
			public RaycastHit capsuleHit { get; private set; }

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600068D RID: 1677 RVA: 0x0002B336 File Offset: 0x00029536
			public RaycastHit GetHitPoint
			{
				get
				{
					if (this.grounding.quality == Grounding.Quality.Best)
					{
						return this.capsuleHit;
					}
					return this.heelHit;
				}
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x0002B353 File Offset: 0x00029553
			public void SetFootPosition(Vector3 position)
			{
				this.doOverrideFootPosition = true;
				this.overrideFootPosition = position;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x0002B364 File Offset: 0x00029564
			public void Initiate(Grounding grounding, Transform transform)
			{
				this.initiated = false;
				this.grounding = grounding;
				this.transform = transform;
				this.up = Vector3.up;
				this.IKPosition = transform.position;
				this.rotationOffset = Quaternion.identity;
				this.initiated = true;
				this.OnEnable();
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x0002B3B5 File Offset: 0x000295B5
			public void OnEnable()
			{
				if (!this.initiated)
				{
					return;
				}
				this.lastPosition = this.transform.position;
				this.lastTime = Time.deltaTime;
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x0002B3DC File Offset: 0x000295DC
			public void Reset()
			{
				this.lastPosition = this.transform.position;
				this.lastTime = Time.deltaTime;
				this.IKOffset = 0f;
				this.IKPosition = this.transform.position;
				this.rotationOffset = Quaternion.identity;
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x0002B42C File Offset: 0x0002962C
			public void Process()
			{
				if (!this.initiated)
				{
					return;
				}
				if (this.grounding.maxStep <= 0f)
				{
					return;
				}
				this.transformPosition = (this.doOverrideFootPosition ? this.overrideFootPosition : this.transform.position);
				this.doOverrideFootPosition = false;
				this.deltaTime = Time.time - this.lastTime;
				this.lastTime = Time.time;
				if (this.deltaTime == 0f)
				{
					return;
				}
				this.up = this.grounding.up;
				this.heightFromGround = float.PositiveInfinity;
				this.velocity = (this.transformPosition - this.lastPosition) / this.deltaTime;
				this.lastPosition = this.transformPosition;
				Vector3 vector = this.velocity * this.grounding.prediction;
				if (this.grounding.footRadius <= 0f)
				{
					this.grounding.quality = Grounding.Quality.Fastest;
				}
				this.isGrounded = false;
				switch (this.grounding.quality)
				{
				case Grounding.Quality.Fastest:
				{
					RaycastHit raycastHit = this.GetRaycastHit(vector);
					this.SetFootToPoint(raycastHit.normal, raycastHit.point);
					if (raycastHit.collider != null)
					{
						this.isGrounded = true;
					}
					break;
				}
				case Grounding.Quality.Simple:
				{
					this.heelHit = this.GetRaycastHit(Vector3.zero);
					Vector3 a = this.grounding.GetFootCenterOffset();
					if (this.invertFootCenter)
					{
						a = -a;
					}
					RaycastHit raycastHit2 = this.GetRaycastHit(a + vector);
					RaycastHit raycastHit3 = this.GetRaycastHit(this.grounding.root.right * this.grounding.footRadius * 0.5f);
					if (this.heelHit.collider != null || raycastHit2.collider != null || raycastHit3.collider != null)
					{
						this.isGrounded = true;
					}
					Vector3 vector2 = Vector3.Cross(raycastHit2.point - this.heelHit.point, raycastHit3.point - this.heelHit.point).normalized;
					if (Vector3.Dot(vector2, this.up) < 0f)
					{
						vector2 = -vector2;
					}
					this.SetFootToPlane(vector2, this.heelHit.point, this.heelHit.point);
					break;
				}
				case Grounding.Quality.Best:
					this.heelHit = this.GetRaycastHit(this.invertFootCenter ? (-this.grounding.GetFootCenterOffset()) : Vector3.zero);
					this.capsuleHit = this.GetCapsuleHit(vector);
					if (this.heelHit.collider != null || this.capsuleHit.collider != null)
					{
						this.isGrounded = true;
					}
					this.SetFootToPlane(this.capsuleHit.normal, this.capsuleHit.point, this.heelHit.point);
					break;
				}
				float num = this.stepHeightFromGround;
				if (!this.grounding.rootGrounded)
				{
					num = 0f;
				}
				this.IKOffset = Interp.LerpValue(this.IKOffset, num, this.grounding.footSpeed, this.grounding.footSpeed);
				this.IKOffset = Mathf.Lerp(this.IKOffset, num, this.deltaTime * this.grounding.footSpeed);
				float verticalOffset = this.grounding.GetVerticalOffset(this.transformPosition, this.grounding.root.position);
				float num2 = Mathf.Clamp(this.grounding.maxStep - verticalOffset, 0f, this.grounding.maxStep);
				this.IKOffset = Mathf.Clamp(this.IKOffset, -num2, this.IKOffset);
				this.RotateFoot();
				this.IKPosition = this.transformPosition - this.up * this.IKOffset;
				float footRotationWeight = this.grounding.footRotationWeight;
				this.rotationOffset = ((footRotationWeight >= 1f) ? this.r : Quaternion.Slerp(Quaternion.identity, this.r, footRotationWeight));
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x0002B88B File Offset: 0x00029A8B
			public float stepHeightFromGround
			{
				get
				{
					return Mathf.Clamp(this.heightFromGround, -this.grounding.maxStep, this.grounding.maxStep);
				}
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x0002B8B0 File Offset: 0x00029AB0
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 vector = this.grounding.GetFootCenterOffset();
				if (this.invertFootCenter)
				{
					vector = -vector;
				}
				Vector3 vector2 = this.transformPosition + vector;
				if (this.grounding.overstepFallsDown)
				{
					result.point = vector2 - this.up * this.grounding.maxStep;
				}
				else
				{
					result.point = new Vector3(vector2.x, this.grounding.root.position.y, vector2.z);
				}
				result.normal = this.up;
				Vector3 vector3 = vector2 + this.grounding.maxStep * this.up;
				Vector3 point = vector3 + offsetFromHeel;
				if (this.grounding.CapsuleCast(vector3, point, this.grounding.footRadius, -this.up, out result, this.grounding.maxStep * 2f, this.grounding.layers, QueryTriggerInteraction.Ignore) && float.IsNaN(result.point.x))
				{
					result.point = vector2 - this.up * this.grounding.maxStep * 2f;
					result.normal = this.up;
				}
				if (result.point == Vector3.zero && result.normal == Vector3.zero)
				{
					if (this.grounding.overstepFallsDown)
					{
						result.point = vector2 - this.up * this.grounding.maxStep;
					}
					else
					{
						result.point = new Vector3(vector2.x, this.grounding.root.position.y, vector2.z);
					}
				}
				return result;
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x0002BAA4 File Offset: 0x00029CA4
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				RaycastHit result = default(RaycastHit);
				Vector3 vector = this.transformPosition + offsetFromHeel;
				if (this.grounding.overstepFallsDown)
				{
					result.point = vector - this.up * this.grounding.maxStep;
				}
				else
				{
					result.point = new Vector3(vector.x, this.grounding.root.position.y, vector.z);
				}
				result.normal = this.up;
				if (this.grounding.maxStep <= 0f)
				{
					return result;
				}
				this.grounding.Raycast(vector + this.grounding.maxStep * this.up, -this.up, out result, this.grounding.maxStep * 2f, this.grounding.layers, QueryTriggerInteraction.Ignore);
				if (result.point == Vector3.zero && result.normal == Vector3.zero)
				{
					if (this.grounding.overstepFallsDown)
					{
						result.point = vector - this.up * this.grounding.maxStep;
					}
					else
					{
						result.point = new Vector3(vector.x, this.grounding.root.position.y, vector.z);
					}
				}
				return result;
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x0002BC28 File Offset: 0x00029E28
			private Vector3 RotateNormal(Vector3 normal)
			{
				if (this.grounding.quality == Grounding.Quality.Best)
				{
					return normal;
				}
				return Vector3.RotateTowards(this.up, normal, this.grounding.maxFootRotationAngle * 0.017453292f, this.deltaTime);
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x0002BC5D File Offset: 0x00029E5D
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
				this.toHitNormal = Quaternion.FromToRotation(this.up, this.RotateNormal(normal));
				this.heightFromGround = this.GetHeightFromGround(point);
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x0002BC84 File Offset: 0x00029E84
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
				planeNormal = this.RotateNormal(planeNormal);
				this.toHitNormal = Quaternion.FromToRotation(this.up, planeNormal);
				Vector3 hitPoint = V3Tools.LineToPlane(this.transformPosition + this.up * this.grounding.maxStep, -this.up, planeNormal, planePoint);
				this.heightFromGround = this.GetHeightFromGround(hitPoint);
				float heightFromGround = this.GetHeightFromGround(heelHitPoint);
				this.heightFromGround = Mathf.Clamp(this.heightFromGround, float.NegativeInfinity, heightFromGround);
			}

			// Token: 0x06000699 RID: 1689 RVA: 0x0002BD0C File Offset: 0x00029F0C
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return this.grounding.GetVerticalOffset(this.transformPosition, hitPoint) - this.rootYOffset;
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x0002BD28 File Offset: 0x00029F28
			private void RotateFoot()
			{
				Quaternion rotationOffsetTarget = this.GetRotationOffsetTarget();
				this.r = Quaternion.Slerp(this.r, rotationOffsetTarget, this.deltaTime * this.grounding.footRotationSpeed);
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x0002BD60 File Offset: 0x00029F60
			private Quaternion GetRotationOffsetTarget()
			{
				if (this.grounding.maxFootRotationAngle <= 0f)
				{
					return Quaternion.identity;
				}
				if (this.grounding.maxFootRotationAngle >= 180f)
				{
					return this.toHitNormal;
				}
				return Quaternion.RotateTowards(Quaternion.identity, this.toHitNormal, this.grounding.maxFootRotationAngle);
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600069C RID: 1692 RVA: 0x0002BDB9 File Offset: 0x00029FB9
			private float rootYOffset
			{
				get
				{
					return this.grounding.GetVerticalOffset(this.transformPosition, this.grounding.root.position - this.up * this.grounding.heightOffset);
				}
			}

			// Token: 0x0400061A RID: 1562
			public Quaternion rotationOffset = Quaternion.identity;

			// Token: 0x04000620 RID: 1568
			public bool invertFootCenter;

			// Token: 0x04000623 RID: 1571
			private Grounding grounding;

			// Token: 0x04000624 RID: 1572
			private float lastTime;

			// Token: 0x04000625 RID: 1573
			private float deltaTime;

			// Token: 0x04000626 RID: 1574
			private Vector3 lastPosition;

			// Token: 0x04000627 RID: 1575
			private Quaternion toHitNormal;

			// Token: 0x04000628 RID: 1576
			private Quaternion r;

			// Token: 0x04000629 RID: 1577
			private Vector3 up = Vector3.up;

			// Token: 0x0400062A RID: 1578
			private bool doOverrideFootPosition;

			// Token: 0x0400062B RID: 1579
			private Vector3 overrideFootPosition;

			// Token: 0x0400062C RID: 1580
			private Vector3 transformPosition;
		}

		// Token: 0x020000DD RID: 221
		public class Pelvis
		{
			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600069E RID: 1694 RVA: 0x0002BE15 File Offset: 0x0002A015
			// (set) Token: 0x0600069F RID: 1695 RVA: 0x0002BE1D File Offset: 0x0002A01D
			public Vector3 IKOffset { get; private set; }

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0002BE26 File Offset: 0x0002A026
			// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0002BE2E File Offset: 0x0002A02E
			public float heightOffset { get; private set; }

			// Token: 0x060006A2 RID: 1698 RVA: 0x0002BE37 File Offset: 0x0002A037
			public void Initiate(Grounding grounding)
			{
				this.grounding = grounding;
				this.initiated = true;
				this.OnEnable();
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x0002BE4D File Offset: 0x0002A04D
			public void Reset()
			{
				this.lastRootPosition = this.grounding.root.transform.position;
				this.lastTime = Time.deltaTime;
				this.IKOffset = Vector3.zero;
				this.heightOffset = 0f;
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x0002BE8B File Offset: 0x0002A08B
			public void OnEnable()
			{
				if (!this.initiated)
				{
					return;
				}
				this.lastRootPosition = this.grounding.root.transform.position;
				this.lastTime = Time.time;
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x0002BEBC File Offset: 0x0002A0BC
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
				if (!this.initiated)
				{
					return;
				}
				float num = Time.time - this.lastTime;
				this.lastTime = Time.time;
				if (num <= 0f)
				{
					return;
				}
				float b = lowestOffset + highestOffset;
				if (!this.grounding.rootGrounded)
				{
					b = 0f;
				}
				this.heightOffset = Mathf.Lerp(this.heightOffset, b, num * this.grounding.pelvisSpeed);
				Vector3 p = this.grounding.root.position - this.lastRootPosition;
				this.lastRootPosition = this.grounding.root.position;
				this.damperF = Interp.LerpValue(this.damperF, isGrounded ? 1f : 0f, 1f, 10f);
				this.heightOffset -= this.grounding.GetVerticalOffset(p, Vector3.zero) * this.grounding.pelvisDamper * this.damperF;
				this.IKOffset = this.grounding.up * this.heightOffset;
			}

			// Token: 0x0400062F RID: 1583
			private Grounding grounding;

			// Token: 0x04000630 RID: 1584
			private Vector3 lastRootPosition;

			// Token: 0x04000631 RID: 1585
			private float damperF;

			// Token: 0x04000632 RID: 1586
			private bool initiated;

			// Token: 0x04000633 RID: 1587
			private float lastTime;
		}
	}
}
