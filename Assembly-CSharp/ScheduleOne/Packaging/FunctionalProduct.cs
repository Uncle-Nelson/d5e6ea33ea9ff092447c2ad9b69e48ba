using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200089E RID: 2206
	public class FunctionalProduct : Draggable
	{
		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x000FA981 File Offset: 0x000F8B81
		// (set) Token: 0x06003B90 RID: 15248 RVA: 0x000FA989 File Offset: 0x000F8B89
		public SmoothedVelocityCalculator VelocityCalculator { get; private set; }

		// Token: 0x06003B91 RID: 15249 RVA: 0x000FA994 File Offset: 0x000F8B94
		public virtual void Initialize(PackagingStation station, ItemInstance item, Transform alignment, bool align = true)
		{
			if (align)
			{
				this.AlignTo(alignment);
			}
			this.startLocalPos = base.transform.localPosition;
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Task"));
			this.InitializeVisuals(item);
			base.Rb.collisionDetectionMode = 2;
			if (this.VelocityCalculator == null)
			{
				this.VelocityCalculator = base.gameObject.AddComponent<SmoothedVelocityCalculator>();
				this.VelocityCalculator.MaxReasonableVelocity = 2f;
			}
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x000FAA14 File Offset: 0x000F8C14
		public virtual void Initialize(ItemInstance item)
		{
			this.startLocalPos = base.transform.localPosition;
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Task"));
			this.InitializeVisuals(item);
			base.Rb.collisionDetectionMode = 2;
			if (this.VelocityCalculator == null)
			{
				this.VelocityCalculator = base.gameObject.AddComponent<SmoothedVelocityCalculator>();
				this.VelocityCalculator.MaxReasonableVelocity = 2f;
			}
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x000FAA8C File Offset: 0x000F8C8C
		public virtual void InitializeVisuals(ItemInstance item)
		{
			ProductItemInstance productItemInstance = item as ProductItemInstance;
			if (productItemInstance == null)
			{
				Console.LogError("Item instance is not a product instance!", null);
				return;
			}
			productItemInstance.SetupPackagingVisuals(this.Visuals);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x000FAABC File Offset: 0x000F8CBC
		public void AlignTo(Transform alignment)
		{
			base.transform.rotation = alignment.rotation * (Quaternion.Inverse(this.AlignmentPoint.rotation) * base.transform.rotation);
			base.transform.position = alignment.position + (base.transform.position - this.AlignmentPoint.position);
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x000FAB30 File Offset: 0x000F8D30
		protected override void FixedUpdate()
		{
			base.FixedUpdate();
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x000FAB38 File Offset: 0x000F8D38
		protected override void LateUpdate()
		{
			base.LateUpdate();
			if (this.ClampZ)
			{
				this.Clamp();
			}
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x000FAB50 File Offset: 0x000F8D50
		private void Clamp()
		{
			float num = Mathf.Clamp(Mathf.Abs(base.transform.localPosition.x / this.startLocalPos.x), 0f, 1f);
			float num2 = Mathf.Min(Mathf.Abs(this.startLocalPos.z) * num, this.lowestMaxZ);
			this.lowestMaxZ = num2;
			Vector3 vector = base.transform.parent.InverseTransformPoint(base.originalHitPoint);
			vector.z = Mathf.Clamp(vector.z, -num2, num2);
			Vector3 originalHitPoint = base.transform.parent.TransformPoint(vector);
			base.SetOriginalHitPoint(originalHitPoint);
		}

		// Token: 0x04002B2B RID: 11051
		public bool ClampZ = true;

		// Token: 0x04002B2C RID: 11052
		[Header("References")]
		public Transform AlignmentPoint;

		// Token: 0x04002B2D RID: 11053
		public FilledPackagingVisuals Visuals;

		// Token: 0x04002B2E RID: 11054
		private Vector3 startLocalPos;

		// Token: 0x04002B2F RID: 11055
		private float lowestMaxZ = 500f;
	}
}
