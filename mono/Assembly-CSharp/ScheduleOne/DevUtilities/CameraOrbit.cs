using System;
using System.Collections.Generic;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006DB RID: 1755
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x06002FD1 RID: 12241 RVA: 0x000C747C File Offset: 0x000C567C
		private void Start()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			this.x = eulerAngles.y;
			this.y = eulerAngles.x;
			this.rb = base.GetComponent<Rigidbody>();
			if (this.rb != null)
			{
				this.rb.freezeRotation = true;
			}
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000C74D4 File Offset: 0x000C56D4
		private void Update()
		{
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			pointerEventData.position = Input.mousePosition;
			List<RaycastResult> list = new List<RaycastResult>();
			this.raycaster.Raycast(pointerEventData, list);
			this.hoveringUI = (list.Count > 0);
			this.LookAt.OverrideLookTarget(this.cam.transform.position, 100, false);
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x000C753C File Offset: 0x000C573C
		private void LateUpdate()
		{
			if (this.target)
			{
				if (Input.GetMouseButton(0) && !this.hoveringUI)
				{
					this.targetx += Input.GetAxis("Mouse X") * this.xSpeed * this.distance * 0.02f * (5f / (this.distance + 2f));
					this.targety -= Input.GetAxis("Mouse Y") * this.ySpeed * 0.02f;
				}
				this.targety = CameraOrbit.ClampAngle(this.targety, this.yMinLimit, this.yMaxLimit);
				this.x = Mathf.LerpAngle(this.x, this.targetx, 0.1f);
				this.y = Mathf.LerpAngle(this.y, this.targety, 1f);
				Quaternion rotation = Quaternion.Euler(this.y, this.x, 0f);
				if (!this.hoveringUI)
				{
					this.targetdistance = Mathf.Clamp(this.targetdistance - Input.GetAxis("Mouse ScrollWheel") * this.ScrollSensativity, this.distanceMin, this.distanceMax);
				}
				this.distance = Mathf.Lerp(this.distance, this.targetdistance, 0.1f);
				RaycastHit raycastHit;
				if (Physics.Linecast(this.target.position, base.transform.position, ref raycastHit))
				{
					this.targetdistance -= raycastHit.distance;
				}
				Vector3 point = new Vector3(0f, 0f, -this.distance);
				Vector3 position = rotation * point + this.target.position;
				base.transform.rotation = rotation;
				base.transform.position = position;
			}
			this.cam.position = base.transform.position;
			this.cam.rotation = base.transform.rotation;
			this.cam.position = this.cam.position - base.transform.right * this.sideOffset * Vector3.Distance(this.cam.position, this.target.position);
			if (Input.GetKey(KeyCode.KeypadPlus))
			{
				base.GetComponent<Camera>().fieldOfView += 0.3f;
			}
			if (Input.GetKey(KeyCode.KeypadMinus))
			{
				base.GetComponent<Camera>().fieldOfView -= 0.3f;
			}
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0000809D File Offset: 0x0000629D
		public static float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360f)
			{
				angle += 360f;
			}
			if (angle > 360f)
			{
				angle -= 360f;
			}
			return Mathf.Clamp(angle, min, max);
		}

		// Token: 0x040021F0 RID: 8688
		[Header("Required")]
		public Transform target;

		// Token: 0x040021F1 RID: 8689
		public Transform cam;

		// Token: 0x040021F2 RID: 8690
		public GraphicRaycaster raycaster;

		// Token: 0x040021F3 RID: 8691
		public AvatarLookController LookAt;

		// Token: 0x040021F4 RID: 8692
		[Header("Config")]
		public float targetdistance = 5f;

		// Token: 0x040021F5 RID: 8693
		public float xSpeed = 120f;

		// Token: 0x040021F6 RID: 8694
		public float ySpeed = 120f;

		// Token: 0x040021F7 RID: 8695
		public float sideOffset = 1f;

		// Token: 0x040021F8 RID: 8696
		public float yMinLimit = -20f;

		// Token: 0x040021F9 RID: 8697
		public float yMaxLimit = 80f;

		// Token: 0x040021FA RID: 8698
		public float distanceMin = 0.5f;

		// Token: 0x040021FB RID: 8699
		public float distanceMax = 15f;

		// Token: 0x040021FC RID: 8700
		public float ScrollSensativity = 4f;

		// Token: 0x040021FD RID: 8701
		private Rigidbody rb;

		// Token: 0x040021FE RID: 8702
		private float x;

		// Token: 0x040021FF RID: 8703
		private float y;

		// Token: 0x04002200 RID: 8704
		private float targetx;

		// Token: 0x04002201 RID: 8705
		private float targety;

		// Token: 0x04002202 RID: 8706
		private float distance = 5f;

		// Token: 0x04002203 RID: 8707
		private bool hoveringUI;
	}
}
