using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.Construction.Features;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Construction.Features;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Construction
{
	// Token: 0x02000B83 RID: 2947
	public class FeaturesManager : Singleton<FeaturesManager>
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06004E6D RID: 20077 RVA: 0x0014B072 File Offset: 0x00149272
		public bool isActive
		{
			get
			{
				return this.activeConstructable != null;
			}
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0014B080 File Offset: 0x00149280
		protected override void Awake()
		{
			base.Awake();
			this.CloseFeatureMenu();
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x0014B08E File Offset: 0x0014928E
		private void LateUpdate()
		{
			if (!this.isActive)
			{
				return;
			}
			if (this.featureIcons.Count > 0)
			{
				this.UpdateIconTransforms();
			}
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x0014B0B0 File Offset: 0x001492B0
		public void OpenFeatureMenu(Feature feature)
		{
			if (this.selectedFeature != null)
			{
				this.CloseFeatureMenu();
			}
			this.selectedFeature = feature;
			this.featureMenuRect.gameObject.SetActive(true);
			this.featureMenuTitleLabel.text = Singleton<ConstructionMenu>.Instance.SelectedConstructable.ConstructableName + " > " + this.selectedFeature.featureName;
			if (feature.disableRoofDisibility && Singleton<ConstructionMenu>.Instance.SelectedConstructable is Constructable_GridBased)
			{
				(Singleton<ConstructionMenu>.Instance.SelectedConstructable as Constructable_GridBased).SetRoofVisible(false);
				this.roofSetInvisible = true;
			}
			this.currentFeatureInterface = feature.CreateInterface(this.featureInterfaceContainer);
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x0014B160 File Offset: 0x00149360
		public void CloseFeatureMenu()
		{
			if (this.currentFeatureInterface != null)
			{
				this.currentFeatureInterface.Close();
			}
			if (this.roofSetInvisible)
			{
				if (Singleton<ConstructionMenu>.Instance.SelectedConstructable is Constructable_GridBased)
				{
					(Singleton<ConstructionMenu>.Instance.SelectedConstructable as Constructable_GridBased).SetRoofVisible(true);
				}
				this.roofSetInvisible = false;
			}
			this.selectedFeature = null;
			this.featureMenuRect.gameObject.SetActive(false);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x0014B1D4 File Offset: 0x001493D4
		public void DeselectFeature()
		{
			if (this.selectedFeature == null)
			{
				return;
			}
			foreach (FeatureIcon featureIcon in this.featureIcons)
			{
				if (featureIcon.isSelected)
				{
					featureIcon.SetIsSelected(false);
				}
			}
			this.CloseFeatureMenu();
			this.selectedFeature = null;
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x0014B24C File Offset: 0x0014944C
		public void Activate(Constructable constructable)
		{
			this.Deactivate();
			this.activeConstructable = constructable;
			this.CreateIcons();
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x0014B261 File Offset: 0x00149461
		public void Deactivate()
		{
			this.ClearIcons();
			if (this.selectedFeature != null)
			{
				this.CloseFeatureMenu();
			}
			this.activeConstructable = null;
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x0014B284 File Offset: 0x00149484
		private void ClearIcons()
		{
			for (int i = 0; i < this.featureIcons.Count; i++)
			{
				Object.Destroy(this.featureIcons[i].gameObject);
			}
			this.featureIcons.Clear();
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x0014B2C8 File Offset: 0x001494C8
		private void CreateIcons()
		{
			foreach (Feature feature in this.activeConstructable.features)
			{
				FeatureIcon component = Object.Instantiate<GameObject>(this.featureIconPrefab, this.featureIconsContainer).GetComponent<FeatureIcon>();
				component.AssignFeature(feature);
				this.featureIcons.Add(component);
			}
			this.UpdateIconTransforms();
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x0014B34C File Offset: 0x0014954C
		private void UpdateIconTransforms()
		{
			foreach (FeatureIcon featureIcon in this.featureIcons)
			{
				featureIcon.UpdateTransform();
			}
		}

		// Token: 0x04003B33 RID: 15155
		public Constructable activeConstructable;

		// Token: 0x04003B34 RID: 15156
		public Feature selectedFeature;

		// Token: 0x04003B35 RID: 15157
		[Header("References")]
		[SerializeField]
		protected RectTransform featureIconsContainer;

		// Token: 0x04003B36 RID: 15158
		[SerializeField]
		protected RectTransform featureMenuRect;

		// Token: 0x04003B37 RID: 15159
		[SerializeField]
		protected TextMeshProUGUI featureMenuTitleLabel;

		// Token: 0x04003B38 RID: 15160
		[SerializeField]
		protected RectTransform featureInterfaceContainer;

		// Token: 0x04003B39 RID: 15161
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject featureIconPrefab;

		// Token: 0x04003B3A RID: 15162
		private FI_Base currentFeatureInterface;

		// Token: 0x04003B3B RID: 15163
		private bool roofSetInvisible;

		// Token: 0x04003B3C RID: 15164
		protected List<FeatureIcon> featureIcons = new List<FeatureIcon>();
	}
}
