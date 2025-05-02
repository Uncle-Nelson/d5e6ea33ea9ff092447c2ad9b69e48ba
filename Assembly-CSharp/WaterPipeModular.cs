using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000042 RID: 66
[ExecuteInEditMode]
public class WaterPipeModular : MonoBehaviour
{
	// Token: 0x06000151 RID: 337 RVA: 0x000078E4 File Offset: 0x00005AE4
	private void Start()
	{
		this.largeWaterPipe = (Resources.Load("Models/Water_Pipe_Long") as GameObject);
		this.mediumWaterPipe = (Resources.Load("Models/Water_Pipe_Medium") as GameObject);
		this.smallWaterpipe = (Resources.Load("Models/Water_Pipe_Small") as GameObject);
		this.innerCorner = (Resources.Load("Models/Water_Pipe_left") as GameObject);
		this.outerCorner = (Resources.Load("Models/Water_Pipe_right") as GameObject);
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000795C File Offset: 0x00005B5C
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

	// Token: 0x06000153 RID: 339 RVA: 0x000079F8 File Offset: 0x00005BF8
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

	// Token: 0x0400012E RID: 302
	[HideInInspector]
	public List<GameObject> itemsList = new List<GameObject>();

	// Token: 0x0400012F RID: 303
	[HideInInspector]
	public GameObject largeWaterPipe;

	// Token: 0x04000130 RID: 304
	[HideInInspector]
	public GameObject mediumWaterPipe;

	// Token: 0x04000131 RID: 305
	[HideInInspector]
	public GameObject smallWaterpipe;

	// Token: 0x04000132 RID: 306
	[HideInInspector]
	public GameObject innerCorner;

	// Token: 0x04000133 RID: 307
	[HideInInspector]
	public GameObject outerCorner;
}
