using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000038 RID: 56
	public class FlockController : MonoBehaviour
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x0007D358 File Offset: 0x0007B558
		// Note: this type is marked as 'beforefieldinit'.
		static FlockController()
		{
			Il2CppClassPointerStore<FlockController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockController>.NativeClassPtr);
			FlockController.NativeFieldInfoPtr__childPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childPrefab");
			FlockController.NativeFieldInfoPtr__childAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childAmount");
			FlockController.NativeFieldInfoPtr__slowSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_slowSpawn");
			FlockController.NativeFieldInfoPtr__spawnSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphere");
			FlockController.NativeFieldInfoPtr__spawnSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereHeight");
			FlockController.NativeFieldInfoPtr__spawnSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_spawnSphereDepth");
			FlockController.NativeFieldInfoPtr__minSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minSpeed");
			FlockController.NativeFieldInfoPtr__maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxSpeed");
			FlockController.NativeFieldInfoPtr__minScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minScale");
			FlockController.NativeFieldInfoPtr__maxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxScale");
			FlockController.NativeFieldInfoPtr__soarFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarFrequency");
			FlockController.NativeFieldInfoPtr__soarAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarAnimation");
			FlockController.NativeFieldInfoPtr__flapAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flapAnimation");
			FlockController.NativeFieldInfoPtr__idleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_idleAnimation");
			FlockController.NativeFieldInfoPtr__diveValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveValue");
			FlockController.NativeFieldInfoPtr__diveFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_diveFrequency");
			FlockController.NativeFieldInfoPtr__minDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minDamping");
			FlockController.NativeFieldInfoPtr__maxDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxDamping");
			FlockController.NativeFieldInfoPtr__waypointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_waypointDistance");
			FlockController.NativeFieldInfoPtr__minAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_minAnimationSpeed");
			FlockController.NativeFieldInfoPtr__maxAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_maxAnimationSpeed");
			FlockController.NativeFieldInfoPtr__randomPositionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_randomPositionTimer");
			FlockController.NativeFieldInfoPtr__positionSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphere");
			FlockController.NativeFieldInfoPtr__positionSphereHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereHeight");
			FlockController.NativeFieldInfoPtr__positionSphereDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_positionSphereDepth");
			FlockController.NativeFieldInfoPtr__childTriggerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_childTriggerPos");
			FlockController.NativeFieldInfoPtr__forceChildWaypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forceChildWaypoints");
			FlockController.NativeFieldInfoPtr__forcedRandomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_forcedRandomDelay");
			FlockController.NativeFieldInfoPtr__flatFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatFly");
			FlockController.NativeFieldInfoPtr__flatSoar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_flatSoar");
			FlockController.NativeFieldInfoPtr__birdAvoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoid");
			FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidHorizontalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDown");
			FlockController.NativeFieldInfoPtr__birdAvoidUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidUp");
			FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidVerticalForce");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMax");
			FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_birdAvoidDistanceMin");
			FlockController.NativeFieldInfoPtr__soarMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_soarMaxTime");
			FlockController.NativeFieldInfoPtr__avoidanceMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_avoidanceMask");
			FlockController.NativeFieldInfoPtr__roamers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_roamers");
			FlockController.NativeFieldInfoPtr__posBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_posBuffer");
			FlockController.NativeFieldInfoPtr__updateDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateDivisor");
			FlockController.NativeFieldInfoPtr__newDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_newDelta");
			FlockController.NativeFieldInfoPtr__updateCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_updateCounter");
			FlockController.NativeFieldInfoPtr__activeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_activeChildren");
			FlockController.NativeFieldInfoPtr__groupChildToNewTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToNewTransform");
			FlockController.NativeFieldInfoPtr__groupTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupTransform");
			FlockController.NativeFieldInfoPtr__groupName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupName");
			FlockController.NativeFieldInfoPtr__groupChildToFlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_groupChildToFlock");
			FlockController.NativeFieldInfoPtr__startPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_startPosOffset");
			FlockController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockController>.NativeClassPtr, "_thisT");
			FlockController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663677);
			FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663678);
			FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663679);
			FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663680);
			FlockController.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663681);
			FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663682);
			FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663683);
			FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663684);
			FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663685);
			FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663686);
			FlockController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockController>.NativeClassPtr, 100663687);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0007D860 File Offset: 0x0007BA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74138, XrefRangeEnd = 74145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0007D894 File Offset: 0x0007BA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74182, RefRangeEnd = 74183, XrefRangeStart = 74145, XrefRangeEnd = 74182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0007D8D4 File Offset: 0x0007BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74183, XrefRangeEnd = 74184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildToParent(Transform obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0007D918 File Offset: 0x0007BB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74184, XrefRangeEnd = 74196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0007D958 File Offset: 0x0007BB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74196, XrefRangeEnd = 74212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0007D98C File Offset: 0x0007BB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74212, XrefRangeEnd = 74232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_InstantiateGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0007D9C0 File Offset: 0x0007BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74232, XrefRangeEnd = 74245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74245, XrefRangeEnd = 74262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0007DA28 File Offset: 0x0007BC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74276, RefRangeEnd = 74277, XrefRangeStart = 74262, XrefRangeEnd = 74276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlockRandomPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0007DA5C File Offset: 0x0007BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74277, XrefRangeEnd = 74289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void destroyBirds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr_destroyBirds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0007DA90 File Offset: 0x0007BC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74289, XrefRangeEnd = 74307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000047D6 File Offset: 0x000029D6
		public FlockController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0007DACC File Offset: 0x0007BCCC
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x000047DF File Offset: 0x000029DF
		public unsafe FlockChild _childPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0007DAFC File Offset: 0x0007BCFC
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x000047FE File Offset: 0x000029FE
		public unsafe int _childAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childAmount)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0007DB24 File Offset: 0x0007BD24
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00004819 File Offset: 0x00002A19
		public unsafe bool _slowSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__slowSpawn)) = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00004834 File Offset: 0x00002A34
		public unsafe float _spawnSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphere)) = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0007DB74 File Offset: 0x0007BD74
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000484F File Offset: 0x00002A4F
		public unsafe float _spawnSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereHeight)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0007DB9C File Offset: 0x0007BD9C
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x0000486A File Offset: 0x00002A6A
		public unsafe float _spawnSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__spawnSphereDepth)) = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00004885 File Offset: 0x00002A85
		public unsafe float _minSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minSpeed)) = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0007DBEC File Offset: 0x0007BDEC
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x000048A0 File Offset: 0x00002AA0
		public unsafe float _maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxSpeed)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0007DC14 File Offset: 0x0007BE14
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x000048BB File Offset: 0x00002ABB
		public unsafe float _minScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minScale)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0007DC3C File Offset: 0x0007BE3C
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000048D6 File Offset: 0x00002AD6
		public unsafe float _maxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxScale)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0007DC64 File Offset: 0x0007BE64
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000048F1 File Offset: 0x00002AF1
		public unsafe float _soarFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarFrequency)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0007DC8C File Offset: 0x0007BE8C
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000490C File Offset: 0x00002B0C
		public unsafe string _soarAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0007DCB4 File Offset: 0x0007BEB4
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x0000492B File Offset: 0x00002B2B
		public unsafe string _flapAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flapAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0007DCDC File Offset: 0x0007BEDC
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0000494A File Offset: 0x00002B4A
		public unsafe string _idleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__idleAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0007DD04 File Offset: 0x0007BF04
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00004969 File Offset: 0x00002B69
		public unsafe float _diveValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveValue)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0007DD2C File Offset: 0x0007BF2C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00004984 File Offset: 0x00002B84
		public unsafe float _diveFrequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__diveFrequency)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0007DD54 File Offset: 0x0007BF54
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0000499F File Offset: 0x00002B9F
		public unsafe float _minDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minDamping)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0007DD7C File Offset: 0x0007BF7C
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000049BA File Offset: 0x00002BBA
		public unsafe float _maxDamping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxDamping)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0007DDA4 File Offset: 0x0007BFA4
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000049D5 File Offset: 0x00002BD5
		public unsafe float _waypointDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__waypointDistance)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0007DDCC File Offset: 0x0007BFCC
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x000049F0 File Offset: 0x00002BF0
		public unsafe float _minAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__minAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0007DDF4 File Offset: 0x0007BFF4
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00004A0B File Offset: 0x00002C0B
		public unsafe float _maxAnimationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__maxAnimationSpeed)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x0007DE1C File Offset: 0x0007C01C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00004A26 File Offset: 0x00002C26
		public unsafe float _randomPositionTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__randomPositionTimer)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0007DE44 File Offset: 0x0007C044
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00004A41 File Offset: 0x00002C41
		public unsafe float _positionSphere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphere)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x0007DE6C File Offset: 0x0007C06C
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00004A5C File Offset: 0x00002C5C
		public unsafe float _positionSphereHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereHeight)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0007DE94 File Offset: 0x0007C094
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe float _positionSphereDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__positionSphereDepth)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0007DEBC File Offset: 0x0007C0BC
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00004A92 File Offset: 0x00002C92
		public unsafe bool _childTriggerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__childTriggerPos)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00004AAD File Offset: 0x00002CAD
		public unsafe bool _forceChildWaypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forceChildWaypoints)) = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0007DF0C File Offset: 0x0007C10C
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public unsafe float _forcedRandomDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__forcedRandomDelay)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0007DF34 File Offset: 0x0007C134
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00004AE3 File Offset: 0x00002CE3
		public unsafe bool _flatFly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatFly)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0007DF5C File Offset: 0x0007C15C
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00004AFE File Offset: 0x00002CFE
		public unsafe bool _flatSoar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__flatSoar)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0007DF84 File Offset: 0x0007C184
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00004B19 File Offset: 0x00002D19
		public unsafe bool _birdAvoid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoid)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00004B34 File Offset: 0x00002D34
		public unsafe int _birdAvoidHorizontalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidHorizontalForce)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00004B4F File Offset: 0x00002D4F
		public unsafe bool _birdAvoidDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDown)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0007DFFC File Offset: 0x0007C1FC
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004B6A File Offset: 0x00002D6A
		public unsafe bool _birdAvoidUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidUp)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0007E024 File Offset: 0x0007C224
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004B85 File Offset: 0x00002D85
		public unsafe int _birdAvoidVerticalForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidVerticalForce)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0007E04C File Offset: 0x0007C24C
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public unsafe float _birdAvoidDistanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMax)) = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0007E074 File Offset: 0x0007C274
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00004BBB File Offset: 0x00002DBB
		public unsafe float _birdAvoidDistanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__birdAvoidDistanceMin)) = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0007E09C File Offset: 0x0007C29C
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00004BD6 File Offset: 0x00002DD6
		public unsafe float _soarMaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__soarMaxTime)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00004BF1 File Offset: 0x00002DF1
		public unsafe LayerMask _avoidanceMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__avoidanceMask)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0007E0EC File Offset: 0x0007C2EC
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00004C0C File Offset: 0x00002E0C
		public unsafe List<FlockChild> _roamers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlockChild>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__roamers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0007E11C File Offset: 0x0007C31C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00004C2B File Offset: 0x00002E2B
		public unsafe Vector3 _posBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__posBuffer)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0007E144 File Offset: 0x0007C344
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00004C46 File Offset: 0x00002E46
		public unsafe int _updateDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateDivisor)) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0007E16C File Offset: 0x0007C36C
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00004C61 File Offset: 0x00002E61
		public unsafe float _newDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__newDelta)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0007E194 File Offset: 0x0007C394
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00004C7C File Offset: 0x00002E7C
		public unsafe int _updateCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__updateCounter)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0007E1BC File Offset: 0x0007C3BC
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004C97 File Offset: 0x00002E97
		public unsafe float _activeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__activeChildren)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0007E1E4 File Offset: 0x0007C3E4
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004CB2 File Offset: 0x00002EB2
		public unsafe bool _groupChildToNewTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToNewTransform)) = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0007E20C File Offset: 0x0007C40C
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004CCD File Offset: 0x00002ECD
		public unsafe Transform _groupTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0007E23C File Offset: 0x0007C43C
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00004CEC File Offset: 0x00002EEC
		public unsafe string _groupName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0007E264 File Offset: 0x0007C464
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00004D0B File Offset: 0x00002F0B
		public unsafe bool _groupChildToFlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__groupChildToFlock)) = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0007E28C File Offset: 0x0007C48C
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00004D26 File Offset: 0x00002F26
		public unsafe Vector3 _startPosOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__startPosOffset)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004D41 File Offset: 0x00002F41
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr__childPrefab;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr__childAmount;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr__slowSpawn;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphere;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereHeight;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr__spawnSphereDepth;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr__minSpeed;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr__maxSpeed;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr__minScale;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr__maxScale;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr__soarFrequency;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr__soarAnimation;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr__flapAnimation;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr__idleAnimation;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr__diveValue;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr__diveFrequency;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr__minDamping;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr__maxDamping;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr__waypointDistance;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr__minAnimationSpeed;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr__maxAnimationSpeed;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr__randomPositionTimer;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr__positionSphere;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereHeight;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr__positionSphereDepth;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr__childTriggerPos;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr__forceChildWaypoints;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr__forcedRandomDelay;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr__flatFly;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr__flatSoar;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoid;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidHorizontalForce;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDown;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidUp;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidVerticalForce;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMax;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr__birdAvoidDistanceMin;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr__soarMaxTime;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr__avoidanceMask;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr__roamers;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr__posBuffer;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr__updateDivisor;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr__newDelta;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr__updateCounter;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr__activeChildren;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToNewTransform;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeFieldInfoPtr__groupTransform;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeFieldInfoPtr__groupName;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeFieldInfoPtr__groupChildToFlock;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeFieldInfoPtr__startPosOffset;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_Int32_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_AddChildToParent_Public_Void_Transform_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Void_Int32_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGroup_Public_Void_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildAmount_Public_Void_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_SetFlockRandomPosition_Public_Void_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_destroyBirds_Public_Void_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
