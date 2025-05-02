using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000B04 RID: 2820
	public class TransitEntitySelector : MonoBehaviour
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x0013D093 File Offset: 0x0013B293
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x0013D09B File Offset: 0x0013B29B
		public bool IsOpen { get; protected set; }

		// Token: 0x06004B61 RID: 19297 RVA: 0x0013D0A4 File Offset: 0x0013B2A4
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 12);
			Singleton<ManagementClipboard>.Instance.onClipboardUnequipped.AddListener(new UnityAction(this.ClipboardClosed));
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0013D0D4 File Offset: 0x0013B2D4
		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources = null, bool selectingDestination = true)
		{
			this.IsOpen = true;
			this.changesMade = false;
			this.selectDestination = selectingDestination;
			this.selectionTitle = _selectionTitle;
			if (instruction != string.Empty)
			{
				Singleton<HUD>.Instance.ShowTopScreenText(instruction);
			}
			this.maxSelectedObjects = _maxSelectedObjects;
			this.selectedObjects = new List<ITransitEntity>();
			this.selectedObjects.AddRange(_selectedObjects);
			for (int i = 0; i < this.selectedObjects.Count; i++)
			{
				this.SetSelectionOutline(this.selectedObjects[i], true);
			}
			this.objectFilter = _objectFilter;
			this.typeRequirements = _typeRequirements;
			this.callback = _callback;
			this.UpdateInstructions();
			Singleton<ManagementInterface>.Instance.EquippedClipboard.OverrideClipboardText(this.selectionTitle);
			Singleton<ManagementClipboard>.Instance.Close(true);
			if (this.maxSelectedObjects == 1)
			{
				Singleton<InputPromptsCanvas>.Instance.LoadModule("objectselector");
			}
			else
			{
				Singleton<InputPromptsCanvas>.Instance.LoadModule("objectselector_multi");
			}
			if (transitLineSources != null)
			{
				this.transitSources.Clear();
				this.transitSources.AddRange(transitLineSources);
				for (int j = 0; j < this.transitSources.Count; j++)
				{
					TransitLineVisuals item = Object.Instantiate<TransitLineVisuals>(Singleton<ManagementWorldspaceCanvas>.Instance.TransitRouteVisualsPrefab, NetworkSingleton<GameManager>.Instance.Temp);
					this.transitLines.Add(item);
				}
				this.UpdateTransitLines();
			}
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0013D224 File Offset: 0x0013B424
		private void UpdateTransitLines()
		{
			float num = 1.5f;
			Vector3 vector = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * num;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(num, out raycastHit, this.DetectionMask, false, 0f))
			{
				vector = raycastHit.point;
			}
			for (int i = 0; i < this.transitSources.Count; i++)
			{
				if (this.selectDestination)
				{
					this.transitLines[i].SetSourcePosition(this.transitSources[i].position);
					this.transitLines[i].SetDestinationPosition(vector);
				}
				else
				{
					this.transitLines[i].SetSourcePosition(vector);
					this.transitLines[i].SetDestinationPosition(this.transitSources[i].position);
				}
			}
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x0013D310 File Offset: 0x0013B510
		public virtual void Close(bool returnToClipboard, bool pushChanges)
		{
			this.IsOpen = false;
			if (Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "npcselector" || Singleton<InputPromptsCanvas>.Instance.currentModuleLabel == "objectselector_multi")
			{
				Singleton<InputPromptsCanvas>.Instance.UnloadModule();
			}
			for (int i = 0; i < this.selectedObjects.Count; i++)
			{
				this.SetSelectionOutline(this.selectedObjects[i], false);
			}
			Singleton<HUD>.Instance.HideTopScreenText();
			if (returnToClipboard)
			{
				Singleton<ManagementInterface>.Instance.EquippedClipboard.EndOverride();
				Singleton<ManagementClipboard>.Instance.Open(Singleton<ManagementInterface>.Instance.Configurables, Singleton<ManagementInterface>.Instance.EquippedClipboard);
			}
			for (int j = 0; j < this.transitLines.Count; j++)
			{
				Object.Destroy(this.transitLines[j].gameObject);
			}
			this.transitLines.Clear();
			this.transitSources.Clear();
			this.objectFilter = null;
			if (pushChanges)
			{
				this.callback(this.selectedObjects);
			}
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x0013D41C File Offset: 0x0013B61C
		private void Update()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.hoveredObj = this.GetHoveredObject();
			string empty = string.Empty;
			if (this.hoveredObj != null && this.IsObjectTypeValid(this.hoveredObj, out empty))
			{
				if (this.hoveredObj != this.highlightedObj && !this.selectedObjects.Contains(this.hoveredObj))
				{
					if (this.highlightedObj != null)
					{
						if (this.selectedObjects.Contains(this.highlightedObj))
						{
							this.highlightedObj.ShowOutline(this.SelectOutlineColor);
						}
						else
						{
							this.highlightedObj.HideOutline();
						}
						this.highlightedObj = null;
					}
					this.highlightedObj = this.hoveredObj;
					this.hoveredObj.ShowOutline(this.HoverOutlineColor);
				}
			}
			else
			{
				Singleton<HUD>.Instance.CrosshairText.Show(empty, new Color32(byte.MaxValue, 125, 125, byte.MaxValue));
				if (this.highlightedObj != null)
				{
					if (this.selectedObjects.Contains(this.highlightedObj))
					{
						this.highlightedObj.ShowOutline(this.SelectOutlineColor);
					}
					else
					{
						this.highlightedObj.HideOutline();
					}
					this.highlightedObj = null;
				}
			}
			this.UpdateInstructions();
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick) && this.hoveredObj != null && this.IsObjectTypeValid(this.hoveredObj, out empty))
			{
				this.ObjectClicked(this.hoveredObj);
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.Submit) && this.maxSelectedObjects > 1)
			{
				this.Close(true, true);
			}
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x0013D59C File Offset: 0x0013B79C
		private void LateUpdate()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.UpdateTransitLines();
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x0013D5B0 File Offset: 0x0013B7B0
		private void UpdateInstructions()
		{
			string text = this.selectionTitle;
			if (this.maxSelectedObjects > 1)
			{
				text = string.Concat(new string[]
				{
					text,
					" (",
					this.selectedObjects.Count.ToString(),
					"/",
					this.maxSelectedObjects.ToString(),
					")"
				});
			}
			Singleton<HUD>.Instance.ShowTopScreenText(text);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x0013D624 File Offset: 0x0013B824
		private ITransitEntity GetHoveredObject()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(5f, out raycastHit, this.DetectionMask, false, 0.1f))
			{
				return raycastHit.collider.GetComponentInParent<ITransitEntity>();
			}
			return null;
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x0013D660 File Offset: 0x0013B860
		public bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			reason = string.Empty;
			if (this.typeRequirements.Count > 0 && !this.typeRequirements.Contains(obj.GetType()))
			{
				bool flag = false;
				for (int i = 0; i < this.typeRequirements.Count; i++)
				{
					if (obj.GetType().IsAssignableFrom(this.typeRequirements[i]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					reason = "Does not match type requirement";
					return false;
				}
			}
			string text;
			if (this.objectFilter != null && !this.objectFilter(obj, out text))
			{
				reason = text;
				return false;
			}
			return true;
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x0013D6F4 File Offset: 0x0013B8F4
		public void ObjectClicked(ITransitEntity obj)
		{
			string text;
			if (!this.IsObjectTypeValid(obj, out text))
			{
				return;
			}
			this.changesMade = true;
			if (!this.selectedObjects.Contains(obj))
			{
				if (this.selectedObjects.Count < this.maxSelectedObjects)
				{
					this.selectedObjects.Add(obj);
					this.SetSelectionOutline(obj, true);
				}
			}
			else if (this.maxSelectedObjects > 1)
			{
				this.selectedObjects.Remove(obj);
				this.SetSelectionOutline(obj, false);
			}
			if (this.maxSelectedObjects == 1 || !GameInput.GetButton(GameInput.ButtonCode.Sprint))
			{
				this.Close(true, true);
				return;
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x0013D784 File Offset: 0x0013B984
		private void SetSelectionOutline(ITransitEntity obj, bool on)
		{
			if (obj == null)
			{
				return;
			}
			if (on)
			{
				obj.ShowOutline(this.SelectOutlineColor);
				return;
			}
			obj.HideOutline();
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x0013D7A0 File Offset: 0x0013B9A0
		private void ClipboardClosed()
		{
			this.Close(false, false);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x0013D7AA File Offset: 0x0013B9AA
		private void Exit(ExitAction exitAction)
		{
			if (!this.IsOpen)
			{
				return;
			}
			if (exitAction.used)
			{
				return;
			}
			if (exitAction.exitType == ExitType.Escape)
			{
				exitAction.used = true;
				this.Close(true, this.changesMade);
			}
		}

		// Token: 0x04003890 RID: 14480
		public const float SELECTION_RANGE = 5f;

		// Token: 0x04003892 RID: 14482
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04003893 RID: 14483
		public Color HoverOutlineColor;

		// Token: 0x04003894 RID: 14484
		public Color SelectOutlineColor;

		// Token: 0x04003895 RID: 14485
		private int maxSelectedObjects;

		// Token: 0x04003896 RID: 14486
		private List<ITransitEntity> selectedObjects = new List<ITransitEntity>();

		// Token: 0x04003897 RID: 14487
		private List<Type> typeRequirements = new List<Type>();

		// Token: 0x04003898 RID: 14488
		private TransitEntitySelector.ObjectFilter objectFilter;

		// Token: 0x04003899 RID: 14489
		private Action<List<ITransitEntity>> callback;

		// Token: 0x0400389A RID: 14490
		private ITransitEntity hoveredObj;

		// Token: 0x0400389B RID: 14491
		private ITransitEntity highlightedObj;

		// Token: 0x0400389C RID: 14492
		private string selectionTitle = "";

		// Token: 0x0400389D RID: 14493
		private bool changesMade;

		// Token: 0x0400389E RID: 14494
		private List<Transform> transitSources = new List<Transform>();

		// Token: 0x0400389F RID: 14495
		private List<TransitLineVisuals> transitLines = new List<TransitLineVisuals>();

		// Token: 0x040038A0 RID: 14496
		private bool selectDestination = true;

		// Token: 0x02000B05 RID: 2821
		// (Invoke) Token: 0x06004B70 RID: 19312
		public delegate bool ObjectFilter(ITransitEntity obj, out string reason);
	}
}
