using System;
using System.Collections.Generic;
using EPOOutline;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Construction.Features;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	// Token: 0x0200092F RID: 2351
	public class Constructable : NetworkBehaviour
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x0010C8C4 File Offset: 0x0010AAC4
		public bool IsStatic
		{
			get
			{
				return this.isStatic;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003FA3 RID: 16291 RVA: 0x0010C8CC File Offset: 0x0010AACC
		public string ConstructableName
		{
			get
			{
				return this.constructableName;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x0010C8D4 File Offset: 0x0010AAD4
		public string ConstructableDescription
		{
			get
			{
				return this.constructableDescription;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x0010C8DC File Offset: 0x0010AADC
		public string ConstructableAssetPath
		{
			get
			{
				return this.constructableAssetPath;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x0010C8E4 File Offset: 0x0010AAE4
		public string PrefabID
		{
			get
			{
				return this.ID;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x0010C8EC File Offset: 0x0010AAEC
		public Sprite ConstructableIcon
		{
			get
			{
				return this.constructableIcon;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x0010C8F4 File Offset: 0x0010AAF4
		public GameObject _constructionHandler_Asset
		{
			get
			{
				return this.constructionHandler_Asset;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06003FA9 RID: 16297 RVA: 0x0010C8FC File Offset: 0x0010AAFC
		// (set) Token: 0x06003FAA RID: 16298 RVA: 0x0010C904 File Offset: 0x0010AB04
		public bool isVisible { get; protected set; } = true;

		// Token: 0x06003FAB RID: 16299 RVA: 0x0010C910 File Offset: 0x0010AB10
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ConstructableScripts.Constructable_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0006129E File Offset: 0x0005F49E
		public override void OnStartClient()
		{
			base.OnStartClient();
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x0010C92F File Offset: 0x0010AB2F
		public virtual bool CanBeDestroyed(out string reason)
		{
			reason = string.Empty;
			return !this.isStatic;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x0010C944 File Offset: 0x0010AB44
		public virtual bool CanBeDestroyed()
		{
			string text;
			return this.CanBeDestroyed(out text);
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x0010C959 File Offset: 0x0010AB59
		public virtual void DestroyConstructable(bool callOnServer = true)
		{
			if (this.isDestroyed)
			{
				return;
			}
			this.isDestroyed = true;
			Console.Log("Destroying constructable", null);
			if (callOnServer)
			{
				this.Destroy_Networked();
			}
			base.gameObject.SetActive(false);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x0010C98B File Offset: 0x0010AB8B
		[ServerRpc(RequireOwnership = false)]
		private void Destroy_Networked()
		{
			this.RpcWriter___Server_Destroy_Networked_2166136261();
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x0010C993 File Offset: 0x0010AB93
		[ObserversRpc]
		private void DestroyConstructableWrapper()
		{
			this.RpcWriter___Observers_DestroyConstructableWrapper_2166136261();
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x000022C9 File Offset: 0x000004C9
		public virtual bool CanBeModified()
		{
			return true;
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x000141BA File Offset: 0x000123BA
		public virtual bool CanBePickedUpByHand()
		{
			return false;
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0010C99B File Offset: 0x0010AB9B
		public virtual bool CanBeSelected()
		{
			return !this.isStatic;
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x0003CEED File Offset: 0x0003B0ED
		public virtual string GetBuildableVersionAssetPath()
		{
			return string.Empty;
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x0010C9A8 File Offset: 0x0010ABA8
		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
			if (this.outlineEffect == null)
			{
				this.outlineEffect = base.gameObject.AddComponent<Outlinable>();
				this.outlineEffect.OutlineParameters.BlurShift = 0f;
				this.outlineEffect.OutlineParameters.DilateShift = 0.5f;
				this.outlineEffect.OutlineParameters.FillPass.Shader = Resources.Load<Shader>("Easy performant outline/Shaders/Fills/ColorFill");
				foreach (GameObject gameObject in this.outlineRenderers)
				{
					MeshRenderer[] componentsInChildren = gameObject.GetComponentsInChildren<MeshRenderer>();
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						OutlineTarget outlineTarget = new OutlineTarget(componentsInChildren[i], 0);
						this.outlineEffect.TryAddTarget(outlineTarget);
					}
				}
			}
			this.outlineEffect.OutlineParameters.Color = BuildableItem.GetColorFromOutlineColorEnum(color);
			Color32 colorFromOutlineColorEnum = BuildableItem.GetColorFromOutlineColorEnum(color);
			colorFromOutlineColorEnum.a = 9;
			this.outlineEffect.OutlineParameters.FillPass.SetColor("_PublicColor", colorFromOutlineColorEnum);
			this.outlineEffect.enabled = true;
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x0010CAE4 File Offset: 0x0010ACE4
		public void HideOutline()
		{
			if (this.outlineEffect != null)
			{
				this.outlineEffect.enabled = false;
			}
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x000676C2 File Offset: 0x000658C2
		public virtual Vector3 GetCosmeticCenter()
		{
			return base.transform.position;
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0010CB00 File Offset: 0x0010AD00
		public float GetBoundingBoxLongestSide()
		{
			return Mathf.Max(Mathf.Max(this.boundingBox.size.x, this.boundingBox.size.y), this.boundingBox.size.z);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x0010CB3C File Offset: 0x0010AD3C
		public virtual void SetInvisible()
		{
			this.isVisible = false;
			this.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Invisible"));
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x0010CB5C File Offset: 0x0010AD5C
		public virtual void RestoreVisibility()
		{
			this.isVisible = true;
			foreach (Transform transform in base.GetComponentsInChildren<Transform>(true))
			{
				if (transform.gameObject.layer != LayerMask.NameToLayer("Grid"))
				{
					if (this.originalLayers.ContainsKey(transform))
					{
						transform.gameObject.layer = this.originalLayers[transform];
					}
					else
					{
						transform.gameObject.layer = LayerMask.NameToLayer("Default");
					}
				}
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0010CBE4 File Offset: 0x0010ADE4
		public void SetLayerRecursively(GameObject go, int layerNumber)
		{
			foreach (Transform transform in go.GetComponentsInChildren<Transform>(true))
			{
				if (transform.gameObject.layer != LayerMask.NameToLayer("Grid"))
				{
					if (transform.gameObject.layer != LayerMask.NameToLayer("Default"))
					{
						if (this.originalLayers.ContainsKey(transform))
						{
							this.originalLayers[transform] = transform.gameObject.layer;
						}
						else
						{
							this.originalLayers.Add(transform, transform.gameObject.layer);
						}
					}
					transform.gameObject.layer = layerNumber;
				}
			}
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x0010CCFC File Offset: 0x0010AEFC
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted = true;
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_Destroy_Networked_2166136261));
			base.RegisterObserversRpc(1U, new ClientRpcDelegate(this.RpcReader___Observers_DestroyConstructableWrapper_2166136261));
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x0010CD48 File Offset: 0x0010AF48
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x0010CD5B File Offset: 0x0010AF5B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x0010CD6C File Offset: 0x0010AF6C
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
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x0010CE06 File Offset: 0x0010B006
		private void RpcLogic___Destroy_Networked_2166136261()
		{
			Console.Log("Networked", null);
			this.DestroyConstructableWrapper();
			base.Despawn(new DespawnType?(DespawnType.Destroy));
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x0010CE28 File Offset: 0x0010B028
		private void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___Destroy_Networked_2166136261();
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x0010CE48 File Offset: 0x0010B048
		private void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
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
			base.SendObserversRpc(1U, writer, channel, DataOrderType.Default, false, false, false);
			writer.Store();
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x0010CEF1 File Offset: 0x0010B0F1
		private void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
			Console.Log("Wrapper", null);
			this.DestroyConstructable(false);
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x0010CF08 File Offset: 0x0010B108
		private void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			if (!base.IsClientInitialized)
			{
				return;
			}
			this.RpcLogic___DestroyConstructableWrapper_2166136261();
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x0010CF28 File Offset: 0x0010B128
		protected virtual void dll()
		{
			this.boundingBox.isTrigger = true;
			this.boundingBox.gameObject.layer = LayerMask.NameToLayer("Invisible");
			foreach (Feature feature in this.features)
			{
			}
		}

		// Token: 0x04002DCB RID: 11723
		[Header("Basic settings")]
		[SerializeField]
		protected bool isStatic;

		// Token: 0x04002DCC RID: 11724
		[SerializeField]
		protected string constructableName = "Constructable";

		// Token: 0x04002DCD RID: 11725
		[SerializeField]
		protected string constructableDescription = "Description";

		// Token: 0x04002DCE RID: 11726
		[SerializeField]
		protected string constructableAssetPath = string.Empty;

		// Token: 0x04002DCF RID: 11727
		[SerializeField]
		protected string ID = string.Empty;

		// Token: 0x04002DD0 RID: 11728
		[SerializeField]
		protected Sprite constructableIcon;

		// Token: 0x04002DD1 RID: 11729
		[Header("Bounds settings")]
		public BoxCollider boundingBox;

		// Token: 0x04002DD2 RID: 11730
		[Header("Construction Handler")]
		[SerializeField]
		protected GameObject constructionHandler_Asset;

		// Token: 0x04002DD3 RID: 11731
		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers = new List<GameObject>();

		// Token: 0x04002DD4 RID: 11732
		protected Outlinable outlineEffect;

		// Token: 0x04002DD5 RID: 11733
		[Header("Features")]
		public List<Feature> features = new List<Feature>();

		// Token: 0x04002DD7 RID: 11735
		private bool isDestroyed;

		// Token: 0x04002DD8 RID: 11736
		private Dictionary<Transform, LayerMask> originalLayers = new Dictionary<Transform, LayerMask>();

		// Token: 0x04002DD9 RID: 11737
		private bool dll_Excuted;

		// Token: 0x04002DDA RID: 11738
		private bool dll_Excuted;
	}
}
