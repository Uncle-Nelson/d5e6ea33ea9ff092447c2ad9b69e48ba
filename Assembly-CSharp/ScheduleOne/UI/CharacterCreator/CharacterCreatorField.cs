using System;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Clothing;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B43 RID: 2883
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x001439A4 File Offset: 0x00141BA4
		// (set) Token: 0x06004CB6 RID: 19638 RVA: 0x001439AC File Offset: 0x00141BAC
		public T value { get; protected set; }

		// Token: 0x06004CB7 RID: 19639 RVA: 0x001439B5 File Offset: 0x00141BB5
		public virtual T ReadValue()
		{
			return Singleton<CharacterCreator>.Instance.ActiveSettings.GetValue<T>(this.PropertyName);
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x001439CC File Offset: 0x00141BCC
		public override void WriteValue(bool applyValue = true)
		{
			base.WriteValue(applyValue);
			Singleton<CharacterCreator>.Instance.SetValue<T>(this.PropertyName, this.value, this.selectedClothingDefinition);
			Singleton<CharacterCreator>.Instance.RefreshCategory(this.Category);
			if (applyValue)
			{
				this.ApplyValue();
			}
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00143A0B File Offset: 0x00141C0B
		public override void ApplyValue()
		{
			base.ApplyValue();
			this.value = this.ReadValue();
		}

		// Token: 0x040039CB RID: 14795
		protected ClothingDefinition selectedClothingDefinition;
	}
}
