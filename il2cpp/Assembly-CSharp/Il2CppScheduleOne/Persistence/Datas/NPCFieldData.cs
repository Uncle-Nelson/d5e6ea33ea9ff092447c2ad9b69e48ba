using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class NPCFieldData : Object
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x00108714 File Offset: 0x00106914
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldData()
		{
			Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr);
			NPCFieldData.NativeFieldInfoPtr_NPCGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, "NPCGuid");
			NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, 100668787);
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0010876C File Offset: 0x0010696C
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17913, RefRangeEnd = 18090, XrefRangeStart = 17913, XrefRangeEnd = 18090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData(string npcGuid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcGuid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0001948B File Offset: 0x0001768B
		public NPCFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002FBB RID: 12219 RVA: 0x001087B8 File Offset: 0x001069B8
		// (set) Token: 0x06002FBC RID: 12220 RVA: 0x00019494 File Offset: 0x00017694
		public unsafe string NPCGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeFieldInfoPtr_NPCGuid;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
