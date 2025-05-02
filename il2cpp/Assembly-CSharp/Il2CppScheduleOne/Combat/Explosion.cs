using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000491 RID: 1169
	public class Explosion : MonoBehaviour
	{
		// Token: 0x0600653B RID: 25915 RVA: 0x001C9288 File Offset: 0x001C7488
		// Note: this type is marked as 'beforefieldinit'.
		static Explosion()
		{
			Il2CppClassPointerStore<Explosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Explosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosion>.NativeClassPtr);
			Explosion.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "Sound");
			Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676111);
			Explosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676112);
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x001C92F4 File Offset: 0x001C74F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205922, RefRangeEnd = 205923, XrefRangeStart = 205821, XrefRangeEnd = 205922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x001C9340 File Offset: 0x001C7540
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x0002FE08 File Offset: 0x0002E008
		public Explosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x001C937C File Offset: 0x001C757C
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x0002FE11 File Offset: 0x0002E011
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400450F RID: 17679
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04004510 RID: 17680
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x04004511 RID: 17681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
