using System;
using System.Collections.Generic;
using System.IO;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.Persistence
{
	// Token: 0x02000364 RID: 868
	public interface ISaveable
	{
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060013A0 RID: 5024
		string SaveFolderName { get; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060013A1 RID: 5025
		string SaveFileName { get; }

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060013A2 RID: 5026
		Loader Loader { get; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060013A3 RID: 5027
		bool ShouldSaveUnderFolder { get; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060013A4 RID: 5028
		// (set) Token: 0x060013A5 RID: 5029
		List<string> LocalExtraFiles { get; set; }

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060013A6 RID: 5030
		// (set) Token: 0x060013A7 RID: 5031
		List<string> LocalExtraFolders { get; set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060013A8 RID: 5032
		// (set) Token: 0x060013A9 RID: 5033
		bool HasChanged { get; set; }

		// Token: 0x060013AA RID: 5034
		void InitializeSaveable();

		// Token: 0x060013AB RID: 5035
		string GetSaveString();

		// Token: 0x060013AC RID: 5036 RVA: 0x000578C4 File Offset: 0x00055AC4
		string Save(string parentFolderPath)
		{
			bool flag;
			string localPath = this.GetLocalPath(out flag);
			bool flag2 = flag ? Directory.Exists(Path.Combine(parentFolderPath, localPath)) : File.Exists(Path.Combine(parentFolderPath, localPath));
			if (!this.HasChanged && flag2)
			{
				this.CompleteSave(parentFolderPath, true);
				return localPath;
			}
			new SaveRequest(this, parentFolderPath);
			return localPath;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00057918 File Offset: 0x00055B18
		void WriteBaseData(string parentFolderPath, string saveString)
		{
			string text = Path.Combine(parentFolderPath, this.SaveFileName + ".json");
			if (this.ShouldSaveUnderFolder)
			{
				text = Path.Combine(this.GetContainerFolder(parentFolderPath), this.SaveFileName + ".json");
			}
			if (!string.IsNullOrEmpty(saveString))
			{
				try
				{
					File.WriteAllText(text, saveString);
					goto IL_A2;
				}
				catch (Exception ex)
				{
					string[] array = new string[6];
					array[0] = "Failed to write save data file. Exception: ";
					int num = 1;
					Exception ex2 = ex;
					array[num] = ((ex2 != null) ? ex2.ToString() : null);
					array[2] = "\nData path: ";
					array[3] = text;
					array[4] = "\nSave string: ";
					array[5] = saveString;
					Console.LogError(string.Concat(array), null);
					goto IL_A2;
				}
			}
			Console.LogError("Failed to write save data file because the save string is empty. Data path: " + text, null);
			IL_A2:
			this.CompleteSave(parentFolderPath, !string.IsNullOrEmpty(saveString));
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x000579E8 File Offset: 0x00055BE8
		string GetLocalPath(out bool isFolder)
		{
			string result = this.SaveFileName + ".json";
			if (this.ShouldSaveUnderFolder)
			{
				isFolder = true;
				result = this.SaveFolderName;
			}
			else
			{
				isFolder = false;
			}
			return result;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00057A20 File Offset: 0x00055C20
		void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
			List<string> list = new List<string>();
			if (this.LocalExtraFiles != null)
			{
				for (int i = 0; i < this.LocalExtraFiles.Count; i++)
				{
					list.Add(this.LocalExtraFiles[i] + ".json");
				}
			}
			if (this.LocalExtraFolders != null)
			{
				list.AddRange(this.LocalExtraFolders);
			}
			if (writeDataFile)
			{
				bool flag;
				this.GetLocalPath(out flag);
				if (flag)
				{
					string item = Path.Combine(new string[]
					{
						this.SaveFileName + ".json"
					});
					list.Add(item);
				}
			}
			List<string> collection = this.WriteData(parentFolderPath);
			list.AddRange(collection);
			if (this.ShouldSaveUnderFolder)
			{
				string containerFolder = this.GetContainerFolder(parentFolderPath);
				string[] files = Directory.GetFiles(containerFolder);
				string[] directories = Directory.GetDirectories(containerFolder);
				foreach (string text in files)
				{
					FileInfo fileInfo = new FileInfo(text);
					if (!list.Contains(fileInfo.Name))
					{
						try
						{
							File.Delete(text);
						}
						catch (Exception ex)
						{
							string str = "Failed to delete file: ";
							string str2 = text;
							string str3 = "\nException: ";
							Exception ex2 = ex;
							Console.LogError(str + str2 + str3 + ((ex2 != null) ? ex2.ToString() : null), null);
						}
					}
				}
				foreach (string text2 in directories)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text2);
					if (!list.Contains(directoryInfo.Name))
					{
						try
						{
							Directory.Delete(text2, true);
						}
						catch (Exception ex3)
						{
							string str4 = "Failed to delete folder: ";
							string str5 = text2;
							string str6 = "\nException: ";
							Exception ex4 = ex3;
							Console.LogError(str4 + str5 + str6 + ((ex4 != null) ? ex4.ToString() : null), null);
						}
					}
				}
				this.DeleteUnapprovedFiles(parentFolderPath);
			}
			Singleton<SaveManager>.Instance.CompleteSaveable(this);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00057BE8 File Offset: 0x00055DE8
		List<string> WriteData(string parentFolderPath)
		{
			return new List<string>();
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000045B1 File Offset: 0x000027B1
		void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00057BF0 File Offset: 0x00055DF0
		string GetContainerFolder(string parentFolderPath)
		{
			string text = Path.Combine(parentFolderPath, this.SaveFolderName);
			if (!Directory.Exists(text))
			{
				try
				{
					Directory.CreateDirectory(text);
				}
				catch (Exception ex)
				{
					string str = "Failed to write save folder. Exception: ";
					Exception ex2 = ex;
					Console.LogError(str + ((ex2 != null) ? ex2.ToString() : null) + "\nFolder path: " + text, null);
				}
			}
			return text;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00057C54 File Offset: 0x00055E54
		string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			bool flag;
			string text = Path.Combine(parentPath, this.GetLocalPath(out flag));
			if (!flag)
			{
				Console.LogError("Failed to write subfile: " + localPath_NoExtensions + " because the saveable is not saved under a folder.", null);
				return string.Empty;
			}
			if (!Directory.Exists(text))
			{
				Console.LogError("Failed to write subfile: " + localPath_NoExtensions + " because the main folder does not exist.", null);
				return string.Empty;
			}
			if (!this.LocalExtraFiles.Contains(localPath_NoExtensions))
			{
				Console.LogWarning("Writing subfile called '" + localPath_NoExtensions + "' that is not in the list of extra saveables. Be sure to include it in the returned files list.", null);
			}
			if (localPath_NoExtensions.Contains(".json"))
			{
				Console.LogError("Failed to write subfile: " + localPath_NoExtensions + " because it contains a data extension.", null);
				return string.Empty;
			}
			string text2 = localPath_NoExtensions + ".json";
			string text3 = Path.Combine(parentPath, text, text2);
			try
			{
				File.WriteAllText(text3, contents);
			}
			catch (Exception ex)
			{
				string[] array = new string[6];
				array[0] = "Failed to write sub file. Exception: ";
				int num = 1;
				Exception ex2 = ex;
				array[num] = ((ex2 != null) ? ex2.ToString() : null);
				array[2] = "\nData path: ";
				array[3] = text3;
				array[4] = "\nSave string: ";
				array[5] = contents;
				Console.LogError(string.Concat(array), null);
			}
			return text2;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00057D78 File Offset: 0x00055F78
		string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			bool flag;
			string text = Path.Combine(parentPath, this.GetLocalPath(out flag));
			if (!flag)
			{
				Console.LogError("Failed to write subfile: " + localPath_NoExtensions + " because the saveable is not saved under a folder.", null);
				return string.Empty;
			}
			if (!Directory.Exists(text))
			{
				Console.LogError(string.Concat(new string[]
				{
					"Failed to write subfile: ",
					localPath_NoExtensions,
					" because the main folder (",
					text,
					") does not exist."
				}), null);
				return string.Empty;
			}
			if (!this.LocalExtraFolders.Contains(localPath_NoExtensions))
			{
				Console.LogWarning("Writing subfile called '" + localPath_NoExtensions + "' that is not in the list of extra saveables. Be sure to include it in the returned files list.", null);
			}
			if (localPath_NoExtensions.Contains(".json"))
			{
				Console.LogError("Failed to write subfile: " + localPath_NoExtensions + " because it contains a data extension.", null);
				return string.Empty;
			}
			string text2 = Path.Combine(parentPath, text, localPath_NoExtensions);
			try
			{
				Directory.CreateDirectory(text2);
			}
			catch (Exception ex)
			{
				string str = "Failed to write sub folder. Exception: ";
				Exception ex2 = ex;
				Console.LogError(str + ((ex2 != null) ? ex2.ToString() : null) + "\nData path: " + text2, null);
			}
			return text2;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00057E88 File Offset: 0x00056088
		bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			return this.TryLoadFile(Path.Combine(parentPath, fileName), out contents, true);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00057E9C File Offset: 0x0005609C
		bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			contents = string.Empty;
			string text = path;
			if (autoAddExtension)
			{
				text += ".json";
			}
			if (!File.Exists(text))
			{
				Console.LogWarning("File not found at: " + text, null);
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
	}
}
