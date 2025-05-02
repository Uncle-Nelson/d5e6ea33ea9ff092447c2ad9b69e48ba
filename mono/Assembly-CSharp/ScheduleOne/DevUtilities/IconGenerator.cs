using System;
using System.Collections.Generic;
using System.IO;
using EasyButtons;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Rendering;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006DF RID: 1759
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x06002FF8 RID: 12280 RVA: 0x000C7C58 File Offset: 0x000C5E58
		protected override void Awake()
		{
			base.Awake();
			this.Canvas.gameObject.SetActive(false);
			this.CameraPosition.gameObject.SetActive(false);
			this.CameraPosition.clearFlags = CameraClearFlags.Color;
			if (this.Registry == null)
			{
				this.Registry = Singleton<Registry>.Instance;
			}
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x000C7CB4 File Offset: 0x000C5EB4
		[Button]
		public void GenerateIcon()
		{
			LayerUtility.SetLayerRecursively(this.ItemContainer.gameObject, LayerMask.NameToLayer("IconGeneration"));
			Transform transform = null;
			for (int i = 0; i < this.ItemContainer.transform.childCount; i++)
			{
				if (this.ItemContainer.transform.GetChild(i).gameObject.activeSelf)
				{
					transform = this.ItemContainer.transform.GetChild(i);
				}
			}
			string text = this.OutputPath + "/" + transform.name + "_Icon.png";
			Texture2D texture = this.GetTexture(transform.transform);
			Debug.Log("Writing to: " + text);
			byte[] bytes = ImageConversion.EncodeToPNG(texture);
			File.WriteAllBytes(text, bytes);
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x000C7D6C File Offset: 0x000C5F6C
		public Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			IconGenerator.PackagingVisuals packagingVisuals = this.Visuals.Find((IconGenerator.PackagingVisuals x) => packagingID == x.PackagingID);
			if (packagingVisuals == null)
			{
				Debug.LogError(string.Concat(new string[]
				{
					"Failed to find visuals for packaging (",
					packagingID,
					") containing product (",
					productID,
					")"
				}));
				return null;
			}
			ItemDefinition itemDefinition = this.Registry._GetItem(productID);
			if (Application.isPlaying)
			{
				itemDefinition = Singleton<Registry>.Instance._GetItem(productID);
			}
			ProductDefinition productDefinition = itemDefinition as ProductDefinition;
			if (productDefinition == null)
			{
				Debug.LogError("Failed to find product definition for product (" + productID + ")");
				return null;
			}
			(productDefinition.GetDefaultInstance(1) as ProductItemInstance).SetupPackagingVisuals(packagingVisuals.Visuals);
			packagingVisuals.Visuals.gameObject.SetActive(true);
			Texture2D texture = this.GetTexture(packagingVisuals.Visuals.transform.parent);
			packagingVisuals.Visuals.gameObject.SetActive(false);
			return texture;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x000C7E70 File Offset: 0x000C6070
		public Texture2D GetTexture(Transform model)
		{
			this.MainContainer.gameObject.SetActive(true);
			bool activeSelf = this.ItemContainer.gameObject.activeSelf;
			this.ItemContainer.gameObject.SetActive(true);
			if (this.ModifyLighting)
			{
				RenderSettings.ambientMode = AmbientMode.Flat;
				RenderSettings.ambientLight = Color.white;
			}
			RuntimePreviewGenerator.CamPos = this.CameraPosition.transform.position;
			RuntimePreviewGenerator.CamRot = this.CameraPosition.transform.rotation;
			RuntimePreviewGenerator.Padding = 0f;
			RuntimePreviewGenerator.UseLocalBounds = true;
			RuntimePreviewGenerator.BackgroundColor = new Color32(0, 0, 0, 0);
			Texture2D result = RuntimePreviewGenerator.GenerateModelPreview(model, this.IconSize, this.IconSize, false, true);
			RenderSettings.ambientMode = AmbientMode.Trilight;
			this.MainContainer.gameObject.SetActive(false);
			this.ItemContainer.gameObject.SetActive(activeSelf);
			return result;
		}

		// Token: 0x04002215 RID: 8725
		public int IconSize = 512;

		// Token: 0x04002216 RID: 8726
		public string OutputPath;

		// Token: 0x04002217 RID: 8727
		public bool ModifyLighting = true;

		// Token: 0x04002218 RID: 8728
		[Header("References")]
		public Registry Registry;

		// Token: 0x04002219 RID: 8729
		public Camera CameraPosition;

		// Token: 0x0400221A RID: 8730
		public Transform MainContainer;

		// Token: 0x0400221B RID: 8731
		public Transform ItemContainer;

		// Token: 0x0400221C RID: 8732
		public GameObject Canvas;

		// Token: 0x0400221D RID: 8733
		public List<IconGenerator.PackagingVisuals> Visuals;

		// Token: 0x020006E0 RID: 1760
		[Serializable]
		public class PackagingVisuals
		{
			// Token: 0x0400221E RID: 8734
			public string PackagingID;

			// Token: 0x0400221F RID: 8735
			public FilledPackagingVisuals Visuals;
		}
	}
}
