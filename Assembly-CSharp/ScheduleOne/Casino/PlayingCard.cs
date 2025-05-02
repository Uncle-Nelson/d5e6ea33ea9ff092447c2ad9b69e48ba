using System;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000760 RID: 1888
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x000D6965 File Offset: 0x000D4B65
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x000D696D File Offset: 0x000D4B6D
		public bool IsFaceUp { get; private set; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x000D6976 File Offset: 0x000D4B76
		// (set) Token: 0x06003371 RID: 13169 RVA: 0x000D697E File Offset: 0x000D4B7E
		public PlayingCard.ECardSuit Suit { get; private set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06003372 RID: 13170 RVA: 0x000D6987 File Offset: 0x000D4B87
		// (set) Token: 0x06003373 RID: 13171 RVA: 0x000D698F File Offset: 0x000D4B8F
		public PlayingCard.ECardValue Value { get; private set; }

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06003374 RID: 13172 RVA: 0x000D6998 File Offset: 0x000D4B98
		// (set) Token: 0x06003375 RID: 13173 RVA: 0x000D69A0 File Offset: 0x000D4BA0
		public CardController CardController { get; private set; }

		// Token: 0x06003376 RID: 13174 RVA: 0x000D69A9 File Offset: 0x000D4BA9
		private void OnValidate()
		{
			base.gameObject.name = "PlayingCard (" + this.CardID + ")";
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000D69CB File Offset: 0x000D4BCB
		public void SetCardController(CardController cardController)
		{
			this.CardController = cardController;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000D69D4 File Offset: 0x000D4BD4
		public void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
			if (network && this.CardController != null)
			{
				this.CardController.SendCardValue(this.CardID, suit, value);
				return;
			}
			this.Suit = suit;
			this.Value = value;
			PlayingCard.CardSprite cardSprite = this.GetCardSprite(suit, value);
			if (cardSprite != null)
			{
				this.CardSpriteRenderer.sprite = cardSprite.Sprite;
			}
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000D6A31 File Offset: 0x000D4C31
		public void ClearCard()
		{
			this.SetCard(PlayingCard.ECardSuit.Spades, PlayingCard.ECardValue.Blank, true);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000D6A3C File Offset: 0x000D4C3C
		public void SetFaceUp(bool faceUp, bool network = true)
		{
			if (network && this.CardController != null)
			{
				this.CardController.SendCardFaceUp(this.CardID, faceUp);
			}
			if (this.IsFaceUp == faceUp)
			{
				return;
			}
			this.IsFaceUp = faceUp;
			if (this.IsFaceUp)
			{
				this.FlipAnimation.Play(this.FlipFaceUpClip.name);
			}
			else
			{
				this.FlipAnimation.Play(this.FlipFaceDownClip.name);
			}
			this.FlipSound.Play();
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000D6AC0 File Offset: 0x000D4CC0
		public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
			PlayingCard.<>c__DisplayClass35_0 CS$<>8__locals1 = new PlayingCard.<>c__DisplayClass35_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.duration = duration;
			CS$<>8__locals1.position = position;
			CS$<>8__locals1.rotation = rotation;
			if (network && this.CardController != null)
			{
				this.CardController.SendCardGlide(this.CardID, CS$<>8__locals1.position, CS$<>8__locals1.rotation, CS$<>8__locals1.duration);
				return;
			}
			if (this.lastGlideTarget != null && this.lastGlideTarget.Item1.Equals(CS$<>8__locals1.position) && this.lastGlideTarget.Item2.Equals(CS$<>8__locals1.rotation))
			{
				return;
			}
			this.lastGlideTarget = new Tuple<Vector3, Quaternion>(CS$<>8__locals1.position, CS$<>8__locals1.rotation);
			CS$<>8__locals1.verticalOffset = 0.02f;
			if (this.moveRoutine != null)
			{
				base.StopCoroutine(this.moveRoutine);
			}
			this.moveRoutine = base.StartCoroutine(CS$<>8__locals1.<GlideTo>g__MoveRoutine|0());
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000D6BAC File Offset: 0x000D4DAC
		private PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			return this.CardSprites.FirstOrDefault((PlayingCard.CardSprite x) => x.Suit == suit && x.Value == val);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000D6BE4 File Offset: 0x000D4DE4
		[Button]
		public void VerifyCardSprites()
		{
			List<PlayingCard.CardSprite> list = new List<PlayingCard.CardSprite>(this.CardSprites);
			foreach (object obj in Enum.GetValues(typeof(PlayingCard.ECardSuit)))
			{
				PlayingCard.ECardSuit ecardSuit = (PlayingCard.ECardSuit)obj;
				foreach (object obj2 in Enum.GetValues(typeof(PlayingCard.ECardValue)))
				{
					PlayingCard.ECardValue ecardValue = (PlayingCard.ECardValue)obj2;
					PlayingCard.CardSprite cardSprite = this.GetCardSprite(ecardSuit, ecardValue);
					if (cardSprite == null)
					{
						Debug.LogError(string.Format("Card sprite for {0} {1} is missing.", ecardSuit, ecardValue));
					}
					else if (list.Contains(cardSprite))
					{
						Debug.LogError(string.Format("Card sprite for {0} {1} is duplicated.", ecardSuit, ecardValue));
					}
					else
					{
						list.Add(cardSprite);
					}
				}
			}
		}

		// Token: 0x04002498 RID: 9368
		public string CardID = "card_1";

		// Token: 0x04002499 RID: 9369
		[Header("References")]
		public SpriteRenderer CardSpriteRenderer;

		// Token: 0x0400249A RID: 9370
		public PlayingCard.CardSprite[] CardSprites;

		// Token: 0x0400249B RID: 9371
		public Animation FlipAnimation;

		// Token: 0x0400249C RID: 9372
		public AnimationClip FlipFaceUpClip;

		// Token: 0x0400249D RID: 9373
		public AnimationClip FlipFaceDownClip;

		// Token: 0x0400249E RID: 9374
		[Header("Sound")]
		public AudioSourceController FlipSound;

		// Token: 0x0400249F RID: 9375
		public AudioSourceController LandSound;

		// Token: 0x040024A0 RID: 9376
		private Coroutine moveRoutine;

		// Token: 0x040024A1 RID: 9377
		private Tuple<Vector3, Quaternion> lastGlideTarget;

		// Token: 0x02000761 RID: 1889
		[Serializable]
		public class CardSprite
		{
			// Token: 0x040024A2 RID: 9378
			public PlayingCard.ECardSuit Suit;

			// Token: 0x040024A3 RID: 9379
			public PlayingCard.ECardValue Value;

			// Token: 0x040024A4 RID: 9380
			public Sprite Sprite;
		}

		// Token: 0x02000762 RID: 1890
		public struct CardData
		{
			// Token: 0x06003380 RID: 13184 RVA: 0x000D6D13 File Offset: 0x000D4F13
			public CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
				this.Suit = suit;
				this.Value = value;
			}

			// Token: 0x040024A5 RID: 9381
			public PlayingCard.ECardSuit Suit;

			// Token: 0x040024A6 RID: 9382
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000763 RID: 1891
		public enum ECardSuit
		{
			// Token: 0x040024A8 RID: 9384
			Spades,
			// Token: 0x040024A9 RID: 9385
			Hearts,
			// Token: 0x040024AA RID: 9386
			Diamonds,
			// Token: 0x040024AB RID: 9387
			Clubs
		}

		// Token: 0x02000764 RID: 1892
		public enum ECardValue
		{
			// Token: 0x040024AD RID: 9389
			Blank,
			// Token: 0x040024AE RID: 9390
			Ace,
			// Token: 0x040024AF RID: 9391
			Two,
			// Token: 0x040024B0 RID: 9392
			Three,
			// Token: 0x040024B1 RID: 9393
			Four,
			// Token: 0x040024B2 RID: 9394
			Five,
			// Token: 0x040024B3 RID: 9395
			Six,
			// Token: 0x040024B4 RID: 9396
			Seven,
			// Token: 0x040024B5 RID: 9397
			Eight,
			// Token: 0x040024B6 RID: 9398
			Nine,
			// Token: 0x040024B7 RID: 9399
			Ten,
			// Token: 0x040024B8 RID: 9400
			Jack,
			// Token: 0x040024B9 RID: 9401
			Queen,
			// Token: 0x040024BA RID: 9402
			King
		}
	}
}
