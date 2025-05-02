using System;
using System.Collections.Generic;
using System.Linq;
using FishNet;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Object;
using FishNet.Object.Delegating;
using FishNet.Serializing;
using FishNet.Serializing.Generated;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.Variables;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScheduleOne.Employees
{
	// Token: 0x0200064B RID: 1611
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x06002B70 RID: 11120 RVA: 0x000B2BD4 File Offset: 0x000B0DD4
		public void CreateNewEmployee(Property property, EEmployeeType type)
		{
			bool male = 0.67f > Random.Range(0f, 1f);
			NetworkSingleton<VariableDatabase>.Instance.SetVariableValue("LifetimeEmployeesRecruited", (NetworkSingleton<VariableDatabase>.Instance.GetValue<float>("LifetimeEmployeesRecruited") + 1f).ToString(), true);
			string text;
			string text2;
			this.GenerateRandomName(male, out text, out text2);
			string id = text.ToLower() + "_" + text2.ToLower();
			int appearanceIndex;
			AvatarSettings avatarSettings;
			this.GetRandomAppearance(male, out appearanceIndex, out avatarSettings);
			string guid = GUIDManager.GenerateUniqueGUID().ToString();
			this.CreateEmployee(property, type, text, text2, id, male, appearanceIndex, property.NPCSpawnPoint.position, property.NPCSpawnPoint.rotation, guid);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000B2C90 File Offset: 0x000B0E90
		[ServerRpc(RequireOwnership = false)]
		public void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			this.RpcWriter___Server_CreateEmployee_311954683(property, type, firstName, lastName, id, male, appearanceIndex, position, rotation, guid);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000B2CCC File Offset: 0x000B0ECC
		public Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			if (property.Employees.Count >= property.EmployeeCapacity)
			{
				Console.LogError("Property " + property.PropertyCode + " is at capacity.", null);
				return null;
			}
			Employee employeePrefab = this.GetEmployeePrefab(type);
			if (employeePrefab == null)
			{
				Console.LogError("Failed to find employee prefab for " + type.ToString(), null);
				return null;
			}
			guid = ((guid == "") ? Guid.NewGuid().ToString() : guid);
			if (!this.IsPositionValid(position))
			{
				position = property.NPCSpawnPoint.position;
			}
			if (!this.IsRotationValid(rotation))
			{
				rotation = property.NPCSpawnPoint.rotation;
			}
			Employee component = Object.Instantiate<Employee>(employeePrefab, position, rotation).GetComponent<Employee>();
			component.Initialize(null, firstName, lastName, id, guid, property.PropertyCode, male, appearanceIndex);
			base.NetworkObject.Spawn(component.gameObject, null, default(Scene));
			component.Movement.Warp(position);
			component.Movement.transform.rotation = rotation;
			Quest quest = this.EmployeeQuests.FirstOrDefault((Quest_Employees x) => x.EmployeeType == type);
			if (quest != null && quest.QuestState == EQuestState.Inactive)
			{
				quest.Begin(true);
			}
			return component;
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x000B2E39 File Offset: 0x000B1039
		private bool IsPositionValid(Vector3 position)
		{
			return this.IsFloatValid(position.x) && this.IsFloatValid(position.y) && this.IsFloatValid(position.z);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000B2E65 File Offset: 0x000B1065
		private bool IsRotationValid(Quaternion rotation)
		{
			return this.IsFloatValid(rotation.x) && this.IsFloatValid(rotation.y) && this.IsFloatValid(rotation.z) && this.IsFloatValid(rotation.w);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000B2E9F File Offset: 0x000B109F
		private bool IsFloatValid(float value)
		{
			return !float.IsNaN(value) && !float.IsInfinity(value);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000B2EB4 File Offset: 0x000B10B4
		public void RegisterName(string name)
		{
			this.takenNames.Add(name);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000B2EC2 File Offset: 0x000B10C2
		public void RegisterAppearance(bool male, int index)
		{
			if (male)
			{
				this.takenMaleAppearances.Add(index);
				return;
			}
			this.takenFemaleAppearances.Add(index);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000B2EE0 File Offset: 0x000B10E0
		public void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			do
			{
				if (male)
				{
					firstName = this.MaleFirstNames[Random.Range(0, this.MaleFirstNames.Length)].ToString();
				}
				else
				{
					firstName = this.FemaleFirstNames[Random.Range(0, this.FemaleFirstNames.Length)].ToString();
				}
				lastName = this.LastNames[Random.Range(0, this.LastNames.Length)].ToString();
			}
			while (this.takenNames.Contains(firstName + " " + lastName));
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000B2F61 File Offset: 0x000B1161
		public EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			if (!male)
			{
				return this.FemaleAppearances[index];
			}
			return this.MaleAppearances[index];
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000B2F7F File Offset: 0x000B117F
		public VODatabase GetVoice(bool male, int index)
		{
			if (!male)
			{
				return this.FemaleVoices[index % this.FemaleVoices.Length];
			}
			return this.MaleVoices[index % this.MaleVoices.Length];
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000B2FA8 File Offset: 0x000B11A8
		public void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			List<EmployeeManager.EmployeeAppearance> list = male ? this.MaleAppearances : this.FemaleAppearances;
			List<int> list2 = male ? this.takenMaleAppearances : this.takenFemaleAppearances;
			index = Random.Range(0, list.Count);
			settings = list[index].Settings;
			if (list2.Count >= list.Count)
			{
				return;
			}
			int num = 0;
			while (list2.Contains(index))
			{
				index++;
				if (index >= list.Count)
				{
					index = 0;
				}
				num++;
				if (num >= list.Count)
				{
					settings = list[index].Settings;
					return;
				}
			}
			settings = list[index].Settings;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000B3054 File Offset: 0x000B1254
		public Employee GetEmployeePrefab(EEmployeeType type)
		{
			switch (type)
			{
			case EEmployeeType.Botanist:
				return this.BotanistPrefab;
			case EEmployeeType.Handler:
				return this.PackagerPrefab;
			case EEmployeeType.Chemist:
				return this.ChemistPrefab;
			case EEmployeeType.Cleaner:
				return this.CleanerPrefab;
			default:
				Console.LogError("Employee type not found: " + type.ToString(), null);
				return null;
			}
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000B30B4 File Offset: 0x000B12B4
		public List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			List<Employee> list = new List<Employee>();
			foreach (Employee employee in this.AllEmployees)
			{
				if (employee.EmployeeType == type)
				{
					list.Add(employee);
				}
			}
			return list;
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000B314C File Offset: 0x000B134C
		public override void NetworkInitialize___Early()
		{
			if (this.NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize___Early();
			base.RegisterServerRpc(0U, new ServerRpcDelegate(this.RpcReader___Server_CreateEmployee_311954683));
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000B317C File Offset: 0x000B137C
		public override void NetworkInitialize__Late()
		{
			if (this.NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted)
			{
				return;
			}
			this.NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted = true;
			base.NetworkInitialize__Late();
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000B3195 File Offset: 0x000B1395
		public override void NetworkInitializeIfDisabled()
		{
			this.NetworkInitialize___Early();
			this.NetworkInitialize__Late();
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000B31A4 File Offset: 0x000B13A4
		private void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			if (!base.IsClientInitialized)
			{
				NetworkManager networkManager = base.NetworkManager;
				if (networkManager == null)
				{
					networkManager = InstanceFinder.NetworkManager;
				}
				if (networkManager != null)
				{
					networkManager.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				else
				{
					Debug.LogWarning("Cannot complete action because client is not active. This may also occur if the object is not yet initialized, has deinitialized, or if it does not contain a NetworkObject component.");
				}
				return;
			}
			Channel channel = Channel.Reliable;
			PooledWriter writer = WriterPool.GetWriter();
			writer.Write___ScheduleOne.Property.PropertyFishNet.Serializing.Generated(property);
			writer.Write___ScheduleOne.Employees.EEmployeeTypeFishNet.Serializing.Generated(type);
			writer.WriteString(firstName);
			writer.WriteString(lastName);
			writer.WriteString(id);
			writer.WriteBoolean(male);
			writer.WriteInt32(appearanceIndex, AutoPackType.Packed);
			writer.WriteVector3(position);
			writer.WriteQuaternion(rotation, AutoPackType.Packed);
			writer.WriteString(guid);
			base.SendServerRpc(0U, writer, channel, DataOrderType.Default);
			writer.Store();
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000B32CC File Offset: 0x000B14CC
		public void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			this.CreateEmployee_Server(property, type, firstName, lastName, id, male, appearanceIndex, position, rotation, guid);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000B32F4 File Offset: 0x000B14F4
		private void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			Property property = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Property.PropertyFishNet.Serializing.Generateds(PooledReader0);
			EEmployeeType type = FishNet.Serializing.Generated.GeneratedReaders___Internal.Read___ScheduleOne.Employees.EEmployeeTypeFishNet.Serializing.Generateds(PooledReader0);
			string firstName = PooledReader0.ReadString();
			string lastName = PooledReader0.ReadString();
			string id = PooledReader0.ReadString();
			bool male = PooledReader0.ReadBoolean();
			int appearanceIndex = PooledReader0.ReadInt32(AutoPackType.Packed);
			Vector3 position = PooledReader0.ReadVector3();
			Quaternion rotation = PooledReader0.ReadQuaternion(AutoPackType.Packed);
			string guid = PooledReader0.ReadString();
			if (!base.IsServerInitialized)
			{
				return;
			}
			this.RpcLogic___CreateEmployee_311954683(property, type, firstName, lastName, id, male, appearanceIndex, position, rotation, guid);
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x000B33C8 File Offset: 0x000B15C8
		public override void Awake()
		{
			this.NetworkInitialize___Early();
			base.Awake();
			this.NetworkInitialize__Late();
		}

		// Token: 0x04001F53 RID: 8019
		public const float MALE_EMPLOYEE_CHANCE = 0.67f;

		// Token: 0x04001F54 RID: 8020
		public List<Employee> AllEmployees = new List<Employee>();

		// Token: 0x04001F55 RID: 8021
		public Quest_Employees[] EmployeeQuests;

		// Token: 0x04001F56 RID: 8022
		[Header("Prefabs")]
		public Botanist BotanistPrefab;

		// Token: 0x04001F57 RID: 8023
		public Packager PackagerPrefab;

		// Token: 0x04001F58 RID: 8024
		public Chemist ChemistPrefab;

		// Token: 0x04001F59 RID: 8025
		public Cleaner CleanerPrefab;

		// Token: 0x04001F5A RID: 8026
		[Header("Appearances")]
		public List<EmployeeManager.EmployeeAppearance> MaleAppearances;

		// Token: 0x04001F5B RID: 8027
		public List<EmployeeManager.EmployeeAppearance> FemaleAppearances;

		// Token: 0x04001F5C RID: 8028
		[Header("Voices")]
		public VODatabase[] MaleVoices;

		// Token: 0x04001F5D RID: 8029
		public VODatabase[] FemaleVoices;

		// Token: 0x04001F5E RID: 8030
		[Header("Names")]
		public string[] MaleFirstNames;

		// Token: 0x04001F5F RID: 8031
		public string[] FemaleFirstNames;

		// Token: 0x04001F60 RID: 8032
		public string[] LastNames;

		// Token: 0x04001F61 RID: 8033
		private List<string> takenNames = new List<string>();

		// Token: 0x04001F62 RID: 8034
		private List<int> takenMaleAppearances = new List<int>();

		// Token: 0x04001F63 RID: 8035
		private List<int> takenFemaleAppearances = new List<int>();

		// Token: 0x04001F64 RID: 8036
		private bool dll_Excuted;

		// Token: 0x04001F65 RID: 8037
		private bool dll_Excuted;

		// Token: 0x0200064C RID: 1612
		[Serializable]
		public class EmployeeAppearance
		{
			// Token: 0x04001F66 RID: 8038
			public AvatarSettings Settings;

			// Token: 0x04001F67 RID: 8039
			public Sprite Mugshot;
		}
	}
}
