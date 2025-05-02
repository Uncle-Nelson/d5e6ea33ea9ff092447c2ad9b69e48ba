using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using EPOOutline;
using FishNet;
using FishNet.Component.Ownership;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Building;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000627 RID: 1575
	[RequireComponent(typeof(PredictedSpawn))]
	public class BuildableItem : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x000AA0E3 File Offset: 0x000A82E3
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x000AA0EB File Offset: 0x000A82EB
		public ItemInstance ItemInstance { get; protected set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000AA0F4 File Offset: 0x000A82F4
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x000AA0FC File Offset: 0x000A82FC
		public Property ParentProperty { get; protected set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000AA105 File Offset: 0x000A8305
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x000AA10D File Offset: 0x000A830D
		public bool IsDestroyed { get; protected set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x000AA116 File Offset: 0x000A8316
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x000AA11E File Offset: 0x000A831E
		public bool Initialized { get; protected set; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000AA127 File Offset: 0x000A8327
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x000AA12F File Offset: 0x000A832F
		public Guid GUID { get; protected set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000AA138 File Offset: 0x000A8338
		// (set) Token: 0x0600294A RID: 10570 RVA: 0x000AA140 File Offset: 0x000A8340
		public bool IsCulled { get; protected set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x000AA149 File Offset: 0x000A8349
		public GameObject BuildHandler
		{
			get
			{
				return this.buildHandler;
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x000AA154 File Offset: 0x000A8354
		[Button]
		public void AddChildMeshes()
		{
			foreach (MeshRenderer meshRenderer in new List<MeshRenderer>(this.MeshesToCull))
			{
				foreach (MeshRenderer item in meshRenderer.GetComponentsInChildren<MeshRenderer>())
				{
					if (!this.MeshesToCull.Contains(item))
					{
						this.MeshesToCull.Add(item);
					}
				}
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		// (set) Token: 0x0600294E RID: 10574 RVA: 0x000AA1E0 File Offset: 0x000A83E0
		public bool LocallyBuilt { get; protected set; }

		// Token: 0x0600294F RID: 10575 RVA: 0x000AA1E9 File Offset: 0x000A83E9
		public void SetLocallyBuilt()
		{
			this.LocallyBuilt = true;
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000AA1F4 File Offset: 0x000A83F4
		public string SaveFolderName
		{
			get
			{
				return this.ItemInstance.ID + "_" + this.GUID.ToString().Substring(0, 6);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x000AA231 File Offset: 0x000A8431
		public string SaveFileName
		{
			get
			{
				return "Data";
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x00046D4A File Offset: 0x00044F4A
		public Loader Loader
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x000022C9 File Offset: 0x000004C9
		public bool ShouldSaveUnderFolder
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000AA238 File Offset: 0x000A8438
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x000AA240 File Offset: 0x000A8440
		public List<string> LocalExtraFiles { get; set; } = new List<string>();

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000AA249 File Offset: 0x000A8449
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x000AA251 File Offset: 0x000A8451
		public List<string> LocalExtraFolders { get; set; } = new List<string>();

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000AA25A File Offset: 0x000A845A
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x000AA262 File Offset: 0x000A8462
		public bool HasChanged { get; set; }

		// Token: 0x0600295A RID: 10586 RVA: 0x000AA26B File Offset: 0x000A846B
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.BuildableItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000AA280 File Offset: 0x000A8480
		protected virtual void Start()
		{
			if (!this.isGhost)
			{
				this.InitializeSaveable();
				if (this.GUID == Guid.Empty)
				{
					this.GUID = GUIDManager.GenerateUniqueGUID();
					GUIDManager.RegisterObject(this);
				}
				ActivateDuringBuild[] componentsInChildren = base.transform.GetComponentsInChildren<ActivateDuringBuild>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000AA2E8 File Offset: 0x000A84E8
		protected virtual Property GetProperty(Transform searchTransform = null)
		{
			if (searchTransform == null)
			{
				searchTransform = base.transform;
			}
			PropertyContentsContainer componentInParent = searchTransform.GetComponentInParent<PropertyContentsContainer>();
			if (componentInParent != null)
			{
				return componentInParent.Property;
			}
			return searchTransform.GetComponentInParent<Property>();
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0003CA2B File Offset: 0x0003AC2B
		public virtual void InitializeSaveable()
		{
			Singleton<SaveManager>.Instance.RegisterSaveable(this);
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000AA323 File Offset: 0x000A8523
		public override void OnSpawnServer(NetworkConnection connection)
		{
			base.OnSpawnServer(connection);
			if (!connection.IsLocalClient && this.Initialized)
			{
				this.SendInitToClient(connection);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000AA344 File Offset: 0x000A8544
		protected virtual void SendInitToClient(NetworkConnection conn)
		{
			Console.Log("Sending BuildableItem init to client", null);
			this.ReceiveBuildableItemData(conn, this.ItemInstance, this.GUID.ToString(), this.ParentProperty.PropertyCode);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000AA388 File Offset: 0x000A8588
		[ServerRpc(RequireOwnership = false)]
		public void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			this.RpcWriter___Server_SendBuildableItemData_3537728543(instance, GUID, parentPropertyCode);
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000AA39C File Offset: 0x000A859C
		[ObserversRpc]
		[TargetRpc]
		public void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_ReceiveBuildableItemData_3859851844(conn, instance, GUID, parentPropertyCode);
			}
			else
			{
				this.RpcWriter___Target_ReceiveBuildableItemData_3859851844(conn, instance, GUID, parentPropertyCode);
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000AA3D4 File Offset: 0x000A85D4
		public virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			if (this.Initialized)
			{
				return;
			}
			if (instance == null)
			{
				Console.LogError("InitializeBuildItem: passed null instance", null);
			}
			if (instance.Quantity != 1)
			{
				Console.LogWarning("BuiltadlbeItem initialized with quantity '" + instance.Quantity.ToString() + "'! This should be 1.", null);
			}
			this.Initialized = true;
			this.ItemInstance = instance;
			this.SetGUID(new Guid(GUID));
			this.ParentProperty = Property.Properties.FirstOrDefault((Property p) => p.PropertyCode == parentPropertyCode);
			if (this.ParentProperty == null)
			{
				this.ParentProperty = Business.Businesses.FirstOrDefault((Business b) => b.PropertyCode == parentPropertyCode);
			}
			if (this.ParentProperty != null)
			{
				this.ParentProperty.BuildableItems.Add(this);
				if (this.ParentProperty.IsContentCulled)
				{
					this.SetCulled(true);
				}
			}
			else
			{
				Console.LogError("BuildableItem '" + base.gameObject.name + "' does not have a parent Property!", null);
			}
			ActivateDuringBuild[] componentsInChildren = base.transform.GetComponentsInChildren<ActivateDuringBuild>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].gameObject.SetActive(false);
			}
			if (this.onInitialized != null)
			{
				this.onInitialized.Invoke();
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000AA51E File Offset: 0x000A871E
		public bool CanBePickedUp(out string reason)
		{
			if (PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(this.ItemInstance, 1))
			{
				return this.CanBeDestroyed(out reason);
			}
			reason = "Item won't fit in inventory";
			return false;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00070B96 File Offset: 0x0006ED96
		public virtual bool CanBeDestroyed(out string reason)
		{
			reason = string.Empty;
			return true;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000AA544 File Offset: 0x000A8744
		public virtual void PickupItem()
		{
			string empty = string.Empty;
			if (!this.CanBePickedUp(out empty))
			{
				Console.LogWarning("Item can not be picked up!", null);
				return;
			}
			PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(this.ItemInstance);
			this.DestroyItem(true);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000AA584 File Offset: 0x000A8784
		public virtual void DestroyItem(bool callOnServer = true)
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.IsDestroyed = true;
			if (callOnServer)
			{
				this.Destroy_Networked();
			}
			if (this.ParentProperty != null)
			{
				this.ParentProperty.BuildableItems.Remove(this);
			}
			if (this.onDestroyed != null)
			{
				this.onDestroyed.Invoke();
			}
			if (this.onDestroyedWithParameter != null)
			{
				this.onDestroyedWithParameter(this);
			}
			base.gameObject.SetActive(false);
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x000AA5FD File Offset: 0x000A87FD
		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
			this.RpcWriter___Server_Destroy_Networked_2166136261();
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x000AA605 File Offset: 0x000A8805
		[ObserversRpc]
		private void DestroyItemWrapper()
		{
			this.RpcWriter___Observers_DestroyItemWrapper_2166136261();
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x000AA60D File Offset: 0x000A880D
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x000AA61C File Offset: 0x000A881C
		public static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			switch (col)
			{
			case BuildableItem.EOutlineColor.White:
				return Color.white;
			case BuildableItem.EOutlineColor.Blue:
				return new Color32(0, 200, byte.MaxValue, byte.MaxValue);
			case BuildableItem.EOutlineColor.LightBlue:
				return new Color32(120, 225, byte.MaxValue, byte.MaxValue);
			default:
				return Color.white;
			}
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x000AA680 File Offset: 0x000A8880
		public virtual void ShowOutline(Color color)
		{
			if (this.IsDestroyed || base.gameObject == null)
			{
				return;
			}
			if (this.OutlineEffect == null)
			{
				this.OutlineEffect = base.gameObject.AddComponent<Outlinable>();
				this.OutlineEffect.OutlineParameters.BlurShift = 0f;
				this.OutlineEffect.OutlineParameters.DilateShift = 0.5f;
				this.OutlineEffect.OutlineParameters.FillPass.Shader = Resources.Load<Shader>("Easy performant outline/Shaders/Fills/ColorFill");
				foreach (GameObject gameObject in this.OutlineRenderers)
				{
					MeshRenderer[] array = new MeshRenderer[0];
					if (this.IncludeOutlineRendererChildren)
					{
						array = gameObject.GetComponentsInChildren<MeshRenderer>();
					}
					else
					{
						array = new MeshRenderer[]
						{
							gameObject.GetComponent<MeshRenderer>()
						};
					}
					for (int i = 0; i < array.Length; i++)
					{
						OutlineTarget outlineTarget = new OutlineTarget(array[i], 0);
						this.OutlineEffect.TryAddTarget(outlineTarget);
					}
				}
			}
			this.OutlineEffect.OutlineParameters.Color = color;
			Color32 c = color;
			c.a = 9;
			this.OutlineEffect.OutlineParameters.FillPass.SetColor("_PublicColor", c);
			this.OutlineEffect.enabled = true;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000AA7F0 File Offset: 0x000A89F0
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
			this.ShowOutline(BuildableItem.GetColorFromOutlineColorEnum(color));
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000AA803 File Offset: 0x000A8A03
		public virtual void HideOutline()
		{
			if (this.IsDestroyed || base.gameObject == null)
			{
				return;
			}
			if (this.OutlineEffect != null)
			{
				this.OutlineEffect.enabled = false;
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000AA838 File Offset: 0x000A8A38
		public Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			Vector3[] array = new Vector3[8];
			BoxCollider boundingCollider = this.BoundingCollider;
			array[0] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(boundingCollider.size.x, -boundingCollider.size.y, boundingCollider.size.z) * 0.5f);
			array[1] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(-boundingCollider.size.x, -boundingCollider.size.y, boundingCollider.size.z) * 0.5f);
			array[2] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(-boundingCollider.size.x, -boundingCollider.size.y, -boundingCollider.size.z) * 0.5f);
			array[3] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(boundingCollider.size.x, -boundingCollider.size.y, -boundingCollider.size.z) * 0.5f);
			array[4] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(boundingCollider.size.x, boundingCollider.size.y, boundingCollider.size.z) * 0.5f);
			array[5] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(-boundingCollider.size.x, boundingCollider.size.y, boundingCollider.size.z) * 0.5f);
			array[6] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(-boundingCollider.size.x, boundingCollider.size.y, -boundingCollider.size.z) * 0.5f);
			array[7] = this.BoundingCollider.transform.TransformPoint(boundingCollider.center + new Vector3(boundingCollider.size.x, boundingCollider.size.y, -boundingCollider.size.z) * 0.5f);
			List<Vector3> list = new List<Vector3>();
			foreach (Vector3 vector in array)
			{
				if (list.Count == 0)
				{
					list.Add(vector);
				}
				else if (Vector3.Distance(pos, vector) > Vector3.Distance(pos, list[0]))
				{
					list.Clear();
					list.Add(vector);
				}
				else if (Mathf.Abs(Vector3.Distance(pos, vector) - Vector3.Distance(pos, list[0])) < 1E-06f)
				{
					list.Add(vector);
				}
			}
			Vector3 a = Vector3.zero;
			for (int j = 0; j < list.Count; j++)
			{
				a += list[j];
			}
			return a / (float)list.Count;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000AABB0 File Offset: 0x000A8DB0
		public bool GetPenetration(out float x, out float z, out float y)
		{
			Vector3 a = this.BoundingCollider.transform.TransformPoint(this.BoundingCollider.center);
			float num = this.BoundingCollider.size.x / 2f;
			float num2 = 0f;
			x = 0f;
			z = 0f;
			y = 0f;
			Vector3 vector = a - base.transform.right * num;
			RaycastHit raycastHit;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, base.transform.right, this.BoundingCollider.size.x / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(base.transform.right, -raycastHit.normal) < 5f)
			{
				x = this.BoundingCollider.size.x - Vector3.Distance(vector, raycastHit.point);
				Debug.DrawLine(a - base.transform.right * num, raycastHit.point, Color.green);
			}
			vector = a + base.transform.right * num;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, -base.transform.right, this.BoundingCollider.size.x / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(-base.transform.right, -raycastHit.normal) < 5f)
			{
				float num3 = -(this.BoundingCollider.size.x - Vector3.Distance(vector, raycastHit.point));
				x = num3;
				Debug.DrawLine(a + base.transform.right * num, raycastHit.point, Color.red);
			}
			num = this.BoundingCollider.size.z / 2f;
			vector = a - base.transform.forward * num;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, base.transform.forward, this.BoundingCollider.size.z / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(base.transform.forward, -raycastHit.normal) < 5f)
			{
				z = this.BoundingCollider.size.z - Vector3.Distance(vector, raycastHit.point);
				Debug.DrawLine(a - base.transform.forward * num, raycastHit.point, Color.cyan);
			}
			vector = a + base.transform.forward * num;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, -base.transform.forward, this.BoundingCollider.size.z / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(-base.transform.forward, -raycastHit.normal) < 5f)
			{
				float num4 = -(this.BoundingCollider.size.z - Vector3.Distance(vector, raycastHit.point));
				z = num4;
				Debug.DrawLine(a + base.transform.forward * num, raycastHit.point, Color.yellow);
			}
			num = this.BoundingCollider.size.y / 2f;
			vector = a - base.transform.up * num;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, base.transform.up, this.BoundingCollider.size.y / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(base.transform.forward, -raycastHit.normal) < 5f)
			{
				y = this.BoundingCollider.size.y - Vector3.Distance(vector, raycastHit.point);
				Debug.DrawLine(a - base.transform.up * num, raycastHit.point, Color.cyan);
			}
			vector = a + base.transform.up * num;
			if (this.HasLoS_IgnoreBuildables(vector) && PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(vector, -base.transform.up, this.BoundingCollider.size.y / 2f + num - num2, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, num2, 45f) && Vector3.Angle(-base.transform.up, -raycastHit.normal) < 5f)
			{
				float num5 = -(this.BoundingCollider.size.y - Vector3.Distance(vector, raycastHit.point));
				y = num5;
				Debug.DrawLine(a + base.transform.up * num, raycastHit.point, Color.yellow);
			}
			return x != 0f || z != 0f || y != 0f;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000AB1D0 File Offset: 0x000A93D0
		private bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			RaycastHit raycastHit;
			return !PlayerSingleton<PlayerCamera>.Instance.Raycast_ExcludeBuildables(PlayerSingleton<PlayerCamera>.Instance.transform.position, point - PlayerSingleton<PlayerCamera>.Instance.transform.position, Vector3.Distance(point, PlayerSingleton<PlayerCamera>.Instance.transform.position) - 0.01f, out raycastHit, 1 << LayerMask.NameToLayer("Default"), false, 0f, 0f);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000AB24C File Offset: 0x000A944C
		public virtual void SetCulled(bool culled)
		{
			this.IsCulled = culled;
			foreach (MeshRenderer meshRenderer in this.MeshesToCull)
			{
				if (!(meshRenderer == null))
				{
					meshRenderer.enabled = !culled;
				}
			}
			foreach (GameObject gameObject in this.GameObjectsToCull)
			{
				if (!(gameObject == null))
				{
					gameObject.SetActive(!culled);
				}
			}
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000AB2E4 File Offset: 0x000A94E4
		public virtual string GetSaveString()
		{
			return new BuildableItemData(this.GUID, this.ItemInstance, 0).GetJson(true);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00057BE8 File Offset: 0x00055DE8
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return new List<string>();
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000AB33C File Offset: 0x000A953C
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SendBuildableItemData_3537728543));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_ReceiveBuildableItemData_3859851844));
			base.RegisterTargetRpc(2U, new ClientRpcDelegate(this.RpcReader___Target_ReceiveBuildableItemData_3859851844));
			base.RegisterServerRpc(3U, new ServerRpcDelegate(this.RpcReader___Server_Destroy_Networked_2166136261));
			base.RegisterObserversRpc(4U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyItemWrapper_2166136261));
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000AB3CD File Offset: 0x000A95CD
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000AB3E0 File Offset: 0x000A95E0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000AB3F0 File Offset: 0x000A95F0
		private void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(GUID);
			writer.WriteString(parentPropertyCode);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000AB4B1 File Offset: 0x000A96B1
		public void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			this.ReceiveBuildableItemData(null, instance, GUID, parentPropertyCode);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		private void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentPropertyCode = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendBuildableItemData_3537728543(instance, guid, parentPropertyCode);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000AB514 File Offset: 0x000A9714
		private void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(GUID);
			writer.WriteString(parentPropertyCode);
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000AB5E4 File Offset: 0x000A97E4
		public void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			this.InitializeBuildableItem(instance, GUID, parentPropertyCode);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000AB5F0 File Offset: 0x000A97F0
		private void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentPropertyCode = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveBuildableItemData_3859851844(null, instance, guid, parentPropertyCode);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000AB644 File Offset: 0x000A9844
		private void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.WriteItemInstance(instance);
			writer.WriteString(GUID);
			writer.WriteString(parentPropertyCode);
			base.SendTargetRpc(2U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000AB714 File Offset: 0x000A9914
		private void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentPropertyCode = PooledReader0.ReadString();
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___ReceiveBuildableItemData_3859851844(base.LocalConnection, instance, guid, parentPropertyCode);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000AB770 File Offset: 0x000A9970
		private void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendServerRpc(3U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000AB80A File Offset: 0x000A9A0A
		private void RpcLogic___Destroy_Networked_2166136261()
		{
			this.DestroyItemWrapper();
			base.Despawn(new DespawnType?(DespawnType.Destroy));
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000AB820 File Offset: 0x000A9A20
		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___Destroy_Networked_2166136261();
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000AB840 File Offset: 0x000A9A40
		private void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
			if (!base.IsServerInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because server is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			base.SendObserversRpc(4U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000AB8E9 File Offset: 0x000A9AE9
		private void RpcLogic___DestroyItemWrapper_2166136261()
		{
			this.DestroyItem(false);
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000AB8F4 File Offset: 0x000A9AF4
		private void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___DestroyItemWrapper_2166136261();
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void dll()
		{
		}

		// Token: 0x04001E79 RID: 7801
		[HideInInspector]
		public bool isGhost;

		// Token: 0x04001E7A RID: 7802
		[Header("Build Settings")]
		[SerializeField]
		protected GameObject buildHandler;

		// Token: 0x04001E7B RID: 7803
		public float HoldDistance = 2.5f;

		// Token: 0x04001E7C RID: 7804
		public Transform BuildPoint;

		// Token: 0x04001E7D RID: 7805
		public Transform MidAirCenterPoint;

		// Token: 0x04001E7E RID: 7806
		public BoxCollider BoundingCollider;

		// Token: 0x04001E7F RID: 7807
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> OutlineRenderers = new List<GameObject>();

		// Token: 0x04001E80 RID: 7808
		[SerializeField]
		protected bool IncludeOutlineRendererChildren = true;

		// Token: 0x04001E81 RID: 7809
		protected Outlinable OutlineEffect;

		// Token: 0x04001E82 RID: 7810
		[Header("Culling Settings")]
		public GameObject[] GameObjectsToCull;

		// Token: 0x04001E83 RID: 7811
		public List<MeshRenderer> MeshesToCull;

		// Token: 0x04001E84 RID: 7812
		[Header("Buildable Events")]
		public UnityEvent onInitialized;

		// Token: 0x04001E85 RID: 7813
		public UnityEvent onDestroyed;

		// Token: 0x04001E86 RID: 7814
		public Action<BuildableItem> onDestroyedWithParameter;

		// Token: 0x04001E8B RID: 7819
		private bool dll_Excuted;

		// Token: 0x04001E8C RID: 7820
		private bool dll_Excuted;

		// Token: 0x02000628 RID: 1576
		public enum EOutlineColor
		{
			// Token: 0x04001E8E RID: 7822
			White,
			// Token: 0x04001E8F RID: 7823
			Blue,
			// Token: 0x04001E90 RID: 7824
			LightBlue
		}
	}
}
