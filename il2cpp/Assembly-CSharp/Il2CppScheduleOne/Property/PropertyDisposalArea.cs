using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000511 RID: 1297
	public class PropertyDisposalArea : MonoBehaviour
	{
		// Token: 0x06007346 RID: 29510 RVA: 0x001F7694 File Offset: 0x001F5894
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDisposalArea()
		{
			Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyDisposalArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr);
			PropertyDisposalArea.NativeFieldInfoPtr_StandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "StandPoint");
			PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "TrashDropPoint");
			PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, 100677769);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x001F7700 File Offset: 0x001F5900
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDisposalArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00036D43 File Offset: 0x00034F43
		public PropertyDisposalArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x001F773C File Offset: 0x001F593C
		// (set) Token: 0x0600734A RID: 29514 RVA: 0x00036D4C File Offset: 0x00034F4C
		public unsafe Transform StandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x001F776C File Offset: 0x001F596C
		// (set) Token: 0x0600734C RID: 29516 RVA: 0x00036D6B File Offset: 0x00034F6B
		public unsafe Transform TrashDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EAF RID: 20143
		private static readonly IntPtr NativeFieldInfoPtr_StandPoint;

		// Token: 0x04004EB0 RID: 20144
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropPoint;

		// Token: 0x04004EB1 RID: 20145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
