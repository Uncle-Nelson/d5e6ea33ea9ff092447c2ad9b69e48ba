using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class BakerHumanoidQT
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002C70 File Offset: 0x00000E70
		public BakerHumanoidQT(string name)
		{
			this.Qx = name + "Q.x";
			this.Qy = name + "Q.y";
			this.Qz = name + "Q.z";
			this.Qw = name + "Q.w";
			this.Tx = name + "T.x";
			this.Ty = name + "T.y";
			this.Tz = name + "T.z";
			this.Reset();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002D00 File Offset: 0x00000F00
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
			this.transform = transform;
			this.goal = goal;
			this.Qx = name + "Q.x";
			this.Qy = name + "Q.y";
			this.Qz = name + "Q.z";
			this.Qw = name + "Q.w";
			this.Tx = name + "T.x";
			this.Ty = name + "T.y";
			this.Tz = name + "T.z";
			this.Reset();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D9E File Offset: 0x00000F9E
		public Quaternion EvaluateRotation(float time)
		{
			return new Quaternion(this.rotX.Evaluate(time), this.rotY.Evaluate(time), this.rotZ.Evaluate(time), this.rotW.Evaluate(time));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002DD5 File Offset: 0x00000FD5
		public Vector3 EvaluatePosition(float time)
		{
			return new Vector3(this.posX.Evaluate(time), this.posY.Evaluate(time), this.posZ.Evaluate(time));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002E00 File Offset: 0x00001000
		public TQ Evaluate(float time)
		{
			return new TQ(this.EvaluatePosition(time), this.EvaluateRotation(time));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002E15 File Offset: 0x00001015
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002E18 File Offset: 0x00001018
		public void Reset()
		{
			this.rotX = new AnimationCurve();
			this.rotY = new AnimationCurve();
			this.rotZ = new AnimationCurve();
			this.rotW = new AnimationCurve();
			this.posX = new AnimationCurve();
			this.posY = new AnimationCurve();
			this.posZ = new AnimationCurve();
			this.lastQ = Quaternion.identity;
			this.lastQSet = false;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E84 File Offset: 0x00001084
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
			Vector3 vector = this.transform.position;
			Quaternion quaternion = this.transform.rotation;
			if (root.parent != null)
			{
				vector = root.parent.InverseTransformPoint(vector);
				quaternion = Quaternion.Inverse(root.parent.rotation) * quaternion;
			}
			TQ ikgoalTQ = AvatarUtility.GetIKGoalTQ(avatar, humanScale, this.goal, new TQ(bodyPosition, bodyRotation), new TQ(vector, quaternion));
			Quaternion quaternion2 = ikgoalTQ.q;
			if (this.lastQSet)
			{
				quaternion2 = BakerUtilities.EnsureQuaternionContinuity(this.lastQ, ikgoalTQ.q);
			}
			this.lastQ = quaternion2;
			this.lastQSet = true;
			this.rotX.AddKey(time, quaternion2.x);
			this.rotY.AddKey(time, quaternion2.y);
			this.rotZ.AddKey(time, quaternion2.z);
			this.rotW.AddKey(time, quaternion2.w);
			Vector3 t = ikgoalTQ.t;
			this.posX.AddKey(time, t.x);
			this.posY.AddKey(time, t.y);
			this.posZ.AddKey(time, t.z);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002FBC File Offset: 0x000011BC
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
			this.rotX.AddKey(time, rot.x);
			this.rotY.AddKey(time, rot.y);
			this.rotZ.AddKey(time, rot.z);
			this.rotW.AddKey(time, rot.w);
			this.posX.AddKey(time, pos.x);
			this.posY.AddKey(time, pos.y);
			this.posZ.AddKey(time, pos.z);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003050 File Offset: 0x00001250
		public void MoveLastKeyframes(float time)
		{
			this.MoveLastKeyframe(time, this.rotX);
			this.MoveLastKeyframe(time, this.rotY);
			this.MoveLastKeyframe(time, this.rotZ);
			this.MoveLastKeyframe(time, this.rotW);
			this.MoveLastKeyframe(time, this.posX);
			this.MoveLastKeyframe(time, this.posY);
			this.MoveLastKeyframe(time, this.posZ);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000030B8 File Offset: 0x000012B8
		public void SetLoopFrame(float time)
		{
			BakerUtilities.SetLoopFrame(time, this.rotX);
			BakerUtilities.SetLoopFrame(time, this.rotY);
			BakerUtilities.SetLoopFrame(time, this.rotZ);
			BakerUtilities.SetLoopFrame(time, this.rotW);
			BakerUtilities.SetLoopFrame(time, this.posX);
			BakerUtilities.SetLoopFrame(time, this.posY);
			BakerUtilities.SetLoopFrame(time, this.posZ);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003119 File Offset: 0x00001319
		public void SetRootLoopFrame(float time)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000311C File Offset: 0x0000131C
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
			Keyframe[] keys = curve.keys;
			keys[keys.Length - 1].time = time;
			curve.keys = keys;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003148 File Offset: 0x00001348
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
			Keyframe[] keys = curve.keys;
			for (int i = 0; i < keys.Length; i++)
			{
				Keyframe[] array = keys;
				int num = i;
				array[num].time = array[num].time * mlp;
			}
			curve.keys = keys;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003188 File Offset: 0x00001388
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
			this.MultiplyLength(this.rotX, lengthMlp);
			this.MultiplyLength(this.rotY, lengthMlp);
			this.MultiplyLength(this.rotZ, lengthMlp);
			this.MultiplyLength(this.rotW, lengthMlp);
			this.MultiplyLength(this.posX, lengthMlp);
			this.MultiplyLength(this.posY, lengthMlp);
			this.MultiplyLength(this.posZ, lengthMlp);
			BakerUtilities.ReduceKeyframes(this.rotX, maxError);
			BakerUtilities.ReduceKeyframes(this.rotY, maxError);
			BakerUtilities.ReduceKeyframes(this.rotZ, maxError);
			BakerUtilities.ReduceKeyframes(this.rotW, maxError);
			BakerUtilities.ReduceKeyframes(this.posX, maxError);
			BakerUtilities.ReduceKeyframes(this.posY, maxError);
			BakerUtilities.ReduceKeyframes(this.posZ, maxError);
			BakerUtilities.SetTangentMode(this.rotX);
			BakerUtilities.SetTangentMode(this.rotY);
			BakerUtilities.SetTangentMode(this.rotZ);
			BakerUtilities.SetTangentMode(this.rotW);
			clip.SetCurve(string.Empty, typeof(Animator), this.Qx, this.rotX);
			clip.SetCurve(string.Empty, typeof(Animator), this.Qy, this.rotY);
			clip.SetCurve(string.Empty, typeof(Animator), this.Qz, this.rotZ);
			clip.SetCurve(string.Empty, typeof(Animator), this.Qw, this.rotW);
			clip.SetCurve(string.Empty, typeof(Animator), this.Tx, this.posX);
			clip.SetCurve(string.Empty, typeof(Animator), this.Ty, this.posY);
			clip.SetCurve(string.Empty, typeof(Animator), this.Tz, this.posZ);
		}

		// Token: 0x04000022 RID: 34
		private Transform transform;

		// Token: 0x04000023 RID: 35
		private string Qx;

		// Token: 0x04000024 RID: 36
		private string Qy;

		// Token: 0x04000025 RID: 37
		private string Qz;

		// Token: 0x04000026 RID: 38
		private string Qw;

		// Token: 0x04000027 RID: 39
		private string Tx;

		// Token: 0x04000028 RID: 40
		private string Ty;

		// Token: 0x04000029 RID: 41
		private string Tz;

		// Token: 0x0400002A RID: 42
		public AnimationCurve rotX;

		// Token: 0x0400002B RID: 43
		public AnimationCurve rotY;

		// Token: 0x0400002C RID: 44
		public AnimationCurve rotZ;

		// Token: 0x0400002D RID: 45
		public AnimationCurve rotW;

		// Token: 0x0400002E RID: 46
		public AnimationCurve posX;

		// Token: 0x0400002F RID: 47
		public AnimationCurve posY;

		// Token: 0x04000030 RID: 48
		public AnimationCurve posZ;

		// Token: 0x04000031 RID: 49
		private AvatarIKGoal goal;

		// Token: 0x04000032 RID: 50
		private Quaternion lastQ;

		// Token: 0x04000033 RID: 51
		private bool lastQSet;
	}
}
