using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	// Token: 0x02000AC7 RID: 2759
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x06004A31 RID: 18993 RVA: 0x00137150 File Offset: 0x00135350
		public void Awake()
		{
			this.SetVisibility(MessageSenderInterface.EVisibility.Hidden);
			this.ComposeButton.onClick.AddListener(new UnityAction(delegate()
			{
				this.SetVisibility(MessageSenderInterface.EVisibility.Expanded);
			}));
			Button[] cancelButtons = this.CancelButtons;
			for (int i = 0; i < cancelButtons.Length; i++)
			{
				cancelButtons[i].onClick.AddListener(new UnityAction(delegate()
				{
					this.SetVisibility(MessageSenderInterface.EVisibility.Docked);
				}));
			}
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x001371AE File Offset: 0x001353AE
		public void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 15);
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x001371C3 File Offset: 0x001353C3
		private void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (this.Visibility == MessageSenderInterface.EVisibility.Expanded)
			{
				this.SetVisibility(MessageSenderInterface.EVisibility.Docked);
				exit.used = true;
			}
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x001371E8 File Offset: 0x001353E8
		public void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
			this.Visibility = visibility;
			RectTransform[] array = this.DockedUIElements;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].gameObject.SetActive(visibility == MessageSenderInterface.EVisibility.Docked);
			}
			array = this.ExpandedUIElements;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].gameObject.SetActive(visibility == MessageSenderInterface.EVisibility.Expanded);
			}
			if (visibility == MessageSenderInterface.EVisibility.Expanded)
			{
				this.UpdateSendables();
			}
			this.SendablesContainer.gameObject.SetActive(visibility == MessageSenderInterface.EVisibility.Expanded);
			this.Menu.anchoredPosition = new Vector2(0f, (this.Visibility == MessageSenderInterface.EVisibility.Expanded) ? this.ExpandedMenuYPos : this.DockedMenuYPos);
			base.gameObject.SetActive(visibility > MessageSenderInterface.EVisibility.Hidden);
			for (int j = 0; j < this.sendableBubbles.Count; j++)
			{
				this.sendableBubbles[j].RefreshDisplayedText();
			}
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x001372C8 File Offset: 0x001354C8
		public void UpdateSendables()
		{
			for (int i = 0; i < this.sendableBubbles.Count; i++)
			{
				SendableMessage sendableMessage = this.sendableMap[this.sendableBubbles[i]];
				string text;
				if (!sendableMessage.ShouldShow())
				{
					this.sendableBubbles[i].gameObject.SetActive(false);
				}
				else if (sendableMessage.IsValid(out text))
				{
					this.sendableBubbles[i].button.interactable = true;
					this.sendableBubbles[i].gameObject.SetActive(true);
				}
				else
				{
					this.sendableBubbles[i].button.interactable = false;
					this.sendableBubbles[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00137394 File Offset: 0x00135594
		public void AddSendable(SendableMessage sendable)
		{
			MessageBubble component = Object.Instantiate<GameObject>(PlayerSingleton<MessagesApp>.Instance.messageBubblePrefab, this.SendablesContainer).GetComponent<MessageBubble>();
			component.SetupBubble(sendable.Text, MessageBubble.Alignment.Center, true);
			component.button.onClick.AddListener(new UnityAction(delegate()
			{
				this.SendableSelected(sendable);
			}));
			this.sendableBubbles.Add(component);
			this.sendableMap.Add(component, sendable);
			this.UpdateSendables();
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00137423 File Offset: 0x00135623
		protected virtual void SendableSelected(SendableMessage sendable)
		{
			sendable.Send(true, -1);
			this.SetVisibility(MessageSenderInterface.EVisibility.Hidden);
		}

		// Token: 0x0400376A RID: 14186
		public MessageSenderInterface.EVisibility Visibility;

		// Token: 0x0400376B RID: 14187
		[Header("Settings")]
		public float DockedMenuYPos;

		// Token: 0x0400376C RID: 14188
		public float ExpandedMenuYPos;

		// Token: 0x0400376D RID: 14189
		[Header("References")]
		public RectTransform Menu;

		// Token: 0x0400376E RID: 14190
		public RectTransform SendablesContainer;

		// Token: 0x0400376F RID: 14191
		public RectTransform[] DockedUIElements;

		// Token: 0x04003770 RID: 14192
		public RectTransform[] ExpandedUIElements;

		// Token: 0x04003771 RID: 14193
		public Button ComposeButton;

		// Token: 0x04003772 RID: 14194
		public Button[] CancelButtons;

		// Token: 0x04003773 RID: 14195
		private List<MessageBubble> sendableBubbles = new List<MessageBubble>();

		// Token: 0x04003774 RID: 14196
		private Dictionary<MessageBubble, SendableMessage> sendableMap = new Dictionary<MessageBubble, SendableMessage>();

		// Token: 0x02000AC8 RID: 2760
		public enum EVisibility
		{
			// Token: 0x04003776 RID: 14198
			Hidden,
			// Token: 0x04003777 RID: 14199
			Docked,
			// Token: 0x04003778 RID: 14200
			Expanded
		}
	}
}
