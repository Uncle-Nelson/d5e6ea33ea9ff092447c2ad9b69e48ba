using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A9 RID: 1193
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x060068C8 RID: 26824 RVA: 0x001D672C File Offset: 0x001D492C
		// Note: this type is marked as 'beforefieldinit'.
		static SlotReel()
		{
			Il2CppClassPointerStore<SlotReel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotReel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel>.NativeClassPtr);
			SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentSymbol>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentRotation>k__BackingField");
			SlotReel.NativeFieldInfoPtr_SymbolRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotations");
			SlotReel.NativeFieldInfoPtr_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SpinSpeed");
			SlotReel.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "StopSound");
			SlotReel.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStart");
			SlotReel.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStop");
			SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676637);
			SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676638);
			SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676639);
			SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676640);
			SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676641);
			SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676642);
			SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676643);
			SlotReel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676644);
			SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676645);
			SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676646);
			SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676647);
			SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676648);
			SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676649);
			SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676650);
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x001D6914 File Offset: 0x001D4B14
		// (set) Token: 0x060068CA RID: 26826 RVA: 0x001D6950 File Offset: 0x001D4B50
		public unsafe bool IsSpinning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x001D6990 File Offset: 0x001D4B90
		// (set) Token: 0x060068CC RID: 26828 RVA: 0x001D69CC File Offset: 0x001D4BCC
		public unsafe SlotMachine.ESymbol CurrentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x060068CD RID: 26829 RVA: 0x001D6A0C File Offset: 0x001D4C0C
		// (set) Token: 0x060068CE RID: 26830 RVA: 0x001D6A48 File Offset: 0x001D4C48
		public unsafe float CurrentRotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x001D6A88 File Offset: 0x001D4C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212203, XrefRangeEnd = 212207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x001D6ABC File Offset: 0x001D4CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212207, XrefRangeEnd = 212224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x001D6AF0 File Offset: 0x001D4CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212224, XrefRangeEnd = 212225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x001D6B24 File Offset: 0x001D4D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212225, XrefRangeEnd = 212226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(SlotMachine.ESymbol endSymbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endSymbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x001D6B64 File Offset: 0x001D4D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29963, RefRangeEnd = 29964, XrefRangeStart = 29963, XrefRangeEnd = 29964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSymbol(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x001D6BA4 File Offset: 0x001D4DA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212230, RefRangeEnd = 212232, XrefRangeStart = 212226, XrefRangeEnd = 212230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReelRotation(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x001D6BE4 File Offset: 0x001D4DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212232, XrefRangeEnd = 212236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x001D6C30 File Offset: 0x001D4E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212236, XrefRangeEnd = 212237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotReel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00031649 File Offset: 0x0002F849
		public SlotReel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x060068D8 RID: 26840 RVA: 0x001D6C6C File Offset: 0x001D4E6C
		// (set) Token: 0x060068D9 RID: 26841 RVA: 0x00031652 File Offset: 0x0002F852
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x001D6C94 File Offset: 0x001D4E94
		// (set) Token: 0x060068DB RID: 26843 RVA: 0x0003166D File Offset: 0x0002F86D
		public unsafe SlotMachine.ESymbol _CurrentSymbol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x060068DC RID: 26844 RVA: 0x001D6CBC File Offset: 0x001D4EBC
		// (set) Token: 0x060068DD RID: 26845 RVA: 0x00031688 File Offset: 0x0002F888
		public unsafe float _CurrentRotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x001D6CE4 File Offset: 0x001D4EE4
		// (set) Token: 0x060068DF RID: 26847 RVA: 0x000316A3 File Offset: 0x0002F8A3
		public unsafe Il2CppReferenceArray<SlotReel.SymbolRotation> SymbolRotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel.SymbolRotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x001D6D14 File Offset: 0x001D4F14
		// (set) Token: 0x060068E1 RID: 26849 RVA: 0x000316C2 File Offset: 0x0002F8C2
		public unsafe float SpinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed)) = value;
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x001D6D3C File Offset: 0x001D4F3C
		// (set) Token: 0x060068E3 RID: 26851 RVA: 0x000316DD File Offset: 0x0002F8DD
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x060068E4 RID: 26852 RVA: 0x001D6D6C File Offset: 0x001D4F6C
		// (set) Token: 0x060068E5 RID: 26853 RVA: 0x000316FC File Offset: 0x0002F8FC
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x001D6D9C File Offset: 0x001D4F9C
		// (set) Token: 0x060068E7 RID: 26855 RVA: 0x0003171B File Offset: 0x0002F91B
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047D5 RID: 18389
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x040047D6 RID: 18390
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSymbol_k__BackingField;

		// Token: 0x040047D7 RID: 18391
		private static readonly IntPtr NativeFieldInfoPtr__CurrentRotation_k__BackingField;

		// Token: 0x040047D8 RID: 18392
		private static readonly IntPtr NativeFieldInfoPtr_SymbolRotations;

		// Token: 0x040047D9 RID: 18393
		private static readonly IntPtr NativeFieldInfoPtr_SpinSpeed;

		// Token: 0x040047DA RID: 18394
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x040047DB RID: 18395
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040047DC RID: 18396
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x040047DD RID: 18397
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x040047DE RID: 18398
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x040047DF RID: 18399
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0;

		// Token: 0x040047E0 RID: 18400
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0;

		// Token: 0x040047E1 RID: 18401
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0;

		// Token: 0x040047E2 RID: 18402
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0;

		// Token: 0x040047E3 RID: 18403
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040047E4 RID: 18404
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040047E5 RID: 18405
		private static readonly IntPtr NativeMethodInfoPtr_Spin_Public_Void_0;

		// Token: 0x040047E6 RID: 18406
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0;

		// Token: 0x040047E7 RID: 18407
		private static readonly IntPtr NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0;

		// Token: 0x040047E8 RID: 18408
		private static readonly IntPtr NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0;

		// Token: 0x040047E9 RID: 18409
		private static readonly IntPtr NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0;

		// Token: 0x040047EA RID: 18410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A4F RID: 2639
		[Serializable]
		public class SymbolRotation : Il2CppSystem.Object
		{
			// Token: 0x0600D036 RID: 53302 RVA: 0x0031F630 File Offset: 0x0031D830
			// Note: this type is marked as 'beforefieldinit'.
			static SymbolRotation()
			{
				Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr);
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Symbol");
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Rotation");
				SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, 100676651);
			}

			// Token: 0x0600D037 RID: 53303 RVA: 0x0031F698 File Offset: 0x0031D898
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D038 RID: 53304 RVA: 0x00065531 File Offset: 0x00063731
			public SymbolRotation(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040AB RID: 16555
			// (get) Token: 0x0600D039 RID: 53305 RVA: 0x0031F6D4 File Offset: 0x0031D8D4
			// (set) Token: 0x0600D03A RID: 53306 RVA: 0x0006553A File Offset: 0x0006373A
			public unsafe SlotMachine.ESymbol Symbol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol)) = value;
				}
			}

			// Token: 0x170040AC RID: 16556
			// (get) Token: 0x0600D03B RID: 53307 RVA: 0x0031F6FC File Offset: 0x0031D8FC
			// (set) Token: 0x0600D03C RID: 53308 RVA: 0x00065555 File Offset: 0x00063755
			public unsafe float Rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation)) = value;
				}
			}

			// Token: 0x04008C88 RID: 35976
			private static readonly IntPtr NativeFieldInfoPtr_Symbol;

			// Token: 0x04008C89 RID: 35977
			private static readonly IntPtr NativeFieldInfoPtr_Rotation;

			// Token: 0x04008C8A RID: 35978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
