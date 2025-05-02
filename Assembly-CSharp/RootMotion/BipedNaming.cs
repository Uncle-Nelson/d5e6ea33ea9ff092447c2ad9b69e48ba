using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000013 RID: 19
	public static class BipedNaming
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00004B84 File Offset: 0x00002D84
		public static Transform[] GetBonesOfType(BipedNaming.BoneType boneType, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && BipedNaming.GetBoneType(transform.name) == boneType)
				{
					Array.Resize<Transform>(ref array, array.Length + 1);
					array[array.Length - 1] = transform;
				}
			}
			return array;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004BD8 File Offset: 0x00002DD8
		public static Transform[] GetBonesOfSide(BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && BipedNaming.GetBoneSide(transform.name) == boneSide)
				{
					Array.Resize<Transform>(ref array, array.Length + 1);
					array[array.Length - 1] = transform;
				}
			}
			return array;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004C2C File Offset: 0x00002E2C
		public static Transform[] GetBonesOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfType = BipedNaming.GetBonesOfType(boneType, bones);
			return BipedNaming.GetBonesOfSide(boneSide, bonesOfType);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004C48 File Offset: 0x00002E48
		public static Transform GetFirstBoneOfTypeAndSide(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfTypeAndSide = BipedNaming.GetBonesOfTypeAndSide(boneType, boneSide, bones);
			if (bonesOfTypeAndSide.Length == 0)
			{
				return null;
			}
			return bonesOfTypeAndSide[0];
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004C68 File Offset: 0x00002E68
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			foreach (Transform transform in transforms)
			{
				bool flag = true;
				foreach (string[] namingConvention in namings)
				{
					if (!BipedNaming.matchesNaming(transform.name, namingConvention))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return transform;
				}
			}
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public static BipedNaming.BoneType GetBoneType(string boneName)
		{
			if (BipedNaming.isSpine(boneName))
			{
				return BipedNaming.BoneType.Spine;
			}
			if (BipedNaming.isHead(boneName))
			{
				return BipedNaming.BoneType.Head;
			}
			if (BipedNaming.isArm(boneName))
			{
				return BipedNaming.BoneType.Arm;
			}
			if (BipedNaming.isLeg(boneName))
			{
				return BipedNaming.BoneType.Leg;
			}
			if (BipedNaming.isTail(boneName))
			{
				return BipedNaming.BoneType.Tail;
			}
			if (BipedNaming.isEye(boneName))
			{
				return BipedNaming.BoneType.Eye;
			}
			return BipedNaming.BoneType.Unassigned;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004D00 File Offset: 0x00002F00
		public static BipedNaming.BoneSide GetBoneSide(string boneName)
		{
			if (BipedNaming.isLeft(boneName))
			{
				return BipedNaming.BoneSide.Left;
			}
			if (BipedNaming.isRight(boneName))
			{
				return BipedNaming.BoneSide.Right;
			}
			return BipedNaming.BoneSide.Center;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004D17 File Offset: 0x00002F17
		public static Transform GetBone(Transform[] transforms, BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide = BipedNaming.BoneSide.Center, params string[][] namings)
		{
			return BipedNaming.GetNamingMatch(BipedNaming.GetBonesOfTypeAndSide(boneType, boneSide, transforms), namings);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004D27 File Offset: 0x00002F27
		private static bool isLeft(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeLeft) || BipedNaming.lastLetter(boneName) == "L" || BipedNaming.firstLetter(boneName) == "L";
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004D5A File Offset: 0x00002F5A
		private static bool isRight(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeRight) || BipedNaming.lastLetter(boneName) == "R" || BipedNaming.firstLetter(boneName) == "R";
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004D8D File Offset: 0x00002F8D
		private static bool isSpine(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeSpine) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeSpine);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004DAC File Offset: 0x00002FAC
		private static bool isHead(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeHead) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeHead);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004DCB File Offset: 0x00002FCB
		private static bool isArm(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeArm) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeArm);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004DEA File Offset: 0x00002FEA
		private static bool isLeg(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeLeg) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeLeg);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004E09 File Offset: 0x00003009
		private static bool isTail(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeTail) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeTail);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004E28 File Offset: 0x00003028
		private static bool isEye(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeEye) && !BipedNaming.excludesNaming(boneName, BipedNaming.typeExcludeEye);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004E47 File Offset: 0x00003047
		private static bool isTypeExclude(string boneName)
		{
			return BipedNaming.matchesNaming(boneName, BipedNaming.typeExclude);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004E54 File Offset: 0x00003054
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			if (BipedNaming.excludesNaming(boneName, BipedNaming.typeExclude))
			{
				return false;
			}
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004E90 File Offset: 0x00003090
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004EC0 File Offset: 0x000030C0
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			foreach (string letter in namingConvention)
			{
				if (BipedNaming.LastLetterIs(boneName, letter))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004EED File Offset: 0x000030ED
		private static bool LastLetterIs(string boneName, string letter)
		{
			return boneName.Substring(boneName.Length - 1, 1) == letter;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004F04 File Offset: 0x00003104
		private static string firstLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(0, 1);
			}
			return "";
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004F1D File Offset: 0x0000311D
		private static string lastLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(boneName.Length - 1, 1);
			}
			return "";
		}

		// Token: 0x04000087 RID: 135
		public static string[] typeLeft = new string[]
		{
			" L ",
			"_L_",
			"-L-",
			" l ",
			"_l_",
			"-l-",
			"Left",
			"left",
			"CATRigL"
		};

		// Token: 0x04000088 RID: 136
		public static string[] typeRight = new string[]
		{
			" R ",
			"_R_",
			"-R-",
			" r ",
			"_r_",
			"-r-",
			"Right",
			"right",
			"CATRigR"
		};

		// Token: 0x04000089 RID: 137
		public static string[] typeSpine = new string[]
		{
			"Spine",
			"spine",
			"Pelvis",
			"pelvis",
			"Root",
			"root",
			"Torso",
			"torso",
			"Body",
			"body",
			"Hips",
			"hips",
			"Neck",
			"neck",
			"Chest",
			"chest"
		};

		// Token: 0x0400008A RID: 138
		public static string[] typeHead = new string[]
		{
			"Head",
			"head"
		};

		// Token: 0x0400008B RID: 139
		public static string[] typeArm = new string[]
		{
			"Arm",
			"arm",
			"Hand",
			"hand",
			"Wrist",
			"Wrist",
			"Elbow",
			"elbow",
			"Palm",
			"palm"
		};

		// Token: 0x0400008C RID: 140
		public static string[] typeLeg = new string[]
		{
			"Leg",
			"leg",
			"Thigh",
			"thigh",
			"Calf",
			"calf",
			"Femur",
			"femur",
			"Knee",
			"knee",
			"Foot",
			"foot",
			"Ankle",
			"ankle",
			"Hip",
			"hip"
		};

		// Token: 0x0400008D RID: 141
		public static string[] typeTail = new string[]
		{
			"Tail",
			"tail"
		};

		// Token: 0x0400008E RID: 142
		public static string[] typeEye = new string[]
		{
			"Eye",
			"eye"
		};

		// Token: 0x0400008F RID: 143
		public static string[] typeExclude = new string[]
		{
			"Nub",
			"Dummy",
			"dummy",
			"Tip",
			"IK",
			"Mesh"
		};

		// Token: 0x04000090 RID: 144
		public static string[] typeExcludeSpine = new string[]
		{
			"Head",
			"head"
		};

		// Token: 0x04000091 RID: 145
		public static string[] typeExcludeHead = new string[]
		{
			"Top",
			"End"
		};

		// Token: 0x04000092 RID: 146
		public static string[] typeExcludeArm = new string[]
		{
			"Collar",
			"collar",
			"Clavicle",
			"clavicle",
			"Finger",
			"finger",
			"Index",
			"index",
			"Mid",
			"mid",
			"Pinky",
			"pinky",
			"Ring",
			"Thumb",
			"thumb",
			"Adjust",
			"adjust",
			"Twist",
			"twist"
		};

		// Token: 0x04000093 RID: 147
		public static string[] typeExcludeLeg = new string[]
		{
			"Toe",
			"toe",
			"Platform",
			"Adjust",
			"adjust",
			"Twist",
			"twist"
		};

		// Token: 0x04000094 RID: 148
		public static string[] typeExcludeTail = new string[0];

		// Token: 0x04000095 RID: 149
		public static string[] typeExcludeEye = new string[]
		{
			"Lid",
			"lid",
			"Brow",
			"brow",
			"Lash",
			"lash"
		};

		// Token: 0x04000096 RID: 150
		public static string[] pelvis = new string[]
		{
			"Pelvis",
			"pelvis",
			"Hip",
			"hip"
		};

		// Token: 0x04000097 RID: 151
		public static string[] hand = new string[]
		{
			"Hand",
			"hand",
			"Wrist",
			"wrist",
			"Palm",
			"palm"
		};

		// Token: 0x04000098 RID: 152
		public static string[] foot = new string[]
		{
			"Foot",
			"foot",
			"Ankle",
			"ankle"
		};

		// Token: 0x020000D0 RID: 208
		[Serializable]
		public enum BoneType
		{
			// Token: 0x040005FD RID: 1533
			Unassigned,
			// Token: 0x040005FE RID: 1534
			Spine,
			// Token: 0x040005FF RID: 1535
			Head,
			// Token: 0x04000600 RID: 1536
			Arm,
			// Token: 0x04000601 RID: 1537
			Leg,
			// Token: 0x04000602 RID: 1538
			Tail,
			// Token: 0x04000603 RID: 1539
			Eye
		}

		// Token: 0x020000D1 RID: 209
		[Serializable]
		public enum BoneSide
		{
			// Token: 0x04000605 RID: 1541
			Center,
			// Token: 0x04000606 RID: 1542
			Left,
			// Token: 0x04000607 RID: 1543
			Right
		}
	}
}
