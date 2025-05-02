using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000066 RID: 102
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x0001D44D File Offset: 0x0001B64D
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001D459 File Offset: 0x0001B659
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html");
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001D465 File Offset: 0x0001B665
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001D471 File Offset: 0x0001B671
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001D47D File Offset: 0x0001B67D
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0001D489 File Offset: 0x0001B689
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001D495 File Offset: 0x0001B695
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001D4A1 File Offset: 0x0001B6A1
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].curve == curveType)
				{
					return this.multipliers[i].multiplier;
				}
			}
			return 1f;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001D4F3 File Offset: 0x0001B6F3
		public void ResetRotation()
		{
			if (this.pivot != null)
			{
				this.pivot.localRotation = this.defaultLocalRotation;
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001D514 File Offset: 0x0001B714
		public void RotateTo(Transform bone)
		{
			if (this.pivot == null)
			{
				return;
			}
			if (this.pivot != this.lastPivot)
			{
				this.defaultLocalRotation = this.pivot.localRotation;
				this.lastPivot = this.pivot;
			}
			this.pivot.localRotation = this.defaultLocalRotation;
			InteractionTarget.RotationMode rotationMode = this.rotationMode;
			if (rotationMode != InteractionTarget.RotationMode.TwoDOF)
			{
				if (rotationMode != InteractionTarget.RotationMode.ThreeDOF)
				{
					return;
				}
				if (this.threeDOFWeight > 0f)
				{
					Quaternion quaternion = QuaTools.FromToRotation(base.transform.rotation, bone.rotation);
					if (this.threeDOFWeight >= 1f)
					{
						this.pivot.rotation = quaternion * this.pivot.rotation;
						return;
					}
					this.pivot.rotation = Quaternion.Slerp(Quaternion.identity, quaternion, this.threeDOFWeight) * this.pivot.rotation;
				}
			}
			else
			{
				if (this.twistWeight > 0f)
				{
					Vector3 fromDirection = base.transform.position - this.pivot.position;
					Vector3 vector = this.pivot.rotation * this.twistAxis;
					Vector3 vector2 = vector;
					Vector3.OrthoNormalize(ref vector2, ref fromDirection);
					vector2 = vector;
					Vector3 toDirection = bone.position - this.pivot.position;
					Vector3.OrthoNormalize(ref vector2, ref toDirection);
					Quaternion b = QuaTools.FromToAroundAxis(fromDirection, toDirection, vector);
					this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b, this.twistWeight) * this.pivot.rotation;
				}
				if (this.swingWeight > 0f)
				{
					Quaternion b2 = Quaternion.FromToRotation(base.transform.position - this.pivot.position, bone.position - this.pivot.position);
					this.pivot.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.swingWeight) * this.pivot.rotation;
					return;
				}
			}
		}

		// Token: 0x0400033C RID: 828
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		// Token: 0x0400033D RID: 829
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public InteractionTarget.Multiplier[] multipliers;

		// Token: 0x0400033E RID: 830
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp = 1f;

		// Token: 0x0400033F RID: 831
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		// Token: 0x04000340 RID: 832
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public InteractionTarget.RotationMode rotationMode;

		// Token: 0x04000341 RID: 833
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis = Vector3.up;

		// Token: 0x04000342 RID: 834
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight = 1f;

		// Token: 0x04000343 RID: 835
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		// Token: 0x04000344 RID: 836
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight = 1f;

		// Token: 0x04000345 RID: 837
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce = true;

		// Token: 0x04000346 RID: 838
		[Tooltip("Will not set HandPoser's pose target and allows you to use a pose target from a previous interaction if disabled.")]
		public bool usePoser = true;

		// Token: 0x04000347 RID: 839
		private Quaternion defaultLocalRotation;

		// Token: 0x04000348 RID: 840
		private Transform lastPivot;

		// Token: 0x020000FD RID: 253
		[Serializable]
		public enum RotationMode
		{
			// Token: 0x04000789 RID: 1929
			TwoDOF,
			// Token: 0x0400078A RID: 1930
			ThreeDOF
		}

		// Token: 0x020000FE RID: 254
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0400078B RID: 1931
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x0400078C RID: 1932
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;
		}
	}
}
