using System;
using System.Collections.Generic;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x02000725 RID: 1829
	public class ColorFeature : Feature
	{
		// Token: 0x06003183 RID: 12675 RVA: 0x000CD568 File Offset: 0x000CB768
		public override FI_Base CreateInterface(Transform parent)
		{
			FI_ColorPicker fi_ColorPicker = base.CreateInterface(parent) as FI_ColorPicker;
			fi_ColorPicker.onSelectionChanged.AddListener(new UnityAction<ColorFeature.NamedColor>(this.ApplyColor));
			fi_ColorPicker.onSelectionPurchased.AddListener(new UnityAction<ColorFeature.NamedColor>(this.BuyColor));
			return fi_ColorPicker;
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000CD5A4 File Offset: 0x000CB7A4
		public override void Default()
		{
			this.BuyColor(this.colors[this.defaultColorIndex]);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000CD5C0 File Offset: 0x000CB7C0
		private void ApplyColor(ColorFeature.NamedColor color)
		{
			for (int i = 0; i < this.colorTargets.Count; i++)
			{
				this.colorTargets[i].material.color = color.color;
			}
			foreach (ColorFeature.SecondaryPaintTarget secondaryPaintTarget in this.secondaryTargets)
			{
				for (int j = 0; j < secondaryPaintTarget.colorTargets.Count; j++)
				{
					secondaryPaintTarget.colorTargets[j].material.color = ColorFeature.ModifyColor(color.color, secondaryPaintTarget.sChange, secondaryPaintTarget.vChange);
				}
			}
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000CD684 File Offset: 0x000CB884
		public static Color ModifyColor(Color original, float sChange, float vChange)
		{
			float h;
			float num;
			float num2;
			Color.RGBToHSV(original, out h, out num, out num2);
			num = Mathf.Clamp(num + sChange / 100f, 0f, 1f);
			num2 = Mathf.Clamp(num2 + vChange / 100f, 0f, 1f);
			return Color.HSVToRGB(h, num, num2);
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x000CD6D7 File Offset: 0x000CB8D7
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
			this.RpcWriter___Server_SetData_3316948804(colorIndex);
			this.RpcLogic___SetData_3316948804(colorIndex);
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x000CD6ED File Offset: 0x000CB8ED
		private void ReceiveData()
		{
			this.ApplyColor(this.colors[this.SyncAccessor_ownedColorIndex]);
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000CD706 File Offset: 0x000CB906
		private void BuyColor(ColorFeature.NamedColor color)
		{
			this.SetData(this.colors.IndexOf(color));
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000CD744 File Offset: 0x000CB944
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			this.syncVar___ownedColorIndex = new SyncVar<int>(this, 0U, WritePermission.ServerOnly, ReadPermission.Observers, -1f, Channel.Reliable, this.ownedColorIndex);
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_SetData_3316948804));
			base.RegisterSyncVarRead(new SyncVarReadDelegate(this.ReadSyncVar___ScheduleOne.Construction.Features.ColorFeature));
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000CD7BC File Offset: 0x000CB9BC
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Construction.Features.ColorFeatureAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
			this.syncVar___ownedColorIndex.SetRegistered();
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000CD7E0 File Offset: 0x000CB9E0
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000CD7F0 File Offset: 0x000CB9F0
		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
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
			writer.WriteInt32(colorIndex, AutoPackType.Packed);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000CD89C File Offset: 0x000CBA9C
		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			if (!base.IsSpawned)
			{
				this.ApplyColor(this.colors[colorIndex]);
				return;
			}
			this.sync___set_value_ownedColorIndex(colorIndex, true);
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000CD8C4 File Offset: 0x000CBAC4
		private void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			int colorIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			if (!base.IsServerInitialized)
			{
				return;
			}
			if (conn.IsLocalClient)
			{
				return;
			}
			this.RpcLogic___SetData_3316948804(colorIndex);
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000CD907 File Offset: 0x000CBB07
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x000CD90F File Offset: 0x000CBB0F
		public int SyncAccessor_ownedColorIndex
		{
			get
			{
				return this.ownedColorIndex;
			}
			set
			{
				if (value || !base.IsServerInitialized)
				{
					this.ownedColorIndex = value;
				}
				if (Application.isPlaying)
				{
					this.syncVar___ownedColorIndex.SetValue(value, value);
				}
			}
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x000CD94C File Offset: 0x000CBB4C
		public virtual bool ColorFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			if (UInt321 != 0U)
			{
				return false;
			}
			if (PooledReader0 == null)
			{
				this.sync___set_value_ownedColorIndex(this.syncVar___ownedColorIndex.GetValue(true), true);
				return true;
			}
			int value = PooledReader0.ReadInt32(AutoPackType.Packed);
			this.sync___set_value_ownedColorIndex(value, Boolean2);
			return true;
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x000CD9A3 File Offset: 0x000CBBA3
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04002341 RID: 9025
		[Header("References")]
		[SerializeField]
		protected List<MeshRenderer> colorTargets = new List<MeshRenderer>();

		// Token: 0x04002342 RID: 9026
		[SerializeField]
		protected List<ColorFeature.SecondaryPaintTarget> secondaryTargets = new List<ColorFeature.SecondaryPaintTarget>();

		// Token: 0x04002343 RID: 9027
		[Header("Color settings")]
		public List<ColorFeature.NamedColor> colors = new List<ColorFeature.NamedColor>();

		// Token: 0x04002344 RID: 9028
		public int defaultColorIndex;

		// Token: 0x04002345 RID: 9029
		[SyncVar]
		public int ownedColorIndex;

		// Token: 0x04002346 RID: 9030
		public SyncVar<int> syncVar___ownedColorIndex;

		// Token: 0x04002347 RID: 9031
		private bool dll_Excuted;

		// Token: 0x04002348 RID: 9032
		private bool dll_Excuted;

		// Token: 0x02000726 RID: 1830
		[Serializable]
		public class NamedColor
		{
			// Token: 0x04002349 RID: 9033
			public string colorName;

			// Token: 0x0400234A RID: 9034
			public Color color;

			// Token: 0x0400234B RID: 9035
			public float price = 100f;
		}

		// Token: 0x02000727 RID: 1831
		[Serializable]
		public class SecondaryPaintTarget
		{
			// Token: 0x0400234C RID: 9036
			public List<MeshRenderer> colorTargets = new List<MeshRenderer>();

			// Token: 0x0400234D RID: 9037
			public float sChange;

			// Token: 0x0400234E RID: 9038
			public float vChange;
		}
	}
}
