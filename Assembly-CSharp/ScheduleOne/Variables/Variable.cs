using System;
using FishNet.Connection;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Quests;
using UnityEngine.Events;

namespace ScheduleOne.Variables
{
	// Token: 0x02000291 RID: 657
	public class Variable<T> : BaseVariable
	{
		// Token: 0x06000D8F RID: 3471 RVA: 0x0003C81B File Offset: 0x0003AA1B
		public Variable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, T value) : base(name, replicationMode, persistent, mode, owner)
		{
			this.Value = value;
			this.ReplicateValue(null);
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0003C844 File Offset: 0x0003AA44
		public override object GetValue()
		{
			return this.Value;
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0003C854 File Offset: 0x0003AA54
		public override void SetValue(object value, bool replicate)
		{
			if (value is string)
			{
				T t;
				if (this.TryDeserialize((string)value, out t))
				{
					value = t;
				}
				else
				{
					string[] array = new string[6];
					array[0] = "Failed to deserialize value '";
					int num = 1;
					T t2 = t;
					array[num] = ((t2 != null) ? t2.ToString() : null);
					array[2] = "' for variable ";
					array[3] = this.Name;
					array[4] = " of type ";
					array[5] = typeof(T).Name;
					Console.LogWarning(string.Concat(array), null);
				}
			}
			this.Value = (T)((object)value);
			if (replicate)
			{
				this.ReplicateValue(null);
			}
			if (this.OnValueChanged != null)
			{
				this.OnValueChanged.Invoke(this.Value);
			}
			StateMachine.ChangeState();
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0003C918 File Offset: 0x0003AB18
		public virtual bool TryDeserialize(string valueString, out T value)
		{
			value = default(T);
			return false;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x0003C924 File Offset: 0x0003AB24
		public override void ReplicateValue(NetworkConnection conn)
		{
			if (this.VariableMode == EVariableMode.Global)
			{
				NetworkSingleton<VariableDatabase>.Instance.SendValue(conn, this.Name, this.Value.ToString());
				return;
			}
			if (base.Owner.IsOwner)
			{
				Player.Local.SendValue(this.Name, this.Value.ToString(), false);
				return;
			}
			base.Owner.SendValue(this.Name, this.Value.ToString(), true);
		}

		// Token: 0x04000E3A RID: 3642
		public T Value;

		// Token: 0x04000E3B RID: 3643
		public UnityEvent<T> OnValueChanged = new UnityEvent<T>();
	}
}
