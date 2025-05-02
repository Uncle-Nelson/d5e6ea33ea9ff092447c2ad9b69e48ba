using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054F RID: 1359
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x060077E0 RID: 30688 RVA: 0x00207784 File Offset: 0x00205984
		// Note: this type is marked as 'beforefieldinit'.
		static SetRendererMaterial()
		{
			Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetRendererMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr);
			SetRendererMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, "Material");
			SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678378);
			SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678379);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x002077F0 File Offset: 0x002059F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232235, XrefRangeEnd = 232244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00207824 File Offset: 0x00205A24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetRendererMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00038C6B File Offset: 0x00036E6B
		public SetRendererMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x00207860 File Offset: 0x00205A60
		// (set) Token: 0x060077E5 RID: 30693 RVA: 0x00038C74 File Offset: 0x00036E74
		public unsafe Material Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051C4 RID: 20932
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x040051C5 RID: 20933
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x040051C6 RID: 20934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
