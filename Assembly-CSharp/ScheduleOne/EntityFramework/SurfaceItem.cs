using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Building;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.EntityFramework
{
	// Token: 0x02000637 RID: 1591
	public class SurfaceItem : BuildableItem
	{
		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002A12 RID: 10770 RVA: 0x000AD94B File Offset: 0x000ABB4B
		// (set) Token: 0x06002A13 RID: 10771 RVA: 0x000AD953 File Offset: 0x000ABB53
		public Surface ParentSurface { get; protected set; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06002A14 RID: 10772 RVA: 0x000AD95C File Offset: 0x000ABB5C
		public float RotationIncrement { get; } = 45f;

		// Token: 0x06002A15 RID: 10773 RVA: 0x000AD964 File Offset: 0x000ABB64
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.EntityFramework.SurfaceItem_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000AD978 File Offset: 0x000ABB78
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (base.Initialized && base.LocallyBuilt)
			{
				base.StartCoroutine(this.<OnStartClient>g__WaitForDataSend|12_0());
			}
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000AD9A0 File Offset: 0x000ABBA0
		protected override void SendInitToClient(NetworkConnection conn)
		{
			this.InitializeSurfaceItem(conn, base.ItemInstance, base.GUID.ToString(), this.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000AD9F3 File Offset: 0x000ABBF3
		[ServerRpc(RequireOwnership = false)]
		public void SendSurfaceItemData(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			this.RpcWriter___Server_SendSurfaceItemData_2652836379(instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x000ADA10 File Offset: 0x000ABC10
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void InitializeSurfaceItem(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			if (conn == null)
			{
				this.RpcWriter___Observers_InitializeSurfaceItem_2932264618(conn, instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
				this.RpcLogic___InitializeSurfaceItem_2932264618(conn, instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
			}
			else
			{
				this.RpcWriter___Target_InitializeSurfaceItem_2932264618(conn, instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
			}
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000ADA84 File Offset: 0x000ABC84
		public virtual void InitializeSurfaceItem(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			this.SetTransformData(parentSurfaceGUID, relativePosition, relativeRotation);
			if (this.ParentSurface == null)
			{
				this.DestroyItem(false);
				return;
			}
			Property parentProperty = this.ParentSurface.ParentProperty;
			if (parentProperty == null)
			{
				Console.LogError("Failed to find parent property for " + base.gameObject.name, null);
				return;
			}
			base.InitializeBuildableItem(instance, GUID, parentProperty.PropertyCode);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000ADAF4 File Offset: 0x000ABCF4
		protected virtual void SetTransformData(string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			Surface @object = GUIDManager.GetObject<Surface>(new Guid(parentSurfaceGUID));
			if (@object == null)
			{
				Console.LogError("Failed to find parent surface for " + base.gameObject.name, null);
				return;
			}
			this.ParentSurface = @object;
			this.RelativePosition = relativePosition;
			this.RelativeRotation = relativeRotation;
			base.transform.position = @object.transform.TransformPoint(relativePosition);
			base.transform.rotation = @object.transform.rotation * relativeRotation;
			if (base.NetworkObject.IsSpawned)
			{
				base.transform.SetParent(this.ParentSurface.Container.transform);
				return;
			}
			base.StartCoroutine(this.<SetTransformData>g__Routine|17_0());
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000ADBB0 File Offset: 0x000ABDB0
		protected override Property GetProperty(Transform searchTransform = null)
		{
			return base.GetProperty(searchTransform);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000ADBBC File Offset: 0x000ABDBC
		public override string GetSaveString()
		{
			return new SurfaceItemData(base.GUID, base.ItemInstance, 25, this.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation).GetJson(true);
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x000ADC5C File Offset: 0x000ABE5C
		[CompilerGenerated]
		private IEnumerator <OnStartClient>g__WaitForDataSend|12_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			this.SendSurfaceItemData(base.ItemInstance, base.GUID.ToString(), this.ParentSurface.GUID.ToString(), this.RelativePosition, this.RelativeRotation);
			yield break;
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x000ADC6B File Offset: 0x000ABE6B
		[CompilerGenerated]
		private IEnumerator <SetTransformData>g__Routine|17_0()
		{
			yield return new WaitUntil(() => base.NetworkObject.IsSpawned);
			base.transform.SetParent(this.ParentSurface.Container.transform);
			yield break;
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000ADC7C File Offset: 0x000ABE7C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(5U, new ServerRpcDelegate(this.RpcReader___Server_SendSurfaceItemData_2652836379));
			base.RegisterTargetRpc(6U, new ClientRpcDelegate(this.RpcReader___Target_InitializeSurfaceItem_2932264618));
			base.RegisterObserversRpc(7U, new ClientRpcDelegate(this.RpcReader___Observers_InitializeSurfaceItem_2932264618));
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000ADCE5 File Offset: 0x000ABEE5
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.EntityFramework.SurfaceItemAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000ADCFE File Offset: 0x000ABEFE
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000ADD0C File Offset: 0x000ABF0C
		private void RpcWriter___Server_SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
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
			writer.WriteString(parentSurfaceGUID);
			writer.WriteVector3(relativePosition);
			writer.WriteQuaternion(relativeRotation, AutoPackType.Packed);
			base.SendServerRpc(5U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000ADDEC File Offset: 0x000ABFEC
		public void RpcLogic___SendSurfaceItemData_2652836379(ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			this.InitializeSurfaceItem(null, instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x000ADDFC File Offset: 0x000ABFFC
		private void RpcReader___Server_SendSurfaceItemData_2652836379(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentSurfaceGUID = PooledReader0.ReadString();
			Vector3 relativePosition = PooledReader0.ReadVector3();
			Quaternion relativeRotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendSurfaceItemData_2652836379(instance, guid, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x000ADE78 File Offset: 0x000AC078
		private void RpcWriter___Target_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
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
			writer.WriteString(parentSurfaceGUID);
			writer.WriteVector3(relativePosition);
			writer.WriteQuaternion(relativeRotation, AutoPackType.Packed);
			base.SendTargetRpc(6U, writer, channel, DataOrderType.Default, conn, false, true);
			writer.Store();
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x000ADF66 File Offset: 0x000AC166
		public virtual void RpcLogic___InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
		{
			this.InitializeSurfaceItem(instance, GUID, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x000ADF78 File Offset: 0x000AC178
		private void RpcReader___Target_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentSurfaceGUID = PooledReader0.ReadString();
			Vector3 relativePosition = PooledReader0.ReadVector3();
			Quaternion relativeRotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___InitializeSurfaceItem_2932264618(base.LocalConnection, instance, guid, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x000ADFF8 File Offset: 0x000AC1F8
		private void RpcWriter___Observers_InitializeSurfaceItem_2932264618(NetworkConnection conn, ItemInstance instance, string GUID, string parentSurfaceGUID, Vector3 relativePosition, Quaternion relativeRotation)
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
			writer.WriteString(parentSurfaceGUID);
			writer.WriteVector3(relativePosition);
			writer.WriteQuaternion(relativeRotation, AutoPackType.Packed);
			base.SendObserversRpc(7U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
		private void RpcReader___Observers_InitializeSurfaceItem_2932264618(PooledReader PooledReader0, Channel channel)
		{
			ItemInstance instance = PooledReader0.ReadItemInstance();
			string guid = PooledReader0.ReadString();
			string parentSurfaceGUID = PooledReader0.ReadString();
			Vector3 relativePosition = PooledReader0.ReadVector3();
			Quaternion relativeRotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			if (!base.IsClientInitialized)
			{
				return;
			}
			if (base.IsHost)
			{
				return;
			}
			this.RpcLogic___InitializeSurfaceItem_2932264618(null, instance, guid, parentSurfaceGUID, relativePosition, relativeRotation);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000AE16D File Offset: 0x000AC36D
		protected virtual void dll()
		{
			base.Awake();
		}

		// Token: 0x04001EC2 RID: 7874
		[Header("Settings")]
		public List<Surface.ESurfaceType> ValidSurfaceTypes = new List<Surface.ESurfaceType>
		{
			Surface.ESurfaceType.Wall,
			Surface.ESurfaceType.Roof
		};

		// Token: 0x04001EC3 RID: 7875
		public bool AllowRotation = true;

		// Token: 0x04001EC5 RID: 7877
		protected Vector3 RelativePosition = Vector3.zero;

		// Token: 0x04001EC6 RID: 7878
		protected Quaternion RelativeRotation = Quaternion.identity;

		// Token: 0x04001EC7 RID: 7879
		private bool dll_Excuted;

		// Token: 0x04001EC8 RID: 7880
		private bool dll_Excuted;
	}
}
