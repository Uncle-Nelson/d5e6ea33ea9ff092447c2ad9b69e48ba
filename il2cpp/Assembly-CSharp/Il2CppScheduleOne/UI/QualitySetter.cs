using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000623 RID: 1571
	public class QualitySetter : MonoBehaviour
	{
		// Token: 0x06008A85 RID: 35461 RVA: 0x00244D38 File Offset: 0x00242F38
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySetter()
		{
			Il2CppClassPointerStore<QualitySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "QualitySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr);
			QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680505);
			QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680506);
			QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680507);
			QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680508);
		}

		// Token: 0x06008A86 RID: 35462 RVA: 0x00244DB8 File Offset: 0x00242FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254487, XrefRangeEnd = 254500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A87 RID: 35463 RVA: 0x00244DEC File Offset: 0x00242FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254500, XrefRangeEnd = 254509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A88 RID: 35464 RVA: 0x00244E2C File Offset: 0x0024302C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualitySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x00244E68 File Offset: 0x00243068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254509, XrefRangeEnd = 254518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__0_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A8A RID: 35466 RVA: 0x0004244A File Offset: 0x0004064A
		public QualitySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DF8 RID: 24056
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005DF9 RID: 24057
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0;

		// Token: 0x04005DFA RID: 24058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005DFB RID: 24059
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0;
	}
}
