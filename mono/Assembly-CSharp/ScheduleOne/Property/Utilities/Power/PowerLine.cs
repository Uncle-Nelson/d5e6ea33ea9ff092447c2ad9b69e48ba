using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Power
{
	// Token: 0x02000825 RID: 2085
	public class PowerLine : Constructable
	{
		// Token: 0x060038FE RID: 14590 RVA: 0x000F0D28 File Offset: 0x000EEF28
		public void InitializePowerLine(PowerNode a, PowerNode b)
		{
			this.nodeA = a;
			this.nodeB = b;
			this.nodeA.connections.Add(this);
			this.nodeB.connections.Add(this);
			this.nodeA.RecalculatePowerNetwork();
			for (int i = 0; i < PowerLine.powerLine_MaxSegments; i++)
			{
				Transform transform = Object.Instantiate<GameObject>(Singleton<PowerManager>.Instance.powerLineSegmentPrefab, base.transform).transform;
				transform.gameObject.SetActive(false);
				this.segments.Add(transform);
			}
			this.RefreshVisuals();
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x000F0DBC File Offset: 0x000EEFBC
		public override void DestroyConstructable(bool callOnServer = true)
		{
			if (this.nodeA != null)
			{
				this.nodeA.connections.Remove(this);
			}
			if (this.nodeB != null)
			{
				this.nodeB.connections.Remove(this);
			}
			if (this.nodeA != null)
			{
				this.nodeA.RecalculatePowerNetwork();
			}
			if (this.nodeB != null)
			{
				this.nodeB.RecalculatePowerNetwork();
			}
			base.DestroyConstructable(callOnServer);
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x000F0E44 File Offset: 0x000EF044
		protected virtual void LateUpdate()
		{
			if (this.nodeA == null || this.nodeB == null)
			{
				this.DestroyConstructable(true);
				return;
			}
			if (Vector3.Distance(this.nodeA_LastUpdatePos, this.nodeA.pConnectionPoint.transform.position) > PowerLine.updateThreshold)
			{
				this.RefreshVisuals();
			}
			if (Vector3.Distance(this.nodeB_LastUpdatePos, this.nodeB.pConnectionPoint.transform.position) > PowerLine.updateThreshold)
			{
				this.RefreshVisuals();
			}
			if (Vector3.Distance(this.nodeA.pConnectionPoint.transform.position, this.nodeB.pConnectionPoint.transform.position) > PowerLine.maxLineLength)
			{
				this.DestroyConstructable(true);
			}
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x000F0F0C File Offset: 0x000EF10C
		private void RefreshVisuals()
		{
			this.nodeA_LastUpdatePos = this.nodeA.pConnectionPoint.transform.position;
			this.nodeB_LastUpdatePos = this.nodeB.pConnectionPoint.transform.position;
			int segmentCount = PowerLine.GetSegmentCount(this.nodeA_LastUpdatePos, this.nodeB_LastUpdatePos);
			List<Transform> list = new List<Transform>();
			for (int i = 0; i < this.segments.Count; i++)
			{
				if (i < segmentCount)
				{
					this.segments[i].gameObject.SetActive(true);
					list.Add(this.segments[i]);
				}
				else
				{
					this.segments[i].gameObject.SetActive(false);
				}
			}
			PowerLine.DrawPowerLine(this.nodeA_LastUpdatePos, this.nodeB_LastUpdatePos, list, this.LengthFactor);
			this.RefreshBoundingBox();
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x000F0FE4 File Offset: 0x000EF1E4
		private void RefreshBoundingBox()
		{
			this.boundingBox.transform.position = (this.nodeA.pConnectionPoint.transform.position + this.nodeB.pConnectionPoint.transform.position) / 2f;
			this.boundingBox.transform.LookAt(this.nodeA.transform.position);
			this.boundingBox.size = new Vector3(0.1f, 0.5f, Vector3.Distance(this.nodeA.pConnectionPoint.transform.position, this.nodeB.pConnectionPoint.transform.position));
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x000F10A3 File Offset: 0x000EF2A3
		public PowerNode GetOtherNode(PowerNode firstNode)
		{
			if (firstNode == this.nodeA)
			{
				return this.nodeB;
			}
			if (firstNode == this.nodeB)
			{
				return this.nodeA;
			}
			return null;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x000F10D0 File Offset: 0x000EF2D0
		public void SetVisible(bool v)
		{
			for (int i = 0; i < this.segments.Count; i++)
			{
				this.segments[i].gameObject.SetActive(v);
			}
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x000F110A File Offset: 0x000EF30A
		public override Vector3 GetCosmeticCenter()
		{
			return (this.nodeA.transform.position + this.nodeB.transform.position) / 2f;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x000F113C File Offset: 0x000EF33C
		public static bool CanNodesBeConnected(PowerNode nodeA, PowerNode nodeB)
		{
			return !(nodeA == nodeB) && !(nodeA == null) && !(nodeB == null) && !nodeA.IsConnectedTo(nodeB) && Vector3.Distance(nodeA.pConnectionPoint.transform.position, nodeB.pConnectionPoint.transform.position) <= PowerLine.maxLineLength;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x000F11A4 File Offset: 0x000EF3A4
		public static int GetSegmentCount(Vector3 startPoint, Vector3 endPoint)
		{
			float num = Vector3.Distance(startPoint, endPoint);
			int num2 = (int)((float)(PowerLine.powerLine_MaxSegments - PowerLine.powerLine_MinSegments) * Mathf.Clamp(num / 20f, 0f, 1f));
			return PowerLine.powerLine_MinSegments + num2;
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x000F11E5 File Offset: 0x000EF3E5
		public static void DrawPowerLine(Vector3 startPoint, Vector3 endPoint, List<Transform> segments, float lengthFactor)
		{
			PowerLine.PositionSegments(PowerLine.GetCatenaryPoints(startPoint, endPoint, segments.Count, lengthFactor), segments);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x000F11FC File Offset: 0x000EF3FC
		private static void PositionSegments(List<Vector3> points, List<Transform> segments)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				segments[i].transform.position = (points[i] + points[i + 1]) / 2f;
				segments[i].transform.forward = points[i + 1] - points[i];
				segments[i].localScale = new Vector3(segments[i].localScale.x, segments[i].localScale.y, Vector3.Distance(points[i], points[i + 1]));
			}
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x000F12C0 File Offset: 0x000EF4C0
		private static List<Vector3> GetCatenaryPoints(Vector3 startPoint, Vector3 endPoint, int pointCount, float l)
		{
			Vector3 vector = startPoint;
			Vector3 b = endPoint;
			List<Vector3> list = new List<Vector3>();
			l *= Vector3.Distance(startPoint, endPoint);
			Vector3 a = endPoint - startPoint;
			a.y = 0f;
			a = a.normalized;
			Vector3 up = Vector3.up;
			endPoint.y -= startPoint.y;
			endPoint.x = Vector3.Distance(new Vector3(startPoint.x, 0f, startPoint.z), new Vector3(endPoint.x, 0f, endPoint.z));
			startPoint = Vector3.zero;
			float num = endPoint.y - startPoint.y;
			float num2 = endPoint.x - startPoint.x;
			int num3 = 0;
			float num4 = 0.01f * Mathf.Pow(Mathf.Clamp(Vector3.Distance(vector, b), 1f, float.MaxValue), 2f);
			float num5 = 1f;
			do
			{
				num5 += num4;
				num3++;
			}
			while ((double)Mathf.Sqrt(Mathf.Pow(l, 2f) - Mathf.Pow(num, 2f)) < (double)(2f * num5) * Math.Sinh((double)(num2 / (2f * num5))));
			int num6 = 0;
			float num7 = 0.001f;
			float num8 = num5 - num4;
			float num9 = num5;
			do
			{
				num6++;
				num5 = (num8 + num9) / 2f;
				if ((double)Mathf.Sqrt(Mathf.Pow(l, 2f) - Mathf.Pow(num, 2f)) < (double)(2f * num5) * Math.Sinh((double)(num2 / (2f * num5))))
				{
					num8 = num5;
				}
				else
				{
					num9 = num5;
				}
			}
			while (num9 - num8 > num7);
			float num10 = (startPoint.x + endPoint.x - num5 * Mathf.Log((l + num) / (l - num))) / 2f;
			float num11 = (float)(Math.Cosh((double)num2 / (2.0 * (double)num5)) / Math.Sinh((double)num2 / (2.0 * (double)num5)));
			float num12 = (startPoint.y + endPoint.y - l * num11) / 2f;
			float num13 = endPoint.x / (float)pointCount;
			List<Vector2> list2 = new List<Vector2>();
			for (int i = 0; i <= pointCount; i++)
			{
				float num14 = num13 * (float)i;
				float y = (float)((double)num5 * Math.Cosh((double)((num14 - num10) / num5)) + (double)num12);
				list2.Add(new Vector2(num14, y));
			}
			for (int j = 0; j < list2.Count; j++)
			{
				Vector3 item = vector + a * list2[j].x;
				item.y = vector.y + list2[j].y;
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x000F15D4 File Offset: 0x000EF7D4
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x000F15ED File Offset: 0x000EF7ED
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Property.Utilities.Power.PowerLineAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x000F1606 File Offset: 0x000EF806
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x000F1614 File Offset: 0x000EF814
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002949 RID: 10569
		public static int powerLine_MinSegments = 3;

		// Token: 0x0400294A RID: 10570
		public static int powerLine_MaxSegments = 10;

		// Token: 0x0400294B RID: 10571
		public static float maxLineLength = 25f;

		// Token: 0x0400294C RID: 10572
		public static float updateThreshold = 0.1f;

		// Token: 0x0400294D RID: 10573
		public PowerNode nodeA;

		// Token: 0x0400294E RID: 10574
		public PowerNode nodeB;

		// Token: 0x0400294F RID: 10575
		public float LengthFactor = 1.002f;

		// Token: 0x04002950 RID: 10576
		protected List<Transform> segments = new List<Transform>();

		// Token: 0x04002951 RID: 10577
		private Vector3 nodeA_LastUpdatePos = Vector3.zero;

		// Token: 0x04002952 RID: 10578
		private Vector3 nodeB_LastUpdatePos = Vector3.zero;

		// Token: 0x04002953 RID: 10579
		private bool dll_Excuted;

		// Token: 0x04002954 RID: 10580
		private bool dll_Excuted;
	}
}
