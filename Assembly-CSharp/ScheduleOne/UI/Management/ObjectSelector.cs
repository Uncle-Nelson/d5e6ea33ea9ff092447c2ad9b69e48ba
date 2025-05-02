using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AFE RID: 2814
	public class ObjectSelector : MonoBehaviour
	{
		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x0013C4DB File Offset: 0x0013A6DB
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x0013C4E3 File Offset: 0x0013A6E3
		public bool IsOpen { get; protected set; }

		// Token: 0x06004B3E RID: 19262 RVA: 0x0013C4EC File Offset: 0x0013A6EC
		private void Start()
		{
			GameInput.RegisterExitListener(new GameInput.ExitDelegate(this.Exit), 12);
			Singleton<ManagementClipboard>.Instance.onClipboardUnequipped.AddListener(new UnityAction(this.ClipboardClosed));
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x0013C51C File Offset: 0x0013A71C
		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, Property property, ObjectSelector.ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, List<Transform> transitLineSources = null)
		{
			this.IsOpen = true;
			this.changesMade = false;
			this.targetProperty = property;
			this.selectionTitle = _selectionTitle;
			if (instruction != string.Empty)
			{
				Singleton<HUD>.Instance.ShowTopScreenText(instruction);
			}
			this.maxSelectedObjects = _maxSelectedObjects;
			this.selectedObjects = new List<BuildableItem>();
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

		// Token: 0x06004B40 RID: 19264 RVA: 0x0013C66C File Offset: 0x0013A86C
		private void UpdateTransitLines()
		{
			float num = 1.5f;
			Vector3 destinationPosition = PlayerSingleton<PlayerCamera>.Instance.transform.position + PlayerSingleton<PlayerCamera>.Instance.transform.forward * num;
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(num, out raycastHit, this.DetectionMask, false, 0f))
			{
				destinationPosition = raycastHit.point;
			}
			for (int i = 0; i < this.transitSources.Count; i++)
			{
				this.transitLines[i].SetSourcePosition(this.transitSources[i].position);
				this.transitLines[i].SetDestinationPosition(destinationPosition);
			}
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x0013C718 File Offset: 0x0013A918
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
			if (pushChanges)
			{
				this.callback(this.selectedObjects);
			}
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0013C81C File Offset: 0x0013AA1C
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

		// Token: 0x06004B43 RID: 19267 RVA: 0x0013C9B9 File Offset: 0x0013ABB9
		private void LateUpdate()
		{
			if (!this.IsOpen)
			{
				return;
			}
			this.UpdateTransitLines();
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x0013C9CC File Offset: 0x0013ABCC
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

		// Token: 0x06004B45 RID: 19269 RVA: 0x0013CA40 File Offset: 0x0013AC40
		private BuildableItem GetHoveredObject()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(5f, out raycastHit, this.DetectionMask, false, 0.1f))
			{
				return raycastHit.collider.GetComponentInParent<BuildableItem>();
			}
			return null;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x0013CA7C File Offset: 0x0013AC7C
		public bool IsObjectTypeValid(BuildableItem obj, out string reason)
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
			if (this.targetProperty != null && obj.ParentProperty != this.targetProperty)
			{
				reason = "Wrong property";
				return false;
			}
			string text;
			if (this.objectFilter != null && !this.objectFilter(obj, out text))
			{
				reason = text;
				return false;
			}
			return true;
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0013CB3C File Offset: 0x0013AD3C
		public void ObjectClicked(BuildableItem obj)
		{
			string text;
			if (!this.IsObjectTypeValid(obj, out text))
			{
				return;
			}
			this.changesMade = true;
			if (!this.selectedObjects.Contains(obj))
			{
				if (this.maxSelectedObjects == 1 && this.selectedObjects.Count == 1)
				{
					BuildableItem buildableItem = this.selectedObjects[0];
					this.selectedObjects.Remove(buildableItem);
					this.SetSelectionOutline(buildableItem, false);
				}
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

		// Token: 0x06004B48 RID: 19272 RVA: 0x0013CC05 File Offset: 0x0013AE05
		private void SetSelectionOutline(BuildableItem obj, bool on)
		{
			if (obj.IsDestroyed)
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

		// Token: 0x06004B49 RID: 19273 RVA: 0x0013CC26 File Offset: 0x0013AE26
		private void ClipboardClosed()
		{
			this.Close(false, false);
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x0013CC30 File Offset: 0x0013AE30
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

		// Token: 0x0400386D RID: 14445
		public const float SELECTION_RANGE = 5f;

		// Token: 0x0400386F RID: 14447
		[Header("Settings")]
		public LayerMask DetectionMask;

		// Token: 0x04003870 RID: 14448
		public Color HoverOutlineColor;

		// Token: 0x04003871 RID: 14449
		public Color SelectOutlineColor;

		// Token: 0x04003872 RID: 14450
		private int maxSelectedObjects;

		// Token: 0x04003873 RID: 14451
		private List<BuildableItem> selectedObjects = new List<BuildableItem>();

		// Token: 0x04003874 RID: 14452
		private List<Type> typeRequirements = new List<Type>();

		// Token: 0x04003875 RID: 14453
		private ObjectSelector.ObjectFilter objectFilter;

		// Token: 0x04003876 RID: 14454
		private Action<List<BuildableItem>> callback;

		// Token: 0x04003877 RID: 14455
		private BuildableItem hoveredObj;

		// Token: 0x04003878 RID: 14456
		private BuildableItem highlightedObj;

		// Token: 0x04003879 RID: 14457
		private string selectionTitle = "";

		// Token: 0x0400387A RID: 14458
		private bool changesMade;

		// Token: 0x0400387B RID: 14459
		private List<Transform> transitSources = new List<Transform>();

		// Token: 0x0400387C RID: 14460
		private List<TransitLineVisuals> transitLines = new List<TransitLineVisuals>();

		// Token: 0x0400387D RID: 14461
		private Property targetProperty;

		// Token: 0x02000AFF RID: 2815
		// (Invoke) Token: 0x06004B4D RID: 19277
		public delegate bool ObjectFilter(BuildableItem obj, out string reason);
	}
}
