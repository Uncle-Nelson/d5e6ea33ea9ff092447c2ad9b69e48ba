using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.ExtendedComponents
{
	// Token: 0x020003FC RID: 1020
	public class GameInputField : TMP_InputField
	{
		// Token: 0x060054FE RID: 21758 RVA: 0x0018D870 File Offset: 0x0018BA70
		// Note: this type is marked as 'beforefieldinit'.
		static GameInputField()
		{
			Il2CppClassPointerStore<GameInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ExtendedComponents", "GameInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInputField>.NativeClassPtr);
			GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673855);
			GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673856);
			GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673857);
			GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100673858);
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x0018D8F0 File Offset: 0x0018BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180459, XrefRangeEnd = 180477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x0018D92C File Offset: 0x0018BB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180477, XrefRangeEnd = 180481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x0018D970 File Offset: 0x0018BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180481, XrefRangeEnd = 180485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x0018D9B4 File Offset: 0x0018BBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180485, XrefRangeEnd = 180489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInputField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00028D10 File Offset: 0x00026F10
		public GameInputField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
