using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F3 RID: 1523
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x060085C7 RID: 34247 RVA: 0x002370C4 File Offset: 0x002352C4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLayer()
		{
			Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr);
			AvatarLayer.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Name");
			AvatarLayer.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "AssetPath");
			AvatarLayer.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Texture");
			AvatarLayer.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal");
			AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal_DefaultFormat");
			AvatarLayer.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Order");
			AvatarLayer.NativeFieldInfoPtr_CombinedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "CombinedMaterial");
			AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, 100680011);
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x00237194 File Offset: 0x00235394
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060085C9 RID: 34249 RVA: 0x0003F8D6 File Offset: 0x0003DAD6
		public AvatarLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x060085CA RID: 34250 RVA: 0x002371D0 File Offset: 0x002353D0
		// (set) Token: 0x060085CB RID: 34251 RVA: 0x0003F8DF File Offset: 0x0003DADF
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x002371F8 File Offset: 0x002353F8
		// (set) Token: 0x060085CD RID: 34253 RVA: 0x0003F8FE File Offset: 0x0003DAFE
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x060085CE RID: 34254 RVA: 0x00237220 File Offset: 0x00235420
		// (set) Token: 0x060085CF RID: 34255 RVA: 0x0003F91D File Offset: 0x0003DB1D
		public unsafe Texture2D Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x00237250 File Offset: 0x00235450
		// (set) Token: 0x060085D1 RID: 34257 RVA: 0x0003F93C File Offset: 0x0003DB3C
		public unsafe Texture2D Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x00237280 File Offset: 0x00235480
		// (set) Token: 0x060085D3 RID: 34259 RVA: 0x0003F95B File Offset: 0x0003DB5B
		public unsafe Texture2D Normal_DefaultFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultFormat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x060085D4 RID: 34260 RVA: 0x002372B0 File Offset: 0x002354B0
		// (set) Token: 0x060085D5 RID: 34261 RVA: 0x0003F97A File Offset: 0x0003DB7A
		public unsafe int Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order)) = value;
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x060085D6 RID: 34262 RVA: 0x002372D8 File Offset: 0x002354D8
		// (set) Token: 0x060085D7 RID: 34263 RVA: 0x0003F995 File Offset: 0x0003DB95
		public unsafe Material CombinedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B13 RID: 23315
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005B14 RID: 23316
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x04005B15 RID: 23317
		private static readonly IntPtr NativeFieldInfoPtr_Texture;

		// Token: 0x04005B16 RID: 23318
		private static readonly IntPtr NativeFieldInfoPtr_Normal;

		// Token: 0x04005B17 RID: 23319
		private static readonly IntPtr NativeFieldInfoPtr_Normal_DefaultFormat;

		// Token: 0x04005B18 RID: 23320
		private static readonly IntPtr NativeFieldInfoPtr_Order;

		// Token: 0x04005B19 RID: 23321
		private static readonly IntPtr NativeFieldInfoPtr_CombinedMaterial;

		// Token: 0x04005B1A RID: 23322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
