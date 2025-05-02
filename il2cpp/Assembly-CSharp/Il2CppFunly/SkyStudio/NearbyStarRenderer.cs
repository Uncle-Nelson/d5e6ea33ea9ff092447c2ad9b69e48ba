using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DC RID: 220
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x000A8B5C File Offset: 0x000A6D5C
		// Note: this type is marked as 'beforefieldinit'.
		static NearbyStarRenderer()
		{
			Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NearbyStarRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr);
			NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kMaxStars");
			NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kStarPointTextureWidth");
			NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kStarPaddingRadiusMultipler");
			NearbyStarRenderer.NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665348);
			NearbyStarRenderer.NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665349);
			NearbyStarRenderer.NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665350);
			NearbyStarRenderer.NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665351);
			NearbyStarRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665352);
			NearbyStarRenderer.NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665353);
			NearbyStarRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665354);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000A8C54 File Offset: 0x000A6E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88846, XrefRangeEnd = 88850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderTextureSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000A8CC0 File Offset: 0x000A6EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88850, XrefRangeEnd = 88873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref randomSeed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref starCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000A8D1C File Offset: 0x000A6F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88873, XrefRangeEnd = 88876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDebugTexture(RenderTexture rt, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000A8D70 File Offset: 0x000A6F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88900, RefRangeEnd = 88901, XrefRangeStart = 88876, XrefRangeEnd = 88900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(starTexKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &validStarPixelCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000A8DD0 File Offset: 0x000A6FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88901, XrefRangeEnd = 88906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator ComputeStarData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NearbyStarRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000A8E1C File Offset: 0x000A701C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88915, RefRangeEnd = 88917, XrefRangeStart = 88906, XrefRangeEnd = 88915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000A8E6C File Offset: 0x000A706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88917, XrefRangeEnd = 88918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NearbyStarRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0000AE27 File Offset: 0x00009027
		public NearbyStarRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x000A8EA8 File Offset: 0x000A70A8
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x0000AE30 File Offset: 0x00009030
		public unsafe static int kMaxStars
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars, (void*)(&value));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000A8EC4 File Offset: 0x000A70C4
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x0000AE3E File Offset: 0x0000903E
		public unsafe static int kStarPointTextureWidth
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth, (void*)(&value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000A8EE0 File Offset: 0x000A70E0
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0000AE4C File Offset: 0x0000904C
		public unsafe static float kStarPaddingRadiusMultipler
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler, (void*)(&value));
			}
		}

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr_kMaxStars;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_kStarPointTextureWidth;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_kStarPaddingRadiusMultipler;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084E RID: 2126
		[ObfuscatedName("Funly.SkyStudio.NearbyStarRenderer+<ComputeStarData>d__7")]
		public sealed class _ComputeStarData_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600C05C RID: 49244 RVA: 0x002F09F0 File Offset: 0x002EEBF0
			// Note: this type is marked as 'beforefieldinit'.
			static _ComputeStarData_d__7()
			{
				Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "<ComputeStarData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr);
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>1__state");
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>2__current");
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>4__this");
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665355);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665356);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665357);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665358);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665359);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665360);
			}

			// Token: 0x0600C05D RID: 49245 RVA: 0x002F0AD0 File Offset: 0x002EECD0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ComputeStarData_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C05E RID: 49246 RVA: 0x002F0B18 File Offset: 0x002EED18
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C05F RID: 49247 RVA: 0x002F0B4C File Offset: 0x002EED4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88783, XrefRangeEnd = 88841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003BED RID: 15341
			// (get) Token: 0x0600C060 RID: 49248 RVA: 0x002F0B88 File Offset: 0x002EED88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C061 RID: 49249 RVA: 0x002F0BC8 File Offset: 0x002EEDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88841, XrefRangeEnd = 88846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BEE RID: 15342
			// (get) Token: 0x0600C062 RID: 49250 RVA: 0x002F0BFC File Offset: 0x002EEDFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C063 RID: 49251 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
			public _ComputeStarData_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BEA RID: 15338
			// (get) Token: 0x0600C064 RID: 49252 RVA: 0x002F0C3C File Offset: 0x002EEE3C
			// (set) Token: 0x0600C065 RID: 49253 RVA: 0x0005DFC1 File Offset: 0x0005C1C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BEB RID: 15339
			// (get) Token: 0x0600C066 RID: 49254 RVA: 0x002F0C64 File Offset: 0x002EEE64
			// (set) Token: 0x0600C067 RID: 49255 RVA: 0x0005DFDC File Offset: 0x0005C1DC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BEC RID: 15340
			// (get) Token: 0x0600C068 RID: 49256 RVA: 0x002F0C94 File Offset: 0x002EEE94
			// (set) Token: 0x0600C069 RID: 49257 RVA: 0x0005DFFB File Offset: 0x0005C1FB
			public unsafe NearbyStarRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NearbyStarRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400823D RID: 33341
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400823E RID: 33342
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400823F RID: 33343
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008240 RID: 33344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008241 RID: 33345
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008242 RID: 33346
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008243 RID: 33347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008244 RID: 33348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008245 RID: 33349
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
