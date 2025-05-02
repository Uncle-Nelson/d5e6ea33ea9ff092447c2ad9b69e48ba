using System;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	// Token: 0x02000A54 RID: 2644
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x06004736 RID: 18230 RVA: 0x0012A3A4 File Offset: 0x001285A4
		private void Start()
		{
			this.nextSpawnTime = Time.time + Random.Range(this.MinInterval, this.MaxInterval);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0012A3C4 File Offset: 0x001285C4
		private void Update()
		{
			if (this.SpawnRateMultiplier == 0f)
			{
				return;
			}
			if (Time.time > this.nextSpawnTime)
			{
				this.nextSpawnTime = Time.time + Random.Range(this.MinInterval, this.MaxInterval) / this.SpawnRateMultiplier;
				if (this.Prefabs.Length != 0)
				{
					GameObject gameObject = Object.Instantiate<GameObject>(this.Prefabs[Random.Range(0, this.Prefabs.Length)], base.transform);
					if (this.UniformScale)
					{
						float num = Random.Range(this.MinScale.x, this.MaxScale.x);
						gameObject.transform.localScale = new Vector3(num, num, 1f);
					}
					else
					{
						gameObject.transform.localScale = new Vector3(Random.Range(this.MinScale.x, this.MaxScale.x), Random.Range(this.MinScale.y, this.MaxScale.y), 1f);
					}
					gameObject.transform.localPosition = new Vector3(Random.Range(-this.SpawnArea.rect.width / 2f, this.SpawnArea.rect.width / 2f), Random.Range(-this.SpawnArea.rect.height / 2f, this.SpawnArea.rect.height / 2f), 0f);
					if (this.OnSpawn != null)
					{
						this.OnSpawn.Invoke(gameObject);
					}
				}
			}
		}

		// Token: 0x0400349E RID: 13470
		public RectTransform SpawnArea;

		// Token: 0x0400349F RID: 13471
		public GameObject[] Prefabs;

		// Token: 0x040034A0 RID: 13472
		public float MinInterval = 1f;

		// Token: 0x040034A1 RID: 13473
		public float MaxInterval = 5f;

		// Token: 0x040034A2 RID: 13474
		public float SpawnRateMultiplier = 1f;

		// Token: 0x040034A3 RID: 13475
		public Vector2 MinScale = Vector2.one;

		// Token: 0x040034A4 RID: 13476
		public Vector2 MaxScale = Vector2.one;

		// Token: 0x040034A5 RID: 13477
		public bool UniformScale = true;

		// Token: 0x040034A6 RID: 13478
		private float nextSpawnTime;

		// Token: 0x040034A7 RID: 13479
		public UnityEvent<GameObject> OnSpawn;
	}
}
