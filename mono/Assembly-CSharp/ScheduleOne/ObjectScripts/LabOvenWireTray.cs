using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BDD RID: 3037
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x00162082 File Offset: 0x00160282
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0016208A File Offset: 0x0016028A
		public bool Interactable { get; private set; }

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x00162093 File Offset: 0x00160293
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x0016209B File Offset: 0x0016029B
		public float TargetPosition { get; private set; }

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x001620A4 File Offset: 0x001602A4
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x001620AC File Offset: 0x001602AC
		public float ActualPosition { get; private set; }

		// Token: 0x06005404 RID: 21508 RVA: 0x001620B5 File Offset: 0x001602B5
		private void Start()
		{
			this.SetPosition(0f);
			this.SetInteractable(false);
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x001620CC File Offset: 0x001602CC
		private void LateUpdate()
		{
			if (this.isMoving)
			{
				Vector3 position = this.GetPlaneHit() + this.clickOffset;
				float num = this.PlaneNormal.InverseTransformPoint(position).y;
				Debug.Log("Hit offset: " + num.ToString());
				num = Mathf.Clamp01(Mathf.InverseLerp(-0.25f, 0.24f, num));
				this.TargetPosition = num;
			}
			this.Move();
			this.ClampAngle();
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x00162144 File Offset: 0x00160344
		private void Move()
		{
			Vector3 b = Vector3.Lerp(this.ClosedPosition.localPosition, this.OpenPosition.localPosition, this.TargetPosition);
			this.Tray.localPosition = Vector3.Lerp(this.Tray.localPosition, b, Time.deltaTime * this.MoveSpeed);
			this.ActualPosition = Mathf.Lerp(this.ActualPosition, this.TargetPosition, Time.deltaTime * this.MoveSpeed);
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x001621C0 File Offset: 0x001603C0
		private void ClampAngle()
		{
			float max = this.DoorClampCurve.Evaluate(this.OvenDoor.ActualPosition);
			this.ActualPosition = Mathf.Clamp(this.ActualPosition, 0f, max);
			Vector3 localPosition = Vector3.Lerp(this.ClosedPosition.localPosition, this.OpenPosition.localPosition, this.ActualPosition);
			this.Tray.localPosition = localPosition;
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x00162229 File Offset: 0x00160429
		public void SetInteractable(bool interactable)
		{
			this.Interactable = interactable;
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00162232 File Offset: 0x00160432
		public void SetPosition(float position)
		{
			this.TargetPosition = position;
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x0016223B File Offset: 0x0016043B
		public void ClickStart(RaycastHit hit)
		{
			this.isMoving = true;
		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00162244 File Offset: 0x00160444
		private Vector3 GetPlaneHit()
		{
			Plane plane = new Plane(this.PlaneNormal.forward, this.PlaneNormal.position);
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			float distance;
			plane.Raycast(ray, out distance);
			return ray.GetPoint(distance);
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00162296 File Offset: 0x00160496
		public void ClickEnd()
		{
			this.isMoving = false;
		}

		// Token: 0x04003E9C RID: 16028
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x04003E9D RID: 16029
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x04003EA1 RID: 16033
		[Header("References")]
		public Transform Tray;

		// Token: 0x04003EA2 RID: 16034
		public Transform PlaneNormal;

		// Token: 0x04003EA3 RID: 16035
		public Transform ClosedPosition;

		// Token: 0x04003EA4 RID: 16036
		public Transform OpenPosition;

		// Token: 0x04003EA5 RID: 16037
		public LabOvenDoor OvenDoor;

		// Token: 0x04003EA6 RID: 16038
		[Header("Settings")]
		public float MoveSpeed = 2f;

		// Token: 0x04003EA7 RID: 16039
		public AnimationCurve DoorClampCurve;

		// Token: 0x04003EA8 RID: 16040
		private Vector3 clickOffset = Vector3.zero;

		// Token: 0x04003EA9 RID: 16041
		private bool isMoving;
	}
}
