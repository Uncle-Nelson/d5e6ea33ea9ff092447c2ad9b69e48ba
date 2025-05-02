using System;
using System.Collections.Generic;
using ScheduleOne.Map;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x02000677 RID: 1655
	public class DeliveryLocation : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000BEC91 File Offset: 0x000BCE91
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x000BEC99 File Offset: 0x000BCE99
		public Guid GUID { get; protected set; }

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000BECA2 File Offset: 0x000BCEA2
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000BECB4 File Offset: 0x000BCEB4
		private void Awake()
		{
			this.PoI.gameObject.SetActive(false);
			if (!GUIDManager.IsGUIDValid(this.StaticGUID) || GUIDManager.IsGUIDAlreadyRegistered(new Guid(this.StaticGUID)))
			{
				Console.LogError("Delivery location Static GUID is not valid.", null);
				return;
			}
			((IGUIDRegisterable)this).SetGUID(this.StaticGUID);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000BED09 File Offset: 0x000BCF09
		private void OnValidate()
		{
			base.gameObject.name = this.LocationName;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000BED1C File Offset: 0x000BCF1C
		public virtual string GetDescription()
		{
			return this.LocationDescription;
		}

		// Token: 0x04002061 RID: 8289
		public string LocationName = string.Empty;

		// Token: 0x04002062 RID: 8290
		public string LocationDescription = string.Empty;

		// Token: 0x04002063 RID: 8291
		public Transform CustomerStandPoint;

		// Token: 0x04002064 RID: 8292
		public Transform TeleportPoint;

		// Token: 0x04002065 RID: 8293
		public POI PoI;

		// Token: 0x04002066 RID: 8294
		public string StaticGUID = string.Empty;

		// Token: 0x04002067 RID: 8295
		public List<Contract> ScheduledContracts = new List<Contract>();
	}
}
