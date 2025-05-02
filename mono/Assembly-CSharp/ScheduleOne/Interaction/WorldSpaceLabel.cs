using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200061B RID: 1563
	public class WorldSpaceLabel
	{
		// Token: 0x060028FE RID: 10494 RVA: 0x000A90B8 File Offset: 0x000A72B8
		public WorldSpaceLabel(string _text, Vector3 _position)
		{
			this.text = _text;
			this.position = _position;
			this.rect = Object.Instantiate<GameObject>(Singleton<InteractionManager>.Instance.WSLabelPrefab, Singleton<InteractionManager>.Instance.wsLabelContainer).GetComponent<RectTransform>();
			this.textComp = this.rect.GetComponent<Text>();
			Singleton<InteractionManager>.Instance.activeWSlabels.Add(this);
			this.RefreshDisplay();
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x000A915C File Offset: 0x000A735C
		public void RefreshDisplay()
		{
			if (PlayerSingleton<PlayerCamera>.Instance.transform.InverseTransformPoint(this.position).z < -3f || !this.active)
			{
				this.rect.gameObject.SetActive(false);
				return;
			}
			this.textComp.text = this.text;
			this.textComp.color = this.color;
			this.rect.position = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(this.position);
			float num = Mathf.Clamp(1f / Vector3.Distance(this.position, PlayerSingleton<PlayerCamera>.Instance.transform.position), 0f, 1f) * Singleton<InteractionManager>.Instance.displaySizeMultiplier * this.scale;
			this.rect.localScale = new Vector3(num, num, 1f);
			this.rect.gameObject.SetActive(true);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x000A9255 File Offset: 0x000A7455
		public void Destroy()
		{
			Singleton<InteractionManager>.Instance.activeWSlabels.Remove(this);
			this.rect.gameObject.SetActive(false);
			Object.Destroy(this.rect.gameObject);
		}

		// Token: 0x04001E1A RID: 7706
		public string text = string.Empty;

		// Token: 0x04001E1B RID: 7707
		public Color32 color = Color.white;

		// Token: 0x04001E1C RID: 7708
		public Vector3 position = Vector3.zero;

		// Token: 0x04001E1D RID: 7709
		public float scale = 1f;

		// Token: 0x04001E1E RID: 7710
		public RectTransform rect;

		// Token: 0x04001E1F RID: 7711
		public Text textComp;

		// Token: 0x04001E20 RID: 7712
		public bool active = true;
	}
}
