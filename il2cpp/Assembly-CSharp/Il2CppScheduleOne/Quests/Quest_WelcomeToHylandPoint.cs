using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C6 RID: 454
	public class Quest_WelcomeToHylandPoint : Quest
	{
		// Token: 0x060026D8 RID: 9944 RVA: 0x000EA6CC File Offset: 0x000E88CC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_WelcomeToHylandPoint()
		{
			Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_WelcomeToHylandPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr);
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReturnToRVQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ReadMessagesQuest");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "RV");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "Nelson");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMaxDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "ExplosionMinDist");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "onExplode");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "exploded");
			Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "cameraLookTime");
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667640);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667641);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667642);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667643);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667644);
			Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, 100667645);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x000EA828 File Offset: 0x000E8A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117630, XrefRangeEnd = 117632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000EA864 File Offset: 0x000E8A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117632, XrefRangeEnd = 117644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000EA898 File Offset: 0x000E8A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117644, XrefRangeEnd = 117656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Explode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000EA8CC File Offset: 0x000E8ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117656, XrefRangeEnd = 117674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000EA924 File Offset: 0x000E8B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117674, XrefRangeEnd = 117678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_WelcomeToHylandPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000EA960 File Offset: 0x000E8B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117678, XrefRangeEnd = 117682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0001582A File Offset: 0x00013A2A
		public Quest_WelcomeToHylandPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000EA994 File Offset: 0x000E8B94
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x00015833 File Offset: 0x00013A33
		public unsafe QuestEntry ReturnToRVQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReturnToRVQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000EA9C4 File Offset: 0x000E8BC4
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x00015852 File Offset: 0x00013A52
		public unsafe QuestEntry ReadMessagesQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ReadMessagesQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000EA9F4 File Offset: 0x000E8BF4
		// (set) Token: 0x060026E5 RID: 9957 RVA: 0x00015871 File Offset: 0x00013A71
		public unsafe RV RV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_RV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000EAA24 File Offset: 0x000E8C24
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x00015890 File Offset: 0x00013A90
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000EAA54 File Offset: 0x000E8C54
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x000158AF File Offset: 0x00013AAF
		public unsafe float ExplosionMaxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMaxDist)) = value;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x000EAA7C File Offset: 0x000E8C7C
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x000158CA File Offset: 0x00013ACA
		public unsafe float ExplosionMinDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_ExplosionMinDist)) = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000EAAA4 File Offset: 0x000E8CA4
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x000158E5 File Offset: 0x00013AE5
		public unsafe UnityEvent onExplode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_onExplode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x000EAAD4 File Offset: 0x000E8CD4
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x00015904 File Offset: 0x00013B04
		public unsafe bool exploded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_exploded)) = value;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000EAAFC File Offset: 0x000E8CFC
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x0001591F File Offset: 0x00013B1F
		public unsafe float cameraLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.NativeFieldInfoPtr_cameraLookTime)) = value;
			}
		}

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToRVQuest;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_ReadMessagesQuest;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_RV;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMaxDist;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionMinDist;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeFieldInfoPtr_onExplode;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr_exploded;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeFieldInfoPtr_cameraLookTime;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_Explode_Public_Void_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x020008D5 RID: 2261
		[ObfuscatedName("ScheduleOne.Quests.Quest_WelcomeToHylandPoint+<<Explode>g__Shake|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
		{
			// Token: 0x0600C441 RID: 50241 RVA: 0x002FD17C File Offset: 0x002FB37C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint>.NativeClassPtr, "<<Explode>g__Shake|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667646);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667647);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667648);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667649);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667650);
				Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667651);
			}

			// Token: 0x0600C442 RID: 50242 RVA: 0x002FD248 File Offset: 0x002FB448
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C443 RID: 50243 RVA: 0x002FD290 File Offset: 0x002FB490
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C444 RID: 50244 RVA: 0x002FD2C4 File Offset: 0x002FB4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117619, XrefRangeEnd = 117625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D43 RID: 15683
			// (get) Token: 0x0600C445 RID: 50245 RVA: 0x002FD300 File Offset: 0x002FB500
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C446 RID: 50246 RVA: 0x002FD340 File Offset: 0x002FB540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117625, XrefRangeEnd = 117630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D44 RID: 15684
			// (get) Token: 0x0600C447 RID: 50247 RVA: 0x002FD374 File Offset: 0x002FB574
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C448 RID: 50248 RVA: 0x0005F849 File Offset: 0x0005DA49
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D41 RID: 15681
			// (get) Token: 0x0600C449 RID: 50249 RVA: 0x002FD3B4 File Offset: 0x002FB5B4
			// (set) Token: 0x0600C44A RID: 50250 RVA: 0x0005F852 File Offset: 0x0005DA52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D42 RID: 15682
			// (get) Token: 0x0600C44B RID: 50251 RVA: 0x002FD3DC File Offset: 0x002FB5DC
			// (set) Token: 0x0600C44C RID: 50252 RVA: 0x0005F86D File Offset: 0x0005DA6D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_WelcomeToHylandPoint.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008501 RID: 34049
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008502 RID: 34050
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008503 RID: 34051
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008504 RID: 34052
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008505 RID: 34053
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008506 RID: 34054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008507 RID: 34055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008508 RID: 34056
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
