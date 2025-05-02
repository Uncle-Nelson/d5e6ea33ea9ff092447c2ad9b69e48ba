using System;
using FishNet.Managing.Transporting;
using FishNet.Transporting.Multipass;
using FishNet.Transporting.Yak;
using UnityEngine;

namespace ScheduleOne.Networking
{
	// Token: 0x02000541 RID: 1345
	public class TransportInitializer : MonoBehaviour
	{
		// Token: 0x060020C8 RID: 8392 RVA: 0x00086CAA File Offset: 0x00084EAA
		public void Awake()
		{
			base.GetComponent<TransportManager>().GetTransport<Multipass>().SetClientTransport<Yak>();
		}
	}
}
