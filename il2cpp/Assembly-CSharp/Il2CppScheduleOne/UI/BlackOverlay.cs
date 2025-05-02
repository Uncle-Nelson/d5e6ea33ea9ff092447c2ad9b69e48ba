using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000626 RID: 1574
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x06008AAF RID: 35503 RVA: 0x002455D8 File Offset: 0x002437D8
		// Note: this type is marked as 'beforefieldinit'.
		static BlackOverlay()
		{
			Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BlackOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr);
			BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<isShown>k__BackingField");
			BlackOverlay.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "canvas");
			BlackOverlay.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "group");
			BlackOverlay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "fadeRoutine");
			BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680525);
			BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680526);
			BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680527);
			BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680528);
			BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680529);
			BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680530);
			BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100680531);
		}

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x06008AB0 RID: 35504 RVA: 0x002456E4 File Offset: 0x002438E4
		// (set) Token: 0x06008AB1 RID: 35505 RVA: 0x00245720 File Offset: 0x00243920
		public unsafe bool isShown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00245760 File Offset: 0x00243960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254577, XrefRangeEnd = 254583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x0024579C File Offset: 0x0024399C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254589, RefRangeEnd = 254594, XrefRangeStart = 254583, XrefRangeEnd = 254589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x002457DC File Offset: 0x002439DC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 254598, RefRangeEnd = 254605, XrefRangeStart = 254594, XrefRangeEnd = 254598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x0024581C File Offset: 0x00243A1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254610, RefRangeEnd = 254613, XrefRangeStart = 254605, XrefRangeEnd = 254610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Fade(float endOpacity, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endOpacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x00245878 File Offset: 0x00243A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254613, XrefRangeEnd = 254616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x0004252F File Offset: 0x0004072F
		public BlackOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x06008AB8 RID: 35512 RVA: 0x002458B4 File Offset: 0x00243AB4
		// (set) Token: 0x06008AB9 RID: 35513 RVA: 0x00042538 File Offset: 0x00040738
		public unsafe bool _isShown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x002458DC File Offset: 0x00243ADC
		// (set) Token: 0x06008ABB RID: 35515 RVA: 0x00042553 File Offset: 0x00040753
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x0024590C File Offset: 0x00243B0C
		// (set) Token: 0x06008ABD RID: 35517 RVA: 0x00042572 File Offset: 0x00040772
		public unsafe CanvasGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x0024593C File Offset: 0x00243B3C
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x00042591 File Offset: 0x00040791
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E14 RID: 24084
		private static readonly IntPtr NativeFieldInfoPtr__isShown_k__BackingField;

		// Token: 0x04005E15 RID: 24085
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005E16 RID: 24086
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04005E17 RID: 24087
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04005E18 RID: 24088
		private static readonly IntPtr NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0;

		// Token: 0x04005E19 RID: 24089
		private static readonly IntPtr NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0;

		// Token: 0x04005E1A RID: 24090
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005E1B RID: 24091
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Single_0;

		// Token: 0x04005E1C RID: 24092
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Single_0;

		// Token: 0x04005E1D RID: 24093
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0;

		// Token: 0x04005E1E RID: 24094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B12 RID: 2834
		[ObfuscatedName("ScheduleOne.UI.BlackOverlay+<Fade>d__10")]
		public sealed class _Fade_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600D6AC RID: 54956 RVA: 0x00331898 File Offset: 0x0032FA98
			// Note: this type is marked as 'beforefieldinit'.
			static _Fade_d__10()
			{
				Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<Fade>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr);
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>1__state");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>2__current");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>4__this");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "endOpacity");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "fadeTime");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<start>5__2");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<i>5__3");
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680532);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680533);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680534);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680535);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680536);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100680537);
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x003319C8 File Offset: 0x0032FBC8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Fade_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AE RID: 54958 RVA: 0x00331A10 File Offset: 0x0032FC10
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AF RID: 54959 RVA: 0x00331A44 File Offset: 0x0032FC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254562, XrefRangeEnd = 254572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004287 RID: 17031
			// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x00331A80 File Offset: 0x0032FC80
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6B1 RID: 54961 RVA: 0x00331AC0 File Offset: 0x0032FCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254572, XrefRangeEnd = 254577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004288 RID: 17032
			// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x00331AF4 File Offset: 0x0032FCF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6B3 RID: 54963 RVA: 0x00068777 File Offset: 0x00066977
			public _Fade_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004280 RID: 17024
			// (get) Token: 0x0600D6B4 RID: 54964 RVA: 0x00331B34 File Offset: 0x0032FD34
			// (set) Token: 0x0600D6B5 RID: 54965 RVA: 0x00068780 File Offset: 0x00066980
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004281 RID: 17025
			// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x00331B5C File Offset: 0x0032FD5C
			// (set) Token: 0x0600D6B7 RID: 54967 RVA: 0x0006879B File Offset: 0x0006699B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004282 RID: 17026
			// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x00331B8C File Offset: 0x0032FD8C
			// (set) Token: 0x0600D6B9 RID: 54969 RVA: 0x000687BA File Offset: 0x000669BA
			public unsafe BlackOverlay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackOverlay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004283 RID: 17027
			// (get) Token: 0x0600D6BA RID: 54970 RVA: 0x00331BBC File Offset: 0x0032FDBC
			// (set) Token: 0x0600D6BB RID: 54971 RVA: 0x000687D9 File Offset: 0x000669D9
			public unsafe float endOpacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity)) = value;
				}
			}

			// Token: 0x17004284 RID: 17028
			// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x00331BE4 File Offset: 0x0032FDE4
			// (set) Token: 0x0600D6BD RID: 54973 RVA: 0x000687F4 File Offset: 0x000669F4
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17004285 RID: 17029
			// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x00331C0C File Offset: 0x0032FE0C
			// (set) Token: 0x0600D6BF RID: 54975 RVA: 0x0006880F File Offset: 0x00066A0F
			public unsafe float _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x17004286 RID: 17030
			// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x00331C34 File Offset: 0x0032FE34
			// (set) Token: 0x0600D6C1 RID: 54977 RVA: 0x0006882A File Offset: 0x00066A2A
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009063 RID: 36963
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009064 RID: 36964
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009065 RID: 36965
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009066 RID: 36966
			private static readonly IntPtr NativeFieldInfoPtr_endOpacity;

			// Token: 0x04009067 RID: 36967
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009068 RID: 36968
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04009069 RID: 36969
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400906A RID: 36970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400906B RID: 36971
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400906C RID: 36972
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400906D RID: 36973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400906E RID: 36974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400906F RID: 36975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
