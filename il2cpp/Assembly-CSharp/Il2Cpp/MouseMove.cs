using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003F RID: 63
	public class MouseMove : MonoBehaviour
	{
		// Token: 0x06000537 RID: 1335 RVA: 0x0007F72C File Offset: 0x0007D92C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseMove()
		{
			Il2CppClassPointerStore<MouseMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MouseMove");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseMove>.NativeClassPtr);
			MouseMove.NativeFieldInfoPtr__sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, "_sensitivity");
			MouseMove.NativeFieldInfoPtr__originalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, "_originalPos");
			MouseMove.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663736);
			MouseMove.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663737);
			MouseMove.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseMove>.NativeClassPtr, 100663738);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0007F7C0 File Offset: 0x0007D9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74793, XrefRangeEnd = 74795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0007F7F4 File Offset: 0x0007D9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74795, XrefRangeEnd = 74800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0007F828 File Offset: 0x0007DA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74800, XrefRangeEnd = 74801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseMove() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseMove>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseMove.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00005219 File Offset: 0x00003419
		public MouseMove(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0007F864 File Offset: 0x0007DA64
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe float _sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__sensitivity)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0007F88C File Offset: 0x0007DA8C
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x0000523D File Offset: 0x0000343D
		public unsafe Vector3 _originalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__originalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseMove.NativeFieldInfoPtr__originalPos)) = value;
			}
		}

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr__sensitivity;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr__originalPos;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
