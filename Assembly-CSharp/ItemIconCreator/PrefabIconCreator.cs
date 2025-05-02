using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemIconCreator
{
	// Token: 0x02000226 RID: 550
	[ExecuteInEditMode]
	public class PrefabIconCreator : IconCreator
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x00036946 File Offset: 0x00034B46
		public override void BuildIcons()
		{
			base.StartCoroutine(this.BuildAllIcons());
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00036955 File Offset: 0x00034B55
		public override bool CheckConditions()
		{
			if (!base.CheckConditions())
			{
				return false;
			}
			if (this.itemsToShot.Length == 0)
			{
				Debug.LogError("There's no prefab to shoot");
				return false;
			}
			if (this.itemPosition == null)
			{
				Debug.LogError("Item position is null");
				return false;
			}
			return true;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00036994 File Offset: 0x00034B94
		protected override void Update()
		{
			if (this.preview && !this.isCreatingIcons)
			{
				if (this.instantiatedItem != null)
				{
					if (this.dynamicFov)
					{
						base.UpdateFOV(this.instantiatedItem);
					}
					if (this.lookAtObjectCenter)
					{
						base.LookAtTargetCenter(this.instantiatedItem);
					}
					this.instantiatedItem.transform.position = this.itemPosition.transform.position;
					this.instantiatedItem.transform.rotation = this.itemPosition.transform.rotation;
				}
				else if (this.instantiatedItem == null && this.itemsToShot.Length != 0)
				{
					this.ClearShit();
					if (this.itemPosition.childCount > 0 && this.itemPosition.GetChild(0).GetComponent<MeshRenderer>() != null)
					{
						this.instantiatedItem = this.itemPosition.GetChild(0).gameObject;
					}
					else
					{
						this.instantiatedItem = Object.Instantiate<GameObject>(this.itemsToShot[0], this.itemPosition.transform.position, this.itemPosition.transform.rotation, this.itemPosition);
					}
				}
			}
			base.Update();
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00036AD4 File Offset: 0x00034CD4
		private void ClearShit()
		{
			List<Transform> list = new List<Transform>();
			for (int i = 0; i < this.itemPosition.childCount; i++)
			{
				list.Add(this.itemPosition.GetChild(i));
			}
			for (int j = 0; j < list.Count; j++)
			{
				Object.DestroyImmediate(list[j].gameObject);
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00036B31 File Offset: 0x00034D31
		public IEnumerator BuildAllIcons()
		{
			base.Initialize();
			int num;
			for (int i = 0; i < this.itemsToShot.Length; i = num + 1)
			{
				this.finalPath = "C:/Users/Tyler/Desktop/";
				if (this.instantiatedItem != null)
				{
					Object.DestroyImmediate(this.instantiatedItem);
				}
				if (this.whiteCam != null)
				{
					this.whiteCam.enabled = false;
				}
				if (this.blackCam != null)
				{
					this.blackCam.enabled = false;
				}
				this.ClearShit();
				this.instantiatedItem = Object.Instantiate<GameObject>(this.itemsToShot[i], this.itemPosition.transform.position, this.itemPosition.transform.rotation);
				if (IconCreatorCanvas.instance != null)
				{
					IconCreatorCanvas.instance.SetInfo(this.itemsToShot.Length, i, this.itemsToShot[i].name, true, this.nextIconKey);
				}
				this.currentObject = this.instantiatedItem.transform;
				if (this.dynamicFov)
				{
					base.UpdateFOV(this.instantiatedItem);
				}
				if (this.lookAtObjectCenter)
				{
					base.LookAtTargetCenter(this.instantiatedItem);
				}
				if (this.mode == IconCreator.Mode.Manual)
				{
					this.CanMove = true;
					yield return new WaitUntil(() => Input.GetKeyDown(this.nextIconKey));
					this.CanMove = false;
				}
				if (IconCreatorCanvas.instance != null)
				{
					IconCreatorCanvas.instance.SetTakingPicture();
					yield return null;
					yield return null;
				}
				yield return base.CaptureFrame(this.itemsToShot[i].name, i);
				num = i;
			}
			if (IconCreatorCanvas.instance != null)
			{
				IconCreatorCanvas.instance.SetInfo(0, 0, "", false, this.nextIconKey);
			}
			base.DeleteCameras();
			yield break;
		}

		// Token: 0x04000D24 RID: 3364
		[Header("Items")]
		public GameObject[] itemsToShot;

		// Token: 0x04000D25 RID: 3365
		public Transform itemPosition;

		// Token: 0x04000D26 RID: 3366
		private GameObject instantiatedItem;
	}
}
