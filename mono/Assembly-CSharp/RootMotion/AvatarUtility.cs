using System;
using System.Reflection;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000008 RID: 8
	public class AvatarUtility
	{
		// Token: 0x0600002A RID: 42 RVA: 0x0000258C File Offset: 0x0000078C
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			int num = (int)AvatarUtility.HumanIDFromAvatarIKGoal(avatarIKGoal);
			if (num == 55)
			{
				throw new InvalidOperationException("Invalid human id.");
			}
			MethodInfo method = typeof(Avatar).GetMethod("GetPostRotation", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new InvalidOperationException("Cannot find GetPostRotation method.");
			}
			return (Quaternion)method.Invoke(avatar, new object[]
			{
				num
			});
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000025F4 File Offset: 0x000007F4
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			int num = (int)AvatarUtility.HumanIDFromAvatarIKGoal(avatarIKGoal);
			if (num == 55)
			{
				throw new InvalidOperationException("Invalid human id.");
			}
			MethodInfo method = typeof(Avatar).GetMethod("GetAxisLength", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new InvalidOperationException("Cannot find GetAxisLength method.");
			}
			MethodInfo method2 = typeof(Avatar).GetMethod("GetPostRotation", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method2 == null)
			{
				throw new InvalidOperationException("Cannot find GetPostRotation method.");
			}
			Quaternion rhs = (Quaternion)method2.Invoke(avatar, new object[]
			{
				num
			});
			TQ tq = new TQ(boneTQ.t, boneTQ.q * rhs);
			if (avatarIKGoal == AvatarIKGoal.LeftFoot || avatarIKGoal == AvatarIKGoal.RightFoot)
			{
				float x = (float)method.Invoke(avatar, new object[]
				{
					num
				});
				Vector3 point = new Vector3(x, 0f, 0f);
				tq.t += tq.q * point;
			}
			Quaternion quaternion = Quaternion.Inverse(bodyPositionRotation.q);
			tq.t = quaternion * (tq.t - bodyPositionRotation.t);
			tq.q = quaternion * tq.q;
			tq.t /= humanScale;
			tq.q = Quaternion.LookRotation(tq.q * Vector3.forward, tq.q * Vector3.up);
			return tq;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002774 File Offset: 0x00000974
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			int num = (int)AvatarUtility.HumanIDFromAvatarIKGoal(avatarIKGoal);
			if (num == 55)
			{
				throw new InvalidOperationException("Invalid human id.");
			}
			MethodInfo method = typeof(Avatar).GetMethod("GetAxisLength", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method == null)
			{
				throw new InvalidOperationException("Cannot find GetAxisLength method.");
			}
			MethodInfo method2 = typeof(Avatar).GetMethod("GetPostRotation", BindingFlags.Instance | BindingFlags.NonPublic);
			if (method2 == null)
			{
				throw new InvalidOperationException("Cannot find GetPostRotation method.");
			}
			Quaternion rotation = (Quaternion)method2.Invoke(avatar, new object[]
			{
				num
			});
			if (avatarIKGoal == AvatarIKGoal.LeftFoot || avatarIKGoal == AvatarIKGoal.RightFoot)
			{
				float x = (float)method.Invoke(avatar, new object[]
				{
					num
				});
				Vector3 point = new Vector3(x, 0f, 0f);
				goalTQ.t -= goalTQ.q * point;
			}
			return new TQ(goalTQ.t, goalTQ.q * Quaternion.Inverse(rotation));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002878 File Offset: 0x00000A78
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			TQ tq = ikQT.Evaluate(time);
			TQ tq2 = rootQT.Evaluate(time);
			tq.q = tq2.q * tq.q;
			tq.t = tq2.t + tq2.q * tq.t;
			tq.t *= humanScale;
			return tq;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000028E1 File Offset: 0x00000AE1
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			switch (avatarIKGoal)
			{
			case AvatarIKGoal.LeftFoot:
				return HumanBodyBones.LeftFoot;
			case AvatarIKGoal.RightFoot:
				return HumanBodyBones.RightFoot;
			case AvatarIKGoal.LeftHand:
				return HumanBodyBones.LeftHand;
			case AvatarIKGoal.RightHand:
				return HumanBodyBones.RightHand;
			default:
				return HumanBodyBones.LastBone;
			}
		}
	}
}
