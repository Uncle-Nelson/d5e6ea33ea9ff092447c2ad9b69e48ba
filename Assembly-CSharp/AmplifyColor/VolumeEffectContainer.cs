using System;
using System.Collections.Generic;
using System.Linq;

namespace AmplifyColor
{
	// Token: 0x02000C50 RID: 3152
	[Serializable]
	public class VolumeEffectContainer
	{
		// Token: 0x0600585D RID: 22621 RVA: 0x00172CFD File Offset: 0x00170EFD
		public VolumeEffectContainer()
		{
			this.volumes = new List<VolumeEffect>();
		}

		// Token: 0x0600585E RID: 22622 RVA: 0x00172D10 File Offset: 0x00170F10
		public void AddColorEffect(AmplifyColorEffect colorEffect)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.FindVolumeEffect(colorEffect)) != null)
			{
				volumeEffect.UpdateVolume();
				return;
			}
			volumeEffect = new VolumeEffect(colorEffect);
			this.volumes.Add(volumeEffect);
			volumeEffect.UpdateVolume();
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x00172D48 File Offset: 0x00170F48
		public VolumeEffect AddJustColorEffect(AmplifyColorEffect colorEffect)
		{
			VolumeEffect volumeEffect = new VolumeEffect(colorEffect);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00172D6C File Offset: 0x00170F6C
		public VolumeEffect FindVolumeEffect(AmplifyColorEffect colorEffect)
		{
			for (int i = 0; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == colorEffect)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.SharedInstanceID == colorEffect.SharedInstanceID)
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00172E15 File Offset: 0x00171015
		public void RemoveVolumeEffect(VolumeEffect volume)
		{
			this.volumes.Remove(volume);
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00172E24 File Offset: 0x00171024
		public AmplifyColorEffect[] GetStoredEffects()
		{
			return (from r in this.volumes
			select r.gameObject).ToArray<AmplifyColorEffect>();
		}

		// Token: 0x0400416D RID: 16749
		public List<VolumeEffect> volumes;
	}
}
