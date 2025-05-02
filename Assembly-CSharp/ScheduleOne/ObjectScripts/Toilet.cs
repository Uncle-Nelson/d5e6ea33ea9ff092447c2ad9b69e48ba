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
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000B9C RID: 2972
	public class Toilet : GridItem
	{
		// Token: 0x06004F9F RID: 20383 RVA: 0x0014FB17 File Offset: 0x0014DD17
		public void Hovered()
		{
			if (!this.isFlushing)
			{
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.IntObj.SetMessage("Flush");
				return;
			}
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x0014FB4A File Offset: 0x0014DD4A
		public void Interacted()
		{
			this.isFlushing = true;
			this.SendFlush();
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x0014FB59 File Offset: 0x0014DD59
		[ServerRpc(RequireOwnership = false)]
		private void SendFlush()
		{
			this.RpcWriter___Server_SendFlush_2166136261();
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x0014FB61 File Offset: 0x0014DD61
		[ObserversRpc]
		private void Flush()
		{
			this.RpcWriter___Observers_Flush_2166136261();
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x0014FB87 File Offset: 0x0014DD87
		[CompilerGenerated]
		private IEnumerator <Flush>g__Routine|11_0()
		{
			if (this.OnFlush != null)
			{
				this.OnFlush.Invoke();
			}
			yield return new WaitForSeconds(this.InitialDelay);
			float checkRate = 0.5f;
			int reps = (int)(this.FlushTime / checkRate);
			int j;
			for (int i = 0; i < reps; i = j + 1)
			{
				if (InstanceFinder.IsServer)
				{
					Collider[] array = Physics.OverlapSphere(this.ItemDetectionCollider.transform.position, this.ItemDetectionCollider.radius, this.ItemLayerMask);
					List<TrashItem> list = new List<TrashItem>();
					Collider[] array2 = array;
					for (j = 0; j < array2.Length; j++)
					{
						TrashItem componentInParent = array2[j].GetComponentInParent<TrashItem>();
						if (componentInParent != null && !list.Contains(componentInParent))
						{
							list.Add(componentInParent);
						}
					}
					if (list.Count > 0)
					{
						foreach (TrashItem trashItem in list)
						{
							trashItem.DestroyTrash();
						}
					}
				}
				yield return new WaitForSeconds(checkRate);
				j = i;
			}
			this._flushCoroutine = null;
			this.isFlushing = false;
			yield break;
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x0014FB98 File Offset: 0x0014DD98
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(8U, new ServerRpcDelegate(this.RpcReader___Server_SendFlush_2166136261));
			base.RegisterObserversRpc(9U, new ClientRpcDelegate(this.RpcReader___Observers_Flush_2166136261));
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x0014FBEA File Offset: 0x0014DDEA
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x0014FC03 File Offset: 0x0014DE03
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x0014FC14 File Offset: 0x0014DE14
		private void RpcWriter___Server_SendFlush_2166136261()
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
			base.SendServerRpc(8U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0014FCAE File Offset: 0x0014DEAE
		private void RpcLogic___SendFlush_2166136261()
		{
			this.Flush();
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x0014FCB8 File Offset: 0x0014DEB8
		private void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___SendFlush_2166136261();
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x0014FCD8 File Offset: 0x0014DED8
		private void RpcWriter___Observers_Flush_2166136261()
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
			base.SendObserversRpc(9U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x0014FD81 File Offset: 0x0014DF81
		private void RpcLogic___Flush_2166136261()
		{
			this.isFlushing = true;
			this._flushCoroutine = base.StartCoroutine(this.<Flush>g__Routine|11_0());
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x0014FD9C File Offset: 0x0014DF9C
		private void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___Flush_2166136261();
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x0014FDBC File Offset: 0x0014DFBC
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04003C0A RID: 15370
		public float InitialDelay = 0.5f;

		// Token: 0x04003C0B RID: 15371
		public float FlushTime = 5f;

		// Token: 0x04003C0C RID: 15372
		public InteractableObject IntObj;

		// Token: 0x04003C0D RID: 15373
		public LayerMask ItemLayerMask;

		// Token: 0x04003C0E RID: 15374
		public SphereCollider ItemDetectionCollider;

		// Token: 0x04003C0F RID: 15375
		public UnityEvent OnFlush;

		// Token: 0x04003C10 RID: 15376
		private Coroutine _flushCoroutine;

		// Token: 0x04003C11 RID: 15377
		private bool isFlushing;

		// Token: 0x04003C12 RID: 15378
		private bool dll_Excuted;

		// Token: 0x04003C13 RID: 15379
		private bool dll_Excuted;
	}
}
