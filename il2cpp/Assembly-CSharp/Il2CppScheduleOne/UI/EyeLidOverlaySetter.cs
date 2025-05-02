using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000638 RID: 1592
	public class EyeLidOverlaySetter : MonoBehaviour
	{
		// Token: 0x06008CBA RID: 36026 RVA: 0x0024B8E8 File Offset: 0x00249AE8
		// Note: this type is marked as 'beforefieldinit'.
		static EyeLidOverlaySetter()
		{
			Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyeLidOverlaySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr);
			EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, "OpenOverride");
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680769);
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680770);
			EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680771);
			EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680772);
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x0024B97C File Offset: 0x00249B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257208, XrefRangeEnd = 257212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x0024B9B0 File Offset: 0x00249BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257212, XrefRangeEnd = 257216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x0024B9E4 File Offset: 0x00249BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257216, XrefRangeEnd = 257222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x0024BA18 File Offset: 0x00249C18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74374, RefRangeEnd = 74378, XrefRangeStart = 74374, XrefRangeEnd = 74378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeLidOverlaySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x0004380F File Offset: 0x00041A0F
		public EyeLidOverlaySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x06008CC0 RID: 36032 RVA: 0x0024BA54 File Offset: 0x00249C54
		// (set) Token: 0x06008CC1 RID: 36033 RVA: 0x00043818 File Offset: 0x00041A18
		public unsafe float OpenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride)) = value;
			}
		}

		// Token: 0x04005F5E RID: 24414
		private static readonly IntPtr NativeFieldInfoPtr_OpenOverride;

		// Token: 0x04005F5F RID: 24415
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005F60 RID: 24416
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04005F61 RID: 24417
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F62 RID: 24418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
