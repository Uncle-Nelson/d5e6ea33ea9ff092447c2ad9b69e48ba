using System;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009EA RID: 2538
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		// Token: 0x06004478 RID: 17528 RVA: 0x0011F25C File Offset: 0x0011D45C
		protected override void Awake()
		{
			base.Awake();
			this.PhoneButton.onClick.AddListener(new UnityAction(this.PhoneClicked));
			this.CharacterButton.onClick.AddListener(new UnityAction(this.CharacterClicked));
			this.Close();
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x0011F2AD File Offset: 0x0011D4AD
		public void Open()
		{
			this.Canvas.enabled = true;
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x0011F2BB File Offset: 0x0011D4BB
		public void Close()
		{
			this.Canvas.enabled = false;
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x0011F2C9 File Offset: 0x0011D4C9
		public void PhoneClicked()
		{
			Singleton<GameplayMenu>.Instance.SetScreen(GameplayMenu.EGameplayScreen.Phone);
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x0011F2D6 File Offset: 0x0011D4D6
		public void CharacterClicked()
		{
			Singleton<GameplayMenu>.Instance.SetScreen(GameplayMenu.EGameplayScreen.Character);
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
		public void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
			GameplayMenuInterface.<>c__DisplayClass11_0 CS$<>8__locals1 = new GameplayMenuInterface.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.pos = Vector2.zero;
			this.PhoneButton.interactable = true;
			this.CharacterButton.interactable = true;
			if (screen == GameplayMenu.EGameplayScreen.Character)
			{
				this.CharacterInterface.Open();
			}
			else
			{
				this.CharacterInterface.Close();
			}
			if (screen != GameplayMenu.EGameplayScreen.Phone)
			{
				if (screen == GameplayMenu.EGameplayScreen.Character)
				{
					CS$<>8__locals1.pos = this.CharacterButton.transform.position;
					this.CharacterButton.interactable = false;
				}
			}
			else
			{
				CS$<>8__locals1.pos = this.PhoneButton.transform.position;
				this.PhoneButton.interactable = false;
			}
			if (this.selectionLerp != null)
			{
				base.StopCoroutine(this.selectionLerp);
			}
			this.selectionLerp = base.StartCoroutine(CS$<>8__locals1.<SetSelected>g__Lerp|0());
		}

		// Token: 0x040031F4 RID: 12788
		public Canvas Canvas;

		// Token: 0x040031F5 RID: 12789
		public Button PhoneButton;

		// Token: 0x040031F6 RID: 12790
		public Button CharacterButton;

		// Token: 0x040031F7 RID: 12791
		public RectTransform SelectionIndicator;

		// Token: 0x040031F8 RID: 12792
		public CharacterInterface CharacterInterface;

		// Token: 0x040031F9 RID: 12793
		private Coroutine selectionLerp;
	}
}
