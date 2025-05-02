using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066C RID: 1644
	public class MaskedObject : UIBehaviour
	{
		// Token: 0x060092CA RID: 37578 RVA: 0x0025D6A0 File Offset: 0x0025B8A0
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedObject()
		{
			Il2CppClassPointerStore<MaskedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "MaskedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr);
			MaskedObject.NativeFieldInfoPtr_canvasRendererToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRendererToClip");
			MaskedObject.NativeFieldInfoPtr_includeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "includeChildren");
			MaskedObject.NativeFieldInfoPtr_rootCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "rootCanvas");
			MaskedObject.NativeFieldInfoPtr_maskRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "maskRectTransform");
			MaskedObject.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "initialized");
			MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, "canvasRenderersToClip");
			MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681512);
			MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681513);
			MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681514);
			MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681515);
			MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681516);
			MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr, 100681517);
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x0025D7C0 File Offset: 0x0025B9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265127, XrefRangeEnd = 265129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x0025D7FC File Offset: 0x0025B9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265129, XrefRangeEnd = 265133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x0025D838 File Offset: 0x0025BA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265133, XrefRangeEnd = 265151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskedObject.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x0025D874 File Offset: 0x0025BA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265151, XrefRangeEnd = 265154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Canvas rootCanvas, RectTransform maskRectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootCanvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maskRectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x0025D8C8 File Offset: 0x0025BAC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265173, RefRangeEnd = 265177, XrefRangeStart = 265154, XrefRangeEnd = 265173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetClippingRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x0025D8FC File Offset: 0x0025BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265177, XrefRangeEnd = 265185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskedObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x000470EB File Offset: 0x000452EB
		public MaskedObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x0025D938 File Offset: 0x0025BB38
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x000470F4 File Offset: 0x000452F4
		public unsafe CanvasRenderer canvasRendererToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRendererToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x0025D968 File Offset: 0x0025BB68
		// (set) Token: 0x060092D5 RID: 37589 RVA: 0x00047113 File Offset: 0x00045313
		public unsafe bool includeChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_includeChildren)) = value;
			}
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x060092D6 RID: 37590 RVA: 0x0025D990 File Offset: 0x0025BB90
		// (set) Token: 0x060092D7 RID: 37591 RVA: 0x0004712E File Offset: 0x0004532E
		public unsafe Canvas rootCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_rootCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x060092D8 RID: 37592 RVA: 0x0025D9C0 File Offset: 0x0025BBC0
		// (set) Token: 0x060092D9 RID: 37593 RVA: 0x0004714D File Offset: 0x0004534D
		public unsafe RectTransform maskRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_maskRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x060092DA RID: 37594 RVA: 0x0025D9F0 File Offset: 0x0025BBF0
		// (set) Token: 0x060092DB RID: 37595 RVA: 0x0004716C File Offset: 0x0004536C
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x060092DC RID: 37596 RVA: 0x0025DA18 File Offset: 0x0025BC18
		// (set) Token: 0x060092DD RID: 37597 RVA: 0x00047187 File Offset: 0x00045387
		public unsafe List<CanvasRenderer> canvasRenderersToClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskedObject.NativeFieldInfoPtr_canvasRenderersToClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006325 RID: 25381
		private static readonly IntPtr NativeFieldInfoPtr_canvasRendererToClip;

		// Token: 0x04006326 RID: 25382
		private static readonly IntPtr NativeFieldInfoPtr_includeChildren;

		// Token: 0x04006327 RID: 25383
		private static readonly IntPtr NativeFieldInfoPtr_rootCanvas;

		// Token: 0x04006328 RID: 25384
		private static readonly IntPtr NativeFieldInfoPtr_maskRectTransform;

		// Token: 0x04006329 RID: 25385
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400632A RID: 25386
		private static readonly IntPtr NativeFieldInfoPtr_canvasRenderersToClip;

		// Token: 0x0400632B RID: 25387
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400632C RID: 25388
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400632D RID: 25389
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400632E RID: 25390
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Canvas_RectTransform_0;

		// Token: 0x0400632F RID: 25391
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetClippingRect_Private_Void_0;

		// Token: 0x04006330 RID: 25392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
