using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ScheduleOne.UI.Input
{
	// Token: 0x02000B28 RID: 2856
	[ExecuteInEditMode]
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0013F70F File Offset: 0x0013D90F
		private InputPromptsManager manager
		{
			get
			{
				if (!Singleton<InputPromptsManager>.InstanceExists)
				{
					return GameObject.Find("@InputPromptsManager").GetComponent<InputPromptsManager>();
				}
				return Singleton<InputPromptsManager>.Instance;
			}
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x0013F72D File Offset: 0x0013D92D
		private void OnEnable()
		{
			this.RefreshPromptImages();
			this.Container.gameObject.SetActive(true);
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x0013F746 File Offset: 0x0013D946
		private void OnDisable()
		{
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x000045B1 File Offset: 0x000027B1
		private void Update()
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x0013F75C File Offset: 0x0013D95C
		private void RefreshPromptImages()
		{
			this.AppliedAlignment = this.Alignment;
			this.displayedActions.Clear();
			this.displayedActions.AddRange(this.Actions);
			int childCount = this.ImagesContainer.childCount;
			Transform[] array = new Transform[childCount];
			for (int i = 0; i < childCount; i++)
			{
				array[i] = this.ImagesContainer.GetChild(i);
			}
			for (int j = 0; j < childCount; j++)
			{
				if (Application.isPlaying)
				{
					Object.Destroy(array[j].gameObject);
				}
				else
				{
					Object.DestroyImmediate(array[j].gameObject);
				}
			}
			this.promptImages.Clear();
			float num = 0f;
			for (int k = 0; k < this.Actions.Count; k++)
			{
				string text;
				string controlPath;
				InputActionRebindingExtensions.GetBindingDisplayString(this.Actions[k].action, 0, ref text, ref controlPath, 0);
				PromptImage promptImage = this.manager.GetPromptImage(controlPath, this.ImagesContainer);
				if (!(promptImage == null))
				{
					num += promptImage.Width;
					foreach (Image image in promptImage.transform.GetComponentsInChildren<Image>())
					{
						if (this.OverridePromptImageColor)
						{
							image.color = this.PromptImageColor;
						}
					}
					this.promptImages.Add(promptImage);
				}
			}
			num += InputPrompt.Spacing * (float)this.Actions.Count;
			this.LabelComponent.text = this.Label;
			this.LabelComponent.ForceMeshUpdate(false, false);
			num += this.LabelComponent.preferredWidth;
			float num2 = 0f;
			if (this.Alignment == InputPrompt.EInputPromptAlignment.Left)
			{
				num2 = -InputPrompt.Spacing;
			}
			else if (this.Alignment == InputPrompt.EInputPromptAlignment.Middle)
			{
				num2 = -num / 2f;
			}
			else if (this.Alignment == InputPrompt.EInputPromptAlignment.Right)
			{
				num2 = InputPrompt.Spacing;
			}
			float num3 = 1f;
			if (this.Alignment == InputPrompt.EInputPromptAlignment.Left)
			{
				this.LabelComponent.alignment = TextAlignmentOptions.CaplineRight;
				num3 = -1f;
			}
			else
			{
				this.LabelComponent.alignment = TextAlignmentOptions.CaplineLeft;
			}
			float num4 = 0f;
			for (int m = 0; m < this.promptImages.Count; m++)
			{
				this.promptImages[m].GetComponent<RectTransform>().anchoredPosition = new Vector2(num2 + num4 * num3 + this.promptImages[m].Width * 0.5f * num3, 0f);
				num4 += this.promptImages[m].Width + InputPrompt.Spacing;
			}
			this.LabelComponent.GetComponent<RectTransform>().anchoredPosition = new Vector2(num2 + num4 * num3 + this.LabelComponent.GetComponent<RectTransform>().sizeDelta.x * 0.5f * num3, 0f);
			this.UpdateShade();
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0013FA37 File Offset: 0x0013DC37
		public void SetLabel(string label)
		{
			this.Label = label;
			this.LabelComponent.text = this.Label;
			this.UpdateShade();
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x0013FA58 File Offset: 0x0013DC58
		private void UpdateShade()
		{
			float num = this.LabelComponent.preferredWidth + 90f;
			this.Shade.sizeDelta = new Vector2(num, this.Shade.sizeDelta.y);
			if (this.Alignment == InputPrompt.EInputPromptAlignment.Left)
			{
				this.Shade.anchoredPosition = new Vector2(-num / 2f, 0f);
				return;
			}
			if (this.Alignment == InputPrompt.EInputPromptAlignment.Middle)
			{
				this.Shade.anchoredPosition = new Vector2(0f, 0f);
				return;
			}
			if (this.Alignment == InputPrompt.EInputPromptAlignment.Right)
			{
				this.Shade.anchoredPosition = new Vector2(num / 2f, 0f);
			}
		}

		// Token: 0x04003908 RID: 14600
		public static float Spacing = 10f;

		// Token: 0x04003909 RID: 14601
		[Header("Settings")]
		public List<InputActionReference> Actions = new List<InputActionReference>();

		// Token: 0x0400390A RID: 14602
		public string Label;

		// Token: 0x0400390B RID: 14603
		public InputPrompt.EInputPromptAlignment Alignment;

		// Token: 0x0400390C RID: 14604
		[Header("References")]
		public RectTransform Container;

		// Token: 0x0400390D RID: 14605
		public RectTransform ImagesContainer;

		// Token: 0x0400390E RID: 14606
		public TextMeshProUGUI LabelComponent;

		// Token: 0x0400390F RID: 14607
		public RectTransform Shade;

		// Token: 0x04003910 RID: 14608
		[Header("Settings")]
		public bool OverridePromptImageColor;

		// Token: 0x04003911 RID: 14609
		public Color PromptImageColor = Color.white;

		// Token: 0x04003912 RID: 14610
		[SerializeField]
		private List<PromptImage> promptImages = new List<PromptImage>();

		// Token: 0x04003913 RID: 14611
		private List<InputActionReference> displayedActions = new List<InputActionReference>();

		// Token: 0x04003914 RID: 14612
		private InputPrompt.EInputPromptAlignment AppliedAlignment;

		// Token: 0x02000B29 RID: 2857
		public enum EInputPromptAlignment
		{
			// Token: 0x04003916 RID: 14614
			Left,
			// Token: 0x04003917 RID: 14615
			Middle,
			// Token: 0x04003918 RID: 14616
			Right
		}
	}
}
