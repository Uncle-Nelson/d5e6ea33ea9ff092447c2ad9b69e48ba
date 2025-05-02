using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x0200071E RID: 1822
	[RequireComponent(typeof(Animation))]
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x000CCF09 File Offset: 0x000CB109
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x000CCF11 File Offset: 0x000CB111
		public bool IsPlaying { get; private set; }

		// Token: 0x0600315C RID: 12636 RVA: 0x000CCF1A File Offset: 0x000CB11A
		protected virtual void Awake()
		{
			this.animation = base.GetComponent<Animation>();
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000CCF28 File Offset: 0x000CB128
		private void LateUpdate()
		{
			if (this.IsPlaying)
			{
				PlayerSingleton<PlayerCamera>.Instance.transform.position = this.CameraControl.position;
				PlayerSingleton<PlayerCamera>.Instance.transform.rotation = this.CameraControl.rotation;
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000CCF68 File Offset: 0x000CB168
		public virtual void Play()
		{
			Console.Log("Playing cutscene: " + this.Name, null);
			this.animation.Play();
			this.IsPlaying = true;
			if (this.onPlay != null)
			{
				this.onPlay.Invoke();
			}
			PlayerSingleton<PlayerCamera>.Instance.AddActiveUIElement("Cutscene (" + this.Name + ")");
			PlayerSingleton<PlayerCamera>.Instance.OverrideTransform(this.CameraControl.position, this.CameraControl.rotation, 0f, false);
			Singleton<HUD>.Instance.canvas.enabled = false;
			if (this.DisablePlayerControl)
			{
				PlayerSingleton<PlayerMovement>.Instance.canMove = false;
				PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(false);
			}
			if (this.OverrideFOV)
			{
				PlayerSingleton<PlayerCamera>.Instance.OverrideFOV(this.CameraFOV, 0f);
			}
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000CD044 File Offset: 0x000CB244
		public void InvokeEnd()
		{
			Console.Log("Cutscene ended: " + this.Name, null);
			this.animation.Stop();
			this.IsPlaying = false;
			if (this.onEnd != null)
			{
				this.onEnd.Invoke();
			}
			PlayerSingleton<PlayerCamera>.Instance.RemoveActiveUIElement("Cutscene (" + this.Name + ")");
			PlayerSingleton<PlayerCamera>.Instance.StopFOVOverride(0.25f);
			PlayerSingleton<PlayerCamera>.Instance.StopTransformOverride(0f, true, false);
			PlayerSingleton<PlayerCamera>.Instance.LockMouse();
			Singleton<HUD>.Instance.canvas.enabled = true;
			PlayerSingleton<PlayerMovement>.Instance.canMove = true;
			PlayerSingleton<PlayerInventory>.Instance.SetInventoryEnabled(true);
		}

		// Token: 0x04002325 RID: 8997
		[Header("Settings")]
		public string Name = "Cutscene";

		// Token: 0x04002326 RID: 8998
		public bool DisablePlayerControl = true;

		// Token: 0x04002327 RID: 8999
		public bool OverrideFOV;

		// Token: 0x04002328 RID: 9000
		public float CameraFOV = 70f;

		// Token: 0x04002329 RID: 9001
		[Header("References")]
		public Transform CameraControl;

		// Token: 0x0400232A RID: 9002
		[Header("Events")]
		public UnityEvent onPlay;

		// Token: 0x0400232B RID: 9003
		public UnityEvent onEnd;

		// Token: 0x0400232C RID: 9004
		private Animation animation;
	}
}
