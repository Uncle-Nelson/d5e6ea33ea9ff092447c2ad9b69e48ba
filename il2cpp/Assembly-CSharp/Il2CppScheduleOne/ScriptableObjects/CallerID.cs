using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004AF RID: 1199
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x060069B7 RID: 27063 RVA: 0x001D934C File Offset: 0x001D754C
		// Note: this type is marked as 'beforefieldinit'.
		static CallerID()
		{
			Il2CppClassPointerStore<CallerID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "CallerID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerID>.NativeClassPtr);
			CallerID.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "Name");
			CallerID.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "ProfilePicture");
			CallerID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerID>.NativeClassPtr, 100676721);
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x001D93B8 File Offset: 0x001D75B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88931, XrefRangeStart = 88919, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00031F6C File Offset: 0x0003016C
		public CallerID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x060069BA RID: 27066 RVA: 0x001D93F4 File Offset: 0x001D75F4
		// (set) Token: 0x060069BB RID: 27067 RVA: 0x00031F75 File Offset: 0x00030175
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x060069BC RID: 27068 RVA: 0x001D941C File Offset: 0x001D761C
		// (set) Token: 0x060069BD RID: 27069 RVA: 0x00031F94 File Offset: 0x00030194
		public unsafe Sprite ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400486C RID: 18540
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400486D RID: 18541
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x0400486E RID: 18542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
