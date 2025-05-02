using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006A6 RID: 1702
	public class AssetPathLink : MonoBehaviour
	{
		// Token: 0x06009852 RID: 38994 RVA: 0x0026E340 File Offset: 0x0026C540
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathLink()
		{
			Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "AssetPathLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr);
			AssetPathLink.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, "prefabID");
			AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr, 100682100);
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x0026E398 File Offset: 0x0026C598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272234, XrefRangeEnd = 272238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetPathLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetPathLink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetPathLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x0004A226 File Offset: 0x00048426
		public AssetPathLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06009855 RID: 38997 RVA: 0x0026E3D4 File Offset: 0x0026C5D4
		// (set) Token: 0x06009856 RID: 38998 RVA: 0x0004A22F File Offset: 0x0004842F
		public unsafe string prefabID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetPathLink.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400669B RID: 26267
		private static readonly IntPtr NativeFieldInfoPtr_prefabID;

		// Token: 0x0400669C RID: 26268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
