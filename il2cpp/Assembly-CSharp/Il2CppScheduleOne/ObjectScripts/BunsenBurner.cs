using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073F RID: 1855
	public class BunsenBurner : MonoBehaviour
	{
		// Token: 0x0600AB2C RID: 43820 RVA: 0x002ABCB8 File Offset: 0x002A9EB8
		// Note: this type is marked as 'beforefieldinit'.
		static BunsenBurner()
		{
			Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BunsenBurner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr);
			BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<Interactable>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<IsDialHeld>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentDialValue>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "<CurrentHeat>k__BackingField");
			BunsenBurner.NativeFieldInfoPtr_LockDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LockDial");
			BunsenBurner.NativeFieldInfoPtr_FlameColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameColor");
			BunsenBurner.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "LightIntensity");
			BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleRotationSpeed");
			BunsenBurner.NativeFieldInfoPtr_FlamePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlamePitch");
			BunsenBurner.NativeFieldInfoPtr_Flame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Flame");
			BunsenBurner.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Light");
			BunsenBurner.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle");
			BunsenBurner.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "HandleClickable");
			BunsenBurner.NativeFieldInfoPtr_Handle_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Min");
			BunsenBurner.NativeFieldInfoPtr_Handle_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Handle_Max");
			BunsenBurner.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Highlight");
			BunsenBurner.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "Anim");
			BunsenBurner.NativeFieldInfoPtr_FlameSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, "FlameSound");
			BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684300);
			BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684301);
			BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684302);
			BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684303);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684304);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684305);
			BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684306);
			BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684307);
			BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684308);
			BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684309);
			BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684310);
			BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684311);
			BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684312);
			BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684313);
			BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684314);
			BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr, 100684315);
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x002ABF90 File Offset: 0x002AA190
		// (set) Token: 0x0600AB2E RID: 43822 RVA: 0x002ABFCC File Offset: 0x002AA1CC
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x002AC00C File Offset: 0x002AA20C
		// (set) Token: 0x0600AB30 RID: 43824 RVA: 0x002AC048 File Offset: 0x002AA248
		public unsafe bool IsDialHeld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600AB31 RID: 43825 RVA: 0x002AC088 File Offset: 0x002AA288
		// (set) Token: 0x0600AB32 RID: 43826 RVA: 0x002AC0C4 File Offset: 0x002AA2C4
		public unsafe float CurrentDialValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x002AC104 File Offset: 0x002AA304
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x002AC140 File Offset: 0x002AA340
		public unsafe float CurrentHeat
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x002AC180 File Offset: 0x002AA380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297327, XrefRangeEnd = 297347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x002AC1B4 File Offset: 0x002AA3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297347, XrefRangeEnd = 297365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x002AC1E8 File Offset: 0x002AA3E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297380, RefRangeEnd = 297381, XrefRangeStart = 297365, XrefRangeEnd = 297380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_UpdateEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x002AC21C File Offset: 0x002AA41C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297386, RefRangeEnd = 297390, XrefRangeStart = 297381, XrefRangeEnd = 297386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDialPosition(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x002AC25C File Offset: 0x002AA45C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297393, RefRangeEnd = 297396, XrefRangeStart = 297390, XrefRangeEnd = 297393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB3A RID: 43834 RVA: 0x002AC29C File Offset: 0x002AA49C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217117, RefRangeEnd = 217121, XrefRangeStart = 217117, XrefRangeEnd = 217121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x002AC2DC File Offset: 0x002AA4DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217121, RefRangeEnd = 217123, XrefRangeStart = 217121, XrefRangeEnd = 217123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x002AC310 File Offset: 0x002AA510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297396, XrefRangeEnd = 297397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunsenBurner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunsenBurner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunsenBurner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x000543B4 File Offset: 0x000525B4
		public BunsenBurner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600AB3E RID: 43838 RVA: 0x002AC34C File Offset: 0x002AA54C
		// (set) Token: 0x0600AB3F RID: 43839 RVA: 0x000543BD File Offset: 0x000525BD
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600AB40 RID: 43840 RVA: 0x002AC374 File Offset: 0x002AA574
		// (set) Token: 0x0600AB41 RID: 43841 RVA: 0x000543D8 File Offset: 0x000525D8
		public unsafe bool _IsDialHeld_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__IsDialHeld_k__BackingField)) = value;
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600AB42 RID: 43842 RVA: 0x002AC39C File Offset: 0x002AA59C
		// (set) Token: 0x0600AB43 RID: 43843 RVA: 0x000543F3 File Offset: 0x000525F3
		public unsafe float _CurrentDialValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentDialValue_k__BackingField)) = value;
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002AC3C4 File Offset: 0x002AA5C4
		// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x0005440E File Offset: 0x0005260E
		public unsafe float _CurrentHeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr__CurrentHeat_k__BackingField)) = value;
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600AB46 RID: 43846 RVA: 0x002AC3EC File Offset: 0x002AA5EC
		// (set) Token: 0x0600AB47 RID: 43847 RVA: 0x00054429 File Offset: 0x00052629
		public unsafe bool LockDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LockDial)) = value;
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600AB48 RID: 43848 RVA: 0x002AC414 File Offset: 0x002AA614
		// (set) Token: 0x0600AB49 RID: 43849 RVA: 0x00054444 File Offset: 0x00052644
		public unsafe Gradient FlameColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600AB4A RID: 43850 RVA: 0x002AC444 File Offset: 0x002AA644
		// (set) Token: 0x0600AB4B RID: 43851 RVA: 0x00054463 File Offset: 0x00052663
		public unsafe AnimationCurve LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_LightIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F9 RID: 13561
		// (get) Token: 0x0600AB4C RID: 43852 RVA: 0x002AC474 File Offset: 0x002AA674
		// (set) Token: 0x0600AB4D RID: 43853 RVA: 0x00054482 File Offset: 0x00052682
		public unsafe float HandleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleRotationSpeed)) = value;
			}
		}

		// Token: 0x170034FA RID: 13562
		// (get) Token: 0x0600AB4E RID: 43854 RVA: 0x002AC49C File Offset: 0x002AA69C
		// (set) Token: 0x0600AB4F RID: 43855 RVA: 0x0005449D File Offset: 0x0005269D
		public unsafe AnimationCurve FlamePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlamePitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600AB50 RID: 43856 RVA: 0x002AC4CC File Offset: 0x002AA6CC
		// (set) Token: 0x0600AB51 RID: 43857 RVA: 0x000544BC File Offset: 0x000526BC
		public unsafe ParticleSystem Flame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Flame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x002AC4FC File Offset: 0x002AA6FC
		// (set) Token: 0x0600AB53 RID: 43859 RVA: 0x000544DB File Offset: 0x000526DB
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x002AC52C File Offset: 0x002AA72C
		// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x000544FA File Offset: 0x000526FA
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x002AC55C File Offset: 0x002AA75C
		// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x00054519 File Offset: 0x00052719
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x002AC58C File Offset: 0x002AA78C
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x00054538 File Offset: 0x00052738
		public unsafe Transform Handle_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x002AC5BC File Offset: 0x002AA7BC
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x00054557 File Offset: 0x00052757
		public unsafe Transform Handle_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Handle_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x002AC5EC File Offset: 0x002AA7EC
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x00054576 File Offset: 0x00052776
		public unsafe Transform Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x002AC61C File Offset: 0x002AA81C
		// (set) Token: 0x0600AB5F RID: 43871 RVA: 0x00054595 File Offset: 0x00052795
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600AB60 RID: 43872 RVA: 0x002AC64C File Offset: 0x002AA84C
		// (set) Token: 0x0600AB61 RID: 43873 RVA: 0x000545B4 File Offset: 0x000527B4
		public unsafe AudioSourceController FlameSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunsenBurner.NativeFieldInfoPtr_FlameSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007301 RID: 29441
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x04007302 RID: 29442
		private static readonly IntPtr NativeFieldInfoPtr__IsDialHeld_k__BackingField;

		// Token: 0x04007303 RID: 29443
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDialValue_k__BackingField;

		// Token: 0x04007304 RID: 29444
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHeat_k__BackingField;

		// Token: 0x04007305 RID: 29445
		private static readonly IntPtr NativeFieldInfoPtr_LockDial;

		// Token: 0x04007306 RID: 29446
		private static readonly IntPtr NativeFieldInfoPtr_FlameColor;

		// Token: 0x04007307 RID: 29447
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x04007308 RID: 29448
		private static readonly IntPtr NativeFieldInfoPtr_HandleRotationSpeed;

		// Token: 0x04007309 RID: 29449
		private static readonly IntPtr NativeFieldInfoPtr_FlamePitch;

		// Token: 0x0400730A RID: 29450
		private static readonly IntPtr NativeFieldInfoPtr_Flame;

		// Token: 0x0400730B RID: 29451
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x0400730C RID: 29452
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x0400730D RID: 29453
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x0400730E RID: 29454
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Min;

		// Token: 0x0400730F RID: 29455
		private static readonly IntPtr NativeFieldInfoPtr_Handle_Max;

		// Token: 0x04007310 RID: 29456
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x04007311 RID: 29457
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04007312 RID: 29458
		private static readonly IntPtr NativeFieldInfoPtr_FlameSound;

		// Token: 0x04007313 RID: 29459
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04007314 RID: 29460
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x04007315 RID: 29461
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDialHeld_Public_get_Boolean_0;

		// Token: 0x04007316 RID: 29462
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDialHeld_Private_set_Void_Boolean_0;

		// Token: 0x04007317 RID: 29463
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDialValue_Public_get_Single_0;

		// Token: 0x04007318 RID: 29464
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDialValue_Private_set_Void_Single_0;

		// Token: 0x04007319 RID: 29465
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHeat_Public_get_Single_0;

		// Token: 0x0400731A RID: 29466
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHeat_Private_set_Void_Single_0;

		// Token: 0x0400731B RID: 29467
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400731C RID: 29468
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400731D RID: 29469
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEffects_Private_Void_0;

		// Token: 0x0400731E RID: 29470
		private static readonly IntPtr NativeMethodInfoPtr_SetDialPosition_Public_Void_Single_0;

		// Token: 0x0400731F RID: 29471
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007320 RID: 29472
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007321 RID: 29473
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007322 RID: 29474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
