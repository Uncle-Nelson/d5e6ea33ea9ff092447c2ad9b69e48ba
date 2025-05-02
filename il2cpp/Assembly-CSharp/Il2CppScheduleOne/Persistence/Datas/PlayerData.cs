using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A8 RID: 680
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x06003133 RID: 12595 RVA: 0x0010CC1C File Offset: 0x0010AE1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerData()
		{
			Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
			PlayerData.NativeFieldInfoPtr_PlayerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "PlayerCode");
			PlayerData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Position");
			PlayerData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Rotation");
			PlayerData.NativeFieldInfoPtr_IntroCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "IntroCompleted");
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100668832);
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100668833);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0010CCC4 File Offset: 0x0010AEC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131098, RefRangeEnd = 131101, XrefRangeStart = 131094, XrefRangeEnd = 131098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref introCompleted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0010CD3C File Offset: 0x0010AF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131104, RefRangeEnd = 131105, XrefRangeStart = 131101, XrefRangeEnd = 131104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0001A42C File Offset: 0x0001862C
		public PlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x0010CD78 File Offset: 0x0010AF78
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x0001A435 File Offset: 0x00018635
		public unsafe string PlayerCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0010CDA0 File Offset: 0x0010AFA0
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x0001A454 File Offset: 0x00018654
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x0010CDC8 File Offset: 0x0010AFC8
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x0001A46F File Offset: 0x0001866F
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0010CDF0 File Offset: 0x0010AFF0
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x0001A48A File Offset: 0x0001868A
		public unsafe bool IntroCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted)) = value;
			}
		}

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeFieldInfoPtr_PlayerCode;

		// Token: 0x0400200C RID: 8204
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400200D RID: 8205
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400200E RID: 8206
		private static readonly IntPtr NativeFieldInfoPtr_IntroCompleted;

		// Token: 0x0400200F RID: 8207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0;

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
