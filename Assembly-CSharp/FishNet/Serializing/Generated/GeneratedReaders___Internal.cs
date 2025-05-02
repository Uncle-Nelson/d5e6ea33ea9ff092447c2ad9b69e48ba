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
	// Token: 0x02000C66 RID: 3174
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedReaders___Internal
	{
		// Token: 0x060058DD RID: 22749 RVA: 0x00175768 File Offset: 0x00173968
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
			GenericReader<ItemInstance>.Read = new Func<Reader, ItemInstance>(ItemSerializers.ReadItemInstance);
			GenericReader<StorableItemInstance>.Read = new Func<Reader, StorableItemInstance>(ItemSerializers.ReadStorableItemInstance);
			GenericReader<CashInstance>.Read = new Func<Reader, CashInstance>(ItemSerializers.ReadCashInstance);
			GenericReader<QualityItemInstance>.Read = new Func<Reader, QualityItemInstance>(ItemSerializers.ReadQualityItemInstance);
			GenericReader<ClothingInstance>.Read = new Func<Reader, ClothingInstance>(ItemSerializers.ReadClothingInstance);
			GenericReader<ProductItemInstance>.Read = new Func<Reader, ProductItemInstance>(ItemSerializers.ReadProductItemInstance);
			GenericReader<WeedInstance>.Read = new Func<Reader, WeedInstance>(ItemSerializers.ReadWeedInstance);
			GenericReader<MethInstance>.Read = new Func<Reader, MethInstance>(ItemSerializers.ReadMethInstance);
			GenericReader<CocaineInstance>.Read = new Func<Reader, CocaineInstance>(ItemSerializers.ReadCocaineInstance);
			GenericReader<IntegerItemInstance>.Read = new Func<Reader, IntegerItemInstance>(ItemSerializers.ReadIntegerItemInstance);
			GenericReader<WateringCanInstance>.Read = new Func<Reader, WateringCanInstance>(ItemSerializers.ReadWateringCanInstance);
			GenericReader<TrashGrabberInstance>.Read = new Func<Reader, TrashGrabberInstance>(ItemSerializers.ReadTrashGrabberInstance);
			GenericReader<VisionEventReceipt>.Read = new Func<Reader, VisionEventReceipt>(GeneratedReaders___Internal.Read___ScheduleOne.Vision.VisionEventReceiptFishNet.Serializing.Generateds);
			GenericReader<PlayerVisualState.EVisualState>.Read = new Func<Reader, PlayerVisualState.EVisualState>(GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generateds);
			GenericReader<VisionCone.EEventLevel>.Read = new Func<Reader, VisionCone.EEventLevel>(GeneratedReaders___Internal.Read___ScheduleOne.Vision.VisionCone/EEventLevelFishNet.Serializing.Generateds);
			GenericReader<ContractInfo>.Read = new Func<Reader, ContractInfo>(GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds);
			GenericReader<ProductList>.Read = new Func<Reader, ProductList>(GeneratedReaders___Internal.Read___ScheduleOne.Product.ProductListFishNet.Serializing.Generateds);
			GenericReader<ProductList.Entry>.Read = new Func<Reader, ProductList.Entry>(GeneratedReaders___Internal.Read___ScheduleOne.Product.ProductList/EntryFishNet.Serializing.Generateds);
			GenericReader<EQuality>.Read = new Func<Reader, EQuality>(GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds);
			GenericReader<List<ProductList.Entry>>.Read = new Func<Reader, List<ProductList.Entry>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Product.ProductList/Entry>FishNet.Serializing.Generateds);
			GenericReader<QuestWindowConfig>.Read = new Func<Reader, QuestWindowConfig>(GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestWindowConfigFishNet.Serializing.Generateds);
			GenericReader<GameDateTime>.Read = new Func<Reader, GameDateTime>(GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds);
			GenericReader<QuestManager.EQuestAction>.Read = new Func<Reader, QuestManager.EQuestAction>(GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestManager/EQuestActionFishNet.Serializing.Generateds);
			GenericReader<EQuestState>.Read = new Func<Reader, EQuestState>(GeneratedReaders___Internal.Read___ScheduleOne.Quests.EQuestStateFishNet.Serializing.Generateds);
			GenericReader<Impact>.Read = new Func<Reader, Impact>(GeneratedReaders___Internal.Read___ScheduleOne.Combat.ImpactFishNet.Serializing.Generateds);
			GenericReader<EImpactType>.Read = new Func<Reader, EImpactType>(GeneratedReaders___Internal.Read___ScheduleOne.Combat.EImpactTypeFishNet.Serializing.Generateds);
			GenericReader<LandVehicle>.Read = new Func<Reader, LandVehicle>(GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.LandVehicleFishNet.Serializing.Generateds);
			GenericReader<CheckpointManager.ECheckpointLocation>.Read = new Func<Reader, CheckpointManager.ECheckpointLocation>(GeneratedReaders___Internal.Read___ScheduleOne.Law.CheckpointManager/ECheckpointLocationFishNet.Serializing.Generateds);
			GenericReader<Player>.Read = new Func<Reader, Player>(GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerFishNet.Serializing.Generateds);
			GenericReader<List<string>>.Read = new Func<Reader, List<string>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds);
			GenericReader<StringIntPair>.Read = new Func<Reader, StringIntPair>(GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.StringIntPairFishNet.Serializing.Generateds);
			GenericReader<StringIntPair[]>.Read = new Func<Reader, StringIntPair[]>(GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generateds);
			GenericReader<Message>.Read = new Func<Reader, Message>(GeneratedReaders___Internal.Read___ScheduleOne.Messaging.MessageFishNet.Serializing.Generateds);
			GenericReader<Message.ESenderType>.Read = new Func<Reader, Message.ESenderType>(GeneratedReaders___Internal.Read___ScheduleOne.Messaging.Message/ESenderTypeFishNet.Serializing.Generateds);
			GenericReader<MessageChain>.Read = new Func<Reader, MessageChain>(GeneratedReaders___Internal.Read___ScheduleOne.UI.Phone.Messages.MessageChainFishNet.Serializing.Generateds);
			GenericReader<MSGConversationData>.Read = new Func<Reader, MSGConversationData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.MSGConversationDataFishNet.Serializing.Generateds);
			GenericReader<TextMessageData>.Read = new Func<Reader, TextMessageData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextMessageDataFishNet.Serializing.Generateds);
			GenericReader<TextMessageData[]>.Read = new Func<Reader, TextMessageData[]>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextMessageData[]FishNet.Serializing.Generateds);
			GenericReader<TextResponseData>.Read = new Func<Reader, TextResponseData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextResponseDataFishNet.Serializing.Generateds);
			GenericReader<TextResponseData[]>.Read = new Func<Reader, TextResponseData[]>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextResponseData[]FishNet.Serializing.Generateds);
			GenericReader<Response>.Read = new Func<Reader, Response>(GeneratedReaders___Internal.Read___ScheduleOne.Messaging.ResponseFishNet.Serializing.Generateds);
			GenericReader<List<Response>>.Read = new Func<Reader, List<Response>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Messaging.Response>FishNet.Serializing.Generateds);
			GenericReader<List<NetworkObject>>.Read = new Func<Reader, List<NetworkObject>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<FishNet.Object.NetworkObject>FishNet.Serializing.Generateds);
			GenericReader<AdvancedTransitRouteData>.Read = new Func<Reader, AdvancedTransitRouteData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteDataFishNet.Serializing.Generateds);
			GenericReader<ManagementItemFilter.EMode>.Read = new Func<Reader, ManagementItemFilter.EMode>(GeneratedReaders___Internal.Read___ScheduleOne.Management.ManagementItemFilter/EModeFishNet.Serializing.Generateds);
			GenericReader<AdvancedTransitRouteData[]>.Read = new Func<Reader, AdvancedTransitRouteData[]>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.AdvancedTransitRouteData[]FishNet.Serializing.Generateds);
			GenericReader<ERank>.Read = new Func<Reader, ERank>(GeneratedReaders___Internal.Read___ScheduleOne.Levelling.ERankFishNet.Serializing.Generateds);
			GenericReader<FullRank>.Read = new Func<Reader, FullRank>(GeneratedReaders___Internal.Read___ScheduleOne.Levelling.FullRankFishNet.Serializing.Generateds);
			GenericReader<PlayerData>.Read = new Func<Reader, PlayerData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.PlayerDataFishNet.Serializing.Generateds);
			GenericReader<VariableData>.Read = new Func<Reader, VariableData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.VariableDataFishNet.Serializing.Generateds);
			GenericReader<VariableData[]>.Read = new Func<Reader, VariableData[]>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.VariableData[]FishNet.Serializing.Generateds);
			GenericReader<AvatarSettings>.Read = new Func<Reader, AvatarSettings>(GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.AvatarSettingsFishNet.Serializing.Generateds);
			GenericReader<Eye.EyeLidConfiguration>.Read = new Func<Reader, Eye.EyeLidConfiguration>(GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generateds);
			GenericReader<AvatarSettings.LayerSetting>.Read = new Func<Reader, AvatarSettings.LayerSetting>(GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.AvatarSettings/LayerSettingFishNet.Serializing.Generateds);
			GenericReader<List<AvatarSettings.LayerSetting>>.Read = new Func<Reader, List<AvatarSettings.LayerSetting>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generateds);
			GenericReader<AvatarSettings.AccessorySetting>.Read = new Func<Reader, AvatarSettings.AccessorySetting>(GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.AvatarSettings/AccessorySettingFishNet.Serializing.Generateds);
			GenericReader<List<AvatarSettings.AccessorySetting>>.Read = new Func<Reader, List<AvatarSettings.AccessorySetting>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/AccessorySetting>FishNet.Serializing.Generateds);
			GenericReader<BasicAvatarSettings>.Read = new Func<Reader, BasicAvatarSettings>(GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.Customization.BasicAvatarSettingsFishNet.Serializing.Generateds);
			GenericReader<PlayerCrimeData.EPursuitLevel>.Read = new Func<Reader, PlayerCrimeData.EPursuitLevel>(GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerCrimeData/EPursuitLevelFishNet.Serializing.Generateds);
			GenericReader<Property>.Read = new Func<Reader, Property>(GeneratedReaders___Internal.Read___ScheduleOne.Property.PropertyFishNet.Serializing.Generateds);
			GenericReader<EEmployeeType>.Read = new Func<Reader, EEmployeeType>(GeneratedReaders___Internal.Read___ScheduleOne.Employees.EEmployeeTypeFishNet.Serializing.Generateds);
			GenericReader<EDealWindow>.Read = new Func<Reader, EDealWindow>(GeneratedReaders___Internal.Read___ScheduleOne.Economy.EDealWindowFishNet.Serializing.Generateds);
			GenericReader<HandoverScreen.EHandoverOutcome>.Read = new Func<Reader, HandoverScreen.EHandoverOutcome>(GeneratedReaders___Internal.Read___ScheduleOne.UI.Handover.HandoverScreen/EHandoverOutcomeFishNet.Serializing.Generateds);
			GenericReader<List<ItemInstance>>.Read = new Func<Reader, List<ItemInstance>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.ItemFramework.ItemInstance>FishNet.Serializing.Generateds);
			GenericReader<ScheduleOne.Persistence.Datas.CustomerData>.Read = new Func<Reader, ScheduleOne.Persistence.Datas.CustomerData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.CustomerDataFishNet.Serializing.Generateds);
			GenericReader<string[]>.Read = new Func<Reader, string[]>(GeneratedReaders___Internal.Read___System.String[]FishNet.Serializing.Generateds);
			GenericReader<float[]>.Read = new Func<Reader, float[]>(GeneratedReaders___Internal.Read___System.Single[]FishNet.Serializing.Generateds);
			GenericReader<EDrugType>.Read = new Func<Reader, EDrugType>(GeneratedReaders___Internal.Read___ScheduleOne.Product.EDrugTypeFishNet.Serializing.Generateds);
			GenericReader<GameData>.Read = new Func<Reader, GameData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.GameDataFishNet.Serializing.Generateds);
			GenericReader<GameSettings>.Read = new Func<Reader, GameSettings>(GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.GameSettingsFishNet.Serializing.Generateds);
			GenericReader<DeliveryInstance>.Read = new Func<Reader, DeliveryInstance>(GeneratedReaders___Internal.Read___ScheduleOne.Delivery.DeliveryInstanceFishNet.Serializing.Generateds);
			GenericReader<EDeliveryStatus>.Read = new Func<Reader, EDeliveryStatus>(GeneratedReaders___Internal.Read___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generateds);
			GenericReader<ExplosionData>.Read = new Func<Reader, ExplosionData>(GeneratedReaders___Internal.Read___ScheduleOne.Combat.ExplosionDataFishNet.Serializing.Generateds);
			GenericReader<PlayingCard.ECardSuit>.Read = new Func<Reader, PlayingCard.ECardSuit>(GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardSuitFishNet.Serializing.Generateds);
			GenericReader<PlayingCard.ECardValue>.Read = new Func<Reader, PlayingCard.ECardValue>(GeneratedReaders___Internal.Read___ScheduleOne.Casino.PlayingCard/ECardValueFishNet.Serializing.Generateds);
			GenericReader<NetworkObject[]>.Read = new Func<Reader, NetworkObject[]>(GeneratedReaders___Internal.Read___FishNet.Object.NetworkObject[]FishNet.Serializing.Generateds);
			GenericReader<RTBGameController.EStage>.Read = new Func<Reader, RTBGameController.EStage>(GeneratedReaders___Internal.Read___ScheduleOne.Casino.RTBGameController/EStageFishNet.Serializing.Generateds);
			GenericReader<SlotMachine.ESymbol>.Read = new Func<Reader, SlotMachine.ESymbol>(GeneratedReaders___Internal.Read___ScheduleOne.Casino.SlotMachine/ESymbolFishNet.Serializing.Generateds);
			GenericReader<SlotMachine.ESymbol[]>.Read = new Func<Reader, SlotMachine.ESymbol[]>(GeneratedReaders___Internal.Read___ScheduleOne.Casino.SlotMachine/ESymbol[]FishNet.Serializing.Generateds);
			GenericReader<EDoorSide>.Read = new Func<Reader, EDoorSide>(GeneratedReaders___Internal.Read___ScheduleOne.Doors.EDoorSideFishNet.Serializing.Generateds);
			GenericReader<EVehicleColor>.Read = new Func<Reader, EVehicleColor>(GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.Modification.EVehicleColorFishNet.Serializing.Generateds);
			GenericReader<ParkData>.Read = new Func<Reader, ParkData>(GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.ParkDataFishNet.Serializing.Generateds);
			GenericReader<EParkingAlignment>.Read = new Func<Reader, EParkingAlignment>(GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.EParkingAlignmentFishNet.Serializing.Generateds);
			GenericReader<TrashContentData>.Read = new Func<Reader, TrashContentData>(GeneratedReaders___Internal.Read___ScheduleOne.Persistence.TrashContentDataFishNet.Serializing.Generateds);
			GenericReader<int[]>.Read = new Func<Reader, int[]>(GeneratedReaders___Internal.Read___System.Int32[]FishNet.Serializing.Generateds);
			GenericReader<Coordinate>.Read = new Func<Reader, Coordinate>(GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds);
			GenericReader<WeedAppearanceSettings>.Read = new Func<Reader, WeedAppearanceSettings>(GeneratedReaders___Internal.Read___ScheduleOne.Product.WeedAppearanceSettingsFishNet.Serializing.Generateds);
			GenericReader<CocaineAppearanceSettings>.Read = new Func<Reader, CocaineAppearanceSettings>(GeneratedReaders___Internal.Read___ScheduleOne.Product.CocaineAppearanceSettingsFishNet.Serializing.Generateds);
			GenericReader<MethAppearanceSettings>.Read = new Func<Reader, MethAppearanceSettings>(GeneratedReaders___Internal.Read___ScheduleOne.Product.MethAppearanceSettingsFishNet.Serializing.Generateds);
			GenericReader<NewMixOperation>.Read = new Func<Reader, NewMixOperation>(GeneratedReaders___Internal.Read___ScheduleOne.Product.NewMixOperationFishNet.Serializing.Generateds);
			GenericReader<Recycler.EState>.Read = new Func<Reader, Recycler.EState>(GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.Recycler/EStateFishNet.Serializing.Generateds);
			GenericReader<CoordinateProceduralTilePair>.Read = new Func<Reader, CoordinateProceduralTilePair>(GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateProceduralTilePairFishNet.Serializing.Generateds);
			GenericReader<List<CoordinateProceduralTilePair>>.Read = new Func<Reader, List<CoordinateProceduralTilePair>>(GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Tiles.CoordinateProceduralTilePair>FishNet.Serializing.Generateds);
			GenericReader<ChemistryCookOperation>.Read = new Func<Reader, ChemistryCookOperation>(GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.ChemistryCookOperationFishNet.Serializing.Generateds);
			GenericReader<DryingOperation>.Read = new Func<Reader, DryingOperation>(GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.DryingOperationFishNet.Serializing.Generateds);
			GenericReader<OvenCookOperation>.Read = new Func<Reader, OvenCookOperation>(GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.OvenCookOperationFishNet.Serializing.Generateds);
			GenericReader<MixOperation>.Read = new Func<Reader, MixOperation>(GeneratedReaders___Internal.Read___ScheduleOne.ObjectScripts.MixOperationFishNet.Serializing.Generateds);
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x00175DE8 File Offset: 0x00173FE8
		public static VisionEventReceipt Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new VisionEventReceipt
			{
				TargetPlayer = reader.ReadNetworkObject(),
				State = GeneratedReaders___Internal.Read___ScheduleOne.PlayerScripts.PlayerVisualState/EVisualStateFishNet.Serializing.Generateds(reader)
			};
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x00175E40 File Offset: 0x00174040
		public static PlayerVisualState.EVisualState Generateds(Reader reader)
		{
			return (PlayerVisualState.EVisualState)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x00175E5C File Offset: 0x0017405C
		public static VisionCone.EEventLevel Generateds(Reader reader)
		{
			return (VisionCone.EEventLevel)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x00175E78 File Offset: 0x00174078
		public static ContractInfo Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ContractInfo
			{
				Payment = reader.ReadSingle(AutoPackType.Unpacked),
				Products = GeneratedReaders___Internal.Read___ScheduleOne.Product.ProductListFishNet.Serializing.Generateds(reader),
				DeliveryLocationGUID = reader.ReadString(),
				DeliveryWindow = GeneratedReaders___Internal.Read___ScheduleOne.Quests.QuestWindowConfigFishNet.Serializing.Generateds(reader),
				Expires = reader.ReadBoolean(),
				ExpiresAfter = reader.ReadInt32(AutoPackType.Packed),
				PickupScheduleIndex = reader.ReadInt32(AutoPackType.Packed),
				IsCounterOffer = reader.ReadBoolean()
			};
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00175F4C File Offset: 0x0017414C
		public static ProductList Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ProductList
			{
				entries = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.Product.ProductList/Entry>FishNet.Serializing.Generateds(reader)
			};
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00175F94 File Offset: 0x00174194
		public static ProductList.Entry Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ProductList.Entry
			{
				ProductID = reader.ReadString(),
				Quality = GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(reader),
				Quantity = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x00176004 File Offset: 0x00174204
		public static EQuality Generateds(Reader reader)
		{
			return (EQuality)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00176020 File Offset: 0x00174220
		public static List<ProductList.Entry> List(Reader reader)
		{
			return reader.ReadListAllocated<ProductList.Entry>();
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x00176038 File Offset: 0x00174238
		public static QuestWindowConfig Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new QuestWindowConfig
			{
				IsEnabled = reader.ReadBoolean(),
				WindowStartTime = reader.ReadInt32(AutoPackType.Packed),
				WindowEndTime = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x001760AC File Offset: 0x001742AC
		public static GameDateTime Generateds(Reader reader)
		{
			return new GameDateTime
			{
				elapsedDays = reader.ReadInt32(AutoPackType.Packed),
				time = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x001760F8 File Offset: 0x001742F8
		public static QuestManager.EQuestAction Generateds(Reader reader)
		{
			return (QuestManager.EQuestAction)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x00176114 File Offset: 0x00174314
		public static EQuestState Generateds(Reader reader)
		{
			return (EQuestState)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x00176130 File Offset: 0x00174330
		public static Impact Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new Impact
			{
				HitPoint = reader.ReadVector3(),
				ImpactForceDirection = reader.ReadVector3(),
				ImpactForce = reader.ReadSingle(AutoPackType.Unpacked),
				ImpactDamage = reader.ReadSingle(AutoPackType.Unpacked),
				ImpactType = GeneratedReaders___Internal.Read___ScheduleOne.Combat.EImpactTypeFishNet.Serializing.Generateds(reader),
				ImpactSource = reader.ReadNetworkObject(),
				ImpactID = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x001761F0 File Offset: 0x001743F0
		public static EImpactType Generateds(Reader reader)
		{
			return (EImpactType)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x0017620C File Offset: 0x0017440C
		public static LandVehicle Generateds(Reader reader)
		{
			return (LandVehicle)reader.ReadNetworkBehaviour();
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00176224 File Offset: 0x00174424
		public static CheckpointManager.ECheckpointLocation Generateds(Reader reader)
		{
			return (CheckpointManager.ECheckpointLocation)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00176240 File Offset: 0x00174440
		public static Player Generateds(Reader reader)
		{
			return (Player)reader.ReadNetworkBehaviour();
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00176258 File Offset: 0x00174458
		public static List<string> List(Reader reader)
		{
			return reader.ReadListAllocated<string>();
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00176270 File Offset: 0x00174470
		public static StringIntPair Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new StringIntPair
			{
				String = reader.ReadString(),
				Int = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x001762CC File Offset: 0x001744CC
		public static StringIntPair[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<StringIntPair>();
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x001762E4 File Offset: 0x001744E4
		public static Message Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new Message
			{
				messageId = reader.ReadInt32(AutoPackType.Packed),
				text = reader.ReadString(),
				sender = GeneratedReaders___Internal.Read___ScheduleOne.Messaging.Message/ESenderTypeFishNet.Serializing.Generateds(reader),
				endOfGroup = reader.ReadBoolean()
			};
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00176364 File Offset: 0x00174564
		public static Message.ESenderType Generateds(Reader reader)
		{
			return (Message.ESenderType)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x00176380 File Offset: 0x00174580
		public static MessageChain Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new MessageChain
			{
				Messages = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(reader),
				id = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x001763DC File Offset: 0x001745DC
		public static MSGConversationData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new MSGConversationData
			{
				ConversationIndex = reader.ReadInt32(AutoPackType.Packed),
				Read = reader.ReadBoolean(),
				MessageHistory = GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextMessageData[]FishNet.Serializing.Generateds(reader),
				ActiveResponses = GeneratedReaders___Internal.Read___ScheduleOne.Persistence.Datas.TextResponseData[]FishNet.Serializing.Generateds(reader),
				IsHidden = reader.ReadBoolean(),
				DataType = reader.ReadString(),
				DataVersion = reader.ReadInt32(AutoPackType.Packed),
				GameVersion = reader.ReadString()
			};
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x001764AC File Offset: 0x001746AC
		public static TextMessageData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new TextMessageData
			{
				Sender = reader.ReadInt32(AutoPackType.Packed),
				MessageID = reader.ReadInt32(AutoPackType.Packed),
				Text = reader.ReadString(),
				EndOfChain = reader.ReadBoolean()
			};
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00176534 File Offset: 0x00174734
		public static TextMessageData[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<TextMessageData>();
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x0017654C File Offset: 0x0017474C
		public static TextResponseData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new TextResponseData
			{
				Text = reader.ReadString(),
				Label = reader.ReadString()
			};
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x001765A4 File Offset: 0x001747A4
		public static TextResponseData[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<TextResponseData>();
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x001765BC File Offset: 0x001747BC
		public static Response Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new Response
			{
				text = reader.ReadString(),
				label = reader.ReadString(),
				disableDefaultResponseBehaviour = reader.ReadBoolean()
			};
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00176628 File Offset: 0x00174828
		public static List<Response> List(Reader reader)
		{
			return reader.ReadListAllocated<Response>();
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00176640 File Offset: 0x00174840
		public static List<NetworkObject> List(Reader reader)
		{
			return reader.ReadListAllocated<NetworkObject>();
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x00176658 File Offset: 0x00174858
		public static AdvancedTransitRouteData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new AdvancedTransitRouteData
			{
				SourceGUID = reader.ReadString(),
				DestinationGUID = reader.ReadString(),
				FilterMode = GeneratedReaders___Internal.Read___ScheduleOne.Management.ManagementItemFilter/EModeFishNet.Serializing.Generateds(reader),
				FilterItemIDs = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(reader)
			};
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x001766D4 File Offset: 0x001748D4
		public static ManagementItemFilter.EMode Generateds(Reader reader)
		{
			return (ManagementItemFilter.EMode)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x001766F0 File Offset: 0x001748F0
		public static AdvancedTransitRouteData[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<AdvancedTransitRouteData>();
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00176708 File Offset: 0x00174908
		public static ERank Generateds(Reader reader)
		{
			return (ERank)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00176724 File Offset: 0x00174924
		public static FullRank Generateds(Reader reader)
		{
			return new FullRank
			{
				Rank = GeneratedReaders___Internal.Read___ScheduleOne.Levelling.ERankFishNet.Serializing.Generateds(reader),
				Tier = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00176768 File Offset: 0x00174968
		public static PlayerData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new PlayerData
			{
				PlayerCode = reader.ReadString(),
				Position = reader.ReadVector3(),
				Rotation = reader.ReadSingle(AutoPackType.Unpacked),
				IntroCompleted = reader.ReadBoolean(),
				DataType = reader.ReadString(),
				DataVersion = reader.ReadInt32(AutoPackType.Packed),
				GameVersion = reader.ReadString()
			};
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x00176824 File Offset: 0x00174A24
		public static VariableData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new VariableData
			{
				Name = reader.ReadString(),
				Value = reader.ReadString(),
				DataType = reader.ReadString(),
				DataVersion = reader.ReadInt32(AutoPackType.Packed),
				GameVersion = reader.ReadString()
			};
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x001768B8 File Offset: 0x00174AB8
		public static VariableData[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<VariableData>();
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x001768D0 File Offset: 0x00174AD0
		public static AvatarSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			AvatarSettings avatarSettings = ScriptableObject.CreateInstance<AvatarSettings>();
			avatarSettings.SkinColor = reader.ReadColor(AutoPackType.Packed);
			avatarSettings.Height = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.Gender = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.Weight = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.HairPath = reader.ReadString();
			avatarSettings.HairColor = reader.ReadColor(AutoPackType.Packed);
			avatarSettings.EyebrowScale = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.EyebrowThickness = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.EyebrowRestingHeight = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.EyebrowRestingAngle = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.LeftEyeLidColor = reader.ReadColor(AutoPackType.Packed);
			avatarSettings.RightEyeLidColor = reader.ReadColor(AutoPackType.Packed);
			avatarSettings.LeftEyeRestingState = GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generateds(reader);
			avatarSettings.RightEyeRestingState = GeneratedReaders___Internal.Read___ScheduleOne.AvatarFramework.Eye/EyeLidConfigurationFishNet.Serializing.Generateds(reader);
			avatarSettings.EyeballMaterialIdentifier = reader.ReadString();
			avatarSettings.EyeBallTint = reader.ReadColor(AutoPackType.Packed);
			avatarSettings.PupilDilation = reader.ReadSingle(AutoPackType.Unpacked);
			avatarSettings.FaceLayerSettings = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generateds(reader);
			avatarSettings.BodyLayerSettings = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/LayerSetting>FishNet.Serializing.Generateds(reader);
			avatarSettings.AccessorySettings = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<ScheduleOne.AvatarFramework.AvatarSettings/AccessorySetting>FishNet.Serializing.Generateds(reader);
			avatarSettings.UseCombinedLayer = reader.ReadBoolean();
			avatarSettings.CombinedLayerPath = reader.ReadString();
			return avatarSettings;
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00176AD0 File Offset: 0x00174CD0
		public static Eye.EyeLidConfiguration Generateds(Reader reader)
		{
			return new Eye.EyeLidConfiguration
			{
				topLidOpen = reader.ReadSingle(AutoPackType.Unpacked),
				bottomLidOpen = reader.ReadSingle(AutoPackType.Unpacked)
			};
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00176B1C File Offset: 0x00174D1C
		public static AvatarSettings.LayerSetting Generateds(Reader reader)
		{
			return new AvatarSettings.LayerSetting
			{
				layerPath = reader.ReadString(),
				layerTint = reader.ReadColor(AutoPackType.Packed)
			};
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00176B60 File Offset: 0x00174D60
		public static List<AvatarSettings.LayerSetting> List(Reader reader)
		{
			return reader.ReadListAllocated<AvatarSettings.LayerSetting>();
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00176B78 File Offset: 0x00174D78
		public static AvatarSettings.AccessorySetting Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new AvatarSettings.AccessorySetting
			{
				path = reader.ReadString(),
				color = reader.ReadColor(AutoPackType.Packed)
			};
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00176BD4 File Offset: 0x00174DD4
		public static List<AvatarSettings.AccessorySetting> List(Reader reader)
		{
			return reader.ReadListAllocated<AvatarSettings.AccessorySetting>();
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00176BEC File Offset: 0x00174DEC
		public static BasicAvatarSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			BasicAvatarSettings basicAvatarSettings = ScriptableObject.CreateInstance<BasicAvatarSettings>();
			basicAvatarSettings.Gender = reader.ReadInt32(AutoPackType.Packed);
			basicAvatarSettings.Weight = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.SkinColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.HairStyle = reader.ReadString();
			basicAvatarSettings.HairColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Mouth = reader.ReadString();
			basicAvatarSettings.FacialHair = reader.ReadString();
			basicAvatarSettings.FacialDetails = reader.ReadString();
			basicAvatarSettings.FacialDetailsIntensity = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.EyeballColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.UpperEyeLidRestingPosition = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.LowerEyeLidRestingPosition = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.PupilDilation = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.EyebrowScale = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.EyebrowThickness = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.EyebrowRestingHeight = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.EyebrowRestingAngle = reader.ReadSingle(AutoPackType.Unpacked);
			basicAvatarSettings.Top = reader.ReadString();
			basicAvatarSettings.TopColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Bottom = reader.ReadString();
			basicAvatarSettings.BottomColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Shoes = reader.ReadString();
			basicAvatarSettings.ShoesColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Headwear = reader.ReadString();
			basicAvatarSettings.HeadwearColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Eyewear = reader.ReadString();
			basicAvatarSettings.EyewearColor = reader.ReadColor(AutoPackType.Packed);
			basicAvatarSettings.Tattoos = GeneratedReaders___Internal.Read___System.Collections.Generic.List`1<System.String>FishNet.Serializing.Generateds(reader);
			return basicAvatarSettings;
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00176E74 File Offset: 0x00175074
		public static PlayerCrimeData.EPursuitLevel Generateds(Reader reader)
		{
			return (PlayerCrimeData.EPursuitLevel)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00176E90 File Offset: 0x00175090
		public static Property Generateds(Reader reader)
		{
			return (Property)reader.ReadNetworkBehaviour();
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00176EA8 File Offset: 0x001750A8
		public static EEmployeeType Generateds(Reader reader)
		{
			return (EEmployeeType)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x00176EC4 File Offset: 0x001750C4
		public static EDealWindow Generateds(Reader reader)
		{
			return (EDealWindow)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00176EE0 File Offset: 0x001750E0
		public static HandoverScreen.EHandoverOutcome Generateds(Reader reader)
		{
			return (HandoverScreen.EHandoverOutcome)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00176EFC File Offset: 0x001750FC
		public static List<ItemInstance> List(Reader reader)
		{
			return reader.ReadListAllocated<ItemInstance>();
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00176F14 File Offset: 0x00175114
		public static ScheduleOne.Persistence.Datas.CustomerData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ScheduleOne.Persistence.Datas.CustomerData
			{
				Dependence = reader.ReadSingle(AutoPackType.Unpacked),
				PurchaseableProducts = GeneratedReaders___Internal.Read___System.String[]FishNet.Serializing.Generateds(reader),
				ProductAffinities = GeneratedReaders___Internal.Read___System.Single[]FishNet.Serializing.Generateds(reader),
				TimeSinceLastDealCompleted = reader.ReadInt32(AutoPackType.Packed),
				TimeSinceLastDealOffered = reader.ReadInt32(AutoPackType.Packed),
				OfferedDeals = reader.ReadInt32(AutoPackType.Packed),
				CompletedDeals = reader.ReadInt32(AutoPackType.Packed),
				IsContractOffered = reader.ReadBoolean(),
				OfferedContract = GeneratedReaders___Internal.Read___ScheduleOne.Quests.ContractInfoFishNet.Serializing.Generateds(reader),
				OfferedContractTime = GeneratedReaders___Internal.Read___ScheduleOne.GameTime.GameDateTimeFishNet.Serializing.Generateds(reader),
				TimeSincePlayerApproached = reader.ReadInt32(AutoPackType.Packed),
				TimeSinceInstantDealOffered = reader.ReadInt32(AutoPackType.Packed),
				HasBeenRecommended = reader.ReadBoolean(),
				DataType = reader.ReadString(),
				DataVersion = reader.ReadInt32(AutoPackType.Packed),
				GameVersion = reader.ReadString()
			};
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x00177090 File Offset: 0x00175290
		public static string[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<string>();
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x001770A8 File Offset: 0x001752A8
		public static float[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<float>();
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001770C0 File Offset: 0x001752C0
		public static EDrugType Generateds(Reader reader)
		{
			return (EDrugType)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001770DC File Offset: 0x001752DC
		public static GameData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new GameData
			{
				OrganisationName = reader.ReadString(),
				Seed = reader.ReadInt32(AutoPackType.Packed),
				Settings = GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.GameSettingsFishNet.Serializing.Generateds(reader),
				DataType = reader.ReadString(),
				DataVersion = reader.ReadInt32(AutoPackType.Packed),
				GameVersion = reader.ReadString()
			};
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00177188 File Offset: 0x00175388
		public static GameSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new GameSettings
			{
				ConsoleEnabled = reader.ReadBoolean()
			};
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001771D0 File Offset: 0x001753D0
		public static DeliveryInstance Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new DeliveryInstance
			{
				DeliveryID = reader.ReadString(),
				StoreName = reader.ReadString(),
				DestinationCode = reader.ReadString(),
				LoadingDockIndex = reader.ReadInt32(AutoPackType.Packed),
				Items = GeneratedReaders___Internal.Read___ScheduleOne.DevUtilities.StringIntPair[]FishNet.Serializing.Generateds(reader),
				Status = GeneratedReaders___Internal.Read___ScheduleOne.Delivery.EDeliveryStatusFishNet.Serializing.Generateds(reader),
				TimeUntilArrival = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x0017728C File Offset: 0x0017548C
		public static EDeliveryStatus Generateds(Reader reader)
		{
			return (EDeliveryStatus)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x001772A8 File Offset: 0x001754A8
		public static ExplosionData Generateds(Reader reader)
		{
			return new ExplosionData
			{
				DamageRadius = reader.ReadSingle(AutoPackType.Unpacked),
				MaxDamage = reader.ReadSingle(AutoPackType.Unpacked),
				PushForceRadius = reader.ReadSingle(AutoPackType.Unpacked),
				MaxPushForce = reader.ReadSingle(AutoPackType.Unpacked)
			};
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x00177320 File Offset: 0x00175520
		public static PlayingCard.ECardSuit Generateds(Reader reader)
		{
			return (PlayingCard.ECardSuit)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x0017733C File Offset: 0x0017553C
		public static PlayingCard.ECardValue Generateds(Reader reader)
		{
			return (PlayingCard.ECardValue)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00177358 File Offset: 0x00175558
		public static NetworkObject[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<NetworkObject>();
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x00177370 File Offset: 0x00175570
		public static RTBGameController.EStage Generateds(Reader reader)
		{
			return (RTBGameController.EStage)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x0017738C File Offset: 0x0017558C
		public static SlotMachine.ESymbol Generateds(Reader reader)
		{
			return (SlotMachine.ESymbol)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x001773A8 File Offset: 0x001755A8
		public static SlotMachine.ESymbol[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<SlotMachine.ESymbol>();
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x001773C0 File Offset: 0x001755C0
		public static EDoorSide Generateds(Reader reader)
		{
			return (EDoorSide)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x001773DC File Offset: 0x001755DC
		public static EVehicleColor Generateds(Reader reader)
		{
			return (EVehicleColor)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x001773F8 File Offset: 0x001755F8
		public static ParkData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ParkData
			{
				lotGUID = reader.ReadGuid(),
				spotIndex = reader.ReadInt32(AutoPackType.Packed),
				alignment = GeneratedReaders___Internal.Read___ScheduleOne.Vehicles.EParkingAlignmentFishNet.Serializing.Generateds(reader)
			};
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00177468 File Offset: 0x00175668
		public static EParkingAlignment Generateds(Reader reader)
		{
			return (EParkingAlignment)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x00177484 File Offset: 0x00175684
		public static TrashContentData Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new TrashContentData
			{
				TrashIDs = GeneratedReaders___Internal.Read___System.String[]FishNet.Serializing.Generateds(reader),
				TrashQuantities = GeneratedReaders___Internal.Read___System.Int32[]FishNet.Serializing.Generateds(reader)
			};
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x001774DC File Offset: 0x001756DC
		public static int[] Generateds(Reader reader)
		{
			return reader.ReadArrayAllocated<int>();
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x001774F4 File Offset: 0x001756F4
		public static Coordinate Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new Coordinate
			{
				x = reader.ReadInt32(AutoPackType.Packed),
				y = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00177558 File Offset: 0x00175758
		public static WeedAppearanceSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new WeedAppearanceSettings
			{
				MainColor = reader.ReadColor32(),
				SecondaryColor = reader.ReadColor32(),
				LeafColor = reader.ReadColor32(),
				StemColor = reader.ReadColor32()
			};
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x001775D4 File Offset: 0x001757D4
		public static CocaineAppearanceSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new CocaineAppearanceSettings
			{
				MainColor = reader.ReadColor32(),
				SecondaryColor = reader.ReadColor32()
			};
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x0017762C File Offset: 0x0017582C
		public static MethAppearanceSettings Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new MethAppearanceSettings
			{
				MainColor = reader.ReadColor32(),
				SecondaryColor = reader.ReadColor32()
			};
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00177684 File Offset: 0x00175884
		public static NewMixOperation Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new NewMixOperation
			{
				ProductID = reader.ReadString(),
				IngredientID = reader.ReadString()
			};
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x001776DC File Offset: 0x001758DC
		public static Recycler.EState Generateds(Reader reader)
		{
			return (Recycler.EState)reader.ReadInt32(AutoPackType.Packed);
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x001776F8 File Offset: 0x001758F8
		public static CoordinateProceduralTilePair Generateds(Reader reader)
		{
			return new CoordinateProceduralTilePair
			{
				coord = GeneratedReaders___Internal.Read___ScheduleOne.Tiles.CoordinateFishNet.Serializing.Generateds(reader),
				tileParent = reader.ReadNetworkObject(),
				tileIndex = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x00177750 File Offset: 0x00175950
		public static List<CoordinateProceduralTilePair> List(Reader reader)
		{
			return reader.ReadListAllocated<CoordinateProceduralTilePair>();
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x00177768 File Offset: 0x00175968
		public static ChemistryCookOperation Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new ChemistryCookOperation
			{
				RecipeID = reader.ReadString(),
				ProductQuality = GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(reader),
				StartLiquidColor = reader.ReadColor(AutoPackType.Packed),
				LiquidLevel = reader.ReadSingle(AutoPackType.Unpacked),
				CurrentTime = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x00177804 File Offset: 0x00175A04
		public static DryingOperation Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new DryingOperation
			{
				ItemID = reader.ReadString(),
				Quantity = reader.ReadInt32(AutoPackType.Packed),
				StartQuality = GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(reader),
				Time = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x0017788C File Offset: 0x00175A8C
		public static OvenCookOperation Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new OvenCookOperation
			{
				IngredientID = reader.ReadString(),
				IngredientQuality = GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(reader),
				IngredientQuantity = reader.ReadInt32(AutoPackType.Packed),
				ProductID = reader.ReadString(),
				CookProgress = reader.ReadInt32(AutoPackType.Packed)
			};
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x00177924 File Offset: 0x00175B24
		public static MixOperation Generateds(Reader reader)
		{
			bool flag = reader.ReadBoolean();
			if (flag)
			{
				return null;
			}
			return new MixOperation
			{
				ProductID = reader.ReadString(),
				ProductQuality = GeneratedReaders___Internal.Read___ScheduleOne.ItemFramework.EQualityFishNet.Serializing.Generateds(reader),
				IngredientID = reader.ReadString(),
				Quantity = reader.ReadInt32(AutoPackType.Packed)
			};
		}
	}
}
