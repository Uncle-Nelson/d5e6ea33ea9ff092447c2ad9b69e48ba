using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000675 RID: 1653
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x0600937F RID: 37759 RVA: 0x0025F6C0 File Offset: 0x0025D8C0
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceDialogueRenderer()
		{
			Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "WorldspaceDialogueRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr);
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "FadeDist");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<ShownText>k__BackingField");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "MaxRange");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "BaseScale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Scale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Padding");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "WorldSpaceOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Canvas");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CanvasGroup");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Background");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Text");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Anim");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "localOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CurrentOpacity");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "hideCoroutine");
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681584);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681585);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681586);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681587);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681588);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681589);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681590);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681591);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681592);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681593);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681594);
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x0025F8F8 File Offset: 0x0025DAF8
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x0025F930 File Offset: 0x0025DB30
		public unsafe string ShownText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x0025F974 File Offset: 0x0025DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265736, XrefRangeEnd = 265741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x0025F9A8 File Offset: 0x0025DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265741, XrefRangeEnd = 265772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x0025F9DC File Offset: 0x0025DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265772, XrefRangeEnd = 265773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x0025FA10 File Offset: 0x0025DC10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265806, RefRangeEnd = 265808, XrefRangeStart = 265773, XrefRangeEnd = 265806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x0025FA44 File Offset: 0x0025DC44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265832, RefRangeEnd = 265836, XrefRangeStart = 265808, XrefRangeEnd = 265832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowText(string text, float duration = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x0025FA94 File Offset: 0x0025DC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265841, RefRangeEnd = 265843, XrefRangeStart = 265836, XrefRangeEnd = 265841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x0025FAC8 File Offset: 0x0025DCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265846, RefRangeEnd = 265847, XrefRangeStart = 265843, XrefRangeEnd = 265846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpacity(float op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x0025FB08 File Offset: 0x0025DD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265847, XrefRangeEnd = 265855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceDialogueRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x0025FB44 File Offset: 0x0025DD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265855, XrefRangeEnd = 265860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x00047780 File Offset: 0x00045980
		public WorldspaceDialogueRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x0600938C RID: 37772 RVA: 0x0025FB90 File Offset: 0x0025DD90
		// (set) Token: 0x0600938D RID: 37773 RVA: 0x00047789 File Offset: 0x00045989
		public unsafe static float FadeDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&value));
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x0025FBAC File Offset: 0x0025DDAC
		// (set) Token: 0x0600938F RID: 37775 RVA: 0x00047797 File Offset: 0x00045997
		public unsafe string _ShownText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x06009390 RID: 37776 RVA: 0x0025FBD4 File Offset: 0x0025DDD4
		// (set) Token: 0x06009391 RID: 37777 RVA: 0x000477B6 File Offset: 0x000459B6
		public unsafe float MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange)) = value;
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x06009392 RID: 37778 RVA: 0x0025FBFC File Offset: 0x0025DDFC
		// (set) Token: 0x06009393 RID: 37779 RVA: 0x000477D1 File Offset: 0x000459D1
		public unsafe float BaseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale)) = value;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x06009394 RID: 37780 RVA: 0x0025FC24 File Offset: 0x0025DE24
		// (set) Token: 0x06009395 RID: 37781 RVA: 0x000477EC File Offset: 0x000459EC
		public unsafe AnimationCurve Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x06009396 RID: 37782 RVA: 0x0025FC54 File Offset: 0x0025DE54
		// (set) Token: 0x06009397 RID: 37783 RVA: 0x0004780B File Offset: 0x00045A0B
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x06009398 RID: 37784 RVA: 0x0025FC7C File Offset: 0x0025DE7C
		// (set) Token: 0x06009399 RID: 37785 RVA: 0x00047826 File Offset: 0x00045A26
		public unsafe Vector3 WorldSpaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset)) = value;
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x0600939A RID: 37786 RVA: 0x0025FCA4 File Offset: 0x0025DEA4
		// (set) Token: 0x0600939B RID: 37787 RVA: 0x00047841 File Offset: 0x00045A41
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x0600939C RID: 37788 RVA: 0x0025FCD4 File Offset: 0x0025DED4
		// (set) Token: 0x0600939D RID: 37789 RVA: 0x00047860 File Offset: 0x00045A60
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x0600939E RID: 37790 RVA: 0x0025FD04 File Offset: 0x0025DF04
		// (set) Token: 0x0600939F RID: 37791 RVA: 0x0004787F File Offset: 0x00045A7F
		public unsafe RectTransform Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x060093A0 RID: 37792 RVA: 0x0025FD34 File Offset: 0x0025DF34
		// (set) Token: 0x060093A1 RID: 37793 RVA: 0x0004789E File Offset: 0x00045A9E
		public unsafe TextMeshProUGUI Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x060093A2 RID: 37794 RVA: 0x0025FD64 File Offset: 0x0025DF64
		// (set) Token: 0x060093A3 RID: 37795 RVA: 0x000478BD File Offset: 0x00045ABD
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x060093A4 RID: 37796 RVA: 0x0025FD94 File Offset: 0x0025DF94
		// (set) Token: 0x060093A5 RID: 37797 RVA: 0x000478DC File Offset: 0x00045ADC
		public unsafe Vector3 localOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset)) = value;
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x060093A6 RID: 37798 RVA: 0x0025FDBC File Offset: 0x0025DFBC
		// (set) Token: 0x060093A7 RID: 37799 RVA: 0x000478F7 File Offset: 0x00045AF7
		public unsafe float CurrentOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity)) = value;
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x060093A8 RID: 37800 RVA: 0x0025FDE4 File Offset: 0x0025DFE4
		// (set) Token: 0x060093A9 RID: 37801 RVA: 0x00047912 File Offset: 0x00045B12
		public unsafe Coroutine hideCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006391 RID: 25489
		private static readonly IntPtr NativeFieldInfoPtr_FadeDist;

		// Token: 0x04006392 RID: 25490
		private static readonly IntPtr NativeFieldInfoPtr__ShownText_k__BackingField;

		// Token: 0x04006393 RID: 25491
		private static readonly IntPtr NativeFieldInfoPtr_MaxRange;

		// Token: 0x04006394 RID: 25492
		private static readonly IntPtr NativeFieldInfoPtr_BaseScale;

		// Token: 0x04006395 RID: 25493
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04006396 RID: 25494
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04006397 RID: 25495
		private static readonly IntPtr NativeFieldInfoPtr_WorldSpaceOffset;

		// Token: 0x04006398 RID: 25496
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006399 RID: 25497
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x0400639A RID: 25498
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x0400639B RID: 25499
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x0400639C RID: 25500
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400639D RID: 25501
		private static readonly IntPtr NativeFieldInfoPtr_localOffset;

		// Token: 0x0400639E RID: 25502
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpacity;

		// Token: 0x0400639F RID: 25503
		private static readonly IntPtr NativeFieldInfoPtr_hideCoroutine;

		// Token: 0x040063A0 RID: 25504
		private static readonly IntPtr NativeMethodInfoPtr_get_ShownText_Public_get_String_0;

		// Token: 0x040063A1 RID: 25505
		private static readonly IntPtr NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0;

		// Token: 0x040063A2 RID: 25506
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040063A3 RID: 25507
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040063A4 RID: 25508
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040063A5 RID: 25509
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Private_Void_0;

		// Token: 0x040063A6 RID: 25510
		private static readonly IntPtr NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0;

		// Token: 0x040063A7 RID: 25511
		private static readonly IntPtr NativeMethodInfoPtr_HideText_Public_Void_0;

		// Token: 0x040063A8 RID: 25512
		private static readonly IntPtr NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0;

		// Token: 0x040063A9 RID: 25513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063AA RID: 25514
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000B56 RID: 2902
		[ObfuscatedName("ScheduleOne.UI.WorldspaceDialogueRenderer+<<ShowText>g__Wait|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D9EE RID: 55790 RVA: 0x0033AF20 File Offset: 0x00339120
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique()
			{
				Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<<ShowText>g__Wait|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>1__state");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>2__current");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "dur");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>4__this");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681595);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681596);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681597);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681598);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681599);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681600);
			}

			// Token: 0x0600D9EF RID: 55791 RVA: 0x0033B014 File Offset: 0x00339214
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9F0 RID: 55792 RVA: 0x0033B05C File Offset: 0x0033925C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9F1 RID: 55793 RVA: 0x0033B090 File Offset: 0x00339290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265725, XrefRangeEnd = 265731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043A0 RID: 17312
			// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x0033B0CC File Offset: 0x003392CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9F3 RID: 55795 RVA: 0x0033B10C File Offset: 0x0033930C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265731, XrefRangeEnd = 265736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043A1 RID: 17313
			// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x0033B140 File Offset: 0x00339340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9F5 RID: 55797 RVA: 0x0006A237 File Offset: 0x00068437
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0600D9F6 RID: 55798 RVA: 0x0033B180 File Offset: 0x00339380
			// (set) Token: 0x0600D9F7 RID: 55799 RVA: 0x0006A240 File Offset: 0x00068440
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700439D RID: 17309
			// (get) Token: 0x0600D9F8 RID: 55800 RVA: 0x0033B1A8 File Offset: 0x003393A8
			// (set) Token: 0x0600D9F9 RID: 55801 RVA: 0x0006A25B File Offset: 0x0006845B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439E RID: 17310
			// (get) Token: 0x0600D9FA RID: 55802 RVA: 0x0033B1D8 File Offset: 0x003393D8
			// (set) Token: 0x0600D9FB RID: 55803 RVA: 0x0006A27A File Offset: 0x0006847A
			public unsafe float dur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur)) = value;
				}
			}

			// Token: 0x1700439F RID: 17311
			// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x0033B200 File Offset: 0x00339400
			// (set) Token: 0x0600D9FD RID: 55805 RVA: 0x0006A295 File Offset: 0x00068495
			public unsafe WorldspaceDialogueRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009259 RID: 37465
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400925A RID: 37466
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400925B RID: 37467
			private static readonly IntPtr NativeFieldInfoPtr_dur;

			// Token: 0x0400925C RID: 37468
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400925D RID: 37469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400925E RID: 37470
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400925F RID: 37471
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009260 RID: 37472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009261 RID: 37473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009262 RID: 37474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
