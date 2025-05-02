using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000022 RID: 34
	public class SpinPlanet : MonoBehaviour
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00078D44 File Offset: 0x00076F44
		// Note: this type is marked as 'beforefieldinit'.
		static SpinPlanet()
		{
			Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpinPlanet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr);
			SpinPlanet.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, "speed");
			SpinPlanet.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, 100663549);
			SpinPlanet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr, 100663550);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00078DB0 File Offset: 0x00076FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72735, XrefRangeEnd = 72740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinPlanet.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00078DE4 File Offset: 0x00076FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72740, XrefRangeEnd = 72741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpinPlanet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpinPlanet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinPlanet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000384E File Offset: 0x00001A4E
		public SpinPlanet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00078E20 File Offset: 0x00077020
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003857 File Offset: 0x00001A57
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinPlanet.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpinPlanet.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
