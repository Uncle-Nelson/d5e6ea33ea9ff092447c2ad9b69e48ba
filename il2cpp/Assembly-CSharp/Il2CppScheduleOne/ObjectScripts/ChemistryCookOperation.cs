using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000740 RID: 1856
	public class ChemistryCookOperation : Il2CppSystem.Object
	{
		// Token: 0x0600AB62 RID: 43874 RVA: 0x002AC67C File Offset: 0x002AA87C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryCookOperation()
		{
			Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "ChemistryCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr);
			ChemistryCookOperation.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "recipe");
			ChemistryCookOperation.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "RecipeID");
			ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "ProductQuality");
			ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "StartLiquidColor");
			ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "LiquidLevel");
			ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "CurrentTime");
			ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684316);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684317);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684318);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684319);
			ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684320);
			ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684321);
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x0600AB63 RID: 43875 RVA: 0x002AC79C File Offset: 0x002AA99C
		public unsafe StationRecipe Recipe
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 297415, RefRangeEnd = 297426, XrefRangeStart = 297397, XrefRangeEnd = 297415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x002AC7DC File Offset: 0x002AA9DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297429, RefRangeEnd = 297431, XrefRangeStart = 297426, XrefRangeEnd = 297429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x002AC860 File Offset: 0x002AAA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297433, RefRangeEnd = 297434, XrefRangeStart = 297431, XrefRangeEnd = 297433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x002AC8E4 File Offset: 0x002AAAE4
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x002AC920 File Offset: 0x002AAB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297434, XrefRangeEnd = 297435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Progress(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x002AC960 File Offset: 0x002AAB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297435, XrefRangeEnd = 297438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Recipe_b__2_0(StationRecipe r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x000545D3 File Offset: 0x000527D3
		public ChemistryCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600AB6A RID: 43882 RVA: 0x002AC9B0 File Offset: 0x002AABB0
		// (set) Token: 0x0600AB6B RID: 43883 RVA: 0x000545DC File Offset: 0x000527DC
		public unsafe StationRecipe recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600AB6C RID: 43884 RVA: 0x002AC9E0 File Offset: 0x002AABE0
		// (set) Token: 0x0600AB6D RID: 43885 RVA: 0x000545FB File Offset: 0x000527FB
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600AB6E RID: 43886 RVA: 0x002ACA08 File Offset: 0x002AAC08
		// (set) Token: 0x0600AB6F RID: 43887 RVA: 0x0005461A File Offset: 0x0005281A
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x002ACA30 File Offset: 0x002AAC30
		// (set) Token: 0x0600AB71 RID: 43889 RVA: 0x00054635 File Offset: 0x00052835
		public unsafe Color StartLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600AB72 RID: 43890 RVA: 0x002ACA58 File Offset: 0x002AAC58
		// (set) Token: 0x0600AB73 RID: 43891 RVA: 0x00054650 File Offset: 0x00052850
		public unsafe float LiquidLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600AB74 RID: 43892 RVA: 0x002ACA80 File Offset: 0x002AAC80
		// (set) Token: 0x0600AB75 RID: 43893 RVA: 0x0005466B File Offset: 0x0005286B
		public unsafe int CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x04007323 RID: 29475
		private static readonly IntPtr NativeFieldInfoPtr_recipe;

		// Token: 0x04007324 RID: 29476
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04007325 RID: 29477
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04007326 RID: 29478
		private static readonly IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x04007327 RID: 29479
		private static readonly IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x04007328 RID: 29480
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x04007329 RID: 29481
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x0400732A RID: 29482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0;

		// Token: 0x0400732B RID: 29483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0;

		// Token: 0x0400732C RID: 29484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400732D RID: 29485
		private static readonly IntPtr NativeMethodInfoPtr_Progress_Public_Void_Int32_0;

		// Token: 0x0400732E RID: 29486
		private static readonly IntPtr NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0;
	}
}
