using System;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x0200075C RID: 1884
	public class CasinoGameInteraction : MonoBehaviour
	{
		// Token: 0x06003320 RID: 13088 RVA: 0x000D4FC8 File Offset: 0x000D31C8
		private void Awake()
		{
			this.IntObj.onHovered.AddListener(new UnityAction(this.Hovered));
			this.IntObj.onInteractStart.AddListener(new UnityAction(this.Interacted));
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x000D5004 File Offset: 0x000D3204
		private void Hovered()
		{
			if (this.Players.CurrentPlayerCount < this.Players.PlayerLimit)
			{
				this.IntObj.SetMessage("Play " + this.GameName);
				this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				return;
			}
			this.IntObj.SetMessage("Table is full");
			this.IntObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x000D506D File Offset: 0x000D326D
		private void Interacted()
		{
			if (this.Players.CurrentPlayerCount < this.Players.PlayerLimit && this.onLocalPlayerRequestJoin != null)
			{
				this.onLocalPlayerRequestJoin(Player.Local);
			}
		}

		// Token: 0x04002482 RID: 9346
		public string GameName;

		// Token: 0x04002483 RID: 9347
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x04002484 RID: 9348
		public InteractableObject IntObj;

		// Token: 0x04002485 RID: 9349
		public Action<Player> onLocalPlayerRequestJoin;
	}
}
