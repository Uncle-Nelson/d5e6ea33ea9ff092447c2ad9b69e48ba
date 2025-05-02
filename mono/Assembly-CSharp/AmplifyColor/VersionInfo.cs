using System;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x02000C49 RID: 3145
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x06005833 RID: 22579 RVA: 0x00171E20 File Offset: 0x00170020
		public static string StaticToString()
		{
			return string.Format("{0}.{1}.{2}", 1, 9, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x00171E4E File Offset: 0x0017004E
		public override string ToString()
		{
			return string.Format("{0}.{1}.{2}", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06005835 RID: 22581 RVA: 0x00171E8A File Offset: 0x0017008A
		public static int FullNumber
		{
			get
			{
				return 190;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x00171E91 File Offset: 0x00170091
		public int Number
		{
			get
			{
				return this.m_major * 100 + this.m_minor * 10 + this.m_release;
			}
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00171EAD File Offset: 0x001700AD
		private VersionInfo()
		{
			this.m_major = 1;
			this.m_minor = 9;
			this.m_release = 0;
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00171ECB File Offset: 0x001700CB
		private VersionInfo(byte major, byte minor, byte release)
		{
			this.m_major = (int)major;
			this.m_minor = (int)minor;
			this.m_release = (int)release;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00171EE8 File Offset: 0x001700E8
		public static VersionInfo Current()
		{
			return new VersionInfo(1, 9, 0);
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00171EF3 File Offset: 0x001700F3
		public static bool Matches(VersionInfo version)
		{
			return 1 == version.m_major && 9 == version.m_minor && version.m_release == 0;
		}

		// Token: 0x04004152 RID: 16722
		public const byte Major = 1;

		// Token: 0x04004153 RID: 16723
		public const byte Minor = 9;

		// Token: 0x04004154 RID: 16724
		public const byte Release = 0;

		// Token: 0x04004155 RID: 16725
		private static string StageSuffix = "";

		// Token: 0x04004156 RID: 16726
		private static string TrialSuffix = "";

		// Token: 0x04004157 RID: 16727
		[SerializeField]
		private int m_major;

		// Token: 0x04004158 RID: 16728
		[SerializeField]
		private int m_minor;

		// Token: 0x04004159 RID: 16729
		[SerializeField]
		private int m_release;
	}
}
