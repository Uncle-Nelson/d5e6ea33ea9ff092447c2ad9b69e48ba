using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Object;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Casino;
using ScheduleOne.Clothing;
using ScheduleOne.Combat;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.Economy;
using ScheduleOne.Employees;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Management;
using ScheduleOne.Messaging;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using ScheduleOne.Vision;
using UnityEngine;

namespace FishNet.Serializing.Generated
{
	// Token: 0x02000C65 RID: 3173
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedWriters___Internal
	{
		// Token: 0x06005887 RID: 22663 RVA: 0x001734AC File Offset: 0x001716AC
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
			GenericWriter<ItemInstance>.Write = new Action<Writer, ItemInstance>(ItemSerializers.WriteItemInstance);
			GenericWriter<StorableItemInstance>.Write = new Action<Writer, StorableItemInstance>(ItemSerializers.WriteStorableItemInstance);
			GenericWriter<CashInstance>.Write = new Action<Writer, CashInstance>(ItemSerializers.WriteCashInstance);
			GenericWriter<QualityItemInstance>.Write = new Action<Writer, QualityItemInstance>(ItemSerializers.WriteQualityItemInstance);
			GenericWriter<ClothingInstance>.Write = new Action<Writer, ClothingInstance>(ItemSerializers.WriteClothingInstance);
			GenericWriter<ProductItemInstance>.Write = new Action<Writer, ProductItemInstance>(ItemSerializers.WriteProductItemInstance);
			GenericWriter<WeedInstance>.Write = new Action<Writer, WeedInstance>(ItemSerializers.WriteWeedInstance);
			GenericWriter<MethInstance>.Write = new Action<Writer, MethInstance>(ItemSerializers.WriteMethInstance);
			GenericWriter<CocaineInstance>.Write = new Action<Writer, CocaineInstance>(ItemSerializers.WriteCocaineInstance);
			GenericWriter<IntegerItemInstance>.Write = new Action<Writer, IntegerItemInstance>(ItemSerializers.WriteIntegerItemInstance);
			GenericWriter<WateringCanInstance>.Write = new Action<Writer, WateringCanInstance>(ItemSerializers.WriteWateringCanInstance);
			GenericWriter<TrashGrabberInstance>.Write = new Action<Writer, TrashGrabberInstance>(ItemSerializers.WriteTrashGrabberInstance);
			GenericWriter<VisionEventReceipt>.Write = new Action<Writer, VisionEventReceipt>(GeneratedWriters___Internal.Write___ScheduleOne.Vision.VisionEventReceiptFishNet.Serializing.Generated);
			GenericWriter<PlayerVisualState.EVisualState>.Write = new Action<Writer, PlayerVisualState.EVisualState>(GeneratedWriters___Internal.Write___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generated);
			GenericWriter<VisionCone.EEventLevel>.Write = new Action<Writer, VisionCone.EEventLevel>(GeneratedWriters___Internal.Write___ScheduleOne.Vision.VisionCone/EEventLevelFishNet.Serializing.Generated);
			GenericWriter<ContractInfo>.Write = new Action<Writer, ContractInfo>(GeneratedWriters___Internal.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated);
			GenericWriter<ProductList>.Write = new Action<Writer, ProductList>(GeneratedWriters___Internal.Write___ScheduleOne.Product.ProductListFishNet.Serializing.Generated);
			GenericWriter<ProductList.Entry>.Write = new Action<Writer, ProductList.Entry>(GeneratedWriters___Internal.Write___ScheduleOne.Product.ProductList/EntryFishNet.Serializing.Generated);
			GenericWriter<EQuality>.Write = new Action<Writer, EQuality>(GeneratedWriters___Internal.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated);
			GenericWriter<List<ProductList.Entry>>.Write = new Action<Writer, List<ProductList.Entry>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.Product.ProductList/Entry>FishNet.Serializing.Generated);
			GenericWriter<QuestWindowConfig>.Write = new Action<Writer, QuestWindowConfig>(GeneratedWriters___Internal.Write___ScheduleOne.Quests.QuestWindowConfigFishNet.Serializing.Generated);
			GenericWriter<GameDateTime>.Write = new Action<Writer, GameDateTime>(GeneratedWriters___Internal.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated);
			GenericWriter<QuestManager.EQuestAction>.Write = new Action<Writer, QuestManager.EQuestAction>(GeneratedWriters___Internal.Write___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generated);
			GenericWriter<EQuestState>.Write = new Action<Writer, EQuestState>(GeneratedWriters___Internal.Write___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generated);
			GenericWriter<Impact>.Write = new Action<Writer, Impact>(GeneratedWriters___Internal.Write___ScheduleOne.Combat.ImpactFishNet.Serializing.Generated);
			GenericWriter<EImpactType>.Write = new Action<Writer, EImpactType>(GeneratedWriters___Internal.Write___ScheduleOne.Combat.EImpactTypeFishNet.Serializing.Generated);
			GenericWriter<LandVehicle>.Write = new Action<Writer, LandVehicle>(GeneratedWriters___Internal.Write___ScheduleOne.Vehicles.LandVehicleFishNet.Serializing.Generated);
			GenericWriter<CheckpointManager.ECheckpointLocation>.Write = new Action<Writer, CheckpointManager.ECheckpointLocation>(GeneratedWriters___Internal.Write___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generated);
			GenericWriter<Player>.Write = new Action<Writer, Player>(GeneratedWriters___Internal.Write___ScheduleOne.PlayerScripts.PlayerFishNet.Serializing.Generated);
			GenericWriter<List<string>>.Write = new Action<Writer, List<string>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated);
			GenericWriter<StringIntPair>.Write = new Action<Writer, StringIntPair>(GeneratedWriters___Internal.Write___ScheduleOne.DevUtilities.StringIntPairFishNet.Serializing.Generated);
			GenericWriter<StringIntPair[]>.Write = new Action<Writer, StringIntPair[]>(GeneratedWriters___Internal.Write___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generated);
			GenericWriter<Message>.Write = new Action<Writer, Message>(GeneratedWriters___Internal.Write___ScheduleOne.Messaging.MessageFishNet.Serializing.Generated);
			GenericWriter<Message.ESenderType>.Write = new Action<Writer, Message.ESenderType>(GeneratedWriters___Internal.Write___ScheduleOne.Messaging.Message/ESenderTypeFishNet.Serializing.Generated);
			GenericWriter<MessageChain>.Write = new Action<Writer, MessageChain>(GeneratedWriters___Internal.Write___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generated);
			GenericWriter<MSGConversationData>.Write = new Action<Writer, MSGConversationData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.MSGConversationDataFishNet.Serializing.Generated);
			GenericWriter<TextMessageData>.Write = new Action<Writer, TextMessageData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.TextMessageDataFishNet.Serializing.Generated);
			GenericWriter<TextMessageData[]>.Write = new Action<Writer, TextMessageData[]>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.TextMessageData[]FishNet.Serializing.Generated);
			GenericWriter<TextResponseData>.Write = new Action<Writer, TextResponseData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.TextResponseDataFishNet.Serializing.Generated);
			GenericWriter<TextResponseData[]>.Write = new Action<Writer, TextResponseData[]>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.TextResponseData[]FishNet.Serializing.Generated);
			GenericWriter<Response>.Write = new Action<Writer, Response>(GeneratedWriters___Internal.Write___ScheduleOne.Messaging.ResponseFishNet.Serializing.Generated);
			GenericWriter<List<Response>>.Write = new Action<Writer, List<Response>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generated);
			GenericWriter<List<NetworkObject>>.Write = new Action<Writer, List<NetworkObject>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generated);
			GenericWriter<AdvancedTransitRouteData>.Write = new Action<Writer, AdvancedTransitRouteData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.AdvancedTransitRouteDataFishNet.Serializing.Generated);
			GenericWriter<ManagementItemFilter.EMode>.Write = new Action<Writer, ManagementItemFilter.EMode>(GeneratedWriters___Internal.Write___ScheduleOne.Management.ManagementItemFilter/EModeFishNet.Serializing.Generated);
			GenericWriter<AdvancedTransitRouteData[]>.Write = new Action<Writer, AdvancedTransitRouteData[]>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generated);
			GenericWriter<ERank>.Write = new Action<Writer, ERank>(GeneratedWriters___Internal.Write___ScheduleOne.Levelling.ERankFishNet.Serializing.Generated);
			GenericWriter<FullRank>.Write = new Action<Writer, FullRank>(GeneratedWriters___Internal.Write___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generated);
			GenericWriter<PlayerData>.Write = new Action<Writer, PlayerData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.PlayerDataFishNet.Serializing.Generated);
			GenericWriter<VariableData>.Write = new Action<Writer, VariableData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.VariableDataFishNet.Serializing.Generated);
			GenericWriter<VariableData[]>.Write = new Action<Writer, VariableData[]>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.VariableData[]FishNet.Serializing.Generated);
			GenericWriter<AvatarSettings>.Write = new Action<Writer, AvatarSettings>(GeneratedWriters___Internal.Write___ScheduleOne.AvatarFramework.AvatarSettingsFishNet.Serializing.Generated);
			GenericWriter<Eye.EyeLidConfiguration>.Write = new Action<Writer, Eye.EyeLidConfiguration>(GeneratedWriters___Internal.Write___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generated);
			GenericWriter<AvatarSettings.LayerSetting>.Write = new Action<Writer, AvatarSettings.LayerSetting>(GeneratedWriters___Internal.Write___ScheduleOne.AvatarFramework.AvatarSettings/LayerSettingFishNet.Serializing.Generated);
			GenericWriter<List<AvatarSettings.LayerSetting>>.Write = new Action<Writer, List<AvatarSettings.LayerSetting>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generated);
			GenericWriter<AvatarSettings.AccessorySetting>.Write = new Action<Writer, AvatarSettings.AccessorySetting>(GeneratedWriters___Internal.Write___ScheduleOne.AvatarFramework.AvatarSettings/AccessorySettingFishNet.Serializing.Generated);
			GenericWriter<List<AvatarSettings.AccessorySetting>>.Write = new Action<Writer, List<AvatarSettings.AccessorySetting>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/AccessorySetting>FishNet.Serializing.Generated);
			GenericWriter<BasicAvatarSettings>.Write = new Action<Writer, BasicAvatarSettings>(GeneratedWriters___Internal.Write___ScheduleOne.AvatarFramework.Customization.BasicAvatarSettingsFishNet.Serializing.Generated);
			GenericWriter<PlayerCrimeData.EPursuitLevel>.Write = new Action<Writer, PlayerCrimeData.EPursuitLevel>(GeneratedWriters___Internal.Write___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generated);
			GenericWriter<Property>.Write = new Action<Writer, Property>(GeneratedWriters___Internal.Write___ScheduleOne.Property.PropertyFishNet.Serializing.Generated);
			GenericWriter<EEmployeeType>.Write = new Action<Writer, EEmployeeType>(GeneratedWriters___Internal.Write___ScheduleOne.Employees.EEmployeeTypeFishNet.Serializing.Generated);
			GenericWriter<EDealWindow>.Write = new Action<Writer, EDealWindow>(GeneratedWriters___Internal.Write___ScheduleOne.Economy.EDealWindowFishNet.Serializing.Generated);
			GenericWriter<HandoverScreen.EHandoverOutcome>.Write = new Action<Writer, HandoverScreen.EHandoverOutcome>(GeneratedWriters___Internal.Write___ScheduleOne.UI.Handover.HandoverScreen/EHandoverOutcomeFishNet.Serializing.Generated);
			GenericWriter<List<ItemInstance>>.Write = new Action<Writer, List<ItemInstance>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generated);
			GenericWriter<ScheduleOne.Persistence.Datas.CustomerData>.Write = new Action<Writer, ScheduleOne.Persistence.Datas.CustomerData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.CustomerDataFishNet.Serializing.Generated);
			GenericWriter<string[]>.Write = new Action<Writer, string[]>(GeneratedWriters___Internal.Write___System.String[]FishNet.Serializing.Generated);
			GenericWriter<float[]>.Write = new Action<Writer, float[]>(GeneratedWriters___Internal.Write___System.Single[]FishNet.Serializing.Generated);
			GenericWriter<EDrugType>.Write = new Action<Writer, EDrugType>(GeneratedWriters___Internal.Write___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generated);
			GenericWriter<GameData>.Write = new Action<Writer, GameData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.Datas.GameDataFishNet.Serializing.Generated);
			GenericWriter<GameSettings>.Write = new Action<Writer, GameSettings>(GeneratedWriters___Internal.Write___ScheduleOne.DevUtilities.GameSettingsFishNet.Serializing.Generated);
			GenericWriter<DeliveryInstance>.Write = new Action<Writer, DeliveryInstance>(GeneratedWriters___Internal.Write___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generated);
			GenericWriter<EDeliveryStatus>.Write = new Action<Writer, EDeliveryStatus>(GeneratedWriters___Internal.Write___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generated);
			GenericWriter<ExplosionData>.Write = new Action<Writer, ExplosionData>(GeneratedWriters___Internal.Write___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generated);
			GenericWriter<PlayingCard.ECardSuit>.Write = new Action<Writer, PlayingCard.ECardSuit>(GeneratedWriters___Internal.Write___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generated);
			GenericWriter<PlayingCard.ECardValue>.Write = new Action<Writer, PlayingCard.ECardValue>(GeneratedWriters___Internal.Write___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generated);
			GenericWriter<NetworkObject[]>.Write = new Action<Writer, NetworkObject[]>(GeneratedWriters___Internal.Write___FishNet.Object.NetworkObject[]FishNet.Serializing.Generated);
			GenericWriter<RTBGameController.EStage>.Write = new Action<Writer, RTBGameController.EStage>(GeneratedWriters___Internal.Write___ScheduleOne.Casino.RTBGameController/EStageFishNet.Serializing.Generated);
			GenericWriter<SlotMachine.ESymbol>.Write = new Action<Writer, SlotMachine.ESymbol>(GeneratedWriters___Internal.Write___ScheduleOne.Casino.SlotMachine/ESymbolFishNet.Serializing.Generated);
			GenericWriter<SlotMachine.ESymbol[]>.Write = new Action<Writer, SlotMachine.ESymbol[]>(GeneratedWriters___Internal.Write___ScheduleOne.Casino.SlotMachine/ESymbol[]FishNet.Serializing.Generated);
			GenericWriter<EDoorSide>.Write = new Action<Writer, EDoorSide>(GeneratedWriters___Internal.Write___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generated);
			GenericWriter<EVehicleColor>.Write = new Action<Writer, EVehicleColor>(GeneratedWriters___Internal.Write___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generated);
			GenericWriter<ParkData>.Write = new Action<Writer, ParkData>(GeneratedWriters___Internal.Write___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generated);
			GenericWriter<EParkingAlignment>.Write = new Action<Writer, EParkingAlignment>(GeneratedWriters___Internal.Write___ScheduleOne.Vehicles.EParkingAlignmentFishNet.Serializing.Generated);
			GenericWriter<TrashContentData>.Write = new Action<Writer, TrashContentData>(GeneratedWriters___Internal.Write___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generated);
			GenericWriter<int[]>.Write = new Action<Writer, int[]>(GeneratedWriters___Internal.Write___System.Int32[]FishNet.Serializing.Generated);
			GenericWriter<Coordinate>.Write = new Action<Writer, Coordinate>(GeneratedWriters___Internal.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated);
			GenericWriter<WeedAppearanceSettings>.Write = new Action<Writer, WeedAppearanceSettings>(GeneratedWriters___Internal.Write___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generated);
			GenericWriter<CocaineAppearanceSettings>.Write = new Action<Writer, CocaineAppearanceSettings>(GeneratedWriters___Internal.Write___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generated);
			GenericWriter<MethAppearanceSettings>.Write = new Action<Writer, MethAppearanceSettings>(GeneratedWriters___Internal.Write___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generated);
			GenericWriter<NewMixOperation>.Write = new Action<Writer, NewMixOperation>(GeneratedWriters___Internal.Write___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generated);
			GenericWriter<Recycler.EState>.Write = new Action<Writer, Recycler.EState>(GeneratedWriters___Internal.Write___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generated);
			GenericWriter<CoordinateProceduralTilePair>.Write = new Action<Writer, CoordinateProceduralTilePair>(GeneratedWriters___Internal.Write___ScheduleOne.Tiles.CoordinateProceduralTilePairFishNet.Serializing.Generated);
			GenericWriter<List<CoordinateProceduralTilePair>>.Write = new Action<Writer, List<CoordinateProceduralTilePair>>(GeneratedWriters___Internal.Write___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generated);
			GenericWriter<ChemistryCookOperation>.Write = new Action<Writer, ChemistryCookOperation>(GeneratedWriters___Internal.Write___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generated);
			GenericWriter<DryingOperation>.Write = new Action<Writer, DryingOperation>(GeneratedWriters___Internal.Write___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generated);
			GenericWriter<OvenCookOperation>.Write = new Action<Writer, OvenCookOperation>(GeneratedWriters___Internal.Write___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generated);
			GenericWriter<MixOperation>.Write = new Action<Writer, MixOperation>(GeneratedWriters___Internal.Write___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generated);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00173B2C File Offset: 0x00171D2C
		public static void Generated(this Writer writer, VisionEventReceipt value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteNetworkObject(value.TargetPlayer);
			writer.Write___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generated(value.State);
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x00173B84 File Offset: 0x00171D84
		public static void Generated(this Writer writer, PlayerVisualState.EVisualState value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x00173BA4 File Offset: 0x00171DA4
		public static void Generated(this Writer writer, VisionCone.EEventLevel value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x00173BC4 File Offset: 0x00171DC4
		public static void Generated(this Writer writer, ContractInfo value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteSingle(value.Payment, AutoPackType.Unpacked);
			writer.Write___ScheduleOne.Product.ProductListFishNet.Serializing.Generated(value.Products);
			writer.WriteString(value.DeliveryLocationGUID);
			writer.Write___ScheduleOne.Quests.QuestWindowConfigFishNet.Serializing.Generated(value.DeliveryWindow);
			writer.WriteBoolean(value.Expires);
			writer.WriteInt32(value.ExpiresAfter, AutoPackType.Packed);
			writer.WriteInt32(value.PickupScheduleIndex, AutoPackType.Packed);
			writer.WriteBoolean(value.IsCounterOffer);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x00173C98 File Offset: 0x00171E98
		public static void Generated(this Writer writer, ProductList value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.Product.ProductList/Entry>FishNet.Serializing.Generated(value.entries);
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00173CE0 File Offset: 0x00171EE0
		public static void Generated(this Writer writer, ProductList.Entry value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.ProductID);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value.Quality);
			writer.WriteInt32(value.Quantity, AutoPackType.Packed);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00173D50 File Offset: 0x00171F50
		public static void Generated(this Writer writer, EQuality value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00173D70 File Offset: 0x00171F70
		public static void List(this Writer writer, List<ProductList.Entry> value)
		{
			writer.WriteList<ProductList.Entry>(value);
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00173D8C File Offset: 0x00171F8C
		public static void Generated(this Writer writer, QuestWindowConfig value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteBoolean(value.IsEnabled);
			writer.WriteInt32(value.WindowStartTime, AutoPackType.Packed);
			writer.WriteInt32(value.WindowEndTime, AutoPackType.Packed);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00173E00 File Offset: 0x00172000
		public static void Generated(this Writer writer, GameDateTime value)
		{
			writer.WriteInt32(value.elapsedDays, AutoPackType.Packed);
			writer.WriteInt32(value.time, AutoPackType.Packed);
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00173E3C File Offset: 0x0017203C
		public static void Generated(this Writer writer, QuestManager.EQuestAction value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00173E5C File Offset: 0x0017205C
		public static void Generated(this Writer writer, EQuestState value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00173E7C File Offset: 0x0017207C
		public static void Generated(this Writer writer, Impact value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteVector3(value.HitPoint);
			writer.WriteVector3(value.ImpactForceDirection);
			writer.WriteSingle(value.ImpactForce, AutoPackType.Unpacked);
			writer.WriteSingle(value.ImpactDamage, AutoPackType.Unpacked);
			writer.Write___ScheduleOne.Combat.EImpactTypeFishNet.Serializing.Generated(value.ImpactType);
			writer.WriteNetworkObject(value.ImpactSource);
			writer.WriteInt32(value.ImpactID, AutoPackType.Packed);
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00173F40 File Offset: 0x00172140
		public static void Generated(this Writer writer, EImpactType value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00173F60 File Offset: 0x00172160
		public static void Generated(this Writer writer, LandVehicle value)
		{
			writer.WriteNetworkBehaviour(value);
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x00173F7C File Offset: 0x0017217C
		public static void Generated(this Writer writer, CheckpointManager.ECheckpointLocation value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x00173F9C File Offset: 0x0017219C
		public static void Generated(this Writer writer, Player value)
		{
			writer.WriteNetworkBehaviour(value);
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x00173FB8 File Offset: 0x001721B8
		public static void List(this Writer writer, List<string> value)
		{
			writer.WriteList<string>(value);
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00173FD4 File Offset: 0x001721D4
		public static void Generated(this Writer writer, StringIntPair value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.String);
			writer.WriteInt32(value.Int, AutoPackType.Packed);
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00174034 File Offset: 0x00172234
		public static void Generated(this Writer writer, StringIntPair[] value)
		{
			writer.WriteArray<StringIntPair>(value);
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00174050 File Offset: 0x00172250
		public static void Generated(this Writer writer, Message value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteInt32(value.messageId, AutoPackType.Packed);
			writer.WriteString(value.text);
			writer.Write___ScheduleOne.Messaging.Message/ESenderTypeFishNet.Serializing.Generated(value.sender);
			writer.WriteBoolean(value.endOfGroup);
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x001740D4 File Offset: 0x001722D4
		public static void Generated(this Writer writer, Message.ESenderType value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x001740F4 File Offset: 0x001722F4
		public static void Generated(this Writer writer, MessageChain value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(value.Messages);
			writer.WriteInt32(value.id, AutoPackType.Packed);
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x00174154 File Offset: 0x00172354
		public static void Generated(this Writer writer, MSGConversationData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteInt32(value.ConversationIndex, AutoPackType.Packed);
			writer.WriteBoolean(value.Read);
			writer.Write___ScheduleOne.Persistence.Datas.TextMessageData[]FishNet.Serializing.Generated(value.MessageHistory);
			writer.Write___ScheduleOne.Persistence.Datas.TextResponseData[]FishNet.Serializing.Generated(value.ActiveResponses);
			writer.WriteBoolean(value.IsHidden);
			writer.WriteString(value.DataType);
			writer.WriteInt32(value.DataVersion, AutoPackType.Packed);
			writer.WriteString(value.GameVersion);
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x00174224 File Offset: 0x00172424
		public static void Generated(this Writer writer, TextMessageData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteInt32(value.Sender, AutoPackType.Packed);
			writer.WriteInt32(value.MessageID, AutoPackType.Packed);
			writer.WriteString(value.Text);
			writer.WriteBoolean(value.EndOfChain);
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x001742AC File Offset: 0x001724AC
		public static void Generated(this Writer writer, TextMessageData[] value)
		{
			writer.WriteArray<TextMessageData>(value);
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x001742C8 File Offset: 0x001724C8
		public static void Generated(this Writer writer, TextResponseData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.Text);
			writer.WriteString(value.Label);
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x00174320 File Offset: 0x00172520
		public static void Generated(this Writer writer, TextResponseData[] value)
		{
			writer.WriteArray<TextResponseData>(value);
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x0017433C File Offset: 0x0017253C
		public static void Generated(this Writer writer, Response value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.text);
			writer.WriteString(value.label);
			writer.WriteBoolean(value.disableDefaultResponseBehaviour);
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x001743A8 File Offset: 0x001725A8
		public static void List(this Writer writer, List<Response> value)
		{
			writer.WriteList<Response>(value);
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x001743C4 File Offset: 0x001725C4
		public static void List(this Writer writer, List<NetworkObject> value)
		{
			writer.WriteList<NetworkObject>(value);
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x001743E0 File Offset: 0x001725E0
		public static void Generated(this Writer writer, AdvancedTransitRouteData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.SourceGUID);
			writer.WriteString(value.DestinationGUID);
			writer.Write___ScheduleOne.Management.ManagementItemFilter/EModeFishNet.Serializing.Generated(value.FilterMode);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(value.FilterItemIDs);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0017445C File Offset: 0x0017265C
		public static void Generated(this Writer writer, ManagementItemFilter.EMode value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0017447C File Offset: 0x0017267C
		public static void Generated(this Writer writer, AdvancedTransitRouteData[] value)
		{
			writer.WriteArray<AdvancedTransitRouteData>(value);
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x00174498 File Offset: 0x00172698
		public static void Generated(this Writer writer, ERank value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x001744B8 File Offset: 0x001726B8
		public static void Generated(this Writer writer, FullRank value)
		{
			writer.Write___ScheduleOne.Levelling.ERankFishNet.Serializing.Generated(value.Rank);
			writer.WriteInt32(value.Tier, AutoPackType.Packed);
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x001744F0 File Offset: 0x001726F0
		public static void Generated(this Writer writer, PlayerData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.PlayerCode);
			writer.WriteVector3(value.Position);
			writer.WriteSingle(value.Rotation, AutoPackType.Unpacked);
			writer.WriteBoolean(value.IntroCompleted);
			writer.WriteString(value.DataType);
			writer.WriteInt32(value.DataVersion, AutoPackType.Packed);
			writer.WriteString(value.GameVersion);
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x001745AC File Offset: 0x001727AC
		public static void Generated(this Writer writer, VariableData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.Name);
			writer.WriteString(value.Value);
			writer.WriteString(value.DataType);
			writer.WriteInt32(value.DataVersion, AutoPackType.Packed);
			writer.WriteString(value.GameVersion);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00174640 File Offset: 0x00172840
		public static void Generated(this Writer writer, VariableData[] value)
		{
			writer.WriteArray<VariableData>(value);
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x0017465C File Offset: 0x0017285C
		public static void Generated(this Writer writer, AvatarSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteColor(value.SkinColor, AutoPackType.Packed);
			writer.WriteSingle(value.Height, AutoPackType.Unpacked);
			writer.WriteSingle(value.Gender, AutoPackType.Unpacked);
			writer.WriteSingle(value.Weight, AutoPackType.Unpacked);
			writer.WriteString(value.HairPath);
			writer.WriteColor(value.HairColor, AutoPackType.Packed);
			writer.WriteSingle(value.EyebrowScale, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowThickness, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowRestingHeight, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowRestingAngle, AutoPackType.Unpacked);
			writer.WriteColor(value.LeftEyeLidColor, AutoPackType.Packed);
			writer.WriteColor(value.RightEyeLidColor, AutoPackType.Packed);
			writer.Write___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generated(value.LeftEyeRestingState);
			writer.Write___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generated(value.RightEyeRestingState);
			writer.WriteString(value.EyeballMaterialIdentifier);
			writer.WriteColor(value.EyeBallTint, AutoPackType.Packed);
			writer.WriteSingle(value.PupilDilation, AutoPackType.Unpacked);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generated(value.FaceLayerSettings);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generated(value.BodyLayerSettings);
			writer.Write___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/AccessorySetting>FishNet.Serializing.Generated(value.AccessorySettings);
			writer.WriteBoolean(value.UseCombinedLayer);
			writer.WriteString(value.CombinedLayerPath);
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00174860 File Offset: 0x00172A60
		public static void Generated(this Writer writer, Eye.EyeLidConfiguration value)
		{
			writer.WriteSingle(value.topLidOpen, AutoPackType.Unpacked);
			writer.WriteSingle(value.bottomLidOpen, AutoPackType.Unpacked);
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x0017489C File Offset: 0x00172A9C
		public static void Generated(this Writer writer, AvatarSettings.LayerSetting value)
		{
			writer.WriteString(value.layerPath);
			writer.WriteColor(value.layerTint, AutoPackType.Packed);
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x001748D4 File Offset: 0x00172AD4
		public static void List(this Writer writer, List<AvatarSettings.LayerSetting> value)
		{
			writer.WriteList<AvatarSettings.LayerSetting>(value);
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x001748F0 File Offset: 0x00172AF0
		public static void Generated(this Writer writer, AvatarSettings.AccessorySetting value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.path);
			writer.WriteColor(value.color, AutoPackType.Packed);
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x00174950 File Offset: 0x00172B50
		public static void List(this Writer writer, List<AvatarSettings.AccessorySetting> value)
		{
			writer.WriteList<AvatarSettings.AccessorySetting>(value);
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x0017496C File Offset: 0x00172B6C
		public static void Generated(this Writer writer, BasicAvatarSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteInt32(value.Gender, AutoPackType.Packed);
			writer.WriteSingle(value.Weight, AutoPackType.Unpacked);
			writer.WriteColor(value.SkinColor, AutoPackType.Packed);
			writer.WriteString(value.HairStyle);
			writer.WriteColor(value.HairColor, AutoPackType.Packed);
			writer.WriteString(value.Mouth);
			writer.WriteString(value.FacialHair);
			writer.WriteString(value.FacialDetails);
			writer.WriteSingle(value.FacialDetailsIntensity, AutoPackType.Unpacked);
			writer.WriteColor(value.EyeballColor, AutoPackType.Packed);
			writer.WriteSingle(value.UpperEyeLidRestingPosition, AutoPackType.Unpacked);
			writer.WriteSingle(value.LowerEyeLidRestingPosition, AutoPackType.Unpacked);
			writer.WriteSingle(value.PupilDilation, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowScale, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowThickness, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowRestingHeight, AutoPackType.Unpacked);
			writer.WriteSingle(value.EyebrowRestingAngle, AutoPackType.Unpacked);
			writer.WriteString(value.Top);
			writer.WriteColor(value.TopColor, AutoPackType.Packed);
			writer.WriteString(value.Bottom);
			writer.WriteColor(value.BottomColor, AutoPackType.Packed);
			writer.WriteString(value.Shoes);
			writer.WriteColor(value.ShoesColor, AutoPackType.Packed);
			writer.WriteString(value.Headwear);
			writer.WriteColor(value.HeadwearColor, AutoPackType.Packed);
			writer.WriteString(value.Eyewear);
			writer.WriteColor(value.EyewearColor, AutoPackType.Packed);
			writer.Write___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generated(value.Tattoos);
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00174BF4 File Offset: 0x00172DF4
		public static void Generated(this Writer writer, PlayerCrimeData.EPursuitLevel value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00174C14 File Offset: 0x00172E14
		public static void Generated(this Writer writer, Property value)
		{
			writer.WriteNetworkBehaviour(value);
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00174C30 File Offset: 0x00172E30
		public static void Generated(this Writer writer, EEmployeeType value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x00174C50 File Offset: 0x00172E50
		public static void Generated(this Writer writer, EDealWindow value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x00174C70 File Offset: 0x00172E70
		public static void Generated(this Writer writer, HandoverScreen.EHandoverOutcome value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x00174C90 File Offset: 0x00172E90
		public static void List(this Writer writer, List<ItemInstance> value)
		{
			writer.WriteList<ItemInstance>(value);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00174CAC File Offset: 0x00172EAC
		public static void Generated(this Writer writer, ScheduleOne.Persistence.Datas.CustomerData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteSingle(value.Dependence, AutoPackType.Unpacked);
			writer.Write___System.String[]FishNet.Serializing.Generated(value.PurchaseableProducts);
			writer.Write___System.Single[]FishNet.Serializing.Generated(value.ProductAffinities);
			writer.WriteInt32(value.TimeSinceLastDealCompleted, AutoPackType.Packed);
			writer.WriteInt32(value.TimeSinceLastDealOffered, AutoPackType.Packed);
			writer.WriteInt32(value.OfferedDeals, AutoPackType.Packed);
			writer.WriteInt32(value.CompletedDeals, AutoPackType.Packed);
			writer.WriteBoolean(value.IsContractOffered);
			writer.Write___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generated(value.OfferedContract);
			writer.Write___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generated(value.OfferedContractTime);
			writer.WriteInt32(value.TimeSincePlayerApproached, AutoPackType.Packed);
			writer.WriteInt32(value.TimeSinceInstantDealOffered, AutoPackType.Packed);
			writer.WriteBoolean(value.HasBeenRecommended);
			writer.WriteString(value.DataType);
			writer.WriteInt32(value.DataVersion, AutoPackType.Packed);
			writer.WriteString(value.GameVersion);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x00174E28 File Offset: 0x00173028
		public static void Generated(this Writer writer, string[] value)
		{
			writer.WriteArray<string>(value);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00174E44 File Offset: 0x00173044
		public static void Generated(this Writer writer, float[] value)
		{
			writer.WriteArray<float>(value);
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00174E60 File Offset: 0x00173060
		public static void Generated(this Writer writer, EDrugType value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00174E80 File Offset: 0x00173080
		public static void Generated(this Writer writer, GameData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.OrganisationName);
			writer.WriteInt32(value.Seed, AutoPackType.Packed);
			writer.Write___ScheduleOne.DevUtilities.GameSettingsFishNet.Serializing.Generated(value.Settings);
			writer.WriteString(value.DataType);
			writer.WriteInt32(value.DataVersion, AutoPackType.Packed);
			writer.WriteString(value.GameVersion);
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00174F2C File Offset: 0x0017312C
		public static void Generated(this Writer writer, GameSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteBoolean(value.ConsoleEnabled);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00174F74 File Offset: 0x00173174
		public static void Generated(this Writer writer, DeliveryInstance value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.DeliveryID);
			writer.WriteString(value.StoreName);
			writer.WriteString(value.DestinationCode);
			writer.WriteInt32(value.LoadingDockIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generated(value.Items);
			writer.Write___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generated(value.Status);
			writer.WriteInt32(value.TimeUntilArrival, AutoPackType.Packed);
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00175030 File Offset: 0x00173230
		public static void Generated(this Writer writer, EDeliveryStatus value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00175050 File Offset: 0x00173250
		public static void Generated(this Writer writer, ExplosionData value)
		{
			writer.WriteSingle(value.DamageRadius, AutoPackType.Unpacked);
			writer.WriteSingle(value.MaxDamage, AutoPackType.Unpacked);
			writer.WriteSingle(value.PushForceRadius, AutoPackType.Unpacked);
			writer.WriteSingle(value.MaxPushForce, AutoPackType.Unpacked);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x001750BC File Offset: 0x001732BC
		public static void Generated(this Writer writer, PlayingCard.ECardSuit value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x001750DC File Offset: 0x001732DC
		public static void Generated(this Writer writer, PlayingCard.ECardValue value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x001750FC File Offset: 0x001732FC
		public static void Generated(this Writer writer, NetworkObject[] value)
		{
			writer.WriteArray<NetworkObject>(value);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00175118 File Offset: 0x00173318
		public static void Generated(this Writer writer, RTBGameController.EStage value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00175138 File Offset: 0x00173338
		public static void Generated(this Writer writer, SlotMachine.ESymbol value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x00175158 File Offset: 0x00173358
		public static void Generated(this Writer writer, SlotMachine.ESymbol[] value)
		{
			writer.WriteArray<SlotMachine.ESymbol>(value);
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00175174 File Offset: 0x00173374
		public static void Generated(this Writer writer, EDoorSide value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00175194 File Offset: 0x00173394
		public static void Generated(this Writer writer, EVehicleColor value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x001751B4 File Offset: 0x001733B4
		public static void Generated(this Writer writer, ParkData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteGuidAllocated(value.lotGUID);
			writer.WriteInt32(value.spotIndex, AutoPackType.Packed);
			writer.Write___ScheduleOne.Vehicles.EParkingAlignmentFishNet.Serializing.Generated(value.alignment);
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x00175224 File Offset: 0x00173424
		public static void Generated(this Writer writer, EParkingAlignment value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00175244 File Offset: 0x00173444
		public static void Generated(this Writer writer, TrashContentData value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.Write___System.String[]FishNet.Serializing.Generated(value.TrashIDs);
			writer.Write___System.Int32[]FishNet.Serializing.Generated(value.TrashQuantities);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x0017529C File Offset: 0x0017349C
		public static void Generated(this Writer writer, int[] value)
		{
			writer.WriteArray<int>(value);
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x001752B8 File Offset: 0x001734B8
		public static void Generated(this Writer writer, Coordinate value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteInt32(value.x, AutoPackType.Packed);
			writer.WriteInt32(value.y, AutoPackType.Packed);
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x0017531C File Offset: 0x0017351C
		public static void Generated(this Writer writer, WeedAppearanceSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteColor32(value.MainColor);
			writer.WriteColor32(value.SecondaryColor);
			writer.WriteColor32(value.LeafColor);
			writer.WriteColor32(value.StemColor);
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00175398 File Offset: 0x00173598
		public static void Generated(this Writer writer, CocaineAppearanceSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteColor32(value.MainColor);
			writer.WriteColor32(value.SecondaryColor);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x001753F0 File Offset: 0x001735F0
		public static void Generated(this Writer writer, MethAppearanceSettings value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteColor32(value.MainColor);
			writer.WriteColor32(value.SecondaryColor);
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00175448 File Offset: 0x00173648
		public static void Generated(this Writer writer, NewMixOperation value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.ProductID);
			writer.WriteString(value.IngredientID);
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x001754A0 File Offset: 0x001736A0
		public static void Generated(this Writer writer, Recycler.EState value)
		{
			writer.WriteInt32((int)value, AutoPackType.Packed);
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x001754C0 File Offset: 0x001736C0
		public static void Generated(this Writer writer, CoordinateProceduralTilePair value)
		{
			writer.Write___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generated(value.coord);
			writer.WriteNetworkObject(value.tileParent);
			writer.WriteInt32(value.tileIndex, AutoPackType.Packed);
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00175508 File Offset: 0x00173708
		public static void List(this Writer writer, List<CoordinateProceduralTilePair> value)
		{
			writer.WriteList<CoordinateProceduralTilePair>(value);
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00175524 File Offset: 0x00173724
		public static void Generated(this Writer writer, ChemistryCookOperation value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.RecipeID);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value.ProductQuality);
			writer.WriteColor(value.StartLiquidColor, AutoPackType.Packed);
			writer.WriteSingle(value.LiquidLevel, AutoPackType.Unpacked);
			writer.WriteInt32(value.CurrentTime, AutoPackType.Packed);
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x001755C4 File Offset: 0x001737C4
		public static void Generated(this Writer writer, DryingOperation value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.ItemID);
			writer.WriteInt32(value.Quantity, AutoPackType.Packed);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value.StartQuality);
			writer.WriteInt32(value.Time, AutoPackType.Packed);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0017564C File Offset: 0x0017384C
		public static void Generated(this Writer writer, OvenCookOperation value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.IngredientID);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value.IngredientQuality);
			writer.WriteInt32(value.IngredientQuantity, AutoPackType.Packed);
			writer.WriteString(value.ProductID);
			writer.WriteInt32(value.CookProgress, AutoPackType.Packed);
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x001756E4 File Offset: 0x001738E4
		public static void Generated(this Writer writer, MixOperation value)
		{
			if (value == null)
			{
				writer.WriteBoolean(true);
				return;
			}
			writer.WriteBoolean(false);
			writer.WriteString(value.ProductID);
			writer.Write___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generated(value.ProductQuality);
			writer.WriteString(value.IngredientID);
			writer.WriteInt32(value.Quantity, AutoPackType.Packed);
		}
	}
}
