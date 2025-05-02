using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003AD RID: 941
	public class Preset : Il2CppSystem.Object
	{
		// Token: 0x0600498E RID: 18830 RVA: 0x00166630 File Offset: 0x00164830
		// Note: this type is marked as 'beforefieldinit'.
		static Preset()
		{
			Il2CppClassPointerStore<Preset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "Preset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preset>.NativeClassPtr);
			Preset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetName");
			Preset.NativeFieldInfoPtr_PresetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetColor");
			Preset.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "ObjectType");
			Preset.NativeFieldInfoPtr_onNameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onNameChanged");
			Preset.NativeFieldInfoPtr_onDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onDeleted");
			Preset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672420);
			Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672421);
			Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672422);
			Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672423);
			Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672424);
			Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672425);
			Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672426);
		}

		// Token: 0x0600498F RID: 18831 RVA: 0x00166750 File Offset: 0x00164950
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163607, RefRangeEnd = 163611, XrefRangeStart = 163602, XrefRangeEnd = 163607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004990 RID: 18832 RVA: 0x0016678C File Offset: 0x0016498C
		[CallerCount(0)]
		public unsafe virtual Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x001667D8 File Offset: 0x001649D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163612, RefRangeEnd = 163613, XrefRangeStart = 163611, XrefRangeEnd = 163612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x00166828 File Offset: 0x00164A28
		[CallerCount(0)]
		public unsafe virtual void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x00166864 File Offset: 0x00164A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163615, RefRangeEnd = 163616, XrefRangeStart = 163613, XrefRangeEnd = 163615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string newName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x001668A8 File Offset: 0x00164AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163616, RefRangeEnd = 163617, XrefRangeStart = 163616, XrefRangeEnd = 163616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeletePreset(Preset replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x001668EC File Offset: 0x00164AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163623, RefRangeEnd = 163624, XrefRangeStart = 163617, XrefRangeEnd = 163623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Preset GetDefault(ManageableObjectType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000236F9 File Offset: 0x000218F9
		public Preset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004997 RID: 18839 RVA: 0x0016692C File Offset: 0x00164B2C
		// (set) Token: 0x06004998 RID: 18840 RVA: 0x00023702 File Offset: 0x00021902
		public unsafe string PresetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x00166954 File Offset: 0x00164B54
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x00023721 File Offset: 0x00021921
		public unsafe Color32 PresetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor)) = value;
			}
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x0016697C File Offset: 0x00164B7C
		// (set) Token: 0x0600499C RID: 18844 RVA: 0x0002373C File Offset: 0x0002193C
		public unsafe ManageableObjectType ObjectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType)) = value;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x001669A4 File Offset: 0x00164BA4
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x00023757 File Offset: 0x00021957
		public unsafe Preset.NameChange onNameChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.NameChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x001669D4 File Offset: 0x00164BD4
		// (set) Token: 0x060049A0 RID: 18848 RVA: 0x00023776 File Offset: 0x00021976
		public unsafe Preset.PresetDeletion onDeleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.PresetDeletion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeFieldInfoPtr_PresetColor;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeFieldInfoPtr_onNameChanged;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeFieldInfoPtr_onDeleted;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0;

		// Token: 0x02000983 RID: 2435
		public sealed class NameChange : MulticastDelegate
		{
			// Token: 0x0600CA1A RID: 51738 RVA: 0x0030E40C File Offset: 0x0030C60C
			// Note: this type is marked as 'beforefieldinit'.
			static NameChange()
			{
				Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "NameChange");
				Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672427);
				Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672428);
				Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672429);
				Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672430);
			}

			// Token: 0x0600CA1B RID: 51739 RVA: 0x0030E480 File Offset: 0x0030C680
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83966, RefRangeEnd = 83970, XrefRangeStart = 83966, XrefRangeEnd = 83970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA1C RID: 51740 RVA: 0x0030E4DC File Offset: 0x0030C6DC
			[CallerCount(0)]
			public unsafe void Invoke(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA1D RID: 51741 RVA: 0x0030E520 File Offset: 0x0030C720
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string name, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA1E RID: 51742 RVA: 0x0030E594 File Offset: 0x0030C794
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA1F RID: 51743 RVA: 0x00062477 File Offset: 0x00060677
			public NameChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA20 RID: 51744 RVA: 0x00062480 File Offset: 0x00060680
			public static implicit operator Preset.NameChange(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.NameChange>(A_0);
			}

			// Token: 0x0600CA21 RID: 51745 RVA: 0x00062488 File Offset: 0x00060688
			public static Preset.NameChange operator +(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Preset.NameChange>();
			}

			// Token: 0x0600CA22 RID: 51746 RVA: 0x00062496 File Offset: 0x00060696
			public static Preset.NameChange operator -(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.NameChange>();
				}
				return result;
			}

			// Token: 0x040088BB RID: 35003
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088BC RID: 35004
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040088BD RID: 35005
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040088BE RID: 35006
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000984 RID: 2436
		public sealed class PresetDeletion : MulticastDelegate
		{
			// Token: 0x0600CA23 RID: 51747 RVA: 0x0030E5D8 File Offset: 0x0030C7D8
			// Note: this type is marked as 'beforefieldinit'.
			static PresetDeletion()
			{
				Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetDeletion");
				Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672431);
				Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672432);
				Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672433);
				Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672434);
			}

			// Token: 0x0600CA24 RID: 51748 RVA: 0x0030E64C File Offset: 0x0030C84C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106479, RefRangeEnd = 106558, XrefRangeStart = 106479, XrefRangeEnd = 106558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PresetDeletion(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA25 RID: 51749 RVA: 0x0030E6A8 File Offset: 0x0030C8A8
			[CallerCount(0)]
			public unsafe void Invoke(Preset replacement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA26 RID: 51750 RVA: 0x0030E6EC File Offset: 0x0030C8EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Preset replacement, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA27 RID: 51751 RVA: 0x0030E760 File Offset: 0x0030C960
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA28 RID: 51752 RVA: 0x000624A7 File Offset: 0x000606A7
			public PresetDeletion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA29 RID: 51753 RVA: 0x000624B0 File Offset: 0x000606B0
			public static implicit operator Preset.PresetDeletion(Action<Preset> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.PresetDeletion>(A_0);
			}

			// Token: 0x0600CA2A RID: 51754 RVA: 0x000624B8 File Offset: 0x000606B8
			public static Preset.PresetDeletion operator +(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Preset.PresetDeletion>();
			}

			// Token: 0x0600CA2B RID: 51755 RVA: 0x000624C6 File Offset: 0x000606C6
			public static Preset.PresetDeletion operator -(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.PresetDeletion>();
				}
				return result;
			}

			// Token: 0x040088BF RID: 35007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088C0 RID: 35008
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0;

			// Token: 0x040088C1 RID: 35009
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0;

			// Token: 0x040088C2 RID: 35010
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
