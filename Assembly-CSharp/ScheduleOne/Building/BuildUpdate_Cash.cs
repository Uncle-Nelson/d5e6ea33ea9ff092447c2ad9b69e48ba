using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts.Cash;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x0200078C RID: 1932
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000DBB7D File Offset: 0x000D9D7D
		private float placeAmount
		{
			get
			{
				return (float)Cash.amounts[this.amountIndex % Cash.amounts.Length];
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000DBB94 File Offset: 0x000D9D94
		private void Start()
		{
			Transform transform = this.ghostModel.transform.Find("Bills");
			for (int i = 0; i < transform.childCount; i++)
			{
				this.bills.Add(transform.GetChild(i));
			}
			this.RefreshGhostModelAppearance();
			this.amountLabel = new WorldSpaceLabel("Amount", Vector3.zero);
			this.amountLabel.scale = 1.25f;
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000DBC05 File Offset: 0x000D9E05
		protected override void Update()
		{
			base.Update();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
			{
				this.amountIndex++;
				this.RefreshGhostModelAppearance();
			}
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000DBC2C File Offset: 0x000D9E2C
		protected override void LateUpdate()
		{
			base.LateUpdate();
			if (this.GetRelevantCashBalane() < this.placeAmount)
			{
				if (this.GetRelevantCashBalane() < (float)Cash.amounts[0])
				{
					this.amountIndex = 0;
					this.RefreshGhostModelAppearance();
					this.validPosition = false;
					base.UpdateMaterials();
					this.amountLabel.text = "Insufficient cash";
					this.UpdateLabel();
					return;
				}
				while (this.GetRelevantCashBalane() < this.placeAmount)
				{
					this.amountIndex++;
					this.RefreshGhostModelAppearance();
				}
			}
			this.amountLabel.text = MoneyManager.FormatAmount(this.placeAmount, false, false);
			this.UpdateLabel();
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000DBCD0 File Offset: 0x000D9ED0
		private void UpdateLabel()
		{
			this.amountLabel.position = this.ghostModel.transform.position;
			Vector3 a = PlayerSingleton<PlayerCamera>.Instance.transform.position - this.ghostModel.transform.position;
			a.y = 0f;
			a.Normalize();
			this.amountLabel.position += a * 0.2f;
			if (this.validPosition)
			{
				this.amountLabel.color = Color.white;
				return;
			}
			this.amountLabel.color = new Color32(byte.MaxValue, 50, 50, byte.MaxValue);
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000DBD90 File Offset: 0x000D9F90
		private void RefreshGhostModelAppearance()
		{
			int billStacksToDisplay = Cash.GetBillStacksToDisplay(this.placeAmount);
			for (int i = 0; i < this.bills.Count; i++)
			{
				if (i < billStacksToDisplay)
				{
					this.bills[i].gameObject.SetActive(true);
				}
				else
				{
					this.bills[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000DBDF4 File Offset: 0x000D9FF4
		protected override void Place()
		{
			float rotation = Vector3.SignedAngle(this.bestIntersection.storageTile.ownerGrid.transform.forward, this.storedItemClass.buildPoint.forward, this.bestIntersection.storageTile.ownerGrid.transform.up);
			CashInstance cashInstance = new CashInstance(this.itemInstance.Definition, 1);
			cashInstance.SetBalance(this.placeAmount, false);
			Singleton<BuildManager>.Instance.CreateStoredItem(cashInstance, this.bestIntersection.storageTile.ownerGrid.GetComponentInParent<IStorageEntity>(), this.bestIntersection.storageTile.ownerGrid, base.GetOriginCoordinate(), rotation);
			this.mouseUpSincePlace = false;
			this.PostPlace();
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000DBEAE File Offset: 0x000DA0AE
		protected override void PostPlace()
		{
			NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(-this.placeAmount, true, false);
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000DBEC3 File Offset: 0x000DA0C3
		public override void Stop()
		{
			base.Stop();
			this.amountLabel.Destroy();
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x000DBED6 File Offset: 0x000DA0D6
		public float GetRelevantCashBalane()
		{
			return NetworkSingleton<MoneyManager>.Instance.cashBalance;
		}

		// Token: 0x0400258A RID: 9610
		public int amountIndex;

		// Token: 0x0400258B RID: 9611
		protected List<Transform> bills = new List<Transform>();

		// Token: 0x0400258C RID: 9612
		private WorldSpaceLabel amountLabel;
	}
}
