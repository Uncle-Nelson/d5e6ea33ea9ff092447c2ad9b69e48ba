using System;
using System.Collections.Generic;
using EasyButtons;
using EPOOutline;
using FluffyUnderware.DevTools.Extensions;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Property;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Delivery
{
	// Token: 0x0200071D RID: 1821
	public class LoadingDock : MonoBehaviour, IGUIDRegisterable, ITransitEntity
	{
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000CCA43 File Offset: 0x000CAC43
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x000CCA4B File Offset: 0x000CAC4B
		public LandVehicle DynamicOccupant { get; private set; }

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000CCA54 File Offset: 0x000CAC54
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x000CCA5C File Offset: 0x000CAC5C
		public LandVehicle StaticOccupant { get; private set; }

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000CCA65 File Offset: 0x000CAC65
		public bool IsInUse
		{
			get
			{
				return this.DynamicOccupant != null || this.StaticOccupant != null;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x000CCA83 File Offset: 0x000CAC83
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x000CCA8B File Offset: 0x000CAC8B
		public Guid GUID { get; protected set; }

		// Token: 0x06003144 RID: 12612 RVA: 0x000CCA94 File Offset: 0x000CAC94
		[Button]
		public void RegenerateGUID()
		{
			this.BakedGUID = Guid.NewGuid().ToString();
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000CCABC File Offset: 0x000CACBC
		public string Name
		{
			get
			{
				return "Loading Dock " + (ArrayExt.IndexOf<LoadingDock>(this.ParentProperty.LoadingDocks, this) + 1).ToString();
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x000CCAEE File Offset: 0x000CACEE
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x000CCAF6 File Offset: 0x000CACF6
		public List<ItemSlot> InputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x000CCAFF File Offset: 0x000CACFF
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x000CCB07 File Offset: 0x000CAD07
		public List<ItemSlot> OutputSlots { get; set; } = new List<ItemSlot>();

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x000CCB10 File Offset: 0x000CAD10
		public Transform LinkOrigin
		{
			get
			{
				return this.uiPoint;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000CCB18 File Offset: 0x000CAD18
		public Transform[] AccessPoints
		{
			get
			{
				return this.accessPoints;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x000CCB20 File Offset: 0x000CAD20
		public bool Selectable { get; } = 1;

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000CCB28 File Offset: 0x000CAD28
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x000CCB30 File Offset: 0x000CAD30
		public bool IsAcceptingItems { get; set; }

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000CCB39 File Offset: 0x000CAD39
		// (set) Token: 0x06003150 RID: 12624 RVA: 0x000CCB41 File Offset: 0x000CAD41
		public bool IsDestroyed { get; set; }

		// Token: 0x06003151 RID: 12625 RVA: 0x000CCB4A File Offset: 0x000CAD4A
		private void Awake()
		{
			this.GUID = new Guid(this.BakedGUID);
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000CCB63 File Offset: 0x000CAD63
		private void Start()
		{
			base.InvokeRepeating("RefreshOccupant", Random.Range(0f, 1f), 1f);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000CCB84 File Offset: 0x000CAD84
		public void SetGUID(Guid guid)
		{
			this.GUID = guid;
			GUIDManager.RegisterObject(this);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000CCB94 File Offset: 0x000CAD94
		private void RefreshOccupant()
		{
			LandVehicle closestVehicle = this.VehicleDetector.closestVehicle;
			if (closestVehicle != null && closestVehicle.speed_Kmh < 2f)
			{
				this.SetOccupant(this.VehicleDetector.closestVehicle);
			}
			else
			{
				this.SetOccupant(null);
			}
			if (this.StaticOccupant != null && !this.StaticOccupant.IsVisible)
			{
				this.SetStaticOccupant(null);
			}
			if (this.DynamicOccupant != null)
			{
				Vector3 position = this.DynamicOccupant.transform.position - this.DynamicOccupant.transform.forward * (this.DynamicOccupant.boundingBoxDimensions.z / 2f + 0.6f);
				this.accessPoints[0].transform.position = position;
				this.accessPoints[0].transform.rotation = Quaternion.LookRotation(this.DynamicOccupant.transform.forward, Vector3.up);
				this.accessPoints[0].transform.localPosition = new Vector3(this.accessPoints[0].transform.localPosition.x, 0f, this.accessPoints[0].transform.localPosition.z);
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000CCCE0 File Offset: 0x000CAEE0
		private void SetOccupant(LandVehicle occupant)
		{
			if (occupant == this.DynamicOccupant)
			{
				return;
			}
			Console.Log(string.Concat(new string[]
			{
				"Loading dock ",
				base.name,
				" is ",
				(occupant == null) ? "empty" : "occupied",
				"."
			}), null);
			this.DynamicOccupant = occupant;
			this.InputSlots.Clear();
			this.OutputSlots.Clear();
			if (this.DynamicOccupant != null)
			{
				this.OutputSlots.AddRange(this.DynamicOccupant.Storage.ItemSlots);
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000CCD8C File Offset: 0x000CAF8C
		public void SetStaticOccupant(LandVehicle vehicle)
		{
			this.StaticOccupant = vehicle;
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000CCD98 File Offset: 0x000CAF98
		public virtual void ShowOutline(Color color)
		{
			if (this.OutlineEffect == null)
			{
				this.OutlineEffect = base.gameObject.AddComponent<Outlinable>();
				this.OutlineEffect.OutlineParameters.BlurShift = 0f;
				this.OutlineEffect.OutlineParameters.DilateShift = 0.5f;
				this.OutlineEffect.OutlineParameters.FillPass.Shader = Resources.Load<Shader>("Easy performant outline/Shaders/Fills/ColorFill");
				foreach (GameObject gameObject in this.OutlineRenderers)
				{
					MeshRenderer[] array = new MeshRenderer[0];
					array = new MeshRenderer[]
					{
						gameObject.GetComponent<MeshRenderer>()
					};
					for (int j = 0; j < array.Length; j++)
					{
						OutlineTarget outlineTarget = new OutlineTarget(array[j], 0);
						this.OutlineEffect.TryAddTarget(outlineTarget);
					}
				}
			}
			this.OutlineEffect.OutlineParameters.Color = color;
			Color32 c = color;
			c.a = 9;
			this.OutlineEffect.OutlineParameters.FillPass.SetColor("_PublicColor", c);
			this.OutlineEffect.enabled = true;
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000CCEBD File Offset: 0x000CB0BD
		public virtual void HideOutline()
		{
			if (this.OutlineEffect != null)
			{
				this.OutlineEffect.enabled = false;
			}
		}

		// Token: 0x04002317 RID: 8983
		[SerializeField]
		protected string BakedGUID = string.Empty;

		// Token: 0x0400231D RID: 8989
		public Property ParentProperty;

		// Token: 0x0400231E RID: 8990
		public VehicleDetector VehicleDetector;

		// Token: 0x0400231F RID: 8991
		public ParkingLot Parking;

		// Token: 0x04002320 RID: 8992
		public Transform uiPoint;

		// Token: 0x04002321 RID: 8993
		public Transform[] accessPoints;

		// Token: 0x04002322 RID: 8994
		public GameObject[] OutlineRenderers;

		// Token: 0x04002323 RID: 8995
		private Outlinable OutlineEffect;
	}
}
