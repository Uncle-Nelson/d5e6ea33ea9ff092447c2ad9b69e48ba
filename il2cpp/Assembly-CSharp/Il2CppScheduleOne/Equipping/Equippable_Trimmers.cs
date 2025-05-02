using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BC RID: 1468
	public class Equippable_Trimmers : Equippable_Viewmodel
	{
		// Token: 0x060080DE RID: 32990 RVA: 0x00226A8C File Offset: 0x00224C8C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Trimmers()
		{
			Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Trimmers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr);
			Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "CanClickAndDrag");
			Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, "SoundLoopPrefab");
			Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679455);
			Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr, 100679456);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x00226B0C File Offset: 0x00224D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244932, XrefRangeEnd = 244962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Trimmers.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x00226B48 File Offset: 0x00224D48
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244704, RefRangeEnd = 244712, XrefRangeStart = 244704, XrefRangeEnd = 244712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Trimmers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Trimmers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Trimmers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
		public Equippable_Trimmers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x060080E2 RID: 32994 RVA: 0x00226B84 File Offset: 0x00224D84
		// (set) Token: 0x060080E3 RID: 32995 RVA: 0x0003D2B1 File Offset: 0x0003B4B1
		public unsafe bool CanClickAndDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_CanClickAndDrag)) = value;
			}
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x060080E4 RID: 32996 RVA: 0x00226BAC File Offset: 0x00224DAC
		// (set) Token: 0x060080E5 RID: 32997 RVA: 0x0003D2CC File Offset: 0x0003B4CC
		public unsafe AudioSourceController SoundLoopPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Trimmers.NativeFieldInfoPtr_SoundLoopPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057C1 RID: 22465
		private static readonly IntPtr NativeFieldInfoPtr_CanClickAndDrag;

		// Token: 0x040057C2 RID: 22466
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoopPrefab;

		// Token: 0x040057C3 RID: 22467
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057C4 RID: 22468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
