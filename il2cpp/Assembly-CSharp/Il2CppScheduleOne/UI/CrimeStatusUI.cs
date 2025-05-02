using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000655 RID: 1621
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x060090A7 RID: 37031 RVA: 0x002570EC File Offset: 0x002552EC
		// Note: this type is marked as 'beforefieldinit'.
		static CrimeStatusUI()
		{
			Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrimeStatusUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr);
			CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "SmallTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "LargeTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusContainer");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusGroup");
			CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "BodysearchLabel");
			CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "InvestigatingMask");
			CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "UnderArrestMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedDeadMask");
			CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "ArrestProgressContainer");
			CrimeStatusUI.NativeFieldInfoPtr_animateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "animateText");
			CrimeStatusUI.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "routine");
			CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681216);
			CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681217);
			CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681218);
			CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100681219);
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x0025725C File Offset: 0x0025545C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262253, RefRangeEnd = 262255, XrefRangeStart = 262212, XrefRangeEnd = 262253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090A9 RID: 37033 RVA: 0x00257290 File Offset: 0x00255490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262255, XrefRangeEnd = 262263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x002572C4 File Offset: 0x002554C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262268, RefRangeEnd = 262270, XrefRangeStart = 262263, XrefRangeEnd = 262268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Routine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x00257304 File Offset: 0x00255504
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrimeStatusUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x00045D90 File Offset: 0x00043F90
		public CrimeStatusUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x060090AD RID: 37037 RVA: 0x00257340 File Offset: 0x00255540
		// (set) Token: 0x060090AE RID: 37038 RVA: 0x00045D99 File Offset: 0x00043F99
		public unsafe static float SmallTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0025735C File Offset: 0x0025555C
		// (set) Token: 0x060090B0 RID: 37040 RVA: 0x00045DA7 File Offset: 0x00043FA7
		public unsafe static float LargeTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&value));
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x00257378 File Offset: 0x00255578
		// (set) Token: 0x060090B2 RID: 37042 RVA: 0x00045DB5 File Offset: 0x00043FB5
		public unsafe RectTransform CrimeStatusContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x060090B3 RID: 37043 RVA: 0x002573A8 File Offset: 0x002555A8
		// (set) Token: 0x060090B4 RID: 37044 RVA: 0x00045DD4 File Offset: 0x00043FD4
		public unsafe CanvasGroup CrimeStatusGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x060090B5 RID: 37045 RVA: 0x002573D8 File Offset: 0x002555D8
		// (set) Token: 0x060090B6 RID: 37046 RVA: 0x00045DF3 File Offset: 0x00043FF3
		public unsafe GameObject BodysearchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x060090B7 RID: 37047 RVA: 0x00257408 File Offset: 0x00255608
		// (set) Token: 0x060090B8 RID: 37048 RVA: 0x00045E12 File Offset: 0x00044012
		public unsafe Image InvestigatingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x060090B9 RID: 37049 RVA: 0x00257438 File Offset: 0x00255638
		// (set) Token: 0x060090BA RID: 37050 RVA: 0x00045E31 File Offset: 0x00044031
		public unsafe Image UnderArrestMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x060090BB RID: 37051 RVA: 0x00257468 File Offset: 0x00255668
		// (set) Token: 0x060090BC RID: 37052 RVA: 0x00045E50 File Offset: 0x00044050
		public unsafe Image WantedMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x060090BD RID: 37053 RVA: 0x00257498 File Offset: 0x00255698
		// (set) Token: 0x060090BE RID: 37054 RVA: 0x00045E6F File Offset: 0x0004406F
		public unsafe Image WantedDeadMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x060090BF RID: 37055 RVA: 0x002574C8 File Offset: 0x002556C8
		// (set) Token: 0x060090C0 RID: 37056 RVA: 0x00045E8E File Offset: 0x0004408E
		public unsafe GameObject ArrestProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x060090C1 RID: 37057 RVA: 0x002574F8 File Offset: 0x002556F8
		// (set) Token: 0x060090C2 RID: 37058 RVA: 0x00045EAD File Offset: 0x000440AD
		public unsafe bool animateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText)) = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x060090C3 RID: 37059 RVA: 0x00257520 File Offset: 0x00255720
		// (set) Token: 0x060090C4 RID: 37060 RVA: 0x00045EC8 File Offset: 0x000440C8
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061D2 RID: 25042
		private static readonly IntPtr NativeFieldInfoPtr_SmallTextSize;

		// Token: 0x040061D3 RID: 25043
		private static readonly IntPtr NativeFieldInfoPtr_LargeTextSize;

		// Token: 0x040061D4 RID: 25044
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusContainer;

		// Token: 0x040061D5 RID: 25045
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusGroup;

		// Token: 0x040061D6 RID: 25046
		private static readonly IntPtr NativeFieldInfoPtr_BodysearchLabel;

		// Token: 0x040061D7 RID: 25047
		private static readonly IntPtr NativeFieldInfoPtr_InvestigatingMask;

		// Token: 0x040061D8 RID: 25048
		private static readonly IntPtr NativeFieldInfoPtr_UnderArrestMask;

		// Token: 0x040061D9 RID: 25049
		private static readonly IntPtr NativeFieldInfoPtr_WantedMask;

		// Token: 0x040061DA RID: 25050
		private static readonly IntPtr NativeFieldInfoPtr_WantedDeadMask;

		// Token: 0x040061DB RID: 25051
		private static readonly IntPtr NativeFieldInfoPtr_ArrestProgressContainer;

		// Token: 0x040061DC RID: 25052
		private static readonly IntPtr NativeFieldInfoPtr_animateText;

		// Token: 0x040061DD RID: 25053
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x040061DE RID: 25054
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_0;

		// Token: 0x040061DF RID: 25055
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040061E0 RID: 25056
		private static readonly IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_0;

		// Token: 0x040061E1 RID: 25057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3D RID: 2877
		[ObfuscatedName("ScheduleOne.UI.CrimeStatusUI+<Routine>d__14")]
		public sealed class _Routine_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D892 RID: 55442 RVA: 0x00336E38 File Offset: 0x00335038
			// Note: this type is marked as 'beforefieldinit'.
			static _Routine_d__14()
			{
				Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "<Routine>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr);
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>1__state");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>2__current");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>4__this");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<lerpTime>5__2");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<t>5__3");
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681220);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681221);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681222);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681223);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681224);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100681225);
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x00336F40 File Offset: 0x00335140
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Routine_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D894 RID: 55444 RVA: 0x00336F88 File Offset: 0x00335188
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D895 RID: 55445 RVA: 0x00336FBC File Offset: 0x003351BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262190, XrefRangeEnd = 262207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700432C RID: 17196
			// (get) Token: 0x0600D896 RID: 55446 RVA: 0x00336FF8 File Offset: 0x003351F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x00337038 File Offset: 0x00335238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262207, XrefRangeEnd = 262212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700432D RID: 17197
			// (get) Token: 0x0600D898 RID: 55448 RVA: 0x0033706C File Offset: 0x0033526C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D899 RID: 55449 RVA: 0x000697A6 File Offset: 0x000679A6
			public _Routine_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004327 RID: 17191
			// (get) Token: 0x0600D89A RID: 55450 RVA: 0x003370AC File Offset: 0x003352AC
			// (set) Token: 0x0600D89B RID: 55451 RVA: 0x000697AF File Offset: 0x000679AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004328 RID: 17192
			// (get) Token: 0x0600D89C RID: 55452 RVA: 0x003370D4 File Offset: 0x003352D4
			// (set) Token: 0x0600D89D RID: 55453 RVA: 0x000697CA File Offset: 0x000679CA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004329 RID: 17193
			// (get) Token: 0x0600D89E RID: 55454 RVA: 0x00337104 File Offset: 0x00335304
			// (set) Token: 0x0600D89F RID: 55455 RVA: 0x000697E9 File Offset: 0x000679E9
			public unsafe CrimeStatusUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432A RID: 17194
			// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x00337134 File Offset: 0x00335334
			// (set) Token: 0x0600D8A1 RID: 55457 RVA: 0x00069808 File Offset: 0x00067A08
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x1700432B RID: 17195
			// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x0033715C File Offset: 0x0033535C
			// (set) Token: 0x0600D8A3 RID: 55459 RVA: 0x00069823 File Offset: 0x00067A23
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x0400918A RID: 37258
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400918B RID: 37259
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400918C RID: 37260
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400918D RID: 37261
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400918E RID: 37262
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x0400918F RID: 37263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009190 RID: 37264
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009191 RID: 37265
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009192 RID: 37266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009193 RID: 37267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009194 RID: 37268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
