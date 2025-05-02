using System;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000062 RID: 98
	[Serializable]
	public class InteractionEffector
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001A38D File Offset: 0x0001858D
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0001A395 File Offset: 0x00018595
		public FullBodyBipedEffector effectorType { get; private set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001A39E File Offset: 0x0001859E
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0001A3A6 File Offset: 0x000185A6
		public bool isPaused { get; private set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001A3AF File Offset: 0x000185AF
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0001A3B7 File Offset: 0x000185B7
		public InteractionObject interactionObject { get; private set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001A3C0 File Offset: 0x000185C0
		public bool inInteraction
		{
			get
			{
				return this.interactionObject != null;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001A3CE File Offset: 0x000185CE
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
			this.effectorType = effectorType;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001A3E8 File Offset: 0x000185E8
		public void Initiate(InteractionSystem interactionSystem)
		{
			this.interactionSystem = interactionSystem;
			this.effector = interactionSystem.ik.solver.GetEffector(this.effectorType);
			this.poser = this.effector.bone.GetComponent<Poser>();
			this.StoreDefaults();
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001A434 File Offset: 0x00018634
		public void StoreDefaults()
		{
			if (this.interactionSystem == null)
			{
				return;
			}
			this.defaultPositionWeight = this.interactionSystem.ik.solver.GetEffector(this.effectorType).positionWeight;
			this.defaultRotationWeight = this.interactionSystem.ik.solver.GetEffector(this.effectorType).rotationWeight;
			this.defaultPoserWeight = ((this.poser != null) ? this.poser.weight : 0f);
			this.defaultPull = this.interactionSystem.ik.solver.GetChain(this.effectorType).pull;
			this.defaultReach = this.interactionSystem.ik.solver.GetChain(this.effectorType).reach;
			this.defaultPush = this.interactionSystem.ik.solver.GetChain(this.effectorType).push;
			this.defaultPushParent = this.interactionSystem.ik.solver.GetChain(this.effectorType).pushParent;
			this.defaultBendGoalWeight = this.interactionSystem.ik.solver.GetChain(this.effectorType).bendConstraint.weight;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001A588 File Offset: 0x00018788
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			if (this.inInteraction)
			{
				return false;
			}
			if (this.isPaused)
			{
				return false;
			}
			if (this.defaults)
			{
				return false;
			}
			this.resetTimer = Mathf.MoveTowards(this.resetTimer, 0f, deltaTime * speed);
			if (this.effector.isEndEffector)
			{
				if (this.pullUsed)
				{
					this.interactionSystem.ik.solver.GetChain(this.effectorType).pull = Mathf.Lerp(this.defaultPull, this.interactionSystem.ik.solver.GetChain(this.effectorType).pull, this.resetTimer);
				}
				if (this.reachUsed)
				{
					this.interactionSystem.ik.solver.GetChain(this.effectorType).reach = Mathf.Lerp(this.defaultReach, this.interactionSystem.ik.solver.GetChain(this.effectorType).reach, this.resetTimer);
				}
				if (this.pushUsed)
				{
					this.interactionSystem.ik.solver.GetChain(this.effectorType).push = Mathf.Lerp(this.defaultPush, this.interactionSystem.ik.solver.GetChain(this.effectorType).push, this.resetTimer);
				}
				if (this.pushParentUsed)
				{
					this.interactionSystem.ik.solver.GetChain(this.effectorType).pushParent = Mathf.Lerp(this.defaultPushParent, this.interactionSystem.ik.solver.GetChain(this.effectorType).pushParent, this.resetTimer);
				}
				if (this.bendGoalWeightUsed)
				{
					this.interactionSystem.ik.solver.GetChain(this.effectorType).bendConstraint.weight = Mathf.Lerp(this.defaultBendGoalWeight, this.interactionSystem.ik.solver.GetChain(this.effectorType).bendConstraint.weight, this.resetTimer);
				}
			}
			if (this.positionWeightUsed)
			{
				this.effector.positionWeight = Mathf.Lerp(this.defaultPositionWeight, this.effector.positionWeight, this.resetTimer);
			}
			if (this.rotationWeightUsed)
			{
				this.effector.rotationWeight = Mathf.Lerp(this.defaultRotationWeight, this.effector.rotationWeight, this.resetTimer);
			}
			if (this.resetTimer <= 0f)
			{
				this.pullUsed = false;
				this.reachUsed = false;
				this.pushUsed = false;
				this.pushParentUsed = false;
				this.positionWeightUsed = false;
				this.rotationWeightUsed = false;
				this.bendGoalWeightUsed = false;
				this.poserUsed = false;
				this.defaults = true;
			}
			return true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001A850 File Offset: 0x00018A50
		public bool Pause()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			this.isPaused = true;
			this.pausePositionRelative = this.target.InverseTransformPoint(this.effector.position);
			this.pauseRotationRelative = Quaternion.Inverse(this.target.rotation) * this.effector.rotation;
			if (this.interactionSystem.OnInteractionPause != null)
			{
				this.interactionSystem.OnInteractionPause(this.effectorType, this.interactionObject);
			}
			return true;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0001A8DA File Offset: 0x00018ADA
		public bool Resume()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			this.isPaused = false;
			if (this.interactionSystem.OnInteractionResume != null)
			{
				this.interactionSystem.OnInteractionResume(this.effectorType, this.interactionObject);
			}
			return true;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001A918 File Offset: 0x00018B18
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			InteractionTarget interactionTarget = null;
			this.target = interactionObject.GetTarget(this.effectorType, tag);
			if (this.target != null)
			{
				interactionTarget = this.target.GetComponent<InteractionTarget>();
			}
			return this.Start(interactionObject, interactionTarget, fadeInTime, interrupt);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001A960 File Offset: 0x00018B60
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			this.interactionTarget = interactionTarget;
			if (!this.inInteraction)
			{
				this.effector.position = this.effector.bone.position;
				this.effector.rotation = this.effector.bone.rotation;
			}
			else
			{
				if (!interrupt)
				{
					return false;
				}
				this.defaults = false;
			}
			this.target = ((interactionTarget != null) ? interactionTarget.transform : interactionObject.transform);
			this.interactionObject = interactionObject;
			if (this.interactionSystem.OnInteractionStart != null)
			{
				this.interactionSystem.OnInteractionStart(this.effectorType, interactionObject);
			}
			interactionObject.OnStartInteraction(this.interactionSystem);
			this.triggered.Clear();
			for (int i = 0; i < interactionObject.events.Length; i++)
			{
				this.triggered.Add(false);
			}
			this.positionWeightUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.PositionWeight);
			this.rotationWeightUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.RotationWeight);
			this.pullUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Pull);
			this.reachUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Reach);
			this.pushUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.Push);
			this.pushParentUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.PushParent);
			this.bendGoalWeightUsed = interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.BendGoalWeight);
			this.poserUsed = (this.poser != null && interactionObject.CurveUsed(InteractionObject.WeightCurve.Type.PoserWeight));
			if (this.poser != null && this.poserUsed)
			{
				if (this.poser.poseRoot == null)
				{
					this.poser.weight = 0f;
				}
				if (interactionTarget != null)
				{
					if (interactionTarget.usePoser)
					{
						this.poser.poseRoot = this.target.transform;
					}
				}
				else
				{
					this.poser.poseRoot = null;
				}
				this.poser.AutoMapping();
			}
			if (this.defaults)
			{
				this.StoreDefaults();
			}
			this.timer = 0f;
			this.weight = 0f;
			this.fadeInSpeed = ((fadeInTime > 0f) ? (1f / fadeInTime) : 1000f);
			this.length = interactionObject.length;
			this.isPaused = false;
			this.pickedUp = false;
			this.pickUpPosition = Vector3.zero;
			this.pickUpRotation = Quaternion.identity;
			if (interactionTarget != null)
			{
				interactionTarget.RotateTo(this.effector.bone);
			}
			this.started = true;
			return true;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		public void Update(Transform root, float speed, float deltaTime)
		{
			if (!this.inInteraction)
			{
				if (this.started)
				{
					this.isPaused = false;
					this.pickedUp = false;
					this.defaults = false;
					this.resetTimer = 1f;
					this.started = false;
				}
				return;
			}
			if (this.interactionTarget != null && !this.interactionTarget.rotateOnce)
			{
				this.interactionTarget.RotateTo(this.effector.bone);
			}
			if (this.isPaused)
			{
				if (!this.pickedUp)
				{
					this.effector.position = this.target.TransformPoint(this.pausePositionRelative);
					this.effector.rotation = this.target.rotation * this.pauseRotationRelative;
				}
				this.interactionObject.Apply(this.interactionSystem.ik.solver, this.effectorType, this.interactionTarget, this.timer, this.weight, true);
				return;
			}
			this.timer += deltaTime * speed * ((this.interactionTarget != null) ? this.interactionTarget.interactionSpeedMlp : 1f);
			this.weight = Mathf.Clamp(this.weight + deltaTime * this.fadeInSpeed * speed, 0f, 1f);
			bool flag = false;
			bool flag2 = false;
			this.TriggerUntriggeredEvents(true, out flag, out flag2);
			Vector3 b = this.pickedUp ? this.interactionSystem.transform.TransformPoint(this.pickUpPosition) : this.target.position;
			Quaternion b2 = this.pickedUp ? (this.interactionSystem.transform.rotation * this.pickUpRotation) : this.target.rotation;
			this.effector.position = Vector3.Lerp(this.effector.bone.position, b, this.weight);
			this.effector.rotation = Quaternion.Lerp(this.effector.bone.rotation, b2, this.weight);
			this.interactionObject.Apply(this.interactionSystem.ik.solver, this.effectorType, this.interactionTarget, this.timer, this.weight, false);
			if (flag)
			{
				this.PickUp(root);
			}
			if (flag2)
			{
				this.Pause();
			}
			float value = this.interactionObject.GetValue(InteractionObject.WeightCurve.Type.PoserWeight, this.interactionTarget, this.timer);
			if (this.poser != null && this.poserUsed)
			{
				this.poser.weight = Mathf.Lerp(this.poser.weight, value, this.weight);
			}
			else if (value > 0f)
			{
				Warning.Log(string.Concat(new string[]
				{
					"InteractionObject ",
					this.interactionObject.name,
					" has a curve/multipler for Poser Weight, but the bone of effector ",
					this.effectorType.ToString(),
					" has no HandPoser/GenericPoser attached."
				}), this.effector.bone, false);
			}
			if (this.timer >= this.length)
			{
				this.Stop();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0001AEE7 File Offset: 0x000190E7
		public float progress
		{
			get
			{
				if (!this.inInteraction)
				{
					return 0f;
				}
				if (this.length == 0f)
				{
					return 0f;
				}
				return this.timer / this.length;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001AF18 File Offset: 0x00019118
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
			pickUp = false;
			pause = false;
			for (int i = 0; i < this.triggered.Count; i++)
			{
				if (!this.triggered[i] && (!checkTime || this.interactionObject.events[i].time < this.timer))
				{
					this.interactionObject.events[i].Activate(this.effector.bone);
					if (this.interactionObject.events[i].pickUp)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						pickUp = true;
					}
					if (this.interactionObject.events[i].pause)
					{
						if (this.timer >= this.interactionObject.events[i].time)
						{
							this.timer = this.interactionObject.events[i].time;
						}
						pause = true;
					}
					if (this.interactionSystem.OnInteractionEvent != null)
					{
						this.interactionSystem.OnInteractionEvent(this.effectorType, this.interactionObject, this.interactionObject.events[i]);
					}
					this.triggered[i] = true;
				}
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001B06C File Offset: 0x0001926C
		private void PickUp(Transform root)
		{
			this.pickUpPosition = root.InverseTransformPoint(this.effector.position);
			this.pickUpRotation = Quaternion.Inverse(this.interactionSystem.transform.rotation) * this.effector.rotation;
			this.pickUpOnPostFBBIK = true;
			this.pickedUp = true;
			Rigidbody component = this.interactionObject.targetsRoot.GetComponent<Rigidbody>();
			if (component != null)
			{
				if (!component.isKinematic)
				{
					component.isKinematic = true;
				}
				Collider component2 = root.GetComponent<Collider>();
				if (component2 != null)
				{
					foreach (Collider collider in this.interactionObject.targetsRoot.GetComponentsInChildren<Collider>())
					{
						if (!collider.isTrigger && collider.enabled)
						{
							Physics.IgnoreCollision(component2, collider);
						}
					}
				}
			}
			if (this.interactionSystem.OnInteractionPickUp != null)
			{
				this.interactionSystem.OnInteractionPickUp(this.effectorType, this.interactionObject);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001B16C File Offset: 0x0001936C
		public bool Stop()
		{
			if (!this.inInteraction)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			this.TriggerUntriggeredEvents(false, out flag, out flag2);
			if (this.interactionSystem.OnInteractionStop != null)
			{
				this.interactionSystem.OnInteractionStop(this.effectorType, this.interactionObject);
			}
			if (this.interactionTarget != null)
			{
				this.interactionTarget.ResetRotation();
			}
			this.interactionObject = null;
			this.weight = 0f;
			this.timer = 0f;
			this.isPaused = false;
			this.target = null;
			this.defaults = false;
			this.resetTimer = 1f;
			this.pickedUp = false;
			this.started = false;
			return true;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001B220 File Offset: 0x00019420
		public void OnPostFBBIK()
		{
			if (!this.inInteraction)
			{
				return;
			}
			float num = this.interactionObject.GetValue(InteractionObject.WeightCurve.Type.RotateBoneWeight, this.interactionTarget, this.timer) * this.weight;
			if (num > 0f)
			{
				Quaternion b = this.pickedUp ? (this.interactionSystem.transform.rotation * this.pickUpRotation) : this.effector.rotation;
				Quaternion rhs = Quaternion.Slerp(this.effector.bone.rotation, b, num * num);
				this.effector.bone.localRotation = Quaternion.Inverse(this.effector.bone.parent.rotation) * rhs;
			}
			if (this.pickUpOnPostFBBIK)
			{
				Vector3 position = this.effector.bone.position;
				this.effector.bone.position = this.interactionSystem.transform.TransformPoint(this.pickUpPosition);
				this.interactionObject.targetsRoot.parent = this.effector.bone;
				this.effector.bone.position = position;
				this.pickUpOnPostFBBIK = false;
			}
		}

		// Token: 0x040002EF RID: 751
		private Poser poser;

		// Token: 0x040002F0 RID: 752
		private IKEffector effector;

		// Token: 0x040002F1 RID: 753
		private float timer;

		// Token: 0x040002F2 RID: 754
		private float length;

		// Token: 0x040002F3 RID: 755
		private float weight;

		// Token: 0x040002F4 RID: 756
		private float fadeInSpeed;

		// Token: 0x040002F5 RID: 757
		private float defaultPositionWeight;

		// Token: 0x040002F6 RID: 758
		private float defaultRotationWeight;

		// Token: 0x040002F7 RID: 759
		private float defaultPull;

		// Token: 0x040002F8 RID: 760
		private float defaultReach;

		// Token: 0x040002F9 RID: 761
		private float defaultPush;

		// Token: 0x040002FA RID: 762
		private float defaultPushParent;

		// Token: 0x040002FB RID: 763
		private float defaultBendGoalWeight;

		// Token: 0x040002FC RID: 764
		private float defaultPoserWeight;

		// Token: 0x040002FD RID: 765
		private float resetTimer;

		// Token: 0x040002FE RID: 766
		private bool positionWeightUsed;

		// Token: 0x040002FF RID: 767
		private bool rotationWeightUsed;

		// Token: 0x04000300 RID: 768
		private bool pullUsed;

		// Token: 0x04000301 RID: 769
		private bool reachUsed;

		// Token: 0x04000302 RID: 770
		private bool pushUsed;

		// Token: 0x04000303 RID: 771
		private bool pushParentUsed;

		// Token: 0x04000304 RID: 772
		private bool bendGoalWeightUsed;

		// Token: 0x04000305 RID: 773
		private bool poserUsed;

		// Token: 0x04000306 RID: 774
		private bool pickedUp;

		// Token: 0x04000307 RID: 775
		private bool defaults;

		// Token: 0x04000308 RID: 776
		private bool pickUpOnPostFBBIK;

		// Token: 0x04000309 RID: 777
		private Vector3 pickUpPosition;

		// Token: 0x0400030A RID: 778
		private Vector3 pausePositionRelative;

		// Token: 0x0400030B RID: 779
		private Quaternion pickUpRotation;

		// Token: 0x0400030C RID: 780
		private Quaternion pauseRotationRelative;

		// Token: 0x0400030D RID: 781
		private InteractionTarget interactionTarget;

		// Token: 0x0400030E RID: 782
		private Transform target;

		// Token: 0x0400030F RID: 783
		private List<bool> triggered = new List<bool>();

		// Token: 0x04000310 RID: 784
		private InteractionSystem interactionSystem;

		// Token: 0x04000311 RID: 785
		private bool started;
	}
}
