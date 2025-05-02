using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000AFA RID: 2810
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06004B18 RID: 19224 RVA: 0x0013B825 File Offset: 0x00139A25
		// (set) Token: 0x06004B19 RID: 19225 RVA: 0x0013B82D File Offset: 0x00139A2D
		public bool IsOpen { get; protected set; }

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06004B1A RID: 19226 RVA: 0x0013B836 File Offset: 0x00139A36
		public Property CurrentProperty
		{
			get
			{
				return Player.Local.CurrentProperty;
			}
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0013B844 File Offset: 0x00139A44
		public void Open()
		{
			this.IsOpen = true;
			this.Canvas.enabled = true;
			for (int i = 0; i < this.SelectedConfigurables.Count; i++)
			{
				this.SelectedConfigurables[i].Selected();
				this.SelectedConfigurables[i].ShowOutline(this.SelectedOutlineColor);
			}
			this.UpdateInputPrompt();
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x0013B8A8 File Offset: 0x00139AA8
		public void Close(bool preserveSelection = false)
		{
			this.IsOpen = false;
			this.Canvas.enabled = false;
			if (this.OutlinedConfigurable != null && !this.SelectedConfigurables.Contains(this.OutlinedConfigurable))
			{
				this.OutlinedConfigurable.Deselected();
				this.OutlinedConfigurable.HideOutline();
				this.OutlinedConfigurable = null;
			}
			if (this.HoveredConfigurable != null)
			{
				this.HoveredConfigurable.HideOutline();
				this.HoveredConfigurable = null;
			}
			if (!preserveSelection)
			{
				this.ClearSelection();
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0013B924 File Offset: 0x00139B24
		private void Update()
		{
			if (Player.Local == null)
			{
				return;
			}
			this.UpdateUIs();
			if (this.IsOpen)
			{
				IConfigurable hoveredConfigurable = this.GetHoveredConfigurable();
				if (hoveredConfigurable != null && !hoveredConfigurable.IsBeingConfiguredByOtherPlayer)
				{
					this.HoveredConfigurable = hoveredConfigurable;
				}
				else
				{
					this.HoveredConfigurable = null;
				}
				this.UpdateSelection();
			}
			else if (this.HoveredConfigurable != null)
			{
				this.HoveredConfigurable.Deselected();
				this.HoveredConfigurable.HideOutline();
				this.HoveredConfigurable = null;
			}
			this.UpdateInputPrompt();
			if (Player.Local.CurrentProperty == null)
			{
				this.ClearSelection();
			}
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0013B9BC File Offset: 0x00139BBC
		private void UpdateInputPrompt()
		{
			List<IConfigurable> list = new List<IConfigurable>();
			if (this.HoveredConfigurable != null && !this.SelectedConfigurables.Contains(this.HoveredConfigurable))
			{
				list.Add(this.HoveredConfigurable);
			}
			list.AddRange(this.SelectedConfigurables);
			if (list.Count == 0)
			{
				this.HideCrosshairPrompt();
				return;
			}
			bool flag = true;
			if (list.Count > 1)
			{
				for (int i = 0; i < list.Count - 1; i++)
				{
					if (list[i].ConfigurableType != list[i + 1].ConfigurableType)
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this.HideCrosshairPrompt();
				return;
			}
			string typeName = ConfigurableType.GetTypeName(list[0].ConfigurableType);
			if (list.Count > 1)
			{
				this.ShowCrosshairPrompt("Manage " + list.Count.ToString() + "x " + typeName);
				return;
			}
			this.ShowCrosshairPrompt("Manage " + typeName);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0013BAAC File Offset: 0x00139CAC
		private void UpdateUIs()
		{
			foreach (Property property in Property.OwnedProperties)
			{
				float num = Vector3.Distance(property.transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position);
				property.WorldspaceUIContainer.gameObject.SetActive(this.IsOpen && num < 50f);
			}
			List<IConfigurable> configurablesToShow = this.GetConfigurablesToShow();
			this.RemoveNullConfigurables();
			for (int i = 0; i < this.ShownConfigurables.Count; i++)
			{
				if (!configurablesToShow.Contains(this.ShownConfigurables[i]) && this.ShownConfigurables[i].WorldspaceUI.IsEnabled)
				{
					IConfigurable config = this.ShownConfigurables[i];
					this.ShownConfigurables[i].WorldspaceUI.Hide(delegate
					{
						this.ShownConfigurables.Remove(config);
					});
				}
			}
			for (int j = 0; j < configurablesToShow.Count; j++)
			{
				if (!this.ShownConfigurables.Contains(configurablesToShow[j]))
				{
					configurablesToShow[j].WorldspaceUI.Show();
					if (!this.ShownConfigurables.Contains(configurablesToShow[j]))
					{
						this.ShownConfigurables.Add(configurablesToShow[j]);
					}
				}
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0013BC34 File Offset: 0x00139E34
		private void LateUpdate()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			this.RemoveNullConfigurables();
			this.ShownConfigurables.Sort((IConfigurable a, IConfigurable b) => Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, a.UIPoint.position).CompareTo(Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, b.UIPoint.position)));
			for (int i = 0; i < this.ShownConfigurables.Count; i++)
			{
				this.ShownConfigurables[i].WorldspaceUI.SetInternalScale(this.ScaleCurve.Evaluate(Vector3.Distance(PlayerSingleton<PlayerCamera>.Instance.transform.position, this.ShownConfigurables[i].UIPoint.position) / 5f));
				this.ShownConfigurables[i].WorldspaceUI.UpdatePosition(this.ShownConfigurables[i].UIPoint.position);
				this.ShownConfigurables[i].WorldspaceUI.transform.SetAsFirstSibling();
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0013BD30 File Offset: 0x00139F30
		private void UpdateSelection()
		{
			if (GameInput.GetButtonDown(GameInput.ButtonCode.SecondaryClick))
			{
				this.ClearSelection();
			}
			if (this.HoveredConfigurable == null)
			{
				if (this.OutlinedConfigurable != null && !this.SelectedConfigurables.Contains(this.OutlinedConfigurable))
				{
					this.OutlinedConfigurable.Deselected();
					this.OutlinedConfigurable.HideOutline();
					this.OutlinedConfigurable = null;
				}
				return;
			}
			if (this.HoveredConfigurable != null && this.HoveredConfigurable.IsBeingConfiguredByOtherPlayer)
			{
				this.HoveredConfigurable.Deselected();
				this.HoveredConfigurable.HideOutline();
				this.HoveredConfigurable = null;
				return;
			}
			for (int i = 0; i < this.SelectedConfigurables.Count; i++)
			{
				if (this.SelectedConfigurables[i].IsBeingConfiguredByOtherPlayer)
				{
					this.RemoveFromSelection(this.SelectedConfigurables[i]);
					i--;
				}
			}
			if (!this.SelectedConfigurables.Contains(this.HoveredConfigurable) && this.OutlinedConfigurable != this.HoveredConfigurable)
			{
				if (this.OutlinedConfigurable != null && !this.SelectedConfigurables.Contains(this.OutlinedConfigurable))
				{
					this.OutlinedConfigurable.Deselected();
					this.OutlinedConfigurable.HideOutline();
					this.OutlinedConfigurable = null;
				}
				this.HoveredConfigurable.Selected();
				this.HoveredConfigurable.ShowOutline(this.HoveredOutlineColor);
				this.OutlinedConfigurable = this.HoveredConfigurable;
			}
			if (this.HoveredConfigurable == null || !this.HoveredConfigurable.CanBeSelected)
			{
				return;
			}
			if (GameInput.GetButtonDown(GameInput.ButtonCode.PrimaryClick))
			{
				if (this.SelectedConfigurables.Contains(this.HoveredConfigurable))
				{
					this.RemoveFromSelection(this.HoveredConfigurable);
					return;
				}
				this.AddToSelection(this.HoveredConfigurable);
			}
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0013BEC9 File Offset: 0x0013A0C9
		private void AddToSelection(IConfigurable config)
		{
			if (this.SelectedConfigurables.Contains(config))
			{
				return;
			}
			config.ShowOutline(this.SelectedOutlineColor);
			config.Selected();
			this.SelectedConfigurables.Add(config);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0013BEF8 File Offset: 0x0013A0F8
		private void RemoveFromSelection(IConfigurable config)
		{
			if (this.HoveredConfigurable != config)
			{
				config.Deselected();
				config.HideOutline();
			}
			else
			{
				config.ShowOutline(this.HoveredOutlineColor);
			}
			if (this.SelectedConfigurables.Contains(config))
			{
				this.SelectedConfigurables.Remove(config);
			}
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0013BF38 File Offset: 0x0013A138
		private void ClearSelection()
		{
			IConfigurable[] array = this.SelectedConfigurables.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				this.RemoveFromSelection(array[i]);
			}
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0013BF68 File Offset: 0x0013A168
		private void RemoveNullConfigurables()
		{
			for (int i = 0; i < this.ShownConfigurables.Count; i++)
			{
				if (this.ShownConfigurables[i].IsDestroyed)
				{
					this.ShownConfigurables.RemoveAt(i);
					i--;
				}
			}
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0013BFB0 File Offset: 0x0013A1B0
		private IConfigurable GetHoveredConfigurable()
		{
			RaycastHit raycastHit;
			if (PlayerSingleton<PlayerCamera>.Instance.LookRaycast(5f, out raycastHit, this.ObjectSelectionLayerMask, true, 0f))
			{
				IConfigurable componentInParent = raycastHit.collider.GetComponentInParent<IConfigurable>();
				if (componentInParent != null)
				{
					return componentInParent;
				}
			}
			return null;
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0013BFF0 File Offset: 0x0013A1F0
		private List<IConfigurable> GetConfigurablesToShow()
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return new List<IConfigurable>();
			}
			List<IConfigurable> list = new List<IConfigurable>();
			if (this.CurrentProperty != null && this.CurrentProperty.IsOwned)
			{
				for (int i = 0; i < this.CurrentProperty.Configurables.Count; i++)
				{
					if (this.CurrentProperty.Configurables[i] != null && !this.CurrentProperty.Configurables[i].IsDestroyed && Vector3.Distance(this.CurrentProperty.Configurables[i].Transform.position, PlayerSingleton<PlayerCamera>.Instance.transform.position) <= 5f)
					{
						list.Add(this.CurrentProperty.Configurables[i]);
					}
				}
			}
			for (int j = 0; j < this.SelectedConfigurables.Count; j++)
			{
				if (!list.Contains(this.SelectedConfigurables[j]))
				{
					list.Add(this.SelectedConfigurables[j]);
				}
			}
			if (!list.Contains(this.HoveredConfigurable) && this.HoveredConfigurable != null)
			{
				list.Add(this.HoveredConfigurable);
			}
			return list;
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0013C126 File Offset: 0x0013A326
		public void ShowCrosshairPrompt(string message)
		{
			this.CrosshairPrompt.SetLabel(message);
			this.CrosshairPrompt.gameObject.SetActive(true);
			this.CrosshairPrompt.transform.SetAsLastSibling();
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0013C155 File Offset: 0x0013A355
		public void HideCrosshairPrompt()
		{
			this.CrosshairPrompt.gameObject.SetActive(false);
		}

		// Token: 0x04003853 RID: 14419
		public const float VISIBILITY_RANGE = 5f;

		// Token: 0x04003854 RID: 14420
		public const float PROPERTY_CANVAS_RANGE = 50f;

		// Token: 0x04003856 RID: 14422
		[Header("References")]
		public Canvas Canvas;

		// Token: 0x04003857 RID: 14423
		public AnimationCurve ScaleCurve;

		// Token: 0x04003858 RID: 14424
		public TransitLineVisuals TransitRouteVisualsPrefab;

		// Token: 0x04003859 RID: 14425
		public InputPrompt CrosshairPrompt;

		// Token: 0x0400385A RID: 14426
		[Header("Settings")]
		public LayerMask ObjectSelectionLayerMask;

		// Token: 0x0400385B RID: 14427
		public Color HoveredOutlineColor = Color.white;

		// Token: 0x0400385C RID: 14428
		public Color SelectedOutlineColor = Color.white;

		// Token: 0x0400385D RID: 14429
		private List<IConfigurable> ShownConfigurables = new List<IConfigurable>();

		// Token: 0x0400385E RID: 14430
		public IConfigurable HoveredConfigurable;

		// Token: 0x0400385F RID: 14431
		private IConfigurable OutlinedConfigurable;

		// Token: 0x04003860 RID: 14432
		public List<IConfigurable> SelectedConfigurables = new List<IConfigurable>();
	}
}
