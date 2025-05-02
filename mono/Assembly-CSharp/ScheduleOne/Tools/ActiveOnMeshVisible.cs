using System;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000844 RID: 2116
	public class ActiveOnMeshVisible : MonoBehaviour
	{
		// Token: 0x06003A2F RID: 14895 RVA: 0x000F62B8 File Offset: 0x000F44B8
		private void LateUpdate()
		{
			if (this.Mesh.isVisible && !this.isVisible)
			{
				this.isVisible = true;
				GameObject[] objectsToActivate = this.ObjectsToActivate;
				for (int i = 0; i < objectsToActivate.Length; i++)
				{
					objectsToActivate[i].SetActive(!this.Reverse);
				}
				return;
			}
			if (!this.Mesh.isVisible && this.isVisible)
			{
				this.isVisible = false;
				GameObject[] objectsToActivate = this.ObjectsToActivate;
				for (int i = 0; i < objectsToActivate.Length; i++)
				{
					objectsToActivate[i].SetActive(this.Reverse);
				}
			}
		}

		// Token: 0x040029E3 RID: 10723
		public MeshRenderer Mesh;

		// Token: 0x040029E4 RID: 10724
		public GameObject[] ObjectsToActivate;

		// Token: 0x040029E5 RID: 10725
		public bool Reverse;

		// Token: 0x040029E6 RID: 10726
		private bool isVisible = true;
	}
}
