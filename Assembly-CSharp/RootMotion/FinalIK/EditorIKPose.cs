using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000077 RID: 119
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0001FE21 File Offset: 0x0001E021
		public bool poseStored
		{
			get
			{
				return this.localPositions.Length != 0;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001FE30 File Offset: 0x0001E030
		public void Store(Transform[] T)
		{
			this.localPositions = new Vector3[T.Length];
			this.localRotations = new Quaternion[T.Length];
			for (int i = 1; i < T.Length; i++)
			{
				this.localPositions[i] = T[i].localPosition;
				this.localRotations[i] = T[i].localRotation;
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001FE90 File Offset: 0x0001E090
		public bool Restore(Transform[] T)
		{
			if (this.localPositions.Length != T.Length)
			{
				Debug.LogError("Can not restore pose (unmatched bone count). Please stop the solver and click on 'Store Default Pose' if you have made changes to character hierarchy.");
				return false;
			}
			for (int i = 1; i < T.Length; i++)
			{
				T[i].localPosition = this.localPositions[i];
				T[i].localRotation = this.localRotations[i];
			}
			return true;
		}

		// Token: 0x040003A7 RID: 935
		public Vector3[] localPositions = new Vector3[0];

		// Token: 0x040003A8 RID: 936
		public Quaternion[] localRotations = new Quaternion[0];
	}
}
