using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000076 RID: 118
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001FA8A File Offset: 0x0001DC8A
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0001FA92 File Offset: 0x0001DC92
		public IK ik { get; private set; }

		// Token: 0x060004CF RID: 1231 RVA: 0x0001FA9C File Offset: 0x0001DC9C
		private void OnEnable()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponent<IK>();
			}
			if (this.ik == null)
			{
				Debug.LogError("EditorIK needs to have an IK component on the same GameObject.", base.transform);
				return;
			}
			if (this.bones.Length == 0)
			{
				this.bones = this.ik.transform.GetComponentsInChildren<Transform>();
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001FB0C File Offset: 0x0001DD0C
		private void OnDisable()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.defaultPose != null && this.defaultPose.poseStored)
			{
				this.defaultPose.Restore(this.bones);
			}
			if (this.ik != null)
			{
				this.ik.GetIKSolver().executedInEditor = false;
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001FB70 File Offset: 0x0001DD70
		private void OnDestroy()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			if (this.bones.Length == 0)
			{
				this.bones = this.ik.transform.GetComponentsInChildren<Transform>();
			}
			if (this.defaultPose != null && this.defaultPose.poseStored && this.bones.Length != 0)
			{
				this.defaultPose.Restore(this.bones);
			}
			this.ik.GetIKSolver().executedInEditor = false;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0001FBFA File Offset: 0x0001DDFA
		public void StoreDefaultPose()
		{
			this.bones = this.ik.transform.GetComponentsInChildren<Transform>();
			this.defaultPose.Store(this.bones);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001FC24 File Offset: 0x0001DE24
		public bool Initiate()
		{
			if (this.defaultPose == null)
			{
				return false;
			}
			if (!this.defaultPose.poseStored)
			{
				return false;
			}
			if (this.bones.Length == 0)
			{
				return false;
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponent<IK>();
			}
			if (this.ik == null)
			{
				Debug.LogError("EditorIK can not find an IK component.", base.transform);
				return false;
			}
			this.defaultPose.Restore(this.bones);
			this.ik.GetIKSolver().executedInEditor = false;
			this.ik.GetIKSolver().Initiate(this.ik.transform);
			this.ik.GetIKSolver().executedInEditor = true;
			return true;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
		public void Update()
		{
			if (Application.isPlaying)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			if (!this.ik.enabled)
			{
				return;
			}
			if (!this.ik.GetIKSolver().executedInEditor)
			{
				return;
			}
			if (this.bones.Length == 0)
			{
				this.bones = this.ik.transform.GetComponentsInChildren<Transform>();
			}
			if (this.bones.Length == 0)
			{
				return;
			}
			if (!this.defaultPose.Restore(this.bones))
			{
				return;
			}
			this.ik.GetIKSolver().executedInEditor = false;
			if (!this.ik.GetIKSolver().initiated)
			{
				this.ik.GetIKSolver().Initiate(this.ik.transform);
			}
			if (!this.ik.GetIKSolver().initiated)
			{
				return;
			}
			this.ik.GetIKSolver().executedInEditor = true;
			if (this.animator != null && this.animator.runtimeAnimatorController != null)
			{
				this.animator.Update(Time.deltaTime);
			}
			this.ik.GetIKSolver().Update();
		}

		// Token: 0x040003A3 RID: 931
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		// Token: 0x040003A4 RID: 932
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		// Token: 0x040003A5 RID: 933
		[HideInInspector]
		public Transform[] bones = new Transform[0];
	}
}
