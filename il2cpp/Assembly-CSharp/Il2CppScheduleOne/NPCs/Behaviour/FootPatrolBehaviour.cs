using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000359 RID: 857
	public class FootPatrolBehaviour : Behaviour
	{
		// Token: 0x060041CD RID: 16845 RVA: 0x0014979C File Offset: 0x0014799C
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolBehaviour()
		{
			Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr);
			FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "MOVE_SPEED");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MIN_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MAX_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_ASSET_PATH");
			FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "UseFlashlight");
			FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "flashlightEquipped");
			FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "<Group>k__BackingField");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671305);
			FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671306);
			FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671307);
			FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671308);
			FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671309);
			FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671310);
			FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671311);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671312);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671313);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671314);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671315);
			FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671316);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671317);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671318);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671319);
			FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671320);
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060041CE RID: 16846 RVA: 0x001499C0 File Offset: 0x00147BC0
		// (set) Token: 0x060041CF RID: 16847 RVA: 0x00149A00 File Offset: 0x00147C00
		public unsafe PatrolGroup Group
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115214, RefRangeEnd = 115215, XrefRangeStart = 115214, XrefRangeEnd = 115215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x00149A44 File Offset: 0x00147C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151808, XrefRangeEnd = 151827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x00149A80 File Offset: 0x00147C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151827, XrefRangeEnd = 151846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x00149ABC File Offset: 0x00147CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151846, XrefRangeEnd = 151859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x00149AF8 File Offset: 0x00147CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151859, XrefRangeEnd = 151876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x00149B34 File Offset: 0x00147D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151876, XrefRangeEnd = 151942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x00149B70 File Offset: 0x00147D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151942, XrefRangeEnd = 151950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x00149BB0 File Offset: 0x00147DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151958, RefRangeEnd = 151959, XrefRangeStart = 151950, XrefRangeEnd = 151958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGroup(PatrolGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041D7 RID: 16855 RVA: 0x00149BF4 File Offset: 0x00147DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151974, RefRangeEnd = 151975, XrefRangeStart = 151959, XrefRangeEnd = 151974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041D8 RID: 16856 RVA: 0x00149C30 File Offset: 0x00147E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151975, XrefRangeEnd = 151984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00149C6C File Offset: 0x00147E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151984, XrefRangeEnd = 151985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x00149CA8 File Offset: 0x00147EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151985, XrefRangeEnd = 151986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00149CE4 File Offset: 0x00147EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151986, XrefRangeEnd = 151987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00149D20 File Offset: 0x00147F20
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00149D5C File Offset: 0x00147F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00020595 File Offset: 0x0001E795
		public FootPatrolBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x00149D98 File Offset: 0x00147F98
		// (set) Token: 0x060041E0 RID: 16864 RVA: 0x0002059E File Offset: 0x0001E79E
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00149DB4 File Offset: 0x00147FB4
		// (set) Token: 0x060041E2 RID: 16866 RVA: 0x000205AC File Offset: 0x0001E7AC
		public unsafe static int FLASHLIGHT_MIN_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x00149DD0 File Offset: 0x00147FD0
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x000205BA File Offset: 0x0001E7BA
		public unsafe int FLASHLIGHT_MAX_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME)) = value;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00149DF8 File Offset: 0x00147FF8
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x000205D5 File Offset: 0x0001E7D5
		public unsafe static string FLASHLIGHT_ASSET_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00149E18 File Offset: 0x00148018
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x000205E7 File Offset: 0x0001E7E7
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00149E40 File Offset: 0x00148040
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x00020602 File Offset: 0x0001E802
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x00149E68 File Offset: 0x00148068
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x0002061D File Offset: 0x0001E81D
		public unsafe PatrolGroup _Group_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x00149E98 File Offset: 0x00148098
		// (set) Token: 0x060041EE RID: 16878 RVA: 0x0002063C File Offset: 0x0001E83C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x00149EC0 File Offset: 0x001480C0
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x00020657 File Offset: 0x0001E857
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeFieldInfoPtr__Group_k__BackingField;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
