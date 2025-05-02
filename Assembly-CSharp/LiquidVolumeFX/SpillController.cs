using System;
using System.Collections;
using UnityEngine;

namespace LiquidVolumeFX
{
	// Token: 0x0200016A RID: 362
	public class SpillController : MonoBehaviour
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x0001F7C4 File Offset: 0x0001D9C4
		private void Start()
		{
			this.lv = base.GetComponent<LiquidVolume>();
			this.dropTemplates = new GameObject[10];
			for (int i = 0; i < 10; i++)
			{
				GameObject gameObject = Object.Instantiate<GameObject>(this.spill);
				gameObject.transform.localScale *= Random.Range(0.45f, 0.65f);
				gameObject.GetComponent<Renderer>().material.color = Color.Lerp(this.lv.liquidColor1, this.lv.liquidColor2, Random.value);
				gameObject.SetActive(false);
				this.dropTemplates[i] = gameObject;
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001F868 File Offset: 0x0001DA68
		private void Update()
		{
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				base.transform.Rotate(Vector3.forward * Time.deltaTime * 10f);
			}
			if (Input.GetKey(KeyCode.RightArrow))
			{
				base.transform.Rotate(-Vector3.forward * Time.deltaTime * 10f);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001F8DC File Offset: 0x0001DADC
		private void FixedUpdate()
		{
			Vector3 a;
			float num;
			if (this.lv.GetSpillPoint(out a, out num, 1f, LEVEL_COMPENSATION.None))
			{
				for (int i = 0; i < 15; i++)
				{
					int num2 = Random.Range(0, 10);
					GameObject gameObject = Object.Instantiate<GameObject>(this.dropTemplates[num2]);
					gameObject.SetActive(true);
					Rigidbody component = gameObject.GetComponent<Rigidbody>();
					component.transform.position = a + Random.insideUnitSphere * 0.01f;
					component.AddForce(new Vector3(Random.value - 0.5f, Random.value * 0.1f - 0.2f, Random.value - 0.5f));
					base.StartCoroutine(this.DestroySpill(gameObject));
				}
				this.lv.level -= num / 10f + 0.001f;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		private IEnumerator DestroySpill(GameObject spill)
		{
			yield return new WaitForSeconds(1f);
			Object.Destroy(spill);
			yield break;
		}

		// Token: 0x040007CD RID: 1997
		public GameObject spill;

		// Token: 0x040007CE RID: 1998
		private LiquidVolume lv;

		// Token: 0x040007CF RID: 1999
		private GameObject[] dropTemplates;

		// Token: 0x040007D0 RID: 2000
		private const int DROP_TEMPLATES_COUNT = 10;
	}
}
