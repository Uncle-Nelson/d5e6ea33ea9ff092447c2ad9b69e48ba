using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BCC RID: 3020
	public class LabStand : MonoBehaviour
	{
		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x0015C38A File Offset: 0x0015A58A
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x0015C392 File Offset: 0x0015A592
		public bool Interactable { get; private set; }

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x0015C39B File Offset: 0x0015A59B
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x0015C3A3 File Offset: 0x0015A5A3
		public float CurrentPosition { get; private set; } = 1f;

		// Token: 0x060052A3 RID: 21155 RVA: 0x0015C3AC File Offset: 0x0015A5AC
		private void Start()
		{
			this.SetPosition(1f);
			this.SetInteractable(false);
			this.HandleClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ClickStart));
			this.HandleClickable.onClickEnd.AddListener(new UnityAction(this.ClickEnd));
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x0015C404 File Offset: 0x0015A604
		private void LateUpdate()
		{
			if (this.isMoving)
			{
				Vector3 vector = this.GetPlaneHit() + this.clickOffset;
				float position = Mathf.Clamp01(Mathf.InverseLerp(Mathf.Min(this.LoweredTransform.position.y, this.RaisedTransform.position.y), Mathf.Max(this.LoweredTransform.position.y, this.RaisedTransform.position.y), vector.y));
				this.SetPosition(position);
			}
			this.Highlight.gameObject.SetActive(this.Interactable && !this.isMoving);
			this.Move();
			this.Funnel.gameObject.SetActive(this.FunnelEnabled && this.CurrentPosition < this.FunnelThreshold);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x0015C4E0 File Offset: 0x0015A6E0
		private void Move()
		{
			float y = this.GripTransform.localPosition.y;
			Vector3 b = Vector3.Lerp(this.LoweredTransform.localPosition, this.RaisedTransform.localPosition, this.CurrentPosition);
			Quaternion b2 = Quaternion.Lerp(this.LoweredTransform.localRotation, this.RaisedTransform.localRotation, this.CurrentPosition);
			this.GripTransform.localPosition = Vector3.Lerp(this.GripTransform.localPosition, b, Time.deltaTime * this.MoveSpeed);
			this.GripTransform.localRotation = Quaternion.Lerp(this.GripTransform.localRotation, b2, Time.deltaTime * this.MoveSpeed);
			float num = this.GripTransform.localPosition.y - y;
			this.SpinnyThingy.Rotate(Vector3.up, num * 1800f, Space.Self);
			this.UpdateSound(num);
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x0015C5C4 File Offset: 0x0015A7C4
		private void UpdateSound(float difference)
		{
			difference /= 0.05f;
			float num = 0f;
			if (difference < 0f)
			{
				num = Mathf.Abs(difference);
			}
			float num2 = 0f;
			if (difference > 0f)
			{
				num2 = Mathf.Abs(difference);
			}
			this.LowerSound.VolumeMultiplier = num;
			this.RaiseSound.VolumeMultiplier = num2;
			if (num > 0f && !this.LowerSound.AudioSource.isPlaying)
			{
				this.LowerSound.Play();
			}
			else if (num == 0f)
			{
				this.LowerSound.Stop();
			}
			if (num2 > 0f && !this.RaiseSound.AudioSource.isPlaying)
			{
				this.RaiseSound.Play();
				return;
			}
			if (num2 == 0f)
			{
				this.RaiseSound.Stop();
			}
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x0015C68F File Offset: 0x0015A88F
		public void SetPosition(float position)
		{
			this.CurrentPosition = position;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x0015C698 File Offset: 0x0015A898
		public void SetInteractable(bool e)
		{
			this.Interactable = e;
			this.HandleClickable.ClickableEnabled = e;
			if (this.Interactable)
			{
				this.Anim.Play();
				return;
			}
			this.Anim.Stop();
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x0015C6CD File Offset: 0x0015A8CD
		public void ClickStart(RaycastHit hit)
		{
			this.isMoving = true;
			this.clickOffset = this.HandleClickable.transform.position - this.GetPlaneHit();
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x0015C6F8 File Offset: 0x0015A8F8
		private Vector3 GetPlaneHit()
		{
			Plane plane = new Plane(this.PlaneNormal.forward, this.PlaneNormal.position);
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			float distance;
			plane.Raycast(ray, out distance);
			return ray.GetPoint(distance);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x0015C74A File Offset: 0x0015A94A
		public void ClickEnd()
		{
			this.isMoving = false;
		}

		// Token: 0x04003DCD RID: 15821
		[Header("Settings")]
		public float MoveSpeed = 1f;

		// Token: 0x04003DCE RID: 15822
		public bool FunnelEnabled;

		// Token: 0x04003DCF RID: 15823
		public float FunnelThreshold = 0.05f;

		// Token: 0x04003DD0 RID: 15824
		[Header("References")]
		public Animation Anim;

		// Token: 0x04003DD1 RID: 15825
		public Transform GripTransform;

		// Token: 0x04003DD2 RID: 15826
		public Transform SpinnyThingy;

		// Token: 0x04003DD3 RID: 15827
		public Transform RaisedTransform;

		// Token: 0x04003DD4 RID: 15828
		public Transform LoweredTransform;

		// Token: 0x04003DD5 RID: 15829
		public Transform PlaneNormal;

		// Token: 0x04003DD6 RID: 15830
		public Clickable HandleClickable;

		// Token: 0x04003DD7 RID: 15831
		public Transform Funnel;

		// Token: 0x04003DD8 RID: 15832
		public GameObject Highlight;

		// Token: 0x04003DD9 RID: 15833
		public AudioSourceController LowerSound;

		// Token: 0x04003DDA RID: 15834
		public AudioSourceController RaiseSound;

		// Token: 0x04003DDB RID: 15835
		private Vector3 clickOffset = Vector3.zero;

		// Token: 0x04003DDC RID: 15836
		private bool isMoving;
	}
}
