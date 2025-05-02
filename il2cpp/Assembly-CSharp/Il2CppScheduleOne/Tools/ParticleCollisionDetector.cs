using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000544 RID: 1348
	public class ParticleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06007765 RID: 30565 RVA: 0x00206114 File Offset: 0x00204314
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleCollisionDetector()
		{
			Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ParticleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr);
			ParticleCollisionDetector.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "onCollision");
			ParticleCollisionDetector.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, "ps");
			ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678335);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678336);
			ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678337);
			ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr, 100678338);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x002061BC File Offset: 0x002043BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231847, XrefRangeEnd = 231851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x002061F0 File Offset: 0x002043F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231851, XrefRangeEnd = 231854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00206234 File Offset: 0x00204434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231854, XrefRangeEnd = 231864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParticleTrigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x00206268 File Offset: 0x00204468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231864, XrefRangeEnd = 231872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x000388D7 File Offset: 0x00036AD7
		public ParticleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x002062A4 File Offset: 0x002044A4
		// (set) Token: 0x0600776C RID: 30572 RVA: 0x000388E0 File Offset: 0x00036AE0
		public unsafe UnityEvent<GameObject> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x002062D4 File Offset: 0x002044D4
		// (set) Token: 0x0600776E RID: 30574 RVA: 0x000388FF File Offset: 0x00036AFF
		public unsafe ParticleSystem ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleCollisionDetector.NativeFieldInfoPtr_ps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400517C RID: 20860
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x0400517D RID: 20861
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x0400517E RID: 20862
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400517F RID: 20863
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Public_Void_GameObject_0;

		// Token: 0x04005180 RID: 20864
		private static readonly IntPtr NativeMethodInfoPtr_OnParticleTrigger_Private_Void_0;

		// Token: 0x04005181 RID: 20865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
