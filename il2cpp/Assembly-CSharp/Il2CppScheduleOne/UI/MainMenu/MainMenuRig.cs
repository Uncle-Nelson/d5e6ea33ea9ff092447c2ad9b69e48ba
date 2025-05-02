using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E9 RID: 1769
	public class MainMenuRig : MonoBehaviour
	{
		// Token: 0x06009E68 RID: 40552 RVA: 0x002806A4 File Offset: 0x0027E8A4
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuRig()
		{
			Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuRig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr);
			MainMenuRig.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "Avatar");
			MainMenuRig.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "DefaultSettings");
			MainMenuRig.NativeFieldInfoPtr_CashPiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "CashPiles");
			MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682731);
			MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682732);
			MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682733);
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x0028074C File Offset: 0x0027E94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280379, XrefRangeEnd = 280391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x00280780 File Offset: 0x0027E980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280391, XrefRangeEnd = 280431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x002807B4 File Offset: 0x0027E9B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuRig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x0004DB0D File Offset: 0x0004BD0D
		public MainMenuRig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06009E6D RID: 40557 RVA: 0x002807F0 File Offset: 0x0027E9F0
		// (set) Token: 0x06009E6E RID: 40558 RVA: 0x0004DB16 File Offset: 0x0004BD16
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x00280820 File Offset: 0x0027EA20
		// (set) Token: 0x06009E70 RID: 40560 RVA: 0x0004DB35 File Offset: 0x0004BD35
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x00280850 File Offset: 0x0027EA50
		// (set) Token: 0x06009E72 RID: 40562 RVA: 0x0004DB54 File Offset: 0x0004BD54
		public unsafe Il2CppReferenceArray<CashPile> CashPiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashPile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A53 RID: 27219
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04006A54 RID: 27220
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04006A55 RID: 27221
		private static readonly IntPtr NativeFieldInfoPtr_CashPiles;

		// Token: 0x04006A56 RID: 27222
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006A57 RID: 27223
		private static readonly IntPtr NativeMethodInfoPtr_LoadStuff_Private_Void_0;

		// Token: 0x04006A58 RID: 27224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
