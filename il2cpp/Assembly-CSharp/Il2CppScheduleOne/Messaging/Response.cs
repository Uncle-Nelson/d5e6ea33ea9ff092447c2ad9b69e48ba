using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000377 RID: 887
	[Serializable]
	public class Response : Object
	{
		// Token: 0x060045AA RID: 17834 RVA: 0x001573D4 File Offset: 0x001555D4
		// Note: this type is marked as 'beforefieldinit'.
		static Response()
		{
			Il2CppClassPointerStore<Response>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Response");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Response>.NativeClassPtr);
			Response.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "text");
			Response.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "label");
			Response.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "callback");
			Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "disableDefaultResponseBehaviour");
			Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100671864);
			Response.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100671865);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x0015747C File Offset: 0x0015567C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157667, RefRangeEnd = 157672, XrefRangeStart = 157663, XrefRangeEnd = 157667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response(string _text, string _label, Action _callback = null, bool _disableDefaultResponseBehaviour = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _disableDefaultResponseBehaviour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x001574FC File Offset: 0x001556FC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00021E7A File Offset: 0x0002007A
		public Response(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x00157538 File Offset: 0x00155738
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00021E83 File Offset: 0x00020083
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x00157560 File Offset: 0x00155760
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00021EA2 File Offset: 0x000200A2
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x00157588 File Offset: 0x00155788
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x00021EC1 File Offset: 0x000200C1
		public unsafe Action callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001575B8 File Offset: 0x001557B8
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x00021EE0 File Offset: 0x000200E0
		public unsafe bool disableDefaultResponseBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour)) = value;
			}
		}

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultResponseBehaviour;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
