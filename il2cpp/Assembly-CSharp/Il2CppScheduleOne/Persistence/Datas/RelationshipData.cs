using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs.Relation;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026B RID: 619
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x06002F4A RID: 12106 RVA: 0x001074D0 File Offset: 0x001056D0
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipData()
		{
			Il2CppClassPointerStore<RelationshipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RelationshipData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr);
			RelationshipData.NativeFieldInfoPtr_RelationDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "RelationDelta");
			RelationshipData.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "Unlocked");
			RelationshipData.NativeFieldInfoPtr_UnlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "UnlockType");
			RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, 100668769);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00107550 File Offset: 0x00105750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130720, RefRangeEnd = 130721, XrefRangeStart = 130719, XrefRangeEnd = 130720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00019056 File Offset: 0x00017256
		public RelationshipData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002F4D RID: 12109 RVA: 0x001075B4 File Offset: 0x001057B4
		// (set) Token: 0x06002F4E RID: 12110 RVA: 0x0001905F File Offset: 0x0001725F
		public unsafe float RelationDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta)) = value;
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x001075DC File Offset: 0x001057DC
		// (set) Token: 0x06002F50 RID: 12112 RVA: 0x0001907A File Offset: 0x0001727A
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x00107604 File Offset: 0x00105804
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x00019095 File Offset: 0x00017295
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType)) = value;
			}
		}

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeFieldInfoPtr_RelationDelta;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeFieldInfoPtr_UnlockType;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0;
	}
}
