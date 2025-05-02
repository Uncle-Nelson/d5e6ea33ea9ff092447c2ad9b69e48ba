using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x02000602 RID: 1538
	public class PlayerTeleporter : MonoBehaviour
	{
		// Token: 0x0600282E RID: 10286 RVA: 0x000A532C File Offset: 0x000A352C
		public void Teleport(Transform destination)
		{
			PlayerSingleton<PlayerMovement>.Instance.Teleport(destination.position);
			Player.Local.transform.rotation = destination.rotation;
			Player.Local.transform.eulerAngles = new Vector3(0f, Player.Local.transform.eulerAngles.y, 0f);
		}
	}
}
