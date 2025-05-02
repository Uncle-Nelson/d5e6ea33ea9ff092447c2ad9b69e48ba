using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003BF RID: 959
	public class Unlockable : Il2CppSystem.Object
	{
		// Token: 0x06004AD2 RID: 19154 RVA: 0x0016A9F8 File Offset: 0x00168BF8
		// Note: this type is marked as 'beforefieldinit'.
		static Unlockable()
		{
			Il2CppClassPointerStore<Unlockable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "Unlockable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unlockable>.NativeClassPtr);
			Unlockable.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Rank");
			Unlockable.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Title");
			Unlockable.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Icon");
			Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, 100672583);
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0016AA78 File Offset: 0x00168C78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164620, RefRangeEnd = 164622, XrefRangeStart = 164617, XrefRangeEnd = 164620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unlockable(FullRank rank, string title, Sprite icon) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unlockable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x00024069 File Offset: 0x00022269
		public Unlockable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x0016AAE4 File Offset: 0x00168CE4
		// (set) Token: 0x06004AD6 RID: 19158 RVA: 0x00024072 File Offset: 0x00022272
		public unsafe FullRank Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x0016AB0C File Offset: 0x00168D0C
		// (set) Token: 0x06004AD8 RID: 19160 RVA: 0x0002408D File Offset: 0x0002228D
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x0016AB34 File Offset: 0x00168D34
		// (set) Token: 0x06004ADA RID: 19162 RVA: 0x000240AC File Offset: 0x000222AC
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0;
	}
}
