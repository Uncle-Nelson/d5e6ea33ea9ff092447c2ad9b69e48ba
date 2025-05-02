using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000184 RID: 388
	[Serializable]
	public class VariableSetter : Object
	{
		// Token: 0x06001F12 RID: 7954 RVA: 0x000D18E0 File Offset: 0x000CFAE0
		// Note: this type is marked as 'beforefieldinit'.
		static VariableSetter()
		{
			Il2CppClassPointerStore<VariableSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr);
			VariableSetter.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "VariableName");
			VariableSetter.NativeFieldInfoPtr_NewValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "NewValue");
			VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666812);
			VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666813);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x000D1960 File Offset: 0x000CFB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108123, RefRangeEnd = 108124, XrefRangeStart = 108118, XrefRangeEnd = 108123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x000D1994 File Offset: 0x000CFB94
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00011761 File Offset: 0x0000F961
		public VariableSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000D19D0 File Offset: 0x000CFBD0
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0001176A File Offset: 0x0000F96A
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x000D19F8 File Offset: 0x000CFBF8
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00011789 File Offset: 0x0000F989
		public unsafe string NewValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeFieldInfoPtr_NewValue;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
