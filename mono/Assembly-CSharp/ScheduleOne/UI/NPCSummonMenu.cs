using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x02000A10 RID: 2576
	public class NPCSummonMenu : Singleton<NPCSummonMenu>
	{
		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x001229CF File Offset: 0x00120BCF
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x001229D7 File Offset: 0x00120BD7
		public bool IsOpen { get; private set; }

		// Token: 0x06004561 RID: 17761 RVA: 0x001229E0 File Offset: 0x00120BE0
		protected override void Start()
		{
			base.Start();
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00122A17 File Offset: 0x00120C17
		private void Exit(ExitAction exit)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (exit.used)
			{
				return;
			}
			if (exit.exitType == ExitType.Escape)
			{
				exit.used = true;
				this.Close();
			}
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00122A44 File Offset: 0x00120C44
		public void Open(List<NPC> npcs, Action<NPC> _callback)
		{
			this.IsOpen = true;
			this.Canvas.enabled = true;
			this.Container.gameObject.SetActive(true);
			this.callback = _callback;
			for (int i = 0; i < this.Entries.Length; i++)
			{
				if (npcs.Count > i)
				{
					this.Entries[i].Find("Icon").GetComponent<Image>().sprite = npcs[i].MugshotSprite;
					this.Entries[i].Find("Name").GetComponent<TextMeshProUGUI>().text = npcs[i].fullName;
					this.Entries[i].gameObject.SetActive(true);
					NPC npc = npcs[i];
					this.Entries[i].GetComponent<Button>().onClick.RemoveAllListeners();
					this.Entries[i].GetComponent<Button>().onClick.AddListener(new UnityAction(delegate()
					{
						this.NPCSelected(npc);
					}));
				}
				else
				{
					this.Entries[i].gameObject.SetActive(false);
				}
			}
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
		}

		// Token: 0x06004564 RID: 17764 RVA: 0x00122BA8 File Offset: 0x00120DA8
		public void Close()
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			this.Container.gameObject.SetActive(false);
			this.callback = null;
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
		}

		// Token: 0x06004565 RID: 17765 RVA: 0x00122C1B File Offset: 0x00120E1B
		public void NPCSelected(NPC npc)
		{
			this.callback(npc);
			this.Close();
		}

		// Token: 0x040032ED RID: 13037
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x040032EE RID: 13038
		public RectTransform Container;

		// Token: 0x040032EF RID: 13039
		public RectTransform EntryContainer;

		// Token: 0x040032F0 RID: 13040
		public RectTransform[] Entries;

		// Token: 0x040032F1 RID: 13041
		private Action<NPC> callback;
	}
}
