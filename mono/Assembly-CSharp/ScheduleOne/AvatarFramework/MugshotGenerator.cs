using System;
using EasyButtons;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000971 RID: 2417
	public class MugshotGenerator : Singleton<MugshotGenerator>
	{
		// Token: 0x060041C7 RID: 16839 RVA: 0x001142BF File Offset: 0x001124BF
		protected override void Awake()
		{
			base.Awake();
			this.MugshotRig.gameObject.SetActive(false);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x001142D8 File Offset: 0x001124D8
		private void LateUpdate()
		{
			if (this.generate)
			{
				this.generate = false;
				this.FinalizeMugshot();
			}
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x001142EF File Offset: 0x001124EF
		private void FinalizeMugshot()
		{
			this.finalTexture = this.Generator.GetTexture(this.MugshotRig.transform);
			Debug.Log("Mugshot capture");
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x00114317 File Offset: 0x00112517
		[Button]
		public void GenerateMugshot()
		{
			this.GenerateMugshot(this.Settings, true, null);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x00114328 File Offset: 0x00112528
		public void GenerateMugshot(AvatarSettings settings, bool fileToFile, Action<Texture2D> callback)
		{
			MugshotGenerator.<>c__DisplayClass12_0 CS$<>8__locals1 = new MugshotGenerator.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.fileToFile = fileToFile;
			CS$<>8__locals1.settings = settings;
			CS$<>8__locals1.callback = callback;
			this.finalTexture = null;
			Debug.Log("Mugshot start");
			AvatarSettings avatarSettings = Object.Instantiate<AvatarSettings>(CS$<>8__locals1.settings);
			avatarSettings.Height = 1f;
			this.MugshotRig.gameObject.SetActive(true);
			this.MugshotRig.LoadAvatarSettings(avatarSettings);
			LayerUtility.SetLayerRecursively(this.MugshotRig.gameObject, LayerMask.NameToLayer("IconGeneration"));
			SkinnedMeshRenderer[] componentsInChildren = this.MugshotRig.GetComponentsInChildren<SkinnedMeshRenderer>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].updateWhenOffscreen = true;
			}
			this.generate = true;
			base.StartCoroutine(CS$<>8__locals1.<GenerateMugshot>g__Routine|0());
		}

		// Token: 0x04002F4C RID: 12108
		public string OutputPath;

		// Token: 0x04002F4D RID: 12109
		public AvatarSettings Settings;

		// Token: 0x04002F4E RID: 12110
		[Header("References")]
		public Avatar MugshotRig;

		// Token: 0x04002F4F RID: 12111
		public IconGenerator Generator;

		// Token: 0x04002F50 RID: 12112
		public AvatarSettings DefaultSettings;

		// Token: 0x04002F51 RID: 12113
		public Transform LookAtPosition;

		// Token: 0x04002F52 RID: 12114
		private Texture2D finalTexture;

		// Token: 0x04002F53 RID: 12115
		private bool generate;
	}
}
