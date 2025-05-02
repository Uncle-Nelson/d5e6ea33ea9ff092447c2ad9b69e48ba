using System;
using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x020006E9 RID: 1769
	public static class NavMeshUtility
	{
		// Token: 0x06003025 RID: 12325 RVA: 0x000C83E8 File Offset: 0x000C65E8
		public static float GetPathLength(NavMeshPath path)
		{
			if (path == null)
			{
				return 0f;
			}
			float num = 0f;
			for (int i = 1; i < path.corners.Length; i++)
			{
				num += Vector3.Distance(path.corners[i - 1], path.corners[i]);
			}
			return num;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000C843C File Offset: 0x000C663C
		public static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			if (entity == null)
			{
				return null;
			}
			float num = float.MaxValue;
			Transform result = null;
			BuildableItem buildableItem = entity as BuildableItem;
			for (int i = 0; i < entity.AccessPoints.Length; i++)
			{
				NavMeshPath navMeshPath;
				if ((!(buildableItem != null) || buildableItem.ParentProperty.DoBoundsContainPoint(entity.AccessPoints[i].position)) && npc.Movement.CanGetTo(entity.AccessPoints[i].position, 1f, out navMeshPath))
				{
					float num2 = (navMeshPath != null) ? NavMeshUtility.GetPathLength(navMeshPath) : Vector3.Distance(npc.transform.position, entity.AccessPoints[i].position);
					if (num2 < num)
					{
						num = num2;
						result = entity.AccessPoints[i];
					}
				}
			}
			return result;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x000C84F8 File Offset: 0x000C66F8
		public static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			if (entity == null)
			{
				Console.LogWarning("IsAtTransitEntity: Entity is null!", null);
			}
			for (int i = 0; i < entity.AccessPoints.Length; i++)
			{
				if (Vector3.Distance(npc.transform.position, entity.AccessPoints[i].position) < distanceThreshold)
				{
					return true;
				}
				if (npc.Movement.IsAsCloseAsPossible(entity.AccessPoints[i].transform.position, distanceThreshold))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x000C856C File Offset: 0x000C676C
		public static int GetNavMeshAgentID(string name)
		{
			for (int i = 0; i < NavMesh.GetSettingsCount(); i++)
			{
				NavMeshBuildSettings settingsByIndex = NavMesh.GetSettingsByIndex(i);
				if (name == NavMesh.GetSettingsNameFromID(settingsByIndex.agentTypeID))
				{
					return settingsByIndex.agentTypeID;
				}
			}
			return -1;
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000C85B0 File Offset: 0x000C67B0
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			if (useCache)
			{
				for (int i = 0; i < NavMeshUtility.sampleCacheKeys.Count; i++)
				{
					if (Vector3.SqrMagnitude(sourcePosition - NavMeshUtility.sampleCacheKeys[i]) < 1f)
					{
						hit = default(NavMeshHit);
						hit.position = NavMeshUtility.SampleCache[NavMeshUtility.sampleCacheKeys[i]];
						return true;
					}
				}
			}
			bool flag = NavMesh.SamplePosition(sourcePosition, ref hit, maxDistance, areaMask);
			if (flag)
			{
				if ((float)NavMeshUtility.sampleCacheKeys.Count >= 10000f)
				{
					Console.LogWarning("Sample cache is full! Clearing cache...", null);
					NavMeshUtility.ClearCache();
				}
				Vector3 vector = NavMeshUtility.Quantize(sourcePosition, 0.1f);
				NavMeshUtility.sampleCacheKeys.Add(vector);
				NavMeshUtility.SampleCache.Add(vector, hit.position);
			}
			return flag;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000C866D File Offset: 0x000C686D
		private static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			return new Vector3(Mathf.Round(position.x / precision) * precision, Mathf.Round(position.y / precision) * precision, Mathf.Round(position.z / precision) * precision);
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x000C86A1 File Offset: 0x000C68A1
		public static void ClearCache()
		{
			NavMeshUtility.SampleCache.Clear();
			NavMeshUtility.sampleCacheKeys.Clear();
		}

		// Token: 0x04002231 RID: 8753
		public const float SAMPLE_MAX_DISTANCE = 2f;

		// Token: 0x04002232 RID: 8754
		public static Dictionary<Vector3, Vector3> SampleCache = new Dictionary<Vector3, Vector3>();

		// Token: 0x04002233 RID: 8755
		public static List<Vector3> sampleCacheKeys = new List<Vector3>();

		// Token: 0x04002234 RID: 8756
		public const float SAMPLE_CACHE_MAX_SQR_DIST = 1f;

		// Token: 0x04002235 RID: 8757
		public const float MAX_CACHE_SIZE = 10000f;
	}
}
