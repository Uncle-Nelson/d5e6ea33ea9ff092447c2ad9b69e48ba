using System;
using UnityEngine;

// Token: 0x02000063 RID: 99
public class ExampleWheelController : MonoBehaviour
{
	// Token: 0x06000233 RID: 563 RVA: 0x0000D126 File Offset: 0x0000B326
	private void Start()
	{
		this.m_Rigidbody = base.GetComponent<Rigidbody>();
		this.m_Rigidbody.maxAngularVelocity = 100f;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000D144 File Offset: 0x0000B344
	private void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.m_Rigidbody.AddRelativeTorque(new Vector3(-1f * this.acceleration, 0f, 0f), 5);
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			this.m_Rigidbody.AddRelativeTorque(new Vector3(1f * this.acceleration, 0f, 0f), 5);
		}
		float value = -this.m_Rigidbody.angularVelocity.x / 100f;
		if (this.motionVectorRenderer)
		{
			this.motionVectorRenderer.material.SetFloat(ExampleWheelController.Uniforms._MotionAmount, Mathf.Clamp(value, -0.25f, 0.25f));
		}
	}

	// Token: 0x04000268 RID: 616
	public float acceleration;

	// Token: 0x04000269 RID: 617
	public Renderer motionVectorRenderer;

	// Token: 0x0400026A RID: 618
	private Rigidbody m_Rigidbody;

	// Token: 0x02000064 RID: 100
	private static class Uniforms
	{
		// Token: 0x0400026B RID: 619
		internal static readonly int _MotionAmount = Shader.PropertyToID("_MotionAmount");
	}
}
