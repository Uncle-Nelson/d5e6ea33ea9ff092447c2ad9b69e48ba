using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D2 RID: 1234
	public class GameVolumeSetter : MonoBehaviour
	{
		// Token: 0x06006C16 RID: 27670 RVA: 0x001E075C File Offset: 0x001DE95C
		// Note: this type is marked as 'beforefieldinit'.
		static GameVolumeSetter()
		{
			Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "GameVolumeSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr);
			GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, "VolumeMultiplier");
			GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100676963);
			GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100676964);
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x001E07C8 File Offset: 0x001DE9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216805, XrefRangeEnd = 216811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x001E07FC File Offset: 0x001DE9FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74374, RefRangeEnd = 74378, XrefRangeStart = 74374, XrefRangeEnd = 74378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVolumeSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x000332C3 File Offset: 0x000314C3
		public GameVolumeSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06006C1A RID: 27674 RVA: 0x001E0838 File Offset: 0x001DEA38
		// (set) Token: 0x06006C1B RID: 27675 RVA: 0x000332CC File Offset: 0x000314CC
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x040049EC RID: 18924
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040049ED RID: 18925
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049EE RID: 18926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
