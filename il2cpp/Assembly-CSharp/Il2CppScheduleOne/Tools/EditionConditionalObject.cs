using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000537 RID: 1335
	public class EditionConditionalObject : MonoBehaviour
	{
		// Token: 0x060076CF RID: 30415 RVA: 0x00204444 File Offset: 0x00202644
		// Note: this type is marked as 'beforefieldinit'.
		static EditionConditionalObject()
		{
			Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EditionConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr);
			EditionConditionalObject.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, "type");
			EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678257);
			EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr, 100678258);
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x002044B0 File Offset: 0x002026B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231268, XrefRangeEnd = 231270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x002044E4 File Offset: 0x002026E4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EditionConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditionConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditionConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x000384E4 File Offset: 0x000366E4
		public EditionConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x00204520 File Offset: 0x00202720
		// (set) Token: 0x060076D4 RID: 30420 RVA: 0x000384ED File Offset: 0x000366ED
		public unsafe EditionConditionalObject.EType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditionConditionalObject.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04005120 RID: 20768
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04005121 RID: 20769
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005122 RID: 20770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9D RID: 2717
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04008E34 RID: 36404
			ActiveInDemo,
			// Token: 0x04008E35 RID: 36405
			ActiveInFullGame
		}
	}
}
