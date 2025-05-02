using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Compass;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A57 RID: 2647
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x0012A7D1 File Offset: 0x001289D1
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x0012A7D9 File Offset: 0x001289D9
		public bool IsOpen { get; private set; }

		// Token: 0x06004748 RID: 18248 RVA: 0x0012A7E2 File Offset: 0x001289E2
		protected override void Awake()
		{
			base.Awake();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 1);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0012A7FC File Offset: 0x001289FC
		protected override void Start()
		{
			base.Start();
			this.confirmText_Online.text = "Confirm (" + MoneyManager.FormatAmount(VehicleModMenu.repaintCost, false, true) + ")";
			for (int i = 0; i < Singleton<VehicleColors>.Instance.colorLibrary.Count; i++)
			{
				RectTransform component = Object.Instantiate<GameObject>(this.buttonPrefab, this.buttonContainer).GetComponent<RectTransform>();
				component.anchoredPosition = new Vector2((0.5f + (float)this.colorButtons.Count) * component.sizeDelta.x, component.anchoredPosition.y);
				component.Find("Image").GetComponent<Image>().color = Singleton<VehicleColors>.Instance.colorLibrary[i].UIColor;
				EVehicleColor c = Singleton<VehicleColors>.Instance.colorLibrary[i].color;
				this.colorButtons.Add(component);
				this.colorToButton.Add(c, component);
				component.GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
				{
					this.ColorClicked(c);
				}));
			}
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x0012A931 File Offset: 0x00128B31
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.IsOpen)
			{
				return;
			}
			if (this.openCloseRoutine != null)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0012A964 File Offset: 0x00128B64
		protected virtual void Update()
		{
			if (this.IsOpen)
			{
				this.UpdateConfirmButton();
			}
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x0012A974 File Offset: 0x00128B74
		public void Open(LandVehicle vehicle)
		{
			this.currentVehicle = vehicle;
			this.selectedColor = vehicle.OwnedColor;
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			Singleton<CompassManager>.Instance.SetVisible(false);
			this.openCloseRoutine = base.StartCoroutine(this.<Open>g__Close|24_0());
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x0012A9C1 File Offset: 0x00128BC1
		public void Close()
		{
			if (this.currentVehicle != null)
			{
				this.currentVehicle.ApplyOwnedColor();
			}
			this.openCloseRoutine = base.StartCoroutine(this.<Close>g__Close|25_0());
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x0012A9EE File Offset: 0x00128BEE
		public void ColorClicked(EVehicleColor col)
		{
			this.selectedColor = col;
			this.currentVehicle.ApplyColor(col);
			this.RefreshSelectionIndicator();
			this.UpdateConfirmButton();
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x0012AA10 File Offset: 0x00128C10
		private void UpdateConfirmButton()
		{
			bool flag = NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance >= VehicleModMenu.repaintCost;
			this.confirmButton_Online.interactable = (flag && this.selectedColor != this.currentVehicle.OwnedColor);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0012AA5C File Offset: 0x00128C5C
		private void RefreshSelectionIndicator()
		{
			this.tempIndicator.position = this.colorToButton[this.selectedColor].position;
			this.permIndicator.position = this.colorToButton[this.currentVehicle.OwnedColor].position;
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0012AAB0 File Offset: 0x00128CB0
		public void ConfirmButtonClicked()
		{
			NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Vehicle repaint", -VehicleModMenu.repaintCost, 1f, string.Empty);
			NetworkSingleton<MoneyManager>.Instance.CashSound.Play();
			this.currentVehicle.SendOwnedColor(this.selectedColor);
			this.RefreshSelectionIndicator();
			if (this.onPaintPurchased != null)
			{
				this.onPaintPurchased.Invoke();
			}
			this.Close();
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x0012AB4C File Offset: 0x00128D4C
		[CompilerGenerated]
		private IEnumerator <Open>g__Close|24_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.6f);
			this.IsOpen = true;
			this.canvas.enabled = true;
			this.currentVehicle.AlignTo(this.VehiclePosition, EParkingAlignment.RearToKerb, true);
			this.RefreshSelectionIndicator();
			this.UpdateConfirmButton();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraPosition.position, this.CameraPosition.rotation, 0f, false);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(60f, 0f);
			Singleton<InputPromptsCanvas>.Instance.LoadModule("exitonly");
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			this.openCloseRoutine = null;
			yield break;
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0012AB5B File Offset: 0x00128D5B
		[CompilerGenerated]
		private IEnumerator <Close>g__Close|25_0()
		{
			Singleton<BlackOverlay>.Instance.Open(0.5f);
			yield return new WaitForSeconds(0.6f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			this.currentVehicle = null;
			this.IsOpen = false;
			this.canvas.enabled = false;
			Singleton<CompassManager>.Instance.SetVisible(true);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, true);
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0f);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			Singleton<BlackOverlay>.Instance.Close(0.5f);
			this.openCloseRoutine = null;
			yield break;
		}

		// Token: 0x040034AF RID: 13487
		public static float repaintCost = 100f;

		// Token: 0x040034B1 RID: 13489
		[Header("UI References")]
		[SerializeField]
		protected Canvas canvas;

		// Token: 0x040034B2 RID: 13490
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x040034B3 RID: 13491
		[SerializeField]
		protected RectTransform tempIndicator;

		// Token: 0x040034B4 RID: 13492
		[SerializeField]
		protected RectTransform permIndicator;

		// Token: 0x040034B5 RID: 13493
		[SerializeField]
		protected Button confirmButton_Online;

		// Token: 0x040034B6 RID: 13494
		[SerializeField]
		protected TextMeshProUGUI confirmText_Online;

		// Token: 0x040034B7 RID: 13495
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x040034B8 RID: 13496
		public Transform VehiclePosition;

		// Token: 0x040034B9 RID: 13497
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x040034BA RID: 13498
		public UnityEvent onPaintPurchased;

		// Token: 0x040034BB RID: 13499
		protected LandVehicle currentVehicle;

		// Token: 0x040034BC RID: 13500
		protected List<RectTransform> colorButtons = new List<RectTransform>();

		// Token: 0x040034BD RID: 13501
		protected Dictionary<EVehicleColor, RectTransform> colorToButton = new Dictionary<EVehicleColor, RectTransform>();

		// Token: 0x040034BE RID: 13502
		protected EVehicleColor selectedColor = EVehicleColor.White;

		// Token: 0x040034BF RID: 13503
		private Coroutine openCloseRoutine;
	}
}
