using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200036F RID: 879
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x060044BF RID: 17599 RVA: 0x00153510 File Offset: 0x00151710
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConditionalObject()
		{
			Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "NetworkConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr);
			NetworkConditionalObject.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, "condition");
			NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671689);
			NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671690);
			NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100671691);
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x00153590 File Offset: 0x00151790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155582, XrefRangeEnd = 155617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x001535C4 File Offset: 0x001517C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155617, XrefRangeEnd = 155620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x001535F8 File Offset: 0x001517F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00021947 File Offset: 0x0001FB47
		public NetworkConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x00153634 File Offset: 0x00151834
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x00021950 File Offset: 0x0001FB50
		public unsafe NetworkConditionalObject.ECondition condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition)) = value;
			}
		}

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000969 RID: 2409
		[OriginalName("Assembly-CSharp.dll", "", "ECondition")]
		public enum ECondition
		{
			// Token: 0x0400884E RID: 34894
			All,
			// Token: 0x0400884F RID: 34895
			HostOnly
		}
	}
}
