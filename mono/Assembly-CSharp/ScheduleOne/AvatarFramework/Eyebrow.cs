using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x0200096A RID: 2410
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x06004196 RID: 16790 RVA: 0x001139A8 File Offset: 0x00111BA8
		public void SetScale(float _scale)
		{
			this.scale = _scale;
			this.Model.localScale = new Vector3(this.EyebrowDefaultScale.x, this.EyebrowDefaultScale.y, this.EyebrowDefaultScale.z * this.thickness) * this.scale;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x001139FF File Offset: 0x00111BFF
		public void SetThickness(float thickness)
		{
			this.thickness = thickness;
			this.SetScale(this.scale);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00113A14 File Offset: 0x00111C14
		public void SetRestingAngle(float _angle)
		{
			this.restingAngle = _angle;
			base.transform.localRotation = Quaternion.Euler(base.transform.localEulerAngles.x, base.transform.localEulerAngles.y, this.restingAngle * ((this.Side == Eyebrow.ESide.Left) ? -1f : 1f));
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00113A74 File Offset: 0x00111C74
		public void SetRestingHeight(float normalizedHeight)
		{
			normalizedHeight = Mathf.Clamp(normalizedHeight, -1.1f, 1.5f);
			this.Model.transform.localPosition = new Vector3(this.EyebrowDefaultLocalPos.x, this.EyebrowDefaultLocalPos.y + normalizedHeight * 0.01f, this.EyebrowDefaultLocalPos.z);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00113AD1 File Offset: 0x00111CD1
		public void SetColor(Color _col)
		{
			this.col = _col;
			this.Rend.material.color = this.col;
		}

		// Token: 0x04002F1D RID: 12061
		private const float eyebrowHeightMultiplier = 0.01f;

		// Token: 0x04002F1E RID: 12062
		[SerializeField]
		private Vector3 EyebrowDefaultScale;

		// Token: 0x04002F1F RID: 12063
		[SerializeField]
		private Vector3 EyebrowDefaultLocalPos;

		// Token: 0x04002F20 RID: 12064
		[SerializeField]
		protected Eyebrow.ESide Side;

		// Token: 0x04002F21 RID: 12065
		[SerializeField]
		protected Transform Model;

		// Token: 0x04002F22 RID: 12066
		[SerializeField]
		protected MeshRenderer Rend;

		// Token: 0x04002F23 RID: 12067
		[Header("Eyebrow Data - Readonly")]
		[SerializeField]
		private Color col;

		// Token: 0x04002F24 RID: 12068
		[SerializeField]
		private float scale = 1f;

		// Token: 0x04002F25 RID: 12069
		[SerializeField]
		private float thickness = 1f;

		// Token: 0x04002F26 RID: 12070
		[SerializeField]
		private float restingAngle;

		// Token: 0x0200096B RID: 2411
		public enum ESide
		{
			// Token: 0x04002F28 RID: 12072
			Right,
			// Token: 0x04002F29 RID: 12073
			Left
		}
	}
}
