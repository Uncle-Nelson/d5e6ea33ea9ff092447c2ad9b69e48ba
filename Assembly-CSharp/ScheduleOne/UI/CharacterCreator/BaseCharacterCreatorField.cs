using System;
using ScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace ScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000B40 RID: 2880
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x06004CA9 RID: 19625 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Awake()
		{
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x000045B1 File Offset: 0x000027B1
		protected virtual void Start()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void ApplyValue()
		{
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void WriteValue(bool applyValue = true)
		{
		}

		// Token: 0x040039BE RID: 14782
		public string PropertyName;

		// Token: 0x040039BF RID: 14783
		public CharacterCreator.ECategory Category;

		// Token: 0x040039C0 RID: 14784
		private CharacterCreator Creator;
	}
}
