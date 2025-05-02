using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C4 RID: 196
	public class PlayerController : MonoBehaviour
	{
		// Token: 0x06000EA9 RID: 3753 RVA: 0x0009F2C8 File Offset: 0x0009D4C8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerController()
		{
			Il2CppClassPointerStore<PlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "PlayerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerController>.NativeClassPtr);
			PlayerController.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "cam");
			PlayerController.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "speed");
			PlayerController.NativeFieldInfoPtr_jumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "jumpForce");
			PlayerController.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "rb");
			PlayerController.NativeFieldInfoPtr_isGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "isGrounded");
			PlayerController.NativeFieldInfoPtr_landBendEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "landBendEffect");
			PlayerController.NativeFieldInfoPtr_raycastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, "raycastHit");
			PlayerController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665048);
			PlayerController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665049);
			PlayerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665050);
			PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerController>.NativeClassPtr, 100665051);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0009F3D4 File Offset: 0x0009D5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85871, XrefRangeEnd = 85881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0009F408 File Offset: 0x0009D608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85881, XrefRangeEnd = 85895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0009F43C File Offset: 0x0009D63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85895, XrefRangeEnd = 85921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0009F470 File Offset: 0x0009D670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85921, XrefRangeEnd = 85922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000092FD File Offset: 0x000074FD
		public PlayerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0009F4AC File Offset: 0x0009D6AC
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00009306 File Offset: 0x00007506
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00009325 File Offset: 0x00007525
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0009F504 File Offset: 0x0009D704
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00009340 File Offset: 0x00007540
		public unsafe float jumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_jumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_jumpForce)) = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0009F52C File Offset: 0x0009D72C
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0000935B File Offset: 0x0000755B
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0009F55C File Offset: 0x0009D75C
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x0000937A File Offset: 0x0000757A
		public unsafe bool isGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_isGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_isGrounded)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0009F584 File Offset: 0x0009D784
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00009395 File Offset: 0x00007595
		public unsafe ParticleSystem landBendEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_landBendEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_landBendEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0009F5B4 File Offset: 0x0009D7B4
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000093B4 File Offset: 0x000075B4
		public unsafe RaycastHit raycastHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_raycastHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerController.NativeFieldInfoPtr_raycastHit)) = value;
			}
		}

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeFieldInfoPtr_jumpForce;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeFieldInfoPtr_isGrounded;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeFieldInfoPtr_landBendEffect;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_raycastHit;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
