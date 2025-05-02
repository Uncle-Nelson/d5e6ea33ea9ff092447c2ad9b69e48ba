using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class Constraints
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00008DF6 File Offset: 0x00006FF6
		public bool IsValid()
		{
			return this.transform != null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008E04 File Offset: 0x00007004
		public void Initiate(Transform transform)
		{
			this.transform = transform;
			this.position = transform.position;
			this.rotation = transform.eulerAngles;
			this.defaultLocalPosition = transform.localPosition;
			this.defaultLocalRotation = transform.localRotation;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008E3D File Offset: 0x0000703D
		public void FixTransforms()
		{
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.localRotation = this.defaultLocalRotation;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008E64 File Offset: 0x00007064
		public void Update()
		{
			if (!this.IsValid())
			{
				return;
			}
			if (this.target != null)
			{
				this.position = this.target.position;
			}
			this.transform.position += this.positionOffset;
			if (this.positionWeight > 0f)
			{
				this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.positionWeight);
			}
			if (this.target != null)
			{
				this.rotation = this.target.eulerAngles;
			}
			this.transform.rotation = Quaternion.Euler(this.rotationOffset) * this.transform.rotation;
			if (this.rotationWeight > 0f)
			{
				this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(this.rotation), this.rotationWeight);
			}
		}

		// Token: 0x040000FD RID: 253
		public Transform transform;

		// Token: 0x040000FE RID: 254
		public Transform target;

		// Token: 0x040000FF RID: 255
		public Vector3 positionOffset;

		// Token: 0x04000100 RID: 256
		public Vector3 position;

		// Token: 0x04000101 RID: 257
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04000102 RID: 258
		public Vector3 rotationOffset;

		// Token: 0x04000103 RID: 259
		public Vector3 rotation;

		// Token: 0x04000104 RID: 260
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04000105 RID: 261
		private Vector3 defaultLocalPosition;

		// Token: 0x04000106 RID: 262
		private Quaternion defaultLocalRotation;
	}
}
