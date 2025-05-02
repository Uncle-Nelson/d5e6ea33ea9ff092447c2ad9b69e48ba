using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	// Token: 0x020007E4 RID: 2020
	public class VehicleRecorder : MonoBehaviour
	{
		// Token: 0x06003737 RID: 14135 RVA: 0x000E8680 File Offset: 0x000E6880
		protected virtual void Update()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				this.IS_RECORDING = !this.IS_RECORDING;
				if (this.IS_RECORDING)
				{
					this.keyFrames.Clear();
					this.vehicleToRecord = PlayerSingleton<PlayerMovement>.Instance.currentVehicle;
				}
			}
			if (this.vehicleToRecord && this.IS_RECORDING)
			{
				if (this.timeSinceKeyFrame >= 1f / (float)VehicleRecorder.frameRate)
				{
					this.timeSinceKeyFrame = 0f;
					VehicleKeyFrame item = this.Capture();
					this.keyFrames.Add(item);
				}
				Console.Log(this.vehicleToRecord.speed_Kmh, null);
				this.timeSinceKeyFrame += Time.deltaTime;
			}
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x000E8738 File Offset: 0x000E6938
		private VehicleKeyFrame Capture()
		{
			VehicleKeyFrame vehicleKeyFrame = new VehicleKeyFrame();
			vehicleKeyFrame.position = this.vehicleToRecord.transform.position;
			vehicleKeyFrame.rotation = this.vehicleToRecord.transform.rotation;
			vehicleKeyFrame.brakesApplied = this.vehicleToRecord.brakesApplied;
			vehicleKeyFrame.reversing = this.vehicleToRecord.isReversing;
			if (this.vehicleToRecord.GetComponent<VehicleLights>())
			{
				vehicleKeyFrame.headlightsOn = this.vehicleToRecord.GetComponent<VehicleLights>().headLightsOn;
			}
			foreach (Wheel wheel in this.vehicleToRecord.wheels)
			{
				vehicleKeyFrame.wheels.Add(this.CaptureWheel(wheel));
			}
			return vehicleKeyFrame;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x000E8818 File Offset: 0x000E6A18
		private VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel)
		{
			return new VehicleKeyFrame.WheelTransform
			{
				yPos = wheel.transform.Find("Model").transform.localPosition.y,
				rotation = wheel.transform.Find("Model").transform.localRotation
			};
		}

		// Token: 0x040027C8 RID: 10184
		public static int frameRate = 24;

		// Token: 0x040027C9 RID: 10185
		public bool IS_RECORDING;

		// Token: 0x040027CA RID: 10186
		public List<VehicleKeyFrame> keyFrames = new List<VehicleKeyFrame>();

		// Token: 0x040027CB RID: 10187
		private LandVehicle vehicleToRecord;

		// Token: 0x040027CC RID: 10188
		private float timeSinceKeyFrame;
	}
}
