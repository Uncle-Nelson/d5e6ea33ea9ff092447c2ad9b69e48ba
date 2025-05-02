using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x02000039 RID: 57
[ExecuteInEditMode]
public class ACpipeModular : MonoBehaviour
{
	// Token: 0x0600012B RID: 299 RVA: 0x00007028 File Offset: 0x00005228
	private void Start()
	{
		this.largeACPipe = (Resources.Load("Models/AC_Pipe_Long") as GameObject);
		this.smallACpipe = (Resources.Load("Models/AC_Pipe_Medium") as GameObject);
		this.innerCorner = (Resources.Load("Models/AC_Pipe_Side_left") as GameObject);
		this.outerCorner = (Resources.Load("Models/AC_Pipe_Side_Right") as GameObject);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000708C File Offset: 0x0000528C
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
		MonoBehaviour.print(child.gameObject.transform.parent.gameObject.name);
		GameObject gameObject2 = Object.Instantiate<GameObject>(item, child.position, child.rotation);
		gameObject2.transform.SetParent(base.transform);
		this.itemsList.Add(gameObject2);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00007148 File Offset: 0x00005348
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

	// Token: 0x04000108 RID: 264
	[HideInInspector]
	public List<GameObject> itemsList = new List<GameObject>();

	// Token: 0x04000109 RID: 265
	[HideInInspector]
	public GameObject largeACPipe;

	// Token: 0x0400010A RID: 266
	[HideInInspector]
	public GameObject smallACpipe;

	// Token: 0x0400010B RID: 267
	[HideInInspector]
	public GameObject innerCorner;

	// Token: 0x0400010C RID: 268
	[HideInInspector]
	public GameObject outerCorner;
}
