using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x0200078B RID: 1931
	public class TrafficLight : MonoBehaviour
	{
		// Token: 0x0600B6DD RID: 46813 RVA: 0x002D612C File Offset: 0x002D432C
		// Note: this type is marked as 'beforefieldinit'.
		static TrafficLight()
		{
			Il2CppClassPointerStore<TrafficLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "TrafficLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr);
			TrafficLight.NativeFieldInfoPtr_amberTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "amberTime");
			TrafficLight.NativeFieldInfoPtr_redMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redMesh");
			TrafficLight.NativeFieldInfoPtr_orangeMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeMesh");
			TrafficLight.NativeFieldInfoPtr_greenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenMesh");
			TrafficLight.NativeFieldInfoPtr_redOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOn_Mat");
			TrafficLight.NativeFieldInfoPtr_redOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "redOff_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOn_Mat");
			TrafficLight.NativeFieldInfoPtr_orangeOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "orangeOff_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOn_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOn_Mat");
			TrafficLight.NativeFieldInfoPtr_greenOff_Mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "greenOff_Mat");
			TrafficLight.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "state");
			TrafficLight.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, "appliedState");
			TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685764);
			TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685765);
			TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685766);
			TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr, 100685767);
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x002D629C File Offset: 0x002D449C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311420, RefRangeEnd = 311422, XrefRangeStart = 311420, XrefRangeEnd = 311422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x002D62D8 File Offset: 0x002D44D8
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x002D6314 File Offset: 0x002D4514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311974, XrefRangeEnd = 311978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrafficLight.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x002D6350 File Offset: 0x002D4550
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrafficLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrafficLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrafficLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00059D4E File Offset: 0x00057F4E
		public TrafficLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038B7 RID: 14519
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x002D638C File Offset: 0x002D458C
		// (set) Token: 0x0600B6E4 RID: 46820 RVA: 0x00059D57 File Offset: 0x00057F57
		public unsafe static float amberTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrafficLight.NativeFieldInfoPtr_amberTime, (void*)(&value));
			}
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x002D63A8 File Offset: 0x002D45A8
		// (set) Token: 0x0600B6E6 RID: 46822 RVA: 0x00059D65 File Offset: 0x00057F65
		public unsafe MeshRenderer redMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x002D63D8 File Offset: 0x002D45D8
		// (set) Token: 0x0600B6E8 RID: 46824 RVA: 0x00059D84 File Offset: 0x00057F84
		public unsafe MeshRenderer orangeMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x0600B6E9 RID: 46825 RVA: 0x002D6408 File Offset: 0x002D4608
		// (set) Token: 0x0600B6EA RID: 46826 RVA: 0x00059DA3 File Offset: 0x00057FA3
		public unsafe MeshRenderer greenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600B6EB RID: 46827 RVA: 0x002D6438 File Offset: 0x002D4638
		// (set) Token: 0x0600B6EC RID: 46828 RVA: 0x00059DC2 File Offset: 0x00057FC2
		public unsafe Material redOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600B6ED RID: 46829 RVA: 0x002D6468 File Offset: 0x002D4668
		// (set) Token: 0x0600B6EE RID: 46830 RVA: 0x00059DE1 File Offset: 0x00057FE1
		public unsafe Material redOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_redOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600B6EF RID: 46831 RVA: 0x002D6498 File Offset: 0x002D4698
		// (set) Token: 0x0600B6F0 RID: 46832 RVA: 0x00059E00 File Offset: 0x00058000
		public unsafe Material orangeOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600B6F1 RID: 46833 RVA: 0x002D64C8 File Offset: 0x002D46C8
		// (set) Token: 0x0600B6F2 RID: 46834 RVA: 0x00059E1F File Offset: 0x0005801F
		public unsafe Material orangeOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_orangeOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600B6F3 RID: 46835 RVA: 0x002D64F8 File Offset: 0x002D46F8
		// (set) Token: 0x0600B6F4 RID: 46836 RVA: 0x00059E3E File Offset: 0x0005803E
		public unsafe Material greenOn_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOn_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600B6F5 RID: 46837 RVA: 0x002D6528 File Offset: 0x002D4728
		// (set) Token: 0x0600B6F6 RID: 46838 RVA: 0x00059E5D File Offset: 0x0005805D
		public unsafe Material greenOff_Mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_greenOff_Mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x002D6558 File Offset: 0x002D4758
		// (set) Token: 0x0600B6F8 RID: 46840 RVA: 0x00059E7C File Offset: 0x0005807C
		public unsafe TrafficLight.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600B6F9 RID: 46841 RVA: 0x002D6580 File Offset: 0x002D4780
		// (set) Token: 0x0600B6FA RID: 46842 RVA: 0x00059E97 File Offset: 0x00058097
		public unsafe TrafficLight.State appliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrafficLight.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x04007B28 RID: 31528
		private static readonly IntPtr NativeFieldInfoPtr_amberTime;

		// Token: 0x04007B29 RID: 31529
		private static readonly IntPtr NativeFieldInfoPtr_redMesh;

		// Token: 0x04007B2A RID: 31530
		private static readonly IntPtr NativeFieldInfoPtr_orangeMesh;

		// Token: 0x04007B2B RID: 31531
		private static readonly IntPtr NativeFieldInfoPtr_greenMesh;

		// Token: 0x04007B2C RID: 31532
		private static readonly IntPtr NativeFieldInfoPtr_redOn_Mat;

		// Token: 0x04007B2D RID: 31533
		private static readonly IntPtr NativeFieldInfoPtr_redOff_Mat;

		// Token: 0x04007B2E RID: 31534
		private static readonly IntPtr NativeFieldInfoPtr_orangeOn_Mat;

		// Token: 0x04007B2F RID: 31535
		private static readonly IntPtr NativeFieldInfoPtr_orangeOff_Mat;

		// Token: 0x04007B30 RID: 31536
		private static readonly IntPtr NativeFieldInfoPtr_greenOn_Mat;

		// Token: 0x04007B31 RID: 31537
		private static readonly IntPtr NativeFieldInfoPtr_greenOff_Mat;

		// Token: 0x04007B32 RID: 31538
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04007B33 RID: 31539
		private static readonly IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x04007B34 RID: 31540
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007B35 RID: 31541
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007B36 RID: 31542
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_0;

		// Token: 0x04007B37 RID: 31543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0A RID: 3082
		[OriginalName("Assembly-CSharp.dll", "", "State")]
		public enum State
		{
			// Token: 0x0400963D RID: 38461
			Red,
			// Token: 0x0400963E RID: 38462
			Orange,
			// Token: 0x0400963F RID: 38463
			Green
		}
	}
}
