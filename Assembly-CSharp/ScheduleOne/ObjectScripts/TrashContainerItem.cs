using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Tiles;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B9F RID: 2975
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerItem : GridItem, ITransitEntity
	{
		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06004FC2 RID: 20418 RVA: 0x00150487 File Offset: 0x0014E687
		public string Name
		{
			get
			{
				return base.ItemInstance.Name;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06004FC3 RID: 20419 RVA: 0x00150494 File Offset: 0x0014E694
		// (set) Token: 0x06004FC4 RID: 20420 RVA: 0x0015049C File Offset: 0x0014E69C
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x001504A5 File Offset: 0x0014E6A5
		// (set) Token: 0x06004FC6 RID: 20422 RVA: 0x001504AD File Offset: 0x0014E6AD
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06004FC7 RID: 20423 RVA: 0x000AEDCB File Offset: 0x000ACFCB
		public Transform LinkOrigin
		{
			get
			{
				return base.transform;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x001504B6 File Offset: 0x0014E6B6
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06004FC9 RID: 20425 RVA: 0x001504BE File Offset: 0x0014E6BE
		public bool Selectable { get; }

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x001504C6 File Offset: 0x0014E6C6
		// (set) Token: 0x06004FCB RID: 20427 RVA: 0x001504CE File Offset: 0x0014E6CE
		public bool IsAcceptingItems { get; set; }

		// Token: 0x06004FCC RID: 20428 RVA: 0x001504D8 File Offset: 0x0014E6D8
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.TrashContainerItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x001504F7 File Offset: 0x0014E6F7
		protected override void Start()
		{
			base.Start();
			this.Container.onTrashLevelChanged.AddListener(new UnityAction(this.TrashLevelChanged));
			this.Container.onTrashAdded.AddListener(new UnityAction<string>(this.TrashAdded));
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x00150537 File Offset: 0x0014E737
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			base.InitializeGridItem(instance, grid, originCoordinate, rotation, GUID);
			if (!this.isGhost)
			{
				base.InvokeRepeating("CheckTrashItems", Random.Range(0f, 1f), 1f);
			}
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00150570 File Offset: 0x0014E770
		private void TrashLevelChanged()
		{
			base.HasChanged = true;
			if (this.Container.NormalizedTrashLevel > 0.75f)
			{
				if (!this.Flies.isPlaying)
				{
					this.Flies.Play();
					return;
				}
			}
			else if (this.Flies.isPlaying)
			{
				this.Flies.Stop();
			}
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x001505C7 File Offset: 0x0014E7C7
		public override bool CanBeDestroyed(out string reason)
		{
			if (this.Container.TrashLevel > 0)
			{
				reason = "Contains trash";
				return false;
			}
			return base.CanBeDestroyed(out reason);
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x001505E7 File Offset: 0x0014E7E7
		public override string GetSaveString()
		{
			return new TrashContainerData(base.GUID, base.ItemInstance, 0, base.OwnerGrid, this.OriginCoordinate, this.Rotation, this.Container.Content.GetData()).GetJson(true);
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00150624 File Offset: 0x0014E824
		private void TrashAdded(string trashID)
		{
			if (this.TrashAddedSound == null)
			{
				return;
			}
			float volumeMultiplier = Mathf.Clamp01((float)NetworkSingleton<TrashManager>.Instance.GetTrashPrefab(trashID).Size / 4f);
			this.TrashAddedSound.VolumeMultiplier = volumeMultiplier;
			this.TrashAddedSound.Play();
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00150674 File Offset: 0x0014E874
		public override void ShowOutline(Color color)
		{
			base.ShowOutline(color);
			this.PickupAreaProjector.enabled = true;
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00150689 File Offset: 0x0014E889
		public override void HideOutline()
		{
			base.HideOutline();
			this.PickupAreaProjector.enabled = false;
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x001506A0 File Offset: 0x0014E8A0
		private void CheckTrashItems()
		{
			for (int i = 0; i < this.TrashItemsInRadius.Count; i++)
			{
				if (!this.IsTrashValid(this.TrashItemsInRadius[i]))
				{
					this.RemoveTrashItemFromRadius(this.TrashItemsInRadius[i]);
					i--;
				}
			}
			Collider[] array = Physics.OverlapSphere(base.transform.position, this.PickupRadius, LayerMask.GetMask(new string[]
			{
				"Trash"
			}), 1);
			for (int j = 0; j < array.Length; j++)
			{
				if (this.IsPointInRadius(array[j].transform.position))
				{
					TrashItem componentInParent = array[j].GetComponentInParent<TrashItem>();
					if (componentInParent != null && this.IsTrashValid(componentInParent))
					{
						this.AddTrashToRadius(componentInParent);
					}
				}
			}
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00150760 File Offset: 0x0014E960
		private void AddTrashToRadius(TrashItem trashItem)
		{
			if (trashItem is TrashBag)
			{
				this.AddTrashBagToRadius(trashItem as TrashBag);
				return;
			}
			if (!this.TrashItemsInRadius.Contains(trashItem))
			{
				this.TrashItemsInRadius.Add(trashItem);
				trashItem.onDestroyed = (Action<TrashItem>)Delegate.Combine(trashItem.onDestroyed, new Action<TrashItem>(this.RemoveTrashItemFromRadius));
			}
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x001507BE File Offset: 0x0014E9BE
		private void AddTrashBagToRadius(TrashBag trashBag)
		{
			if (!this.TrashBagsInRadius.Contains(trashBag))
			{
				this.TrashBagsInRadius.Add(trashBag);
				trashBag.onDestroyed = (Action<TrashItem>)Delegate.Combine(trashBag.onDestroyed, new Action<TrashItem>(this.RemoveTrashItemFromRadius));
			}
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x001507FC File Offset: 0x0014E9FC
		private void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
			if (trashItem is TrashBag)
			{
				this.RemoveTrashBagFromRadius(trashItem as TrashBag);
				return;
			}
			if (this.TrashItemsInRadius.Contains(trashItem))
			{
				this.TrashItemsInRadius.Remove(trashItem);
				trashItem.onDestroyed = (Action<TrashItem>)Delegate.Remove(trashItem.onDestroyed, new Action<TrashItem>(this.RemoveTrashItemFromRadius));
			}
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x0015085B File Offset: 0x0014EA5B
		private void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
			if (this.TrashBagsInRadius.Contains(trashBag))
			{
				this.TrashBagsInRadius.Remove(trashBag);
				trashBag.onDestroyed = (Action<TrashItem>)Delegate.Remove(trashBag.onDestroyed, new Action<TrashItem>(this.RemoveTrashItemFromRadius));
			}
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x0015089C File Offset: 0x0014EA9C
		private bool IsTrashValid(TrashItem trashItem)
		{
			return !(trashItem == null) && this.IsPointInRadius(trashItem.transform.position) && !trashItem.Draggable.IsBeingDragged && base.ParentProperty.DoBoundsContainPoint(trashItem.transform.position);
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x001508F4 File Offset: 0x0014EAF4
		public bool IsPointInRadius(Vector3 point)
		{
			float num = Vector3.Distance(point, base.transform.position);
			float num2 = Mathf.Abs(point.y - base.transform.position.y);
			return num <= this.PickupRadius + 0.2f && num2 <= 2f;
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x0015099D File Offset: 0x0014EB9D
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x001509B6 File Offset: 0x0014EBB6
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x001509CF File Offset: 0x0014EBCF
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x001509E0 File Offset: 0x0014EBE0
		protected virtual void dll()
		{
			base.Awake();
			this.PickupAreaProjector.size = new Vector3(this.PickupRadius * 2f, this.PickupRadius * 2f, 0.2f);
			this.PickupAreaProjector.enabled = false;
		}

		// Token: 0x04003C25 RID: 15397
		public const float MAX_VERTICAL_OFFSET = 2f;

		// Token: 0x04003C26 RID: 15398
		public TrashContainer Container;

		// Token: 0x04003C27 RID: 15399
		public ParticleSystem Flies;

		// Token: 0x04003C28 RID: 15400
		public AudioSourceController TrashAddedSound;

		// Token: 0x04003C29 RID: 15401
		public DecalProjector PickupAreaProjector;

		// Token: 0x04003C2A RID: 15402
		public Transform[] accessPoints;

		// Token: 0x04003C2B RID: 15403
		[Header("Pickup settings")]
		public bool UsableByCleaners = true;

		// Token: 0x04003C2C RID: 15404
		public float PickupRadius = 5f;

		// Token: 0x04003C31 RID: 15409
		public List<TrashItem> TrashItemsInRadius = new List<TrashItem>();

		// Token: 0x04003C32 RID: 15410
		public List<TrashBag> TrashBagsInRadius = new List<TrashBag>();

		// Token: 0x04003C33 RID: 15411
		private bool dll_Excuted;

		// Token: 0x04003C34 RID: 15412
		private bool dll_Excuted;
	}
}
