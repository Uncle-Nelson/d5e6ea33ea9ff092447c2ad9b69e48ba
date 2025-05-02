using System;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200001B RID: 27
	public static class LayerMaskExtensions
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000070A4 File Offset: 0x000052A4
		public static bool Contains(LayerMask mask, int layer)
		{
			return mask == (mask | 1 << layer);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000070BB File Offset: 0x000052BB
		public static LayerMask Create(params string[] layerNames)
		{
			return LayerMaskExtensions.NamesToMask(layerNames);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000070C3 File Offset: 0x000052C3
		public static LayerMask Create(params int[] layerNumbers)
		{
			return LayerMaskExtensions.LayerNumbersToMask(layerNumbers);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000070CC File Offset: 0x000052CC
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			LayerMask layerMask = 0;
			foreach (string layerName in layerNames)
			{
				layerMask |= 1 << LayerMask.NameToLayer(layerName);
			}
			return layerMask;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007110 File Offset: 0x00005310
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			LayerMask layerMask = 0;
			foreach (int num in layerNumbers)
			{
				layerMask |= 1 << num;
			}
			return layerMask;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000714C File Offset: 0x0000534C
		public static LayerMask Inverse(this LayerMask original)
		{
			return ~original;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000715A File Offset: 0x0000535A
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return original | LayerMaskExtensions.NamesToMask(layerNames);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007173 File Offset: 0x00005373
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return ~(~original | LayerMaskExtensions.NamesToMask(layerNames));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007198 File Offset: 0x00005398
		public static string[] MaskToNames(this LayerMask original)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if ((original & num) == num)
				{
					string text = LayerMask.LayerToName(i);
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000071E8 File Offset: 0x000053E8
		public static int[] MaskToNumbers(this LayerMask original)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if ((original & num) == num)
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00007227 File Offset: 0x00005427
		public static string MaskToString(this LayerMask original)
		{
			return original.MaskToString(", ");
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00007234 File Offset: 0x00005434
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return string.Join(delimiter, original.MaskToNames());
		}
	}
}
