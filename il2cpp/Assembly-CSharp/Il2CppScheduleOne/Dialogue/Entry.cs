using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000439 RID: 1081
	[Serializable]
	public sealed class Entry : ValueType
	{
		// Token: 0x06005EBB RID: 24251 RVA: 0x001B3E34 File Offset: 0x001B2034
		// Note: this type is marked as 'beforefieldinit'.
		static Entry()
		{
			Il2CppClassPointerStore<Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "Entry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entry>.NativeClassPtr);
			Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Key");
			Entry.NativeFieldInfoPtr_Chains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Chains");
			Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675368);
			Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100675369);
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x001B3EB4 File Offset: 0x001B20B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197683, XrefRangeEnd = 197684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetRandomChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x001B3EF8 File Offset: 0x001B20F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197684, XrefRangeEnd = 197685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x0002CAAA File Offset: 0x0002ACAA
		public Entry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0002CAB3 File Offset: 0x0002ACB3
		public Entry() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entry>.NativeClassPtr))
		{
		}

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x06005EC0 RID: 24256 RVA: 0x001B3F34 File Offset: 0x001B2134
		// (set) Token: 0x06005EC1 RID: 24257 RVA: 0x0002CAC5 File Offset: 0x0002ACC5
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x001B3F5C File Offset: 0x001B215C
		// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		public unsafe Il2CppReferenceArray<DialogueChain> Chains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040C6 RID: 16582
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x040040C7 RID: 16583
		private static readonly IntPtr NativeFieldInfoPtr_Chains;

		// Token: 0x040040C8 RID: 16584
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0;

		// Token: 0x040040C9 RID: 16585
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;
	}
}
