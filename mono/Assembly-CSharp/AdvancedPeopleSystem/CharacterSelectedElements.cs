using System;

namespace AdvancedPeopleSystem
{
	// Token: 0x0200021A RID: 538
	[Serializable]
	public class CharacterSelectedElements : ICloneable
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x00035900 File Offset: 0x00033B00
		public object Clone()
		{
			return new CharacterSelectedElements
			{
				Hair = this.Hair,
				Beard = this.Beard,
				Hat = this.Hat,
				Shirt = this.Shirt,
				Pants = this.Pants,
				Shoes = this.Shoes,
				Accessory = this.Accessory,
				Item1 = this.Item1
			};
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00035974 File Offset: 0x00033B74
		public int GetSelectedIndex(CharacterElementType type)
		{
			switch (type)
			{
			case CharacterElementType.Hat:
				return this.Hat;
			case CharacterElementType.Shirt:
				return this.Shirt;
			case CharacterElementType.Pants:
				return this.Pants;
			case CharacterElementType.Shoes:
				return this.Shoes;
			case CharacterElementType.Accessory:
				return this.Accessory;
			case CharacterElementType.Hair:
				return this.Hair;
			case CharacterElementType.Beard:
				return this.Beard;
			case CharacterElementType.Item1:
				return this.Item1;
			default:
				return -1;
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000359E4 File Offset: 0x00033BE4
		public void SetSelectedIndex(CharacterElementType type, int newIndex)
		{
			switch (type)
			{
			case CharacterElementType.Hat:
				this.Hat = newIndex;
				return;
			case CharacterElementType.Shirt:
				this.Shirt = newIndex;
				return;
			case CharacterElementType.Pants:
				this.Pants = newIndex;
				return;
			case CharacterElementType.Shoes:
				this.Shoes = newIndex;
				return;
			case CharacterElementType.Accessory:
				this.Accessory = newIndex;
				return;
			case CharacterElementType.Hair:
				this.Hair = newIndex;
				return;
			case CharacterElementType.Beard:
				this.Beard = newIndex;
				return;
			case CharacterElementType.Item1:
				this.Item1 = newIndex;
				return;
			default:
				return;
			}
		}

		// Token: 0x04000CAC RID: 3244
		public int Hair = -1;

		// Token: 0x04000CAD RID: 3245
		public int Beard = -1;

		// Token: 0x04000CAE RID: 3246
		public int Hat = -1;

		// Token: 0x04000CAF RID: 3247
		public int Shirt = -1;

		// Token: 0x04000CB0 RID: 3248
		public int Pants = -1;

		// Token: 0x04000CB1 RID: 3249
		public int Shoes = -1;

		// Token: 0x04000CB2 RID: 3250
		public int Accessory = -1;

		// Token: 0x04000CB3 RID: 3251
		public int Item1 = -1;
	}
}
