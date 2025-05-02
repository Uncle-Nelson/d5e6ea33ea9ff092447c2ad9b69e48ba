using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000472 RID: 1138
	[Serializable]
	public class GameSettings : Object
	{
		// Token: 0x06006265 RID: 25189 RVA: 0x001BF804 File Offset: 0x001BDA04
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettings()
		{
			Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
			GameSettings.NativeFieldInfoPtr_ConsoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ConsoleEnabled");
			GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100675775);
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x001BF85C File Offset: 0x001BDA5C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x0002E843 File Offset: 0x0002CA43
		public GameSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x001BF898 File Offset: 0x001BDA98
		// (set) Token: 0x06006269 RID: 25193 RVA: 0x0002E84C File Offset: 0x0002CA4C
		public unsafe bool ConsoleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled)) = value;
			}
		}

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleEnabled;

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
