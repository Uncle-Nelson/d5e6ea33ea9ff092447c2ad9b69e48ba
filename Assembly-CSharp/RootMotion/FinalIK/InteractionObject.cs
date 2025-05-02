using System;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	// Token: 0x02000064 RID: 100
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x0001B64D File Offset: 0x0001984D
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001B659 File Offset: 0x00019859
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html");
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001B665 File Offset: 0x00019865
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001B671 File Offset: 0x00019871
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001B67D File Offset: 0x0001987D
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001B689 File Offset: 0x00019889
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001B695 File Offset: 0x00019895
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001B6A1 File Offset: 0x000198A1
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001B6AD File Offset: 0x000198AD
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0001B6B5 File Offset: 0x000198B5
		public float length { get; private set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0001B6BE File Offset: 0x000198BE
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0001B6C6 File Offset: 0x000198C6
		public InteractionSystem lastUsedInteractionSystem { get; private set; }

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001B6D0 File Offset: 0x000198D0
		public void Initiate()
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].curve.length > 0)
				{
					float time = this.weightCurves[i].curve.keys[this.weightCurves[i].curve.length - 1].time;
					this.length = Mathf.Clamp(this.length, time, this.length);
				}
			}
			for (int j = 0; j < this.events.Length; j++)
			{
				this.length = Mathf.Clamp(this.length, this.events[j].time, this.length);
			}
			this.targets = this.targetsRoot.GetComponentsInChildren<InteractionTarget>();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001B796 File Offset: 0x00019996
		public Transform lookAtTarget
		{
			get
			{
				if (this.otherLookAtTarget != null)
				{
					return this.otherLookAtTarget;
				}
				return base.transform;
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001B7B4 File Offset: 0x000199B4
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			if (interactionSystem.CompareTag(string.Empty) || interactionSystem.CompareTag(""))
			{
				foreach (InteractionTarget interactionTarget in this.targets)
				{
					if (interactionTarget.effectorType == effectorType)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			foreach (InteractionTarget interactionTarget2 in this.targets)
			{
				if (interactionTarget2.effectorType == effectorType && interactionTarget2.CompareTag(interactionSystem.tag))
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001B834 File Offset: 0x00019A34
		public bool CurveUsed(InteractionObject.WeightCurve.Type type)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].type == type)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].result == type)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001B886 File Offset: 0x00019A86
		public InteractionTarget[] GetTargets()
		{
			return this.targets;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001B890 File Offset: 0x00019A90
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			if (tag == string.Empty || tag == "")
			{
				return this.GetTarget(effectorType);
			}
			for (int i = 0; i < this.targets.Length; i++)
			{
				if (this.targets[i].effectorType == effectorType && this.targets[i].CompareTag(tag))
				{
					return this.targets[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001B906 File Offset: 0x00019B06
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
			this.lastUsedInteractionSystem = interactionSystem;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001B910 File Offset: 0x00019B10
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight, bool isPaused)
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (!isPaused || (this.weightCurves[i].type != InteractionObject.WeightCurve.Type.PositionOffsetX && this.weightCurves[i].type != InteractionObject.WeightCurve.Type.PositionOffsetY && this.weightCurves[i].type != InteractionObject.WeightCurve.Type.PositionOffsetZ))
				{
					float num = (target == null) ? 1f : target.GetValue(this.weightCurves[i].type);
					this.Apply(solver, effector, this.weightCurves[i].type, this.weightCurves[i].GetValue(timer), weight * num);
				}
			}
			for (int j = 0; j < this.multipliers.Length; j++)
			{
				if (!isPaused || (this.multipliers[j].result != InteractionObject.WeightCurve.Type.PositionOffsetX && this.multipliers[j].result != InteractionObject.WeightCurve.Type.PositionOffsetY && this.multipliers[j].result != InteractionObject.WeightCurve.Type.PositionOffsetZ))
				{
					if (this.multipliers[j].curve == this.multipliers[j].result && !Warning.logged)
					{
						Warning.Log("InteractionObject Multiplier 'Curve' " + this.multipliers[j].curve.ToString() + "and 'Result' are the same.", base.transform, false);
					}
					int weightCurveIndex = this.GetWeightCurveIndex(this.multipliers[j].curve);
					if (weightCurveIndex != -1)
					{
						float num2 = (target == null) ? 1f : target.GetValue(this.multipliers[j].result);
						this.Apply(solver, effector, this.multipliers[j].result, this.multipliers[j].GetValue(this.weightCurves[weightCurveIndex], timer), weight * num2);
					}
					else if (!Warning.logged)
					{
						Warning.Log("InteractionObject Multiplier curve " + this.multipliers[j].curve.ToString() + "does not exist.", base.transform, false);
					}
				}
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001BB0C File Offset: 0x00019D0C
		public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			int weightCurveIndex = this.GetWeightCurveIndex(weightCurveType);
			if (weightCurveIndex != -1)
			{
				float num = (target == null) ? 1f : target.GetValue(weightCurveType);
				return this.weightCurves[weightCurveIndex].GetValue(timer) * num;
			}
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == weightCurveType)
				{
					int weightCurveIndex2 = this.GetWeightCurveIndex(this.multipliers[i].curve);
					if (weightCurveIndex2 != -1)
					{
						float num2 = (target == null) ? 1f : target.GetValue(this.multipliers[i].result);
						return this.multipliers[i].GetValue(this.weightCurves[weightCurveIndex2], timer) * num2;
					}
				}
			}
			return 0f;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001BBCD File Offset: 0x00019DCD
		public Transform targetsRoot
		{
			get
			{
				if (this.otherTargetsRoot != null)
				{
					return this.otherTargetsRoot;
				}
				return base.transform;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001BBEA File Offset: 0x00019DEA
		private void Start()
		{
			this.Initiate();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0001BBF4 File Offset: 0x00019DF4
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight)
		{
			switch (type)
			{
			case InteractionObject.WeightCurve.Type.PositionWeight:
				solver.GetEffector(effector).positionWeight = Mathf.Lerp(solver.GetEffector(effector).positionWeight, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.RotationWeight:
				solver.GetEffector(effector).rotationWeight = Mathf.Lerp(solver.GetEffector(effector).rotationWeight, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetX:
			{
				Vector3 a = ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.right * value;
				solver.GetEffector(effector).position += a * weight;
				return;
			}
			case InteractionObject.WeightCurve.Type.PositionOffsetY:
			{
				Vector3 a2 = ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.up * value;
				solver.GetEffector(effector).position += a2 * weight;
				return;
			}
			case InteractionObject.WeightCurve.Type.PositionOffsetZ:
			{
				Vector3 a3 = ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : solver.GetRoot().rotation) * Vector3.forward * value;
				solver.GetEffector(effector).position += a3 * weight;
				return;
			}
			case InteractionObject.WeightCurve.Type.Pull:
				solver.GetChain(effector).pull = Mathf.Lerp(solver.GetChain(effector).pull, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.Reach:
				solver.GetChain(effector).reach = Mathf.Lerp(solver.GetChain(effector).reach, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.RotateBoneWeight:
			case InteractionObject.WeightCurve.Type.PoserWeight:
				return;
			case InteractionObject.WeightCurve.Type.Push:
				solver.GetChain(effector).push = Mathf.Lerp(solver.GetChain(effector).push, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.PushParent:
				solver.GetChain(effector).pushParent = Mathf.Lerp(solver.GetChain(effector).pushParent, value, weight);
				return;
			case InteractionObject.WeightCurve.Type.BendGoalWeight:
				solver.GetChain(effector).bendConstraint.weight = Mathf.Lerp(solver.GetChain(effector).bendConstraint.weight, value, weight);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001BE38 File Offset: 0x0001A038
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			for (int i = 0; i < this.targets.Length; i++)
			{
				if (this.targets[i].effectorType == effectorType)
				{
					return this.targets[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001BE7C File Offset: 0x0001A07C
		private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].type == weightCurveType)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType)
		{
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == weightCurveType)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0400031A RID: 794
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		// Token: 0x0400031B RID: 795
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		// Token: 0x0400031C RID: 796
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		// Token: 0x0400031D RID: 797
		public InteractionObject.WeightCurve[] weightCurves;

		// Token: 0x0400031E RID: 798
		public InteractionObject.Multiplier[] multipliers;

		// Token: 0x0400031F RID: 799
		public InteractionObject.InteractionEvent[] events;

		// Token: 0x04000322 RID: 802
		private InteractionTarget[] targets = new InteractionTarget[0];

		// Token: 0x020000F6 RID: 246
		[Serializable]
		public class InteractionEvent
		{
			// Token: 0x06000784 RID: 1924 RVA: 0x00032AF0 File Offset: 0x00030CF0
			public void Activate(Transform t)
			{
				this.unityEvent.Invoke();
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Activate(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].Send(t);
				}
			}

			// Token: 0x04000773 RID: 1907
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			// Token: 0x04000774 RID: 1908
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			// Token: 0x04000775 RID: 1909
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			// Token: 0x04000776 RID: 1910
			[Tooltip("The animations called on this event.")]
			public InteractionObject.AnimatorEvent[] animations;

			// Token: 0x04000777 RID: 1911
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public InteractionObject.Message[] messages;

			// Token: 0x04000778 RID: 1912
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;
		}

		// Token: 0x020000F7 RID: 247
		[Serializable]
		public class Message
		{
			// Token: 0x06000786 RID: 1926 RVA: 0x00032B54 File Offset: 0x00030D54
			public void Send(Transform t)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "")
				{
					return;
				}
				this.recipient.SendMessage(this.function, t, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x04000779 RID: 1913
			[Tooltip("The name of the function called.")]
			public string function;

			// Token: 0x0400077A RID: 1914
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			// Token: 0x0400077B RID: 1915
			private const string empty = "";
		}

		// Token: 0x020000F8 RID: 248
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x06000788 RID: 1928 RVA: 0x00032BB0 File Offset: 0x00030DB0
			public void Activate(bool pickUp)
			{
				if (this.animator != null)
				{
					if (pickUp)
					{
						this.animator.applyRootMotion = false;
					}
					this.Activate(this.animator);
				}
				if (this.animation != null)
				{
					this.Activate(this.animation);
				}
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x00032C00 File Offset: 0x00030E00
			private void Activate(Animator animator)
			{
				if (this.animationState == "")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					animator.CrossFade(this.animationState, this.crossfadeTime, this.layer, 0f);
					return;
				}
				animator.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x00032C60 File Offset: 0x00030E60
			private void Activate(Animation animation)
			{
				if (this.animationState == "")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					animation[this.animationState].normalizedTime = 0f;
				}
				animation[this.animationState].layer = this.layer;
				animation.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0400077C RID: 1916
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			// Token: 0x0400077D RID: 1917
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			// Token: 0x0400077E RID: 1918
			[Tooltip("The name of the animation state.")]
			public string animationState;

			// Token: 0x0400077F RID: 1919
			[Tooltip("The crossfading time.")]
			public float crossfadeTime = 0.3f;

			// Token: 0x04000780 RID: 1920
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			// Token: 0x04000781 RID: 1921
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			// Token: 0x04000782 RID: 1922
			private const string empty = "";
		}

		// Token: 0x020000F9 RID: 249
		[Serializable]
		public class WeightCurve
		{
			// Token: 0x0600078C RID: 1932 RVA: 0x00032CDA File Offset: 0x00030EDA
			public float GetValue(float timer)
			{
				return this.curve.Evaluate(timer);
			}

			// Token: 0x04000783 RID: 1923
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type type;

			// Token: 0x04000784 RID: 1924
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			// Token: 0x02000138 RID: 312
			[Serializable]
			public enum Type
			{
				// Token: 0x040008B4 RID: 2228
				PositionWeight,
				// Token: 0x040008B5 RID: 2229
				RotationWeight,
				// Token: 0x040008B6 RID: 2230
				PositionOffsetX,
				// Token: 0x040008B7 RID: 2231
				PositionOffsetY,
				// Token: 0x040008B8 RID: 2232
				PositionOffsetZ,
				// Token: 0x040008B9 RID: 2233
				Pull,
				// Token: 0x040008BA RID: 2234
				Reach,
				// Token: 0x040008BB RID: 2235
				RotateBoneWeight,
				// Token: 0x040008BC RID: 2236
				Push,
				// Token: 0x040008BD RID: 2237
				PushParent,
				// Token: 0x040008BE RID: 2238
				PoserWeight,
				// Token: 0x040008BF RID: 2239
				BendGoalWeight
			}
		}

		// Token: 0x020000FA RID: 250
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0600078E RID: 1934 RVA: 0x00032CF0 File Offset: 0x00030EF0
			public float GetValue(InteractionObject.WeightCurve weightCurve, float timer)
			{
				return weightCurve.GetValue(timer) * this.multiplier;
			}

			// Token: 0x04000785 RID: 1925
			[Tooltip("The curve type to multiply.")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x04000786 RID: 1926
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier = 1f;

			// Token: 0x04000787 RID: 1927
			[Tooltip("The resulting value will be applied to this channel.")]
			public InteractionObject.WeightCurve.Type result;
		}
	}
}
