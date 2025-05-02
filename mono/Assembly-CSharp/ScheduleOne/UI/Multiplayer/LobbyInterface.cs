using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Multiplayer
{
	// Token: 0x02000AD8 RID: 2776
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		// Token: 0x06004A74 RID: 19060 RVA: 0x001389DC File Offset: 0x00136BDC
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<LobbyInterface>.Instance == null || Singleton<LobbyInterface>.Instance != this)
			{
				return;
			}
			this.InviteButton.onClick.AddListener(new UnityAction(this.InviteClicked));
			this.LeaveButton.onClick.AddListener(new UnityAction(this.LeaveClicked));
			Lobby lobby = this.Lobby;
			lobby.onLobbyChange = (Action)Delegate.Combine(lobby.onLobbyChange, new Action(delegate()
			{
				this.UpdateButtons();
				this.UpdatePlayers();
				this.LobbyTitle.text = string.Concat(new string[]
				{
					"Lobby (",
					this.Lobby.PlayerCount.ToString(),
					"/",
					4.ToString(),
					")"
				});
			}));
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00138A6C File Offset: 0x00136C6C
		protected override void Start()
		{
			base.Start();
			if (Singleton<LobbyInterface>.Instance == null || Singleton<LobbyInterface>.Instance != this)
			{
				return;
			}
			this.UpdateButtons();
			this.UpdatePlayers();
			if (PlayerPrefs.GetInt("InviteHintShown", 0) == 0)
			{
				this.InviteHint.SetActive(true);
				return;
			}
			this.InviteHint.SetActive(false);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00138ACC File Offset: 0x00136CCC
		private void LateUpdate()
		{
			if (Singleton<PauseMenu>.InstanceExists)
			{
				this.Canvas.enabled = (Singleton<PauseMenu>.Instance.IsPaused && this.Lobby.IsInLobby && !GameManager.IS_TUTORIAL);
				if (this.Canvas.enabled)
				{
					this.LeaveButton.gameObject.SetActive(false);
					return;
				}
			}
			else
			{
				this.Canvas.enabled = true;
				this.LeaveButton.gameObject.SetActive(!this.Lobby.IsHost);
			}
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00138B58 File Offset: 0x00136D58
		public void SetVisible(bool visible)
		{
			this.Canvas.enabled = visible;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00138B66 File Offset: 0x00136D66
		public void LeaveClicked()
		{
			this.Lobby.LeaveLobby();
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00138B73 File Offset: 0x00136D73
		public void InviteClicked()
		{
			PlayerPrefs.SetInt("InviteHintShown", 1);
			this.InviteHint.SetActive(false);
			this.Lobby.TryOpenInviteInterface();
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x00138B98 File Offset: 0x00136D98
		private void UpdateButtons()
		{
			this.InviteButton.gameObject.SetActive(this.Lobby.IsHost && this.Lobby.PlayerCount < 4);
			this.LeaveButton.gameObject.SetActive(!this.Lobby.IsHost);
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x00138BF4 File Offset: 0x00136DF4
		private void UpdatePlayers()
		{
			if (this.Lobby.IsInLobby)
			{
				for (int i = 0; i < this.PlayerSlots.Length; i++)
				{
					if (this.Lobby.Players[i] != CSteamID.Nil)
					{
						this.SetPlayer(i, this.Lobby.Players[i]);
					}
					else
					{
						this.ClearPlayer(i);
					}
				}
				return;
			}
			this.SetPlayer(0, this.Lobby.LocalPlayerID);
			for (int j = 1; j < this.PlayerSlots.Length; j++)
			{
				this.ClearPlayer(j);
			}
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x00138C8C File Offset: 0x00136E8C
		public void SetPlayer(int index, CSteamID player)
		{
			this.Lobby.Players[index] = player;
			this.PlayerSlots[index].Find("Frame/Avatar").GetComponent<RawImage>().texture = this.GetAvatar(player);
			this.PlayerSlots[index].gameObject.SetActive(true);
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x00138CE1 File Offset: 0x00136EE1
		public void ClearPlayer(int index)
		{
			this.Lobby.Players[index] = CSteamID.Nil;
			this.PlayerSlots[index].gameObject.SetActive(false);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x00138D0C File Offset: 0x00136F0C
		private Texture2D GetAvatar(CSteamID user)
		{
			if (!SteamManager.Initialized)
			{
				Debug.LogWarning("Steamworks not initialized");
				return new Texture2D(0, 0);
			}
			int mediumFriendAvatar = SteamFriends.GetMediumFriendAvatar(user);
			uint num;
			uint num2;
			if (SteamUtils.GetImageSize(mediumFriendAvatar, out num, out num2) && num > 0U && num2 > 0U)
			{
				byte[] array = new byte[num * num2 * 4U];
				Texture2D texture2D = new Texture2D((int)num, (int)num2, TextureFormat.RGBA32, false, false);
				if (SteamUtils.GetImageRGBA(mediumFriendAvatar, array, (int)(num * num2 * 4U)))
				{
					texture2D.LoadRawTextureData(array);
					texture2D.Apply();
				}
				return texture2D;
			}
			Debug.LogWarning("Couldn't get avatar.");
			return new Texture2D(0, 0);
		}

		// Token: 0x040037CD RID: 14285
		[Header("References")]
		public Lobby Lobby;

		// Token: 0x040037CE RID: 14286
		public Canvas Canvas;

		// Token: 0x040037CF RID: 14287
		public TextMeshProUGUI LobbyTitle;

		// Token: 0x040037D0 RID: 14288
		public RectTransform[] PlayerSlots;

		// Token: 0x040037D1 RID: 14289
		public Button InviteButton;

		// Token: 0x040037D2 RID: 14290
		public Button LeaveButton;

		// Token: 0x040037D3 RID: 14291
		public GameObject InviteHint;
	}
}
