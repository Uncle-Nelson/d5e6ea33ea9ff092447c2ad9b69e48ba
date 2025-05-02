using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EA RID: 1514
	public static class ItemSerializers : Object
	{
		// Token: 0x0600841F RID: 33823 RVA: 0x002312F8 File Offset: 0x0022F4F8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSerializers()
		{
			Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSerializers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr);
			ItemSerializers.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, "DEBUG");
			ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679812);
			ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679813);
			ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679814);
			ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679815);
			ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679816);
			ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679817);
			ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679818);
			ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679819);
			ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679820);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679821);
			ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679822);
			ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679823);
			ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679824);
			ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679825);
			ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679826);
			ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679827);
			ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679828);
			ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679829);
			ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679830);
			ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679831);
			ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679832);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679833);
			ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679834);
			ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679835);
			ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679836);
			ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679837);
			ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679838);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679839);
			ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679840);
			ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679841);
			ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679842);
			ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679843);
			ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679844);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679845);
			ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679846);
			ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679847);
			ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679848);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x00231620 File Offset: 0x0022F820
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 248220, RefRangeEnd = 248232, XrefRangeStart = 248132, XrefRangeEnd = 248220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance Read(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x00231664 File Offset: 0x0022F864
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 248254, RefRangeEnd = 248336, XrefRangeStart = 248232, XrefRangeEnd = 248254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x002316AC File Offset: 0x0022F8AC
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 248337, RefRangeEnd = 248386, XrefRangeStart = 248336, XrefRangeEnd = 248337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance ReadItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x002316F0 File Offset: 0x0022F8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248386, XrefRangeEnd = 248390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance DirectReadItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00231734 File Offset: 0x0022F934
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 248414, RefRangeEnd = 248420, XrefRangeStart = 248390, XrefRangeEnd = 248414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStorableItemInstance(this Writer writer, StorableItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x0023177C File Offset: 0x0022F97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 248422, RefRangeEnd = 248425, XrefRangeStart = 248420, XrefRangeEnd = 248422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance ReadStorableItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x002317C0 File Offset: 0x0022F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248425, XrefRangeEnd = 248434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance DirectReadStorableItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x00231804 File Offset: 0x0022FA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248434, XrefRangeEnd = 248444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCashInstance(this Writer writer, CashInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0023184C File Offset: 0x0022FA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248444, XrefRangeEnd = 248446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance ReadCashInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x00231890 File Offset: 0x0022FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248446, XrefRangeEnd = 248457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance DirectReadCashInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x002318D4 File Offset: 0x0022FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248457, XrefRangeEnd = 248463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteQualityItemInstance(this Writer writer, QualityItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x0023191C File Offset: 0x0022FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248463, XrefRangeEnd = 248465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance ReadQualityItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x00231960 File Offset: 0x0022FB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248465, XrefRangeEnd = 248474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance DirectReadQualityItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x002319A4 File Offset: 0x0022FBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248474, XrefRangeEnd = 248484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteClothingInstance(this Writer writer, ClothingInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x002319EC File Offset: 0x0022FBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248484, XrefRangeEnd = 248486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance ReadClothingInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr3) : null;
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x00231A30 File Offset: 0x0022FC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248486, XrefRangeEnd = 248495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance DirectReadClothingInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr3) : null;
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x00231A74 File Offset: 0x0022FC74
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 248525, RefRangeEnd = 248541, XrefRangeStart = 248495, XrefRangeEnd = 248525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x00231ABC File Offset: 0x0022FCBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248543, RefRangeEnd = 248548, XrefRangeStart = 248541, XrefRangeEnd = 248543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x00231B00 File Offset: 0x0022FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248548, XrefRangeEnd = 248559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance DirectReadProductItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x00231B44 File Offset: 0x0022FD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248559, XrefRangeEnd = 248570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWeedInstance(this Writer writer, WeedInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x00231B8C File Offset: 0x0022FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248570, XrefRangeEnd = 248572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance ReadWeedInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr3) : null;
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x00231BD0 File Offset: 0x0022FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248572, XrefRangeEnd = 248583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance DirectReadWeedInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr3) : null;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x00231C14 File Offset: 0x0022FE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248583, XrefRangeEnd = 248594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteMethInstance(this Writer writer, MethInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x00231C5C File Offset: 0x0022FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248594, XrefRangeEnd = 248596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance ReadMethInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr3) : null;
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x00231CA0 File Offset: 0x0022FEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248596, XrefRangeEnd = 248607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance DirectReadMethInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr3) : null;
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x00231CE4 File Offset: 0x0022FEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248607, XrefRangeEnd = 248618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCocaineInstance(this Writer writer, CocaineInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600843A RID: 33850 RVA: 0x00231D2C File Offset: 0x0022FF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248618, XrefRangeEnd = 248620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance ReadCocaineInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr3) : null;
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x00231D70 File Offset: 0x0022FF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248620, XrefRangeEnd = 248631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance DirectReadCocaineInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr3) : null;
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x00231DB4 File Offset: 0x0022FFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248631, XrefRangeEnd = 248641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteIntegerItemInstance(this Writer writer, IntegerItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x00231DFC File Offset: 0x0022FFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248641, XrefRangeEnd = 248643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance ReadIntegerItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x00231E40 File Offset: 0x00230040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248643, XrefRangeEnd = 248652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance DirectReadIntegerItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x00231E84 File Offset: 0x00230084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248652, XrefRangeEnd = 248662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWateringCanInstance(this Writer writer, WateringCanInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x00231ECC File Offset: 0x002300CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248662, XrefRangeEnd = 248664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance ReadWateringCanInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr3) : null;
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x00231F10 File Offset: 0x00230110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248664, XrefRangeEnd = 248674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance DirectReadWateringCanInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr3) : null;
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x00231F54 File Offset: 0x00230154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248674, XrefRangeEnd = 248706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTrashGrabberInstance(this Writer writer, TrashGrabberInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x00231F9C File Offset: 0x0023019C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248706, XrefRangeEnd = 248708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance ReadTrashGrabberInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr3) : null;
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x00231FE0 File Offset: 0x002301E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248708, XrefRangeEnd = 248743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance DirectReadTrashGrabberInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr3) : null;
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x0003EBCB File Offset: 0x0003CDCB
		public ItemSerializers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F6 RID: 10230
		// (get) Token: 0x06008446 RID: 33862 RVA: 0x00232024 File Offset: 0x00230224
		// (set) Token: 0x06008447 RID: 33863 RVA: 0x0003EBD4 File Offset: 0x0003CDD4
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x040059ED RID: 23021
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040059EE RID: 23022
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0;

		// Token: 0x040059EF RID: 23023
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0;

		// Token: 0x040059F0 RID: 23024
		private static readonly IntPtr NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0;

		// Token: 0x040059F1 RID: 23025
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0;

		// Token: 0x040059F2 RID: 23026
		private static readonly IntPtr NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0;

		// Token: 0x040059F3 RID: 23027
		private static readonly IntPtr NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0;

		// Token: 0x040059F4 RID: 23028
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0;

		// Token: 0x040059F5 RID: 23029
		private static readonly IntPtr NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0;

		// Token: 0x040059F6 RID: 23030
		private static readonly IntPtr NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0;

		// Token: 0x040059F7 RID: 23031
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0;

		// Token: 0x040059F8 RID: 23032
		private static readonly IntPtr NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0;

		// Token: 0x040059F9 RID: 23033
		private static readonly IntPtr NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0;

		// Token: 0x040059FA RID: 23034
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0;

		// Token: 0x040059FB RID: 23035
		private static readonly IntPtr NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0;

		// Token: 0x040059FC RID: 23036
		private static readonly IntPtr NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0;

		// Token: 0x040059FD RID: 23037
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0;

		// Token: 0x040059FE RID: 23038
		private static readonly IntPtr NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0;

		// Token: 0x040059FF RID: 23039
		private static readonly IntPtr NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0;

		// Token: 0x04005A00 RID: 23040
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0;

		// Token: 0x04005A01 RID: 23041
		private static readonly IntPtr NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0;

		// Token: 0x04005A02 RID: 23042
		private static readonly IntPtr NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0;

		// Token: 0x04005A03 RID: 23043
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0;

		// Token: 0x04005A04 RID: 23044
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0;

		// Token: 0x04005A05 RID: 23045
		private static readonly IntPtr NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0;

		// Token: 0x04005A06 RID: 23046
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0;

		// Token: 0x04005A07 RID: 23047
		private static readonly IntPtr NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0;

		// Token: 0x04005A08 RID: 23048
		private static readonly IntPtr NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0;

		// Token: 0x04005A09 RID: 23049
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0;

		// Token: 0x04005A0A RID: 23050
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0;

		// Token: 0x04005A0B RID: 23051
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0;

		// Token: 0x04005A0C RID: 23052
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0;

		// Token: 0x04005A0D RID: 23053
		private static readonly IntPtr NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0;

		// Token: 0x04005A0E RID: 23054
		private static readonly IntPtr NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0;

		// Token: 0x04005A0F RID: 23055
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0;

		// Token: 0x04005A10 RID: 23056
		private static readonly IntPtr NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0;

		// Token: 0x04005A11 RID: 23057
		private static readonly IntPtr NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0;

		// Token: 0x04005A12 RID: 23058
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0;
	}
}
