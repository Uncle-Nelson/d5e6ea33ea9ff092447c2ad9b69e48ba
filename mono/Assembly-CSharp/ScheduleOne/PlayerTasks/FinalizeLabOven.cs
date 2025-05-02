using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Stations;
using ScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000347 RID: 839
	public class FinalizeLabOven : Task
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00052D9E File Offset: 0x00050F9E
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00052DA6 File Offset: 0x00050FA6
		public LabOven Oven { get; private set; }

		// Token: 0x060012DD RID: 4829 RVA: 0x00052DB0 File Offset: 0x00050FB0
		public FinalizeLabOven(LabOven oven)
		{
			this.Oven = oven;
			this.hammer = oven.CreateHammer();
			this.hammer.onCollision.AddListener(new UnityAction<Collision>(this.Collision));
			this.startSequence = this.Oven.StartCoroutine(this.StartSequence());
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00052E1F File Offset: 0x0005101F
		public override void Update()
		{
			base.Update();
			this.timeSinceLastImpact += Time.deltaTime;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00052E3C File Offset: 0x0005103C
		public override void StopTask()
		{
			if (this.startSequence != null)
			{
				this.Oven.StopCoroutine(this.startSequence);
			}
			Object.Destroy(this.hammer.gameObject);
			this.Oven.RemoveTrayAnimation.Stop();
			this.Oven.ResetSquareTray();
			this.Oven.ClearDecals();
			this.Oven.OutputVisuals.BlockRefreshes = false;
			this.Oven.OutputVisuals.RefreshVisuals();
			this.Oven.Door.SetPosition(0f);
			this.Oven.Door.SetInteractable(false);
			this.Oven.WireTray.SetPosition(0f);
			this.Oven.Button.SetInteractable(false);
			this.Oven.ClearShards();
			Singleton<LabOvenCanvas>.Instance.SetIsOpen(this.Oven, true, true);
			PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(70f, 0.2f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.Oven.CameraPosition_Default.position, this.Oven.CameraPosition_Default.rotation, 0.2f, false);
			base.StopTask();
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00052F6C File Offset: 0x0005116C
		private IEnumerator StartSequence()
		{
			this.Oven.Door.SetPosition(1f);
			this.Oven.WireTray.SetPosition(1f);
			yield return new WaitForSeconds(0.5f);
			this.Oven.SquareTray.SetParent(this.Oven.transform);
			this.Oven.RemoveTrayAnimation.Play();
			yield return new WaitForSeconds(0.1f);
			this.Oven.Door.SetPosition(0f);
			yield return new WaitForSeconds(0.4f);
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.Oven.CameraPosition_Breaking.position, this.Oven.CameraPosition_Breaking.rotation, 0.25f, false);
			base.CurrentInstruction = "Use hammer to break up the product";
			yield break;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00052F7C File Offset: 0x0005117C
		public void Collision(Collision col)
		{
			if (col.collider != this.Oven.CookedLiquidCollider)
			{
				return;
			}
			if (this.hammer.VelocityCalculator.Velocity.magnitude < this.SMASH_VELOCITY_THRESHOLD)
			{
				return;
			}
			if (!this.hammer.Draggable.IsHeld)
			{
				return;
			}
			if (this.timeSinceLastImpact < 0.1f)
			{
				return;
			}
			ContactPoint[] array = new ContactPoint[col.contactCount];
			col.GetContacts(array);
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < array.Length; i++)
			{
				if (Vector3.Distance(array[i].point, this.hammer.ImpactPoint.position) < 0.1f)
				{
					vector = array[i].point;
					break;
				}
			}
			if (vector == Vector3.zero)
			{
				return;
			}
			this.timeSinceLastImpact = 0f;
			this.impactCount++;
			this.Oven.CreateImpactEffects(vector, true);
			if (this.impactCount == 3)
			{
				this.Shatter();
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00053084 File Offset: 0x00051284
		private void Shatter()
		{
			int num = this.Oven.CurrentOperation.Cookable.ProductQuantity * this.Oven.CurrentOperation.IngredientQuantity;
			this.Oven.Shatter(num, this.Oven.CurrentOperation.Cookable.ProductShardPrefab.gameObject);
			this.Oven.OutputVisuals.BlockRefreshes = true;
			ItemInstance productItem = this.Oven.CurrentOperation.GetProductItem(num);
			this.Oven.OutputSlot.AddItem(productItem, false);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("Oven_Cooks_Completed", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("Oven_Cooks_Completed") + 1f).ToString(), true);
			this.Oven.SendCookOperation(null);
			this.Oven.StartCoroutine(this.<Shatter>g__Routine|16_0());
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005315E File Offset: 0x0005135E
		[CompilerGenerated]
		private IEnumerator <Shatter>g__Routine|16_0()
		{
			yield return new WaitForSeconds(1.4f);
			if (base.TaskActive)
			{
				this.Success();
			}
			yield break;
		}

		// Token: 0x04001235 RID: 4661
		public const float MAX_DISTANCE_FROM_IMPACT_POINT = 0.1f;

		// Token: 0x04001236 RID: 4662
		public float SMASH_VELOCITY_THRESHOLD = 1.2f;

		// Token: 0x04001237 RID: 4663
		public const int REQUIRED_IMPACTS = 3;

		// Token: 0x04001239 RID: 4665
		private Coroutine startSequence;

		// Token: 0x0400123A RID: 4666
		private LabOvenHammer hammer;

		// Token: 0x0400123B RID: 4667
		private int impactCount;

		// Token: 0x0400123C RID: 4668
		private float timeSinceLastImpact = 100f;
	}
}
