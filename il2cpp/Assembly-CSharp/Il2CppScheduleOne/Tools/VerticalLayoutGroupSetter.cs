using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000554 RID: 1364
	public class VerticalLayoutGroupSetter : MonoBehaviour
	{
		// Token: 0x06007825 RID: 30757 RVA: 0x0020825C File Offset: 0x0020645C
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalLayoutGroupSetter()
		{
			Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VerticalLayoutGroupSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr);
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "LeftSpacing");
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "layoutGroup");
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678401);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678402);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678403);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x002082F0 File Offset: 0x002064F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232486, XrefRangeEnd = 232490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00208324 File Offset: 0x00206524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232490, XrefRangeEnd = 232499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00208358 File Offset: 0x00206558
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalLayoutGroupSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00038F06 File Offset: 0x00037106
		public VerticalLayoutGroupSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x00208394 File Offset: 0x00206594
		// (set) Token: 0x0600782B RID: 30763 RVA: 0x00038F0F File Offset: 0x0003710F
		public unsafe float LeftSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing)) = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x002083BC File Offset: 0x002065BC
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x00038F2A File Offset: 0x0003712A
		public unsafe VerticalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051E9 RID: 20969
		private static readonly IntPtr NativeFieldInfoPtr_LeftSpacing;

		// Token: 0x040051EA RID: 20970
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x040051EB RID: 20971
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051EC RID: 20972
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040051ED RID: 20973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
