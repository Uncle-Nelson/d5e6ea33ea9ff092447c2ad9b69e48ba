using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000A61 RID: 2657
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x06004787 RID: 18311 RVA: 0x0012B47C File Offset: 0x0012967C
		private void Update()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			List<WorldspacePopup> list = new List<WorldspacePopup>();
			List<WorldspacePopup> list2 = new List<WorldspacePopup>();
			for (int i = 0; i < WorldspacePopup.ActivePopups.Count; i++)
			{
				if (!this.popupsWithUI.Contains(WorldspacePopup.ActivePopups[i]) && this.ShouldCreateUI(WorldspacePopup.ActivePopups[i]))
				{
					list.Add(WorldspacePopup.ActivePopups[i]);
				}
			}
			for (int j = 0; j < this.popupsWithUI.Count; j++)
			{
				if (!WorldspacePopup.ActivePopups.Contains(this.popupsWithUI[j]) || !this.ShouldCreateUI(this.popupsWithUI[j]))
				{
					list2.Add(this.popupsWithUI[j]);
				}
			}
			foreach (WorldspacePopup worldspacePopup in list)
			{
				this.CreateWorldspaceIcon(worldspacePopup);
				if (worldspacePopup.DisplayOnHUD)
				{
					this.CreateHUDIcon(worldspacePopup);
				}
			}
			foreach (WorldspacePopup worldspacePopup2 in list2)
			{
				this.DestroyWorldspaceIcon(worldspacePopup2);
				if (worldspacePopup2.DisplayOnHUD)
				{
					this.DestroyHUDIcon(worldspacePopup2);
				}
			}
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0012B5EC File Offset: 0x001297EC
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			for (int i = 0; i < this.popupsWithUI.Count; i++)
			{
				if (PlayerSingleton<PlayerCamera>.Instance.transform.InverseTransformPoint(this.popupsWithUI[i].transform.position).z > 0f)
				{
					Vector3 vector = this.popupsWithUI[i].transform.position + this.popupsWithUI[i].WorldspaceOffset;
					Vector2 v = PlayerSingleton<PlayerCamera>.Instance.Camera.WorldToScreenPoint(vector);
					float num = 1f;
					if (this.popupsWithUI[i].ScaleWithDistance)
					{
						float f = Vector3.Distance(vector, PlayerSingleton<PlayerCamera>.Instance.transform.position);
						num = 1f / Mathf.Sqrt(f);
					}
					num *= this.popupsWithUI[i].SizeMultiplier;
					num *= 0.4f;
					this.popupsWithUI[i].WorldspaceUI.Rect.position = v;
					this.popupsWithUI[i].WorldspaceUI.Rect.localScale = new Vector3(num, num, 1f);
					this.popupsWithUI[i].WorldspaceUI.gameObject.SetActive(true);
				}
				else
				{
					this.popupsWithUI[i].WorldspaceUI.gameObject.SetActive(false);
				}
			}
			for (int j = 0; j < this.popupsWithUI.Count; j++)
			{
				if (this.popupsWithUI[j].HUDUI != null)
				{
					float num2 = Vector3.SignedAngle(Vector3.ProjectOnPlane(PlayerSingleton<PlayerCamera>.Instance.transform.forward, Vector3.up), (this.popupsWithUI[j].transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.position).normalized, Vector3.up);
					this.popupsWithUI[j].HUDUI.localRotation = Quaternion.Euler(0f, 0f, 0f - num2);
					this.popupsWithUI[j].HUDUIIcon.transform.up = Vector3.up;
					float num3 = 1f;
					float num4 = Mathf.Abs(num2);
					float num5 = 15f;
					if (num4 < 45f)
					{
						num3 = (num4 - num5) / (45f - num5);
						num3 = Mathf.Clamp01(num3);
					}
					this.popupsWithUI[j].HUDUICanvasGroup.alpha = Mathf.MoveTowards(this.popupsWithUI[j].HUDUICanvasGroup.alpha, num3, Time.deltaTime * 3f);
				}
			}
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0012B8D0 File Offset: 0x00129AD0
		private bool ShouldCreateUI(WorldspacePopup popup)
		{
			return Vector3.Distance(popup.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) <= popup.Range;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x0012B8FC File Offset: 0x00129AFC
		private WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			WorldspacePopupUI worldspacePopupUI = popup.CreateUI(this.WorldspaceContainer);
			this.activeWorldspaceUIs.Add(worldspacePopupUI);
			this.popupsWithUI.Add(popup);
			popup.WorldspaceUI = worldspacePopupUI;
			return worldspacePopupUI;
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x0012B938 File Offset: 0x00129B38
		private RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			RectTransform component = Object.Instantiate<GameObject>(this.HudIconContainerPrefab, this.HudContainer).GetComponent<RectTransform>();
			WorldspacePopupUI huduiicon = popup.CreateUI(component.Find("Container").GetComponent<RectTransform>());
			popup.HUDUI = component;
			popup.HUDUIIcon = huduiicon;
			popup.HUDUICanvasGroup = component.GetComponent<CanvasGroup>();
			popup.HUDUICanvasGroup.alpha = 0f;
			this.activeHUDUIs.Add(component);
			return component;
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0012B9AC File Offset: 0x00129BAC
		private void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
			for (int i = 0; i < this.activeWorldspaceUIs.Count; i++)
			{
				if (this.activeWorldspaceUIs[i].Popup == popup)
				{
					this.activeWorldspaceUIs[i].Destroy();
					this.activeWorldspaceUIs.RemoveAt(i);
					this.popupsWithUI.Remove(popup);
					return;
				}
			}
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0012BA14 File Offset: 0x00129C14
		private void DestroyHUDIcon(WorldspacePopup popup)
		{
			for (int i = 0; i < this.activeHUDUIs.Count; i++)
			{
				if (this.activeHUDUIs[i].GetComponentInChildren<WorldspacePopupUI>().Popup == popup)
				{
					this.activeHUDUIs[i].GetComponentInChildren<WorldspacePopupUI>().Destroy();
					Object.Destroy(this.activeHUDUIs[i].gameObject);
					this.activeHUDUIs.RemoveAt(i);
					return;
				}
			}
		}

		// Token: 0x040034F0 RID: 13552
		public const float WORLDSPACE_ICON_SCALE_MULTIPLIER = 0.4f;

		// Token: 0x040034F1 RID: 13553
		[Header("References")]
		public RectTransform WorldspaceContainer;

		// Token: 0x040034F2 RID: 13554
		public RectTransform HudContainer;

		// Token: 0x040034F3 RID: 13555
		[Header("Prefabs")]
		public GameObject HudIconContainerPrefab;

		// Token: 0x040034F4 RID: 13556
		private List<WorldspacePopupUI> activeWorldspaceUIs = new List<WorldspacePopupUI>();

		// Token: 0x040034F5 RID: 13557
		private List<RectTransform> activeHUDUIs = new List<RectTransform>();

		// Token: 0x040034F6 RID: 13558
		private List<WorldspacePopup> popupsWithUI = new List<WorldspacePopup>();
	}
}
