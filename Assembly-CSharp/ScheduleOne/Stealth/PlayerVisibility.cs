using System;
using System.Collections.Generic;
using System.Linq;
using FishNet.Object;
using ScheduleOne.DevUtilities;
using ScheduleOne.FX;
using ScheduleOne.NPCs;
using ScheduleOne.Vehicles;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Stealth
{
	// Token: 0x020002C5 RID: 709
	public class PlayerVisibility : NetworkBehaviour
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00042C43 File Offset: 0x00040E43
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00042C4B File Offset: 0x00040E4B
		public VisionEvent HighestVisionEvent { get; set; }

		// Token: 0x06000F21 RID: 3873 RVA: 0x00042C54 File Offset: 0x00040E54
		public override void OnStartClient()
		{
			base.OnStartClient();
			if (base.IsOwner)
			{
				this.environmentalVisibility = new VisibilityAttribute("Environmental Brightess", 0f, 1f, -1);
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00042C7F File Offset: 0x00040E7F
		private void FixedUpdate()
		{
			this.UpdateEnvironmentalVisibilityAttribute();
			this.CurrentVisibility = this.CalculateVisibility();
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00042C94 File Offset: 0x00040E94
		private float CalculateVisibility()
		{
			float num = 0f;
			Dictionary<string, float> maxPointsChangesByUniquenessCode = (from UniqueVisibilityAttribute uva in 
				from a in this.activeAttributes
				where a is UniqueVisibilityAttribute
				select a
			group uva by uva.uniquenessCode).ToDictionary((IGrouping<string, UniqueVisibilityAttribute> group) => group.Key, (IGrouping<string, UniqueVisibilityAttribute> group) => group.Max((UniqueVisibilityAttribute uva) => uva.pointsChange));
			this.filteredAttributes = this.activeAttributes.Where(delegate(VisibilityAttribute attr)
			{
				if (attr is UniqueVisibilityAttribute)
				{
					UniqueVisibilityAttribute uniqueVisibilityAttribute = attr as UniqueVisibilityAttribute;
					return uniqueVisibilityAttribute != null && uniqueVisibilityAttribute.pointsChange >= CollectionExtensions.GetValueOrDefault<string, float>(maxPointsChangesByUniquenessCode, uniqueVisibilityAttribute.uniquenessCode, 0f);
				}
				return true;
			}).ToList<VisibilityAttribute>();
			for (int i = 0; i < this.filteredAttributes.Count; i++)
			{
				num += this.filteredAttributes[i].pointsChange;
				if (this.filteredAttributes[i].multiplier != 1f)
				{
					num *= this.filteredAttributes[i].multiplier;
				}
			}
			return Mathf.Clamp(num, 0f, 100f);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x00042DD4 File Offset: 0x00040FD4
		public VisibilityAttribute GetAttribute(string name)
		{
			return this.activeAttributes.Find((VisibilityAttribute x) => x.name.ToLower() == name.ToLower());
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00042E05 File Offset: 0x00041005
		private void UpdateEnvironmentalVisibilityAttribute()
		{
			if (this.environmentalVisibility == null)
			{
				return;
			}
			this.environmentalVisibility.multiplier = Singleton<EnvironmentFX>.Instance.normalizedEnvironmentalBrightness;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00042E28 File Offset: 0x00041028
		public float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
		{
			float num = 0f;
			if (Vector3.Distance(point, base.transform.position) > checkRange + 1f)
			{
				return 0f;
			}
			List<VisionObscurer> list = new List<VisionObscurer>();
			foreach (Transform transform in this.visibilityPoints)
			{
				float num2 = Vector3.Distance(point, transform.position);
				if (num2 <= checkRange)
				{
					this.hits = Physics.RaycastAll(point, (transform.position - point).normalized, Mathf.Min(checkRange, num2), this.visibilityCheckMask, 2).ToList<RaycastHit>();
					for (int i = 0; i < this.hits.Count; i++)
					{
						LandVehicle componentInParent = this.hits[i].collider.GetComponentInParent<LandVehicle>();
						if (checkingNPC != null && componentInParent != null)
						{
							if (checkingNPC.CurrentVehicle == componentInParent)
							{
								this.hits.RemoveAt(i);
								i--;
							}
						}
						else
						{
							VisionObscurer componentInParent2 = this.hits[i].collider.GetComponentInParent<VisionObscurer>();
							if (componentInParent2 != null)
							{
								if (transform == this.visibilityPoints[1] && !list.Contains(componentInParent2))
								{
									list.Add(componentInParent2);
								}
								this.hits.RemoveAt(i);
								i--;
							}
							else if (this.hits[i].collider.isTrigger)
							{
								this.hits.RemoveAt(i);
								i--;
							}
						}
					}
					if (this.hits.Count > 0)
					{
						Debug.DrawRay(point, this.hits[0].point - point, Color.red, 0.1f);
					}
					else
					{
						Debug.DrawRay(point, (transform.position - point).normalized * num2, Color.green, 0.1f);
						num += 1f / (float)this.visibilityPoints.Count;
					}
				}
			}
			float num3 = 1f;
			for (int j = 0; j < list.Count; j++)
			{
				num3 *= 1f - list[j].ObscuranceAmount;
			}
			return num * num3;
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x000430F5 File Offset: 0x000412F5
		public virtual void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00043108 File Offset: 0x00041308
		public virtual void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted = true;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004311B File Offset: 0x0004131B
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0004311B File Offset: 0x0004131B
		public virtual void Awake()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04000F8D RID: 3981
		public const float MAX_VISIBLITY = 100f;

		// Token: 0x04000F8E RID: 3982
		public float CurrentVisibility;

		// Token: 0x04000F8F RID: 3983
		public List<VisibilityAttribute> activeAttributes = new List<VisibilityAttribute>();

		// Token: 0x04000F90 RID: 3984
		public List<VisibilityAttribute> filteredAttributes = new List<VisibilityAttribute>();

		// Token: 0x04000F91 RID: 3985
		[Header("Settings")]
		public LayerMask visibilityCheckMask;

		// Token: 0x04000F92 RID: 3986
		[Header("References")]
		public List<Transform> visibilityPoints = new List<Transform>();

		// Token: 0x04000F93 RID: 3987
		private VisibilityAttribute environmentalVisibility;

		// Token: 0x04000F95 RID: 3989
		private List<RaycastHit> hits;

		// Token: 0x04000F96 RID: 3990
		private bool dll_Excuted;

		// Token: 0x04000F97 RID: 3991
		private bool dll_Excuted;
	}
}
