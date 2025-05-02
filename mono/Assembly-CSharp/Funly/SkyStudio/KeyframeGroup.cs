using System;
using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class KeyframeGroup<T> : IKeyframeGroup where T : IBaseKeyframe
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00026D91 File Offset: 0x00024F91
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00026D99 File Offset: 0x00024F99
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00026DA2 File Offset: 0x00024FA2
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00026DAA File Offset: 0x00024FAA
		public string id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00026DB4 File Offset: 0x00024FB4
		public KeyframeGroup(string name)
		{
			this.name = name;
			this.id = Guid.NewGuid().ToString();
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00026DF2 File Offset: 0x00024FF2
		public void AddKeyFrame(T keyFrame)
		{
			this.keyframes.Add(keyFrame);
			this.SortKeyframes();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00026E06 File Offset: 0x00025006
		public void RemoveKeyFrame(T keyFrame)
		{
			if (this.keyframes.Count == 1)
			{
				Debug.LogError("You must have at least 1 keyframe in every group.");
				return;
			}
			this.keyframes.Remove(keyFrame);
			this.SortKeyframes();
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00026E34 File Offset: 0x00025034
		public void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
			this.RemoveKeyFrame((T)((object)keyframe));
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00026E42 File Offset: 0x00025042
		public int GetKeyFrameCount()
		{
			return this.keyframes.Count;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00026E4F File Offset: 0x0002504F
		public T GetKeyframe(int index)
		{
			return this.keyframes[index];
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00026E5D File Offset: 0x0002505D
		public void SortKeyframes()
		{
			this.keyframes.Sort();
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00026E6A File Offset: 0x0002506A
		public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
		{
			if (curve == InterpolationCurve.Linear)
			{
				return t;
			}
			if (curve == InterpolationCurve.EaseInEaseOut)
			{
				return Mathf.Clamp01((t < 0.5f) ? (2f * t * t) : (-1f + (4f - 2f * t) * t));
			}
			return t;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00026EA4 File Offset: 0x000250A4
		public T GetPreviousKeyFrame(float time)
		{
			T result;
			T t;
			if (!this.GetSurroundingKeyFrames(time, out result, out t))
			{
				return default(T);
			}
			return result;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00026ECC File Offset: 0x000250CC
		public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			beforeKeyframe = default(T);
			afterKeyframe = default(T);
			int index;
			int index2;
			if (this.GetSurroundingKeyFrames(time, out index, out index2))
			{
				beforeKeyframe = this.GetKeyframe(index);
				afterKeyframe = this.GetKeyframe(index2);
				return true;
			}
			return false;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00026F14 File Offset: 0x00025114
		public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			beforeIndex = 0;
			afterIndex = 0;
			if (this.keyframes.Count == 0)
			{
				Debug.LogError("Can't return nearby keyframes since it's empty.");
				return false;
			}
			if (this.keyframes.Count == 1)
			{
				return true;
			}
			T t = this.keyframes[0];
			if (time < t.time)
			{
				beforeIndex = this.keyframes.Count - 1;
				afterIndex = 0;
				return true;
			}
			int num = 0;
			for (int i = 0; i < this.keyframes.Count; i++)
			{
				t = this.keyframes[i];
				if (t.time >= time)
				{
					break;
				}
				num = i;
			}
			int num2 = (num + 1) % this.keyframes.Count;
			beforeIndex = num;
			afterIndex = num2;
			return true;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00026FCF File Offset: 0x000251CF
		public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
		{
			return KeyframeGroup<T>.ProgressBetweenSurroundingKeyframes(time, beforeKey.time, afterKey.time);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00026FE4 File Offset: 0x000251E4
		public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			if (afterKeyTime > beforeKeyTime && time <= beforeKeyTime)
			{
				return 0f;
			}
			float num = KeyframeGroup<T>.WidthBetweenCircularValues(beforeKeyTime, afterKeyTime);
			return Mathf.Clamp01(KeyframeGroup<T>.WidthBetweenCircularValues(beforeKeyTime, time) / num);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00027015 File Offset: 0x00025215
		public static float WidthBetweenCircularValues(float begin, float end)
		{
			if (begin <= end)
			{
				return end - begin;
			}
			return 1f - begin + end;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00027028 File Offset: 0x00025228
		public void TrimToSingleKeyframe()
		{
			if (this.keyframes.Count == 1)
			{
				return;
			}
			this.keyframes.RemoveRange(1, this.keyframes.Count - 1);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00027054 File Offset: 0x00025254
		public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			float num;
			float num2;
			this.CalculateCircularDistances(previousKeyValue, nextKeyValue, minValue, maxValue, out num, out num2);
			if (num2 > num)
			{
				return InterpolationDirection.Reverse;
			}
			return InterpolationDirection.Foward;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00027077 File Offset: 0x00025277
		public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
			if (nextKeyValue < previousKeyValue)
			{
				forwardDistance = maxValue - previousKeyValue + (nextKeyValue - minValue);
			}
			else
			{
				forwardDistance = nextKeyValue - previousKeyValue;
			}
			reverseDistance = minValue + maxValue - forwardDistance;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002709C File Offset: 0x0002529C
		public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			float t = KeyframeGroup<T>.ProgressBetweenSurroundingKeyframes(time, beforeTime, nextTime);
			float num = this.CurveAdjustedBlendingTime(curve, t);
			if (direction == InterpolationDirection.Auto)
			{
				return this.AutoInterpolation(num, previousKeyValue, nextKeyValue);
			}
			InterpolationDirection interpolationDirection = direction;
			float num2;
			float num3;
			this.CalculateCircularDistances(previousKeyValue, nextKeyValue, minValue, maxValue, out num2, out num3);
			if (interpolationDirection == InterpolationDirection.ShortestPath)
			{
				if (num3 > num2)
				{
					interpolationDirection = InterpolationDirection.Foward;
				}
				else
				{
					interpolationDirection = InterpolationDirection.Reverse;
				}
			}
			if (interpolationDirection == InterpolationDirection.Foward)
			{
				return this.ForwardInterpolation(num, previousKeyValue, nextKeyValue, minValue, maxValue, num2);
			}
			if (interpolationDirection == InterpolationDirection.Reverse)
			{
				return this.ReverseInterpolation(num, previousKeyValue, nextKeyValue, minValue, maxValue, num3);
			}
			Debug.LogError("Unhandled interpolation direction: " + interpolationDirection.ToString() + ", returning min value.");
			return minValue;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002713D File Offset: 0x0002533D
		public float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			return Mathf.Lerp(previousValue, nextValue, curvedTime);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00027148 File Offset: 0x00025348
		public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			if (previousKeyValue <= nextKeyValue)
			{
				return Mathf.Lerp(previousKeyValue, nextKeyValue, time);
			}
			float num = time * distance;
			float num2 = maxValue - previousKeyValue;
			if (num <= num2)
			{
				return previousKeyValue + num;
			}
			return minValue + (num - num2);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0002717C File Offset: 0x0002537C
		public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			if (nextKeyValue <= previousKeyValue)
			{
				return Mathf.Lerp(previousKeyValue, nextKeyValue, time);
			}
			float num = time * distance;
			float num2 = previousKeyValue - minValue;
			if (num <= num2)
			{
				return previousKeyValue - num;
			}
			return maxValue - (num - num2);
		}

		// Token: 0x0400095D RID: 2397
		public List<T> keyframes = new List<T>();

		// Token: 0x0400095E RID: 2398
		[SerializeField]
		private string m_Name;

		// Token: 0x0400095F RID: 2399
		[SerializeField]
		private string m_Id;
	}
}
