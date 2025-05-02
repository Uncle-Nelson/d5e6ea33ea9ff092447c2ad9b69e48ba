using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using AeLa.EasyFeedback;
using AeLa.EasyFeedback.FormElements;
using AeLa.EasyFeedback.Utility;
using ScheduleOne.DevUtilities;
using ScheduleOne.Networking;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	// Token: 0x020009E0 RID: 2528
	public class FeedbackForm : FeedbackForm
	{
		// Token: 0x0600443B RID: 17467 RVA: 0x0011E270 File Offset: 0x0011C470
		public override void Awake()
		{
			base.Awake();
			this.ScreenshotToggle.SetIsOnWithoutNotify(this.IncludeScreenshot);
			this.ScreenshotToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnScreenshotToggle));
			this.SaveFileToggle.SetIsOnWithoutNotify(this.IncludeSaveFile);
			this.SaveFileToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSaveFileToggle));
			this.OnSubmissionSucceeded.AddListener(new UnityAction(this.Clear));
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x0011E2F4 File Offset: 0x0011C4F4
		private void Update()
		{
			this.Cog.localEulerAngles += new Vector3(0f, 0f, -180f * Time.unscaledDeltaTime);
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x0011E326 File Offset: 0x0011C526
		public void PrepScreenshot()
		{
			this.CurrentReport = new Report();
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x0011E333 File Offset: 0x0011C533
		private void OnScreenshotToggle(bool value)
		{
			this.IncludeScreenshot = value;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x0011E33C File Offset: 0x0011C53C
		private void OnSaveFileToggle(bool value)
		{
			this.IncludeSaveFile = value;
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x0011E345 File Offset: 0x0011C545
		public void SetFormData(string title)
		{
			if (this.CurrentReport == null)
			{
				this.CurrentReport = new Report();
			}
			this.CurrentReport.Title = title;
			base.GetComponentInChildren<ReportTitle>().GetComponent<TMP_InputField>().SetTextWithoutNotify(title);
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x0011E378 File Offset: 0x0011C578
		public void SetCategory(string categoryName)
		{
			for (int i = 0; i < this.Config.Board.CategoryNames.Length; i++)
			{
				if (this.Config.Board.CategoryNames[i].Contains(categoryName))
				{
					this.CategoryDropdown.SetValueWithoutNotify(i + 1);
					return;
				}
			}
			Console.LogWarning("Category not found: " + categoryName, null);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x0011E3DC File Offset: 0x0011C5DC
		public override void Submit()
		{
			if (this.IncludeScreenshot)
			{
				PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(false, 0f);
				this.CanvasGroup.alpha = 0f;
				this.ssCoroutine = Singleton<CoroutineService>.Instance.StartCoroutine(this.ScreenshotAndOpenForm());
				Singleton<CoroutineService>.Instance.StartCoroutine(this.<Submit>g__Wait|15_0());
			}
			if (File.Exists(Application.persistentDataPath + "/Player-prev.log"))
			{
				try
				{
					byte[] array = File.ReadAllBytes(Application.persistentDataPath + "/Player-prev.log");
					this.CurrentReport.AttachFile("Player-prev.txt", array);
				}
				catch (Exception ex)
				{
					Console.LogError("Failed to attach Player-prev.txt: " + ex.Message, null);
				}
			}
			if (this.IncludeSaveFile)
			{
				string loadedGameFolderPath = Singleton<LoadManager>.Instance.LoadedGameFolderPath;
				string text = loadedGameFolderPath + ".zip";
				try
				{
					if (File.Exists(text))
					{
						Console.Log("Deleting prior zip file: " + text, null);
						File.Delete(text);
					}
					ZipFile.CreateFromDirectory(loadedGameFolderPath, text, CompressionLevel.Optimal, true);
					byte[] array2 = File.ReadAllBytes(text);
					this.CurrentReport.AttachFile("SaveGame.zip", array2);
				}
				catch (Exception ex2)
				{
					Console.LogError("Failed to attach save file: " + ex2.Message, null);
				}
				finally
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
				}
			}
			if (Player.Local != null)
			{
				Report currentReport = this.CurrentReport;
				currentReport.Title = currentReport.Title + " (" + Player.Local.PlayerName + ")";
			}
			this.CurrentReport.AddSection("Game Info", 2);
			string text2 = "Singleplayer";
			if (Singleton<Lobby>.InstanceExists && Singleton<Lobby>.Instance.IsInLobby)
			{
				text2 = "Multiplayer";
				if (Singleton<Lobby>.Instance.IsHost)
				{
					text2 += " (Host)";
				}
				else
				{
					text2 += " (Client)";
				}
			}
			this.CurrentReport["Game Info"].AppendLine("Network Mode: " + text2);
			this.CurrentReport["Game Info"].AppendLine("Player Count: " + Player.PlayerList.Count.ToString());
			this.CurrentReport["Game Info"].AppendLine("Beta Branch: " + GameManager.IS_BETA.ToString());
			this.CurrentReport["Game Info"].AppendLine("Is Demo: " + false.ToString());
			this.CurrentReport["Game Info"].AppendLine("Load History: " + string.Join(", ", LoadManager.LoadHistory));
			Singleton<CoroutineService>.Instance.StartCoroutine(base.SubmitAsync());
			base.Submit();
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x0011E6C8 File Offset: 0x0011C8C8
		protected override string GetTextToAppendToTitle()
		{
			string text = base.GetTextToAppendToTitle();
			text = text + " (" + Application.version + ")";
			if (Player.Local != null)
			{
				text = text + " (" + Player.Local.PlayerName + ")";
			}
			return text;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x0011E71B File Offset: 0x0011C91B
		private void Clear()
		{
			this.SummaryField.SetTextWithoutNotify(string.Empty);
			this.DescriptionField.SetTextWithoutNotify(string.Empty);
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x0011E73D File Offset: 0x0011C93D
		private IEnumerator ScreenshotAndOpenForm()
		{
			if (this.IncludeScreenshot)
			{
				yield return ScreenshotUtil.CaptureScreenshot(this.ScreenshotCaptureMode, this.ResizeLargeScreenshots, delegate(byte[] ss)
				{
					this.CurrentReport.AttachFile("screenshot.png", ss);
				}, delegate(string err)
				{
					this.OnSubmissionError.Invoke(err);
				});
			}
			base.EnableForm();
			this.Form.gameObject.SetActive(true);
			this.OnFormOpened.Invoke();
			this.ssCoroutine = null;
			yield break;
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x0011E754 File Offset: 0x0011C954
		[CompilerGenerated]
		private IEnumerator <Submit>g__Wait|15_0()
		{
			yield return new WaitForEndOfFrame();
			PlayerSingleton<PlayerCamera>.Instance.SetDoFActive(true, 0f);
			this.CanvasGroup.alpha = 1f;
			yield break;
		}

		// Token: 0x040031BE RID: 12734
		private Coroutine ssCoroutine;

		// Token: 0x040031BF RID: 12735
		public CanvasGroup CanvasGroup;

		// Token: 0x040031C0 RID: 12736
		public Toggle ScreenshotToggle;

		// Token: 0x040031C1 RID: 12737
		public Toggle SaveFileToggle;

		// Token: 0x040031C2 RID: 12738
		public TMP_InputField SummaryField;

		// Token: 0x040031C3 RID: 12739
		public TMP_InputField DescriptionField;

		// Token: 0x040031C4 RID: 12740
		public RectTransform Cog;

		// Token: 0x040031C5 RID: 12741
		public TMP_Dropdown CategoryDropdown;
	}
}
