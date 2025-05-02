using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200003A RID: 58
public class GarageDoorController : MonoBehaviour
{
	// Token: 0x0600012F RID: 303 RVA: 0x0000719C File Offset: 0x0000539C
	private void OnTriggerStay(Collider other)
	{
		if (other.gameObject.CompareTag("MainCamera"))
		{
			if (Input.GetKeyUp(KeyCode.E) && !this.doorStatus.doorIsOpen && this.doorStatus.canRotate)
			{
				this.doorStatus.canRotate = false;
				base.StartCoroutine(this.Rotate(Vector3.right, -80f, 1f));
			}
			if (Input.GetKeyUp(KeyCode.E) && this.doorStatus.doorIsOpen && this.doorStatus.canRotate)
			{
				this.doorStatus.canRotate = false;
				base.StartCoroutine(this.Rotate(Vector3.right, 80f, 1f));
			}
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00007254 File Offset: 0x00005454
	private IEnumerator Rotate(Vector3 axis, float angle, float duration = 1f)
	{
		Quaternion from = this.garageDoor.rotation;
		Quaternion to = this.garageDoor.rotation;
		to *= Quaternion.Euler(axis * angle);
		float elapsed = 0f;
		while (elapsed < duration)
		{
			this.garageDoor.rotation = Quaternion.Slerp(from, to, elapsed / duration);
			elapsed += Time.deltaTime;
			yield return null;
		}
		this.garageDoor.rotation = to;
		this.doorStatus.doorIsOpen = !this.doorStatus.doorIsOpen;
		this.doorStatus.canRotate = true;
		yield break;
	}

	// Token: 0x0400010D RID: 269
	public GarageDoorStatus doorStatus;

	// Token: 0x0400010E RID: 270
	public Transform garageDoor;

	// Token: 0x0400010F RID: 271
	public Quaternion targetRotation = new Quaternion(80f, 0f, 0f, 0f);
}
