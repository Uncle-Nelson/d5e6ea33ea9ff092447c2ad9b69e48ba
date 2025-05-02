using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007A RID: 122
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		// Token: 0x060004E2 RID: 1250 RVA: 0x00020164 File Offset: 0x0001E364
		protected override void OnModifyOffset()
		{
			HitReactionVRIK.PositionOffset[] array = this.positionOffsets;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(this.ik, this.offsetCurves, this.weight);
			}
			HitReactionVRIK.RotationOffset[] array2 = this.rotationOffsets;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Apply(this.ik, this.offsetCurves, this.weight);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000201D0 File Offset: 0x0001E3D0
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
			if (this.ik == null)
			{
				Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			foreach (HitReactionVRIK.PositionOffset positionOffset in this.positionOffsets)
			{
				if (positionOffset.collider == collider)
				{
					positionOffset.Hit(force, this.offsetCurves, point);
				}
			}
			foreach (HitReactionVRIK.RotationOffset rotationOffset in this.rotationOffsets)
			{
				if (rotationOffset.collider == collider)
				{
					rotationOffset.Hit(force, this.offsetCurves, point);
				}
			}
		}

		// Token: 0x040003AD RID: 941
		public AnimationCurve[] offsetCurves;

		// Token: 0x040003AE RID: 942
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReactionVRIK.PositionOffset[] positionOffsets;

		// Token: 0x040003AF RID: 943
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReactionVRIK.RotationOffset[] rotationOffsets;

		// Token: 0x0200010E RID: 270
		[Serializable]
		public abstract class Offset
		{
			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060007DC RID: 2012 RVA: 0x00033EFD File Offset: 0x000320FD
			// (set) Token: 0x060007DD RID: 2013 RVA: 0x00033F05 File Offset: 0x00032105
			private protected float crossFader { protected get; private set; }

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060007DE RID: 2014 RVA: 0x00033F0E File Offset: 0x0003210E
			// (set) Token: 0x060007DF RID: 2015 RVA: 0x00033F16 File Offset: 0x00032116
			private protected float timer { protected get; private set; }

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00033F1F File Offset: 0x0003211F
			// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00033F27 File Offset: 0x00032127
			private protected Vector3 force { protected get; private set; }

			// Token: 0x060007E2 RID: 2018 RVA: 0x00033F30 File Offset: 0x00032130
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
				if (this.length == 0f)
				{
					this.length = this.GetLength(curves);
				}
				if (this.length <= 0f)
				{
					Debug.LogError("Hit Point WeightCurve length is zero.");
					return;
				}
				if (this.timer < 1f)
				{
					this.crossFader = 0f;
				}
				this.crossFadeSpeed = ((this.crossFadeTime > 0f) ? (1f / this.crossFadeTime) : 0f);
				this.CrossFadeStart();
				this.timer = 0f;
				this.force = force;
			}

			// Token: 0x060007E3 RID: 2019 RVA: 0x00033FC8 File Offset: 0x000321C8
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				float num = Time.time - this.lastTime;
				this.lastTime = Time.time;
				if (this.timer >= this.length)
				{
					return;
				}
				this.timer = Mathf.Clamp(this.timer + num, 0f, this.length);
				if (this.crossFadeSpeed > 0f)
				{
					this.crossFader = Mathf.Clamp(this.crossFader + num * this.crossFadeSpeed, 0f, 1f);
				}
				else
				{
					this.crossFader = 1f;
				}
				this.OnApply(ik, curves, weight);
			}

			// Token: 0x060007E4 RID: 2020
			protected abstract float GetLength(AnimationCurve[] curves);

			// Token: 0x060007E5 RID: 2021
			protected abstract void CrossFadeStart();

			// Token: 0x060007E6 RID: 2022
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			// Token: 0x040007DB RID: 2011
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x040007DC RID: 2012
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x040007DD RID: 2013
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			// Token: 0x040007E1 RID: 2017
			private float length;

			// Token: 0x040007E2 RID: 2018
			private float crossFadeSpeed;

			// Token: 0x040007E3 RID: 2019
			private float lastTime;
		}

		// Token: 0x0200010F RID: 271
		[Serializable]
		public class PositionOffset : HitReactionVRIK.Offset
		{
			// Token: 0x060007E8 RID: 2024 RVA: 0x00034074 File Offset: 0x00032274
			protected override float GetLength(AnimationCurve[] curves)
			{
				float num = (curves[this.forceDirCurveIndex].keys.Length != 0) ? curves[this.forceDirCurveIndex].keys[curves[this.forceDirCurveIndex].length - 1].time : 0f;
				float min = (curves[this.upDirCurveIndex].keys.Length != 0) ? curves[this.upDirCurveIndex].keys[curves[this.upDirCurveIndex].length - 1].time : 0f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x00034108 File Offset: 0x00032308
			protected override void CrossFadeStart()
			{
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x00034134 File Offset: 0x00032334
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				Vector3 a = ik.transform.up * base.force.magnitude;
				Vector3 vector = curves[this.forceDirCurveIndex].Evaluate(base.timer) * base.force + curves[this.upDirCurveIndex].Evaluate(base.timer) * a;
				vector *= weight;
				HitReactionVRIK.PositionOffset.PositionOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Apply(ik, vector, base.crossFader);
				}
			}

			// Token: 0x040007E4 RID: 2020
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			// Token: 0x040007E5 RID: 2021
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex = 1;

			// Token: 0x040007E6 RID: 2022
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks;

			// Token: 0x0200013D RID: 317
			[Serializable]
			public class PositionOffsetLink
			{
				// Token: 0x0600084F RID: 2127 RVA: 0x00035E95 File Offset: 0x00034095
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
					this.current = Vector3.Lerp(this.lastValue, offset * this.weight, crossFader);
					ik.solver.AddPositionOffset(this.positionOffset, this.current);
				}

				// Token: 0x06000850 RID: 2128 RVA: 0x00035ECC File Offset: 0x000340CC
				public void CrossFadeStart()
				{
					this.lastValue = this.current;
				}

				// Token: 0x040008CC RID: 2252
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				// Token: 0x040008CD RID: 2253
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x040008CE RID: 2254
				private Vector3 lastValue;

				// Token: 0x040008CF RID: 2255
				private Vector3 current;
			}
		}

		// Token: 0x02000110 RID: 272
		[Serializable]
		public class RotationOffset : HitReactionVRIK.Offset
		{
			// Token: 0x060007EC RID: 2028 RVA: 0x000341E0 File Offset: 0x000323E0
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
				base.Hit(force, curves, point);
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				Vector3 b = (this.rigidbody != null) ? this.rigidbody.worldCenterOfMass : this.collider.transform.position;
				this.comAxis = Vector3.Cross(force, point - b);
			}

			// Token: 0x060007ED RID: 2029 RVA: 0x00034254 File Offset: 0x00032454
			protected override float GetLength(AnimationCurve[] curves)
			{
				if (curves[this.curveIndex].keys.Length == 0)
				{
					return 0f;
				}
				return curves[this.curveIndex].keys[curves[this.curveIndex].length - 1].time;
			}

			// Token: 0x060007EE RID: 2030 RVA: 0x00034294 File Offset: 0x00032494
			protected override void CrossFadeStart()
			{
				HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			// Token: 0x060007EF RID: 2031 RVA: 0x000342C0 File Offset: 0x000324C0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
				if (this.collider == null)
				{
					Debug.LogError("No collider assigned for a HitPointBone in the HitReaction component.");
					return;
				}
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				if (this.rigidbody != null)
				{
					Quaternion offset = Quaternion.AngleAxis(curves[this.curveIndex].Evaluate(base.timer) * weight, this.comAxis);
					HitReactionVRIK.RotationOffset.RotationOffsetLink[] array = this.offsetLinks;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].Apply(ik, offset, base.crossFader);
					}
				}
			}

			// Token: 0x040007E7 RID: 2023
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public int curveIndex;

			// Token: 0x040007E8 RID: 2024
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks;

			// Token: 0x040007E9 RID: 2025
			private Rigidbody rigidbody;

			// Token: 0x040007EA RID: 2026
			private Vector3 comAxis;

			// Token: 0x0200013E RID: 318
			[Serializable]
			public class RotationOffsetLink
			{
				// Token: 0x06000852 RID: 2130 RVA: 0x00035EE2 File Offset: 0x000340E2
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, offset, this.weight), crossFader);
					ik.solver.AddRotationOffset(this.rotationOffset, this.current);
				}

				// Token: 0x06000853 RID: 2131 RVA: 0x00035F1E File Offset: 0x0003411E
				public void CrossFadeStart()
				{
					this.lastValue = this.current;
				}

				// Token: 0x040008D0 RID: 2256
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				// Token: 0x040008D1 RID: 2257
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x040008D2 RID: 2258
				private Quaternion lastValue = Quaternion.identity;

				// Token: 0x040008D3 RID: 2259
				private Quaternion current = Quaternion.identity;
			}
		}
	}
}
