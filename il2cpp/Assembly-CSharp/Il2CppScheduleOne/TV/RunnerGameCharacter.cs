using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000189 RID: 393
	public class RunnerGameCharacter : MonoBehaviour
	{
		// Token: 0x06001FD5 RID: 8149 RVA: 0x000D38F8 File Offset: 0x000D1AF8
		// Note: this type is marked as 'beforefieldinit'.
		static RunnerGameCharacter()
		{
			Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "RunnerGameCharacter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr);
			RunnerGameCharacter.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "Game");
			RunnerGameCharacter.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, "onHit");
			RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666857);
			RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr, 100666858);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000D3978 File Offset: 0x000D1B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108510, XrefRangeEnd = 108518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000D39BC File Offset: 0x000D1BBC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunnerGameCharacter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunnerGameCharacter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunnerGameCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00011F66 File Offset: 0x00010166
		public RunnerGameCharacter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000D39F8 File Offset: 0x000D1BF8
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00011F6F File Offset: 0x0001016F
		public unsafe RunnerGame Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunnerGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000D3A28 File Offset: 0x000D1C28
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00011F8E File Offset: 0x0001018E
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunnerGameCharacter.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
