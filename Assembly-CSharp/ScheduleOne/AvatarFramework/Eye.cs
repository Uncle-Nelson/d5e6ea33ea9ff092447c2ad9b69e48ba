using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000964 RID: 2404
	public class Eye : MonoBehaviour
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x00112FC1 File Offset: 0x001111C1
		// (set) Token: 0x06004173 RID: 16755 RVA: 0x00112FC9 File Offset: 0x001111C9
		public Eye.EyeLidConfiguration CurrentConfiguration { get; protected set; }

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06004174 RID: 16756 RVA: 0x00112FD2 File Offset: 0x001111D2
		public bool IsBlinking
		{
			get
			{
				return this.blinkRoutine != null;
			}
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x00112FDD File Offset: 0x001111DD
		private void Awake()
		{
			this.avatar = base.GetComponentInParent<Avatar>();
			this.EyeLight.Enabled = false;
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x00112FF7 File Offset: 0x001111F7
		public void SetSize(float size)
		{
			this.Container.localScale = Eye.defaultScale * size;
		}

		// Token: 0x06004177 RID: 16759 RVA: 0x0011300F File Offset: 0x0011120F
		public void SetLidColor(Color color)
		{
			this.TopLidRend.material.color = color;
			this.BottomLidRend.material.color = color;
		}

		// Token: 0x06004178 RID: 16760 RVA: 0x00113033 File Offset: 0x00111233
		public void SetEyeballMaterial(Material mat, Color col)
		{
			this.EyeBallRend.material = mat;
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x00113041 File Offset: 0x00111241
		public void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
			this.EyeBallRend.material.color = col;
			this.EyeBallRend.material.SetColor("_EmissionColor", col * emission);
			if (writeDefault)
			{
				this.defaultEyeColor = col;
			}
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x0011307A File Offset: 0x0011127A
		public void ResetEyeballColor()
		{
			this.EyeBallRend.material.color = this.defaultEyeColor;
			this.EyeBallRend.material.SetColor("_EmissionColor", this.defaultEyeColor * 0.115f);
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x001130B8 File Offset: 0x001112B8
		public void ConfigureEyeLight(Color color, float intensity)
		{
			if (this.EyeLight == null || this.EyeLight._Light == null)
			{
				return;
			}
			this.EyeLight._Light.color = color;
			this.EyeLight._Light.intensity = intensity;
			this.EyeLight.Enabled = (intensity > 0f);
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x0011311C File Offset: 0x0011131C
		public void SetDilation(float dil)
		{
			this.PupilRend.SetBlendShapeWeight(0, dil * 100f);
		}

		// Token: 0x0600417D RID: 16765 RVA: 0x00113134 File Offset: 0x00111334
		public void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
			Eye.<>c__DisplayClass34_0 CS$<>8__locals1 = new Eye.<>c__DisplayClass34_0();
			CS$<>8__locals1.config = config;
			CS$<>8__locals1.time = time;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.startConfig = this.CurrentConfiguration;
			this.StopExistingRoutines();
			if (!Singleton<CoroutineService>.InstanceExists)
			{
				return;
			}
			this.stateRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetEyeLidState>g__Routine|0());
		}

		// Token: 0x0600417E RID: 16766 RVA: 0x0011318C File Offset: 0x0011138C
		private void StopExistingRoutines()
		{
			if (this.blinkRoutine != null)
			{
				base.StopCoroutine(this.blinkRoutine);
			}
			if (this.stateRoutine != null)
			{
				base.StopCoroutine(this.stateRoutine);
			}
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x001131B8 File Offset: 0x001113B8
		public void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
			if (this.TopLidContainer == null || this.BottomLidContainer == null)
			{
				return;
			}
			if (debug)
			{
				string str = "Setting eye lid state: ";
				Eye.EyeLidConfiguration eyeLidConfiguration = config;
				Console.Log(str + eyeLidConfiguration.ToString(), null);
			}
			this.TopLidContainer.localRotation = Quaternion.Lerp(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(-90f, 0f, 0f), config.topLidOpen);
			this.BottomLidContainer.localRotation = Quaternion.Lerp(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(90f, 0f, 0f), config.bottomLidOpen);
			this.CurrentConfiguration = config;
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x00113288 File Offset: 0x00111488
		public void LookAt(Vector3 position, bool instant = false)
		{
			Vector3 vector = (position - this.EyeLookOrigin.position).normalized;
			vector = this.EyeLookOrigin.InverseTransformDirection(vector);
			vector.z = Mathf.Clamp(vector.z, 0.1f, float.MaxValue);
			vector = this.EyeLookOrigin.TransformDirection(vector);
			Vector3 vector2 = this.EyeLookOrigin.InverseTransformDirection(vector);
			vector2.x = 0f;
			vector2 = this.EyeLookOrigin.TransformDirection(vector2);
			float num = Vector3.SignedAngle(this.EyeLookOrigin.forward, vector2, this.EyeLookOrigin.right);
			Vector3 vector3 = this.EyeLookOrigin.InverseTransformDirection(vector);
			vector3.y = 0f;
			vector3 = this.EyeLookOrigin.TransformDirection(vector3);
			float num2 = Vector3.SignedAngle(this.EyeLookOrigin.forward, vector3, this.EyeLookOrigin.up);
			Vector3 vector4 = new Vector3(Mathf.Clamp(num + this.AngleOffset.x, Eye.minRotation.y, Eye.maxRotation.y), Mathf.Clamp(num2 + this.AngleOffset.y, Eye.minRotation.x, Eye.maxRotation.x), 0f);
			if (instant)
			{
				string str = "instant: ";
				Vector3 vector5 = vector4;
				Debug.Log(str + vector5.ToString());
				this.PupilContainer.localRotation = Quaternion.Euler(vector4);
				return;
			}
			this.PupilContainer.localRotation = Quaternion.Lerp(this.PupilContainer.localRotation, Quaternion.Euler(vector4), Time.deltaTime * 10f);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0011342C File Offset: 0x0011162C
		public void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
			Eye.<>c__DisplayClass38_0 CS$<>8__locals1 = new Eye.<>c__DisplayClass38_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.blinkDuration = blinkDuration;
			CS$<>8__locals1.debug = debug;
			CS$<>8__locals1.endState = endState;
			this.StopExistingRoutines();
			if (this.avatar == null || this.avatar.EmotionManager == null)
			{
				return;
			}
			if (this.avatar.EmotionManager.IsSwitchingEmotion)
			{
				return;
			}
			this.blinkRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<Blink>g__Routine|0());
		}

		// Token: 0x04002EF3 RID: 12019
		public const float PupilLookSpeed = 10f;

		// Token: 0x04002EF4 RID: 12020
		private static Vector3 defaultScale = new Vector3(0.03f, 0.03f, 0.015f);

		// Token: 0x04002EF5 RID: 12021
		private static Vector3 maxRotation = new Vector3(40f, 35f, 0f);

		// Token: 0x04002EF6 RID: 12022
		private static Vector3 minRotation = new Vector3(-40f, -90f, 0f);

		// Token: 0x04002EF8 RID: 12024
		[Header("References")]
		public Transform Container;

		// Token: 0x04002EF9 RID: 12025
		public Transform TopLidContainer;

		// Token: 0x04002EFA RID: 12026
		public Transform BottomLidContainer;

		// Token: 0x04002EFB RID: 12027
		public Transform PupilContainer;

		// Token: 0x04002EFC RID: 12028
		public MeshRenderer TopLidRend;

		// Token: 0x04002EFD RID: 12029
		public MeshRenderer BottomLidRend;

		// Token: 0x04002EFE RID: 12030
		public MeshRenderer EyeBallRend;

		// Token: 0x04002EFF RID: 12031
		public Transform EyeLookOrigin;

		// Token: 0x04002F00 RID: 12032
		public OptimizedLight EyeLight;

		// Token: 0x04002F01 RID: 12033
		public SkinnedMeshRenderer PupilRend;

		// Token: 0x04002F02 RID: 12034
		private Coroutine blinkRoutine;

		// Token: 0x04002F03 RID: 12035
		private Coroutine stateRoutine;

		// Token: 0x04002F04 RID: 12036
		private Avatar avatar;

		// Token: 0x04002F05 RID: 12037
		private Color defaultEyeColor = Color.white;

		// Token: 0x04002F06 RID: 12038
		public Vector2 AngleOffset = Vector2.zero;

		// Token: 0x02000965 RID: 2405
		[Serializable]
		public struct EyeLidConfiguration
		{
			// Token: 0x06004184 RID: 16772 RVA: 0x00113524 File Offset: 0x00111724
			public override string ToString()
			{
				return "Top: " + this.topLidOpen.ToString() + ", Bottom: " + this.bottomLidOpen.ToString();
			}

			// Token: 0x06004185 RID: 16773 RVA: 0x0011354C File Offset: 0x0011174C
			public static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				return new Eye.EyeLidConfiguration
				{
					topLidOpen = Mathf.Lerp(start.topLidOpen, end.topLidOpen, lerp),
					bottomLidOpen = Mathf.Lerp(start.bottomLidOpen, end.bottomLidOpen, lerp)
				};
			}

			// Token: 0x04002F07 RID: 12039
			[Range(0f, 1f)]
			public float topLidOpen;

			// Token: 0x04002F08 RID: 12040
			[Range(0f, 1f)]
			public float bottomLidOpen;
		}
	}
}
