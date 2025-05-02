using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000552 RID: 1362
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x0600780E RID: 30734 RVA: 0x00207EC4 File Offset: 0x002060C4
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothRotate()
		{
			Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr);
			SmoothRotate.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Active");
			SmoothRotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Speed");
			SmoothRotate.NativeFieldInfoPtr_Aceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Aceleration");
			SmoothRotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Axis");
			SmoothRotate.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "currentSpeed");
			SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678396);
			SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678397);
			SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678398);
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00207F94 File Offset: 0x00206194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232468, XrefRangeEnd = 232475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00207FC8 File Offset: 0x002061C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00208008 File Offset: 0x00206208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232475, XrefRangeEnd = 232478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00038E2F File Offset: 0x0003702F
		public SmoothRotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x00208044 File Offset: 0x00206244
		// (set) Token: 0x06007814 RID: 30740 RVA: 0x00038E38 File Offset: 0x00037038
		public unsafe bool Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active)) = value;
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x0020806C File Offset: 0x0020626C
		// (set) Token: 0x06007816 RID: 30742 RVA: 0x00038E53 File Offset: 0x00037053
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x00208094 File Offset: 0x00206294
		// (set) Token: 0x06007818 RID: 30744 RVA: 0x00038E6E File Offset: 0x0003706E
		public unsafe float Aceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration)) = value;
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x002080BC File Offset: 0x002062BC
		// (set) Token: 0x0600781A RID: 30746 RVA: 0x00038E89 File Offset: 0x00037089
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600781B RID: 30747 RVA: 0x002080E4 File Offset: 0x002062E4
		// (set) Token: 0x0600781C RID: 30748 RVA: 0x00038EA4 File Offset: 0x000370A4
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x040051DD RID: 20957
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x040051DE RID: 20958
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040051DF RID: 20959
		private static readonly IntPtr NativeFieldInfoPtr_Aceleration;

		// Token: 0x040051E0 RID: 20960
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040051E1 RID: 20961
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x040051E2 RID: 20962
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040051E3 RID: 20963
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040051E4 RID: 20964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
