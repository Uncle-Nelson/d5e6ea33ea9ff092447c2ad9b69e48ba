using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020007D6 RID: 2006
	public class VehicleHumanoidCollider : MonoBehaviour
	{
		// Token: 0x060036D3 RID: 14035 RVA: 0x000E6E56 File Offset: 0x000E5056
		private void Start()
		{
			LayerUtility.SetLayerRecursively(base.gameObject, LayerMask.NameToLayer("Ignore Raycast"));
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000E6E6D File Offset: 0x000E506D
		private void OnCollisionStay(Collision collision)
		{
			Debug.Log("Collision Stay: " + collision.collider.gameObject.name);
		}

		// Token: 0x04002757 RID: 10071
		public LandVehicle vehicle;
	}
}
