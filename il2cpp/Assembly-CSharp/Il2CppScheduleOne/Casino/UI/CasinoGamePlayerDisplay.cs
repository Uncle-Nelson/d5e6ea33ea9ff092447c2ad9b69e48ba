using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004AB RID: 1195
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x06006938 RID: 26936 RVA: 0x001D7BBC File Offset: 0x001D5DBC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerDisplay()
		{
			Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "CasinoGamePlayerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr);
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "BindedPlayers");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "TitleLabel");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "PlayerEntries");
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676672);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676673);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676674);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676675);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676676);
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x001D7C8C File Offset: 0x001D5E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212646, RefRangeEnd = 212647, XrefRangeStart = 212595, XrefRangeEnd = 212646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x001D7CC0 File Offset: 0x001D5EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212647, XrefRangeEnd = 212658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x001D7CF4 File Offset: 0x001D5EF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212674, RefRangeEnd = 212676, XrefRangeStart = 212658, XrefRangeEnd = 212674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(CasinoGamePlayers players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x001D7D38 File Offset: 0x001D5F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212694, RefRangeEnd = 212696, XrefRangeStart = 212676, XrefRangeEnd = 212694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unbind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x001D7D6C File Offset: 0x001D5F6C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x00031AC6 File Offset: 0x0002FCC6
		public CasinoGamePlayerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600693F RID: 26943 RVA: 0x001D7DA8 File Offset: 0x001D5FA8
		// (set) Token: 0x06006940 RID: 26944 RVA: 0x00031ACF File Offset: 0x0002FCCF
		public unsafe CasinoGamePlayers BindedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006941 RID: 26945 RVA: 0x001D7DD8 File Offset: 0x001D5FD8
		// (set) Token: 0x06006942 RID: 26946 RVA: 0x00031AEE File Offset: 0x0002FCEE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006943 RID: 26947 RVA: 0x001D7E08 File Offset: 0x001D6008
		// (set) Token: 0x06006944 RID: 26948 RVA: 0x00031B0D File Offset: 0x0002FD0D
		public unsafe Il2CppReferenceArray<RectTransform> PlayerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400481C RID: 18460
		private static readonly IntPtr NativeFieldInfoPtr_BindedPlayers;

		// Token: 0x0400481D RID: 18461
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400481E RID: 18462
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEntries;

		// Token: 0x0400481F RID: 18463
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPlayers_Public_Void_0;

		// Token: 0x04004820 RID: 18464
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScores_Public_Void_0;

		// Token: 0x04004821 RID: 18465
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0;

		// Token: 0x04004822 RID: 18466
		private static readonly IntPtr NativeMethodInfoPtr_Unbind_Public_Void_0;

		// Token: 0x04004823 RID: 18467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
