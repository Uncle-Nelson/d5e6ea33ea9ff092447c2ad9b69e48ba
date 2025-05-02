using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076F RID: 1903
	public class Spin : MonoBehaviour
	{
		// Token: 0x0600B4AE RID: 46254 RVA: 0x002CF9B4 File Offset: 0x002CDBB4
		// Note: this type is marked as 'beforefieldinit'.
		static Spin()
		{
			Il2CppClassPointerStore<Spin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "Spin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spin>.NativeClassPtr);
			Spin.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Axis");
			Spin.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Speed");
			Spin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100685528);
			Spin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100685529);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002CFA34 File Offset: 0x002CDC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309833, XrefRangeEnd = 309836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x002CFA68 File Offset: 0x002CDC68
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x00058A1F File Offset: 0x00056C1F
		public Spin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x002CFAA4 File Offset: 0x002CDCA4
		// (set) Token: 0x0600B4B3 RID: 46259 RVA: 0x00058A28 File Offset: 0x00056C28
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600B4B4 RID: 46260 RVA: 0x002CFACC File Offset: 0x002CDCCC
		// (set) Token: 0x0600B4B5 RID: 46261 RVA: 0x00058A43 File Offset: 0x00056C43
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x040079CA RID: 31178
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040079CB RID: 31179
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040079CC RID: 31180
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040079CD RID: 31181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
