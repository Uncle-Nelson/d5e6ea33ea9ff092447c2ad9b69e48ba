using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BC RID: 1212
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		// Token: 0x06006A1F RID: 27167 RVA: 0x001DAB20 File Offset: 0x001D8D20
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Cash()
		{
			Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr);
			BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountIndex");
			BuildUpdate_Cash.NativeFieldInfoPtr_bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "bills");
			BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountLabel");
			BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676775);
			BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676776);
			BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676777);
			BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676778);
			BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676779);
			BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676780);
			BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676781);
			BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676782);
			BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676783);
			BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676784);
			BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676785);
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06006A20 RID: 27168 RVA: 0x001DAC68 File Offset: 0x001D8E68
		public unsafe float placeAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 213945, RefRangeEnd = 213948, XrefRangeStart = 213941, XrefRangeEnd = 213945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x001DACA4 File Offset: 0x001D8EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213948, XrefRangeEnd = 213970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x001DACD8 File Offset: 0x001D8ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213970, XrefRangeEnd = 213989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x001DAD14 File Offset: 0x001D8F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213989, XrefRangeEnd = 214024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x001DAD50 File Offset: 0x001D8F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214042, RefRangeEnd = 214043, XrefRangeStart = 214024, XrefRangeEnd = 214042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x001DAD84 File Offset: 0x001D8F84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214059, RefRangeEnd = 214063, XrefRangeStart = 214043, XrefRangeEnd = 214059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshGhostModelAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x001DADB8 File Offset: 0x001D8FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214063, XrefRangeEnd = 214100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x001DADF4 File Offset: 0x001D8FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214100, XrefRangeEnd = 214109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x001DAE30 File Offset: 0x001D9030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214109, XrefRangeEnd = 214111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x001DAE6C File Offset: 0x001D906C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 214117, RefRangeEnd = 214119, XrefRangeStart = 214111, XrefRangeEnd = 214117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRelevantCashBalane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x001DAEA8 File Offset: 0x001D90A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214119, XrefRangeEnd = 214129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x000321E7 File Offset: 0x000303E7
		public BuildUpdate_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06006A2C RID: 27180 RVA: 0x001DAEE4 File Offset: 0x001D90E4
		// (set) Token: 0x06006A2D RID: 27181 RVA: 0x000321F0 File Offset: 0x000303F0
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x001DAF0C File Offset: 0x001D910C
		// (set) Token: 0x06006A2F RID: 27183 RVA: 0x0003220B File Offset: 0x0003040B
		public unsafe List<Transform> bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06006A30 RID: 27184 RVA: 0x001DAF3C File Offset: 0x001D913C
		// (set) Token: 0x06006A31 RID: 27185 RVA: 0x0003222A File Offset: 0x0003042A
		public unsafe WorldSpaceLabel amountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpaceLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048AB RID: 18603
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x040048AC RID: 18604
		private static readonly IntPtr NativeFieldInfoPtr_bills;

		// Token: 0x040048AD RID: 18605
		private static readonly IntPtr NativeFieldInfoPtr_amountLabel;

		// Token: 0x040048AE RID: 18606
		private static readonly IntPtr NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0;

		// Token: 0x040048AF RID: 18607
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040048B0 RID: 18608
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040048B1 RID: 18609
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040048B2 RID: 18610
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Private_Void_0;

		// Token: 0x040048B3 RID: 18611
		private static readonly IntPtr NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0;

		// Token: 0x040048B4 RID: 18612
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_Void_0;

		// Token: 0x040048B5 RID: 18613
		private static readonly IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0;

		// Token: 0x040048B6 RID: 18614
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_0;

		// Token: 0x040048B7 RID: 18615
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0;

		// Token: 0x040048B8 RID: 18616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
