using System;
using System.Collections.Generic;
using System.Linq;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200089D RID: 2205
	public class FunctionalPackaging : Draggable
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x000FA3E8 File Offset: 0x000F85E8
		// (set) Token: 0x06003B80 RID: 15232 RVA: 0x000FA3F0 File Offset: 0x000F85F0
		public bool IsSealed { get; protected set; }

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x000FA3F9 File Offset: 0x000F85F9
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x000FA401 File Offset: 0x000F8601
		public bool IsFull { get; protected set; }

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x000FA40A File Offset: 0x000F860A
		// (set) Token: 0x06003B84 RID: 15236 RVA: 0x000FA412 File Offset: 0x000F8612
		public bool ReachedOutput { get; protected set; }

		// Token: 0x06003B85 RID: 15237 RVA: 0x000FA41C File Offset: 0x000F861C
		public virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
			this.station = _station;
			if (align)
			{
				this.AlignTo(alignment);
			}
			this.ClickableEnabled = false;
			base.Rb.isKinematic = true;
			if (this.VelocityCalculator == null)
			{
				this.VelocityCalculator = base.gameObject.AddComponent<SmoothedVelocityCalculator>();
				this.VelocityCalculator.MaxReasonableVelocity = 2f;
			}
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x000FA47C File Offset: 0x000F867C
		public void AlignTo(Transform alignment)
		{
			base.transform.rotation = alignment.rotation * (Quaternion.Inverse(this.AlignmentPoint.rotation) * base.transform.rotation);
			Vector3 b = base.transform.position - this.AlignmentPoint.position;
			base.transform.position = alignment.position + b;
			if (base.Rb == null)
			{
				base.Rb = base.GetComponent<Rigidbody>();
			}
			if (base.Rb != null)
			{
				base.Rb.position = base.transform.position;
				base.Rb.rotation = base.transform.rotation;
			}
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x000FA546 File Offset: 0x000F8746
		public virtual void Destroy()
		{
			Object.Destroy(base.gameObject);
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x000FA554 File Offset: 0x000F8754
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (this.IsFull)
			{
				return;
			}
			foreach (FunctionalProduct functionalProduct in this.productContactTime.Keys.ToList<FunctionalProduct>())
			{
				if (!(functionalProduct.Rb == null) && this.productContactTime[functionalProduct] > this.ProductContactTime && !this.PackedProducts.Contains(functionalProduct) && !functionalProduct.IsHeld)
				{
					this.PackProduct(functionalProduct);
				}
			}
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x000FA5F8 File Offset: 0x000F87F8
		protected virtual void PackProduct(FunctionalProduct product)
		{
			product.ClickableEnabled = false;
			product.ClampZ = false;
			Object.Destroy(product.Rb);
			product.transform.SetParent(base.transform);
			if (this.ProductAlignmentPoints.Length > this.PackedProducts.Count)
			{
				product.transform.position = this.ProductAlignmentPoints[this.PackedProducts.Count].position;
				product.transform.rotation = this.ProductAlignmentPoints[this.PackedProducts.Count].rotation;
			}
			this.PackedProducts.Add(product);
			if (this.PackedProducts.Count >= this.Definition.Quantity && !this.IsFull)
			{
				this.FullyPacked();
			}
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x000FA6BC File Offset: 0x000F88BC
		protected virtual void FullyPacked()
		{
			this.IsFull = true;
			if (this.onFullyPacked != null)
			{
				this.onFullyPacked();
			}
			foreach (FunctionalProduct functionalProduct in this.PackedProducts)
			{
				Object.Destroy(functionalProduct.Rb);
			}
			if (this.AutoEnableSealing)
			{
				this.EnableSealing();
			}
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x000FA73C File Offset: 0x000F893C
		protected virtual void OnTriggerStay(Collider other)
		{
			if (this.station == null)
			{
				return;
			}
			FunctionalProduct componentInParent = other.GetComponentInParent<FunctionalProduct>();
			if (componentInParent != null && componentInParent.IsHeld)
			{
				return;
			}
			if (componentInParent != null)
			{
				if (!this.productContactTime.ContainsKey(componentInParent))
				{
					this.productContactTime.Add(componentInParent, 0f);
				}
				Vector3 velocity = componentInParent.VelocityCalculator.Velocity;
				Vector3 velocity2 = this.VelocityCalculator.Velocity;
				Vector3 vector = velocity - velocity2;
				Debug.DrawRay(componentInParent.transform.position, velocity, Color.red);
				Debug.DrawRay(base.transform.position, velocity2, Color.blue);
				if (vector.magnitude < this.ProductContactMaxVelocity)
				{
					Dictionary<FunctionalProduct, float> dictionary = this.productContactTime;
					FunctionalProduct key = componentInParent;
					dictionary[key] += Time.fixedDeltaTime;
				}
			}
			if (other.gameObject.name == this.station.OutputCollider.name && !this.ReachedOutput && this.IsSealed && !base.IsHeld)
			{
				this.ReachedOutput = true;
				if (this.onReachOutput != null)
				{
					this.onReachOutput();
				}
			}
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x000FA86E File Offset: 0x000F8A6E
		protected virtual void EnableSealing()
		{
			this.ClickableEnabled = true;
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x000FA878 File Offset: 0x000F8A78
		public virtual void Seal()
		{
			this.IsSealed = true;
			foreach (FunctionalProduct functionalProduct in this.PackedProducts)
			{
				Collider[] componentsInChildren = functionalProduct.GetComponentsInChildren<Collider>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].enabled = false;
				}
			}
			if (this.SealSound != null)
			{
				this.SealSound.Play();
			}
			this.HoveredCursor = CursorManager.ECursorType.OpenHand;
			this.ClickableEnabled = true;
			base.Rb.isKinematic = false;
			if (this.onSealed != null)
			{
				this.onSealed();
			}
		}

		// Token: 0x04002B1C RID: 11036
		[Header("Settings")]
		public string SealInstruction = "Seal packaging";

		// Token: 0x04002B1D RID: 11037
		public bool AutoEnableSealing = true;

		// Token: 0x04002B1E RID: 11038
		public float ProductContactTime = 0.1f;

		// Token: 0x04002B1F RID: 11039
		public float ProductContactMaxVelocity = 0.3f;

		// Token: 0x04002B20 RID: 11040
		[Header("References")]
		public PackagingDefinition Definition;

		// Token: 0x04002B21 RID: 11041
		public Transform AlignmentPoint;

		// Token: 0x04002B22 RID: 11042
		public Transform[] ProductAlignmentPoints;

		// Token: 0x04002B23 RID: 11043
		public AudioSourceController SealSound;

		// Token: 0x04002B24 RID: 11044
		protected List<FunctionalProduct> PackedProducts = new List<FunctionalProduct>();

		// Token: 0x04002B25 RID: 11045
		public Action onFullyPacked;

		// Token: 0x04002B26 RID: 11046
		public Action onSealed;

		// Token: 0x04002B27 RID: 11047
		public Action onReachOutput;

		// Token: 0x04002B28 RID: 11048
		private PackagingStation station;

		// Token: 0x04002B29 RID: 11049
		private Dictionary<FunctionalProduct, float> productContactTime = new Dictionary<FunctionalProduct, float>();

		// Token: 0x04002B2A RID: 11050
		private SmoothedVelocityCalculator VelocityCalculator;
	}
}
