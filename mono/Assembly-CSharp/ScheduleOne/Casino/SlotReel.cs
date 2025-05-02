using System;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x02000773 RID: 1907
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x000D9685 File Offset: 0x000D7885
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x000D968D File Offset: 0x000D788D
		public bool IsSpinning { get; private set; }

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x000D9696 File Offset: 0x000D7896
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x000D969E File Offset: 0x000D789E
		public SlotMachine.ESymbol CurrentSymbol { get; private set; } = SlotMachine.ESymbol.Seven;

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x000D96A7 File Offset: 0x000D78A7
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x000D96AF File Offset: 0x000D78AF
		public float CurrentRotation { get; private set; }

		// Token: 0x0600341A RID: 13338 RVA: 0x000D96B8 File Offset: 0x000D78B8
		private void Awake()
		{
			this.SetSymbol(SlotMachine.GetRandomSymbol());
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000D96C5 File Offset: 0x000D78C5
		private void Update()
		{
			if (this.IsSpinning)
			{
				this.SetReelRotation(this.CurrentRotation + this.SpinSpeed * Time.deltaTime);
				return;
			}
			this.SetReelRotation(this.GetSymbolRotation(this.CurrentSymbol));
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000D96FB File Offset: 0x000D78FB
		public void Spin()
		{
			this.IsSpinning = true;
			if (this.onStart != null)
			{
				this.onStart.Invoke();
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000D9717 File Offset: 0x000D7917
		public void Stop(SlotMachine.ESymbol endSymbol)
		{
			this.CurrentSymbol = endSymbol;
			this.IsSpinning = false;
			this.StopSound.Play();
			if (this.onStop != null)
			{
				this.onStop.Invoke();
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000D9745 File Offset: 0x000D7945
		public void SetSymbol(SlotMachine.ESymbol symbol)
		{
			this.CurrentSymbol = symbol;
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000D974E File Offset: 0x000D794E
		private void SetReelRotation(float rotation)
		{
			base.transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);
			this.CurrentRotation = rotation % 360f;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000D9778 File Offset: 0x000D7978
		private float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			foreach (SlotReel.SymbolRotation symbolRotation in this.SymbolRotations)
			{
				if (symbolRotation.Symbol == symbol)
				{
					return symbolRotation.Rotation;
				}
			}
			Console.LogWarning("SlotReel.GetSymbolRotation: Symbol not found: " + symbol.ToString(), null);
			return 0f;
		}

		// Token: 0x04002525 RID: 9509
		[Header("Settings")]
		public SlotReel.SymbolRotation[] SymbolRotations;

		// Token: 0x04002526 RID: 9510
		public float SpinSpeed = 1000f;

		// Token: 0x04002527 RID: 9511
		[Header("References")]
		public AudioSourceController StopSound;

		// Token: 0x04002528 RID: 9512
		public UnityEvent onStart;

		// Token: 0x04002529 RID: 9513
		public UnityEvent onStop;

		// Token: 0x02000774 RID: 1908
		[Serializable]
		public class SymbolRotation
		{
			// Token: 0x0400252A RID: 9514
			public SlotMachine.ESymbol Symbol;

			// Token: 0x0400252B RID: 9515
			public float Rotation;
		}
	}
}
