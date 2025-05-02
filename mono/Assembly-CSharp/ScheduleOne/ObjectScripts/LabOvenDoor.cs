using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BDB RID: 3035
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060053EB RID: 21483 RVA: 0x00161D12 File Offset: 0x0015FF12
		// (set) Token: 0x060053EC RID: 21484 RVA: 0x00161D1A File Offset: 0x0015FF1A
		public bool Interactable { get; private set; }

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060053ED RID: 21485 RVA: 0x00161D23 File Offset: 0x0015FF23
		// (set) Token: 0x060053EE RID: 21486 RVA: 0x00161D2B File Offset: 0x0015FF2B
		public float TargetPosition { get; private set; }

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x00161D34 File Offset: 0x0015FF34
		// (set) Token: 0x060053F0 RID: 21488 RVA: 0x00161D3C File Offset: 0x0015FF3C
		public float ActualPosition { get; private set; }

		// Token: 0x060053F1 RID: 21489 RVA: 0x00161D48 File Offset: 0x0015FF48
		private void Start()
		{
			this.SetPosition(0f);
			this.SetInteractable(false);
			this.HandleClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ClickStart));
			this.HandleClickable.onClickEnd.AddListener(new UnityAction(this.ClickEnd));
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x00161DA0 File Offset: 0x0015FFA0
		private void LateUpdate()
		{
			if (this.isMoving)
			{
				Vector3 position = this.GetPlaneHit() + this.clickOffset;
				float num = this.PlaneNormal.InverseTransformPoint(position).y;
				num = Mathf.Clamp01(Mathf.InverseLerp(-0.25f, 0.24f, num));
				this.SetPosition(this.HitMapCurve.Evaluate(num));
			}
			this.Move();
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x00161E08 File Offset: 0x00160008
		private void Move()
		{
			float y = Mathf.Lerp(90f, 10f, this.TargetPosition);
			Quaternion b = Quaternion.Euler(0f, y, 0f);
			this.Door.localRotation = Quaternion.Lerp(this.Door.localRotation, b, Time.deltaTime * this.DoorMoveSpeed);
			this.ActualPosition = Mathf.Lerp(this.ActualPosition, this.TargetPosition, Time.deltaTime * this.DoorMoveSpeed);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00161E87 File Offset: 0x00160087
		public void SetInteractable(bool interactable)
		{
			this.Interactable = interactable;
			this.HandleClickable.ClickableEnabled = interactable;
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00161E9C File Offset: 0x0016009C
		public void SetPosition(float newPosition)
		{
			float targetPosition = this.TargetPosition;
			this.TargetPosition = newPosition;
			if (targetPosition == 0f && newPosition > 0.02f)
			{
				this.OpenSound.Play();
				return;
			}
			if (targetPosition >= 0.98f && newPosition < 0.98f)
			{
				this.CloseSound.Play();
				return;
			}
			if (targetPosition > 0.01f && newPosition <= 0.001f)
			{
				this.ShutSound.Play();
			}
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x00161F0A File Offset: 0x0016010A
		public void ClickStart(RaycastHit hit)
		{
			this.isMoving = true;
			this.clickOffset = this.HandleClickable.transform.position - this.GetPlaneHit();
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00161F34 File Offset: 0x00160134
		private Vector3 GetPlaneHit()
		{
			Plane plane = new Plane(this.PlaneNormal.forward, this.PlaneNormal.position);
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			float distance;
			plane.Raycast(ray, out distance);
			return ray.GetPoint(distance);
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x00161F86 File Offset: 0x00160186
		public void ClickEnd()
		{
			this.isMoving = false;
		}

		// Token: 0x04003E80 RID: 16000
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x04003E81 RID: 16001
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x04003E82 RID: 16002
		public const float DOOR_ANGLE_CLOSED = 90f;

		// Token: 0x04003E83 RID: 16003
		public const float DOOR_ANGLE_OPEN = 10f;

		// Token: 0x04003E87 RID: 16007
		[Header("References")]
		public Clickable HandleClickable;

		// Token: 0x04003E88 RID: 16008
		public Transform Door;

		// Token: 0x04003E89 RID: 16009
		public Transform PlaneNormal;

		// Token: 0x04003E8A RID: 16010
		public AnimationCurve HitMapCurve;

		// Token: 0x04003E8B RID: 16011
		[Header("Sounds")]
		public AudioSourceController OpenSound;

		// Token: 0x04003E8C RID: 16012
		public AudioSourceController CloseSound;

		// Token: 0x04003E8D RID: 16013
		public AudioSourceController ShutSound;

		// Token: 0x04003E8E RID: 16014
		[Header("Settings")]
		public float DoorMoveSpeed = 2f;

		// Token: 0x04003E8F RID: 16015
		private Vector3 clickOffset = Vector3.zero;

		// Token: 0x04003E90 RID: 16016
		private bool isMoving;
	}
}
