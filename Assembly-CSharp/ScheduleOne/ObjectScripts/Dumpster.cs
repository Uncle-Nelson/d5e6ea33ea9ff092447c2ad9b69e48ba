using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Equipping;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BF1 RID: 3057
	public class Dumpster : GridItem
	{
		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060055E0 RID: 21984 RVA: 0x00169B5A File Offset: 0x00167D5A
		// (set) Token: 0x060055E1 RID: 21985 RVA: 0x00169B62 File Offset: 0x00167D62
		public bool lidOpen { get; protected set; }

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060055E2 RID: 21986 RVA: 0x00169B6B File Offset: 0x00167D6B
		// (set) Token: 0x060055E3 RID: 21987 RVA: 0x00169B73 File Offset: 0x00167D73
		public float currentTrashLevel { get; protected set; }

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x00169B7C File Offset: 0x00167D7C
		public bool isFull
		{
			get
			{
				return this.currentTrashLevel >= Dumpster.capacity;
			}
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00169B90 File Offset: 0x00167D90
		protected virtual void Update()
		{
			if (this.lidOpen)
			{
				this.lid_CurrentAngle = Mathf.Clamp(this.lid_CurrentAngle + Time.deltaTime * 90f * 3f, 0f, 90f);
			}
			else
			{
				this.lid_CurrentAngle = Mathf.Clamp(this.lid_CurrentAngle - Time.deltaTime * 90f * 3f, 0f, 90f);
			}
			this.lid.localRotation = Quaternion.Euler(0f, 0f, -this.lid_CurrentAngle);
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00169C22 File Offset: 0x00167E22
		public virtual void Lid_Hovered()
		{
			if (this.lidOpen)
			{
				this.lid_IntObj.SetMessage("Close dumpster");
				return;
			}
			this.lid_IntObj.SetMessage("Open dumpster");
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00169C4D File Offset: 0x00167E4D
		public virtual void Lid_Interacted()
		{
			this.lidOpen = !this.lidOpen;
		}

		// Token: 0x060055E8 RID: 21992 RVA: 0x00169C5E File Offset: 0x00167E5E
		protected bool DoesPlayerHaveBinEquipped()
		{
			return PlayerSingleton<PlayerInventory>.Instance.equippedSlot != null && PlayerSingleton<PlayerInventory>.Instance.equippedSlot.Equippable is Equippable_Bin;
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x00169C85 File Offset: 0x00167E85
		public void ChangeTrashLevel(float change)
		{
			this.SetTrashLevel(this.currentTrashLevel + change);
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00169C95 File Offset: 0x00167E95
		public void SetTrashLevel(float trashLevel)
		{
			this.currentTrashLevel = Mathf.Clamp(trashLevel, 0f, Dumpster.capacity);
			this.UpdateTrashVisuals();
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00169CB4 File Offset: 0x00167EB4
		private void UpdateTrashVisuals()
		{
			this.trash.localPosition = new Vector3(this.trash.localPosition.x, this.trash_MinY + this.currentTrashLevel / Dumpster.capacity * (this.trash_MaxY - this.trash_MinY));
			this.trash.gameObject.SetActive(this.currentTrashLevel > 0f);
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00169D1F File Offset: 0x00167F1F
		public override bool CanBeDestroyed(out string reason)
		{
			if (this.currentTrashLevel > 0f)
			{
				reason = "Dumpster is not empty";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00169D4A File Offset: 0x00167F4A
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x00169D63 File Offset: 0x00167F63
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x00169D7C File Offset: 0x00167F7C
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x00169D8A File Offset: 0x00167F8A
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003F87 RID: 16263
		public static float capacity = 100f;

		// Token: 0x04003F88 RID: 16264
		[Header("References")]
		[SerializeField]
		protected InteractableObject lid_IntObj;

		// Token: 0x04003F89 RID: 16265
		[SerializeField]
		protected InteractableObject inner_IntObj;

		// Token: 0x04003F8A RID: 16266
		[SerializeField]
		protected Transform lid;

		// Token: 0x04003F8B RID: 16267
		[SerializeField]
		protected Transform trash;

		// Token: 0x04003F8C RID: 16268
		public Transform standPoint;

		// Token: 0x04003F8D RID: 16269
		[Header("Settings")]
		[SerializeField]
		protected float trash_MinY;

		// Token: 0x04003F8E RID: 16270
		[SerializeField]
		protected float trash_MaxY;

		// Token: 0x04003F91 RID: 16273
		private float lid_CurrentAngle;

		// Token: 0x04003F92 RID: 16274
		private bool dll_Excuted;

		// Token: 0x04003F93 RID: 16275
		private bool dll_Excuted;
	}
}
