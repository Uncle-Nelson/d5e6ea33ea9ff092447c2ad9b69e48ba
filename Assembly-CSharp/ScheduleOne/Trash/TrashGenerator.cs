using System;
using System.Collections.Generic;
using EasyButtons;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.Trash
{
	// Token: 0x02000833 RID: 2099
	[RequireComponent(typeof(BoxCollider))]
	public class TrashGenerator : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x000F2D84 File Offset: 0x000F0F84
		public string SaveFolderName
		{
			get
			{
				return "Generator_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x000F2DB8 File Offset: 0x000F0FB8
		public string SaveFileName
		{
			get
			{
				return "Generator_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x000141BA File Offset: 0x000123BA
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x000F2DEA File Offset: 0x000F0FEA
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x000F2DF2 File Offset: 0x000F0FF2
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x000F2DFB File Offset: 0x000F0FFB
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x000F2E03 File Offset: 0x000F1003
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x000F2E0C File Offset: 0x000F100C
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x000F2E14 File Offset: 0x000F1014
		public bool HasChanged { get; set; }

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x000F2E1D File Offset: 0x000F101D
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x000F2E25 File Offset: 0x000F1025
		public Guid GUID { get; protected set; }

		// Token: 0x0600397D RID: 14717 RVA: 0x000F2E2E File Offset: 0x000F102E
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x000F2E3D File Offset: 0x000F103D
		private void Awake()
		{
			TrashGenerator.AllGenerators.Add(this);
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x000F2E4C File Offset: 0x000F104C
		private void Start()
		{
			NetworkSingleton<TimeManager>.Instance._onSleepStart.AddListener(new UnityAction(this.SleepStart));
			this.boxCollider = base.GetComponent<BoxCollider>();
			this.boxCollider.isTrigger = true;
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Invisible"));
			this.GUID = new Guid(this.StaticGUID);
			GUIDManager.RegisterObject(this);
			this.InitializeSaveable();
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x000F2EBE File Offset: 0x000F10BE
		private void OnValidate()
		{
			if (string.IsNullOrEmpty(this.StaticGUID))
			{
				this.RegenerateGUID();
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x000F2ED3 File Offset: 0x000F10D3
		private void OnDestroy()
		{
			TrashGenerator.AllGenerators.Remove(this);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x000F2EE4 File Offset: 0x000F10E4
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.green;
			this.boxCollider = base.GetComponent<BoxCollider>();
			Gizmos.DrawWireCube(this.boxCollider.bounds.center, new Vector3(this.boxCollider.size.x * base.transform.localScale.x, this.boxCollider.size.y * base.transform.localScale.y, this.boxCollider.size.z * base.transform.localScale.z));
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x000F2F88 File Offset: 0x000F1188
		public void AddGeneratedTrash(TrashItem item)
		{
			if (this.generatedTrash.Contains(item))
			{
				return;
			}
			item.onDestroyed = (Action<TrashItem>)Delegate.Combine(item.onDestroyed, new Action<TrashItem>(this.RemoveGeneratedTrash));
			this.generatedTrash.Add(item);
			this.HasChanged = true;
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x000F2FD9 File Offset: 0x000F11D9
		public void RemoveGeneratedTrash(TrashItem item)
		{
			item.onDestroyed = (Action<TrashItem>)Delegate.Remove(item.onDestroyed, new Action<TrashItem>(this.RemoveGeneratedTrash));
			this.generatedTrash.Remove(item);
			this.HasChanged = true;
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x000F3014 File Offset: 0x000F1214
		[Button]
		private void RegenerateGUID()
		{
			this.StaticGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x000F303C File Offset: 0x000F123C
		[Button]
		private void AutoCalculateTrashCount()
		{
			this.boxCollider = base.GetComponent<BoxCollider>();
			float num = this.boxCollider.size.x * base.transform.localScale.x * (this.boxCollider.size.z * base.transform.localScale.z);
			this.MaxTrashCount = Mathf.FloorToInt(num * 0.015f);
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x000F30AB File Offset: 0x000F12AB
		[Button]
		private void GenerateMaxTrash()
		{
			this.GenerateTrash(this.MaxTrashCount - this.generatedTrash.Count);
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x000F30C8 File Offset: 0x000F12C8
		private void SleepStart()
		{
			if (!InstanceFinder.IsServer)
			{
				return;
			}
			int num = Mathf.Min(this.MaxTrashCount - this.generatedTrash.Count, Mathf.FloorToInt((float)this.MaxTrashCount * 0.2f));
			if (num <= 0)
			{
				return;
			}
			this.GenerateTrash(num);
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x000F3114 File Offset: 0x000F1314
		private void GenerateTrash(int count)
		{
			Console.Log("Generating " + count.ToString() + " trash items", null);
			for (int i = 0; i < count; i++)
			{
				Vector3 vector = new Vector3(Random.Range(this.boxCollider.bounds.min.x, this.boxCollider.bounds.max.x), Random.Range(this.boxCollider.bounds.min.y, this.boxCollider.bounds.max.y), Random.Range(this.boxCollider.bounds.min.z, this.boxCollider.bounds.max.z));
				RaycastHit raycastHit;
				vector = (Physics.Raycast(vector, Vector3.down, ref raycastHit, 20f, this.GroundCheckMask) ? raycastHit.point : vector);
				int num = 0;
				NavMeshHit navMeshHit;
				while (!NavMeshUtility.SamplePosition(vector, out navMeshHit, 1.5f, -1, true))
				{
					if (num > 10)
					{
						Console.Log("Failed to find a valid position for trash item", null);
						break;
					}
					vector = new Vector3(Random.Range(this.boxCollider.bounds.min.x, this.boxCollider.bounds.max.x), Random.Range(this.boxCollider.bounds.min.y, this.boxCollider.bounds.max.y), Random.Range(this.boxCollider.bounds.min.z, this.boxCollider.bounds.max.z));
					vector = (Physics.Raycast(vector, Vector3.down, ref raycastHit, 20f, this.GroundCheckMask) ? raycastHit.point : vector);
					num++;
				}
				vector += Vector3.up * 0.5f;
				TrashItem randomGeneratableTrashPrefab = NetworkSingleton<TrashManager>.Instance.GetRandomGeneratableTrashPrefab();
				TrashItem trashItem = NetworkSingleton<TrashManager>.Instance.CreateTrashItem(randomGeneratableTrashPrefab.ID, vector, Random.rotation, default(Vector3), "", false);
				trashItem.SetContinuousCollisionDetection();
				this.AddGeneratedTrash(trashItem);
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x000F3389 File Offset: 0x000F1589
		public bool ShouldSave()
		{
			return this.generatedTrash.Count > 0;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x000F339C File Offset: 0x000F159C
		public virtual string GetSaveString()
		{
			return new TrashGeneratorData(this.GUID.ToString(), this.generatedTrash.ConvertAll<string>((TrashItem x) => x.GUID.ToString()).ToArray()).GetJson(true);
		}

		// Token: 0x04002983 RID: 10627
		public const float TRASH_GENERATION_FRACTION = 0.2f;

		// Token: 0x04002984 RID: 10628
		public const float DEFAULT_TRASH_PER_M2 = 0.015f;

		// Token: 0x04002985 RID: 10629
		public static List<TrashGenerator> AllGenerators = new List<TrashGenerator>();

		// Token: 0x04002986 RID: 10630
		[Range(1f, 200f)]
		[SerializeField]
		private int MaxTrashCount = 10;

		// Token: 0x04002987 RID: 10631
		[SerializeField]
		private List<TrashItem> generatedTrash = new List<TrashItem>();

		// Token: 0x04002988 RID: 10632
		[Header("Settings")]
		public LayerMask GroundCheckMask;

		// Token: 0x04002989 RID: 10633
		private BoxCollider boxCollider;

		// Token: 0x0400298E RID: 10638
		public string StaticGUID = string.Empty;
	}
}
