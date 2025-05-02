using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property.Utilities.Power;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000C0C RID: 3084
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x060056BD RID: 22205 RVA: 0x0016CA14 File Offset: 0x0016AC14
		private void Awake()
		{
			if (this.Cable1Container.gameObject.activeSelf)
			{
				this.cableStart = this.cable1Connection.position;
				this.cableEnd = this.cable1Segments[this.cable1Segments.Count - 1].position;
				this.cableMid = (this.cableStart + this.cableEnd) / 2f;
				return;
			}
			this.cableStart = this.cable2Connection.position;
			this.cableEnd = this.cable2Segments[this.cable2Segments.Count - 1].position;
			this.cableMid = (this.cableStart + this.cableEnd) / 2f;
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x0016CADE File Offset: 0x0016ACDE
		private void Start()
		{
			if (PlayerSingleton<PlayerMovement>.InstanceExists)
			{
				this.<Start>g__Register|17_0();
				return;
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Register|17_0));
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x0016CB10 File Offset: 0x0016AD10
		private void UpdateCulling()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			float sqrMagnitude = (this.cableStart - PlayerSingleton<PlayerCamera>.Instance.transform.position).sqrMagnitude;
			float sqrMagnitude2 = (this.cableEnd - PlayerSingleton<PlayerCamera>.Instance.transform.position).sqrMagnitude;
			float sqrMagnitude3 = (this.cableMid - PlayerSingleton<PlayerCamera>.Instance.transform.position).sqrMagnitude;
			float num = Mathf.Min(new float[]
			{
				sqrMagnitude,
				sqrMagnitude2,
				sqrMagnitude3
			}) * QualitySettings.lodBias;
			this.Cable1Container.gameObject.SetActive(num < 10000f && this.Connection1Enabled);
			this.Cable2Container.gameObject.SetActive(num < 10000f && this.Connection2Enabled);
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x0016CBF4 File Offset: 0x0016ADF4
		[Button]
		public void Orient()
		{
			if (this.previousPole == null && this.nextPole == null)
			{
				Console.LogWarning("No neighbour poles!", null);
				return;
			}
			if (this.nextPole != null && this.previousPole != null)
			{
				Vector3 normalized = (base.transform.position - this.previousPole.transform.position).normalized;
				Vector3 normalized2 = (this.nextPole.transform.position - base.transform.position).normalized;
				Vector3 normalized3 = (normalized + normalized2).normalized;
				base.transform.rotation = Quaternion.LookRotation(normalized3, Vector3.up);
				return;
			}
			if (this.previousPole != null)
			{
				Vector3 normalized4 = (base.transform.position - this.previousPole.transform.position).normalized;
				base.transform.rotation = Quaternion.LookRotation(normalized4, Vector3.up);
				return;
			}
			if (this.nextPole != null)
			{
				Vector3 normalized5 = (this.nextPole.transform.position - base.transform.position).normalized;
				base.transform.rotation = Quaternion.LookRotation(normalized5, Vector3.up);
			}
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x0016CD5C File Offset: 0x0016AF5C
		[Button]
		public void DrawLines()
		{
			if (this.previousPole == null)
			{
				if (this.Connection1Enabled)
				{
					foreach (Transform transform in this.cable1Segments)
					{
						transform.gameObject.SetActive(false);
					}
				}
				if (this.Connection2Enabled)
				{
					foreach (Transform transform2 in this.cable2Segments)
					{
						transform2.gameObject.SetActive(false);
					}
				}
				return;
			}
			if (this.Connection1Enabled)
			{
				PowerLine.DrawPowerLine(this.cable1Connection.position, this.previousPole.cable1Connection.position, this.cable1Segments, this.LengthFactor);
				foreach (Transform transform3 in this.cable1Segments)
				{
					transform3.gameObject.SetActive(true);
				}
			}
			if (this.Connection2Enabled)
			{
				PowerLine.DrawPowerLine(this.cable2Connection.position, this.previousPole.cable2Connection.position, this.cable2Segments, this.LengthFactor);
				foreach (Transform transform4 in this.cable2Segments)
				{
					transform4.gameObject.SetActive(true);
				}
			}
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x0016CF6F File Offset: 0x0016B16F
		[CompilerGenerated]
		private void <Start>g__Register|17_0()
		{
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.<Start>g__Register|17_0));
			PlayerSingleton<PlayerCamera>.Instance.RegisterMovementEvent(2, new Action(this.UpdateCulling));
		}

		// Token: 0x04004010 RID: 16400
		public const float CABLE_CULL_DISTANCE = 100f;

		// Token: 0x04004011 RID: 16401
		public const float CABLE_CULL_DISTANCE_SQR = 10000f;

		// Token: 0x04004012 RID: 16402
		public UtilityPole previousPole;

		// Token: 0x04004013 RID: 16403
		public UtilityPole nextPole;

		// Token: 0x04004014 RID: 16404
		public bool Connection1Enabled = true;

		// Token: 0x04004015 RID: 16405
		public bool Connection2Enabled = true;

		// Token: 0x04004016 RID: 16406
		public float LengthFactor = 1.002f;

		// Token: 0x04004017 RID: 16407
		[Header("References")]
		public Transform cable1Connection;

		// Token: 0x04004018 RID: 16408
		public Transform cable2Connection;

		// Token: 0x04004019 RID: 16409
		public List<Transform> cable1Segments = new List<Transform>();

		// Token: 0x0400401A RID: 16410
		public List<Transform> cable2Segments = new List<Transform>();

		// Token: 0x0400401B RID: 16411
		public Transform Cable1Container;

		// Token: 0x0400401C RID: 16412
		public Transform Cable2Container;

		// Token: 0x0400401D RID: 16413
		private Vector3 cableStart = Vector3.zero;

		// Token: 0x0400401E RID: 16414
		private Vector3 cableEnd = Vector3.zero;

		// Token: 0x0400401F RID: 16415
		private Vector3 cableMid = Vector3.zero;
	}
}
