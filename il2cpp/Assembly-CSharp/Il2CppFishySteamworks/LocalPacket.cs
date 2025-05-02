using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078E RID: 1934
	public sealed class LocalPacket : ValueType
	{
		// Token: 0x0600B72D RID: 46893 RVA: 0x002D797C File Offset: 0x002D5B7C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPacket()
		{
			Il2CppClassPointerStore<LocalPacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "LocalPacket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr);
			LocalPacket.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Data");
			LocalPacket.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Length");
			LocalPacket.NativeFieldInfoPtr_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Channel");
			LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, 100685799);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002D79FC File Offset: 0x002D5BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312207, XrefRangeEnd = 312219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPacket(ArraySegment<byte> data, byte channel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x00059FA3 File Offset: 0x000581A3
		public LocalPacket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x00059FAC File Offset: 0x000581AC
		public LocalPacket() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600B731 RID: 46897 RVA: 0x002D7A60 File Offset: 0x002D5C60
		// (set) Token: 0x0600B732 RID: 46898 RVA: 0x00059FBE File Offset: 0x000581BE
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x0600B733 RID: 46899 RVA: 0x002D7A90 File Offset: 0x002D5C90
		// (set) Token: 0x0600B734 RID: 46900 RVA: 0x00059FDD File Offset: 0x000581DD
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600B735 RID: 46901 RVA: 0x002D7AB8 File Offset: 0x002D5CB8
		// (set) Token: 0x0600B736 RID: 46902 RVA: 0x00059FF8 File Offset: 0x000581F8
		public unsafe byte Channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel)) = value;
			}
		}

		// Token: 0x04007B5E RID: 31582
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04007B5F RID: 31583
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x04007B60 RID: 31584
		private static readonly IntPtr NativeFieldInfoPtr_Channel;

		// Token: 0x04007B61 RID: 31585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0;
	}
}
