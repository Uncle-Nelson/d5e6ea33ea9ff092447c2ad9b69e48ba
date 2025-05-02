using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x02000892 RID: 2194
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x000F9525 File Offset: 0x000F7725
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x000F952D File Offset: 0x000F772D
		public bool ReceiveInput { get; private set; }

		// Token: 0x06003B58 RID: 15192 RVA: 0x000F9538 File Offset: 0x000F7738
		public void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
			this.task = _task;
			this.ReceiveInput = true;
			this.LeftButton.ClickableEnabled = true;
			this.RightButton.ClickableEnabled = true;
			this.DropButton.ClickableEnabled = true;
			this.LoadPackaging(packaging, packagingQuantity);
			this.LoadProduct(product, productQuantity);
			int num = Mathf.RoundToInt(180f / this.DeployAngle);
			for (int i = 0; i < num; i++)
			{
				this.CheckDeployPackaging();
				this.Rotate(this.DeployAngle);
			}
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x000F95BC File Offset: 0x000F77BC
		public void Deinitialize()
		{
			this.ReceiveInput = false;
			if (this.LeftButton.IsHeld)
			{
				this.task.ForceEndClick(this.LeftButton);
			}
			if (this.RightButton.IsHeld)
			{
				this.task.ForceEndClick(this.RightButton);
			}
			if (this.DropButton.IsHeld)
			{
				this.task.ForceEndClick(this.DropButton);
			}
			this.LeftButton.ClickableEnabled = false;
			this.RightButton.ClickableEnabled = false;
			this.DropButton.ClickableEnabled = false;
			for (int i = 0; i < this.ProductInstances.Count; i++)
			{
				Object.Destroy(this.ProductInstances[i].gameObject);
			}
			this.ProductInstances.Clear();
			for (int j = 0; j < this.PackagingInstances.Count; j++)
			{
				Object.Destroy(this.PackagingInstances[j].Container.gameObject);
			}
			this.PackagingInstances.Clear();
			for (int k = 0; k < this.FinalizedPackaging.Count; k++)
			{
				Object.Destroy(this.FinalizedPackaging[k].gameObject);
			}
			this.FinalizedPackaging.Clear();
			if (this.finalizeCoroutine != null)
			{
				base.StopCoroutine(this.finalizeCoroutine);
				this.finalizeCoroutine = null;
			}
			this.UnloadPackaging();
			this.UnloadProduct();
			this.task = null;
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000F9726 File Offset: 0x000F7926
		private void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
			this.PackagingPrefab = prefab;
			this.ConcealedPackaging = quantity;
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000F9736 File Offset: 0x000F7936
		private void UnloadPackaging()
		{
			this.PackagingPrefab = null;
			this.ConcealedPackaging = 0;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x000F9746 File Offset: 0x000F7946
		private void LoadProduct(ProductItemInstance product, int quantity)
		{
			this.ProductItem = product;
			this.ProductPrefab = (product.Definition as ProductDefinition).FunctionalProduct;
			this.ProductInHopper = quantity;
			this.UpdateScreen();
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x000F9772 File Offset: 0x000F7972
		private void UnloadProduct()
		{
			this.ProductPrefab = null;
			this.ProductInHopper = 0;
			this.UpdateScreen();
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x000F9788 File Offset: 0x000F7988
		public void Update()
		{
			this.timeSinceLastDrop += Time.deltaTime;
			this.UpdateInput();
			this.UpdateConveyor();
			if (this.ConcealedPackaging > 0)
			{
				this.CheckDeployPackaging();
			}
			if (this.DropButton.IsHeld && this.ProductInHopper > 0 && this.timeSinceLastDrop > this.DropCooldown)
			{
				this.DropProduct();
			}
			if (Mathf.Abs(this.conveyorVelocity) > 0f && !this.MotorSound.isPlaying)
			{
				this.MotorSound.Play();
			}
			this.MotorSound.VolumeMultiplier = Mathf.Abs(this.conveyorVelocity);
			this.MotorSound.PitchMultiplier = Mathf.Lerp(0.7f, 1f, Mathf.Abs(this.conveyorVelocity));
			if (this.MotorSound.VolumeMultiplier <= 0f)
			{
				this.MotorSound.Stop();
			}
			else if (this.MotorSound.VolumeMultiplier > 0f && !this.MotorSound.isPlaying)
			{
				this.MotorSound.Play();
			}
			this.CheckFinalize();
			this.CheckInsertions();
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x000F98A8 File Offset: 0x000F7AA8
		private void UpdateInput()
		{
			this.directionInput = 0;
			if (!this.ReceiveInput)
			{
				return;
			}
			if (GameInput.GetButton(GameInput.ButtonCode.Left))
			{
				if (!this.LeftButton.IsHeld)
				{
					this.leftDown = true;
					this.task.ForceStartClick(this.LeftButton);
				}
			}
			else if (this.leftDown)
			{
				this.leftDown = false;
				this.task.ForceEndClick(this.LeftButton);
			}
			if (GameInput.GetButton(GameInput.ButtonCode.Right))
			{
				if (!this.RightButton.IsHeld)
				{
					this.rightDown = true;
					this.task.ForceStartClick(this.RightButton);
				}
			}
			else if (this.rightDown)
			{
				this.rightDown = false;
				this.task.ForceEndClick(this.RightButton);
			}
			if (GameInput.GetButton(GameInput.ButtonCode.Jump))
			{
				if (!this.DropButton.IsHeld)
				{
					this.dropDown = true;
					this.task.ForceStartClick(this.DropButton);
				}
			}
			else if (this.dropDown)
			{
				this.dropDown = false;
				this.task.ForceEndClick(this.DropButton);
			}
			if (this.LeftButton.IsHeld)
			{
				this.directionInput--;
			}
			if (this.RightButton.IsHeld)
			{
				this.directionInput++;
			}
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x000F99E8 File Offset: 0x000F7BE8
		private void UpdateScreen()
		{
			this.ProductCountText.text = this.ProductInHopper.ToString();
			this.ProductCountText.gameObject.SetActive(this.ProductInHopper > 0);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x000F9A1C File Offset: 0x000F7C1C
		private void UpdateConveyor()
		{
			float num = Mathf.MoveTowards(this.conveyorVelocity, (float)this.directionInput, this.ConveyorAcceleration * Time.deltaTime);
			this.conveyorVelocity = num;
			this.Rotate(this.conveyorVelocity * this.ConveyorSpeed * Time.deltaTime);
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x000F9A68 File Offset: 0x000F7C68
		private void Rotate(float angle)
		{
			this.ConveyorModel.Rotate(Vector3.forward, -angle);
			for (int i = 0; i < this.PackagingInstances.Count; i++)
			{
				this.PackagingInstances[i].ChangePosition(angle);
			}
			this.PackagingInstances.Sort((PackagingTool.PackagingInstance a, PackagingTool.PackagingInstance b) => a.AnglePosition.CompareTo(b.AnglePosition));
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x000F9ADC File Offset: 0x000F7CDC
		private void CheckDeployPackaging()
		{
			if (this.PackagingInstances.Count > 0 && (this.PackagingInstances[0].AnglePosition < this.DeployAngle || this.PackagingInstances[this.PackagingInstances.Count - 1].AnglePosition > 360f - this.DeployAngle))
			{
				return;
			}
			this.DeployPackaging();
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x000F9B44 File Offset: 0x000F7D44
		private void CheckFinalize()
		{
			if (this.finalizeCoroutine != null)
			{
				return;
			}
			for (int i = 0; i < this.PackagingInstances.Count; i++)
			{
				if (this.PackagingInstances[i].Packaging.IsFull && this.PackagingInstances[i].AnglePosition > 255f && this.PackagingInstances[i].AnglePosition < 270f)
				{
					this.Finalize(this.PackagingInstances[i]);
					return;
				}
			}
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x000F9BCC File Offset: 0x000F7DCC
		private void Finalize(PackagingTool.PackagingInstance instance)
		{
			PackagingTool.<>c__DisplayClass66_0 CS$<>8__locals1 = new PackagingTool.<>c__DisplayClass66_0();
			CS$<>8__locals1.instance = instance;
			CS$<>8__locals1.<>4__this = this;
			this.finalizeInstance = CS$<>8__locals1.instance;
			this.finalizeCoroutine = base.StartCoroutine(CS$<>8__locals1.<Finalize>g__FinalizeRoutine|0());
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000F9C0C File Offset: 0x000F7E0C
		private void DropProduct()
		{
			if (this.ProductInHopper <= 0)
			{
				return;
			}
			this.timeSinceLastDrop = 0f;
			this.ProductInHopper--;
			this.UpdateScreen();
			this.DropSound.Play();
			FunctionalProduct functionalProduct = Object.Instantiate<FunctionalProduct>(this.ProductPrefab, this.HopperDropPoint.position, this.HopperDropPoint.rotation);
			functionalProduct.Initialize(this.ProductItem);
			functionalProduct.transform.SetParent(this.ProductContainer);
			functionalProduct.ClampZ = true;
			functionalProduct.DragProjectionMode = Draggable.EDragProjectionMode.FlatCameraForward;
			functionalProduct.Rb.collisionDetectionMode = 2;
			functionalProduct.Rb.AddForce(Vector3.down * this.ProductInitialForce, 2);
			functionalProduct.Rb.AddTorque(Random.insideUnitSphere * this.ProductRandomTorque, 2);
			this.ProductInstances.Add(functionalProduct);
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x000F9CEC File Offset: 0x000F7EEC
		private void CheckInsertions()
		{
			for (int i = 0; i < this.ProductInstances.Count; i++)
			{
				if (!(this.ProductInstances[i].Rb == null) && !this.ProductInstances[i].Rb.isKinematic && this.HopperInputCollider.bounds.Contains(this.ProductInstances[i].transform.position))
				{
					this.InsertIntoHopper(this.ProductInstances[i]);
					i--;
				}
			}
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x000F9D84 File Offset: 0x000F7F84
		private void InsertIntoHopper(FunctionalProduct product)
		{
			this.ProductInHopper++;
			this.UpdateScreen();
			if (product.IsHeld)
			{
				this.task.ForceEndClick(product);
			}
			Object.Destroy(product.gameObject);
			this.ProductInstances.Remove(product);
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x000F9DD4 File Offset: 0x000F7FD4
		private void DeployPackaging()
		{
			if (this.ConcealedPackaging <= 0)
			{
				return;
			}
			this.ConcealedPackaging--;
			GameObject gameObject = new GameObject("Packaging Container");
			gameObject.transform.SetParent(this.PackagingContainer);
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			FunctionalPackaging functionalPackaging = Object.Instantiate<FunctionalPackaging>(this.PackagingPrefab, gameObject.transform);
			functionalPackaging.AutoEnableSealing = false;
			functionalPackaging.Initialize(this.Station, null, false);
			functionalPackaging.Rb.collisionDetectionMode = 2;
			if (functionalPackaging is FunctionalBaggie)
			{
				functionalPackaging.transform.position = this.BaggieStartPoint.position;
				functionalPackaging.Rb.position = this.BaggieStartPoint.position;
				functionalPackaging.transform.rotation = this.BaggieStartPoint.rotation;
				functionalPackaging.Rb.rotation = this.BaggieStartPoint.rotation;
			}
			else if (functionalPackaging is FunctionalJar)
			{
				functionalPackaging.transform.position = this.JarStartPoint.position;
				functionalPackaging.Rb.position = this.JarStartPoint.position;
				functionalPackaging.transform.rotation = this.JarStartPoint.rotation;
				functionalPackaging.Rb.rotation = this.JarStartPoint.rotation;
			}
			else
			{
				Console.LogError("Unknown packaging type!", null);
			}
			PackagingTool.PackagingInstance packagingInstance = new PackagingTool.PackagingInstance();
			packagingInstance.Container = gameObject.transform;
			packagingInstance.ContainerRb = gameObject.AddComponent<Rigidbody>();
			packagingInstance.ContainerRb.isKinematic = true;
			packagingInstance.ContainerRb.useGravity = false;
			packagingInstance.ContainerRb.collisionDetectionMode = 2;
			packagingInstance.Packaging = functionalPackaging;
			Console.Log("Deployed packaging", null);
			this.PackagingInstances.Insert(0, packagingInstance);
		}

		// Token: 0x04002AD2 RID: 10962
		private const float FinalizeRange_Min = 255f;

		// Token: 0x04002AD3 RID: 10963
		private const float FinalizeRange_Max = 270f;

		// Token: 0x04002AD4 RID: 10964
		[Header("Settings")]
		public float ConveyorSpeed = 1f;

		// Token: 0x04002AD5 RID: 10965
		public float ConveyorAcceleration = 1f;

		// Token: 0x04002AD6 RID: 10966
		public float BaggieRadius = 0.3f;

		// Token: 0x04002AD7 RID: 10967
		public float JarRadius = 0.35f;

		// Token: 0x04002AD8 RID: 10968
		public float DeployAngle = 60f;

		// Token: 0x04002AD9 RID: 10969
		public float ProductInitialForce = 0.2f;

		// Token: 0x04002ADA RID: 10970
		public float ProductRandomTorque = 0.5f;

		// Token: 0x04002ADB RID: 10971
		public float KickForce = 1f;

		// Token: 0x04002ADC RID: 10972
		public float DropCooldown = 0.25f;

		// Token: 0x04002ADD RID: 10973
		[Header("References")]
		public PackagingStation Station;

		// Token: 0x04002ADE RID: 10974
		public Transform ConveyorModel;

		// Token: 0x04002ADF RID: 10975
		public Animation DoorAnim;

		// Token: 0x04002AE0 RID: 10976
		public Animation CapAnim;

		// Token: 0x04002AE1 RID: 10977
		public Animation SealAnim;

		// Token: 0x04002AE2 RID: 10978
		public Animation KickAnim;

		// Token: 0x04002AE3 RID: 10979
		public Clickable LeftButton;

		// Token: 0x04002AE4 RID: 10980
		public Clickable RightButton;

		// Token: 0x04002AE5 RID: 10981
		public Clickable DropButton;

		// Token: 0x04002AE6 RID: 10982
		public Transform PackagingContainer;

		// Token: 0x04002AE7 RID: 10983
		public TextMeshPro ProductCountText;

		// Token: 0x04002AE8 RID: 10984
		public Transform HopperDropPoint;

		// Token: 0x04002AE9 RID: 10985
		public Transform BaggieStartPoint;

		// Token: 0x04002AEA RID: 10986
		public Transform JarStartPoint;

		// Token: 0x04002AEB RID: 10987
		public Transform ProductContainer;

		// Token: 0x04002AEC RID: 10988
		public Transform KickOrigin;

		// Token: 0x04002AED RID: 10989
		public SphereCollider HopperInputCollider;

		// Token: 0x04002AEE RID: 10990
		public AudioSourceController KickSound;

		// Token: 0x04002AEF RID: 10991
		public AudioSourceController MotorSound;

		// Token: 0x04002AF0 RID: 10992
		public AudioSourceController DropSound;

		// Token: 0x04002AF1 RID: 10993
		private FunctionalPackaging PackagingPrefab;

		// Token: 0x04002AF2 RID: 10994
		private int ConcealedPackaging;

		// Token: 0x04002AF3 RID: 10995
		private ProductItemInstance ProductItem;

		// Token: 0x04002AF4 RID: 10996
		private FunctionalProduct ProductPrefab;

		// Token: 0x04002AF5 RID: 10997
		private int ProductInHopper;

		// Token: 0x04002AF6 RID: 10998
		private List<PackagingTool.PackagingInstance> PackagingInstances = new List<PackagingTool.PackagingInstance>();

		// Token: 0x04002AF7 RID: 10999
		private List<FunctionalProduct> ProductInstances = new List<FunctionalProduct>();

		// Token: 0x04002AF8 RID: 11000
		private List<FunctionalPackaging> FinalizedPackaging = new List<FunctionalPackaging>();

		// Token: 0x04002AF9 RID: 11001
		private float conveyorVelocity;

		// Token: 0x04002AFA RID: 11002
		private int directionInput;

		// Token: 0x04002AFB RID: 11003
		private Task task;

		// Token: 0x04002AFC RID: 11004
		private PackagingTool.PackagingInstance finalizeInstance;

		// Token: 0x04002AFD RID: 11005
		private Coroutine finalizeCoroutine;

		// Token: 0x04002AFE RID: 11006
		private bool leftDown;

		// Token: 0x04002AFF RID: 11007
		private bool rightDown;

		// Token: 0x04002B00 RID: 11008
		private bool dropDown;

		// Token: 0x04002B01 RID: 11009
		private float timeSinceLastDrop = 10f;

		// Token: 0x02000893 RID: 2195
		public class PackagingInstance
		{
			// Token: 0x06003B6B RID: 15211 RVA: 0x000FA03C File Offset: 0x000F823C
			public void ChangePosition(float angleDelta)
			{
				this.AnglePosition += angleDelta;
				this.AnglePosition = Mathf.Repeat(this.AnglePosition, 360f);
				Quaternion rhs = Quaternion.Euler(0f, -this.AnglePosition, 0f);
				Quaternion quaternion = this.Container.parent.rotation * rhs;
				this.ContainerRb.MoveRotation(quaternion);
			}

			// Token: 0x04002B02 RID: 11010
			public Transform Container;

			// Token: 0x04002B03 RID: 11011
			public Rigidbody ContainerRb;

			// Token: 0x04002B04 RID: 11012
			public FunctionalPackaging Packaging;

			// Token: 0x04002B05 RID: 11013
			public float AnglePosition;
		}
	}
}
