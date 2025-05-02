using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	public class RouteListData : Object
	{
		// Token: 0x06002FEC RID: 12268 RVA: 0x00108F94 File Offset: 0x00107194
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListData()
		{
			Il2CppClassPointerStore<RouteListData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RouteListData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListData>.NativeClassPtr);
			RouteListData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, "Routes");
			RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListData>.NativeClassPtr, 100668795);
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00108FEC File Offset: 0x001071EC
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17913, RefRangeEnd = 18090, XrefRangeStart = 17913, XrefRangeEnd = 18090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData(List<AdvancedTransitRouteData> routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListData.NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0001967D File Offset: 0x0001787D
		public RouteListData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x00109038 File Offset: 0x00107238
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x00019686 File Offset: 0x00017886
		public unsafe List<AdvancedTransitRouteData> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRouteData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_AdvancedTransitRouteData_0;
	}
}
