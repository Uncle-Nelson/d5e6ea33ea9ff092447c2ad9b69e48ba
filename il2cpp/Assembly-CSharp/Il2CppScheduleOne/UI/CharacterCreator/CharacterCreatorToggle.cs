using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000702 RID: 1794
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x0600A0DA RID: 41178 RVA: 0x00287BFC File Offset: 0x00285DFC
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorToggle()
		{
			Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr);
			CharacterCreatorToggle.NativeFieldInfoPtr_Button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button1");
			CharacterCreatorToggle.NativeFieldInfoPtr_Button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button2");
			CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682970);
			CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682971);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682972);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682973);
			CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100682974);
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x00287CB8 File Offset: 0x00285EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283020, XrefRangeEnd = 283034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00287CF4 File Offset: 0x00285EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283034, XrefRangeEnd = 283041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00287D30 File Offset: 0x00285F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283041, XrefRangeEnd = 283042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00287D64 File Offset: 0x00285F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283042, XrefRangeEnd = 283043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x00287D98 File Offset: 0x00285F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283043, XrefRangeEnd = 283046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x0004F204 File Offset: 0x0004D404
		public CharacterCreatorToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600A0E1 RID: 41185 RVA: 0x00287DD4 File Offset: 0x00285FD4
		// (set) Token: 0x0600A0E2 RID: 41186 RVA: 0x0004F20D File Offset: 0x0004D40D
		public unsafe Button Button1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x00287E04 File Offset: 0x00286004
		// (set) Token: 0x0600A0E4 RID: 41188 RVA: 0x0004F22C File Offset: 0x0004D42C
		public unsafe Button Button2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BD2 RID: 27602
		private static readonly IntPtr NativeFieldInfoPtr_Button1;

		// Token: 0x04006BD3 RID: 27603
		private static readonly IntPtr NativeFieldInfoPtr_Button2;

		// Token: 0x04006BD4 RID: 27604
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BD5 RID: 27605
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BD6 RID: 27606
		private static readonly IntPtr NativeMethodInfoPtr_OnButton1_Public_Void_0;

		// Token: 0x04006BD7 RID: 27607
		private static readonly IntPtr NativeMethodInfoPtr_OnButton2_Public_Void_0;

		// Token: 0x04006BD8 RID: 27608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
