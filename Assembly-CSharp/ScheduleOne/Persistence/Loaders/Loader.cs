using System;
using System.Collections.Generic;
using System.IO;

namespace ScheduleOne.Persistence.Loaders
{
	// Token: 0x02000389 RID: 905
	public class Loader
	{
		// Token: 0x0600147E RID: 5246 RVA: 0x000045B1 File Offset: 0x000027B1
		public virtual void Load(string mainPath)
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0005B930 File Offset: 0x00059B30
		public bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			return this.TryLoadFile(Path.Combine(parentPath, fileName), out contents, true);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0005B944 File Offset: 0x00059B44
		public bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			contents = string.Empty;
			string text = path;
			if (autoAddExtension)
			{
				text += ".json";
			}
			if (!File.Exists(text))
			{
				return false;
			}
			try
			{
				contents = File.ReadAllText(text);
			}
			catch (Exception ex)
			{
				string str = "Error reading file: ";
				string str2 = text;
				string str3 = "\n";
				Exception ex2 = ex;
				Console.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null), null);
				return false;
			}
			return true;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0005B9BC File Offset: 0x00059BBC
		protected List<DirectoryInfo> GetDirectories(string parentPath)
		{
			if (!Directory.Exists(parentPath))
			{
				return new List<DirectoryInfo>();
			}
			List<DirectoryInfo> list = new List<DirectoryInfo>();
			string[] directories = Directory.GetDirectories(parentPath);
			for (int i = 0; i < directories.Length; i++)
			{
				list.Add(new DirectoryInfo(directories[i]));
			}
			return list;
		}
	}
}
