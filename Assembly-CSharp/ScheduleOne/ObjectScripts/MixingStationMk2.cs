using System;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BE3 RID: 3043
	public class MixingStationMk2 : MixingStation
	{
		// Token: 0x060054B7 RID: 21687 RVA: 0x00164CDA File Offset: 0x00162EDA
		protected override void MinPass()
		{
			base.MinPass();
			this.UpdateScreen();
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00164CE8 File Offset: 0x00162EE8
		public override void MixingStart()
		{
			base.MixingStart();
			this.Animation.Play("Mixing station start");
			this.EnableScreen();
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00164D07 File Offset: 0x00162F07
		public override void MixingDone()
		{
			base.MixingDone();
			this.Animation.Play("Mixing station end");
			this.DisableScreen();
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00164D28 File Offset: 0x00162F28
		private void EnableScreen()
		{
			if (base.CurrentMixOperation == null)
			{
				return;
			}
			this.QuantityLabel.text = base.CurrentMixOperation.Quantity.ToString() + "x";
			ProductDefinition productDefinition;
			if (base.CurrentMixOperation.IsOutputKnown(out productDefinition))
			{
				this.OutputIcon.sprite = productDefinition.Icon;
				this.OutputIcon.color = Color.white;
				this.QuestionMark.gameObject.SetActive(false);
			}
			else
			{
				this.OutputIcon.sprite = Registry.GetItem(base.CurrentMixOperation.ProductID).Icon;
				this.OutputIcon.color = Color.black;
				this.QuestionMark.gameObject.SetActive(true);
			}
			this.UpdateScreen();
			this.ScreenCanvas.enabled = true;
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00164DFC File Offset: 0x00162FFC
		private void UpdateScreen()
		{
			if (base.CurrentMixOperation == null)
			{
				return;
			}
			this.ProgressLabel.text = (base.GetMixTimeForCurrentOperation() - base.CurrentMixTime).ToString() + " mins remaining";
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00164E3C File Offset: 0x0016303C
		private void DisableScreen()
		{
			this.ScreenCanvas.enabled = false;
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00164E52 File Offset: 0x00163052
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00164E6B File Offset: 0x0016306B
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.MixingStationMk2Assembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00164E84 File Offset: 0x00163084
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00164E92 File Offset: 0x00163092
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003EF3 RID: 16115
		public Animation Animation;

		// Token: 0x04003EF4 RID: 16116
		[Header("Screen")]
		public Canvas ScreenCanvas;

		// Token: 0x04003EF5 RID: 16117
		public Image OutputIcon;

		// Token: 0x04003EF6 RID: 16118
		public RectTransform QuestionMark;

		// Token: 0x04003EF7 RID: 16119
		public TextMeshProUGUI QuantityLabel;

		// Token: 0x04003EF8 RID: 16120
		public TextMeshProUGUI ProgressLabel;

		// Token: 0x04003EF9 RID: 16121
		private bool dll_Excuted;

		// Token: 0x04003EFA RID: 16122
		private bool dll_Excuted;
	}
}
