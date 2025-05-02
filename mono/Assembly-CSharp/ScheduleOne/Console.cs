using System;
using System.Collections.Generic;
using FishNet;
using ScheduleOne.DevUtilities;
using ScheduleOne.Employees;
using ScheduleOne.GameTime;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.Persistence;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.Trash;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000232 RID: 562
	public class Console : Singleton<Console>
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000370E8 File Offset: 0x000352E8
		private static Player player
		{
			get
			{
				return Player.Local;
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000370EF File Offset: 0x000352EF
		private static void LogCommandError(string error)
		{
			Console.LogWarning(error, null);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000370F8 File Offset: 0x000352F8
		private static void LogUnrecognizedFormat(string[] correctExamples)
		{
			string text = string.Empty;
			for (int i = 0; i < correctExamples.Length; i++)
			{
				if (i > 0)
				{
					text += ",";
				}
				text = text + "'" + correctExamples[i] + "'";
			}
			Console.LogWarning("Unrecognized command format. Correct format example(s): " + text, null);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00037150 File Offset: 0x00035350
		protected override void Awake()
		{
			base.Awake();
			if (Singleton<Console>.Instance != this)
			{
				return;
			}
			if (Console.commands.Count == 0)
			{
				Console.commands.Add("freecam", new Console.FreeCamCommand());
				Console.commands.Add("save", new Console.Save());
				Console.commands.Add("settime", new Console.SetTimeCommand());
				Console.commands.Add("give", new Console.AddItemToInventoryCommand());
				Console.commands.Add("clearinventory", new Console.ClearInventoryCommand());
				Console.commands.Add("changecash", new Console.ChangeCashCommand());
				Console.commands.Add("changebalance", new Console.ChangeOnlineBalanceCommand());
				Console.commands.Add("addxp", new Console.GiveXP());
				Console.commands.Add("spawnvehicle", new Console.SpawnVehicleCommand());
				Console.commands.Add("setmovespeed", new Console.SetMoveSpeedCommand());
				Console.commands.Add("setjumpforce", new Console.SetJumpMultiplier());
				Console.commands.Add("teleport", new Console.Teleport());
				Console.commands.Add("setowned", new Console.SetPropertyOwned());
				Console.commands.Add("packageproduct", new Console.PackageProduct());
				Console.commands.Add("setstaminareserve", new Console.SetStaminaReserve());
				Console.commands.Add("raisewanted", new Console.RaisedWanted());
				Console.commands.Add("lowerwanted", new Console.LowerWanted());
				Console.commands.Add("clearwanted", new Console.ClearWanted());
				Console.commands.Add("sethealth", new Console.SetHealth());
				Console.commands.Add("settimescale", new Console.SetTimeScale());
				Console.commands.Add("setvar", new Console.SetVariableValue());
				Console.commands.Add("setqueststate", new Console.SetQuestState());
				Console.commands.Add("setquestentrystate", new Console.SetQuestEntryState());
				Console.commands.Add("setemotion", new Console.SetEmotion());
				Console.commands.Add("setunlocked", new Console.SetUnlocked());
				Console.commands.Add("setrelationship", new Console.SetRelationship());
				Console.commands.Add("addemployee", new Console.AddEmployeeCommand());
				Console.commands.Add("setdiscovered", new Console.SetDiscovered());
				Console.commands.Add("growplants", new Console.GrowPlants());
				Console.commands.Add("setlawintensity", new Console.SetLawIntensity());
				Console.commands.Add("setquality", new Console.SetQuality());
				Console.commands.Add("bind", new Console.Bind());
				Console.commands.Add("unbind", new Console.Unbind());
				Console.commands.Add("clearbinds", new Console.ClearBinds());
				Console.commands.Add("hideui", new Console.HideUI());
				Console.commands.Add("disable", new Console.Disable());
				Console.commands.Add("enable", new Console.Enable());
				Console.commands.Add("endtutorial", new Console.EndTutorial());
				Console.commands.Add("disablenpcasset", new Console.DisableNPCAsset());
				Console.commands.Add("showfps", new Console.ShowFPS());
				Console.commands.Add("hidefps", new Console.HideFPS());
				Console.commands.Add("cleartrash", new Console.ClearTrash());
			}
			foreach (KeyValuePair<string, Console.ConsoleCommand> keyValuePair in Console.commands)
			{
				Console.Commands.Add(keyValuePair.Value);
			}
			Player.onLocalPlayerSpawned = (Action)Delegate.Remove(Player.onLocalPlayerSpawned, new Action(this.RunStartupCommands));
			Player.onLocalPlayerSpawned = (Action)Delegate.Combine(Player.onLocalPlayerSpawned, new Action(this.RunStartupCommands));
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00037558 File Offset: 0x00035758
		private void RunStartupCommands()
		{
			if (Application.isEditor || Debug.isDebugBuild)
			{
				foreach (string args in this.startupCommands)
				{
					Console.SubmitCommand(args);
				}
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000375B8 File Offset: 0x000357B8
		[HideInCallstack]
		public static void Log(object message, Object context = null)
		{
			Debug.Log(message, context);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000375C1 File Offset: 0x000357C1
		[HideInCallstack]
		public static void LogWarning(object message, Object context = null)
		{
			Debug.LogWarning(message, context);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000375CA File Offset: 0x000357CA
		[HideInCallstack]
		public static void LogError(object message, Object context = null)
		{
			Debug.LogError(message, context);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000375D4 File Offset: 0x000357D4
		public static void SubmitCommand(List<string> args)
		{
			if (args.Count == 0)
			{
				return;
			}
			if (!InstanceFinder.IsHost && !Application.isEditor && !Debug.isDebugBuild)
			{
				return;
			}
			for (int i = 0; i < args.Count; i++)
			{
				args[i] = args[i].ToLower();
			}
			string text = args[0];
			Console.ConsoleCommand consoleCommand;
			if (Console.commands.TryGetValue(text, out consoleCommand))
			{
				args.RemoveAt(0);
				consoleCommand.Execute(args);
				return;
			}
			Console.LogWarning("Command '" + text + "' not found.", null);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00037660 File Offset: 0x00035860
		public static void SubmitCommand(string args)
		{
			Console.SubmitCommand(new List<string>(args.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries)));
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00037680 File Offset: 0x00035880
		public void AddBinding(KeyCode key, string command)
		{
			Console.Log("Binding " + key.ToString() + " to " + command, null);
			if (this.keyBindings.ContainsKey(key))
			{
				this.keyBindings[key] = command;
				return;
			}
			this.keyBindings.Add(key, command);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000376D9 File Offset: 0x000358D9
		public void RemoveBinding(KeyCode key)
		{
			Console.Log("Unbinding " + key.ToString(), null);
			this.keyBindings.Remove(key);
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00037705 File Offset: 0x00035905
		public void ClearBindings()
		{
			Console.Log("Clearing all key bindings", null);
			this.keyBindings.Clear();
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00037720 File Offset: 0x00035920
		private void Update()
		{
			if (!GameInput.IsTyping && !Singleton<PauseMenu>.Instance.IsPaused)
			{
				foreach (KeyValuePair<KeyCode, string> keyValuePair in this.keyBindings)
				{
					if (Input.GetKeyDown(keyValuePair.Key))
					{
						Console.SubmitCommand(keyValuePair.Value);
					}
				}
			}
		}

		// Token: 0x04000D50 RID: 3408
		public Transform TeleportPointsContainer;

		// Token: 0x04000D51 RID: 3409
		public List<Console.LabelledGameObject> LabelledGameObjectList;

		// Token: 0x04000D52 RID: 3410
		[Tooltip("Commands that run on startup (Editor only)")]
		public List<string> startupCommands = new List<string>();

		// Token: 0x04000D53 RID: 3411
		public static List<Console.ConsoleCommand> Commands = new List<Console.ConsoleCommand>();

		// Token: 0x04000D54 RID: 3412
		private static Dictionary<string, Console.ConsoleCommand> commands = new Dictionary<string, Console.ConsoleCommand>();

		// Token: 0x04000D55 RID: 3413
		private Dictionary<KeyCode, string> keyBindings = new Dictionary<KeyCode, string>();

		// Token: 0x02000233 RID: 563
		public abstract class ConsoleCommand
		{
			// Token: 0x1700025F RID: 607
			// (get) Token: 0x06000BE2 RID: 3042
			public abstract string CommandWord { get; }

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x06000BE3 RID: 3043
			public abstract string CommandDescription { get; }

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06000BE4 RID: 3044
			public abstract string ExampleUsage { get; }

			// Token: 0x06000BE5 RID: 3045
			public abstract void Execute(List<string> args);
		}

		// Token: 0x02000234 RID: 564
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x17000262 RID: 610
			// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000377D0 File Offset: 0x000359D0
			public override string CommandWord
			{
				get
				{
					return "settime";
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x000377D7 File Offset: 0x000359D7
			public override string CommandDescription
			{
				get
				{
					return "Sets the time of day to the specified 24-hour time";
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000377DE File Offset: 0x000359DE
			public override string ExampleUsage
			{
				get
				{
					return "settime 1530";
				}
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x000377E8 File Offset: 0x000359E8
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0 || !TimeManager.IsValid24HourTime(args[0]))
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'settime 1530'", null);
					return;
				}
				if (Player.Local.IsSleeping)
				{
					Console.LogWarning("Can't set time whilst sleeping", null);
					return;
				}
				Console.Log("Time set to " + args[0], null);
				NetworkSingleton<TimeManager>.Instance.SetTime(int.Parse(args[0]), false);
			}
		}

		// Token: 0x02000235 RID: 565
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00037866 File Offset: 0x00035A66
			public override string CommandWord
			{
				get
				{
					return "spawnvehicle";
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000BED RID: 3053 RVA: 0x0003786D File Offset: 0x00035A6D
			public override string CommandDescription
			{
				get
				{
					return "Spawns a vehicle at the player's location";
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00037874 File Offset: 0x00035A74
			public override string ExampleUsage
			{
				get
				{
					return "spawnvehicle shitbox";
				}
			}

			// Token: 0x06000BEF RID: 3055 RVA: 0x0003787C File Offset: 0x00035A7C
			public override void Execute(List<string> args)
			{
				bool flag = false;
				if (args.Count > 0 && NetworkSingleton<VehicleManager>.Instance.GetVehiclePrefab(args[0]) != null)
				{
					flag = true;
					Console.Log("Spawning '" + args[0] + "'...", null);
					Vector3 position = Console.player.transform.position + Console.player.transform.forward * 4f + Console.player.transform.up * 1f;
					Quaternion rotation = Console.player.transform.rotation;
					NetworkSingleton<VehicleManager>.Instance.SpawnAndReturnVehicle(args[0], position, rotation, true);
				}
				if (!flag)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'spawnvehicle shitbox'", null);
				}
			}
		}

		// Token: 0x02000236 RID: 566
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00037950 File Offset: 0x00035B50
			public override string CommandWord
			{
				get
				{
					return "give";
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00037957 File Offset: 0x00035B57
			public override string CommandDescription
			{
				get
				{
					return "Gives the player the specified item. Optionally specify a quantity.";
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0003795E File Offset: 0x00035B5E
			public override string ExampleUsage
			{
				get
				{
					return "give ogkush 5";
				}
			}

			// Token: 0x06000BF4 RID: 3060 RVA: 0x00037968 File Offset: 0x00035B68
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'give watering_can', 'give watering_can 5'", null);
					return;
				}
				ItemDefinition item = Registry.GetItem(args[0]);
				if (!(item != null))
				{
					Console.LogWarning("Unrecognized item code '" + args[0] + "'", null);
					return;
				}
				ItemInstance defaultInstance = item.GetDefaultInstance(1);
				if (args[0] == "cash")
				{
					Console.LogWarning("Unrecognized item code '" + args[0] + "'", null);
					return;
				}
				if (PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(defaultInstance, 1))
				{
					int num = 1;
					if (args.Count > 1)
					{
						bool flag = false;
						if (int.TryParse(args[1], out num) && num > 0)
						{
							flag = true;
						}
						if (!flag)
						{
							Console.LogWarning("Unrecognized quantity '" + args[1] + "'. Please provide a positive integer", null);
						}
					}
					int num2 = 0;
					while (num > 0 && PlayerSingleton<PlayerInventory>.Instance.CanItemFitInInventory(defaultInstance, 1))
					{
						PlayerSingleton<PlayerInventory>.Instance.AddItemToInventory(defaultInstance);
						num--;
						num2++;
					}
					Console.Log(string.Concat(new string[]
					{
						"Added ",
						num2.ToString(),
						" ",
						item.Name,
						" to inventory"
					}), null);
					return;
				}
				Console.LogWarning("Insufficient inventory space", null);
			}
		}

		// Token: 0x02000237 RID: 567
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00037AC2 File Offset: 0x00035CC2
			public override string CommandWord
			{
				get
				{
					return "clearinventory";
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00037AC9 File Offset: 0x00035CC9
			public override string CommandDescription
			{
				get
				{
					return "Clears the player's inventory";
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00037AC2 File Offset: 0x00035CC2
			public override string ExampleUsage
			{
				get
				{
					return "clearinventory";
				}
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00037AD0 File Offset: 0x00035CD0
			public override void Execute(List<string> args)
			{
				Console.Log("Clearing player inventory...", null);
				PlayerSingleton<PlayerInventory>.Instance.ClearInventory();
			}
		}

		// Token: 0x02000238 RID: 568
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00037AE7 File Offset: 0x00035CE7
			public override string CommandWord
			{
				get
				{
					return "changecash";
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00037AEE File Offset: 0x00035CEE
			public override string CommandDescription
			{
				get
				{
					return "Changes the player's cash balance by the specified amount";
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00037AF5 File Offset: 0x00035CF5
			public override string ExampleUsage
			{
				get
				{
					return "changecash 5000";
				}
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x00037AFC File Offset: 0x00035CFC
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num))
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'changecash 5000', 'changecash -5000'", null);
					return;
				}
				if (num > 0f)
				{
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(num, true, false);
					Console.Log("Gave player " + MoneyManager.FormatAmount(num, false, false) + " cash", null);
					return;
				}
				if (num < 0f)
				{
					num = Mathf.Clamp(num, -NetworkSingleton<MoneyManager>.Instance.cashBalance, 0f);
					NetworkSingleton<MoneyManager>.Instance.ChangeCashBalance(num, true, false);
					Console.Log("Removed " + MoneyManager.FormatAmount(num, false, false) + " cash from player", null);
				}
			}
		}

		// Token: 0x02000239 RID: 569
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00037BAF File Offset: 0x00035DAF
			public override string CommandWord
			{
				get
				{
					return "changebalance";
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00037BB6 File Offset: 0x00035DB6
			public override string CommandDescription
			{
				get
				{
					return "Changes the player's online balance by the specified amount";
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00037BBD File Offset: 0x00035DBD
			public override string ExampleUsage
			{
				get
				{
					return "changebalance 5000";
				}
			}

			// Token: 0x06000C03 RID: 3075 RVA: 0x00037BC4 File Offset: 0x00035DC4
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num))
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'changebalance 5000', 'changebalance -5000'", null);
					return;
				}
				if (num > 0f)
				{
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Added online balance", num, 1f, "Added by developer console");
					Console.Log("Increased online balance by " + MoneyManager.FormatAmount(num, false, false), null);
					return;
				}
				if (num < 0f)
				{
					num = Mathf.Clamp(num, -NetworkSingleton<MoneyManager>.Instance.SyncAccessor_onlineBalance, 0f);
					NetworkSingleton<MoneyManager>.Instance.CreateOnlineTransaction("Removed online balance", num, 1f, "Removed by developer console");
					Console.Log("Decreased online balance by " + MoneyManager.FormatAmount(num, false, false), null);
				}
			}
		}

		// Token: 0x0200023A RID: 570
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00037C87 File Offset: 0x00035E87
			public override string CommandWord
			{
				get
				{
					return "setmovespeed";
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00037C8E File Offset: 0x00035E8E
			public override string CommandDescription
			{
				get
				{
					return "Sets the player's move speed multiplier";
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00037C95 File Offset: 0x00035E95
			public override string ExampleUsage
			{
				get
				{
					return "setmovespeed 1";
				}
			}

			// Token: 0x06000C08 RID: 3080 RVA: 0x00037C9C File Offset: 0x00035E9C
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'setmovespeed 1'", null);
					return;
				}
				Console.Log("Setting player move speed multiplier to " + num.ToString(), null);
				PlayerMovement.StaticMoveSpeedMultiplier = num;
			}
		}

		// Token: 0x0200023B RID: 571
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00037CF8 File Offset: 0x00035EF8
			public override string CommandWord
			{
				get
				{
					return "setjumpforce";
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00037CFF File Offset: 0x00035EFF
			public override string CommandDescription
			{
				get
				{
					return "Sets the player's jump force multiplier";
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00037D06 File Offset: 0x00035F06
			public override string ExampleUsage
			{
				get
				{
					return "setjumpforce 1";
				}
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00037D10 File Offset: 0x00035F10
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'setjumpforce 1'", null);
					return;
				}
				Console.Log("Setting player jump force multiplier to " + num.ToString(), null);
				PlayerMovement.JumpMultiplier = num;
			}
		}

		// Token: 0x0200023C RID: 572
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00037D6C File Offset: 0x00035F6C
			public override string CommandWord
			{
				get
				{
					return "setowned";
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00037D73 File Offset: 0x00035F73
			public override string CommandDescription
			{
				get
				{
					return "Sets the specified property or business as owned";
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00037D7A File Offset: 0x00035F7A
			public override string ExampleUsage
			{
				get
				{
					return "setowned barn, setowned laundromat";
				}
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x00037D84 File Offset: 0x00035F84
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						"setowned barn",
						"setowned manor"
					});
					return;
				}
				string code = args[0].ToLower();
				Property property = Property.UnownedProperties.Find((Property x) => x.PropertyCode.ToLower() == code);
				Business business = Business.UnownedBusinesses.Find((Business x) => x.PropertyCode.ToLower() == code);
				if (property == null && business == null)
				{
					Console.LogCommandError("Could not find unowned property with code '" + code + "'");
					return;
				}
				if (property != null)
				{
					property.SetOwned();
				}
				if (business != null)
				{
					business.SetOwned();
				}
				Console.Log("Property with code '" + code + "' is now owned", null);
			}
		}

		// Token: 0x0200023E RID: 574
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00037E7D File Offset: 0x0003607D
			public override string CommandWord
			{
				get
				{
					return "teleport";
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00037E84 File Offset: 0x00036084
			public override string CommandDescription
			{
				get
				{
					return "Teleports the player to the specified location";
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00037E8B File Offset: 0x0003608B
			public override string ExampleUsage
			{
				get
				{
					return "teleport townhall, teleport barn";
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x00037E94 File Offset: 0x00036094
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						"teleport docks",
						"teleport barn"
					});
					return;
				}
				string text = args[0].ToLower();
				Transform transform = null;
				Vector3 b = Vector3.zero;
				for (int i = 0; i < Singleton<Console>.Instance.TeleportPointsContainer.childCount; i++)
				{
					if (Singleton<Console>.Instance.TeleportPointsContainer.GetChild(i).name.ToLower() == text)
					{
						transform = Singleton<Console>.Instance.TeleportPointsContainer.GetChild(i);
						break;
					}
				}
				if (transform == null)
				{
					for (int j = 0; j < Property.Properties.Count; j++)
					{
						if (Property.Properties[j].PropertyCode.ToLower() == text)
						{
							transform = Property.Properties[j].SpawnPoint;
							b = Vector3.up * 1f;
							break;
						}
					}
				}
				if (transform == null)
				{
					for (int k = 0; k < Business.Businesses.Count; k++)
					{
						if (Business.Businesses[k].PropertyCode.ToLower() == text)
						{
							transform = Business.Businesses[k].SpawnPoint;
							b = Vector3.up * 1f;
							break;
						}
					}
				}
				if (transform == null)
				{
					Console.LogCommandError("Unrecognized destination");
					return;
				}
				PlayerSingleton<PlayerMovement>.Instance.Teleport(transform.transform.position + b);
				Player.Local.transform.forward = transform.transform.forward;
				Console.Log("Teleported to '" + text + "'", null);
			}
		}

		// Token: 0x0200023F RID: 575
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00038054 File Offset: 0x00036254
			public override string CommandWord
			{
				get
				{
					return "packageprodcut";
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003805B File Offset: 0x0003625B
			public override string CommandDescription
			{
				get
				{
					return "Packages the equipped product with the specified packaging";
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00038062 File Offset: 0x00036262
			public override string ExampleUsage
			{
				get
				{
					return "packageproduct jar, packageproduct baggie";
				}
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x0003806C File Offset: 0x0003626C
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						"packageproduct jar",
						"packageproduct baggie"
					});
					return;
				}
				PackagingDefinition packagingDefinition = Registry.GetItem(args[0].ToLower()) as PackagingDefinition;
				if (packagingDefinition == null)
				{
					Console.LogCommandError("Unrecognized packaging ID");
					return;
				}
				if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance is ProductItemInstance)
				{
					(PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance as ProductItemInstance).SetPackaging(packagingDefinition);
					PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
					PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
					Console.Log("Applied packaging '" + packagingDefinition.Name + "' to equipped product", null);
					return;
				}
				Console.LogCommandError("No product equipped");
			}
		}

		// Token: 0x02000240 RID: 576
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00038144 File Offset: 0x00036344
			public override string CommandWord
			{
				get
				{
					return "setstaminareserve";
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0003814B File Offset: 0x0003634B
			public override string CommandDescription
			{
				get
				{
					return "Sets the player's stamina reserve (default 100) to the specified amount.";
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00038152 File Offset: 0x00036352
			public override string ExampleUsage
			{
				get
				{
					return "setstaminareserve 200";
				}
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x0003815C File Offset: 0x0003635C
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'setstaminareserve 200'", null);
					return;
				}
				Console.Log("Setting player stamina reserve to " + num.ToString(), null);
				PlayerMovement.StaminaReserveMax = num;
				PlayerSingleton<PlayerMovement>.Instance.SetStamina(num, true);
			}
		}

		// Token: 0x02000241 RID: 577
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000381C4 File Offset: 0x000363C4
			public override string CommandWord
			{
				get
				{
					return "raisewanted";
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000381CB File Offset: 0x000363CB
			public override string CommandDescription
			{
				get
				{
					return "Raises the player's wanted level";
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000381C4 File Offset: 0x000363C4
			public override string ExampleUsage
			{
				get
				{
					return "raisewanted";
				}
			}

			// Token: 0x06000C29 RID: 3113 RVA: 0x000381D4 File Offset: 0x000363D4
			public override void Execute(List<string> args)
			{
				Console.Log("Raising wanted level...", null);
				if (Console.player.CrimeData.CurrentPursuitLevel == PlayerCrimeData.EPursuitLevel.None)
				{
					Singleton<LawManager>.Instance.PoliceCalled(Console.player, new Crime());
				}
				Console.player.CrimeData.Escalate();
			}
		}

		// Token: 0x02000242 RID: 578
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00038220 File Offset: 0x00036420
			public override string CommandWord
			{
				get
				{
					return "lowerwanted";
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00038227 File Offset: 0x00036427
			public override string CommandDescription
			{
				get
				{
					return "Lowers the player's wanted level";
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00038220 File Offset: 0x00036420
			public override string ExampleUsage
			{
				get
				{
					return "lowerwanted";
				}
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x0003822E File Offset: 0x0003642E
			public override void Execute(List<string> args)
			{
				Console.Log("Lowering wanted level...", null);
				Console.player.CrimeData.Deescalate();
			}
		}

		// Token: 0x02000243 RID: 579
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0003824A File Offset: 0x0003644A
			public override string CommandWord
			{
				get
				{
					return "clearwanted";
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00038251 File Offset: 0x00036451
			public override string CommandDescription
			{
				get
				{
					return "Clears the player's wanted level";
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0003824A File Offset: 0x0003644A
			public override string ExampleUsage
			{
				get
				{
					return "clearwanted";
				}
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x00038258 File Offset: 0x00036458
			public override void Execute(List<string> args)
			{
				Console.Log("Clearing wanted level...", null);
				Console.player.CrimeData.SetPursuitLevel(PlayerCrimeData.EPursuitLevel.None);
				Console.player.CrimeData.ClearCrimes();
			}
		}

		// Token: 0x02000244 RID: 580
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00038284 File Offset: 0x00036484
			public override string CommandWord
			{
				get
				{
					return "sethealth";
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0003828B File Offset: 0x0003648B
			public override string CommandDescription
			{
				get
				{
					return "Sets the player's health to the specified amount";
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00038292 File Offset: 0x00036492
			public override string ExampleUsage
			{
				get
				{
					return "sethealth 100";
				}
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x0003829C File Offset: 0x0003649C
			public override void Execute(List<string> args)
			{
				if (!Console.player.Health.IsAlive)
				{
					Console.LogWarning("Can't set health whilst dead", null);
					return;
				}
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'sethealth 100'", null);
					return;
				}
				Console.Log("Setting player health to " + num.ToString(), null);
				Console.player.Health.SetHealth(num);
				if (num < 0f)
				{
					PlayerSingleton<PlayerCamera>.Instance.JoltCamera();
				}
			}
		}

		// Token: 0x02000245 RID: 581
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00038331 File Offset: 0x00036531
			public override string CommandWord
			{
				get
				{
					return "setenergy";
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00038338 File Offset: 0x00036538
			public override string CommandDescription
			{
				get
				{
					return "Sets the player's energy to the specified amount";
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003833F File Offset: 0x0003653F
			public override string ExampleUsage
			{
				get
				{
					return "setenergy 100";
				}
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x00038348 File Offset: 0x00036548
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'setenergy 100'", null);
					return;
				}
				num = Mathf.Clamp(num, 0f, 100f);
				Console.Log("Setting player energy to " + num.ToString(), null);
				Player.Local.Energy.SetEnergy(num);
			}
		}

		// Token: 0x02000246 RID: 582
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000C3F RID: 3135 RVA: 0x000383BF File Offset: 0x000365BF
			public override string CommandWord
			{
				get
				{
					return "freecam";
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000C40 RID: 3136 RVA: 0x000383C6 File Offset: 0x000365C6
			public override string CommandDescription
			{
				get
				{
					return "Toggles free cam mode";
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000C41 RID: 3137 RVA: 0x000383BF File Offset: 0x000365BF
			public override string ExampleUsage
			{
				get
				{
					return "freecam";
				}
			}

			// Token: 0x06000C42 RID: 3138 RVA: 0x000383CD File Offset: 0x000365CD
			public override void Execute(List<string> args)
			{
				if (PlayerSingleton<PlayerCamera>.Instance.FreeCamEnabled)
				{
					PlayerSingleton<PlayerCamera>.Instance.SetFreeCam(false, true);
					return;
				}
				PlayerSingleton<PlayerCamera>.Instance.SetFreeCam(true, true);
			}
		}

		// Token: 0x02000247 RID: 583
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000383F4 File Offset: 0x000365F4
			public override string CommandWord
			{
				get
				{
					return "save";
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000383FB File Offset: 0x000365FB
			public override string CommandDescription
			{
				get
				{
					return "Forces a save";
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000383F4 File Offset: 0x000365F4
			public override string ExampleUsage
			{
				get
				{
					return "save";
				}
			}

			// Token: 0x06000C47 RID: 3143 RVA: 0x00038402 File Offset: 0x00036602
			public override void Execute(List<string> args)
			{
				Console.Log("Forcing save...", null);
				Singleton<SaveManager>.Instance.Save();
			}
		}

		// Token: 0x02000248 RID: 584
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00038419 File Offset: 0x00036619
			public override string CommandWord
			{
				get
				{
					return "settimescale";
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00038420 File Offset: 0x00036620
			public override string CommandDescription
			{
				get
				{
					return "Sets the time scale. Default 1";
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00038427 File Offset: 0x00036627
			public override string ExampleUsage
			{
				get
				{
					return "settimescale 1";
				}
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x00038430 File Offset: 0x00036630
			public override void Execute(List<string> args)
			{
				if (!Singleton<Settings>.Instance.PausingFreezesTime)
				{
					Console.LogWarning("Can't set time scale right now.", null);
					return;
				}
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): 'settimescale 1'", null);
					return;
				}
				num = Mathf.Clamp(num, 0f, 20f);
				Console.Log("Setting time scale to " + num.ToString(), null);
				Time.timeScale = num;
			}
		}

		// Token: 0x02000249 RID: 585
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000C4E RID: 3150 RVA: 0x000384B5 File Offset: 0x000366B5
			public override string CommandWord
			{
				get
				{
					return "setvar";
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000384BC File Offset: 0x000366BC
			public override string CommandDescription
			{
				get
				{
					return "Sets the value of the specified variable";
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000384C3 File Offset: 0x000366C3
			public override string ExampleUsage
			{
				get
				{
					return "setvar <variable> <value>";
				}
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x000384CC File Offset: 0x000366CC
			public override void Execute(List<string> args)
			{
				if (args.Count >= 2)
				{
					string variableName = args[0].ToLower();
					string value = args[1];
					NetworkSingleton<VariableDatabase>.Instance.SetVariableValue(variableName, value, true);
					return;
				}
				Console.LogWarning("Unrecognized command format. Example usage: " + this.ExampleUsage, null);
			}
		}

		// Token: 0x0200024A RID: 586
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003851B File Offset: 0x0003671B
			public override string CommandWord
			{
				get
				{
					return "setqueststate";
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00038522 File Offset: 0x00036722
			public override string CommandDescription
			{
				get
				{
					return "Sets the state of the specified quest";
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00038529 File Offset: 0x00036729
			public override string ExampleUsage
			{
				get
				{
					return "setqueststate <quest name> <state>";
				}
			}

			// Token: 0x06000C56 RID: 3158 RVA: 0x00038530 File Offset: 0x00036730
			public override void Execute(List<string> args)
			{
				if (args.Count < 2)
				{
					Console.LogWarning("Unrecognized command format. Example usage: " + this.ExampleUsage, null);
					return;
				}
				string text = args[0].ToLower();
				string text2 = args[1];
				text = text.Replace("_", " ");
				Quest quest = Quest.GetQuest(text);
				if (quest == null)
				{
					Console.LogWarning("Failed to find quest with name '" + text + "'", null);
					return;
				}
				EQuestState state = EQuestState.Inactive;
				if (!Enum.TryParse<EQuestState>(text2, true, out state))
				{
					Console.LogWarning("Failed to parse quest state '" + text2 + "'", null);
					return;
				}
				quest.SetQuestState(state, true);
			}
		}

		// Token: 0x0200024B RID: 587
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000385D6 File Offset: 0x000367D6
			public override string CommandWord
			{
				get
				{
					return "setquestentrystate";
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x000385DD File Offset: 0x000367DD
			public override string CommandDescription
			{
				get
				{
					return "Sets the state of the specified quest entry";
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000385E4 File Offset: 0x000367E4
			public override string ExampleUsage
			{
				get
				{
					return "setquestentrystate <quest name> <entry index> <state>";
				}
			}

			// Token: 0x06000C5B RID: 3163 RVA: 0x000385EC File Offset: 0x000367EC
			public override void Execute(List<string> args)
			{
				if (args.Count < 3)
				{
					Console.LogWarning("Unrecognized command format. Example usage: " + this.ExampleUsage, null);
					return;
				}
				string text = args[0].ToLower();
				int num = int.TryParse(args[1], out num) ? num : -1;
				string text2 = args[2];
				text = text.Replace("_", " ");
				Quest quest = Quest.GetQuest(text);
				if (quest == null)
				{
					Console.LogWarning("Failed to find quest with name '" + text + "'", null);
					return;
				}
				if (num < 0 || num >= quest.Entries.Count)
				{
					Console.LogWarning("Invalid entry index", null);
					return;
				}
				EQuestState state = EQuestState.Inactive;
				if (!Enum.TryParse<EQuestState>(text2, true, out state))
				{
					Console.LogWarning("Failed to parse quest state '" + text2 + "'", null);
					return;
				}
				quest.SetQuestEntryState(num, state, true);
			}
		}

		// Token: 0x0200024C RID: 588
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000C5D RID: 3165 RVA: 0x000386CB File Offset: 0x000368CB
			public override string CommandWord
			{
				get
				{
					return "setemotion";
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000C5E RID: 3166 RVA: 0x000386D2 File Offset: 0x000368D2
			public override string CommandDescription
			{
				get
				{
					return "Sets the facial expression of the player's avatar.";
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000386D9 File Offset: 0x000368D9
			public override string ExampleUsage
			{
				get
				{
					return "setemotion cheery";
				}
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x000386E0 File Offset: 0x000368E0
			public override void Execute(List<string> args)
			{
				if (!Singleton<Settings>.Instance.PausingFreezesTime)
				{
					Console.LogWarning("Can't set time scale right now.", null);
					return;
				}
				if (args.Count == 0)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): " + this.ExampleUsage, null);
					return;
				}
				string text = args[0].ToLower();
				if (!Player.Local.Avatar.EmotionManager.HasEmotion(text))
				{
					Console.LogWarning("Unrecognized emotion '" + text + "'", null);
					return;
				}
				Console.Log("Setting emotion to " + text, null);
				Player.Local.Avatar.EmotionManager.AddEmotionOverride(text, "console", 0f, 0);
			}
		}

		// Token: 0x0200024D RID: 589
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00038790 File Offset: 0x00036990
			public override string CommandWord
			{
				get
				{
					return "setunlocked";
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00038797 File Offset: 0x00036997
			public override string CommandDescription
			{
				get
				{
					return "Unlocks the given NPC";
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003879E File Offset: 0x0003699E
			public override string ExampleUsage
			{
				get
				{
					return "setunlocked <npc_id>";
				}
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x000387A8 File Offset: 0x000369A8
			public override void Execute(List<string> args)
			{
				if (args.Count < 1)
				{
					Console.LogWarning("Unrecognized command format. Example usage: " + this.ExampleUsage, null);
					return;
				}
				string text = args[0].ToLower();
				NPC npc = NPCManager.GetNPC(text);
				if (npc == null)
				{
					Console.LogWarning("Failed to find NPC with ID '" + text + "'", null);
					return;
				}
				npc.RelationData.Unlock(NPCRelationData.EUnlockType.DirectApproach, true);
			}
		}

		// Token: 0x0200024E RID: 590
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00038816 File Offset: 0x00036A16
			public override string CommandWord
			{
				get
				{
					return "setrelationship";
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0003881D File Offset: 0x00036A1D
			public override string CommandDescription
			{
				get
				{
					return "Sets the relationship scalar of the given NPC. Range is 0-5.";
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00038824 File Offset: 0x00036A24
			public override string ExampleUsage
			{
				get
				{
					return "setrelationship <npc_id> 5";
				}
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x0003882C File Offset: 0x00036A2C
			public override void Execute(List<string> args)
			{
				if (args.Count < 2)
				{
					Console.LogWarning("Unrecognized command format. Example usage: " + this.ExampleUsage, null);
					return;
				}
				string text = args[0].ToLower();
				NPC npc = NPCManager.GetNPC(text);
				if (npc == null)
				{
					Console.LogWarning("Failed to find NPC with ID '" + text + "'", null);
					return;
				}
				float num = 0f;
				if (!float.TryParse(args[1], out num) || num < 0f || num > 5f)
				{
					Console.LogWarning("Invalid scalar value. Must be between 0 and 5.", null);
					return;
				}
				npc.RelationData.SetRelationship(num);
			}
		}

		// Token: 0x0200024F RID: 591
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000388CB File Offset: 0x00036ACB
			public override string CommandWord
			{
				get
				{
					return "addemployee";
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000388D2 File Offset: 0x00036AD2
			public override string CommandDescription
			{
				get
				{
					return "Adds an employee of the specified type to the given property.";
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000388D9 File Offset: 0x00036AD9
			public override string ExampleUsage
			{
				get
				{
					return "addemployee botanist barn";
				}
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x000388E0 File Offset: 0x00036AE0
			public override void Execute(List<string> args)
			{
				if (args.Count < 2)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						"setowned barn",
						"setowned manor"
					});
					return;
				}
				args[0].ToLower();
				EEmployeeType type = EEmployeeType.Botanist;
				if (!Enum.TryParse<EEmployeeType>(args[0], true, out type))
				{
					Console.LogCommandError("Unrecognized employee type '" + args[0] + "'");
					return;
				}
				string code = args[1].ToLower();
				Property property = Property.OwnedProperties.Find((Property x) => x.PropertyCode.ToLower() == code);
				if (property == null)
				{
					Console.LogCommandError("Could not find property with code '" + code + "'");
					return;
				}
				NetworkSingleton<EmployeeManager>.Instance.CreateNewEmployee(property, type);
				Console.Log(string.Concat(new string[]
				{
					"Adding employee of type '",
					type.ToString(),
					"' to property '",
					property.PropertyCode,
					"'"
				}), null);
			}
		}

		// Token: 0x02000251 RID: 593
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00038A0A File Offset: 0x00036C0A
			public override string CommandWord
			{
				get
				{
					return "setdiscovered";
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00038A11 File Offset: 0x00036C11
			public override string CommandDescription
			{
				get
				{
					return "Sets the specified product as discovered";
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00038A18 File Offset: 0x00036C18
			public override string ExampleUsage
			{
				get
				{
					return "setdiscovered ogkush";
				}
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x00038A20 File Offset: 0x00036C20
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						this.ExampleUsage
					});
					return;
				}
				string text = args[0].ToLower();
				ProductDefinition productDefinition = Registry.GetItem(text) as ProductDefinition;
				if (productDefinition == null)
				{
					Console.LogCommandError("Unrecognized product code '" + text + "'");
					return;
				}
				NetworkSingleton<ProductManager>.Instance.DiscoverProduct(productDefinition.ID);
				Console.Log(productDefinition.Name + " now discovered", null);
			}
		}

		// Token: 0x02000252 RID: 594
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00038AA9 File Offset: 0x00036CA9
			public override string CommandWord
			{
				get
				{
					return "growplants";
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00038AB0 File Offset: 0x00036CB0
			public override string CommandDescription
			{
				get
				{
					return "Sets ALL plants in the world fully grown";
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00038AA9 File Offset: 0x00036CA9
			public override string ExampleUsage
			{
				get
				{
					return "growplants";
				}
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x00038AB8 File Offset: 0x00036CB8
			public override void Execute(List<string> args)
			{
				Plant[] array = Object.FindObjectsOfType<Plant>();
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Pot.FullyGrowPlant();
				}
			}
		}

		// Token: 0x02000253 RID: 595
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00038AE6 File Offset: 0x00036CE6
			public override string CommandWord
			{
				get
				{
					return "setlawintensity";
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00038AED File Offset: 0x00036CED
			public override string CommandDescription
			{
				get
				{
					return "Sets the intensity of law enforcement activity on a scale of 0-10.";
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00038AF4 File Offset: 0x00036CF4
			public override string ExampleUsage
			{
				get
				{
					return "setlawintensity 6";
				}
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x00038AFC File Offset: 0x00036CFC
			public override void Execute(List<string> args)
			{
				float num = 0f;
				if (args.Count == 0 || !float.TryParse(args[0], out num) || num < 0f)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): " + this.ExampleUsage, null);
					return;
				}
				float num2 = Mathf.Clamp(num, 0f, 10f);
				Console.Log("Setting law enforcement intensity to " + num2.ToString(), null);
				Singleton<LawController>.Instance.SetInternalIntensity(num2 / 10f);
			}
		}

		// Token: 0x02000254 RID: 596
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00038B7F File Offset: 0x00036D7F
			public override string CommandWord
			{
				get
				{
					return "setquality";
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00038B86 File Offset: 0x00036D86
			public override string CommandDescription
			{
				get
				{
					return "Sets the quality of the currently equipped item.";
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00038B8D File Offset: 0x00036D8D
			public override string ExampleUsage
			{
				get
				{
					return "setquality standard, setquality heavenly";
				}
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x00038B94 File Offset: 0x00036D94
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						this.ExampleUsage
					});
					return;
				}
				string text = args[0].ToLower();
				EQuality quality;
				if (!Enum.TryParse<EQuality>(text, true, out quality))
				{
					Console.LogCommandError("Unrecognized quality '" + text + "'");
				}
				if (PlayerSingleton<PlayerInventory>.Instance.isAnythingEquipped && PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance is QualityItemInstance)
				{
					(PlayerSingleton<PlayerInventory>.Instance.equippedSlot.ItemInstance as QualityItemInstance).SetQuality(quality);
					PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(false);
					PlayerSingleton<PlayerInventory>.Instance.SetEquippingEnabled(true);
					Console.Log("Set quality to " + quality.ToString(), null);
					return;
				}
				Console.LogCommandError("No quality item equipped");
			}
		}

		// Token: 0x02000255 RID: 597
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00038C69 File Offset: 0x00036E69
			public override string CommandWord
			{
				get
				{
					return "bind";
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00038C70 File Offset: 0x00036E70
			public override string CommandDescription
			{
				get
				{
					return "Binds the given key to the given command.";
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00038C77 File Offset: 0x00036E77
			public override string ExampleUsage
			{
				get
				{
					return "bind t 'settime 1200'";
				}
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00038C80 File Offset: 0x00036E80
			public override void Execute(List<string> args)
			{
				if (args.Count > 1)
				{
					string text = args[0].ToLower();
					KeyCode key;
					if (!Enum.TryParse<KeyCode>(text, true, out key))
					{
						Console.LogCommandError("Unrecognized keycode '" + text + "'");
					}
					string command = string.Join(" ", args.ToArray()).Substring(text.Length + 1);
					Singleton<Console>.Instance.AddBinding(key, command);
					return;
				}
				Console.LogUnrecognizedFormat(new string[]
				{
					this.ExampleUsage
				});
			}
		}

		// Token: 0x02000256 RID: 598
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00038D02 File Offset: 0x00036F02
			public override string CommandWord
			{
				get
				{
					return "unbind";
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00038D09 File Offset: 0x00036F09
			public override string CommandDescription
			{
				get
				{
					return "Removes the given bind.";
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00038D10 File Offset: 0x00036F10
			public override string ExampleUsage
			{
				get
				{
					return "unbind t";
				}
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x00038D18 File Offset: 0x00036F18
			public override void Execute(List<string> args)
			{
				if (args.Count > 0)
				{
					string text = args[0].ToLower();
					KeyCode key;
					if (!Enum.TryParse<KeyCode>(text, true, out key))
					{
						Console.LogCommandError("Unrecognized keycode '" + text + "'");
					}
					Singleton<Console>.Instance.RemoveBinding(key);
					return;
				}
				Console.LogUnrecognizedFormat(new string[]
				{
					this.ExampleUsage
				});
			}
		}

		// Token: 0x02000257 RID: 599
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00038D7B File Offset: 0x00036F7B
			public override string CommandWord
			{
				get
				{
					return "clearbinds";
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00038D82 File Offset: 0x00036F82
			public override string CommandDescription
			{
				get
				{
					return "Clears ALL binds.";
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00038D7B File Offset: 0x00036F7B
			public override string ExampleUsage
			{
				get
				{
					return "clearbinds";
				}
			}

			// Token: 0x06000C94 RID: 3220 RVA: 0x00038D89 File Offset: 0x00036F89
			public override void Execute(List<string> args)
			{
				Singleton<Console>.Instance.ClearBindings();
			}
		}

		// Token: 0x02000258 RID: 600
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00038D95 File Offset: 0x00036F95
			public override string CommandWord
			{
				get
				{
					return "hideui";
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00038D9C File Offset: 0x00036F9C
			public override string CommandDescription
			{
				get
				{
					return "Hides all on-screen UI.";
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00038D95 File Offset: 0x00036F95
			public override string ExampleUsage
			{
				get
				{
					return "hideui";
				}
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x00038DA3 File Offset: 0x00036FA3
			public override void Execute(List<string> args)
			{
				Singleton<HUD>.Instance.canvas.enabled = false;
			}
		}

		// Token: 0x02000259 RID: 601
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00038DB5 File Offset: 0x00036FB5
			public override string CommandWord
			{
				get
				{
					return "addxp";
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00038DBC File Offset: 0x00036FBC
			public override string CommandDescription
			{
				get
				{
					return "Adds the specified amount of experience points.";
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00038DC3 File Offset: 0x00036FC3
			public override string ExampleUsage
			{
				get
				{
					return "addxp 100";
				}
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00038DCC File Offset: 0x00036FCC
			public override void Execute(List<string> args)
			{
				int num = 0;
				if (args.Count == 0 || !int.TryParse(args[0], out num) || num < 0)
				{
					Console.LogWarning("Unrecognized command format. Correct format example(s): " + this.ExampleUsage, null);
					return;
				}
				Console.Log("Giving " + num.ToString() + " experience points", null);
				NetworkSingleton<LevelManager>.Instance.AddXP(num);
			}
		}

		// Token: 0x0200025A RID: 602
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00038E35 File Offset: 0x00037035
			public override string CommandWord
			{
				get
				{
					return "disable";
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00038E3C File Offset: 0x0003703C
			public override string CommandDescription
			{
				get
				{
					return "Disables the specified GameObject";
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00038E43 File Offset: 0x00037043
			public override string ExampleUsage
			{
				get
				{
					return "disable pp";
				}
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x00038E4C File Offset: 0x0003704C
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						this.ExampleUsage
					});
					return;
				}
				string code = args[0].ToLower();
				Console.LabelledGameObject labelledGameObject = Singleton<Console>.Instance.LabelledGameObjectList.Find((Console.LabelledGameObject x) => x.Label.ToLower() == code);
				if (labelledGameObject == null)
				{
					Console.LogCommandError("Could not find GameObject with label '" + code + "'");
					return;
				}
				labelledGameObject.GameObject.SetActive(false);
			}
		}

		// Token: 0x0200025C RID: 604
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00038EED File Offset: 0x000370ED
			public override string CommandWord
			{
				get
				{
					return "enable";
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00038EF4 File Offset: 0x000370F4
			public override string CommandDescription
			{
				get
				{
					return "Enables the specified GameObject";
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00038EFB File Offset: 0x000370FB
			public override string ExampleUsage
			{
				get
				{
					return "enable pp";
				}
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00038F04 File Offset: 0x00037104
			public override void Execute(List<string> args)
			{
				if (args.Count <= 0)
				{
					Console.LogUnrecognizedFormat(new string[]
					{
						this.ExampleUsage
					});
					return;
				}
				string code = args[0].ToLower();
				Console.LabelledGameObject labelledGameObject = Singleton<Console>.Instance.LabelledGameObjectList.Find((Console.LabelledGameObject x) => x.Label.ToLower() == code);
				if (labelledGameObject == null)
				{
					Console.LogCommandError("Could not find GameObject with label '" + code + "'");
					return;
				}
				labelledGameObject.GameObject.SetActive(true);
			}
		}

		// Token: 0x0200025E RID: 606
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00038FA5 File Offset: 0x000371A5
			public override string CommandWord
			{
				get
				{
					return "endtutorial";
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00038FAC File Offset: 0x000371AC
			public override string CommandDescription
			{
				get
				{
					return "Forces the tutorial to end immediately (only if the player is actually in the tutorial).";
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00038FA5 File Offset: 0x000371A5
			public override string ExampleUsage
			{
				get
				{
					return "endtutorial";
				}
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00038FB3 File Offset: 0x000371B3
			public override void Execute(List<string> args)
			{
				NetworkSingleton<GameManager>.Instance.EndTutorial(false);
			}
		}

		// Token: 0x0200025F RID: 607
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00038FC0 File Offset: 0x000371C0
			public override string CommandWord
			{
				get
				{
					return "disablenpcasset";
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00038FC7 File Offset: 0x000371C7
			public override string CommandDescription
			{
				get
				{
					return "Disabled the given asset under all NPCs";
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00038FCE File Offset: 0x000371CE
			public override string ExampleUsage
			{
				get
				{
					return "disablenpcasset avatar";
				}
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00038FD8 File Offset: 0x000371D8
			public override void Execute(List<string> args)
			{
				if (args.Count > 0)
				{
					string text = args[0];
					using (List<NPC>.Enumerator enumerator = NPCManager.NPCRegistry.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							NPC npc = enumerator.Current;
							for (int i = 0; i < npc.transform.childCount; i++)
							{
								Transform child = npc.transform.GetChild(i);
								if (text == "all" || child.name.ToLower() == text.ToLower())
								{
									child.gameObject.SetActive(false);
								}
							}
						}
						return;
					}
				}
				Console.LogUnrecognizedFormat(new string[]
				{
					this.ExampleUsage
				});
			}
		}

		// Token: 0x02000260 RID: 608
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000390A4 File Offset: 0x000372A4
			public override string CommandWord
			{
				get
				{
					return "showfps";
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000390AB File Offset: 0x000372AB
			public override string CommandDescription
			{
				get
				{
					return "Shows FPS label.";
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000CBA RID: 3258 RVA: 0x000390A4 File Offset: 0x000372A4
			public override string ExampleUsage
			{
				get
				{
					return "showfps";
				}
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x000390B2 File Offset: 0x000372B2
			public override void Execute(List<string> args)
			{
				Singleton<HUD>.Instance.fpsLabel.gameObject.SetActive(true);
			}
		}

		// Token: 0x02000261 RID: 609
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000CBD RID: 3261 RVA: 0x000390C9 File Offset: 0x000372C9
			public override string CommandWord
			{
				get
				{
					return "hidefps";
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000CBE RID: 3262 RVA: 0x000390D0 File Offset: 0x000372D0
			public override string CommandDescription
			{
				get
				{
					return "Hides FPS label.";
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000CBF RID: 3263 RVA: 0x000390C9 File Offset: 0x000372C9
			public override string ExampleUsage
			{
				get
				{
					return "hidefps";
				}
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x000390D7 File Offset: 0x000372D7
			public override void Execute(List<string> args)
			{
				Singleton<HUD>.Instance.fpsLabel.gameObject.SetActive(false);
			}
		}

		// Token: 0x02000262 RID: 610
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x000390EE File Offset: 0x000372EE
			public override string CommandWord
			{
				get
				{
					return "cleartrash";
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000390F5 File Offset: 0x000372F5
			public override string CommandDescription
			{
				get
				{
					return "Instantly removes all trash from the world.";
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x000390EE File Offset: 0x000372EE
			public override string ExampleUsage
			{
				get
				{
					return "cleartrash";
				}
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x000390FC File Offset: 0x000372FC
			public override void Execute(List<string> args)
			{
				NetworkSingleton<TrashManager>.Instance.DestroyAllTrash();
			}
		}

		// Token: 0x02000263 RID: 611
		[Serializable]
		public class LabelledGameObject
		{
			// Token: 0x04000D5A RID: 3418
			public string Label;

			// Token: 0x04000D5B RID: 3419
			public GameObject GameObject;
		}
	}
}
