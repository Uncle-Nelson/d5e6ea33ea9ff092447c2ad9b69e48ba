using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F6 RID: 1526
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x06008672 RID: 34418 RVA: 0x00239234 File Offset: 0x00237434
		// Note: this type is marked as 'beforefieldinit'.
		static Eyebrow()
		{
			Il2CppClassPointerStore<Eyebrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eyebrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr);
			Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "eyebrowHeightMultiplier");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultScale");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultLocalPos");
			Eyebrow.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Side");
			Eyebrow.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Model");
			Eyebrow.NativeFieldInfoPtr_Rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Rend");
			Eyebrow.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "col");
			Eyebrow.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "scale");
			Eyebrow.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "thickness");
			Eyebrow.NativeFieldInfoPtr_restingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "restingAngle");
			Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680096);
			Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680097);
			Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680098);
			Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680099);
			Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680100);
			Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680101);
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x002393A4 File Offset: 0x002375A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 251133, RefRangeEnd = 251138, XrefRangeStart = 251132, XrefRangeEnd = 251133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float _scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x002393E4 File Offset: 0x002375E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251138, XrefRangeEnd = 251139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thickness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x00239424 File Offset: 0x00237624
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 251147, RefRangeEnd = 251151, XrefRangeStart = 251139, XrefRangeEnd = 251147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingAngle(float _angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x00239464 File Offset: 0x00237664
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251153, RefRangeEnd = 251159, XrefRangeStart = 251151, XrefRangeEnd = 251153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x002394A4 File Offset: 0x002376A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251159, XrefRangeEnd = 251161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color _col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x002394E4 File Offset: 0x002376E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251161, XrefRangeEnd = 251162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eyebrow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x0003FE6B File Offset: 0x0003E06B
		public Eyebrow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x0600867A RID: 34426 RVA: 0x00239520 File Offset: 0x00237720
		// (set) Token: 0x0600867B RID: 34427 RVA: 0x0003FE74 File Offset: 0x0003E074
		public unsafe static float eyebrowHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x0023953C File Offset: 0x0023773C
		// (set) Token: 0x0600867D RID: 34429 RVA: 0x0003FE82 File Offset: 0x0003E082
		public unsafe Vector3 EyebrowDefaultScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale)) = value;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x0600867E RID: 34430 RVA: 0x00239564 File Offset: 0x00237764
		// (set) Token: 0x0600867F RID: 34431 RVA: 0x0003FE9D File Offset: 0x0003E09D
		public unsafe Vector3 EyebrowDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos)) = value;
			}
		}

		// Token: 0x170028DC RID: 10460
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x0023958C File Offset: 0x0023778C
		// (set) Token: 0x06008681 RID: 34433 RVA: 0x0003FEB8 File Offset: 0x0003E0B8
		public unsafe Eyebrow.ESide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x170028DD RID: 10461
		// (get) Token: 0x06008682 RID: 34434 RVA: 0x002395B4 File Offset: 0x002377B4
		// (set) Token: 0x06008683 RID: 34435 RVA: 0x0003FED3 File Offset: 0x0003E0D3
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x06008684 RID: 34436 RVA: 0x002395E4 File Offset: 0x002377E4
		// (set) Token: 0x06008685 RID: 34437 RVA: 0x0003FEF2 File Offset: 0x0003E0F2
		public unsafe MeshRenderer Rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x06008686 RID: 34438 RVA: 0x00239614 File Offset: 0x00237814
		// (set) Token: 0x06008687 RID: 34439 RVA: 0x0003FF11 File Offset: 0x0003E111
		public unsafe Color col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col)) = value;
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x0023963C File Offset: 0x0023783C
		// (set) Token: 0x06008689 RID: 34441 RVA: 0x0003FF2C File Offset: 0x0003E12C
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x0600868A RID: 34442 RVA: 0x00239664 File Offset: 0x00237864
		// (set) Token: 0x0600868B RID: 34443 RVA: 0x0003FF47 File Offset: 0x0003E147
		public unsafe float thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x0600868C RID: 34444 RVA: 0x0023968C File Offset: 0x0023788C
		// (set) Token: 0x0600868D RID: 34445 RVA: 0x0003FF62 File Offset: 0x0003E162
		public unsafe float restingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle)) = value;
			}
		}

		// Token: 0x04005B86 RID: 23430
		private static readonly IntPtr NativeFieldInfoPtr_eyebrowHeightMultiplier;

		// Token: 0x04005B87 RID: 23431
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultScale;

		// Token: 0x04005B88 RID: 23432
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultLocalPos;

		// Token: 0x04005B89 RID: 23433
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x04005B8A RID: 23434
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x04005B8B RID: 23435
		private static readonly IntPtr NativeFieldInfoPtr_Rend;

		// Token: 0x04005B8C RID: 23436
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04005B8D RID: 23437
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04005B8E RID: 23438
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04005B8F RID: 23439
		private static readonly IntPtr NativeFieldInfoPtr_restingAngle;

		// Token: 0x04005B90 RID: 23440
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04005B91 RID: 23441
		private static readonly IntPtr NativeMethodInfoPtr_SetThickness_Public_Void_Single_0;

		// Token: 0x04005B92 RID: 23442
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0;

		// Token: 0x04005B93 RID: 23443
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B94 RID: 23444
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04005B95 RID: 23445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF2 RID: 2802
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x04008FC5 RID: 36805
			Right,
			// Token: 0x04008FC6 RID: 36806
			Left
		}
	}
}
