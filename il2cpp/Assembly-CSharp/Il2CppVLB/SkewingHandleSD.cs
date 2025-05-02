using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AC RID: 172
	public class SkewingHandleSD : MonoBehaviour
	{
		// Token: 0x06000C12 RID: 3090 RVA: 0x000973BC File Offset: 0x000955BC
		// Note: this type is marked as 'beforefieldinit'.
		static SkewingHandleSD()
		{
			Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SkewingHandleSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr);
			SkewingHandleSD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "ClassName");
			SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "volumetricLightBeam");
			SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "shouldUpdateEachFrame");
			SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664771);
			SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664772);
			SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664773);
			SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664774);
			SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664775);
			SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664776);
			SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664777);
			SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664778);
			SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664779);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000974DC File Offset: 0x000956DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83925, XrefRangeEnd = 83929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAttachedToSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00097518 File Offset: 0x00095718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83933, RefRangeEnd = 83937, XrefRangeStart = 83929, XrefRangeEnd = 83933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00097554 File Offset: 0x00095754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83937, XrefRangeEnd = 83938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00097590 File Offset: 0x00095790
		[CallerCount(0)]
		public unsafe bool ShouldUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000975CC File Offset: 0x000957CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83938, XrefRangeEnd = 83940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00097600 File Offset: 0x00095800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83940, XrefRangeEnd = 83951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00097634 File Offset: 0x00095834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83951, XrefRangeEnd = 83956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00097674 File Offset: 0x00095874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83962, XrefRangeStart = 83956, XrefRangeEnd = 83960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000976A8 File Offset: 0x000958A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkewingHandleSD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00007FF0 File Offset: 0x000061F0
		public SkewingHandleSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x000976E4 File Offset: 0x000958E4
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00007FF9 File Offset: 0x000061F9
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00097704 File Offset: 0x00095904
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0000800B File Offset: 0x0000620B
		public unsafe VolumetricLightBeamSD volumetricLightBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00097734 File Offset: 0x00095934
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0000802A File Offset: 0x0000622A
		public unsafe bool shouldUpdateEachFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame)) = value;
			}
		}

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr_volumetricLightBeam;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr_shouldUpdateEachFrame;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_SetSkewingVector_Private_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000834 RID: 2100
		[ObfuscatedName("VLB.SkewingHandleSD+<CoUpdate>d__9")]
		public sealed class _CoUpdate_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600BF05 RID: 48901 RVA: 0x002EDCC8 File Offset: 0x002EBEC8
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__9()
			{
				Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "<CoUpdate>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr);
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>1__state");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>2__current");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>4__this");
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664780);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664781);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664782);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664783);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664784);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664785);
			}

			// Token: 0x0600BF06 RID: 48902 RVA: 0x002EDDA8 File Offset: 0x002EBFA8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF07 RID: 48903 RVA: 0x002EDDF0 File Offset: 0x002EBFF0
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF08 RID: 48904 RVA: 0x002EDE24 File Offset: 0x002EC024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83917, XrefRangeEnd = 83920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B68 RID: 15208
			// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x002EDE60 File Offset: 0x002EC060
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF0A RID: 48906 RVA: 0x002EDEA0 File Offset: 0x002EC0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83920, XrefRangeEnd = 83925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B69 RID: 15209
			// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x002EDED4 File Offset: 0x002EC0D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF0C RID: 48908 RVA: 0x0005D626 File Offset: 0x0005B826
			public _CoUpdate_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B65 RID: 15205
			// (get) Token: 0x0600BF0D RID: 48909 RVA: 0x002EDF14 File Offset: 0x002EC114
			// (set) Token: 0x0600BF0E RID: 48910 RVA: 0x0005D62F File Offset: 0x0005B82F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B66 RID: 15206
			// (get) Token: 0x0600BF0F RID: 48911 RVA: 0x002EDF3C File Offset: 0x002EC13C
			// (set) Token: 0x0600BF10 RID: 48912 RVA: 0x0005D64A File Offset: 0x0005B84A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B67 RID: 15207
			// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x002EDF6C File Offset: 0x002EC16C
			// (set) Token: 0x0600BF12 RID: 48914 RVA: 0x0005D669 File Offset: 0x0005B869
			public unsafe SkewingHandleSD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkewingHandleSD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400817B RID: 33147
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400817C RID: 33148
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400817D RID: 33149
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400817E RID: 33150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400817F RID: 33151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008180 RID: 33152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008181 RID: 33153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008182 RID: 33154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008183 RID: 33155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
