using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003C RID: 60
	public class LandingSpot : MonoBehaviour
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x0007EA3C File Offset: 0x0007CC3C
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpot()
		{
			Il2CppClassPointerStore<LandingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr);
			LandingSpot.NativeFieldInfoPtr_landingChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landingChild");
			LandingSpot.NativeFieldInfoPtr_landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landing");
			LandingSpot.NativeFieldInfoPtr_lerpCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "lerpCounter");
			LandingSpot.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_controller");
			LandingSpot.NativeFieldInfoPtr__idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_idle");
			LandingSpot.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_thisT");
			LandingSpot.NativeFieldInfoPtr__gotcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_gotcha");
			LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663700);
			LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663701);
			LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663702);
			LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663703);
			LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663704);
			LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663705);
			LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663706);
			LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663707);
			LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663708);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0007EBAC File Offset: 0x0007CDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74488, XrefRangeEnd = 74504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0007EBE0 File Offset: 0x0007CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74504, XrefRangeEnd = 74547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0007EC14 File Offset: 0x0007CE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74547, XrefRangeEnd = 74589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0007EC48 File Offset: 0x0007CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74589, XrefRangeEnd = 74592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StraightenBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0007EC7C File Offset: 0x0007CE7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74607, RefRangeEnd = 74608, XrefRangeStart = 74592, XrefRangeEnd = 74607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74613, RefRangeEnd = 74618, XrefRangeStart = 74608, XrefRangeEnd = 74613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetFlockChild(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0007ED0C File Offset: 0x0007CF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74618, XrefRangeEnd = 74640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0007ED40 File Offset: 0x0007CF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74640, XrefRangeEnd = 74665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFlockChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0007ED74 File Offset: 0x0007CF74
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004EEE File Offset: 0x000030EE
		public LandingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0007EDB0 File Offset: 0x0007CFB0
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004EF7 File Offset: 0x000030F7
		public unsafe FlockChild landingChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004F16 File Offset: 0x00003116
		public unsafe bool landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0007EE08 File Offset: 0x0007D008
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004F31 File Offset: 0x00003131
		public unsafe int lerpCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0007EE30 File Offset: 0x0007D030
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004F4C File Offset: 0x0000314C
		public unsafe LandingSpotController _controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0007EE60 File Offset: 0x0007D060
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004F6B File Offset: 0x0000316B
		public unsafe bool _idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0007EE88 File Offset: 0x0007D088
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004F86 File Offset: 0x00003186
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0007EEB8 File Offset: 0x0007D0B8
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00004FA5 File Offset: 0x000031A5
		public unsafe bool _gotcha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha)) = value;
			}
		}

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_landingChild;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_landing;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_lerpCounter;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr__controller;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr__idle;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr__gotcha;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_StraightenBird_Public_Void_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_RotateBird_Public_Void_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B4 RID: 1972
		[ObfuscatedName("LandingSpot+<GetFlockChild>d__12")]
		public sealed class _GetFlockChild_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600B9D3 RID: 47571 RVA: 0x002E1D00 File Offset: 0x002DFF00
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlockChild_d__12()
			{
				Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "<GetFlockChild>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr);
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>1__state");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>2__current");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "minDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "maxDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>4__this");
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663709);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663710);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663711);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663712);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663713);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663714);
			}

			// Token: 0x0600B9D4 RID: 47572 RVA: 0x002E1E08 File Offset: 0x002E0008
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlockChild_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9D5 RID: 47573 RVA: 0x002E1E50 File Offset: 0x002E0050
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9D6 RID: 47574 RVA: 0x002E1E84 File Offset: 0x002E0084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74449, XrefRangeEnd = 74483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700395A RID: 14682
			// (get) Token: 0x0600B9D7 RID: 47575 RVA: 0x002E1EC0 File Offset: 0x002E00C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9D8 RID: 47576 RVA: 0x002E1F00 File Offset: 0x002E0100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74483, XrefRangeEnd = 74488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700395B RID: 14683
			// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x002E1F34 File Offset: 0x002E0134
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9DA RID: 47578 RVA: 0x0005AD95 File Offset: 0x00058F95
			public _GetFlockChild_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003955 RID: 14677
			// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x002E1F74 File Offset: 0x002E0174
			// (set) Token: 0x0600B9DC RID: 47580 RVA: 0x0005AD9E File Offset: 0x00058F9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003956 RID: 14678
			// (get) Token: 0x0600B9DD RID: 47581 RVA: 0x002E1F9C File Offset: 0x002E019C
			// (set) Token: 0x0600B9DE RID: 47582 RVA: 0x0005ADB9 File Offset: 0x00058FB9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003957 RID: 14679
			// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002E1FCC File Offset: 0x002E01CC
			// (set) Token: 0x0600B9E0 RID: 47584 RVA: 0x0005ADD8 File Offset: 0x00058FD8
			public unsafe float minDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay)) = value;
				}
			}

			// Token: 0x17003958 RID: 14680
			// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002E1FF4 File Offset: 0x002E01F4
			// (set) Token: 0x0600B9E2 RID: 47586 RVA: 0x0005ADF3 File Offset: 0x00058FF3
			public unsafe float maxDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay)) = value;
				}
			}

			// Token: 0x17003959 RID: 14681
			// (get) Token: 0x0600B9E3 RID: 47587 RVA: 0x002E201C File Offset: 0x002E021C
			// (set) Token: 0x0600B9E4 RID: 47588 RVA: 0x0005AE0E File Offset: 0x0005900E
			public unsafe LandingSpot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D56 RID: 32086
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D57 RID: 32087
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D58 RID: 32088
			private static readonly IntPtr NativeFieldInfoPtr_minDelay;

			// Token: 0x04007D59 RID: 32089
			private static readonly IntPtr NativeFieldInfoPtr_maxDelay;

			// Token: 0x04007D5A RID: 32090
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D5B RID: 32091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D5C RID: 32092
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D5D RID: 32093
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D5E RID: 32094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D5F RID: 32095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D60 RID: 32096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
