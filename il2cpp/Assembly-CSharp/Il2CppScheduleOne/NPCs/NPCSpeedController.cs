using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DC RID: 732
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x060035FE RID: 13822 RVA: 0x0011E498 File Offset: 0x0011C698
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSpeedController()
		{
			Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr);
			NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "DefaultWalkSpeed");
			NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedMultiplier");
			NPCSpeedController.NativeFieldInfoPtr_Movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "Movement");
			NPCSpeedController.NativeFieldInfoPtr_speedControlStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "speedControlStack");
			NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "ActiveSpeedControl");
			NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669418);
			NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669419);
			NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669420);
			NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669421);
			NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669422);
			NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669423);
			NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669424);
			NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100669425);
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0011E5CC File Offset: 0x0011C7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138125, XrefRangeEnd = 138133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x0011E600 File Offset: 0x0011C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138133, XrefRangeEnd = 138147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x0011E634 File Offset: 0x0011C834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138147, XrefRangeEnd = 138151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x0011E674 File Offset: 0x0011C874
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 138174, RefRangeEnd = 138196, XrefRangeStart = 138151, XrefRangeEnd = 138174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x0011E6B8 File Offset: 0x0011C8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138196, XrefRangeEnd = 138211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x0011E708 File Offset: 0x0011C908
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 138225, RefRangeEnd = 138232, XrefRangeStart = 138211, XrefRangeEnd = 138225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesSpeedControlExist(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x0011E758 File Offset: 0x0011C958
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 138249, RefRangeEnd = 138266, XrefRangeStart = 138232, XrefRangeEnd = 138249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x0011E79C File Offset: 0x0011C99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138266, XrefRangeEnd = 138274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		public NPCSpeedController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x0011E7D8 File Offset: 0x0011C9D8
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x0001C5BD File Offset: 0x0001A7BD
		public unsafe float DefaultWalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_DefaultWalkSpeed)) = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x0011E800 File Offset: 0x0011CA00
		// (set) Token: 0x0600360B RID: 13835 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600360C RID: 13836 RVA: 0x0011E828 File Offset: 0x0011CA28
		// (set) Token: 0x0600360D RID: 13837 RVA: 0x0001C5F3 File Offset: 0x0001A7F3
		public unsafe NPCMovement Movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_Movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600360E RID: 13838 RVA: 0x0011E858 File Offset: 0x0011CA58
		// (set) Token: 0x0600360F RID: 13839 RVA: 0x0001C612 File Offset: 0x0001A812
		public unsafe List<NPCSpeedController.SpeedControl> speedControlStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCSpeedController.SpeedControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x0011E888 File Offset: 0x0011CA88
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x0001C631 File Offset: 0x0001A831
		public unsafe NPCSpeedController.SpeedControl ActiveSpeedControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_ActiveSpeedControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr_DefaultWalkSpeed;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr_Movement;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr_speedControlStack;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSpeedControl;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityControl_Private_SpeedControl_0;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000927 RID: 2343
		[Serializable]
		public class SpeedControl : Il2CppSystem.Object
		{
			// Token: 0x0600C692 RID: 50834 RVA: 0x003038B8 File Offset: 0x00301AB8
			// Note: this type is marked as 'beforefieldinit'.
			static SpeedControl()
			{
				Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedControl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr);
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "id");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "priority");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "speed");
				NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, 100669426);
			}

			// Token: 0x0600C693 RID: 50835 RVA: 0x00303934 File Offset: 0x00301B34
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 138074, RefRangeEnd = 138095, XrefRangeStart = 138072, XrefRangeEnd = 138074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpeedControl(string id, int priority, float speed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C694 RID: 50836 RVA: 0x00060A8F File Offset: 0x0005EC8F
			public SpeedControl(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DDF RID: 15839
			// (get) Token: 0x0600C695 RID: 50837 RVA: 0x0030399C File Offset: 0x00301B9C
			// (set) Token: 0x0600C696 RID: 50838 RVA: 0x00060A98 File Offset: 0x0005EC98
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DE0 RID: 15840
			// (get) Token: 0x0600C697 RID: 50839 RVA: 0x003039C4 File Offset: 0x00301BC4
			// (set) Token: 0x0600C698 RID: 50840 RVA: 0x00060AB7 File Offset: 0x0005ECB7
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x17003DE1 RID: 15841
			// (get) Token: 0x0600C699 RID: 50841 RVA: 0x003039EC File Offset: 0x00301BEC
			// (set) Token: 0x0600C69A RID: 50842 RVA: 0x00060AD2 File Offset: 0x0005ECD2
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x0400866E RID: 34414
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400866F RID: 34415
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x04008670 RID: 34416
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x04008671 RID: 34417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
		}

		// Token: 0x02000928 RID: 2344
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C69B RID: 50843 RVA: 0x00303A14 File Offset: 0x00301C14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669427);
				NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr, 100669428);
			}

			// Token: 0x0600C69C RID: 50844 RVA: 0x00303A7C File Offset: 0x00301C7C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C69D RID: 50845 RVA: 0x00303AB8 File Offset: 0x00301CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass10_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C69E RID: 50846 RVA: 0x00060AED File Offset: 0x0005ECED
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE2 RID: 15842
			// (get) Token: 0x0600C69F RID: 50847 RVA: 0x00303B08 File Offset: 0x00301D08
			// (set) Token: 0x0600C6A0 RID: 50848 RVA: 0x00060AF6 File Offset: 0x0005ECF6
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass10_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008672 RID: 34418
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008673 RID: 34419
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008674 RID: 34420
			private static readonly IntPtr NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000929 RID: 2345
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6A1 RID: 50849 RVA: 0x00303B30 File Offset: 0x00301D30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669429);
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100669430);
			}

			// Token: 0x0600C6A2 RID: 50850 RVA: 0x00303B98 File Offset: 0x00301D98
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6A3 RID: 50851 RVA: 0x00303BD4 File Offset: 0x00301DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6A4 RID: 50852 RVA: 0x00060B15 File Offset: 0x0005ED15
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE3 RID: 15843
			// (get) Token: 0x0600C6A5 RID: 50853 RVA: 0x00303C24 File Offset: 0x00301E24
			// (set) Token: 0x0600C6A6 RID: 50854 RVA: 0x00060B1E File Offset: 0x0005ED1E
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008675 RID: 34421
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008676 RID: 34422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008677 RID: 34423
			private static readonly IntPtr NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x0200092A RID: 2346
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C6A7 RID: 50855 RVA: 0x00303C4C File Offset: 0x00301E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, "control");
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669431);
				NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr, 100669432);
			}

			// Token: 0x0600C6A8 RID: 50856 RVA: 0x00303CB4 File Offset: 0x00301EB4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6A9 RID: 50857 RVA: 0x00303CF0 File Offset: 0x00301EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138095, XrefRangeEnd = 138125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass9_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C6AA RID: 50858 RVA: 0x00060B3D File Offset: 0x0005ED3D
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE4 RID: 15844
			// (get) Token: 0x0600C6AB RID: 50859 RVA: 0x00303D40 File Offset: 0x00301F40
			// (set) Token: 0x0600C6AC RID: 50860 RVA: 0x00060B46 File Offset: 0x0005ED46
			public unsafe NPCSpeedController.SpeedControl control
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass9_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008678 RID: 34424
			private static readonly IntPtr NativeFieldInfoPtr_control;

			// Token: 0x04008679 RID: 34425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400867A RID: 34426
			private static readonly IntPtr NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}
	}
}
