using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005ED RID: 1517
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008491 RID: 33937 RVA: 0x00233310 File Offset: 0x00231510
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemDefinition()
		{
			Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr);
			QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, "DefaultQuality");
			QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100679892);
			QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100679893);
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x0023337C File Offset: 0x0023157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249195, XrefRangeEnd = 249201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x002333D4 File Offset: 0x002315D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249209, RefRangeEnd = 249210, XrefRangeStart = 249201, XrefRangeEnd = 249209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008494 RID: 33940 RVA: 0x0003ED7F File Offset: 0x0003CF7F
		public QualityItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x06008495 RID: 33941 RVA: 0x00233410 File Offset: 0x00231610
		// (set) Token: 0x06008496 RID: 33942 RVA: 0x0003ED88 File Offset: 0x0003CF88
		public unsafe EQuality DefaultQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality)) = value;
			}
		}

		// Token: 0x04005A4B RID: 23115
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuality;

		// Token: 0x04005A4C RID: 23116
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A4D RID: 23117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
