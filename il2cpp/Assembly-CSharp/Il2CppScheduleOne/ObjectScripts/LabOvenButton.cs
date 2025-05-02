using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000747 RID: 1863
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x0600AE9D RID: 44701 RVA: 0x002B9764 File Offset: 0x002B7964
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenButton()
		{
			Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr);
			LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<Pressed>k__BackingField");
			LabOvenButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Button");
			LabOvenButton.NativeFieldInfoPtr_PressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "PressedTransform");
			LabOvenButton.NativeFieldInfoPtr_DepressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "DepressedTransform");
			LabOvenButton.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Light");
			LabOvenButton.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Clickable");
			LabOvenButton.NativeFieldInfoPtr_pressCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "pressCoroutine");
			LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684775);
			LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684776);
			LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684777);
			LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684778);
			LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684779);
			LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684780);
			LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684781);
			LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100684782);
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600AE9E RID: 44702 RVA: 0x002B98C0 File Offset: 0x002B7AC0
		// (set) Token: 0x0600AE9F RID: 44703 RVA: 0x002B98FC File Offset: 0x002B7AFC
		public unsafe bool Pressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AEA0 RID: 44704 RVA: 0x002B993C File Offset: 0x002B7B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302529, XrefRangeEnd = 302539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA1 RID: 44705 RVA: 0x002B9970 File Offset: 0x002B7B70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302539, RefRangeEnd = 302544, XrefRangeStart = 302539, XrefRangeEnd = 302539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA2 RID: 44706 RVA: 0x002B99B0 File Offset: 0x002B7BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302544, XrefRangeEnd = 302545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA3 RID: 44707 RVA: 0x002B99F0 File Offset: 0x002B7BF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302552, RefRangeEnd = 302556, XrefRangeStart = 302545, XrefRangeEnd = 302552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPressed(bool pressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA4 RID: 44708 RVA: 0x002B9A30 File Offset: 0x002B7C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302562, RefRangeEnd = 302563, XrefRangeStart = 302556, XrefRangeEnd = 302562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveButton(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600AEA5 RID: 44709 RVA: 0x002B9A80 File Offset: 0x002B7C80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEA6 RID: 44710 RVA: 0x00055C81 File Offset: 0x00053E81
		public LabOvenButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x002B9ABC File Offset: 0x002B7CBC
		// (set) Token: 0x0600AEA8 RID: 44712 RVA: 0x00055C8A File Offset: 0x00053E8A
		public unsafe bool _Pressed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x002B9AE4 File Offset: 0x002B7CE4
		// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x00055CA5 File Offset: 0x00053EA5
		public unsafe Transform Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x002B9B14 File Offset: 0x002B7D14
		// (set) Token: 0x0600AEAC RID: 44716 RVA: 0x00055CC4 File Offset: 0x00053EC4
		public unsafe Transform PressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x002B9B44 File Offset: 0x002B7D44
		// (set) Token: 0x0600AEAE RID: 44718 RVA: 0x00055CE3 File Offset: 0x00053EE3
		public unsafe Transform DepressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x002B9B74 File Offset: 0x002B7D74
		// (set) Token: 0x0600AEB0 RID: 44720 RVA: 0x00055D02 File Offset: 0x00053F02
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x002B9BA4 File Offset: 0x002B7DA4
		// (set) Token: 0x0600AEB2 RID: 44722 RVA: 0x00055D21 File Offset: 0x00053F21
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x002B9BD4 File Offset: 0x002B7DD4
		// (set) Token: 0x0600AEB4 RID: 44724 RVA: 0x00055D40 File Offset: 0x00053F40
		public unsafe Coroutine pressCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_pressCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400758E RID: 30094
		private static readonly IntPtr NativeFieldInfoPtr__Pressed_k__BackingField;

		// Token: 0x0400758F RID: 30095
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007590 RID: 30096
		private static readonly IntPtr NativeFieldInfoPtr_PressedTransform;

		// Token: 0x04007591 RID: 30097
		private static readonly IntPtr NativeFieldInfoPtr_DepressedTransform;

		// Token: 0x04007592 RID: 30098
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007593 RID: 30099
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04007594 RID: 30100
		private static readonly IntPtr NativeFieldInfoPtr_pressCoroutine;

		// Token: 0x04007595 RID: 30101
		private static readonly IntPtr NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0;

		// Token: 0x04007596 RID: 30102
		private static readonly IntPtr NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0;

		// Token: 0x04007597 RID: 30103
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007598 RID: 30104
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007599 RID: 30105
		private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0;

		// Token: 0x0400759A RID: 30106
		private static readonly IntPtr NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0;

		// Token: 0x0400759B RID: 30107
		private static readonly IntPtr NativeMethodInfoPtr_MoveButton_Private_IEnumerator_Transform_0;

		// Token: 0x0400759C RID: 30108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BEF RID: 3055
		[ObfuscatedName("ScheduleOne.ObjectScripts.LabOvenButton+<MoveButton>d__14")]
		public sealed class _MoveButton_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600DF56 RID: 57174 RVA: 0x0034A3FC File Offset: 0x003485FC
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveButton_d__14()
			{
				Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<MoveButton>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr);
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>1__state");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>2__current");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<>4__this");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "destination");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<startPos>5__2");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<endPos>5__3");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<lerpTime>5__4");
				LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, "<t>5__5");
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684783);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684784);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684785);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684786);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684787);
				LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr, 100684788);
			}

			// Token: 0x0600DF57 RID: 57175 RVA: 0x0034A540 File Offset: 0x00348740
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveButton_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton._MoveButton_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF58 RID: 57176 RVA: 0x0034A588 File Offset: 0x00348788
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF59 RID: 57177 RVA: 0x0034A5BC File Offset: 0x003487BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302517, XrefRangeEnd = 302524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700453C RID: 17724
			// (get) Token: 0x0600DF5A RID: 57178 RVA: 0x0034A5F8 File Offset: 0x003487F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF5B RID: 57179 RVA: 0x0034A638 File Offset: 0x00348838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302524, XrefRangeEnd = 302529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700453D RID: 17725
			// (get) Token: 0x0600DF5C RID: 57180 RVA: 0x0034A66C File Offset: 0x0034886C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton._MoveButton_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF5D RID: 57181 RVA: 0x0006CE28 File Offset: 0x0006B028
			public _MoveButton_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004534 RID: 17716
			// (get) Token: 0x0600DF5E RID: 57182 RVA: 0x0034A6AC File Offset: 0x003488AC
			// (set) Token: 0x0600DF5F RID: 57183 RVA: 0x0006CE31 File Offset: 0x0006B031
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004535 RID: 17717
			// (get) Token: 0x0600DF60 RID: 57184 RVA: 0x0034A6D4 File Offset: 0x003488D4
			// (set) Token: 0x0600DF61 RID: 57185 RVA: 0x0006CE4C File Offset: 0x0006B04C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004536 RID: 17718
			// (get) Token: 0x0600DF62 RID: 57186 RVA: 0x0034A704 File Offset: 0x00348904
			// (set) Token: 0x0600DF63 RID: 57187 RVA: 0x0006CE6B File Offset: 0x0006B06B
			public unsafe LabOvenButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOvenButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004537 RID: 17719
			// (get) Token: 0x0600DF64 RID: 57188 RVA: 0x0034A734 File Offset: 0x00348934
			// (set) Token: 0x0600DF65 RID: 57189 RVA: 0x0006CE8A File Offset: 0x0006B08A
			public unsafe Transform destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004538 RID: 17720
			// (get) Token: 0x0600DF66 RID: 57190 RVA: 0x0034A764 File Offset: 0x00348964
			// (set) Token: 0x0600DF67 RID: 57191 RVA: 0x0006CEA9 File Offset: 0x0006B0A9
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17004539 RID: 17721
			// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x0034A78C File Offset: 0x0034898C
			// (set) Token: 0x0600DF69 RID: 57193 RVA: 0x0006CEC4 File Offset: 0x0006B0C4
			public unsafe Vector3 _endPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__endPos_5__3)) = value;
				}
			}

			// Token: 0x1700453A RID: 17722
			// (get) Token: 0x0600DF6A RID: 57194 RVA: 0x0034A7B4 File Offset: 0x003489B4
			// (set) Token: 0x0600DF6B RID: 57195 RVA: 0x0006CEDF File Offset: 0x0006B0DF
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x1700453B RID: 17723
			// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x0034A7DC File Offset: 0x003489DC
			// (set) Token: 0x0600DF6D RID: 57197 RVA: 0x0006CEFA File Offset: 0x0006B0FA
			public unsafe float _t_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton._MoveButton_d__14.NativeFieldInfoPtr__t_5__5)) = value;
				}
			}

			// Token: 0x04009597 RID: 38295
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009598 RID: 38296
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009599 RID: 38297
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400959A RID: 38298
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x0400959B RID: 38299
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x0400959C RID: 38300
			private static readonly IntPtr NativeFieldInfoPtr__endPos_5__3;

			// Token: 0x0400959D RID: 38301
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x0400959E RID: 38302
			private static readonly IntPtr NativeFieldInfoPtr__t_5__5;

			// Token: 0x0400959F RID: 38303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095A0 RID: 38304
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095A1 RID: 38305
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095A2 RID: 38306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095A3 RID: 38307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095A4 RID: 38308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
