using System;
using FishNet.Serializing;
using ScheduleOne.Clothing;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Product;
using ScheduleOne.Storage;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000954 RID: 2388
	public static class ItemSerializers
	{
		// Token: 0x0600407A RID: 16506 RVA: 0x0010EE4C File Offset: 0x0010D04C
		private static ItemInstance Read(this Reader reader)
		{
			if (reader.Remaining == 0)
			{
				return null;
			}
			string text = reader.ReadString();
			if (text == typeof(ItemInstance).Name)
			{
				return reader.DirectReadItemInstance();
			}
			if (text == typeof(StorableItemInstance).Name)
			{
				return reader.DirectReadStorableItemInstance();
			}
			if (text == typeof(CashInstance).Name)
			{
				return reader.DirectReadCashInstance();
			}
			if (text == typeof(ClothingInstance).Name)
			{
				return reader.DirectReadClothingInstance();
			}
			if (text == typeof(QualityItemInstance).Name)
			{
				return reader.DirectReadQualityItemInstance();
			}
			if (text == typeof(ProductItemInstance).Name)
			{
				return reader.DirectReadProductItemInstance();
			}
			if (text == typeof(WeedInstance).Name)
			{
				return reader.DirectReadWeedInstance();
			}
			if (text == typeof(MethInstance).Name)
			{
				return reader.DirectReadMethInstance();
			}
			if (text == typeof(CocaineInstance).Name)
			{
				return reader.DirectReadCocaineInstance();
			}
			if (text == typeof(IntegerItemInstance).Name)
			{
				return reader.DirectReadIntegerItemInstance();
			}
			if (text == typeof(WateringCanInstance).Name)
			{
				return reader.DirectReadWateringCanInstance();
			}
			if (text == typeof(TrashGrabberInstance).Name)
			{
				return reader.DirectReadTrashGrabberInstance();
			}
			if (reader.ReadString() == string.Empty)
			{
				return null;
			}
			Console.LogError("ItemSerializers: reader not found for '" + text + "'!", null);
			return null;
		}

		// Token: 0x0600407B RID: 16507 RVA: 0x0010F000 File Offset: 0x0010D200
		public static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
			if (value is StorableItemInstance)
			{
				writer.WriteStorableItemInstance((StorableItemInstance)value);
				return;
			}
			if (value == null)
			{
				writer.WriteString(typeof(ItemInstance).Name);
				writer.WriteString(string.Empty);
				return;
			}
			writer.WriteString(typeof(ItemInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
		}

		// Token: 0x0600407C RID: 16508 RVA: 0x0010F074 File Offset: 0x0010D274
		public static ItemInstance ReadItemInstance(this Reader reader)
		{
			return reader.Read();
		}

		// Token: 0x0600407D RID: 16509 RVA: 0x0010F07C File Offset: 0x0010D27C
		private static ItemInstance DirectReadItemInstance(this Reader reader)
		{
			reader.ReadString() == string.Empty;
			return null;
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0010F090 File Offset: 0x0010D290
		public static void WriteStorableItemInstance(this Writer writer, StorableItemInstance value)
		{
			if (value is QualityItemInstance)
			{
				writer.WriteQualityItemInstance((QualityItemInstance)value);
				return;
			}
			if (value is CashInstance)
			{
				writer.WriteCashInstance(value as CashInstance);
				return;
			}
			if (value is ClothingInstance)
			{
				writer.WriteClothingInstance(value as ClothingInstance);
				return;
			}
			if (value is IntegerItemInstance)
			{
				writer.WriteIntegerItemInstance(value as IntegerItemInstance);
				return;
			}
			if (value is WateringCanInstance)
			{
				writer.WriteWateringCanInstance(value as WateringCanInstance);
				return;
			}
			if (value is TrashGrabberInstance)
			{
				writer.WriteTrashGrabberInstance(value as TrashGrabberInstance);
				return;
			}
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(StorableItemInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0010F14D File Offset: 0x0010D34D
		public static StorableItemInstance ReadStorableItemInstance(this Reader reader)
		{
			return reader.Read() as StorableItemInstance;
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0010F15C File Offset: 0x0010D35C
		private static StorableItemInstance DirectReadStorableItemInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new StorableItemInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16()
			};
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0010F198 File Offset: 0x0010D398
		public static void WriteCashInstance(this Writer writer, CashInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(CashInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteSingle(value.Balance, AutoPackType.Unpacked);
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0010F1E4 File Offset: 0x0010D3E4
		public static CashInstance ReadCashInstance(this Reader reader)
		{
			return reader.Read() as CashInstance;
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x0010F1F4 File Offset: 0x0010D3F4
		private static CashInstance DirectReadCashInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			CashInstance cashInstance = new CashInstance();
			cashInstance.ID = text;
			cashInstance.Quantity = (int)reader.ReadUInt16();
			cashInstance.SetBalance(reader.ReadSingle(AutoPackType.Unpacked), false);
			return cashInstance;
		}

		// Token: 0x06004084 RID: 16516 RVA: 0x0010F240 File Offset: 0x0010D440
		public static void WriteQualityItemInstance(this Writer writer, QualityItemInstance value)
		{
			if (value is ProductItemInstance)
			{
				writer.WriteProductItemInstance(value as ProductItemInstance);
				return;
			}
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(QualityItemInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Quality);
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x0010F2A1 File Offset: 0x0010D4A1
		public static QualityItemInstance ReadQualityItemInstance(this Reader reader)
		{
			return reader.Read() as QualityItemInstance;
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x0010F2B0 File Offset: 0x0010D4B0
		private static QualityItemInstance DirectReadQualityItemInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new QualityItemInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Quality = (EQuality)reader.ReadUInt16()
			};
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x0010F2F8 File Offset: 0x0010D4F8
		public static void WriteClothingInstance(this Writer writer, ClothingInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(ClothingInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Color);
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0010F344 File Offset: 0x0010D544
		public static ClothingInstance ReadClothingInstance(this Reader reader)
		{
			return reader.Read() as ClothingInstance;
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0010F354 File Offset: 0x0010D554
		private static ClothingInstance DirectReadClothingInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new ClothingInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Color = (EClothingColor)reader.ReadUInt16()
			};
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x0010F39C File Offset: 0x0010D59C
		public static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
			if (value is WeedInstance)
			{
				writer.WriteWeedInstance(value as WeedInstance);
				return;
			}
			if (value is MethInstance)
			{
				writer.WriteMethInstance(value as MethInstance);
				return;
			}
			if (value is CocaineInstance)
			{
				writer.WriteCocaineInstance(value as CocaineInstance);
				return;
			}
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(ProductItemInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Quality);
			writer.WriteString(value.PackagingID);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x0010F433 File Offset: 0x0010D633
		public static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			return reader.Read() as ProductItemInstance;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0010F440 File Offset: 0x0010D640
		private static ProductItemInstance DirectReadProductItemInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new ProductItemInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Quality = (EQuality)reader.ReadUInt16(),
				PackagingID = reader.ReadString()
			};
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0010F494 File Offset: 0x0010D694
		public static void WriteWeedInstance(this Writer writer, WeedInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(WeedInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Quality);
			writer.WriteString(value.PackagingID);
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0010F4EC File Offset: 0x0010D6EC
		public static WeedInstance ReadWeedInstance(this Reader reader)
		{
			return reader.Read() as WeedInstance;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0010F4FC File Offset: 0x0010D6FC
		private static WeedInstance DirectReadWeedInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new WeedInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Quality = (EQuality)reader.ReadUInt16(),
				PackagingID = reader.ReadString()
			};
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0010F550 File Offset: 0x0010D750
		public static void WriteMethInstance(this Writer writer, MethInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(MethInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Quality);
			writer.WriteString(value.PackagingID);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0010F5A8 File Offset: 0x0010D7A8
		public static MethInstance ReadMethInstance(this Reader reader)
		{
			return reader.Read() as MethInstance;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0010F5B8 File Offset: 0x0010D7B8
		private static MethInstance DirectReadMethInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new MethInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Quality = (EQuality)reader.ReadUInt16(),
				PackagingID = reader.ReadString()
			};
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0010F60C File Offset: 0x0010D80C
		public static void WriteCocaineInstance(this Writer writer, CocaineInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(CocaineInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Quality);
			writer.WriteString(value.PackagingID);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0010F664 File Offset: 0x0010D864
		public static CocaineInstance ReadCocaineInstance(this Reader reader)
		{
			return reader.Read() as CocaineInstance;
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x0010F674 File Offset: 0x0010D874
		private static CocaineInstance DirectReadCocaineInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new CocaineInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Quality = (EQuality)reader.ReadUInt16(),
				PackagingID = reader.ReadString()
			};
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x0010F6C8 File Offset: 0x0010D8C8
		public static void WriteIntegerItemInstance(this Writer writer, IntegerItemInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(IntegerItemInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteUInt16((ushort)value.Value);
		}

		// Token: 0x06004097 RID: 16535 RVA: 0x0010F714 File Offset: 0x0010D914
		public static IntegerItemInstance ReadIntegerItemInstance(this Reader reader)
		{
			return reader.Read() as IntegerItemInstance;
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0010F724 File Offset: 0x0010D924
		private static IntegerItemInstance DirectReadIntegerItemInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new IntegerItemInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				Value = (int)reader.ReadUInt16()
			};
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0010F76C File Offset: 0x0010D96C
		public static void WriteWateringCanInstance(this Writer writer, WateringCanInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(WateringCanInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			writer.WriteSingle(value.CurrentFillAmount, AutoPackType.Unpacked);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0010F7B8 File Offset: 0x0010D9B8
		public static WateringCanInstance ReadWateringCanInstance(this Reader reader)
		{
			return reader.Read() as WateringCanInstance;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0010F7C8 File Offset: 0x0010D9C8
		private static WateringCanInstance DirectReadWateringCanInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			return new WateringCanInstance
			{
				ID = text,
				Quantity = (int)reader.ReadUInt16(),
				CurrentFillAmount = reader.ReadSingle(AutoPackType.Unpacked)
			};
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0010F810 File Offset: 0x0010DA10
		public static void WriteTrashGrabberInstance(this Writer writer, TrashGrabberInstance value)
		{
			if (value == null)
			{
				return;
			}
			writer.WriteString(typeof(TrashGrabberInstance).Name);
			writer.WriteString(value.ID);
			writer.WriteUInt16((ushort)value.Quantity);
			string[] array = value.GetTrashIDs().ToArray();
			writer.WriteArray<string>(array, 0, array.Length);
			ushort[] array2 = value.GetTrashUshortQuantities().ToArray();
			writer.WriteArray<ushort>(array2, 0, array2.Length);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0010F87D File Offset: 0x0010DA7D
		public static TrashGrabberInstance ReadTrashGrabberInstance(this Reader reader)
		{
			return reader.Read() as TrashGrabberInstance;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x0010F88C File Offset: 0x0010DA8C
		private static TrashGrabberInstance DirectReadTrashGrabberInstance(this Reader reader)
		{
			string text = reader.ReadString();
			if (text == string.Empty)
			{
				return null;
			}
			TrashGrabberInstance trashGrabberInstance = new TrashGrabberInstance();
			trashGrabberInstance.ID = text;
			trashGrabberInstance.Quantity = (int)reader.ReadUInt16();
			string[] array = new string[20];
			ushort[] array2 = new ushort[20];
			int num = reader.ReadArray<string>(ref array);
			reader.ReadArray<ushort>(ref array2);
			for (int i = 0; i < num; i++)
			{
				trashGrabberInstance.AddTrash(array[i], (int)array2[i]);
			}
			return trashGrabberInstance;
		}

		// Token: 0x04002E58 RID: 11864
		public const bool DEBUG = false;
	}
}
