using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000426 RID: 1062
	public class Peephole : MonoBehaviour
	{
		// Token: 0x06005D7B RID: 23931 RVA: 0x001AF89C File Offset: 0x001ADA9C
		// Note: this type is marked as 'beforefieldinit'.
		static Peephole()
		{
			Il2CppClassPointerStore<Peephole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "Peephole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Peephole>.NativeClassPtr);
			Peephole.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "DoorAnim");
			Peephole.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "OpenSound");
			Peephole.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Peephole>.NativeClassPtr, "CloseSound");
			Peephole.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675201);
			Peephole.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675202);
			Peephole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Peephole>.NativeClassPtr, 100675203);
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x001AF944 File Offset: 0x001ADB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196164, RefRangeEnd = 196165, XrefRangeStart = 196160, XrefRangeEnd = 196164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x001AF978 File Offset: 0x001ADB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196169, RefRangeEnd = 196170, XrefRangeStart = 196165, XrefRangeEnd = 196169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x001AF9AC File Offset: 0x001ADBAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Peephole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Peephole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Peephole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x0002C101 File Offset: 0x0002A301
		public Peephole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06005D80 RID: 23936 RVA: 0x001AF9E8 File Offset: 0x001ADBE8
		// (set) Token: 0x06005D81 RID: 23937 RVA: 0x0002C10A File Offset: 0x0002A30A
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06005D82 RID: 23938 RVA: 0x001AFA18 File Offset: 0x001ADC18
		// (set) Token: 0x06005D83 RID: 23939 RVA: 0x0002C129 File Offset: 0x0002A329
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06005D84 RID: 23940 RVA: 0x001AFA48 File Offset: 0x001ADC48
		// (set) Token: 0x06005D85 RID: 23941 RVA: 0x0002C148 File Offset: 0x0002A348
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Peephole.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
