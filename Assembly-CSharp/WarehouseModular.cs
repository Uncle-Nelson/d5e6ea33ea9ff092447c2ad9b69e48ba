using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000041 RID: 65
[ExecuteInEditMode]
public class WarehouseModular : MonoBehaviour
{
	// Token: 0x0600014D RID: 333 RVA: 0x000076DC File Offset: 0x000058DC
	private void Start()
	{
		this.myMeshFilter = base.GetComponent<MeshFilter>();
		this.largeWall = (Resources.Load("Models/LargeWall") as GameObject);
		this.mediumWall = (Resources.Load("Models/MediumWall") as GameObject);
		this.smallWall = (Resources.Load("Models/SmallWall") as GameObject);
		this.miniWall = (Resources.Load("Models/Extra_SmallWall") as GameObject);
		this.tinyWall = (Resources.Load("Models/Extra_SmallWall1") as GameObject);
		this.windowWall = (Resources.Load("Models/WindowWall") as GameObject);
		this.smallWindowWall = (Resources.Load("Models/SmallWindowWall") as GameObject);
		this.innerCorner = (Resources.Load("Models/LeftCorner") as GameObject);
		this.outerCorner = (Resources.Load("Models/RightCorner") as GameObject);
		this.garageFrame = (Resources.Load("Models/GarageDoorFrame") as GameObject);
		this.doorFrame = (Resources.Load("Models/DoorWall") as GameObject);
		this.doubleDoorFrame = (Resources.Load("Models/DoubleDoorWall") as GameObject);
	}

	// Token: 0x0600014E RID: 334 RVA: 0x000077F4 File Offset: 0x000059F4
	public void BuildNextItem(GameObject item)
	{
		if (this.itemsList.Count == 0)
		{
			GameObject gameObject = Object.Instantiate<GameObject>(item, base.transform.position, item.transform.rotation);
			gameObject.transform.SetParent(base.transform);
			this.itemsList.Add(gameObject);
			return;
		}
		Transform child = this.itemsList.Last<GameObject>().transform.GetChild(0);
		GameObject gameObject2 = Object.Instantiate<GameObject>(item, child.position, child.rotation);
		gameObject2.transform.SetParent(base.transform);
		this.itemsList.Add(gameObject2);
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00007890 File Offset: 0x00005A90
	public void DeleteLastItem()
	{
		GameObject gameObject = this.itemsList.Last<GameObject>();
		if (Application.isPlaying)
		{
			Object.Destroy(gameObject);
		}
		if (Application.isEditor)
		{
			Object.DestroyImmediate(gameObject);
		}
		this.itemsList.Remove(gameObject);
	}

	// Token: 0x04000120 RID: 288
	[HideInInspector]
	public List<GameObject> itemsList = new List<GameObject>();

	// Token: 0x04000121 RID: 289
	[HideInInspector]
	public GameObject largeWall;

	// Token: 0x04000122 RID: 290
	[HideInInspector]
	public GameObject mediumWall;

	// Token: 0x04000123 RID: 291
	[HideInInspector]
	public GameObject smallWall;

	// Token: 0x04000124 RID: 292
	[HideInInspector]
	public GameObject miniWall;

	// Token: 0x04000125 RID: 293
	[HideInInspector]
	public GameObject tinyWall;

	// Token: 0x04000126 RID: 294
	[HideInInspector]
	public GameObject windowWall;

	// Token: 0x04000127 RID: 295
	[HideInInspector]
	public GameObject smallWindowWall;

	// Token: 0x04000128 RID: 296
	[HideInInspector]
	public GameObject innerCorner;

	// Token: 0x04000129 RID: 297
	[HideInInspector]
	public GameObject outerCorner;

	// Token: 0x0400012A RID: 298
	[HideInInspector]
	public GameObject garageFrame;

	// Token: 0x0400012B RID: 299
	[HideInInspector]
	public GameObject doorFrame;

	// Token: 0x0400012C RID: 300
	[HideInInspector]
	public GameObject doubleDoorFrame;

	// Token: 0x0400012D RID: 301
	private MeshFilter myMeshFilter;
}
