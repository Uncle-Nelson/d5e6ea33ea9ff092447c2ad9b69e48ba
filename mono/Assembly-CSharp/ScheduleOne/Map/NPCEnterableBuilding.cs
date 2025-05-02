using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000C24 RID: 3108
	public class NPCEnterableBuilding : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06005732 RID: 22322 RVA: 0x0016E66A File Offset: 0x0016C86A
		// (set) Token: 0x06005733 RID: 22323 RVA: 0x0016E672 File Offset: 0x0016C872
		public Guid GUID { get; protected set; }

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x0016E67B File Offset: 0x0016C87B
		public int OccupantCount
		{
			get
			{
				return this.Occupants.Count;
			}
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x0016E688 File Offset: 0x0016C888
		protected virtual void Awake()
		{
			if (!GUIDManager.IsGUIDValid(this.BakedGUID))
			{
				Console.LogError(base.gameObject.name + "'s baked GUID is not valid! Bad.", null);
			}
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
			if (this.Doors.Length == 0)
			{
				this.GetDoors();
				if (this.Doors.Length == 0)
				{
					Console.LogError(this.BuildingName + " has no doors! NPCs won't be able to enter the building.", null);
				}
			}
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x0016E702 File Offset: 0x0016C902
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x0016E714 File Offset: 0x0016C914
		public virtual void NPCEnteredBuilding(NPC npc)
		{
			if (!this.Occupants.Contains(npc))
			{
				this.Occupants.Add(npc);
			}
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			if (Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, npc.Movement.FootPosition) > 15f)
			{
				return;
			}
			AudioSourceController audioSourceController = Object.Instantiate<AudioSourceController>(Singleton<AudioManager>.Instance.DoorOpen, NetworkSingleton<GameManager>.Instance.Temp.transform);
			audioSourceController.transform.position = npc.Avatar.transform.position;
			audioSourceController.Play();
			Object.Destroy(audioSourceController.gameObject, audioSourceController.AudioSource.clip.length);
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x0016E7C8 File Offset: 0x0016C9C8
		public virtual void NPCExitedBuilding(NPC npc)
		{
			this.Occupants.Remove(npc);
			if (!PlayerSingleton<PlayerCamera>.InstanceExists || Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, npc.Avatar.transform.position) > 15f)
			{
				return;
			}
			if (!Singleton<AudioManager>.InstanceExists)
			{
				return;
			}
			if (!NetworkSingleton<GameManager>.InstanceExists)
			{
				return;
			}
			AudioSourceController audioSourceController = Object.Instantiate<AudioSourceController>(Singleton<AudioManager>.Instance.DoorClose, NetworkSingleton<GameManager>.Instance.Temp.transform);
			audioSourceController.Play();
			Object.Destroy(audioSourceController.gameObject, audioSourceController.AudioSource.clip.length);
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x0016E865 File Offset: 0x0016CA65
		[Button]
		public void GetDoors()
		{
			this.Doors = base.GetComponentsInChildren<StaticDoor>();
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0016E873 File Offset: 0x0016CA73
		public List<NPC> GetSummonableNPCs()
		{
			return (from npc in this.Occupants
			where npc.CanBeSummoned
			select npc).ToList<NPC>();
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x0016E8A4 File Offset: 0x0016CAA4
		public StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			return (from door in this.Doors
			where !useableOnly || door.Usable
			orderby Vector3.Distance(door.transform.position, pos)
			select door).FirstOrDefault<StaticDoor>();
		}

		// Token: 0x0400408A RID: 16522
		public const float DOOR_SOUND_DISTANCE_LIMIT = 15f;

		// Token: 0x0400408C RID: 16524
		[Header("Settings")]
		public string BuildingName;

		// Token: 0x0400408D RID: 16525
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x0400408E RID: 16526
		[Header("References")]
		public StaticDoor[] Doors;

		// Token: 0x0400408F RID: 16527
		[Header("Readonly")]
		[SerializeField]
		private List<NPC> Occupants = new List<NPC>();
	}
}
