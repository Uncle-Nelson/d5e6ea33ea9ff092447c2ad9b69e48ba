using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052B RID: 1323
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x06007643 RID: 30275 RVA: 0x00202BCC File Offset: 0x00200DCC
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveInRange()
		{
			Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveInRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr);
			ActiveInRange.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Distance");
			ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ScaleByLODBias");
			ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ObjectsToActivate");
			ActiveInRange.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Reverse");
			ActiveInRange.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "isVisible");
			ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678198);
			ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678199);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00202C88 File Offset: 0x00200E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230895, XrefRangeEnd = 230917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00202CBC File Offset: 0x00200EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230917, XrefRangeEnd = 230918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveInRange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00038089 File Offset: 0x00036289
		public ActiveInRange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06007647 RID: 30279 RVA: 0x00202CF8 File Offset: 0x00200EF8
		// (set) Token: 0x06007648 RID: 30280 RVA: 0x00038092 File Offset: 0x00036292
		public unsafe float Distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance)) = value;
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x06007649 RID: 30281 RVA: 0x00202D20 File Offset: 0x00200F20
		// (set) Token: 0x0600764A RID: 30282 RVA: 0x000380AD File Offset: 0x000362AD
		public unsafe bool ScaleByLODBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias)) = value;
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x00202D48 File Offset: 0x00200F48
		// (set) Token: 0x0600764C RID: 30284 RVA: 0x000380C8 File Offset: 0x000362C8
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600764D RID: 30285 RVA: 0x00202D78 File Offset: 0x00200F78
		// (set) Token: 0x0600764E RID: 30286 RVA: 0x000380E7 File Offset: 0x000362E7
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x00202DA0 File Offset: 0x00200FA0
		// (set) Token: 0x06007650 RID: 30288 RVA: 0x00038102 File Offset: 0x00036302
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x040050D0 RID: 20688
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x040050D1 RID: 20689
		private static readonly IntPtr NativeFieldInfoPtr_ScaleByLODBias;

		// Token: 0x040050D2 RID: 20690
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x040050D3 RID: 20691
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x040050D4 RID: 20692
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x040050D5 RID: 20693
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040050D6 RID: 20694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
