using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Trash
{
	// Token: 0x02000829 RID: 2089
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x000F1940 File Offset: 0x000EFB40
		public static bool IsHoveringTrash
		{
			get
			{
				return Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.activeSelf;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x000F1956 File Offset: 0x000EFB56
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x000F195E File Offset: 0x000EFB5E
		public bool IsBaggingTrash { get; private set; }

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06003922 RID: 14626 RVA: 0x000F1967 File Offset: 0x000EFB67
		// (set) Token: 0x06003923 RID: 14627 RVA: 0x000F196F File Offset: 0x000EFB6F
		public bool IsPickingUpTrash { get; private set; }

		// Token: 0x06003924 RID: 14628 RVA: 0x000F1978 File Offset: 0x000EFB78
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(false);
			Singleton<TrashBagCanvas>.Instance.Open();
			this.PickupAreaProjector.transform.SetParent(NetworkSingleton<GameManager>.Instance.Temp);
			this.PickupAreaProjector.transform.localScale = Vector3.one;
			this.PickupAreaProjector.transform.forward = -Vector3.up;
			this.PickupAreaProjector.gameObject.SetActive(false);
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x000F1A05 File Offset: 0x000EFC05
		public override void Unequip()
		{
			base.Unequip();
			Singleton<TrashBagCanvas>.Instance.Close();
			Object.Destroy(this.PickupAreaProjector.gameObject);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x000F1A28 File Offset: 0x000EFC28
		protected override void Update()
		{
			base.Update();
			Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(false);
			TrashContainer hoveredTrashContainer = this.GetHoveredTrashContainer();
			this.PickupAreaProjector.gameObject.SetActive(false);
			if (this.IsBaggingTrash)
			{
				if (!GameInput.GetButton(GameInput.ButtonCode.Interact) || hoveredTrashContainer != this._baggedContainer)
				{
					this.StopBagTrash(false);
					return;
				}
				this._bagTrashTime += Time.deltaTime;
				Singleton<TrashBagCanvas>.Instance.InputPrompt.SetLabel("Bag trash");
				Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(true);
				Singleton<HUD>.Instance.ShowRadialIndicator(this._bagTrashTime / 1f);
				if (this._bagTrashTime >= 1f)
				{
					this.StopBagTrash(true);
				}
				return;
			}
			else if (this.IsPickingUpTrash)
			{
				List<TrashItem> list = new List<TrashItem>();
				RaycastHit hit;
				if (this.RaycastLook(out hit) && this.IsPickupLocationValid(hit))
				{
					list = this.GetTrashItemsAtPoint(hit.point);
				}
				if (!GameInput.GetButton(GameInput.ButtonCode.Interact) || list.Count == 0)
				{
					this.StopPickup(false);
					return;
				}
				this._pickupTrashTime += Time.deltaTime;
				Singleton<TrashBagCanvas>.Instance.InputPrompt.SetLabel("Bag trash");
				Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(true);
				Singleton<HUD>.Instance.ShowRadialIndicator(this._pickupTrashTime / 1f);
				this.PickupAreaProjector.transform.position = hit.point + Vector3.up * 0.1f;
				this.PickupAreaProjector.gameObject.SetActive(true);
				if (this._pickupTrashTime >= 1f)
				{
					this.StopPickup(true);
				}
				return;
			}
			else
			{
				if (hoveredTrashContainer != null && hoveredTrashContainer.CanBeBagged())
				{
					this._baggedContainer = hoveredTrashContainer;
					Singleton<TrashBagCanvas>.Instance.InputPrompt.SetLabel("Bag trash");
					Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(true);
					if (GameInput.GetButtonDown(GameInput.ButtonCode.Interact))
					{
						this.StartBagTrash(hoveredTrashContainer);
					}
					return;
				}
				RaycastHit hit2;
				if (hoveredTrashContainer == null && this.RaycastLook(out hit2) && this.IsPickupLocationValid(hit2))
				{
					this.PickupAreaProjector.transform.position = hit2.point + Vector3.up * 0.1f;
					this.PickupAreaProjector.gameObject.SetActive(true);
					if (this.GetTrashItemsAtPoint(hit2.point).Count > 0)
					{
						this.PickupAreaProjector.fadeFactor = 0.5f;
						Singleton<TrashBagCanvas>.Instance.InputPrompt.SetLabel("Bag trash");
						Singleton<TrashBagCanvas>.Instance.InputPrompt.gameObject.SetActive(true);
						if (GameInput.GetButtonDown(GameInput.ButtonCode.Interact))
						{
							this.StartPickup();
							return;
						}
					}
					else
					{
						this.PickupAreaProjector.fadeFactor = 0.05f;
					}
				}
				return;
			}
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x000F1D08 File Offset: 0x000EFF08
		private TrashContainer GetHoveredTrashContainer()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(2.75f, out raycastHit, Singleton<InteractionManager>.Instance.Interaction_SearchMask, true, 0f))
			{
				TrashContainer componentInParent = raycastHit.collider.GetComponentInParent<TrashContainer>();
				if (componentInParent != null)
				{
					return componentInParent;
				}
			}
			return null;
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x000F1D51 File Offset: 0x000EFF51
		private bool RaycastLook(out RaycastHit hit)
		{
			return PlayerSingleton<PlayerCamera>.Instance.LookRaycast(3f, out hit, this.PickupLookMask, true, 0f);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x000F1D6F File Offset: 0x000EFF6F
		private bool IsPickupLocationValid(RaycastHit hit)
		{
			return Vector3.Angle(hit.normal, Vector3.up) <= 5f;
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x000F1D8C File Offset: 0x000EFF8C
		private List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			Collider[] array = Physics.OverlapSphere(pos, 0.45f, Singleton<InteractionManager>.Instance.Interaction_SearchMask, 2);
			List<TrashItem> list = new List<TrashItem>();
			Collider[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				TrashItem componentInParent = array2[i].GetComponentInParent<TrashItem>();
				if (componentInParent != null && componentInParent.CanGoInContainer)
				{
					list.Add(componentInParent);
				}
			}
			return list;
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x000F1DEB File Offset: 0x000EFFEB
		private void StartBagTrash(TrashContainer container)
		{
			this.IsBaggingTrash = true;
			this._bagTrashTime = 0f;
			this._baggedContainer = container;
			this.RustleSound.Play();
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x000F1E14 File Offset: 0x000F0014
		private void StopBagTrash(bool complete)
		{
			this.IsBaggingTrash = false;
			this._bagTrashTime = 0f;
			this.RustleSound.Stop();
			if (complete)
			{
				this._baggedContainer.BagTrash();
				this.BagSound.PlayOneShot(true);
				this.itemInstance.ChangeQuantity(-1);
			}
			this._baggedContainer = null;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x000F1E6B File Offset: 0x000F006B
		private void StartPickup()
		{
			this.IsPickingUpTrash = true;
			this._pickupTrashTime = 0f;
			this.RustleSound.Play();
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x000F1E8C File Offset: 0x000F008C
		private void StopPickup(bool complete)
		{
			this.IsPickingUpTrash = false;
			this._pickupTrashTime = 0f;
			this.PickupAreaProjector.gameObject.SetActive(false);
			this.RustleSound.Stop();
			if (complete)
			{
				List<TrashItem> trashItemsAtPoint = this.GetTrashItemsAtPoint(this.PickupAreaProjector.transform.position);
				foreach (TrashItem trashItem in trashItemsAtPoint)
				{
					trashItem.DestroyTrash();
				}
				this.itemInstance.ChangeQuantity(-1);
				TrashContentData content = new TrashContentData(trashItemsAtPoint);
				NetworkSingleton<TrashManager>.Instance.CreateTrashBag(NetworkSingleton<TrashManager>.Instance.TrashBagPrefab.ID, this.PickupAreaProjector.transform.position + Vector3.up * 0.4f, Quaternion.identity, content, default(Vector3), "", false);
				this.BagSound.PlayOneShot(true);
			}
		}

		// Token: 0x0400295F RID: 10591
		public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75f;

		// Token: 0x04002960 RID: 10592
		public const float BAG_TRASH_TIME = 1f;

		// Token: 0x04002961 RID: 10593
		public const float PICKUP_RANGE = 3f;

		// Token: 0x04002962 RID: 10594
		public const float PICKUP_AREA_RADIUS = 0.5f;

		// Token: 0x04002965 RID: 10597
		public LayerMask PickupLookMask;

		// Token: 0x04002966 RID: 10598
		[Header("References")]
		public DecalProjector PickupAreaProjector;

		// Token: 0x04002967 RID: 10599
		public AudioSourceController RustleSound;

		// Token: 0x04002968 RID: 10600
		public AudioSourceController BagSound;

		// Token: 0x04002969 RID: 10601
		private float _bagTrashTime;

		// Token: 0x0400296A RID: 10602
		private TrashContainer _baggedContainer;

		// Token: 0x0400296B RID: 10603
		private float _pickupTrashTime;
	}
}
