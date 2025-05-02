using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000613 RID: 1555
	public class ACEntry : MonoBehaviour
	{
		// Token: 0x06008968 RID: 35176 RVA: 0x002418EC File Offset: 0x0023FAEC
		// Note: this type is marked as 'beforefieldinit'.
		static ACEntry()
		{
			Il2CppClassPointerStore<ACEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACEntry>.NativeClassPtr);
			ACEntry.NativeFieldInfoPtr_DevOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, "DevOnly");
			ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680404);
			ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680405);
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x00241958 File Offset: 0x0023FB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253639, XrefRangeEnd = 253645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x0024198C File Offset: 0x0023FB8C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x000419AB File Offset: 0x0003FBAB
		public ACEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600896C RID: 35180 RVA: 0x002419C8 File Offset: 0x0023FBC8
		// (set) Token: 0x0600896D RID: 35181 RVA: 0x000419B4 File Offset: 0x0003FBB4
		public unsafe bool DevOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly)) = value;
			}
		}

		// Token: 0x04005D4F RID: 23887
		private static readonly IntPtr NativeFieldInfoPtr_DevOnly;

		// Token: 0x04005D50 RID: 23888
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D51 RID: 23889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
