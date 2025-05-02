using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000186 RID: 390
	public class PongBall : MonoBehaviour
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x000D278C File Offset: 0x000D098C
		// Note: this type is marked as 'beforefieldinit'.
		static PongBall()
		{
			Il2CppClassPointerStore<PongBall>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongBall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongBall>.NativeClassPtr);
			PongBall.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Game");
			PongBall.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Rect");
			PongBall.NativeFieldInfoPtr_RB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RB");
			PongBall.NativeFieldInfoPtr_RandomForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RandomForce");
			PongBall.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "onHit");
			PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666835);
			PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666836);
			PongBall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666837);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x000D285C File Offset: 0x000D0A5C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x000D2890 File Offset: 0x000D0A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108227, XrefRangeEnd = 108258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x000D28D4 File Offset: 0x000D0AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongBall() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongBall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00011ABE File Offset: 0x0000FCBE
		public PongBall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x000D2910 File Offset: 0x000D0B10
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00011AC7 File Offset: 0x0000FCC7
		public unsafe Pong Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pong>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x000D2940 File Offset: 0x000D0B40
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00011AE6 File Offset: 0x0000FCE6
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x000D2970 File Offset: 0x000D0B70
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00011B05 File Offset: 0x0000FD05
		public unsafe Rigidbody RB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x000D29A0 File Offset: 0x000D0BA0
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x00011B24 File Offset: 0x0000FD24
		public unsafe float RandomForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce)) = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000D29C8 File Offset: 0x000D0BC8
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00011B3F File Offset: 0x0000FD3F
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeFieldInfoPtr_RB;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeFieldInfoPtr_RandomForce;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
