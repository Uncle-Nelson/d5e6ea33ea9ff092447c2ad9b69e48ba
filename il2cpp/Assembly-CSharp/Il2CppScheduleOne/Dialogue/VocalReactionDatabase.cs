using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200044A RID: 1098
	[Serializable]
	public class VocalReactionDatabase : Object
	{
		// Token: 0x06005FAD RID: 24493 RVA: 0x001B70D4 File Offset: 0x001B52D4
		// Note: this type is marked as 'beforefieldinit'.
		static VocalReactionDatabase()
		{
			Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "VocalReactionDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr);
			VocalReactionDatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entries");
			VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675500);
			VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, 100675501);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x001B7140 File Offset: 0x001B5340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198750, XrefRangeEnd = 198761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase.Entry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr_GetEntry_Public_Entry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VocalReactionDatabase.Entry>(intPtr3) : null;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x001B7190 File Offset: 0x001B5390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198761, XrefRangeEnd = 198769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VocalReactionDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x0002D25C File Offset: 0x0002B45C
		public VocalReactionDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06005FB1 RID: 24497 RVA: 0x001B71CC File Offset: 0x001B53CC
		// (set) Token: 0x06005FB2 RID: 24498 RVA: 0x0002D265 File Offset: 0x0002B465
		public unsafe List<VocalReactionDatabase.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VocalReactionDatabase.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Entry_String_0;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A0E RID: 2574
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600CEB2 RID: 52914 RVA: 0x0031B51C File Offset: 0x0031971C
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VocalReactionDatabase>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr);
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Key");
				VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, "Reactions");
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675502);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675503);
				VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr, 100675504);
			}

			// Token: 0x17004048 RID: 16456
			// (get) Token: 0x0600CEB3 RID: 52915 RVA: 0x0031B5AC File Offset: 0x003197AC
			public unsafe string name
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600CEB4 RID: 52916 RVA: 0x0031B5E4 File Offset: 0x003197E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198749, XrefRangeEnd = 198750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetRandomReaction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr_GetRandomReaction_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600CEB5 RID: 52917 RVA: 0x0031B61C File Offset: 0x0031981C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VocalReactionDatabase.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VocalReactionDatabase.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEB6 RID: 52918 RVA: 0x00064866 File Offset: 0x00062A66
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004046 RID: 16454
			// (get) Token: 0x0600CEB7 RID: 52919 RVA: 0x0031B658 File Offset: 0x00319858
			// (set) Token: 0x0600CEB8 RID: 52920 RVA: 0x0006486F File Offset: 0x00062A6F
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004047 RID: 16455
			// (get) Token: 0x0600CEB9 RID: 52921 RVA: 0x0031B680 File Offset: 0x00319880
			// (set) Token: 0x0600CEBA RID: 52922 RVA: 0x0006488E File Offset: 0x00062A8E
			public unsafe Il2CppStringArray Reactions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VocalReactionDatabase.Entry.NativeFieldInfoPtr_Reactions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B7D RID: 35709
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x04008B7E RID: 35710
			private static readonly IntPtr NativeFieldInfoPtr_Reactions;

			// Token: 0x04008B7F RID: 35711
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008B80 RID: 35712
			private static readonly IntPtr NativeMethodInfoPtr_GetRandomReaction_Public_String_0;

			// Token: 0x04008B81 RID: 35713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
