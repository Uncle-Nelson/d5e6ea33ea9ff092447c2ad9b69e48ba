using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000622 RID: 1570
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x06008A7B RID: 35451 RVA: 0x00244BC8 File Offset: 0x00242DC8
		// Note: this type is marked as 'beforefieldinit'.
		static OpenSteamOverlay()
		{
			Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OpenSteamOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr);
			OpenSteamOverlay.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "APP_ID");
			OpenSteamOverlay.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "Type");
			OpenSteamOverlay.NativeFieldInfoPtr_CustomLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "CustomLink");
			OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680503);
			OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680504);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x00244C5C File Offset: 0x00242E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254484, XrefRangeEnd = 254487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenOverlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x00244C90 File Offset: 0x00242E90
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenSteamOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x000423F9 File Offset: 0x000405F9
		public OpenSteamOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x00244CCC File Offset: 0x00242ECC
		// (set) Token: 0x06008A80 RID: 35456 RVA: 0x00042402 File Offset: 0x00040602
		public unsafe static uint APP_ID
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&value));
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x06008A81 RID: 35457 RVA: 0x00244CE8 File Offset: 0x00242EE8
		// (set) Token: 0x06008A82 RID: 35458 RVA: 0x00042410 File Offset: 0x00040610
		public unsafe OpenSteamOverlay.EType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x00244D10 File Offset: 0x00242F10
		// (set) Token: 0x06008A84 RID: 35460 RVA: 0x0004242B File Offset: 0x0004062B
		public unsafe string CustomLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005DF3 RID: 24051
		private static readonly IntPtr NativeFieldInfoPtr_APP_ID;

		// Token: 0x04005DF4 RID: 24052
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04005DF5 RID: 24053
		private static readonly IntPtr NativeFieldInfoPtr_CustomLink;

		// Token: 0x04005DF6 RID: 24054
		private static readonly IntPtr NativeMethodInfoPtr_OpenOverlay_Public_Void_0;

		// Token: 0x04005DF7 RID: 24055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B11 RID: 2833
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04009061 RID: 36961
			Store,
			// Token: 0x04009062 RID: 36962
			CustomLink
		}
	}
}
