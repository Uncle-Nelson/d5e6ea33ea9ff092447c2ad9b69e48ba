using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.Tiles;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044F RID: 1103
	public class Autotest : MonoBehaviour
	{
		// Token: 0x06005FC4 RID: 24516 RVA: 0x001B74E8 File Offset: 0x001B56E8
		// Note: this type is marked as 'beforefieldinit'.
		static Autotest()
		{
			Il2CppClassPointerStore<Autotest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Autotest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Autotest>.NativeClassPtr);
			Autotest.NativeFieldInfoPtr_workerAccom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "workerAccom");
			Autotest.NativeFieldInfoPtr_crescentGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Autotest>.NativeClassPtr, "crescentGrid");
			Autotest.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675512);
			Autotest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Autotest>.NativeClassPtr, 100675513);
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x001B7568 File Offset: 0x001B5768
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x001B759C File Offset: 0x001B579C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Autotest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Autotest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Autotest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x0002D2FC File Offset: 0x0002B4FC
		public Autotest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x001B75D8 File Offset: 0x001B57D8
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x0002D305 File Offset: 0x0002B505
		public unsafe Constructable_GridBased workerAccom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_workerAccom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x001B7608 File Offset: 0x001B5808
		// (set) Token: 0x06005FCB RID: 24523 RVA: 0x0002D324 File Offset: 0x0002B524
		public unsafe Grid crescentGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Autotest.NativeFieldInfoPtr_crescentGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400416E RID: 16750
		private static readonly IntPtr NativeFieldInfoPtr_workerAccom;

		// Token: 0x0400416F RID: 16751
		private static readonly IntPtr NativeFieldInfoPtr_crescentGrid;

		// Token: 0x04004170 RID: 16752
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04004171 RID: 16753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
