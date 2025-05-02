using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020005FD RID: 1533
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x06008721 RID: 34593 RVA: 0x0023B1F4 File Offset: 0x002393F4
		// Note: this type is marked as 'beforefieldinit'.
		static ImpostorGenerator()
		{
			Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "ImpostorGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr);
			ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "ImpostorCamera");
			ImpostorGenerator.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "Avatar");
			ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "GenerationQueue");
			ImpostorGenerator.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "output");
			ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, 100680169);
		}

		// Token: 0x06008722 RID: 34594 RVA: 0x0023B288 File Offset: 0x00239488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251537, XrefRangeEnd = 251545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpostorGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008723 RID: 34595 RVA: 0x00040491 File Offset: 0x0003E691
		public ImpostorGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x06008724 RID: 34596 RVA: 0x0023B2C4 File Offset: 0x002394C4
		// (set) Token: 0x06008725 RID: 34597 RVA: 0x0004049A File Offset: 0x0003E69A
		public unsafe Camera ImpostorCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06008726 RID: 34598 RVA: 0x0023B2F4 File Offset: 0x002394F4
		// (set) Token: 0x06008727 RID: 34599 RVA: 0x000404B9 File Offset: 0x0003E6B9
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x06008728 RID: 34600 RVA: 0x0023B324 File Offset: 0x00239524
		// (set) Token: 0x06008729 RID: 34601 RVA: 0x000404D8 File Offset: 0x0003E6D8
		public unsafe List<AvatarSettings> GenerationQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600872A RID: 34602 RVA: 0x0023B354 File Offset: 0x00239554
		// (set) Token: 0x0600872B RID: 34603 RVA: 0x000404F7 File Offset: 0x0003E6F7
		public unsafe Texture2D output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BF3 RID: 23539
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorCamera;

		// Token: 0x04005BF4 RID: 23540
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005BF5 RID: 23541
		private static readonly IntPtr NativeFieldInfoPtr_GenerationQueue;

		// Token: 0x04005BF6 RID: 23542
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04005BF7 RID: 23543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
