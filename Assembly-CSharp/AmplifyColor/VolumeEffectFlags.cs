using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C57 RID: 3159
	[Serializable]
	public class VolumeEffectFlags
	{
		// Token: 0x06005876 RID: 22646 RVA: 0x00173180 File Offset: 0x00171380
		public VolumeEffectFlags()
		{
			this.components = new List<VolumeEffectComponentFlags>();
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x00173194 File Offset: 0x00171394
		public void AddComponent(Component c)
		{
			VolumeEffectComponentFlags volumeEffectComponentFlags;
			if ((volumeEffectComponentFlags = this.components.Find(delegate(VolumeEffectComponentFlags s)
			{
				string componentName = s.componentName;
				Type type = c.GetType();
				return componentName == (((type != null) ? type.ToString() : null) ?? "");
			})) != null)
			{
				volumeEffectComponentFlags.UpdateComponentFlags(c);
				return;
			}
			this.components.Add(new VolumeEffectComponentFlags(c));
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x001731EC File Offset: 0x001713EC
		public void UpdateFlags(VolumeEffect effectVol)
		{
			using (List<VolumeEffectComponent>.Enumerator enumerator = effectVol.components.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					VolumeEffectComponent comp = enumerator.Current;
					VolumeEffectComponentFlags volumeEffectComponentFlags;
					if ((volumeEffectComponentFlags = this.components.Find((VolumeEffectComponentFlags s) => s.componentName == comp.componentName)) == null)
					{
						this.components.Add(new VolumeEffectComponentFlags(comp));
					}
					else
					{
						volumeEffectComponentFlags.UpdateComponentFlags(comp);
					}
				}
			}
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x00173284 File Offset: 0x00171484
		public static void UpdateCamFlags(AmplifyColorEffect[] effects, AmplifyColorVolumeBase[] volumes)
		{
			foreach (AmplifyColorEffect amplifyColorEffect in effects)
			{
				amplifyColorEffect.EffectFlags = new VolumeEffectFlags();
				for (int j = 0; j < volumes.Length; j++)
				{
					VolumeEffect volumeEffect = volumes[j].EffectContainer.FindVolumeEffect(amplifyColorEffect);
					if (volumeEffect != null)
					{
						amplifyColorEffect.EffectFlags.UpdateFlags(volumeEffect);
					}
				}
			}
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x001732E8 File Offset: 0x001714E8
		public VolumeEffect GenerateEffectData(AmplifyColorEffect go)
		{
			VolumeEffect volumeEffect = new VolumeEffect(go);
			foreach (VolumeEffectComponentFlags volumeEffectComponentFlags in this.components)
			{
				if (volumeEffectComponentFlags.blendFlag)
				{
					Component component = go.GetComponent(volumeEffectComponentFlags.componentName);
					if (component != null)
					{
						volumeEffect.AddComponent(component, volumeEffectComponentFlags);
					}
				}
			}
			return volumeEffect;
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x00173364 File Offset: 0x00171564
		public VolumeEffectComponentFlags FindComponentFlags(string compName)
		{
			for (int i = 0; i < this.components.Count; i++)
			{
				if (this.components[i].componentName == compName)
				{
					return this.components[i];
				}
			}
			return null;
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x001733B0 File Offset: 0x001715B0
		public string[] GetComponentNames()
		{
			return (from r in this.components
			where r.blendFlag
			select r.componentName).ToArray<string>();
		}

		// Token: 0x0400417B RID: 16763
		public List<VolumeEffectComponentFlags> components;
	}
}
