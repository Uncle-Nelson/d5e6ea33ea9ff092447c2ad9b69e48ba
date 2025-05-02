using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000A3A RID: 2618
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06004693 RID: 18067 RVA: 0x00128369 File Offset: 0x00126569
		public bool isOpen
		{
			get
			{
				return this.container.activeSelf;
			}
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x00128376 File Offset: 0x00126576
		protected virtual void Awake()
		{
			Property.onPropertyAcquired = (Property.PropertyChange)Delegate.Combine(Property.onPropertyAcquired, new Property.PropertyChange(this.PropertyAcquired));
			this.container.SetActive(false);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x001283A4 File Offset: 0x001265A4
		protected virtual void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 5);
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x001283B9 File Offset: 0x001265B9
		public virtual void Exit(ExitAction exit)
		{
			if (exit.used)
			{
				return;
			}
			if (exit.exitType == ExitType.RightClick)
			{
				return;
			}
			if (this.container.activeSelf)
			{
				exit.used = true;
				this.Close(true);
			}
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x001283E8 File Offset: 0x001265E8
		public void OpenSelector(PropertySelector.PropertySelected p)
		{
			this.pCallback = p;
			this.container.SetActive(true);
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement(base.name);
			PlayerSingleton<PlayerMovement>.Instance.canMove = false;
			PlayerSingleton<PlayerCamera>.Instance.SetCanLook(false);
			PlayerSingleton<PlayerCamera>.Instance.FreeMouse();
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			Singleton<HUD>.Instance.SetCrosshairVisible(false);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x000045B1 File Offset: 0x000027B1
		private void PropertyAcquired(Property p)
		{
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x0012844E File Offset: 0x0012664E
		private void SelectProperty(Property p)
		{
			this.pCallback(p);
			this.Close(false);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x00128464 File Offset: 0x00126664
		private void Close(bool reenableShit)
		{
			this.container.SetActive(false);
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement(base.name);
			if (reenableShit)
			{
				PlayerSingleton<PlayerMovement>.Instance.canMove = true;
				PlayerSingleton<PlayerCamera>.Instance.SetCanLook(true);
				PlayerSingleton<PlayerCamera>.Instance.LockMouse();
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
				Singleton<HUD>.Instance.SetCrosshairVisible(true);
			}
		}

		// Token: 0x04003420 RID: 13344
		[Header("References")]
		[SerializeField]
		protected GameObject container;

		// Token: 0x04003421 RID: 13345
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x04003422 RID: 13346
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x04003423 RID: 13347
		private PropertySelector.PropertySelected pCallback;

		// Token: 0x02000A3B RID: 2619
		// (Invoke) Token: 0x0600469D RID: 18077
		public delegate void PropertySelected(Property p);
	}
}
