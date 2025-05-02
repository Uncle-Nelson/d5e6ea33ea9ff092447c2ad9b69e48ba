using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054E RID: 1358
	public class SetLayerOnAwake : MonoBehaviour
	{
		// Token: 0x060077DA RID: 30682 RVA: 0x00207680 File Offset: 0x00205880
		// Note: this type is marked as 'beforefieldinit'.
		static SetLayerOnAwake()
		{
			Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetLayerOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr);
			SetLayerOnAwake.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, "Layer");
			SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678376);
			SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678377);
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x002076EC File Offset: 0x002058EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232231, XrefRangeEnd = 232235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00207720 File Offset: 0x00205920
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLayerOnAwake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00038C47 File Offset: 0x00036E47
		public SetLayerOnAwake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x0020775C File Offset: 0x0020595C
		// (set) Token: 0x060077DF RID: 30687 RVA: 0x00038C50 File Offset: 0x00036E50
		public unsafe LayerMask Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x040051C1 RID: 20929
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x040051C2 RID: 20930
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051C3 RID: 20931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
