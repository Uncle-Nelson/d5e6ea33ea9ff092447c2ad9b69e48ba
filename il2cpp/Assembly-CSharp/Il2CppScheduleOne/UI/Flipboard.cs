using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063B RID: 1595
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x06008CEF RID: 36079 RVA: 0x0024C3C0 File Offset: 0x0024A5C0
		// Note: this type is marked as 'beforefieldinit'.
		static Flipboard()
		{
			Il2CppClassPointerStore<Flipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "Flipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flipboard>.NativeClassPtr);
			Flipboard.NativeFieldInfoPtr_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Sprites");
			Flipboard.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Image");
			Flipboard.NativeFieldInfoPtr_FlipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "FlipTime");
			Flipboard.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "SpeedMultiplier");
			Flipboard.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "time");
			Flipboard.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "index");
			Flipboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680804);
			Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680805);
			Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680806);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x0024C4A4 File Offset: 0x0024A6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257550, XrefRangeEnd = 257552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x0024C4D8 File Offset: 0x0024A6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257555, RefRangeEnd = 257556, XrefRangeStart = 257552, XrefRangeEnd = 257555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x0024C518 File Offset: 0x0024A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257556, XrefRangeEnd = 257557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x00043992 File Offset: 0x00041B92
		public Flipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x06008CF4 RID: 36084 RVA: 0x0024C554 File Offset: 0x0024A754
		// (set) Token: 0x06008CF5 RID: 36085 RVA: 0x0004399B File Offset: 0x00041B9B
		public unsafe Il2CppReferenceArray<Sprite> Sprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x06008CF6 RID: 36086 RVA: 0x0024C584 File Offset: 0x0024A784
		// (set) Token: 0x06008CF7 RID: 36087 RVA: 0x000439BA File Offset: 0x00041BBA
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x06008CF8 RID: 36088 RVA: 0x0024C5B4 File Offset: 0x0024A7B4
		// (set) Token: 0x06008CF9 RID: 36089 RVA: 0x000439D9 File Offset: 0x00041BD9
		public unsafe float FlipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime)) = value;
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x06008CFA RID: 36090 RVA: 0x0024C5DC File Offset: 0x0024A7DC
		// (set) Token: 0x06008CFB RID: 36091 RVA: 0x000439F4 File Offset: 0x00041BF4
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x06008CFC RID: 36092 RVA: 0x0024C604 File Offset: 0x0024A804
		// (set) Token: 0x06008CFD RID: 36093 RVA: 0x00043A0F File Offset: 0x00041C0F
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x06008CFE RID: 36094 RVA: 0x0024C62C File Offset: 0x0024A82C
		// (set) Token: 0x06008CFF RID: 36095 RVA: 0x00043A2A File Offset: 0x00041C2A
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04005F81 RID: 24449
		private static readonly IntPtr NativeFieldInfoPtr_Sprites;

		// Token: 0x04005F82 RID: 24450
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x04005F83 RID: 24451
		private static readonly IntPtr NativeFieldInfoPtr_FlipTime;

		// Token: 0x04005F84 RID: 24452
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04005F85 RID: 24453
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04005F86 RID: 24454
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04005F87 RID: 24455
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005F88 RID: 24456
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0;

		// Token: 0x04005F89 RID: 24457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
