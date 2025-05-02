using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006A1 RID: 1697
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x06009787 RID: 38791 RVA: 0x0026BAE4 File Offset: 0x00269CE4
		// Note: this type is marked as 'beforefieldinit'.
		static AppsCanvas()
		{
			Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "AppsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr);
			AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			AppsCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "canvas");
			AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "delayedSetOpenRoutine");
			AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681987);
			AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681988);
			AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681989);
			AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681990);
			AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681991);
			AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681992);
			AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681993);
			AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681994);
			AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681995);
			AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681996);
			AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100681997);
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x0026BC2C File Offset: 0x00269E2C
		// (set) Token: 0x06009789 RID: 38793 RVA: 0x0026BC68 File Offset: 0x00269E68
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x0026BCA8 File Offset: 0x00269EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271353, XrefRangeEnd = 271359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x0026BCE4 File Offset: 0x00269EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271359, XrefRangeEnd = 271390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x0026BD30 File Offset: 0x00269F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271390, XrefRangeEnd = 271392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x0026BD64 File Offset: 0x00269F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271392, XrefRangeEnd = 271399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x0026BD98 File Offset: 0x00269F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271399, XrefRangeEnd = 271404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x0026BDF4 File Offset: 0x00269FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271407, RefRangeEnd = 271408, XrefRangeStart = 271404, XrefRangeEnd = 271407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x0026BE34 File Offset: 0x0026A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271408, XrefRangeEnd = 271411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x0026BE74 File Offset: 0x0026A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271411, XrefRangeEnd = 271420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x0026BEB0 File Offset: 0x0026A0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271420, XrefRangeEnd = 271423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x00049B20 File Offset: 0x00047D20
		public AppsCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x06009794 RID: 38804 RVA: 0x0026BEEC File Offset: 0x0026A0EC
		// (set) Token: 0x06009795 RID: 38805 RVA: 0x00049B29 File Offset: 0x00047D29
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x06009796 RID: 38806 RVA: 0x0026BF14 File Offset: 0x0026A114
		// (set) Token: 0x06009797 RID: 38807 RVA: 0x00049B44 File Offset: 0x00047D44
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x06009798 RID: 38808 RVA: 0x0026BF44 File Offset: 0x0026A144
		// (set) Token: 0x06009799 RID: 38809 RVA: 0x00049B63 File Offset: 0x00047D63
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006616 RID: 26134
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006617 RID: 26135
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006618 RID: 26136
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x04006619 RID: 26137
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400661A RID: 26138
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400661B RID: 26139
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400661C RID: 26140
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400661D RID: 26141
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x0400661E RID: 26142
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x0400661F RID: 26143
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04006620 RID: 26144
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006621 RID: 26145
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0;

		// Token: 0x04006622 RID: 26146
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006623 RID: 26147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B67 RID: 2919
		[ObfuscatedName("ScheduleOne.UI.Phone.AppsCanvas+<DelayedSetCanvasActive>d__10")]
		public sealed class _DelayedSetCanvasActive_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DA91 RID: 55953 RVA: 0x0033CD10 File Offset: 0x0033AF10
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__10()
			{
				Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<DelayedSetCanvasActive>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>1__state");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>2__current");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "delay");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>4__this");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "active");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681998);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100681999);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682000);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682001);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682002);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682003);
			}

			// Token: 0x0600DA92 RID: 55954 RVA: 0x0033CE18 File Offset: 0x0033B018
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA93 RID: 55955 RVA: 0x0033CE60 File Offset: 0x0033B060
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA94 RID: 55956 RVA: 0x0033CE94 File Offset: 0x0033B094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271343, XrefRangeEnd = 271348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043CE RID: 17358
			// (get) Token: 0x0600DA95 RID: 55957 RVA: 0x0033CED0 File Offset: 0x0033B0D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA96 RID: 55958 RVA: 0x0033CF10 File Offset: 0x0033B110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271348, XrefRangeEnd = 271353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0600DA97 RID: 55959 RVA: 0x0033CF44 File Offset: 0x0033B144
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA98 RID: 55960 RVA: 0x0006A6DA File Offset: 0x000688DA
			public _DelayedSetCanvasActive_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C9 RID: 17353
			// (get) Token: 0x0600DA99 RID: 55961 RVA: 0x0033CF84 File Offset: 0x0033B184
			// (set) Token: 0x0600DA9A RID: 55962 RVA: 0x0006A6E3 File Offset: 0x000688E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0600DA9B RID: 55963 RVA: 0x0033CFAC File Offset: 0x0033B1AC
			// (set) Token: 0x0600DA9C RID: 55964 RVA: 0x0006A6FE File Offset: 0x000688FE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0600DA9D RID: 55965 RVA: 0x0033CFDC File Offset: 0x0033B1DC
			// (set) Token: 0x0600DA9E RID: 55966 RVA: 0x0006A71D File Offset: 0x0006891D
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0600DA9F RID: 55967 RVA: 0x0033D004 File Offset: 0x0033B204
			// (set) Token: 0x0600DAA0 RID: 55968 RVA: 0x0006A738 File Offset: 0x00068938
			public unsafe AppsCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppsCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CD RID: 17357
			// (get) Token: 0x0600DAA1 RID: 55969 RVA: 0x0033D034 File Offset: 0x0033B234
			// (set) Token: 0x0600DAA2 RID: 55970 RVA: 0x0006A757 File Offset: 0x00068957
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x040092B3 RID: 37555
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092B4 RID: 37556
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092B5 RID: 37557
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040092B6 RID: 37558
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092B7 RID: 37559
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x040092B8 RID: 37560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092B9 RID: 37561
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092BA RID: 37562
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092BB RID: 37563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092BC RID: 37564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092BD RID: 37565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
