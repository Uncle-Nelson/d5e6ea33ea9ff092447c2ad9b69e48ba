using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Economy
{
	// Token: 0x0200066A RID: 1642
	public class DeadDrop : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000BAC97 File Offset: 0x000B8E97
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x000BAC9F File Offset: 0x000B8E9F
		public Guid GUID { get; protected set; }

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000BACCE File Offset: 0x000B8ECE
		protected virtual void Awake()
		{
			DeadDrop.DeadDrops.Add(this);
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000BACF2 File Offset: 0x000B8EF2
		private void OnValidate()
		{
			base.gameObject.name = this.DeadDropName;
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000BAD08 File Offset: 0x000B8F08
		protected virtual void Start()
		{
			base.GetComponent<StorageEntity>().StorageEntitySubtitle = this.DeadDropName;
			this.PoI.SetMainText("Dead Drop\n(" + this.DeadDropName + ")");
			this.UpdateDeadDrop();
			this.Storage.onContentsChanged.AddListener(new UnityAction(this.UpdateDeadDrop));
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000BAD68 File Offset: 0x000B8F68
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000BAD77 File Offset: 0x000B8F77
		public void OnDestroy()
		{
			DeadDrop.DeadDrops.Remove(this);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000BAD88 File Offset: 0x000B8F88
		public static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			List<DeadDrop> list = (from drop in DeadDrop.DeadDrops
			where drop.Storage.ItemCount == 0
			select drop).ToList<DeadDrop>();
			list = (from drop in list
			orderby Vector3.Distance(drop.transform.position, origin)
			select drop).ToList<DeadDrop>();
			list.RemoveAt(0);
			list.RemoveRange(list.Count / 2, list.Count / 2);
			if (list.Count == 0)
			{
				return null;
			}
			return list[Random.Range(0, list.Count)];
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000BAE24 File Offset: 0x000B9024
		private void UpdateDeadDrop()
		{
			this.PoI.enabled = false;
			this.Light.Enabled = (this.Storage.ItemCount > 0);
			if (this.ItemCountVariable != string.Empty)
			{
				NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(this.ItemCountVariable, this.Storage.ItemCount.ToString(), true);
			}
		}

		// Token: 0x04001FFE RID: 8190
		public static List<DeadDrop> DeadDrops = new List<DeadDrop>();

		// Token: 0x04001FFF RID: 8191
		public string DeadDropName;

		// Token: 0x04002000 RID: 8192
		public string DeadDropDescription;

		// Token: 0x04002001 RID: 8193
		public StorageEntity Storage;

		// Token: 0x04002002 RID: 8194
		public POI PoI;

		// Token: 0x04002003 RID: 8195
		public OptimizedLight Light;

		// Token: 0x04002004 RID: 8196
		public string ItemCountVariable = string.Empty;

		// Token: 0x04002006 RID: 8198
		[SerializeField]
		protected string BakedGUID = string.Empty;
	}
}
