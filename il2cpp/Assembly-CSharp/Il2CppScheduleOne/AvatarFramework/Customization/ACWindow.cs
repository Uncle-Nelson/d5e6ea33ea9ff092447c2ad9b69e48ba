using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000616 RID: 1558
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x0600898F RID: 35215 RVA: 0x002420C0 File Offset: 0x002402C0
		// Note: this type is marked as 'beforefieldinit'.
		static ACWindow()
		{
			Il2CppClassPointerStore<ACWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACWindow>.NativeClassPtr);
			ACWindow.NativeFieldInfoPtr_WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "WindowTitle");
			ACWindow.NativeFieldInfoPtr_Predecessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "Predecessor");
			ACWindow.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "TitleText");
			ACWindow.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "BackButton");
			ACWindow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680421);
			ACWindow.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680422);
			ACWindow.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680423);
			ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680424);
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x00242190 File Offset: 0x00240390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253748, XrefRangeEnd = 253768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x002421C4 File Offset: 0x002403C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x002421F8 File Offset: 0x002403F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253768, XrefRangeEnd = 253776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x0024222C File Offset: 0x0024042C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x00041AE8 File Offset: 0x0003FCE8
		public ACWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029E9 RID: 10729
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x00242268 File Offset: 0x00240468
		// (set) Token: 0x06008996 RID: 35222 RVA: 0x00041AF1 File Offset: 0x0003FCF1
		public unsafe string WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029EA RID: 10730
		// (get) Token: 0x06008997 RID: 35223 RVA: 0x00242290 File Offset: 0x00240490
		// (set) Token: 0x06008998 RID: 35224 RVA: 0x00041B10 File Offset: 0x0003FD10
		public unsafe ACWindow Predecessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x06008999 RID: 35225 RVA: 0x002422C0 File Offset: 0x002404C0
		// (set) Token: 0x0600899A RID: 35226 RVA: 0x00041B2F File Offset: 0x0003FD2F
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600899B RID: 35227 RVA: 0x002422F0 File Offset: 0x002404F0
		// (set) Token: 0x0600899C RID: 35228 RVA: 0x00041B4E File Offset: 0x0003FD4E
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D66 RID: 23910
		private static readonly IntPtr NativeFieldInfoPtr_WindowTitle;

		// Token: 0x04005D67 RID: 23911
		private static readonly IntPtr NativeFieldInfoPtr_Predecessor;

		// Token: 0x04005D68 RID: 23912
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04005D69 RID: 23913
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04005D6A RID: 23914
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005D6B RID: 23915
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005D6C RID: 23916
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005D6D RID: 23917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
