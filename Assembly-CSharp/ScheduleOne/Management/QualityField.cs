using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x02000579 RID: 1401
	public class QualityField : ConfigField
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0008F4A2 File Offset: 0x0008D6A2
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x0008F4AA File Offset: 0x0008D6AA
		public EQuality Value { get; protected set; } = EQuality.Standard;

		// Token: 0x060022D8 RID: 8920 RVA: 0x0008F4B3 File Offset: 0x0008D6B3
		public QualityField(EntityConfiguration parentConfig) : base(parentConfig)
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0008F4CE File Offset: 0x0008D6CE
		public void SetValue(EQuality value, bool network)
		{
			this.Value = value;
			if (network)
			{
				base.ParentConfig.ReplicateField(this, null);
			}
			if (this.onValueChanged != null)
			{
				this.onValueChanged.Invoke(this.Value);
			}
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0008F500 File Offset: 0x0008D700
		public override bool IsValueDefault()
		{
			return this.Value == EQuality.Standard;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0008F50B File Offset: 0x0008D70B
		public QualityFieldData GetData()
		{
			return new QualityFieldData(this.Value);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0008F518 File Offset: 0x0008D718
		public void Load(QualityFieldData data)
		{
			if (data != null)
			{
				this.SetValue(data.Value, true);
			}
		}

		// Token: 0x04001A3F RID: 6719
		public UnityEvent<EQuality> onValueChanged = new UnityEvent<EQuality>();
	}
}
