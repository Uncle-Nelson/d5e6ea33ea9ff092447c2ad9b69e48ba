using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076E RID: 1902
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x0600B49F RID: 46239 RVA: 0x002CF768 File Offset: 0x002CD968
		// Note: this type is marked as 'beforefieldinit'.
		static TreeScaler()
		{
			Il2CppClassPointerStore<TreeScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "TreeScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr);
			TreeScaler.NativeFieldInfoPtr_branchMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "branchMeshes");
			TreeScaler.NativeFieldInfoPtr_minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScale");
			TreeScaler.NativeFieldInfoPtr_maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScale");
			TreeScaler.NativeFieldInfoPtr_minScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "minScaleDistance");
			TreeScaler.NativeFieldInfoPtr_maxScaleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, "maxScaleDistance");
			TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685525);
			TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685526);
			TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr, 100685527);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x002CF838 File Offset: 0x002CDA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309778, XrefRangeEnd = 309796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TreeScaler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x002CF874 File Offset: 0x002CDA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309796, XrefRangeEnd = 309825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr_UpdateScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x002CF8A8 File Offset: 0x002CDAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309825, XrefRangeEnd = 309833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TreeScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeScaler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x0005898B File Offset: 0x00056B8B
		public TreeScaler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x002CF8E4 File Offset: 0x002CDAE4
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x00058994 File Offset: 0x00056B94
		public unsafe List<Transform> branchMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_branchMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x002CF914 File Offset: 0x002CDB14
		// (set) Token: 0x0600B4A7 RID: 46247 RVA: 0x000589B3 File Offset: 0x00056BB3
		public unsafe float minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScale)) = value;
			}
		}

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x002CF93C File Offset: 0x002CDB3C
		// (set) Token: 0x0600B4A9 RID: 46249 RVA: 0x000589CE File Offset: 0x00056BCE
		public unsafe float maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScale)) = value;
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600B4AA RID: 46250 RVA: 0x002CF964 File Offset: 0x002CDB64
		// (set) Token: 0x0600B4AB RID: 46251 RVA: 0x000589E9 File Offset: 0x00056BE9
		public unsafe float minScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_minScaleDistance)) = value;
			}
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600B4AC RID: 46252 RVA: 0x002CF98C File Offset: 0x002CDB8C
		// (set) Token: 0x0600B4AD RID: 46253 RVA: 0x00058A04 File Offset: 0x00056C04
		public unsafe float maxScaleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeScaler.NativeFieldInfoPtr_maxScaleDistance)) = value;
			}
		}

		// Token: 0x040079C2 RID: 31170
		private static readonly IntPtr NativeFieldInfoPtr_branchMeshes;

		// Token: 0x040079C3 RID: 31171
		private static readonly IntPtr NativeFieldInfoPtr_minScale;

		// Token: 0x040079C4 RID: 31172
		private static readonly IntPtr NativeFieldInfoPtr_maxScale;

		// Token: 0x040079C5 RID: 31173
		private static readonly IntPtr NativeFieldInfoPtr_minScaleDistance;

		// Token: 0x040079C6 RID: 31174
		private static readonly IntPtr NativeFieldInfoPtr_maxScaleDistance;

		// Token: 0x040079C7 RID: 31175
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040079C8 RID: 31176
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScale_Private_Void_0;

		// Token: 0x040079C9 RID: 31177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
