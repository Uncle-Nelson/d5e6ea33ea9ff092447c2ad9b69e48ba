using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts.Soil
{
	// Token: 0x02000BFF RID: 3071
	public class PourableSoil : Pourable
	{
		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x0016B852 File Offset: 0x00169A52
		// (set) Token: 0x06005671 RID: 22129 RVA: 0x0016B85A File Offset: 0x00169A5A
		public int currentCut { get; protected set; }

		// Token: 0x06005672 RID: 22130 RVA: 0x0016B863 File Offset: 0x00169A63
		protected override void Awake()
		{
			base.Awake();
			this.highlightScale = this.Highlights[0].transform.localScale;
			this.UpdateHighlights();
			this.ClickableEnabled = false;
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x0016B890 File Offset: 0x00169A90
		protected override void Update()
		{
			base.Update();
			this.timeSinceStart += Time.deltaTime;
			this.UpdateHighlights();
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x0016B8B0 File Offset: 0x00169AB0
		private void UpdateHighlights()
		{
			if (this.Highlights[0] == null)
			{
				return;
			}
			for (int i = 0; i < this.Highlights.Length; i++)
			{
				if (this.IsOpen || i < this.currentCut)
				{
					this.Highlights[i].gameObject.SetActive(false);
				}
				else
				{
					float num = (float)i / (float)this.Highlights.Length;
					float num2 = Mathf.Sin(Mathf.Clamp(this.timeSinceStart * 5f - num, 0f, float.MaxValue)) + 1f;
					this.Highlights[i].transform.localScale = new Vector3(this.highlightScale.x * num2, this.highlightScale.y, this.highlightScale.z * num2);
				}
			}
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x0016B980 File Offset: 0x00169B80
		protected override void PourAmount(float amount)
		{
			base.PourAmount(amount);
			this.SoilBag.localScale = new Vector3(1f, Mathf.Lerp(0.45f, 1f, this.currentQuantity / this.StartQuantity), 1f);
			if (base.IsPourPointOverPot())
			{
				if (this.TargetPot.SoilID != this.SoilDefinition.ID)
				{
					this.TargetPot.SetSoilID(this.SoilDefinition.ID);
					this.TargetPot.SetSoilUses(this.SoilDefinition.Uses);
				}
				this.TargetPot.SetSoilState(Pot.ESoilState.Flat);
				this.TargetPot.AddSoil(amount);
			}
			if (this.TargetPot.SoilLevel >= this.TargetPot.SoilCapacity)
			{
				Singleton<TaskManager>.Instance.currentTask.Success();
			}
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x0016BA5A File Offset: 0x00169C5A
		protected override bool CanPour()
		{
			return this.IsOpen && base.CanPour();
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x0016BA6C File Offset: 0x00169C6C
		public void Cut()
		{
			this.TopColliders[this.currentCut].enabled = false;
			this.LerpCut(this.currentCut);
			if (this.currentCut == this.Bones.Length - 1)
			{
				this.FinishCut();
			}
			this.SnipSound.AudioSource.pitch = 0.9f + (float)this.currentCut * 0.05f;
			this.SnipSound.PlayOneShot(false);
			int currentCut = this.currentCut;
			this.currentCut = currentCut + 1;
		}

		// Token: 0x06005678 RID: 22136 RVA: 0x0016BAF4 File Offset: 0x00169CF4
		private void FinishCut()
		{
			this.IsOpen = true;
			Rigidbody rigidbody = this.TopParent.gameObject.AddComponent<Rigidbody>();
			this.TopParent.transform.SetParent(null);
			rigidbody.interpolation = 1;
			rigidbody.AddRelativeForce(Vector3.forward * 1.5f, 2);
			rigidbody.AddRelativeForce(Vector3.up * 0.3f, 2);
			rigidbody.AddTorque(Vector3.up * 1.5f, 2);
			this.ClickableEnabled = true;
			if (this.onOpened != null)
			{
				this.onOpened.Invoke();
			}
			Object.Destroy(this.TopParent.gameObject, 3f);
			Object.Destroy(this.TopMesh.gameObject, 3f);
		}

		// Token: 0x06005679 RID: 22137 RVA: 0x0016BBB8 File Offset: 0x00169DB8
		private void LerpCut(int cutIndex)
		{
			PourableSoil.<>c__DisplayClass25_0 CS$<>8__locals1 = new PourableSoil.<>c__DisplayClass25_0();
			CS$<>8__locals1.bone = this.Bones[cutIndex];
			CS$<>8__locals1.startRot = CS$<>8__locals1.bone.localRotation;
			CS$<>8__locals1.endRot = CS$<>8__locals1.bone.localRotation * Quaternion.Euler(0f, 0f, 10f);
			base.StartCoroutine(CS$<>8__locals1.<LerpCut>g__Routine|0());
		}

		// Token: 0x04003FCB RID: 16331
		public const float TEAR_ANGLE = 10f;

		// Token: 0x04003FCC RID: 16332
		public const float HIGHLIGHT_CYCLE_TIME = 5f;

		// Token: 0x04003FCD RID: 16333
		public bool IsOpen;

		// Token: 0x04003FCE RID: 16334
		public SoilDefinition SoilDefinition;

		// Token: 0x04003FCF RID: 16335
		[Header("References")]
		public Transform SoilBag;

		// Token: 0x04003FD0 RID: 16336
		public Transform[] Bones;

		// Token: 0x04003FD1 RID: 16337
		public List<Collider> TopColliders;

		// Token: 0x04003FD2 RID: 16338
		public MeshRenderer[] Highlights;

		// Token: 0x04003FD3 RID: 16339
		public Transform TopParent;

		// Token: 0x04003FD4 RID: 16340
		public AudioSourceController SnipSound;

		// Token: 0x04003FD5 RID: 16341
		public SkinnedMeshRenderer TopMesh;

		// Token: 0x04003FD7 RID: 16343
		public UnityEvent onOpened;

		// Token: 0x04003FD8 RID: 16344
		private Vector3 highlightScale = Vector3.zero;

		// Token: 0x04003FD9 RID: 16345
		private float timeSinceStart;
	}
}
