using System;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000BCD RID: 3021
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x0015C787 File Offset: 0x0015A987
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x0015C78F File Offset: 0x0015A98F
		public bool Interactable { get; private set; }

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x0015C798 File Offset: 0x0015A998
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x0015C7A0 File Offset: 0x0015A9A0
		public float CurrentStirringSpeed { get; private set; }

		// Token: 0x060052B1 RID: 21169 RVA: 0x0015C7AC File Offset: 0x0015A9AC
		private void Start()
		{
			this.SetInteractable(true);
			this.Clickable.onClickStart.AddListener(new UnityAction<RaycastHit>(this.ClickStart));
			this.Clickable.onClickEnd.AddListener(new UnityAction(this.ClickEnd));
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0015C7F8 File Offset: 0x0015A9F8
		private void Update()
		{
			float volumeMultiplier = Mathf.MoveTowards(this.StirSound.VolumeMultiplier, this.CurrentStirringSpeed, Time.deltaTime * 4f);
			this.StirSound.VolumeMultiplier = volumeMultiplier;
			if (this.StirSound.VolumeMultiplier > 0f && !this.StirSound.AudioSource.isPlaying)
			{
				this.StirSound.AudioSource.Play();
				return;
			}
			if (this.StirSound.VolumeMultiplier == 0f)
			{
				this.StirSound.AudioSource.Stop();
			}
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x0015C88C File Offset: 0x0015AA8C
		private void LateUpdate()
		{
			if (this.isMoving)
			{
				Vector3 forward = this.Container.forward;
				Vector3 planeHit = this.GetPlaneHit();
				float d = Vector3.SignedAngle(this.PlaneNormal.forward, planeHit - this.PlaneNormal.position, this.PlaneNormal.up);
				Quaternion b = this.PlaneNormal.rotation * Quaternion.Euler(Vector3.up * d);
				this.Container.rotation = Quaternion.Lerp(this.Container.rotation, b, Time.deltaTime * this.LerpSpeed);
				float f = Vector3.SignedAngle(forward, this.Container.forward, this.PlaneNormal.up);
				this.CurrentStirringSpeed = Mathf.Clamp01(Mathf.Abs(f) / 20f);
				this.RodPivot.localEulerAngles = new Vector3(7f * (1f - this.CurrentStirringSpeed), 0f, 0f);
				return;
			}
			this.CurrentStirringSpeed = 0f;
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x0015C997 File Offset: 0x0015AB97
		public void SetInteractable(bool e)
		{
			this.Interactable = e;
			this.Clickable.ClickableEnabled = e;
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x0015C9AC File Offset: 0x0015ABAC
		public void ClickStart(RaycastHit hit)
		{
			this.isMoving = true;
			this.clickOffset = this.Clickable.transform.position - this.GetPlaneHit();
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x0015C9D8 File Offset: 0x0015ABD8
		private Vector3 GetPlaneHit()
		{
			Plane plane = new Plane(this.PlaneNormal.up, this.PlaneNormal.position);
			Ray ray = PlayerSingleton<PlayerCamera>.Instance.Camera.ScreenPointToRay(Input.mousePosition);
			float distance;
			plane.Raycast(ray, out distance);
			return ray.GetPoint(distance);
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x0015CA2A File Offset: 0x0015AC2A
		public void ClickEnd()
		{
			this.isMoving = false;
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x000FA546 File Offset: 0x000F8746
		public void Destroy()
		{
			Object.Destroy(base.gameObject);
		}

		// Token: 0x04003DDD RID: 15837
		public const float MAX_STIR_RATE = 20f;

		// Token: 0x04003DDE RID: 15838
		public const float MAX_PIVOT_ANGLE = 7f;

		// Token: 0x04003DE1 RID: 15841
		public float LerpSpeed = 10f;

		// Token: 0x04003DE2 RID: 15842
		[Header("References")]
		public Clickable Clickable;

		// Token: 0x04003DE3 RID: 15843
		public Transform PlaneNormal;

		// Token: 0x04003DE4 RID: 15844
		public Transform Container;

		// Token: 0x04003DE5 RID: 15845
		public Transform RodPivot;

		// Token: 0x04003DE6 RID: 15846
		public AudioSourceController StirSound;

		// Token: 0x04003DE7 RID: 15847
		private Vector3 clickOffset = Vector3.zero;

		// Token: 0x04003DE8 RID: 15848
		private bool isMoving;
	}
}
