using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000465 RID: 1125
	public class PlaceholderBuilding : MonoBehaviour
	{
		// Token: 0x060061A2 RID: 24994 RVA: 0x001BD194 File Offset: 0x001BB394
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceholderBuilding()
		{
			Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlaceholderBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr);
			PlaceholderBuilding.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Name");
			PlaceholderBuilding.NativeFieldInfoPtr_Dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Dimensions");
			PlaceholderBuilding.NativeFieldInfoPtr_AutoGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "AutoGround");
			PlaceholderBuilding.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Model");
			PlaceholderBuilding.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Label");
			PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "lastFramePosition");
			PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675700);
			PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675701);
			PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675702);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x001BD278 File Offset: 0x001BB478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201148, XrefRangeEnd = 201156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x001BD2AC File Offset: 0x001BB4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201156, XrefRangeEnd = 201200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x001BD2E8 File Offset: 0x001BB4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201200, XrefRangeEnd = 201203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceholderBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x0002E28A File Offset: 0x0002C48A
		public PlaceholderBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x001BD324 File Offset: 0x001BB524
		// (set) Token: 0x060061A8 RID: 25000 RVA: 0x0002E293 File Offset: 0x0002C493
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x060061A9 RID: 25001 RVA: 0x001BD34C File Offset: 0x001BB54C
		// (set) Token: 0x060061AA RID: 25002 RVA: 0x0002E2B2 File Offset: 0x0002C4B2
		public unsafe Vector3 Dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions)) = value;
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x060061AB RID: 25003 RVA: 0x001BD374 File Offset: 0x001BB574
		// (set) Token: 0x060061AC RID: 25004 RVA: 0x0002E2CD File Offset: 0x0002C4CD
		public unsafe bool AutoGround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround)) = value;
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x060061AD RID: 25005 RVA: 0x001BD39C File Offset: 0x001BB59C
		// (set) Token: 0x060061AE RID: 25006 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x001BD3CC File Offset: 0x001BB5CC
		// (set) Token: 0x060061B0 RID: 25008 RVA: 0x0002E307 File Offset: 0x0002C507
		public unsafe TextMeshPro Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x001BD3FC File Offset: 0x001BB5FC
		// (set) Token: 0x060061B2 RID: 25010 RVA: 0x0002E326 File Offset: 0x0002C526
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x04004299 RID: 17049
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400429A RID: 17050
		private static readonly IntPtr NativeFieldInfoPtr_Dimensions;

		// Token: 0x0400429B RID: 17051
		private static readonly IntPtr NativeFieldInfoPtr_AutoGround;

		// Token: 0x0400429C RID: 17052
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x0400429D RID: 17053
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400429E RID: 17054
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x0400429F RID: 17055
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040042A0 RID: 17056
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040042A1 RID: 17057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
