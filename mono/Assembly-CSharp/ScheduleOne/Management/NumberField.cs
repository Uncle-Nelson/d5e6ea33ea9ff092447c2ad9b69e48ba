using System;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000576 RID: 1398
	public class NumberField : ConfigField
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0008EF7F File Offset: 0x0008D17F
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x0008EF87 File Offset: 0x0008D187
		public float Value { get; protected set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x0008EF90 File Offset: 0x0008D190
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x0008EF98 File Offset: 0x0008D198
		public float MinValue { get; protected set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x0008EFA1 File Offset: 0x0008D1A1
		// (set) Token: 0x060022BF RID: 8895 RVA: 0x0008EFA9 File Offset: 0x0008D1A9
		public float MaxValue { get; protected set; } = 100f;

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x0008EFB2 File Offset: 0x0008D1B2
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x0008EFBA File Offset: 0x0008D1BA
		public bool WholeNumbers { get; protected set; }

		// Token: 0x060022C2 RID: 8898 RVA: 0x0008EFC3 File Offset: 0x0008D1C3
		public NumberField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0008EFE2 File Offset: 0x0008D1E2
		public void SetValue(float value, bool network)
		{
			this.Value = value;
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onItemChanged != null)
			{
				this.onItemChanged.Invoke(this.Value);
			}
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0008F014 File Offset: 0x0008D214
		public void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
			this.MinValue = minValue;
			this.MaxValue = maxValue;
			this.WholeNumbers = wholeNumbers;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0008F02B File Offset: 0x0008D22B
		public override bool IsValueDefault()
		{
			return this.Value == 0f;
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0008F03A File Offset: 0x0008D23A
		public NumberFieldData GetData()
		{
			return new NumberFieldData(this.Value);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0008F047 File Offset: 0x0008D247
		public void Load(NumberFieldData data)
		{
			if (data != null)
			{
				this.SetValue(data.Value, true);
			}
		}

		// Token: 0x04001A33 RID: 6707
		public UnityEvent<float> onItemChanged = new UnityEvent<float>();
	}
}
