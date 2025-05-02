using System;
using EasyButtons;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Storage
{
	// Token: 0x020008BA RID: 2234
	public class StorageDoorAnimation : MonoBehaviour
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x000FFF38 File Offset: 0x000FE138
		// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x000FFF40 File Offset: 0x000FE140
		public bool IsOpen { get; protected set; }

		// Token: 0x06003CD5 RID: 15573 RVA: 0x000FFF49 File Offset: 0x000FE149
		private void Start()
		{
			if (this.ItemContainer != null)
			{
				this.ItemContainer.gameObject.SetActive(false);
			}
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000FFF6A File Offset: 0x000FE16A
		[Button]
		public void Open()
		{
			this.SetIsOpen(true);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000FFF73 File Offset: 0x000FE173
		[Button]
		public void Close()
		{
			this.SetIsOpen(false);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000FFF7C File Offset: 0x000FE17C
		public void SetIsOpen(bool open)
		{
			if (this.overriddeIsOpen)
			{
				open = this.overrideState;
			}
			if (this.IsOpen == open)
			{
				return;
			}
			if (open && this.ItemContainer != null)
			{
				this.ItemContainer.gameObject.SetActive(true);
			}
			this.IsOpen = open;
			for (int i = 0; i < this.Anims.Length; i++)
			{
				this.Anims[i].Play(this.IsOpen ? this.OpenAnim.name : this.CloseAnim.name);
			}
			if (this.IsOpen)
			{
				if (this.OpenSound != null)
				{
					this.OpenSound.Play();
				}
			}
			else if (this.CloseSound != null)
			{
				this.CloseSound.Play();
			}
			if (!open)
			{
				base.Invoke("DisableItems", this.CloseAnim.length);
			}
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x00100062 File Offset: 0x000FE262
		private void DisableItems()
		{
			if (this.IsOpen)
			{
				return;
			}
			if (this.ItemContainer != null)
			{
				this.ItemContainer.gameObject.SetActive(false);
			}
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x0010008C File Offset: 0x000FE28C
		public void OverrideState(bool open)
		{
			this.overriddeIsOpen = true;
			this.overrideState = open;
			this.SetIsOpen(open);
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001000A3 File Offset: 0x000FE2A3
		public void ResetOverride()
		{
			this.overriddeIsOpen = false;
		}

		// Token: 0x04002BA8 RID: 11176
		private bool overriddeIsOpen;

		// Token: 0x04002BA9 RID: 11177
		private bool overrideState;

		// Token: 0x04002BAA RID: 11178
		public Transform ItemContainer;

		// Token: 0x04002BAB RID: 11179
		[Header("Animations")]
		public Animation[] Anims;

		// Token: 0x04002BAC RID: 11180
		public AnimationClip OpenAnim;

		// Token: 0x04002BAD RID: 11181
		public AnimationClip CloseAnim;

		// Token: 0x04002BAE RID: 11182
		public AudioSourceController OpenSound;

		// Token: 0x04002BAF RID: 11183
		public AudioSourceController CloseSound;
	}
}
