using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000079 RID: 121
	public class HitReaction : OffsetModifier
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00020018 File Offset: 0x0001E218
		public bool inProgress
		{
			get
			{
				HitReaction.HitPointEffector[] array = this.effectorHitPoints;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].inProgress)
					{
						return true;
					}
				}
				HitReaction.HitPointBone[] array2 = this.boneHitPoints;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i].inProgress)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00020068 File Offset: 0x0001E268
		protected override void OnModifyOffset()
		{
			HitReaction.HitPointEffector[] array = this.effectorHitPoints;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Apply(this.ik.solver, this.weight);
			}
			HitReaction.HitPointBone[] array2 = this.boneHitPoints;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Apply(this.ik.solver, this.weight);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000200D4 File Offset: 0x0001E2D4
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
			if (this.ik == null)
			{
				Debug.LogError("No IK assigned in HitReaction");
				return;
			}
			foreach (HitReaction.HitPointEffector hitPointEffector in this.effectorHitPoints)
			{
				if (hitPointEffector.collider == collider)
				{
					hitPointEffector.Hit(force, point);
				}
			}
			foreach (HitReaction.HitPointBone hitPointBone in this.boneHitPoints)
			{
				if (hitPointBone.collider == collider)
				{
					hitPointBone.Hit(force, point);
				}
			}
		}

		// Token: 0x040003AB RID: 939
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitReaction.HitPointEffector[] effectorHitPoints;

		// Token: 0x040003AC RID: 940
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitReaction.HitPointBone[] boneHitPoints;

		// Token: 0x0200010B RID: 267
		[Serializable]
		public abstract class HitPoint
		{
			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00033AF5 File Offset: 0x00031CF5
			public bool inProgress
			{
				get
				{
					return this.timer < this.length;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00033B05 File Offset: 0x00031D05
			// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00033B0D File Offset: 0x00031D0D
			private protected float crossFader { protected get; private set; }

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00033B16 File Offset: 0x00031D16
			// (set) Token: 0x060007CA RID: 1994 RVA: 0x00033B1E File Offset: 0x00031D1E
			private protected float timer { protected get; private set; }

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x060007CB RID: 1995 RVA: 0x00033B27 File Offset: 0x00031D27
			// (set) Token: 0x060007CC RID: 1996 RVA: 0x00033B2F File Offset: 0x00031D2F
			private protected Vector3 force { protected get; private set; }

			// Token: 0x060007CD RID: 1997 RVA: 0x00033B38 File Offset: 0x00031D38
			public virtual void Hit(Vector3 force, Vector3 point)
			{
				if (this.length == 0f)
				{
					this.length = this.GetLength();
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

			// Token: 0x060007CE RID: 1998 RVA: 0x00033BCC File Offset: 0x00031DCC
			public void Apply(IKSolverFullBodyBiped solver, float weight)
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
				this.OnApply(solver, weight);
			}

			// Token: 0x060007CF RID: 1999
			protected abstract float GetLength();

			// Token: 0x060007D0 RID: 2000
			protected abstract void CrossFadeStart();

			// Token: 0x060007D1 RID: 2001
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			// Token: 0x040007CB RID: 1995
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			// Token: 0x040007CC RID: 1996
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			// Token: 0x040007CD RID: 1997
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime = 0.1f;

			// Token: 0x040007D1 RID: 2001
			private float length;

			// Token: 0x040007D2 RID: 2002
			private float crossFadeSpeed;

			// Token: 0x040007D3 RID: 2003
			private float lastTime;
		}

		// Token: 0x0200010C RID: 268
		[Serializable]
		public class HitPointEffector : HitReaction.HitPoint
		{
			// Token: 0x060007D3 RID: 2003 RVA: 0x00033C78 File Offset: 0x00031E78
			protected override float GetLength()
			{
				float num = (this.offsetInForceDirection.keys.Length != 0) ? this.offsetInForceDirection.keys[this.offsetInForceDirection.length - 1].time : 0f;
				float min = (this.offsetInUpDirection.keys.Length != 0) ? this.offsetInUpDirection.keys[this.offsetInUpDirection.length - 1].time : 0f;
				return Mathf.Clamp(num, min, num);
			}

			// Token: 0x060007D4 RID: 2004 RVA: 0x00033D00 File Offset: 0x00031F00
			protected override void CrossFadeStart()
			{
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x00033D2C File Offset: 0x00031F2C
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				Vector3 a = solver.GetRoot().up * base.force.magnitude;
				Vector3 vector = this.offsetInForceDirection.Evaluate(base.timer) * base.force + this.offsetInUpDirection.Evaluate(base.timer) * a;
				vector *= weight;
				HitReaction.HitPointEffector.EffectorLink[] array = this.effectorLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Apply(solver, vector, base.crossFader);
				}
			}

			// Token: 0x040007D4 RID: 2004
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			// Token: 0x040007D5 RID: 2005
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			// Token: 0x040007D6 RID: 2006
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public HitReaction.HitPointEffector.EffectorLink[] effectorLinks;

			// Token: 0x0200013B RID: 315
			[Serializable]
			public class EffectorLink
			{
				// Token: 0x06000849 RID: 2121 RVA: 0x00035DB4 File Offset: 0x00033FB4
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
					this.current = Vector3.Lerp(this.lastValue, offset * this.weight, crossFader);
					solver.GetEffector(this.effector).positionOffset += this.current;
				}

				// Token: 0x0600084A RID: 2122 RVA: 0x00035E01 File Offset: 0x00034001
				public void CrossFadeStart()
				{
					this.lastValue = this.current;
				}

				// Token: 0x040008C4 RID: 2244
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				// Token: 0x040008C5 RID: 2245
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				// Token: 0x040008C6 RID: 2246
				private Vector3 lastValue;

				// Token: 0x040008C7 RID: 2247
				private Vector3 current;
			}
		}

		// Token: 0x0200010D RID: 269
		[Serializable]
		public class HitPointBone : HitReaction.HitPoint
		{
			// Token: 0x060007D7 RID: 2007 RVA: 0x00033DCC File Offset: 0x00031FCC
			public override void Hit(Vector3 force, Vector3 point)
			{
				base.Hit(force, point);
				if (this.rigidbody == null)
				{
					this.rigidbody = this.collider.GetComponent<Rigidbody>();
				}
				Vector3 b = (this.rigidbody != null) ? this.rigidbody.worldCenterOfMass : this.collider.transform.position;
				this.comAxis = Vector3.Cross(force, point - b);
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00033E3F File Offset: 0x0003203F
			protected override float GetLength()
			{
				if (this.aroundCenterOfMass.keys.Length == 0)
				{
					return 0f;
				}
				return this.aroundCenterOfMass.keys[this.aroundCenterOfMass.length - 1].time;
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x00033E78 File Offset: 0x00032078
			protected override void CrossFadeStart()
			{
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].CrossFadeStart();
				}
			}

			// Token: 0x060007DA RID: 2010 RVA: 0x00033EA4 File Offset: 0x000320A4
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
				Quaternion offset = Quaternion.AngleAxis(this.aroundCenterOfMass.Evaluate(base.timer) * weight, this.comAxis);
				HitReaction.HitPointBone.BoneLink[] array = this.boneLinks;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Apply(solver, offset, base.crossFader);
				}
			}

			// Token: 0x040007D7 RID: 2007
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			// Token: 0x040007D8 RID: 2008
			[Tooltip("Linking this hit point to bone(s)")]
			public HitReaction.HitPointBone.BoneLink[] boneLinks;

			// Token: 0x040007D9 RID: 2009
			private Rigidbody rigidbody;

			// Token: 0x040007DA RID: 2010
			private Vector3 comAxis;

			// Token: 0x0200013C RID: 316
			[Serializable]
			public class BoneLink
			{
				// Token: 0x0600084C RID: 2124 RVA: 0x00035E18 File Offset: 0x00034018
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
					this.current = Quaternion.Lerp(this.lastValue, Quaternion.Lerp(Quaternion.identity, offset, this.weight), crossFader);
					this.bone.rotation = this.current * this.bone.rotation;
				}

				// Token: 0x0600084D RID: 2125 RVA: 0x00035E69 File Offset: 0x00034069
				public void CrossFadeStart()
				{
					this.lastValue = this.current;
				}

				// Token: 0x040008C8 RID: 2248
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				// Token: 0x040008C9 RID: 2249
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				// Token: 0x040008CA RID: 2250
				private Quaternion lastValue = Quaternion.identity;

				// Token: 0x040008CB RID: 2251
				private Quaternion current = Quaternion.identity;
			}
		}
	}
}
