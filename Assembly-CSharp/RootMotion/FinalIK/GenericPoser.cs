using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000068 RID: 104
	public class GenericPoser : Poser
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x0001D834 File Offset: 0x0001BA34
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
			if (this.poseRoot == null)
			{
				this.maps = new GenericPoser.Map[0];
				return;
			}
			this.maps = new GenericPoser.Map[0];
			Transform[] componentsInChildren = base.transform.GetComponentsInChildren<Transform>();
			Transform[] componentsInChildren2 = this.poseRoot.GetComponentsInChildren<Transform>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				Transform targetNamed = this.GetTargetNamed(componentsInChildren[i].name, componentsInChildren2);
				if (targetNamed != null)
				{
					Array.Resize<GenericPoser.Map>(ref this.maps, this.maps.Length + 1);
					this.maps[this.maps.Length - 1] = new GenericPoser.Map(componentsInChildren[i], targetNamed);
				}
			}
			this.StoreDefaultState();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001D8DC File Offset: 0x0001BADC
		protected override void InitiatePoser()
		{
			this.StoreDefaultState();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		protected override void UpdatePoser()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.localPositionWeight <= 0f && this.localRotationWeight <= 0f)
			{
				return;
			}
			if (this.poseRoot == null)
			{
				return;
			}
			float localRotationWeight = this.localRotationWeight * this.weight;
			float localPositionWeight = this.localPositionWeight * this.weight;
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].Update(localRotationWeight, localPositionWeight);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001D968 File Offset: 0x0001BB68
		protected override void FixPoserTransforms()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].FixTransform();
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001D998 File Offset: 0x0001BB98
		private void StoreDefaultState()
		{
			for (int i = 0; i < this.maps.Length; i++)
			{
				this.maps[i].StoreDefaultState();
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001D9C8 File Offset: 0x0001BBC8
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].name == tName)
				{
					return array[i];
				}
			}
			return null;
		}

		// Token: 0x0400034A RID: 842
		public GenericPoser.Map[] maps;

		// Token: 0x02000102 RID: 258
		[Serializable]
		public class Map
		{
			// Token: 0x060007A2 RID: 1954 RVA: 0x00033140 File Offset: 0x00031340
			public Map(Transform bone, Transform target)
			{
				this.bone = bone;
				this.target = target;
				this.StoreDefaultState();
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x0003315C File Offset: 0x0003135C
			public void StoreDefaultState()
			{
				this.defaultLocalPosition = this.bone.localPosition;
				this.defaultLocalRotation = this.bone.localRotation;
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x00033180 File Offset: 0x00031380
			public void FixTransform()
			{
				this.bone.localPosition = this.defaultLocalPosition;
				this.bone.localRotation = this.defaultLocalRotation;
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x000331A4 File Offset: 0x000313A4
			public void Update(float localRotationWeight, float localPositionWeight)
			{
				this.bone.localRotation = Quaternion.Lerp(this.bone.localRotation, this.target.localRotation, localRotationWeight);
				this.bone.localPosition = Vector3.Lerp(this.bone.localPosition, this.target.localPosition, localPositionWeight);
			}

			// Token: 0x0400079E RID: 1950
			public Transform bone;

			// Token: 0x0400079F RID: 1951
			public Transform target;

			// Token: 0x040007A0 RID: 1952
			private Vector3 defaultLocalPosition;

			// Token: 0x040007A1 RID: 1953
			private Quaternion defaultLocalRotation;
		}
	}
}
