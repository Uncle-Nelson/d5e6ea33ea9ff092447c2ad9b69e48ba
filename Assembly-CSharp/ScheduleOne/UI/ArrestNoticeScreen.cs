using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.Map;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A1C RID: 2588
	public class ArrestNoticeScreen : Singleton<ArrestNoticeScreen>
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060045CD RID: 17869 RVA: 0x00124E0A File Offset: 0x0012300A
		// (set) Token: 0x060045CE RID: 17870 RVA: 0x00124E12 File Offset: 0x00123012
		public bool isOpen { get; protected set; }

		// Token: 0x060045CF RID: 17871 RVA: 0x00124E1C File Offset: 0x0012301C
		protected override void Awake()
		{
			base.Awake();
			this.isOpen = false;
			this.Canvas.enabled = false;
			this.CanvasGroup.alpha = 0f;
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 20);
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.PlayerSpawned));
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00124E85 File Offset: 0x00123085
		private void PlayerSpawned()
		{
			Player.Local.onArrested.AddListener(new UnityAction(this.RecordCrimes));
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00124EA2 File Offset: 0x001230A2
		private void Exit(ExitAction action)
		{
			if (action.used)
			{
				return;
			}
			if (!this.isOpen)
			{
				return;
			}
			if (action.exitType == ExitType.Escape)
			{
				action.used = true;
				this.Close();
			}
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00124ECC File Offset: 0x001230CC
		public void Open()
		{
			this.ClearEntries();
			this.isOpen = true;
			this.Canvas.enabled = true;
			this.CanvasGroup.alpha = 1f;
			this.CanvasGroup.interactable = true;
			Singleton<PostProcessingManager>.Instance.SetBlur(1f);
			Crime[] array = this.recordedCrimes.Keys.ToArray<Crime>();
			for (int i = 0; i < array.Length; i++)
			{
				Object.Instantiate<RectTransform>(this.CrimeEntryPrefab, this.CrimeEntryContainer).GetComponentInChildren<TextMeshProUGUI>().text = this.recordedCrimes[array[i]].ToString() + "x " + array[i].CrimeName.ToLower();
			}
			List<string> list = PenaltyHandler.ProcessCrimeList(this.recordedCrimes);
			this.ConfiscateItems(EStealthLevel.None);
			for (int j = 0; j < list.Count; j++)
			{
				Object.Instantiate<RectTransform>(this.PenaltyEntryPrefab, this.PenaltyEntryContainer).GetComponentInChildren<TextMeshProUGUI>().text = list[j];
			}
			if (this.vehicle != null && !this.vehicle.isOccupied)
			{
				Transform[] possessedVehicleSpawnPoints = Singleton<Map>.Instance.PoliceStation.PossessedVehicleSpawnPoints;
				Transform target = possessedVehicleSpawnPoints[Random.Range(0, possessedVehicleSpawnPoints.Length - 1)];
				Tuple<Vector3, Quaternion> alignmentTransform = this.vehicle.GetAlignmentTransform(target, EParkingAlignment.RearToKerb);
				this.vehicle.SetTransform_Server(alignmentTransform.Item1, alignmentTransform.Item2);
			}
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			Player.Deactivate(true);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x0012504B File Offset: 0x0012324B
		public void Close()
		{
			if (!this.CanvasGroup.interactable || !this.isOpen)
			{
				return;
			}
			this.CanvasGroup.interactable = false;
			base.StartCoroutine(this.<Close>g__CloseRoutine|17_0());
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x0012507C File Offset: 0x0012327C
		public void RecordCrimes()
		{
			Debug.Log("Crimes recorded");
			this.recordedCrimes.Clear();
			if (Player.Local.LastDrivenVehicle != null && (Player.Local.TimeSinceVehicleExit < 30f || Player.Local.CrimeData.IsCrimeOnRecord(typeof(TransportingIllicitItems))))
			{
				this.vehicle = Player.Local.LastDrivenVehicle;
			}
			for (int i = 0; i < Player.Local.CrimeData.Crimes.Keys.Count; i++)
			{
				this.recordedCrimes.Add(Player.Local.CrimeData.Crimes.Keys.ElementAt(i), Player.Local.CrimeData.Crimes.Values.ElementAt(i));
			}
			if (Player.Local.CrimeData.EvadedArrest)
			{
				this.recordedCrimes.Add(new Evading(), 1);
			}
			this.RecordPossession(EStealthLevel.None);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00125178 File Offset: 0x00123378
		private void RecordPossession(EStealthLevel maxStealthLevel)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			List<ItemSlot> allInventorySlots = PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots();
			if (Player.Local.LastDrivenVehicle != null && Player.Local.TimeSinceVehicleExit < 30f && Player.Local.LastDrivenVehicle.Storage != null)
			{
				allInventorySlots.AddRange(Player.Local.LastDrivenVehicle.Storage.ItemSlots);
			}
			foreach (ItemSlot itemSlot in allInventorySlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					if (itemSlot.ItemInstance is ProductItemInstance)
					{
						ProductItemInstance productItemInstance = itemSlot.ItemInstance as ProductItemInstance;
						if (productItemInstance.AppliedPackaging == null || productItemInstance.AppliedPackaging.StealthLevel <= maxStealthLevel)
						{
							switch (itemSlot.ItemInstance.Definition.legalStatus)
							{
							case ELegalStatus.ControlledSubstance:
								num += productItemInstance.Quantity;
								break;
							case ELegalStatus.LowSeverityDrug:
								num2 += productItemInstance.Quantity;
								break;
							case ELegalStatus.ModerateSeverityDrug:
								num3 += productItemInstance.Quantity;
								break;
							case ELegalStatus.HighSeverityDrug:
								num4 += productItemInstance.Quantity;
								break;
							}
						}
					}
					else
					{
						switch (itemSlot.ItemInstance.Definition.legalStatus)
						{
						case ELegalStatus.ControlledSubstance:
							num += itemSlot.ItemInstance.Quantity;
							break;
						case ELegalStatus.LowSeverityDrug:
							num2 += itemSlot.ItemInstance.Quantity;
							break;
						case ELegalStatus.ModerateSeverityDrug:
							num3 += itemSlot.ItemInstance.Quantity;
							break;
						case ELegalStatus.HighSeverityDrug:
							num4 += itemSlot.ItemInstance.Quantity;
							break;
						}
					}
				}
			}
			if (num > 0)
			{
				this.recordedCrimes.Add(new PossessingControlledSubstances(), num);
			}
			if (num2 > 0)
			{
				this.recordedCrimes.Add(new PossessingLowSeverityDrug(), num2);
			}
			if (num3 > 0)
			{
				this.recordedCrimes.Add(new PossessingModerateSeverityDrug(), num3);
			}
			if (num4 > 0)
			{
				this.recordedCrimes.Add(new PossessingHighSeverityDrug(), num4);
			}
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x001253B4 File Offset: 0x001235B4
		private void ConfiscateItems(EStealthLevel maxStealthLevel)
		{
			List<ItemSlot> allInventorySlots = PlayerSingleton<PlayerInventory>.Instance.GetAllInventorySlots();
			if (Player.Local.LastDrivenVehicle != null && Player.Local.TimeSinceVehicleExit < 30f && Player.Local.LastDrivenVehicle.Storage != null)
			{
				allInventorySlots.AddRange(Player.Local.LastDrivenVehicle.Storage.ItemSlots);
			}
			foreach (ItemSlot itemSlot in allInventorySlots)
			{
				if (itemSlot.ItemInstance != null)
				{
					if (itemSlot.ItemInstance is ProductItemInstance)
					{
						ProductItemInstance productItemInstance = itemSlot.ItemInstance as ProductItemInstance;
						if (productItemInstance.AppliedPackaging == null || productItemInstance.AppliedPackaging.StealthLevel <= maxStealthLevel)
						{
							itemSlot.ClearStoredInstance(false);
						}
					}
					else if (itemSlot.ItemInstance.Definition.legalStatus != ELegalStatus.Legal)
					{
						itemSlot.ClearStoredInstance(false);
					}
				}
			}
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x001254BC File Offset: 0x001236BC
		private void ClearEntries()
		{
			int childCount = this.CrimeEntryContainer.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Object.Destroy(this.CrimeEntryContainer.GetChild(i).gameObject);
			}
			childCount = this.PenaltyEntryContainer.childCount;
			for (int j = 0; j < childCount; j++)
			{
				Object.Destroy(this.PenaltyEntryContainer.GetChild(j).gameObject);
			}
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x00125538 File Offset: 0x00123738
		[CompilerGenerated]
		private IEnumerator <Close>g__CloseRoutine|17_0()
		{
			float lerpTime = 0.3f;
			for (float i = 0f; i < lerpTime; i += Time.deltaTime)
			{
				this.CanvasGroup.alpha = Mathf.Lerp(1f, 0f, i / lerpTime);
				Singleton<PostProcessingManager>.Instance.SetBlur(this.CanvasGroup.alpha);
				yield return new WaitForEndOfFrame();
			}
			this.CanvasGroup.alpha = 0f;
			this.Canvas.enabled = false;
			Singleton<PostProcessingManager>.Instance.SetBlur(0f);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			Player.Activate();
			this.ClearEntries();
			this.isOpen = false;
			yield break;
		}

		// Token: 0x04003369 RID: 13161
		public const float VEHICLE_POSSESSION_TIMEOUT = 30f;

		// Token: 0x0400336B RID: 13163
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x0400336C RID: 13164
		public CanvasGroup CanvasGroup;

		// Token: 0x0400336D RID: 13165
		public RectTransform CrimeEntryContainer;

		// Token: 0x0400336E RID: 13166
		public RectTransform PenaltyEntryContainer;

		// Token: 0x0400336F RID: 13167
		[Header("Prefabs")]
		public RectTransform CrimeEntryPrefab;

		// Token: 0x04003370 RID: 13168
		public RectTransform PenaltyEntryPrefab;

		// Token: 0x04003371 RID: 13169
		private Dictionary<Crime, int> recordedCrimes = new Dictionary<Crime, int>();

		// Token: 0x04003372 RID: 13170
		private LandVehicle vehicle;
	}
}
