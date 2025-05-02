using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppBeautify.Demos
{
	// Token: 0x02000139 RID: 313
	public class Demo : MonoBehaviour
	{
		// Token: 0x06001A44 RID: 6724 RVA: 0x000C2A8C File Offset: 0x000C0C8C
		// Note: this type is marked as 'beforefieldinit'.
		static Demo()
		{
			Il2CppClassPointerStore<Demo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Beautify.Demos", "Demo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Demo>.NativeClassPtr);
			Demo.NativeFieldInfoPtr_lutTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Demo>.NativeClassPtr, "lutTexture");
			Demo.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666084);
			Demo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666085);
			Demo.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666086);
			Demo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Demo>.NativeClassPtr, 100666087);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000C2B20 File Offset: 0x000C0D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97055, XrefRangeEnd = 97056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000C2B54 File Offset: 0x000C0D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97056, XrefRangeEnd = 97123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000C2B88 File Offset: 0x000C0D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97138, RefRangeEnd = 97140, XrefRangeStart = 97123, XrefRangeEnd = 97138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x000C2BBC File Offset: 0x000C0DBC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Demo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Demo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Demo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000EE83 File Offset: 0x0000D083
		public Demo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x000C2BF8 File Offset: 0x000C0DF8
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000EE8C File Offset: 0x0000D08C
		public unsafe Texture lutTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Demo.NativeFieldInfoPtr_lutTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Demo.NativeFieldInfoPtr_lutTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_lutTexture;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
