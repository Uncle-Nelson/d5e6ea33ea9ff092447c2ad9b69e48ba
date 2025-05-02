using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BBC RID: 3004
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x00156DE6 File Offset: 0x00154FE6
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x00156DEE File Offset: 0x00154FEE
		public bool Interactable { get; private set; }

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x00156DF7 File Offset: 0x00154FF7
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x00156DFF File Offset: 0x00154FFF
		public float CurrentPosition { get; private set; }

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x00156E08 File Offset: 0x00155008
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x00156E10 File Offset: 0x00155010
		public float TargetPosition { get; private set; }

		// Token: 0x0600516A RID: 20842 RVA: 0x00156E1C File Offset: 0x0015501C
		private void Start()
		{
			this.SetPosition(0f);
			this.SetInteractable(false);
			this.HandleClickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ClickStart));
			this.HandleClickable.onClickEnd.AddListener(new UnityAction(this.ClickEnd));
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x00156E74 File Offset: 0x00155074
		private void LateUpdate()
		{
			if (!this.Locked)
			{
				if (this.isMoving)
				{
					Vector3 vector = this.GetPlaneHit() + this.clickOffset;
					float position = 1f - Mathf.Clamp01(Mathf.InverseLerp(Mathf.Min(this.LoweredTransform.position.y, this.RaisedTransform.position.y), Mathf.Max(this.LoweredTransform.position.y, this.RaisedTransform.position.y), vector.y));
					this.SetPosition(position);
				}
				else
				{
					this.SetPosition(Mathf.MoveTowards(this.TargetPosition, 0f, Time.deltaTime));
				}
			}
			this.Move();
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00156F34 File Offset: 0x00155134
		private void Move()
		{
			this.CurrentPosition = Mathf.MoveTowards(this.CurrentPosition, this.TargetPosition, this.MoveSpeed * Time.deltaTime);
			base.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(0f, 360f, this.CurrentPosition));
			if (Mathf.Abs(this.CurrentPosition - this.lastClickPosition) > 0.1666f)
			{
				this.lastClickPosition = this.CurrentPosition;
				this.ClickSound.AudioSource.pitch = Mathf.Lerp(0.7f, 1.1f, this.CurrentPosition);
				this.ClickSound.Play();
			}
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00156FE8 File Offset: 0x001551E8
		private void UpdateSound(float difference)
		{
			difference /= 0.05f;
			if (difference < 0f)
			{
				Mathf.Abs(difference);
			}
			if (difference > 0f)
			{
				Mathf.Abs(difference);
			}
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x00157011 File Offset: 0x00155211
		public void SetPosition(float position)
		{
			this.TargetPosition = position;
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x0015701A File Offset: 0x0015521A
		public void SetInteractable(bool e)
		{
			this.Interactable = e;
			this.HandleClickable.ClickableEnabled = e;
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x0015702F File Offset: 0x0015522F
		public void ClickStart(RaycastHit hit)
		{
			this.isMoving = true;
			this.clickOffset = this.HandleClickable.transform.position - this.GetPlaneHit();
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00157059 File Offset: 0x00155259
		public void ClickEnd()
		{
			this.isMoving = false;
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00157064 File Offset: 0x00155264
		private Vector3 GetPlaneHit()
		{
			Plane plane = new Plane(this.PlaneNormal.forward, this.PlaneNormal.position);
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			float distance;
			plane.Raycast(ray, out distance);
			return ray.GetPoint(distance);
		}

		// Token: 0x04003D12 RID: 15634
		private float lastClickPosition;

		// Token: 0x04003D13 RID: 15635
		[Header("Settings")]
		public float MoveSpeed = 1f;

		// Token: 0x04003D14 RID: 15636
		public bool Locked;

		// Token: 0x04003D15 RID: 15637
		[Header("References")]
		public Transform PlaneNormal;

		// Token: 0x04003D16 RID: 15638
		public Transform RaisedTransform;

		// Token: 0x04003D17 RID: 15639
		public Transform LoweredTransform;

		// Token: 0x04003D18 RID: 15640
		public Clickable HandleClickable;

		// Token: 0x04003D19 RID: 15641
		public AudioSourceController ClickSound;

		// Token: 0x04003D1A RID: 15642
		private Vector3 clickOffset = Vector3.zero;

		// Token: 0x04003D1B RID: 15643
		private bool isMoving;
	}
}
