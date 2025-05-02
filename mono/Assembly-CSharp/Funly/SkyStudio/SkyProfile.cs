using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001C7 RID: 455
	[CreateAssetMenu(fileName = "skyProfile.asset", menuName = "Sky Studio/Sky Profile", order = 0)]
	public class SkyProfile : ScriptableObject
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00029A12 File Offset: 0x00027C12
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00029A1C File Offset: 0x00027C1C
		public Material skyboxMaterial
		{
			get
			{
				return this.m_SkyboxMaterial;
			}
			set
			{
				if (value == null)
				{
					this.m_SkyboxMaterial = null;
					return;
				}
				if (this.m_SkyboxMaterial && this.m_SkyboxMaterial.shader.name != value.shader.name)
				{
					this.m_SkyboxMaterial = value;
					this.m_ShaderName = value.shader.name;
					this.ReloadDefinitions();
					return;
				}
				this.m_SkyboxMaterial = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00029A8F File Offset: 0x00027C8F
		public string shaderName
		{
			get
			{
				return this.m_ShaderName;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00029A97 File Offset: 0x00027C97
		public ProfileGroupSection[] groupDefinitions
		{
			get
			{
				if (this.profileDefinition == null)
				{
					return null;
				}
				return this.profileDefinition.groups;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00029AAE File Offset: 0x00027CAE
		public ProfileFeatureSection[] featureDefinitions
		{
			get
			{
				if (this.profileDefinition == null)
				{
					return null;
				}
				return this.profileDefinition.features;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00029AC5 File Offset: 0x00027CC5
		public float GetNumberPropertyValue(string propertyKey)
		{
			return this.GetNumberPropertyValue(propertyKey, 0f);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00029AD4 File Offset: 0x00027CD4
		public float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			NumberKeyframeGroup group = this.GetGroup<NumberKeyframeGroup>(propertyKey);
			if (group == null)
			{
				Debug.LogError("Can't find number group with property key: " + propertyKey);
				return -1f;
			}
			return group.NumericValueAtTime(timeOfDay);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00029B09 File Offset: 0x00027D09
		public Color GetColorPropertyValue(string propertyKey)
		{
			return this.GetColorPropertyValue(propertyKey, 0f);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00029B18 File Offset: 0x00027D18
		public Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			ColorKeyframeGroup group = this.GetGroup<ColorKeyframeGroup>(propertyKey);
			if (group == null)
			{
				Debug.LogError("Can't find color group with property key: " + propertyKey);
				return Color.white;
			}
			return group.ColorForTime(timeOfDay);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00029B4D File Offset: 0x00027D4D
		public Texture GetTexturePropertyValue(string propertyKey)
		{
			return this.GetTexturePropertyValue(propertyKey, 0f);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00029B5C File Offset: 0x00027D5C
		public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			TextureKeyframeGroup group = this.GetGroup<TextureKeyframeGroup>(propertyKey);
			if (group == null)
			{
				Debug.LogError("Can't find texture group with property key: " + propertyKey);
				return null;
			}
			return group.TextureForTime(timeOfDay);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00029B8D File Offset: 0x00027D8D
		public SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			return this.GetSpherePointPropertyValue(propertyKey, 0f);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00029B9C File Offset: 0x00027D9C
		public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
		{
			SpherePointKeyframeGroup group = this.GetGroup<SpherePointKeyframeGroup>(propertyKey);
			if (group == null)
			{
				Debug.LogError("Can't find a sphere point group with property key: " + propertyKey);
				return null;
			}
			return group.SpherePointForTime(timeOfDay);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00029BCD File Offset: 0x00027DCD
		public bool GetBoolPropertyValue(string propertyKey)
		{
			return this.GetBoolPropertyValue(propertyKey, 0f);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00029BDC File Offset: 0x00027DDC
		public bool GetBoolPropertyValue(string propertyKey, float timeOfDay)
		{
			BoolKeyframeGroup group = this.GetGroup<BoolKeyframeGroup>(propertyKey);
			if (group == null)
			{
				Debug.LogError("Can't find boolean group with property key: " + propertyKey);
				return false;
			}
			return group.BoolForTime(timeOfDay);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00029C10 File Offset: 0x00027E10
		public SkyProfile()
		{
			this.ReloadFullProfile();
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00029C5C File Offset: 0x00027E5C
		private void OnEnable()
		{
			this.ReloadFullProfile();
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00029C64 File Offset: 0x00027E64
		private void ReloadFullProfile()
		{
			this.ReloadDefinitions();
			this.MergeProfileWithDefinitions();
			this.RebuildKeyToGroupInfoMapping();
			this.ValidateTimelineGroupKeys();
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00029C7E File Offset: 0x00027E7E
		private void ReloadDefinitions()
		{
			this.profileDefinition = this.GetShaderInfoForMaterial(this.m_ShaderName);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00029C92 File Offset: 0x00027E92
		private IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			return new Standard3dShaderDefinition();
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00029C99 File Offset: 0x00027E99
		public void MergeProfileWithDefinitions()
		{
			this.MergeGroupsWithDefinitions();
			this.MergeShaderKeywordsWithDefinitions();
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00029CA8 File Offset: 0x00027EA8
		public void MergeGroupsWithDefinitions()
		{
			HashSet<string> propertyKeysSet = ProfilePropertyKeys.GetPropertyKeysSet();
			ProfileGroupSection[] groupDefinitions = this.groupDefinitions;
			for (int i = 0; i < groupDefinitions.Length; i++)
			{
				foreach (ProfileGroupDefinition profileGroupDefinition in groupDefinitions[i].groups)
				{
					if (propertyKeysSet.Contains(profileGroupDefinition.propertyKey))
					{
						if (profileGroupDefinition.type == ProfileGroupDefinition.GroupType.Color)
						{
							if (!this.keyframeGroups.ContainsKey(profileGroupDefinition.propertyKey))
							{
								this.AddColorGroup(profileGroupDefinition.propertyKey, profileGroupDefinition.groupName, profileGroupDefinition.color);
							}
							else
							{
								this.keyframeGroups[profileGroupDefinition.propertyKey].name = profileGroupDefinition.groupName;
							}
						}
						else if (profileGroupDefinition.type == ProfileGroupDefinition.GroupType.Number)
						{
							if (!this.keyframeGroups.ContainsKey(profileGroupDefinition.propertyKey))
							{
								this.AddNumericGroup(profileGroupDefinition.propertyKey, profileGroupDefinition.groupName, profileGroupDefinition.minimumValue, profileGroupDefinition.maximumValue, profileGroupDefinition.value);
							}
							else
							{
								NumberKeyframeGroup group = this.keyframeGroups.GetGroup<NumberKeyframeGroup>(profileGroupDefinition.propertyKey);
								group.name = profileGroupDefinition.groupName;
								group.minValue = profileGroupDefinition.minimumValue;
								group.maxValue = profileGroupDefinition.maximumValue;
							}
						}
						else if (profileGroupDefinition.type == ProfileGroupDefinition.GroupType.Texture)
						{
							if (!this.keyframeGroups.ContainsKey(profileGroupDefinition.propertyKey))
							{
								this.AddTextureGroup(profileGroupDefinition.propertyKey, profileGroupDefinition.groupName, profileGroupDefinition.texture);
							}
							else
							{
								this.keyframeGroups[profileGroupDefinition.propertyKey].name = profileGroupDefinition.groupName;
							}
						}
						else if (profileGroupDefinition.type == ProfileGroupDefinition.GroupType.SpherePoint)
						{
							if (!this.keyframeGroups.ContainsKey(profileGroupDefinition.propertyKey))
							{
								this.AddSpherePointGroup(profileGroupDefinition.propertyKey, profileGroupDefinition.groupName, profileGroupDefinition.spherePoint);
							}
							else
							{
								this.keyframeGroups[profileGroupDefinition.propertyKey].name = profileGroupDefinition.groupName;
							}
						}
						else if (profileGroupDefinition.type == ProfileGroupDefinition.GroupType.Boolean)
						{
							if (!this.keyframeGroups.ContainsKey(profileGroupDefinition.propertyKey))
							{
								this.AddBooleanGroup(profileGroupDefinition.propertyKey, profileGroupDefinition.groupName, profileGroupDefinition.boolValue);
							}
							else
							{
								this.keyframeGroups[profileGroupDefinition.propertyKey].name = profileGroupDefinition.groupName;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00029F10 File Offset: 0x00028110
		public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			ProfileGroupSection[] array = this.ProfileDefinitionTable();
			Dictionary<string, ProfileGroupDefinition> dictionary = new Dictionary<string, ProfileGroupDefinition>();
			ProfileGroupSection[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				foreach (ProfileGroupDefinition profileGroupDefinition in array2[i].groups)
				{
					dictionary.Add(profileGroupDefinition.propertyKey, profileGroupDefinition);
				}
			}
			return dictionary;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00029F69 File Offset: 0x00028169
		public ProfileGroupSection[] ProfileDefinitionTable()
		{
			return this.groupDefinitions;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00029F74 File Offset: 0x00028174
		private void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
			NumberKeyframeGroup value2 = new NumberKeyframeGroup(groupName, min, max, new NumberKeyframe(0f, value));
			this.keyframeGroups[propKey] = value2;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00029FA4 File Offset: 0x000281A4
		private void AddColorGroup(string propKey, string groupName, Color color)
		{
			ColorKeyframeGroup value = new ColorKeyframeGroup(groupName, new ColorKeyframe(color, 0f));
			this.keyframeGroups[propKey] = value;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00029FD0 File Offset: 0x000281D0
		private void AddTextureGroup(string propKey, string groupName, Texture2D texture)
		{
			TextureKeyframeGroup value = new TextureKeyframeGroup(groupName, new TextureKeyframe(texture, 0f));
			this.keyframeGroups[propKey] = value;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00029FFC File Offset: 0x000281FC
		private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point)
		{
			SpherePointKeyframeGroup value = new SpherePointKeyframeGroup(groupName, new SpherePointKeyframe(point, 0f));
			this.keyframeGroups[propKey] = value;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002A028 File Offset: 0x00028228
		private void AddBooleanGroup(string propKey, string groupName, bool value)
		{
			BoolKeyframeGroup value2 = new BoolKeyframeGroup(groupName, new BoolKeyframe(0f, value));
			this.keyframeGroups[propKey] = value2;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0002A054 File Offset: 0x00028254
		public T GetGroup<T>(string propertyKey) where T : class
		{
			if (!this.keyframeGroups.ContainsKey(propertyKey))
			{
				Debug.Log("Key does not exist in sky profile, ignoring: " + propertyKey);
				return default(T);
			}
			return this.keyframeGroups[propertyKey] as T;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002A09F File Offset: 0x0002829F
		public IKeyframeGroup GetGroup(string propertyKey)
		{
			return this.keyframeGroups[propertyKey];
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0002A0B0 File Offset: 0x000282B0
		public IKeyframeGroup GetGroupWithId(string groupId)
		{
			if (groupId == null)
			{
				return null;
			}
			foreach (string aKey in this.keyframeGroups)
			{
				IKeyframeGroup keyframeGroup = this.keyframeGroups[aKey];
				if (keyframeGroup.id == groupId)
				{
					return keyframeGroup;
				}
			}
			return null;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00029F69 File Offset: 0x00028169
		public ProfileGroupSection[] GetProfileDefinitions()
		{
			return this.groupDefinitions;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0002A120 File Offset: 0x00028320
		public ProfileGroupSection GetSectionInfo(string sectionKey)
		{
			foreach (ProfileGroupSection profileGroupSection in this.groupDefinitions)
			{
				if (profileGroupSection.sectionKey == sectionKey)
				{
					return profileGroupSection;
				}
			}
			return null;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0002A157 File Offset: 0x00028357
		public bool IsManagedByTimeline(string propertyKey)
		{
			return this.timelineManagedKeys.Contains(propertyKey);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0002A168 File Offset: 0x00028368
		public void ValidateTimelineGroupKeys()
		{
			List<string> list = new List<string>();
			HashSet<string> propertyKeysSet = ProfilePropertyKeys.GetPropertyKeysSet();
			foreach (string text in this.timelineManagedKeys)
			{
				if (!this.IsManagedByTimeline(text) || !propertyKeysSet.Contains(text))
				{
					list.Add(text);
				}
			}
			foreach (string item in list)
			{
				if (this.timelineManagedKeys.Contains(item))
				{
					this.timelineManagedKeys.Remove(item);
				}
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0002A230 File Offset: 0x00028430
		public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			List<ProfileGroupDefinition> list = new List<ProfileGroupDefinition>();
			foreach (string propertyKey in this.timelineManagedKeys)
			{
				ProfileGroupDefinition groupDefinitionForKey = this.GetGroupDefinitionForKey(propertyKey);
				if (groupDefinitionForKey != null)
				{
					list.Add(groupDefinitionForKey);
				}
			}
			return list;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002A298 File Offset: 0x00028498
		public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			List<ProfileGroupDefinition> list = new List<ProfileGroupDefinition>();
			ProfileGroupSection[] groupDefinitions = this.groupDefinitions;
			for (int i = 0; i < groupDefinitions.Length; i++)
			{
				foreach (ProfileGroupDefinition profileGroupDefinition in groupDefinitions[i].groups)
				{
					if (!this.IsManagedByTimeline(profileGroupDefinition.propertyKey) && this.CanGroupBeOnTimeline(profileGroupDefinition))
					{
						list.Add(profileGroupDefinition);
					}
				}
			}
			return list;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0002A304 File Offset: 0x00028504
		public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			ProfileGroupDefinition result = null;
			if (this.m_KeyToGroupInfo.TryGetValue(propertyKey, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0002A328 File Offset: 0x00028528
		public void RebuildKeyToGroupInfoMapping()
		{
			this.m_KeyToGroupInfo = new Dictionary<string, ProfileGroupDefinition>();
			ProfileGroupSection[] groupDefinitions = this.groupDefinitions;
			for (int i = 0; i < groupDefinitions.Length; i++)
			{
				foreach (ProfileGroupDefinition profileGroupDefinition in groupDefinitions[i].groups)
				{
					this.m_KeyToGroupInfo[profileGroupDefinition.propertyKey] = profileGroupDefinition;
				}
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002A388 File Offset: 0x00028588
		public void TrimGroupToSingleKeyframe(string propertyKey)
		{
			IKeyframeGroup group = this.GetGroup(propertyKey);
			if (group == null)
			{
				return;
			}
			group.TrimToSingleKeyframe();
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002A3A8 File Offset: 0x000285A8
		public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition)
		{
			return definition.type != ProfileGroupDefinition.GroupType.Texture && (!definition.propertyKey.Contains("Star") || !definition.propertyKey.Contains("Density")) && !definition.propertyKey.Contains("Sprite") && definition.type != ProfileGroupDefinition.GroupType.Boolean;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0002A400 File Offset: 0x00028600
		protected void MergeShaderKeywordsWithDefinitions()
		{
			ProfileFeatureSection[] features = this.profileDefinition.features;
			for (int i = 0; i < features.Length; i++)
			{
				foreach (ProfileFeatureDefinition profileFeatureDefinition in features[i].featureDefinitions)
				{
					string text = null;
					bool value = false;
					if (profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.BooleanValue || profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.ShaderKeyword)
					{
						text = profileFeatureDefinition.featureKey;
						value = profileFeatureDefinition.value;
					}
					else if (profileFeatureDefinition.featureType == ProfileFeatureDefinition.FeatureType.ShaderKeywordDropdown)
					{
						text = profileFeatureDefinition.featureKeys[profileFeatureDefinition.dropdownSelectedIndex];
						value = true;
					}
					if (text != null && !this.featureStatus.dict.ContainsKey(text))
					{
						this.SetFeatureEnabled(text, value);
					}
				}
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0002A4B8 File Offset: 0x000286B8
		public bool IsFeatureEnabled(string featureKey, bool recursive = true)
		{
			if (featureKey == null)
			{
				return false;
			}
			ProfileFeatureDefinition featureDefinition = this.profileDefinition.GetFeatureDefinition(featureKey);
			if (featureDefinition == null)
			{
				return false;
			}
			if (!this.featureStatus.dict.ContainsKey(featureKey) || !this.featureStatus[featureKey])
			{
				return false;
			}
			if (!recursive)
			{
				return true;
			}
			ProfileFeatureDefinition featureDefinition2;
			for (ProfileFeatureDefinition profileFeatureDefinition = featureDefinition; profileFeatureDefinition != null; profileFeatureDefinition = featureDefinition2)
			{
				featureDefinition2 = this.profileDefinition.GetFeatureDefinition(profileFeatureDefinition.dependsOnFeature);
				if (featureDefinition2 == null || featureDefinition2.featureKey == null)
				{
					break;
				}
				if (this.featureStatus[featureDefinition2.featureKey] != profileFeatureDefinition.dependsOnValue)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002A546 File Offset: 0x00028746
		public void SetFeatureEnabled(string featureKey, bool value)
		{
			if (featureKey == null)
			{
				Debug.LogError("Can't set null feature key value");
				return;
			}
			this.featureStatus[featureKey] = value;
		}

		// Token: 0x04000AAA RID: 2730
		public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		// Token: 0x04000AAB RID: 2731
		public const string DefaultLegacyShaderName = "Funly/Sky Studio/Skybox/3D Standard - Global Keywords";

		// Token: 0x04000AAC RID: 2732
		[SerializeField]
		private Material m_SkyboxMaterial;

		// Token: 0x04000AAD RID: 2733
		[SerializeField]
		private string m_ShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		// Token: 0x04000AAE RID: 2734
		public IProfileDefinition profileDefinition;

		// Token: 0x04000AAF RID: 2735
		public List<string> timelineManagedKeys = new List<string>();

		// Token: 0x04000AB0 RID: 2736
		public KeyframeGroupDictionary keyframeGroups = new KeyframeGroupDictionary();

		// Token: 0x04000AB1 RID: 2737
		public BoolDictionary featureStatus = new BoolDictionary();

		// Token: 0x04000AB2 RID: 2738
		public LightningArtSet lightningArtSet;

		// Token: 0x04000AB3 RID: 2739
		public RainSplashArtSet rainSplashArtSet;

		// Token: 0x04000AB4 RID: 2740
		public Texture2D starLayer1DataTexture;

		// Token: 0x04000AB5 RID: 2741
		public Texture2D starLayer2DataTexture;

		// Token: 0x04000AB6 RID: 2742
		public Texture2D starLayer3DataTexture;

		// Token: 0x04000AB7 RID: 2743
		[SerializeField]
		private int m_ProfileVersion = 2;

		// Token: 0x04000AB8 RID: 2744
		private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo;
	}
}
