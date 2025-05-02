using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x02000974 RID: 2420
	public class AvatarImpostor : MonoBehaviour
	{
		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x00114528 File Offset: 0x00112728
		// (set) Token: 0x060041D7 RID: 16855 RVA: 0x00114530 File Offset: 0x00112730
		public bool HasTexture { get; private set; }

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x00114539 File Offset: 0x00112739
		private Transform Camera
		{
			get
			{
				if (this.cachedCamera == null)
				{
					PlayerCamera instance = PlayerSingleton<PlayerCamera>.Instance;
					this.cachedCamera = ((instance != null) ? instance.transform : null);
				}
				return this.cachedCamera;
			}
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00114568 File Offset: 0x00112768
		public void SetAvatarSettings(AvatarSettings settings)
		{
			Texture2D impostorTexture = settings.ImpostorTexture;
			if (impostorTexture != null)
			{
				this.meshRenderer.material.mainTexture = impostorTexture;
				this.HasTexture = true;
			}
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x0011459D File Offset: 0x0011279D
		private void LateUpdate()
		{
			this.Realign();
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x001145A8 File Offset: 0x001127A8
		private void Realign()
		{
			if (this.Camera != null)
			{
				Vector3 position = this.Camera.position;
				position.y = base.transform.position.y;
				Vector3 forward = base.transform.position - position;
				base.transform.rotation = Quaternion.LookRotation(forward);
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00114609 File Offset: 0x00112809
		public void EnableImpostor()
		{
			base.gameObject.SetActive(true);
			this.Realign();
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public void DisableImpostor()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x04002F5C RID: 12124
		public MeshRenderer meshRenderer;

		// Token: 0x04002F5D RID: 12125
		private Transform cachedCamera;
	}
}
