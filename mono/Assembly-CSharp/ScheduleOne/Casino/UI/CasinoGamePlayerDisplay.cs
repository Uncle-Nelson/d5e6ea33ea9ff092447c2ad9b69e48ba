using System;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino.UI
{
	// Token: 0x02000776 RID: 1910
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x000DA10C File Offset: 0x000D830C
		public void RefreshPlayers()
		{
			int currentPlayerCount = this.BindedPlayers.CurrentPlayerCount;
			this.TitleLabel.text = string.Concat(new string[]
			{
				"Players (",
				currentPlayerCount.ToString(),
				"/",
				this.BindedPlayers.PlayerLimit.ToString(),
				")"
			});
			for (int i = 0; i < this.PlayerEntries.Length; i++)
			{
				Player player = this.BindedPlayers.GetPlayer(i);
				if (player != null)
				{
					this.PlayerEntries[i].Find("Container/Name").GetComponent<TextMeshProUGUI>().text = player.PlayerName;
					this.PlayerEntries[i].Find("Container").gameObject.SetActive(true);
				}
				else
				{
					this.PlayerEntries[i].Find("Container").gameObject.SetActive(false);
				}
			}
			this.RefreshScores();
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x000DA200 File Offset: 0x000D8400
		public void RefreshScores()
		{
			int currentPlayerCount = this.BindedPlayers.CurrentPlayerCount;
			for (int i = 0; i < this.PlayerEntries.Length; i++)
			{
				if (currentPlayerCount > i)
				{
					this.PlayerEntries[i].Find("Container/Score").GetComponent<TextMeshProUGUI>().text = MoneyManager.FormatAmount((float)this.BindedPlayers.GetPlayerScore(this.BindedPlayers.GetPlayer(i)), false, false);
				}
			}
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x000DA26C File Offset: 0x000D846C
		public void Bind(CasinoGamePlayers players)
		{
			this.BindedPlayers = players;
			this.BindedPlayers.onPlayerListChanged.AddListener(new UnityAction(this.RefreshPlayers));
			this.BindedPlayers.onPlayerScoresChanged.AddListener(new UnityAction(this.RefreshScores));
			this.RefreshPlayers();
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x000DA2C0 File Offset: 0x000D84C0
		public void Unbind()
		{
			if (this.BindedPlayers == null)
			{
				return;
			}
			this.BindedPlayers.onPlayerListChanged.RemoveListener(new UnityAction(this.RefreshPlayers));
			this.BindedPlayers.onPlayerScoresChanged.RemoveListener(new UnityAction(this.RefreshScores));
			this.BindedPlayers = null;
		}

		// Token: 0x04002549 RID: 9545
		public CasinoGamePlayers BindedPlayers;

		// Token: 0x0400254A RID: 9546
		[Header("References")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x0400254B RID: 9547
		public RectTransform[] PlayerEntries;
	}
}
