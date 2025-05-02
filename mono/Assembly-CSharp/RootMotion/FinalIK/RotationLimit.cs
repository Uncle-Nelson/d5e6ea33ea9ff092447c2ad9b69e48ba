using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006C RID: 108
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
		public void SetDefaultLocalRotation()
		{
			this.defaultLocalRotation = base.transform.localRotation;
			this.defaultLocalRotationSet = true;
			this.defaultLocalRotationOverride = false;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001E311 File Offset: 0x0001C511
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
			this.defaultLocalRotation = localRotation;
			this.defaultLocalRotationSet = true;
			this.defaultLocalRotationOverride = true;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001E328 File Offset: 0x0001C528
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			if (!this.initiated)
			{
				this.Awake();
			}
			Quaternion quaternion = Quaternion.Inverse(this.defaultLocalRotation) * localRotation;
			Quaternion quaternion2 = this.LimitRotation(quaternion);
			quaternion2 = Quaternion.Normalize(quaternion2);
			changed = (quaternion2 != quaternion);
			if (!changed)
			{
				return localRotation;
			}
			return this.defaultLocalRotation * quaternion2;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001E380 File Offset: 0x0001C580
		public bool Apply()
		{
			bool result = false;
			base.transform.localRotation = this.GetLimitedLocalRotation(base.transform.localRotation, out result);
			return result;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001E3AE File Offset: 0x0001C5AE
		public void Disable()
		{
			if (this.initiated)
			{
				base.enabled = false;
				return;
			}
			this.Awake();
			base.enabled = false;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001E3CD File Offset: 0x0001C5CD
		public Vector3 secondaryAxis
		{
			get
			{
				return new Vector3(this.axis.y, this.axis.z, this.axis.x);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x0001E3F5 File Offset: 0x0001C5F5
		public Vector3 crossAxis
		{
			get
			{
				return Vector3.Cross(this.axis, this.secondaryAxis);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0001E408 File Offset: 0x0001C608
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x0001E410 File Offset: 0x0001C610
		public bool defaultLocalRotationOverride { get; private set; }

		// Token: 0x0600048C RID: 1164
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		// Token: 0x0600048D RID: 1165 RVA: 0x0001E419 File Offset: 0x0001C619
		private void Awake()
		{
			if (!this.defaultLocalRotationSet)
			{
				this.SetDefaultLocalRotation();
			}
			if (this.axis == Vector3.zero)
			{
				Debug.LogError("Axis is Vector3.zero.");
			}
			this.initiated = true;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001E44C File Offset: 0x0001C64C
		private void LateUpdate()
		{
			this.Apply();
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001E455 File Offset: 0x0001C655
		public void LogWarning(string message)
		{
			Warning.Log(message, base.transform, false);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001E464 File Offset: 0x0001C664
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return Quaternion.FromToRotation(rotation * axis, axis) * rotation;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001E47C File Offset: 0x0001C67C
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			twistLimit = Mathf.Clamp(twistLimit, 0f, 180f);
			if (twistLimit >= 180f)
			{
				return rotation;
			}
			Vector3 vector = rotation * axis;
			Vector3 toDirection = orthoAxis;
			Vector3.OrthoNormalize(ref vector, ref toDirection);
			Vector3 fromDirection = rotation * orthoAxis;
			Vector3.OrthoNormalize(ref vector, ref fromDirection);
			Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * rotation;
			if (twistLimit <= 0f)
			{
				return quaternion;
			}
			return Quaternion.RotateTowards(quaternion, rotation, twistLimit);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001E4E9 File Offset: 0x0001C6E9
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			Vector3.OrthoNormalize(ref normal, ref v1);
			Vector3.OrthoNormalize(ref normal, ref v2);
			return Vector3.Angle(v1, v2);
		}

		// Token: 0x04000365 RID: 869
		public Vector3 axis = Vector3.forward;

		// Token: 0x04000366 RID: 870
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		// Token: 0x04000368 RID: 872
		private bool initiated;

		// Token: 0x04000369 RID: 873
		private bool applicationQuit;

		// Token: 0x0400036A RID: 874
		private bool defaultLocalRotationSet;
	}
}
