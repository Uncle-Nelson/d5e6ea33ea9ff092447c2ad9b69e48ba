using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073E RID: 1854
	public class Beaker : StationItem
	{
		// Token: 0x0600AB08 RID: 43784 RVA: 0x002AB778 File Offset: 0x002A9978
		// Note: this type is marked as 'beforefieldinit'.
		static Beaker()
		{
			Il2CppClassPointerStore<Beaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Beaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Beaker>.NativeClassPtr);
			Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MaxLiquid");
			Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MinLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MaxLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MinLiquid");
			Beaker.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Draggable");
			Beaker.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Constraint");
			Beaker.NativeFieldInfoPtr_ConcaveCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConcaveCollider");
			Beaker.NativeFieldInfoPtr_ConvexCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConvexCollider");
			Beaker.NativeFieldInfoPtr_CenterOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "CenterOfMass");
			Beaker.NativeFieldInfoPtr_Joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Joint");
			Beaker.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Anchor");
			Beaker.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Container");
			Beaker.NativeFieldInfoPtr_Fillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Fillable");
			Beaker.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Pourable");
			Beaker.NativeFieldInfoPtr_FilterPaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "FilterPaper");
			Beaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684296);
			Beaker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684297);
			Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684298);
			Beaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684299);
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x002AB924 File Offset: 0x002A9B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297311, XrefRangeEnd = 297316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x002AB958 File Offset: 0x002A9B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297316, XrefRangeEnd = 297321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x002AB98C File Offset: 0x002A9B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297325, RefRangeEnd = 297326, XrefRangeStart = 297321, XrefRangeEnd = 297325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x002AB9CC File Offset: 0x002A9BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297326, XrefRangeEnd = 297327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Beaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x000541EA File Offset: 0x000523EA
		public Beaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x002ABA08 File Offset: 0x002A9C08
		// (set) Token: 0x0600AB0F RID: 43791 RVA: 0x000541F3 File Offset: 0x000523F3
		public unsafe float ClampAngle_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid)) = value;
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x002ABA30 File Offset: 0x002A9C30
		// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x0005420E File Offset: 0x0005240E
		public unsafe float ClampAngle_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid)) = value;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x002ABA58 File Offset: 0x002A9C58
		// (set) Token: 0x0600AB13 RID: 43795 RVA: 0x00054229 File Offset: 0x00052429
		public unsafe float AngleToPour_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid)) = value;
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600AB14 RID: 43796 RVA: 0x002ABA80 File Offset: 0x002A9C80
		// (set) Token: 0x0600AB15 RID: 43797 RVA: 0x00054244 File Offset: 0x00052444
		public unsafe float AngleToPour_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid)) = value;
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600AB16 RID: 43798 RVA: 0x002ABAA8 File Offset: 0x002A9CA8
		// (set) Token: 0x0600AB17 RID: 43799 RVA: 0x0005425F File Offset: 0x0005245F
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x002ABAD8 File Offset: 0x002A9CD8
		// (set) Token: 0x0600AB19 RID: 43801 RVA: 0x0005427E File Offset: 0x0005247E
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600AB1A RID: 43802 RVA: 0x002ABB08 File Offset: 0x002A9D08
		// (set) Token: 0x0600AB1B RID: 43803 RVA: 0x0005429D File Offset: 0x0005249D
		public unsafe Collider ConcaveCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600AB1C RID: 43804 RVA: 0x002ABB38 File Offset: 0x002A9D38
		// (set) Token: 0x0600AB1D RID: 43805 RVA: 0x000542BC File Offset: 0x000524BC
		public unsafe Collider ConvexCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600AB1E RID: 43806 RVA: 0x002ABB68 File Offset: 0x002A9D68
		// (set) Token: 0x0600AB1F RID: 43807 RVA: 0x000542DB File Offset: 0x000524DB
		public unsafe Transform CenterOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x0600AB20 RID: 43808 RVA: 0x002ABB98 File Offset: 0x002A9D98
		// (set) Token: 0x0600AB21 RID: 43809 RVA: 0x000542FA File Offset: 0x000524FA
		public unsafe ConfigurableJoint Joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x0600AB22 RID: 43810 RVA: 0x002ABBC8 File Offset: 0x002A9DC8
		// (set) Token: 0x0600AB23 RID: 43811 RVA: 0x00054319 File Offset: 0x00052519
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x002ABBF8 File Offset: 0x002A9DF8
		// (set) Token: 0x0600AB25 RID: 43813 RVA: 0x00054338 File Offset: 0x00052538
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x0600AB26 RID: 43814 RVA: 0x002ABC28 File Offset: 0x002A9E28
		// (set) Token: 0x0600AB27 RID: 43815 RVA: 0x00054357 File Offset: 0x00052557
		public unsafe Fillable Fillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0600AB28 RID: 43816 RVA: 0x002ABC58 File Offset: 0x002A9E58
		// (set) Token: 0x0600AB29 RID: 43817 RVA: 0x00054376 File Offset: 0x00052576
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F1 RID: 13553
		// (get) Token: 0x0600AB2A RID: 43818 RVA: 0x002ABC88 File Offset: 0x002A9E88
		// (set) Token: 0x0600AB2B RID: 43819 RVA: 0x00054395 File Offset: 0x00052595
		public unsafe GameObject FilterPaper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072EE RID: 29422
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MaxLiquid;

		// Token: 0x040072EF RID: 29423
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MinLiquid;

		// Token: 0x040072F0 RID: 29424
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MaxLiquid;

		// Token: 0x040072F1 RID: 29425
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MinLiquid;

		// Token: 0x040072F2 RID: 29426
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040072F3 RID: 29427
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x040072F4 RID: 29428
		private static readonly IntPtr NativeFieldInfoPtr_ConcaveCollider;

		// Token: 0x040072F5 RID: 29429
		private static readonly IntPtr NativeFieldInfoPtr_ConvexCollider;

		// Token: 0x040072F6 RID: 29430
		private static readonly IntPtr NativeFieldInfoPtr_CenterOfMass;

		// Token: 0x040072F7 RID: 29431
		private static readonly IntPtr NativeFieldInfoPtr_Joint;

		// Token: 0x040072F8 RID: 29432
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x040072F9 RID: 29433
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040072FA RID: 29434
		private static readonly IntPtr NativeFieldInfoPtr_Fillable;

		// Token: 0x040072FB RID: 29435
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x040072FC RID: 29436
		private static readonly IntPtr NativeFieldInfoPtr_FilterPaper;

		// Token: 0x040072FD RID: 29437
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040072FE RID: 29438
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040072FF RID: 29439
		private static readonly IntPtr NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0;

		// Token: 0x04007300 RID: 29440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
