using System;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.GameTime;
using ScheduleOne.Interaction;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BA0 RID: 2976
	public class Bed : NetworkBehaviour
	{
		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06004FE1 RID: 20449 RVA: 0x00150A2C File Offset: 0x0014EC2C
		// (set) Token: 0x06004FE2 RID: 20450 RVA: 0x00150A34 File Offset: 0x0014EC34
		public Employee AssignedEmployee { get; protected set; }

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00150A3D File Offset: 0x0014EC3D
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.Awake_UserLogic_ScheduleOne.ObjectScripts.Bed_Assembly-CSharp.dll();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00150A54 File Offset: 0x0014EC54
		public void Hovered()
		{
			if (Singleton<ManagementClipboard>.Instance.IsEquipped)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Disabled);
				return;
			}
			if (this.AssignedEmployee != null)
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
				this.intObj.SetMessage("Assigned to " + this.AssignedEmployee.fullName);
				return;
			}
			if (this.CanSleep())
			{
				this.intObj.SetInteractableState(InteractableObject.EInteractableState.Default);
				this.intObj.SetMessage("Sleep");
				return;
			}
			this.intObj.SetInteractableState(InteractableObject.EInteractableState.Invalid);
			this.intObj.SetMessage("Can't sleep before " + ScheduleOne.GameTime.TimeManager.Get12HourTime(1800f, true));
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00150B06 File Offset: 0x0014ED06
		public void Interacted()
		{
			Player.Local.CurrentBed = base.NetworkObject;
			Singleton<SleepCanvas>.Instance.SetIsOpen(true);
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00150B23 File Offset: 0x0014ED23
		private bool CanSleep()
		{
			return GameManager.IS_TUTORIAL || NetworkSingleton<ScheduleOne.GameTime.TimeManager>.Instance.IsCurrentTimeWithinRange(1800, 400);
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x00150B44 File Offset: 0x0014ED44
		public void SetAssignedEmployee(Employee employee)
		{
			this.AssignedEmployee = employee;
			if (this.AssignedEmployee != null)
			{
				this.MugshotSprite.sprite = this.AssignedEmployee.MugshotSprite;
				this.NameLabel.text = this.AssignedEmployee.FirstName + "\n" + this.AssignedEmployee.LastName;
				this.Clipboard.gameObject.SetActive(true);
			}
			else
			{
				this.Clipboard.gameObject.SetActive(false);
			}
			this.UpdateMaterial();
			if (this.onAssignedEmployeeChanged != null)
			{
				this.onAssignedEmployeeChanged.Invoke();
			}
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x00150BE4 File Offset: 0x0014EDE4
		private void UpdateMaterial()
		{
			if (this.BlanketMesh == null)
			{
				return;
			}
			Material material = this.DefaultBlanket;
			if (this.AssignedEmployee != null)
			{
				switch (this.AssignedEmployee.EmployeeType)
				{
				case EEmployeeType.Botanist:
					material = this.BotanistBlanket;
					break;
				case EEmployeeType.Handler:
					material = this.PackagerBlanket;
					break;
				case EEmployeeType.Chemist:
					material = this.ChemistBlanket;
					break;
				case EEmployeeType.Cleaner:
					material = this.CleanerBlanket;
					break;
				}
			}
			this.BlanketMesh.material = material;
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00150C67 File Offset: 0x0014EE67
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00150C7A File Offset: 0x0014EE7A
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00150C8D File Offset: 0x0014EE8D
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00150C9B File Offset: 0x0014EE9B
		private void dll()
		{
			if (this.Clipboard != null)
			{
				this.Clipboard.gameObject.SetActive(false);
			}
			this.UpdateMaterial();
		}

		// Token: 0x04003C35 RID: 15413
		public const int MIN_SLEEP_TIME = 1800;

		// Token: 0x04003C36 RID: 15414
		public const float SLEEP_TIME_SCALE = 1f;

		// Token: 0x04003C38 RID: 15416
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003C39 RID: 15417
		public GameObject Clipboard;

		// Token: 0x04003C3A RID: 15418
		public SpriteRenderer MugshotSprite;

		// Token: 0x04003C3B RID: 15419
		public TextMeshPro NameLabel;

		// Token: 0x04003C3C RID: 15420
		public MeshRenderer BlanketMesh;

		// Token: 0x04003C3D RID: 15421
		[Header("Materials")]
		public Material DefaultBlanket;

		// Token: 0x04003C3E RID: 15422
		public Material BotanistBlanket;

		// Token: 0x04003C3F RID: 15423
		public Material ChemistBlanket;

		// Token: 0x04003C40 RID: 15424
		public Material PackagerBlanket;

		// Token: 0x04003C41 RID: 15425
		public Material CleanerBlanket;

		// Token: 0x04003C42 RID: 15426
		public UnityEvent onAssignedEmployeeChanged;

		// Token: 0x04003C43 RID: 15427
		private bool dll_Excuted;

		// Token: 0x04003C44 RID: 15428
		private bool dll_Excuted;
	}
}
