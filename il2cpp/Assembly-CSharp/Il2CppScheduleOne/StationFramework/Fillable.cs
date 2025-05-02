using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000588 RID: 1416
	public class Fillable : MonoBehaviour
	{
		// Token: 0x06007CB4 RID: 31924 RVA: 0x00217A90 File Offset: 0x00215C90
		// Note: this type is marked as 'beforefieldinit'.
		static Fillable()
		{
			Il2CppClassPointerStore<Fillable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "Fillable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable>.NativeClassPtr);
			Fillable.NativeFieldInfoPtr__contents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<contents>k__BackingField");
			Fillable.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidContainer");
			Fillable.NativeFieldInfoPtr_FillableEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "FillableEnabled");
			Fillable.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "LiquidCapacity_L");
			Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678909);
			Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678910);
			Fillable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678911);
			Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678912);
			Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678913);
			Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678914);
			Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678915);
			Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678916);
			Fillable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable>.NativeClassPtr, 100678917);
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x00217BC4 File Offset: 0x00215DC4
		// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x00217C04 File Offset: 0x00215E04
		public unsafe List<Fillable.Content> contents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x00217C48 File Offset: 0x00215E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237585, XrefRangeEnd = 237587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x00217C7C File Offset: 0x00215E7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237614, RefRangeEnd = 237617, XrefRangeStart = 237587, XrefRangeEnd = 237614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLiquid(string label, float volume, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x00217CDC File Offset: 0x00215EDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 237621, RefRangeEnd = 237627, XrefRangeStart = 237617, XrefRangeEnd = 237621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_ResetContents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x00217D10 File Offset: 0x00215F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237662, RefRangeEnd = 237664, XrefRangeStart = 237627, XrefRangeEnd = 237662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_UpdateLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x00217D44 File Offset: 0x00215F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237664, XrefRangeEnd = 237678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLiquidVolume(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x00217D94 File Offset: 0x00215F94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237696, RefRangeEnd = 237697, XrefRangeStart = 237678, XrefRangeEnd = 237696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalLiquidVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x00217DD0 File Offset: 0x00215FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237697, XrefRangeEnd = 237705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Fillable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0003B34E File Offset: 0x0003954E
		public Fillable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x00217E0C File Offset: 0x0021600C
		// (set) Token: 0x06007CC0 RID: 31936 RVA: 0x0003B357 File Offset: 0x00039557
		public unsafe List<Fillable.Content> _contents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Fillable.Content>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr__contents_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x00217E3C File Offset: 0x0021603C
		// (set) Token: 0x06007CC2 RID: 31938 RVA: 0x0003B376 File Offset: 0x00039576
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x00217E6C File Offset: 0x0021606C
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x0003B395 File Offset: 0x00039595
		public unsafe bool FillableEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_FillableEnabled)) = value;
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x00217E94 File Offset: 0x00216094
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x0003B3B0 File Offset: 0x000395B0
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x040054E3 RID: 21731
		private static readonly IntPtr NativeFieldInfoPtr__contents_k__BackingField;

		// Token: 0x040054E4 RID: 21732
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040054E5 RID: 21733
		private static readonly IntPtr NativeFieldInfoPtr_FillableEnabled;

		// Token: 0x040054E6 RID: 21734
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x040054E7 RID: 21735
		private static readonly IntPtr NativeMethodInfoPtr_get_contents_Public_get_List_1_Content_0;

		// Token: 0x040054E8 RID: 21736
		private static readonly IntPtr NativeMethodInfoPtr_set_contents_Protected_set_Void_List_1_Content_0;

		// Token: 0x040054E9 RID: 21737
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040054EA RID: 21738
		private static readonly IntPtr NativeMethodInfoPtr_AddLiquid_Public_Void_String_Single_Color_0;

		// Token: 0x040054EB RID: 21739
		private static readonly IntPtr NativeMethodInfoPtr_ResetContents_Public_Void_0;

		// Token: 0x040054EC RID: 21740
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLiquid_Private_Void_0;

		// Token: 0x040054ED RID: 21741
		private static readonly IntPtr NativeMethodInfoPtr_GetLiquidVolume_Public_Single_String_0;

		// Token: 0x040054EE RID: 21742
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalLiquidVolume_Public_Single_0;

		// Token: 0x040054EF RID: 21743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB6 RID: 2742
		public class Content : Il2CppSystem.Object
		{
			// Token: 0x0600D3C3 RID: 54211 RVA: 0x00329350 File Offset: 0x00327550
			// Note: this type is marked as 'beforefieldinit'.
			static Content()
			{
				Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "Content");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr);
				Fillable.Content.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Label");
				Fillable.Content.NativeFieldInfoPtr_Volume_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Volume_L");
				Fillable.Content.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, "Color");
				Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr, 100678918);
			}

			// Token: 0x0600D3C4 RID: 54212 RVA: 0x003293CC File Offset: 0x003275CC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Content() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.Content>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.Content.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C5 RID: 54213 RVA: 0x00067189 File Offset: 0x00065389
			public Content(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AB RID: 16811
			// (get) Token: 0x0600D3C6 RID: 54214 RVA: 0x00329408 File Offset: 0x00327608
			// (set) Token: 0x0600D3C7 RID: 54215 RVA: 0x00067192 File Offset: 0x00065392
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041AC RID: 16812
			// (get) Token: 0x0600D3C8 RID: 54216 RVA: 0x00329430 File Offset: 0x00327630
			// (set) Token: 0x0600D3C9 RID: 54217 RVA: 0x000671B1 File Offset: 0x000653B1
			public unsafe float Volume_L
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Volume_L)) = value;
				}
			}

			// Token: 0x170041AD RID: 16813
			// (get) Token: 0x0600D3CA RID: 54218 RVA: 0x00329458 File Offset: 0x00327658
			// (set) Token: 0x0600D3CB RID: 54219 RVA: 0x000671CC File Offset: 0x000653CC
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.Content.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008EA5 RID: 36517
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04008EA6 RID: 36518
			private static readonly IntPtr NativeFieldInfoPtr_Volume_L;

			// Token: 0x04008EA7 RID: 36519
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008EA8 RID: 36520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AB7 RID: 2743
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D3CC RID: 54220 RVA: 0x00329480 File Offset: 0x00327680
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr);
				Fillable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9");
				Fillable.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__11_0");
				Fillable.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, "<>9__13_0");
				Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678920);
				Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678921);
				Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr, 100678922);
			}

			// Token: 0x0600D3CD RID: 54221 RVA: 0x00329524 File Offset: 0x00327724
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3CE RID: 54222 RVA: 0x00329560 File Offset: 0x00327760
			[CallerCount(0)]
			public unsafe float _UpdateLiquid_b__11_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3CF RID: 54223 RVA: 0x003295B0 File Offset: 0x003277B0
			[CallerCount(0)]
			public unsafe float _GetTotalLiquidVolume_b__13_0(Fillable.Content x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c.NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3D0 RID: 54224 RVA: 0x000671E7 File Offset: 0x000653E7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AE RID: 16814
			// (get) Token: 0x0600D3D1 RID: 54225 RVA: 0x00329600 File Offset: 0x00327800
			// (set) Token: 0x0600D3D2 RID: 54226 RVA: 0x000671F0 File Offset: 0x000653F0
			public unsafe static Fillable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AF RID: 16815
			// (get) Token: 0x0600D3D3 RID: 54227 RVA: 0x00329628 File Offset: 0x00327828
			// (set) Token: 0x0600D3D4 RID: 54228 RVA: 0x00067202 File Offset: 0x00065402
			public unsafe static Func<Fillable.Content, float> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B0 RID: 16816
			// (get) Token: 0x0600D3D5 RID: 54229 RVA: 0x00329650 File Offset: 0x00327850
			// (set) Token: 0x0600D3D6 RID: 54230 RVA: 0x00067214 File Offset: 0x00065414
			public unsafe static Func<Fillable.Content, float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Fillable.Content, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Fillable.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EA9 RID: 36521
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EAA RID: 36522
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008EAB RID: 36523
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04008EAC RID: 36524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EAD RID: 36525
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__11_0_Internal_Single_Content_0;

			// Token: 0x04008EAE RID: 36526
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalLiquidVolume_b__13_0_Internal_Single_Content_0;
		}

		// Token: 0x02000AB8 RID: 2744
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3D7 RID: 54231 RVA: 0x00329678 File Offset: 0x00327878
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr);
				Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, "totalVolume");
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678923);
				Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr, 100678924);
			}

			// Token: 0x0600D3D8 RID: 54232 RVA: 0x003296E0 File Offset: 0x003278E0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3D9 RID: 54233 RVA: 0x0032971C File Offset: 0x0032791C
			[CallerCount(0)]
			public unsafe Color _UpdateLiquid_b__1(Color acc, Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref acc;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass11_0.NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3DA RID: 54234 RVA: 0x00067226 File Offset: 0x00065426
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B1 RID: 16817
			// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x00329778 File Offset: 0x00327978
			// (set) Token: 0x0600D3DC RID: 54236 RVA: 0x0006722F File Offset: 0x0006542F
			public unsafe float totalVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass11_0.NativeFieldInfoPtr_totalVolume)) = value;
				}
			}

			// Token: 0x04008EAF RID: 36527
			private static readonly IntPtr NativeFieldInfoPtr_totalVolume;

			// Token: 0x04008EB0 RID: 36528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB1 RID: 36529
			private static readonly IntPtr NativeMethodInfoPtr__UpdateLiquid_b__1_Internal_Color_Color_Content_0;
		}

		// Token: 0x02000AB9 RID: 2745
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3DD RID: 54237 RVA: 0x003297A0 File Offset: 0x003279A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr);
				Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678925);
				Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr, 100678926);
			}

			// Token: 0x0600D3DE RID: 54238 RVA: 0x00329808 File Offset: 0x00327A08
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3DF RID: 54239 RVA: 0x00329844 File Offset: 0x00327A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLiquidVolume_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass12_0.NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3E0 RID: 54240 RVA: 0x0006724A File Offset: 0x0006544A
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B2 RID: 16818
			// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x00329894 File Offset: 0x00327A94
			// (set) Token: 0x0600D3E2 RID: 54242 RVA: 0x00067253 File Offset: 0x00065453
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass12_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EB2 RID: 36530
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008EB3 RID: 36531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB4 RID: 36532
			private static readonly IntPtr NativeMethodInfoPtr__GetLiquidVolume_b__0_Internal_Boolean_Content_0;
		}

		// Token: 0x02000ABA RID: 2746
		[ObfuscatedName("ScheduleOne.StationFramework.Fillable+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3E3 RID: 54243 RVA: 0x003298BC File Offset: 0x00327ABC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fillable>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr);
				Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, "label");
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678927);
				Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr, 100678928);
			}

			// Token: 0x0600D3E4 RID: 54244 RVA: 0x00329924 File Offset: 0x00327B24
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fillable.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3E5 RID: 54245 RVA: 0x00329960 File Offset: 0x00327B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddLiquid_b__0(Fillable.Content c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Fillable.__c__DisplayClass9_0.NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D3E6 RID: 54246 RVA: 0x00067272 File Offset: 0x00065472
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B3 RID: 16819
			// (get) Token: 0x0600D3E7 RID: 54247 RVA: 0x003299B0 File Offset: 0x00327BB0
			// (set) Token: 0x0600D3E8 RID: 54248 RVA: 0x0006727B File Offset: 0x0006547B
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Fillable.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EB5 RID: 36533
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008EB6 RID: 36534
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EB7 RID: 36535
			private static readonly IntPtr NativeMethodInfoPtr__AddLiquid_b__0_Internal_Boolean_Content_0;
		}
	}
}
