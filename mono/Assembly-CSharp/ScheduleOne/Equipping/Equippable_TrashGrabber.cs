using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Trash;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	// Token: 0x0200091A RID: 2330
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x00109F6B File Offset: 0x0010816B
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00109F72 File Offset: 0x00108172
		public static Equippable_TrashGrabber Instance { get; private set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x00109F7A File Offset: 0x0010817A
		public static bool IsEquipped
		{
			get
			{
				return Equippable_TrashGrabber.Instance != null;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x00109F87 File Offset: 0x00108187
		// (set) Token: 0x06003F09 RID: 16137 RVA: 0x00109F8F File Offset: 0x0010818F
		private float currentDropTime { get; set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06003F0A RID: 16138 RVA: 0x00109F98 File Offset: 0x00108198
		// (set) Token: 0x06003F0B RID: 16139 RVA: 0x00109FA0 File Offset: 0x001081A0
		private float timeSinceLastDrop { get; set; } = 100f;

		// Token: 0x06003F0C RID: 16140 RVA: 0x00109FAC File Offset: 0x001081AC
		public override void Equip(ItemInstance item)
		{
			base.Equip(item);
			this.trashGrabberInstance = (item as TrashGrabberInstance);
			TrashGrabberInstance trashGrabberInstance = this.trashGrabberInstance;
			trashGrabberInstance.onDataChanged = (Action)Delegate.Combine(trashGrabberInstance.onDataChanged, new Action(this.RefreshVisuals));
			this.defaultBinPosition = new Pose(this.Bin.localPosition, this.Bin.localRotation);
			this.defaultBinScale = this.Bin.localScale;
			Equippable_TrashGrabber.Instance = this;
			Singleton<InputPromptsCanvas>.Instance.LoadModule("trashgrabber");
			this.RefreshVisuals();
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x0010A040 File Offset: 0x00108240
		public override void Unequip()
		{
			base.Unequip();
			TrashGrabberInstance trashGrabberInstance = this.trashGrabberInstance;
			trashGrabberInstance.onDataChanged = (Action)Delegate.Remove(trashGrabberInstance.onDataChanged, new Action(this.RefreshVisuals));
			Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			Equippable_TrashGrabber.Instance = null;
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x0010A080 File Offset: 0x00108280
		protected override void Update()
		{
			base.Update();
			this.timeSinceLastDrop += Time.deltaTime;
			if (GameInput.GetButton(GameInput.ButtonCode.PrimaryClick))
			{
				this.currentDropTime = Mathf.Clamp(this.currentDropTime + Time.deltaTime, 0f, this.DropTime);
				if (this.trashGrabberInstance.GetTotalSize() > 0)
				{
					if (!this.TrashDropSound.isPlaying)
					{
						this.TrashDropSound.Play();
					}
					this.TrashDropSound.VolumeMultiplier = Mathf.Lerp(this.TrashDropSound.VolumeMultiplier, 1f, Time.deltaTime * 4f);
					if (this.currentDropTime >= this.DropTime - 0.05f && this.timeSinceLastDrop >= 0.15f)
					{
						this.timeSinceLastDrop = 0f;
						this.EjectTrash();
					}
				}
				else
				{
					this.TrashDropSound.VolumeMultiplier = Mathf.Lerp(this.TrashDropSound.VolumeMultiplier, 0f, Time.deltaTime * 4f);
				}
			}
			else
			{
				this.currentDropTime = Mathf.Clamp(this.currentDropTime - Time.deltaTime, 0f, this.DropTime);
				this.TrashDropSound.VolumeMultiplier = Mathf.Lerp(this.TrashDropSound.VolumeMultiplier, 0f, Time.deltaTime * 4f);
			}
			float t = Mathf.SmoothStep(0f, 1f, this.currentDropTime / this.DropTime);
			this.Bin.localPosition = Vector3.Lerp(this.defaultBinPosition.position, this.BinRaisedPosition.localPosition, t);
			this.Bin.localRotation = Quaternion.Lerp(this.defaultBinPosition.rotation, this.BinRaisedPosition.localRotation, t);
			this.Bin.localScale = Vector3.Lerp(this.defaultBinScale, this.BinRaisedPosition.localScale, t);
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x0010A264 File Offset: 0x00108464
		private void EjectTrash()
		{
			if (this.trashGrabberInstance.GetTotalSize() <= 0)
			{
				return;
			}
			List<string> trashIDs = this.trashGrabberInstance.GetTrashIDs();
			string id = trashIDs[trashIDs.Count - 1];
			this.trashGrabberInstance.RemoveTrash(id, 1);
			NetworkSingleton<TrashManager>.Instance.CreateTrashItem(id, PlayerSingleton<PlayerCamera>.Instance.transform.TransformPoint(this.TrashDropOffset), Random.rotation, PlayerSingleton<PlayerMovement>.Instance.Controller.velocity + PlayerSingleton<PlayerCamera>.Instance.transform.forward * this.DropForce, "", false);
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x0010A300 File Offset: 0x00108500
		private void OnDestroy()
		{
			if (Equippable_TrashGrabber.Instance == this)
			{
				Equippable_TrashGrabber.Instance = null;
			}
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x0010A318 File Offset: 0x00108518
		public void PickupTrash(TrashItem item)
		{
			this.GrabAnim.Stop();
			this.GrabAnim.Play();
			this.trashGrabberInstance.AddTrash(item.ID, 1);
			item.DestroyTrash();
			if (this.onPickup != null)
			{
				this.onPickup.Invoke();
			}
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x0010A367 File Offset: 0x00108567
		public int GetCapacity()
		{
			return 20 - this.trashGrabberInstance.GetTotalSize();
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x0010A378 File Offset: 0x00108578
		private void RefreshVisuals()
		{
			float num = Mathf.Clamp01((float)this.trashGrabberInstance.GetTotalSize() / 20f);
			this.TrashContent.localPosition = Vector3.Lerp(this.TrashContent_Min.localPosition, this.TrashContent_Max.localPosition, num);
			this.TrashContent.localScale = Vector3.Lerp(this.TrashContent_Min.localScale, this.TrashContent_Max.localScale, num);
			this.TrashContent.gameObject.SetActive(num > 0f);
		}

		// Token: 0x04002D37 RID: 11575
		public const float TrashDropSpacing = 0.15f;

		// Token: 0x04002D38 RID: 11576
		[Header("References")]
		public Transform TrashContent;

		// Token: 0x04002D39 RID: 11577
		public Transform TrashContent_Min;

		// Token: 0x04002D3A RID: 11578
		public Transform TrashContent_Max;

		// Token: 0x04002D3B RID: 11579
		public Animation GrabAnim;

		// Token: 0x04002D3C RID: 11580
		public Transform Bin;

		// Token: 0x04002D3D RID: 11581
		public Transform BinRaisedPosition;

		// Token: 0x04002D3E RID: 11582
		public AudioSourceController TrashDropSound;

		// Token: 0x04002D3F RID: 11583
		[Header("Settings")]
		public float DropTime = 0.4f;

		// Token: 0x04002D40 RID: 11584
		public float DropForce = 1f;

		// Token: 0x04002D41 RID: 11585
		public Vector3 TrashDropOffset;

		// Token: 0x04002D42 RID: 11586
		public UnityEvent onPickup;

		// Token: 0x04002D45 RID: 11589
		private TrashGrabberInstance trashGrabberInstance;

		// Token: 0x04002D46 RID: 11590
		private Pose defaultBinPosition;

		// Token: 0x04002D47 RID: 11591
		private Vector3 defaultBinScale;
	}
}
