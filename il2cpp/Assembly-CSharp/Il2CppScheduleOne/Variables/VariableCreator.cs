using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000182 RID: 386
	[Serializable]
	public class VariableCreator : Object
	{
		// Token: 0x06001EC4 RID: 7876 RVA: 0x000D04B4 File Offset: 0x000CE6B4
		// Note: this type is marked as 'beforefieldinit'.
		static VariableCreator()
		{
			Il2CppClassPointerStore<VariableCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr);
			VariableCreator.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Name");
			VariableCreator.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Type");
			VariableCreator.NativeFieldInfoPtr_InitialValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "InitialValue");
			VariableCreator.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Persistent");
			VariableCreator.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Mode");
			VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, 100666770);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x000D055C File Offset: 0x000CE75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107484, XrefRangeEnd = 107488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00011577 File Offset: 0x0000F777
		public VariableCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x000D0598 File Offset: 0x000CE798
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00011580 File Offset: 0x0000F780
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x000D05C0 File Offset: 0x000CE7C0
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0001159F File Offset: 0x0000F79F
		public unsafe VariableDatabase.EVariableType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000D05E8 File Offset: 0x000CE7E8
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x000115BA File Offset: 0x0000F7BA
		public unsafe string InitialValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x000D0610 File Offset: 0x000CE810
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x000115D9 File Offset: 0x0000F7D9
		public unsafe bool Persistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x000D0638 File Offset: 0x000CE838
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x000115F4 File Offset: 0x0000F7F4
		public unsafe EVariableMode Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode)) = value;
			}
		}

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_InitialValue;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeFieldInfoPtr_Mode;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
