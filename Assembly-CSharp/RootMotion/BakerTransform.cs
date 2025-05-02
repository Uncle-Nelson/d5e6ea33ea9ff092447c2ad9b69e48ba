using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class BakerTransform
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00003744 File Offset: 0x00001944
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
			this.transform = transform;
			this.recordPosition = (recordPosition || isRootNode);
			this.isRootNode = isRootNode;
			this.relativePath = string.Empty;
			this.Reset();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003776 File Offset: 0x00001976
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
			this.relativePosition = position;
			this.relativeRotation = rotation;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003788 File Offset: 0x00001988
		public void SetCurves(ref AnimationClip clip)
		{
			if (this.recordPosition)
			{
				clip.SetCurve(this.relativePath, typeof(Transform), "localPosition.x", this.posX);
				clip.SetCurve(this.relativePath, typeof(Transform), "localPosition.y", this.posY);
				clip.SetCurve(this.relativePath, typeof(Transform), "localPosition.z", this.posZ);
			}
			clip.SetCurve(this.relativePath, typeof(Transform), "localRotation.x", this.rotX);
			clip.SetCurve(this.relativePath, typeof(Transform), "localRotation.y", this.rotY);
			clip.SetCurve(this.relativePath, typeof(Transform), "localRotation.z", this.rotZ);
			clip.SetCurve(this.relativePath, typeof(Transform), "localRotation.w", this.rotW);
			if (this.isRootNode)
			{
				this.AddRootMotionCurves(ref clip);
			}
			clip.EnsureQuaternionContinuity();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000038A4 File Offset: 0x00001AA4
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
			if (this.recordPosition)
			{
				clip.SetCurve("", typeof(Animator), "MotionT.x", this.posX);
				clip.SetCurve("", typeof(Animator), "MotionT.y", this.posY);
				clip.SetCurve("", typeof(Animator), "MotionT.z", this.posZ);
			}
			clip.SetCurve("", typeof(Animator), "MotionQ.x", this.rotX);
			clip.SetCurve("", typeof(Animator), "MotionQ.y", this.rotY);
			clip.SetCurve("", typeof(Animator), "MotionQ.z", this.rotZ);
			clip.SetCurve("", typeof(Animator), "MotionQ.w", this.rotW);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000039A0 File Offset: 0x00001BA0
		public void Reset()
		{
			this.posX = new AnimationCurve();
			this.posY = new AnimationCurve();
			this.posZ = new AnimationCurve();
			this.rotX = new AnimationCurve();
			this.rotY = new AnimationCurve();
			this.rotZ = new AnimationCurve();
			this.rotW = new AnimationCurve();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000039FC File Offset: 0x00001BFC
		public void ReduceKeyframes(float maxError)
		{
			BakerUtilities.ReduceKeyframes(this.rotX, maxError);
			BakerUtilities.ReduceKeyframes(this.rotY, maxError);
			BakerUtilities.ReduceKeyframes(this.rotZ, maxError);
			BakerUtilities.ReduceKeyframes(this.rotW, maxError);
			BakerUtilities.ReduceKeyframes(this.posX, maxError);
			BakerUtilities.ReduceKeyframes(this.posY, maxError);
			BakerUtilities.ReduceKeyframes(this.posZ, maxError);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003A60 File Offset: 0x00001C60
		public void SetKeyframes(float time)
		{
			if (this.recordPosition)
			{
				Vector3 vector = this.transform.localPosition;
				if (this.isRootNode)
				{
					vector = this.transform.position - this.relativePosition;
				}
				this.posX.AddKey(time, vector.x);
				this.posY.AddKey(time, vector.y);
				this.posZ.AddKey(time, vector.z);
			}
			Quaternion quaternion = this.transform.localRotation;
			if (this.isRootNode)
			{
				quaternion = Quaternion.Inverse(this.relativeRotation) * this.transform.rotation;
			}
			this.rotX.AddKey(time, quaternion.x);
			this.rotY.AddKey(time, quaternion.y);
			this.rotZ.AddKey(time, quaternion.z);
			this.rotW.AddKey(time, quaternion.w);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003B58 File Offset: 0x00001D58
		public void AddLoopFrame(float time)
		{
			if (this.recordPosition && !this.isRootNode)
			{
				this.posX.AddKey(time, this.posX.keys[0].value);
				this.posY.AddKey(time, this.posY.keys[0].value);
				this.posZ.AddKey(time, this.posZ.keys[0].value);
			}
			this.rotX.AddKey(time, this.rotX.keys[0].value);
			this.rotY.AddKey(time, this.rotY.keys[0].value);
			this.rotZ.AddKey(time, this.rotZ.keys[0].value);
			this.rotW.AddKey(time, this.rotW.keys[0].value);
		}

		// Token: 0x04000037 RID: 55
		public Transform transform;

		// Token: 0x04000038 RID: 56
		public AnimationCurve posX;

		// Token: 0x04000039 RID: 57
		public AnimationCurve posY;

		// Token: 0x0400003A RID: 58
		public AnimationCurve posZ;

		// Token: 0x0400003B RID: 59
		public AnimationCurve rotX;

		// Token: 0x0400003C RID: 60
		public AnimationCurve rotY;

		// Token: 0x0400003D RID: 61
		public AnimationCurve rotZ;

		// Token: 0x0400003E RID: 62
		public AnimationCurve rotW;

		// Token: 0x0400003F RID: 63
		private string relativePath;

		// Token: 0x04000040 RID: 64
		private bool recordPosition;

		// Token: 0x04000041 RID: 65
		private Vector3 relativePosition;

		// Token: 0x04000042 RID: 66
		private bool isRootNode;

		// Token: 0x04000043 RID: 67
		private Quaternion relativeRotation;
	}
}
