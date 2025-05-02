using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000021 RID: 33
	public class BaseStarDataRenderer : Il2CppSystem.Object
	{
		// Token: 0x06000290 RID: 656 RVA: 0x0007880C File Offset: 0x00076A0C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseStarDataRenderer()
		{
			Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BaseStarDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr);
			BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "progressCallback");
			BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "completionCallback");
			BaseStarDataRenderer.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "density");
			BaseStarDataRenderer.NativeFieldInfoPtr_imageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "imageSize");
			BaseStarDataRenderer.NativeFieldInfoPtr_layerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "layerId");
			BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "maxRadius");
			BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "sphereRadius");
			BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "isCancelled");
			BaseStarDataRenderer.NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663532);
			BaseStarDataRenderer.NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663533);
			BaseStarDataRenderer.NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663534);
			BaseStarDataRenderer.NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663535);
			BaseStarDataRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663536);
			BaseStarDataRenderer.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663537);
			BaseStarDataRenderer.NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663538);
			BaseStarDataRenderer.NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663539);
			BaseStarDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, 100663540);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00078990 File Offset: 0x00076B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72713, XrefRangeEnd = 72717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_progressCallback(BaseStarDataRenderer.StarDataProgress value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000789D4 File Offset: 0x00076BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72717, XrefRangeEnd = 72721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_progressCallback(BaseStarDataRenderer.StarDataProgress value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00078A18 File Offset: 0x00076C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72721, XrefRangeEnd = 72725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_completionCallback(BaseStarDataRenderer.StarDataComplete value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00078A5C File Offset: 0x00076C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72725, XrefRangeEnd = 72729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_completionCallback(BaseStarDataRenderer.StarDataComplete value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00078AA0 File Offset: 0x00076CA0
		[CallerCount(0)]
		public unsafe virtual IEnumerator ComputeStarData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStarDataRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00078AEC File Offset: 0x00076CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72729, XrefRangeEnd = 72731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseStarDataRenderer.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00078B28 File Offset: 0x00076D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72731, RefRangeEnd = 72732, XrefRangeStart = 72731, XrefRangeEnd = 72731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00078B68 File Offset: 0x00076D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72732, RefRangeEnd = 72733, XrefRangeStart = 72732, XrefRangeEnd = 72732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCompletion(Texture2D texture, bool success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00078BB8 File Offset: 0x00076DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72734, RefRangeEnd = 72735, XrefRangeStart = 72733, XrefRangeEnd = 72734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseStarDataRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003761 File Offset: 0x00001961
		public BaseStarDataRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00078BF4 File Offset: 0x00076DF4
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0000376A File Offset: 0x0000196A
		public unsafe BaseStarDataRenderer.StarDataProgress progressCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseStarDataRenderer.StarDataProgress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_progressCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00078C24 File Offset: 0x00076E24
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00003789 File Offset: 0x00001989
		public unsafe BaseStarDataRenderer.StarDataComplete completionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseStarDataRenderer.StarDataComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_completionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00078C54 File Offset: 0x00076E54
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000037A8 File Offset: 0x000019A8
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00078C7C File Offset: 0x00076E7C
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000037C3 File Offset: 0x000019C3
		public unsafe float imageSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_imageSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_imageSize)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00078CA4 File Offset: 0x00076EA4
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x000037DE File Offset: 0x000019DE
		public unsafe string layerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_layerId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_layerId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00078CCC File Offset: 0x00076ECC
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x000037FD File Offset: 0x000019FD
		public unsafe float maxRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_maxRadius)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00078CF4 File Offset: 0x00076EF4
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003818 File Offset: 0x00001A18
		public unsafe float sphereRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_sphereRadius)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00078D1C File Offset: 0x00076F1C
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00003833 File Offset: 0x00001A33
		public unsafe bool isCancelled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseStarDataRenderer.NativeFieldInfoPtr_isCancelled)) = value;
			}
		}

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_progressCallback;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_completionCallback;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_imageSize;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_layerId;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_maxRadius;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_isCancelled;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_add_progressCallback_Public_add_Void_StarDataProgress_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_remove_progressCallback_Public_rem_Void_StarDataProgress_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_add_completionCallback_Public_add_Void_StarDataComplete_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_remove_completionCallback_Public_rem_Void_StarDataComplete_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStarData_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_SendProgress_Protected_Void_Single_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_SendCompletion_Protected_Void_Texture2D_Boolean_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020007AD RID: 1965
		public sealed class StarDataProgress : MulticastDelegate
		{
			// Token: 0x0600B983 RID: 47491 RVA: 0x002E0E08 File Offset: 0x002DF008
			// Note: this type is marked as 'beforefieldinit'.
			static StarDataProgress()
			{
				Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "StarDataProgress");
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663541);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663542);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663543);
				BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr, 100663544);
			}

			// Token: 0x0600B984 RID: 47492 RVA: 0x002E0E7C File Offset: 0x002DF07C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72693, RefRangeEnd = 72695, XrefRangeStart = 72684, XrefRangeEnd = 72693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StarDataProgress(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataProgress>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B985 RID: 47493 RVA: 0x002E0ED8 File Offset: 0x002DF0D8
			[CallerCount(0)]
			public unsafe void Invoke(BaseStarDataRenderer renderer, float progress)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B986 RID: 47494 RVA: 0x002E0F28 File Offset: 0x002DF128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72695, XrefRangeEnd = 72699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, float progress, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B987 RID: 47495 RVA: 0x002E0FAC File Offset: 0x002DF1AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataProgress.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B988 RID: 47496 RVA: 0x0005AB33 File Offset: 0x00058D33
			public StarDataProgress(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B989 RID: 47497 RVA: 0x0005AB3C File Offset: 0x00058D3C
			public static implicit operator BaseStarDataRenderer.StarDataProgress(Action<BaseStarDataRenderer, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<BaseStarDataRenderer.StarDataProgress>(A_0);
			}

			// Token: 0x0600B98A RID: 47498 RVA: 0x0005AB44 File Offset: 0x00058D44
			public static BaseStarDataRenderer.StarDataProgress operator +(BaseStarDataRenderer.StarDataProgress A_0, BaseStarDataRenderer.StarDataProgress A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BaseStarDataRenderer.StarDataProgress>();
			}

			// Token: 0x0600B98B RID: 47499 RVA: 0x0005AB52 File Offset: 0x00058D52
			public static BaseStarDataRenderer.StarDataProgress operator -(BaseStarDataRenderer.StarDataProgress A_0, BaseStarDataRenderer.StarDataProgress A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<BaseStarDataRenderer.StarDataProgress>();
				}
				return result;
			}

			// Token: 0x04007D2B RID: 32043
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D2C RID: 32044
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Single_0;

			// Token: 0x04007D2D RID: 32045
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Single_AsyncCallback_Object_0;

			// Token: 0x04007D2E RID: 32046
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020007AE RID: 1966
		public sealed class StarDataComplete : MulticastDelegate
		{
			// Token: 0x0600B98C RID: 47500 RVA: 0x002E0FF0 File Offset: 0x002DF1F0
			// Note: this type is marked as 'beforefieldinit'.
			static StarDataComplete()
			{
				Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseStarDataRenderer>.NativeClassPtr, "StarDataComplete");
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663545);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663546);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663547);
				BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr, 100663548);
			}

			// Token: 0x0600B98D RID: 47501 RVA: 0x002E1064 File Offset: 0x002DF264
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72708, RefRangeEnd = 72709, XrefRangeStart = 72699, XrefRangeEnd = 72708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StarDataComplete(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseStarDataRenderer.StarDataComplete>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B98E RID: 47502 RVA: 0x002E10C0 File Offset: 0x002DF2C0
			[CallerCount(0)]
			public unsafe void Invoke(BaseStarDataRenderer renderer, Texture2D texture, bool success)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B98F RID: 47503 RVA: 0x002E1124 File Offset: 0x002DF324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72709, XrefRangeEnd = 72713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, Texture2D texture, bool success, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B990 RID: 47504 RVA: 0x002E11BC File Offset: 0x002DF3BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseStarDataRenderer.StarDataComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B991 RID: 47505 RVA: 0x0005AB63 File Offset: 0x00058D63
			public StarDataComplete(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B992 RID: 47506 RVA: 0x0005AB6C File Offset: 0x00058D6C
			public static implicit operator BaseStarDataRenderer.StarDataComplete(Action<BaseStarDataRenderer, Texture2D, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<BaseStarDataRenderer.StarDataComplete>(A_0);
			}

			// Token: 0x0600B993 RID: 47507 RVA: 0x0005AB74 File Offset: 0x00058D74
			public static BaseStarDataRenderer.StarDataComplete operator +(BaseStarDataRenderer.StarDataComplete A_0, BaseStarDataRenderer.StarDataComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BaseStarDataRenderer.StarDataComplete>();
			}

			// Token: 0x0600B994 RID: 47508 RVA: 0x0005AB82 File Offset: 0x00058D82
			public static BaseStarDataRenderer.StarDataComplete operator -(BaseStarDataRenderer.StarDataComplete A_0, BaseStarDataRenderer.StarDataComplete A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<BaseStarDataRenderer.StarDataComplete>();
				}
				return result;
			}

			// Token: 0x04007D2F RID: 32047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D30 RID: 32048
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_BaseStarDataRenderer_Texture2D_Boolean_0;

			// Token: 0x04007D31 RID: 32049
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BaseStarDataRenderer_Texture2D_Boolean_AsyncCallback_Object_0;

			// Token: 0x04007D32 RID: 32050
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
