using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x02000065 RID: 101
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x0001BEF7 File Offset: 0x0001A0F7
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001BF03 File Offset: 0x0001A103
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_system.html");
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001BF0F File Offset: 0x0001A10F
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001BF1B File Offset: 0x0001A11B
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001BF27 File Offset: 0x0001A127
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001BF33 File Offset: 0x0001A133
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001BF3F File Offset: 0x0001A13F
		[ContextMenu("Support")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001BF4B File Offset: 0x0001A14B
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0001BF58 File Offset: 0x0001A158
		public bool inInteraction
		{
			get
			{
				if (!this.IsValid(true))
				{
					return false;
				}
				for (int i = 0; i < this.interactionEffectors.Length; i++)
				{
					if (this.interactionEffectors[i].inInteraction && !this.interactionEffectors[i].isPaused)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].inInteraction && !this.interactionEffectors[i].isPaused;
				}
			}
			return false;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0001C004 File Offset: 0x0001A204
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].inInteraction && this.interactionEffectors[i].isPaused;
				}
			}
			return false;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001C060 File Offset: 0x0001A260
		public bool IsPaused()
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].inInteraction && this.interactionEffectors[i].isPaused)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		public bool IsInSync()
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].isPaused)
				{
					for (int j = 0; j < this.interactionEffectors.Length; j++)
					{
						if (j != i && this.interactionEffectors[j].inInteraction && !this.interactionEffectors[j].isPaused)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001C120 File Offset: 0x0001A320
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			if (interactionObject == null)
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].Start(interactionObject, this.targetTag, this.fadeInTime, interrupt);
				}
			}
			return false;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001C184 File Offset: 0x0001A384
		public bool StartInteractionWithClosestTarget(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			if (interactionObject == null)
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType && this.GetClosestTargetIndex(effectorType, interactionObject) != -1)
				{
					return this.interactionEffectors[i].Start(interactionObject, interactionObject.GetTargets()[i], this.fadeInTime, interrupt);
				}
			}
			return false;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		private int GetClosestTargetIndex(FullBodyBipedEffector effectorType, InteractionObject obj)
		{
			int result = -1;
			float num = float.PositiveInfinity;
			Quaternion rotation = this.ik.solver.GetEffector(effectorType).bone.rotation;
			for (int i = 0; i < obj.GetTargets().Length; i++)
			{
				float num2 = Quaternion.Angle(rotation, obj.GetTargets()[i].transform.rotation);
				if (num2 < num)
				{
					num = num2;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001C260 File Offset: 0x0001A460
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			if (interactionObject == null)
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].Start(interactionObject, target, this.fadeInTime, interrupt);
				}
			}
			return false;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].Pause();
				}
			}
			return false;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001C30C File Offset: 0x0001A50C
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].Resume();
				}
			}
			return false;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001C358 File Offset: 0x0001A558
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].Stop();
				}
			}
			return false;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		public void PauseAll()
		{
			if (!this.IsValid(true))
			{
				return;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].Pause();
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		public void ResumeAll()
		{
			if (!this.IsValid(true))
			{
				return;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].Resume();
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001C414 File Offset: 0x0001A614
		public void StopAll()
		{
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].Stop();
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001C444 File Offset: 0x0001A644
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return null;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].interactionObject;
				}
			}
			return null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001C490 File Offset: 0x0001A690
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			if (!this.IsValid(true))
			{
				return 0f;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].effectorType == effectorType)
				{
					return this.interactionEffectors[i].progress;
				}
			}
			return 0f;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		public float GetMinActiveProgress()
		{
			if (!this.IsValid(true))
			{
				return 0f;
			}
			float num = 1f;
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				if (this.interactionEffectors[i].inInteraction)
				{
					float progress = this.interactionEffectors[i].progress;
					if (progress > 0f && progress < num)
					{
						num = progress;
					}
				}
			}
			return num;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001C548 File Offset: 0x0001A748
		public bool TriggerInteraction(int index, bool interrupt)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			if (!this.TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.triggersInRange[index].ranges[this.bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					if (!this.StartInteraction(range.interactions[i].effectors[j], range.interactions[i].interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			interactionObject = null;
			if (!this.IsValid(true))
			{
				return false;
			}
			if (!this.TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.triggersInRange[index].ranges[this.bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					interactionObject = range.interactions[i].interactionObject;
					if (!this.StartInteraction(range.interactions[i].effectors[j], interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001C684 File Offset: 0x0001A884
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			interactionTarget = null;
			if (!this.IsValid(true))
			{
				return false;
			}
			if (!this.TriggerIndexIsValid(index))
			{
				return false;
			}
			bool result = true;
			InteractionTrigger.Range range = this.triggersInRange[index].ranges[this.bestRangeIndexes[index]];
			for (int i = 0; i < range.interactions.Length; i++)
			{
				for (int j = 0; j < range.interactions[i].effectors.Length; j++)
				{
					InteractionObject interactionObject = range.interactions[i].interactionObject;
					Transform target = interactionObject.GetTarget(range.interactions[i].effectors[j], base.tag);
					if (target != null)
					{
						interactionTarget = target.GetComponent<InteractionTarget>();
					}
					if (!this.StartInteraction(range.interactions[i].effectors[j], interactionObject, interrupt))
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001C758 File Offset: 0x0001A958
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			if (!this.IsValid(true))
			{
				return null;
			}
			int closestTriggerIndex = this.GetClosestTriggerIndex();
			if (closestTriggerIndex < 0 || closestTriggerIndex >= this.triggersInRange.Count)
			{
				return null;
			}
			return this.triggersInRange[closestTriggerIndex].ranges[this.bestRangeIndexes[closestTriggerIndex]];
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001C7AC File Offset: 0x0001A9AC
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return null;
			}
			return closestInteractionRange.interactions[0].interactionObject.GetTarget(closestInteractionRange.interactions[0].effectors[0], this);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001C810 File Offset: 0x0001AA10
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionObject[0];
			}
			InteractionObject[] array = new InteractionObject[closestInteractionRange.interactions.Length];
			for (int i = 0; i < closestInteractionRange.interactions.Length; i++)
			{
				array[i] = closestInteractionRange.interactions[i].interactionObject;
			}
			return array;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001C860 File Offset: 0x0001AA60
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			InteractionTrigger.Range closestInteractionRange = this.GetClosestInteractionRange();
			if (closestInteractionRange == null)
			{
				return new InteractionTarget[0];
			}
			List<InteractionTarget> list = new List<InteractionTarget>();
			foreach (InteractionTrigger.Range.Interaction interaction in closestInteractionRange.interactions)
			{
				foreach (FullBodyBipedEffector effectorType in interaction.effectors)
				{
					list.Add(interaction.interactionObject.GetTarget(effectorType, this));
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001C8DC File Offset: 0x0001AADC
		public bool TriggerEffectorsReady(int index)
		{
			if (!this.IsValid(true))
			{
				return false;
			}
			if (!this.TriggerIndexIsValid(index))
			{
				return false;
			}
			for (int i = 0; i < this.triggersInRange[index].ranges.Length; i++)
			{
				InteractionTrigger.Range range = this.triggersInRange[index].ranges[i];
				for (int j = 0; j < range.interactions.Length; j++)
				{
					for (int k = 0; k < range.interactions[j].effectors.Length; k++)
					{
						if (this.IsInInteraction(range.interactions[j].effectors[k]))
						{
							return false;
						}
					}
				}
				for (int l = 0; l < range.interactions.Length; l++)
				{
					for (int m = 0; m < range.interactions[l].effectors.Length; m++)
					{
						if (this.IsPaused(range.interactions[l].effectors[m]))
						{
							for (int n = 0; n < range.interactions[l].effectors.Length; n++)
							{
								if (n != m && !this.IsPaused(range.interactions[l].effectors[n]))
								{
									return false;
								}
							}
						}
					}
				}
			}
			return true;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001CA10 File Offset: 0x0001AC10
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			if (!this.IsValid(true))
			{
				return null;
			}
			if (index < 0 || index >= this.bestRangeIndexes.Count)
			{
				Warning.Log("Index out of range.", base.transform, false);
				return null;
			}
			return this.triggersInRange[index].ranges[this.bestRangeIndexes[index]];
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		public int GetClosestTriggerIndex()
		{
			if (!this.IsValid(true))
			{
				return -1;
			}
			if (this.triggersInRange.Count == 0)
			{
				return -1;
			}
			if (this.triggersInRange.Count == 1)
			{
				return 0;
			}
			int result = -1;
			float num = float.PositiveInfinity;
			for (int i = 0; i < this.triggersInRange.Count; i++)
			{
				if (this.triggersInRange[i] != null)
				{
					float num2 = Vector3.SqrMagnitude(this.triggersInRange[i].transform.position - base.transform.position);
					if (num2 < num)
					{
						result = i;
						num = num2;
					}
				}
			}
			return result;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001CB0C File Offset: 0x0001AD0C
		public void StoreDefaults()
		{
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].StoreDefaults();
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001CB39 File Offset: 0x0001AD39
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0001CB41 File Offset: 0x0001AD41
		public FullBodyBipedIK ik
		{
			get
			{
				return this.fullBody;
			}
			set
			{
				this.fullBody = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001CB4A File Offset: 0x0001AD4A
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0001CB52 File Offset: 0x0001AD52
		public List<InteractionTrigger> triggersInRange { get; private set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001CB5B File Offset: 0x0001AD5B
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0001CB63 File Offset: 0x0001AD63
		public bool initiated { get; private set; }

		// Token: 0x06000433 RID: 1075 RVA: 0x0001CB6C File Offset: 0x0001AD6C
		public void Start()
		{
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.fullBody == null)
			{
				Warning.Log("InteractionSystem can not find a FullBodyBipedIK component", base.transform, false);
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnPreFBBIK));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostFBBIK));
			IKSolverFullBodyBiped solver3 = this.fullBody.solver;
			solver3.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Combine(solver3.OnFixTransforms, new IKSolver.UpdateDelegate(this.OnFixTransforms));
			this.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Combine(this.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.LookAtInteraction));
			this.OnInteractionPause = (InteractionSystem.InteractionDelegate)Delegate.Combine(this.OnInteractionPause, new InteractionSystem.InteractionDelegate(this.InteractionPause));
			this.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Combine(this.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.InteractionResume));
			this.OnInteractionStop = (InteractionSystem.InteractionDelegate)Delegate.Combine(this.OnInteractionStop, new InteractionSystem.InteractionDelegate(this.InteractionStop));
			InteractionEffector[] array = this.interactionEffectors;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(this);
			}
			this.triggersInRange = new List<InteractionTrigger>();
			this.c = base.GetComponent<Collider>();
			this.UpdateTriggerEventBroadcasting();
			this.initiated = true;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001CD01 File Offset: 0x0001AF01
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			this.lookAt.isPaused = true;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001CD0F File Offset: 0x0001AF0F
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001CD1D File Offset: 0x0001AF1D
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			this.lookAt.isPaused = false;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001CD2B File Offset: 0x0001AF2B
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
			this.lookAt.Look(interactionObject.lookAtTarget, Time.time + interactionObject.length * 0.5f);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0001CD50 File Offset: 0x0001AF50
		public void OnTriggerEnter(Collider c)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = c.GetComponent<InteractionTrigger>();
			if (component == null)
			{
				return;
			}
			if (this.inContact.Contains(component))
			{
				return;
			}
			this.inContact.Add(component);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001CD98 File Offset: 0x0001AF98
		public void OnTriggerExit(Collider c)
		{
			if (this.fullBody == null)
			{
				return;
			}
			InteractionTrigger component = c.GetComponent<InteractionTrigger>();
			if (component == null)
			{
				return;
			}
			this.inContact.Remove(component);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001CDD4 File Offset: 0x0001AFD4
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			bestRangeIndex = -1;
			if (!this.IsValid(true))
			{
				return false;
			}
			if (index < 0 || index >= this.inContact.Count)
			{
				Warning.Log("Index out of range.", base.transform, false);
				return false;
			}
			if (this.inContact[index] == null)
			{
				Warning.Log("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform, false);
				return false;
			}
			bestRangeIndex = this.inContact[index].GetBestRangeIndex(base.transform, this.FPSCamera, this.raycastHit);
			return bestRangeIndex != -1;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001CE68 File Offset: 0x0001B068
		private void OnDrawGizmosSelected()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.fullBody == null)
			{
				this.fullBody = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.characterCollider == null)
			{
				this.characterCollider = base.GetComponent<Collider>();
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
		public void Update()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.UpdateTriggerEventBroadcasting();
			this.Raycasting();
			this.triggersInRange.Clear();
			this.bestRangeIndexes.Clear();
			for (int i = 0; i < this.inContact.Count; i++)
			{
				int item = -1;
				if (this.inContact[i] != null && this.inContact[i].gameObject.activeInHierarchy && this.ContactIsInRange(i, out item))
				{
					this.triggersInRange.Add(this.inContact[i]);
					this.bestRangeIndexes.Add(item);
				}
			}
			this.lookAt.Update();
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0001CF64 File Offset: 0x0001B164
		private void Raycasting()
		{
			if (this.camRaycastLayers == -1)
			{
				return;
			}
			if (this.FPSCamera == null)
			{
				return;
			}
			Physics.Raycast(this.FPSCamera.position, this.FPSCamera.forward, out this.raycastHit, this.camRaycastDistance, this.camRaycastLayers);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
		private void UpdateTriggerEventBroadcasting()
		{
			if (this.characterCollider == null)
			{
				this.characterCollider = this.c;
			}
			if (this.characterCollider != null && this.characterCollider != this.c)
			{
				if (this.characterCollider.GetComponent<TriggerEventBroadcaster>() == null)
				{
					this.characterCollider.gameObject.AddComponent<TriggerEventBroadcaster>().target = base.gameObject;
				}
				if (this.lastCollider != null && this.lastCollider != this.c && this.lastCollider != this.characterCollider)
				{
					TriggerEventBroadcaster component = this.lastCollider.GetComponent<TriggerEventBroadcaster>();
					if (component != null)
					{
						Object.Destroy(component);
					}
				}
			}
			this.lastCollider = this.characterCollider;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001D098 File Offset: 0x0001B298
		private void OnEnable()
		{
			this.lastTime = Time.time;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001D0A8 File Offset: 0x0001B2A8
		private void UpdateEffectors()
		{
			if (this.fullBody == null)
			{
				return;
			}
			float deltaTime = Time.time - this.lastTime;
			this.lastTime = Time.time;
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].Update(base.transform, this.speed, deltaTime);
			}
			for (int j = 0; j < this.interactionEffectors.Length; j++)
			{
				this.interactionEffectors[j].ResetToDefaults(this.resetToDefaultsSpeed * this.speed, deltaTime);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001D138 File Offset: 0x0001B338
		private void OnPreFBBIK()
		{
			if (this.fullBody == null)
			{
				return;
			}
			this.lookAt.SolveSpine();
			this.UpdateEffectors();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001D15C File Offset: 0x0001B35C
		private void OnPostFBBIK()
		{
			if (this.fullBody == null)
			{
				return;
			}
			for (int i = 0; i < this.interactionEffectors.Length; i++)
			{
				this.interactionEffectors[i].OnPostFBBIK();
			}
			this.lookAt.SolveHead();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001D1A3 File Offset: 0x0001B3A3
		private void OnFixTransforms()
		{
			this.lookAt.OnFixTransforms();
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
		private void OnDestroy()
		{
			if (this.fullBody == null)
			{
				return;
			}
			IKSolverFullBodyBiped solver = this.fullBody.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnPreFBBIK));
			IKSolverFullBodyBiped solver2 = this.fullBody.solver;
			solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostFBBIK));
			IKSolverFullBodyBiped solver3 = this.fullBody.solver;
			solver3.OnFixTransforms = (IKSolver.UpdateDelegate)Delegate.Remove(solver3.OnFixTransforms, new IKSolver.UpdateDelegate(this.OnFixTransforms));
			this.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Remove(this.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.LookAtInteraction));
			this.OnInteractionPause = (InteractionSystem.InteractionDelegate)Delegate.Remove(this.OnInteractionPause, new InteractionSystem.InteractionDelegate(this.InteractionPause));
			this.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Remove(this.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.InteractionResume));
			this.OnInteractionStop = (InteractionSystem.InteractionDelegate)Delegate.Remove(this.OnInteractionStop, new InteractionSystem.InteractionDelegate(this.InteractionStop));
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001D2D8 File Offset: 0x0001B4D8
		private bool IsValid(bool log)
		{
			if (this.fullBody == null)
			{
				if (log)
				{
					Warning.Log("FBBIK is null. Will not update the InteractionSystem", base.transform, false);
				}
				return false;
			}
			if (!this.initiated)
			{
				if (log)
				{
					Warning.Log("The InteractionSystem has not been initiated yet.", base.transform, false);
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001D328 File Offset: 0x0001B528
		private bool TriggerIndexIsValid(int index)
		{
			if (index < 0 || index >= this.triggersInRange.Count)
			{
				Warning.Log("Index out of range.", base.transform, false);
				return false;
			}
			if (this.triggersInRange[index] == null)
			{
				Warning.Log("The InteractionTrigger in the list 'inContact' has been destroyed", base.transform, false);
				return false;
			}
			return true;
		}

		// Token: 0x04000323 RID: 803
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag = "";

		// Token: 0x04000324 RID: 804
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime = 0.3f;

		// Token: 0x04000325 RID: 805
		[Tooltip("The master speed for all interactions.")]
		public float speed = 1f;

		// Token: 0x04000326 RID: 806
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed = 1f;

		// Token: 0x04000327 RID: 807
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		// Token: 0x04000328 RID: 808
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		// Token: 0x04000329 RID: 809
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		// Token: 0x0400032A RID: 810
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance = 1f;

		// Token: 0x0400032C RID: 812
		private List<InteractionTrigger> inContact = new List<InteractionTrigger>();

		// Token: 0x0400032D RID: 813
		private List<int> bestRangeIndexes = new List<int>();

		// Token: 0x0400032E RID: 814
		public InteractionSystem.InteractionDelegate OnInteractionStart;

		// Token: 0x0400032F RID: 815
		public InteractionSystem.InteractionDelegate OnInteractionPause;

		// Token: 0x04000330 RID: 816
		public InteractionSystem.InteractionDelegate OnInteractionPickUp;

		// Token: 0x04000331 RID: 817
		public InteractionSystem.InteractionDelegate OnInteractionResume;

		// Token: 0x04000332 RID: 818
		public InteractionSystem.InteractionDelegate OnInteractionStop;

		// Token: 0x04000333 RID: 819
		public InteractionSystem.InteractionEventDelegate OnInteractionEvent;

		// Token: 0x04000334 RID: 820
		public RaycastHit raycastHit;

		// Token: 0x04000335 RID: 821
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		// Token: 0x04000336 RID: 822
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt = new InteractionLookAt();

		// Token: 0x04000337 RID: 823
		private InteractionEffector[] interactionEffectors = new InteractionEffector[]
		{
			new InteractionEffector(FullBodyBipedEffector.Body),
			new InteractionEffector(FullBodyBipedEffector.LeftFoot),
			new InteractionEffector(FullBodyBipedEffector.LeftHand),
			new InteractionEffector(FullBodyBipedEffector.LeftShoulder),
			new InteractionEffector(FullBodyBipedEffector.LeftThigh),
			new InteractionEffector(FullBodyBipedEffector.RightFoot),
			new InteractionEffector(FullBodyBipedEffector.RightHand),
			new InteractionEffector(FullBodyBipedEffector.RightShoulder),
			new InteractionEffector(FullBodyBipedEffector.RightThigh)
		};

		// Token: 0x04000339 RID: 825
		private Collider lastCollider;

		// Token: 0x0400033A RID: 826
		private Collider c;

		// Token: 0x0400033B RID: 827
		private float lastTime;

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x06000791 RID: 1937
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x06000795 RID: 1941
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);
	}
}
