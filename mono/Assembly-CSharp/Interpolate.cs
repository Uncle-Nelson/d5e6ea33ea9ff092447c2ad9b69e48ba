using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000055 RID: 85
public class Interpolate
{
	// Token: 0x060001C1 RID: 449 RVA: 0x0000AED4 File Offset: 0x000090D4
	private static Vector3 Identity(Vector3 v)
	{
		return v;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0000AED7 File Offset: 0x000090D7
	private static Vector3 TransformDotPosition(Transform t)
	{
		return t.position;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000AEDF File Offset: 0x000090DF
	private static IEnumerable<float> NewTimer(float duration)
	{
		float elapsedTime = 0f;
		while (elapsedTime < duration)
		{
			yield return elapsedTime;
			elapsedTime += Time.deltaTime;
			if (elapsedTime >= duration)
			{
				yield return elapsedTime;
			}
		}
		yield break;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000AEEF File Offset: 0x000090EF
	private static IEnumerable<float> NewCounter(int start, int end, int step)
	{
		for (int i = start; i <= end; i += step)
		{
			yield return (float)i;
		}
		yield break;
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0000AF10 File Offset: 0x00009110
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float duration)
	{
		IEnumerable<float> driver = Interpolate.NewTimer(duration);
		return Interpolate.NewEase(ease, start, end, duration, driver);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000AF30 File Offset: 0x00009130
	public static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, int slices)
	{
		IEnumerable<float> driver = Interpolate.NewCounter(0, slices + 1, 1);
		return Interpolate.NewEase(ease, start, end, (float)(slices + 1), driver);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x0000AF55 File Offset: 0x00009155
	private static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
	{
		Vector3 distance = end - start;
		foreach (float elapsedTime in driver)
		{
			yield return Interpolate.Ease(ease, start, distance, elapsedTime, total);
		}
		IEnumerator<float> enumerator = null;
		yield break;
		yield break;
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x0000AF84 File Offset: 0x00009184
	private static Vector3 Ease(Interpolate.Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
	{
		start.x = ease(start.x, distance.x, elapsedTime, duration);
		start.y = ease(start.y, distance.y, elapsedTime, duration);
		start.z = ease(start.z, distance.z, elapsedTime, duration);
		return start;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0000AFE8 File Offset: 0x000091E8
	public static Interpolate.Function Ease(Interpolate.EaseType type)
	{
		Interpolate.Function result = null;
		switch (type)
		{
		case Interpolate.EaseType.Linear:
			result = new Interpolate.Function(Interpolate.Linear);
			break;
		case Interpolate.EaseType.EaseInQuad:
			result = new Interpolate.Function(Interpolate.EaseInQuad);
			break;
		case Interpolate.EaseType.EaseOutQuad:
			result = new Interpolate.Function(Interpolate.EaseOutQuad);
			break;
		case Interpolate.EaseType.EaseInOutQuad:
			result = new Interpolate.Function(Interpolate.EaseInOutQuad);
			break;
		case Interpolate.EaseType.EaseInCubic:
			result = new Interpolate.Function(Interpolate.EaseInCubic);
			break;
		case Interpolate.EaseType.EaseOutCubic:
			result = new Interpolate.Function(Interpolate.EaseOutCubic);
			break;
		case Interpolate.EaseType.EaseInOutCubic:
			result = new Interpolate.Function(Interpolate.EaseInOutCubic);
			break;
		case Interpolate.EaseType.EaseInQuart:
			result = new Interpolate.Function(Interpolate.EaseInQuart);
			break;
		case Interpolate.EaseType.EaseOutQuart:
			result = new Interpolate.Function(Interpolate.EaseOutQuart);
			break;
		case Interpolate.EaseType.EaseInOutQuart:
			result = new Interpolate.Function(Interpolate.EaseInOutQuart);
			break;
		case Interpolate.EaseType.EaseInQuint:
			result = new Interpolate.Function(Interpolate.EaseInQuint);
			break;
		case Interpolate.EaseType.EaseOutQuint:
			result = new Interpolate.Function(Interpolate.EaseOutQuint);
			break;
		case Interpolate.EaseType.EaseInOutQuint:
			result = new Interpolate.Function(Interpolate.EaseInOutQuint);
			break;
		case Interpolate.EaseType.EaseInSine:
			result = new Interpolate.Function(Interpolate.EaseInSine);
			break;
		case Interpolate.EaseType.EaseOutSine:
			result = new Interpolate.Function(Interpolate.EaseOutSine);
			break;
		case Interpolate.EaseType.EaseInOutSine:
			result = new Interpolate.Function(Interpolate.EaseInOutSine);
			break;
		case Interpolate.EaseType.EaseInExpo:
			result = new Interpolate.Function(Interpolate.EaseInExpo);
			break;
		case Interpolate.EaseType.EaseOutExpo:
			result = new Interpolate.Function(Interpolate.EaseOutExpo);
			break;
		case Interpolate.EaseType.EaseInOutExpo:
			result = new Interpolate.Function(Interpolate.EaseInOutExpo);
			break;
		case Interpolate.EaseType.EaseInCirc:
			result = new Interpolate.Function(Interpolate.EaseInCirc);
			break;
		case Interpolate.EaseType.EaseOutCirc:
			result = new Interpolate.Function(Interpolate.EaseOutCirc);
			break;
		case Interpolate.EaseType.EaseInOutCirc:
			result = new Interpolate.Function(Interpolate.EaseInOutCirc);
			break;
		}
		return result;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x0000B1CC File Offset: 0x000093CC
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, float duration)
	{
		IEnumerable<float> steps = Interpolate.NewTimer(duration);
		return Interpolate.NewBezier<Transform>(ease, nodes, new Interpolate.ToVector3<Transform>(Interpolate.TransformDotPosition), duration, steps);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0000B1F8 File Offset: 0x000093F8
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Transform[] nodes, int slices)
	{
		IEnumerable<float> steps = Interpolate.NewCounter(0, slices + 1, 1);
		return Interpolate.NewBezier<Transform>(ease, nodes, new Interpolate.ToVector3<Transform>(Interpolate.TransformDotPosition), (float)(slices + 1), steps);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000B228 File Offset: 0x00009428
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, float duration)
	{
		IEnumerable<float> steps = Interpolate.NewTimer(duration);
		return Interpolate.NewBezier<Vector3>(ease, points, new Interpolate.ToVector3<Vector3>(Interpolate.Identity), duration, steps);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000B254 File Offset: 0x00009454
	public static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Vector3[] points, int slices)
	{
		IEnumerable<float> steps = Interpolate.NewCounter(0, slices + 1, 1);
		return Interpolate.NewBezier<Vector3>(ease, points, new Interpolate.ToVector3<Vector3>(Interpolate.Identity), (float)(slices + 1), steps);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000B284 File Offset: 0x00009484
	private static IEnumerable<Vector3> NewBezier<T>(Interpolate.Function ease, IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
	{
		if (nodes.Count >= 2)
		{
			Vector3[] points = new Vector3[nodes.Count];
			foreach (float elapsedTime in steps)
			{
				for (int i = 0; i < nodes.Count; i++)
				{
					points[i] = toVector3((T)((object)nodes[i]));
				}
				yield return Interpolate.Bezier(ease, points, elapsedTime, maxStep);
			}
			IEnumerator<float> enumerator = null;
			points = null;
		}
		yield break;
		yield break;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000B2B4 File Offset: 0x000094B4
	private static Vector3 Bezier(Interpolate.Function ease, Vector3[] points, float elapsedTime, float duration)
	{
		for (int i = points.Length - 1; i > 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
				points[j].x = ease(points[j].x, points[j + 1].x - points[j].x, elapsedTime, duration);
				points[j].y = ease(points[j].y, points[j + 1].y - points[j].y, elapsedTime, duration);
				points[j].z = ease(points[j].z, points[j + 1].z - points[j].z, elapsedTime, duration);
			}
		}
		return points[0];
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000B3A1 File Offset: 0x000095A1
	public static IEnumerable<Vector3> NewCatmullRom(Transform[] nodes, int slices, bool loop)
	{
		return Interpolate.NewCatmullRom<Transform>(nodes, new Interpolate.ToVector3<Transform>(Interpolate.TransformDotPosition), slices, loop);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0000B3B7 File Offset: 0x000095B7
	public static IEnumerable<Vector3> NewCatmullRom(Vector3[] points, int slices, bool loop)
	{
		return Interpolate.NewCatmullRom<Vector3>(points, new Interpolate.ToVector3<Vector3>(Interpolate.Identity), slices, loop);
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0000B3CD File Offset: 0x000095CD
	private static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop)
	{
		if (nodes.Count >= 2)
		{
			yield return toVector3((T)((object)nodes[0]));
			int last = nodes.Count - 1;
			int current = 0;
			while (loop || current < last)
			{
				if (loop && current > last)
				{
					current = 0;
				}
				int previous = (current == 0) ? (loop ? last : current) : (current - 1);
				int start = current;
				int end = (current == last) ? (loop ? 0 : current) : (current + 1);
				int next = (end == last) ? (loop ? 0 : end) : (end + 1);
				int stepCount = slices + 1;
				int num;
				for (int step = 1; step <= stepCount; step = num + 1)
				{
					yield return Interpolate.CatmullRom(toVector3((T)((object)nodes[previous])), toVector3((T)((object)nodes[start])), toVector3((T)((object)nodes[end])), toVector3((T)((object)nodes[next])), (float)step, (float)stepCount);
					num = step;
				}
				num = current;
				current = num + 1;
			}
		}
		yield break;
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0000B3F4 File Offset: 0x000095F4
	private static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
	{
		float num = elapsedTime / duration;
		float num2 = num * num;
		float num3 = num2 * num;
		return previous * (-0.5f * num3 + num2 - 0.5f * num) + start * (1.5f * num3 + -2.5f * num2 + 1f) + end * (-1.5f * num3 + 2f * num2 + 0.5f * num) + next * (0.5f * num3 - 0.5f * num2);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0000B482 File Offset: 0x00009682
	private static float Linear(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * (elapsedTime / duration) + start;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0000B492 File Offset: 0x00009692
	private static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime + start;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0000B4AB File Offset: 0x000096AB
	private static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return -distance * elapsedTime * (elapsedTime - 2f) + start;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0000B4CC File Offset: 0x000096CC
	private static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 1f;
		return -distance / 2f * (elapsedTime * (elapsedTime - 2f) - 1f) + start;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0000B528 File Offset: 0x00009728
	private static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime + start;
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0000B543 File Offset: 0x00009743
	private static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * (elapsedTime * elapsedTime * elapsedTime + 1f) + start;
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0000B570 File Offset: 0x00009770
	private static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (elapsedTime * elapsedTime * elapsedTime + 2f) + start;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0000B5C9 File Offset: 0x000097C9
	private static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0000B5E6 File Offset: 0x000097E6
	private static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return -distance * (elapsedTime * elapsedTime * elapsedTime * elapsedTime - 1f) + start;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000B614 File Offset: 0x00009814
	private static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return -distance / 2f * (elapsedTime * elapsedTime * elapsedTime * elapsedTime - 2f) + start;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000B672 File Offset: 0x00009872
	private static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return distance * elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0000B691 File Offset: 0x00009891
	private static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * (elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + 1f) + start;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0000B6C0 File Offset: 0x000098C0
	private static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (elapsedTime * elapsedTime * elapsedTime * elapsedTime * elapsedTime + 2f) + start;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0000B721 File Offset: 0x00009921
	private static float EaseInSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return -distance * Mathf.Cos(elapsedTime / duration * 1.5707964f) + distance + start;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0000B73F File Offset: 0x0000993F
	private static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * Mathf.Sin(elapsedTime / duration * 1.5707964f) + start;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000B75A File Offset: 0x0000995A
	private static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return -distance / 2f * (Mathf.Cos(3.1415927f * elapsedTime / duration) - 1f) + start;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0000B782 File Offset: 0x00009982
	private static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * Mathf.Pow(2f, 10f * (elapsedTime / duration - 1f)) + start;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0000B7A8 File Offset: 0x000099A8
	private static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		if (elapsedTime > duration)
		{
			elapsedTime = duration;
		}
		return distance * (-Mathf.Pow(2f, -10f * elapsedTime / duration) + 1f) + start;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0000B7D0 File Offset: 0x000099D0
	private static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return distance / 2f * Mathf.Pow(2f, 10f * (elapsedTime - 1f)) + start;
		}
		elapsedTime -= 1f;
		return distance / 2f * (-Mathf.Pow(2f, -10f * elapsedTime) + 2f) + start;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0000B848 File Offset: 0x00009A48
	private static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		return -distance * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) - 1f) + start;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000B873 File Offset: 0x00009A73
	private static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 1f : (elapsedTime / duration));
		elapsedTime -= 1f;
		return distance * Mathf.Sqrt(1f - elapsedTime * elapsedTime) + start;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000B8A0 File Offset: 0x00009AA0
	private static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
	{
		elapsedTime = ((elapsedTime > duration) ? 2f : (elapsedTime / (duration / 2f)));
		if (elapsedTime < 1f)
		{
			return -distance / 2f * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) - 1f) + start;
		}
		elapsedTime -= 2f;
		return distance / 2f * (Mathf.Sqrt(1f - elapsedTime * elapsedTime) + 1f) + start;
	}

	// Token: 0x02000056 RID: 86
	public enum EaseType
	{
		// Token: 0x040001EF RID: 495
		Linear,
		// Token: 0x040001F0 RID: 496
		EaseInQuad,
		// Token: 0x040001F1 RID: 497
		EaseOutQuad,
		// Token: 0x040001F2 RID: 498
		EaseInOutQuad,
		// Token: 0x040001F3 RID: 499
		EaseInCubic,
		// Token: 0x040001F4 RID: 500
		EaseOutCubic,
		// Token: 0x040001F5 RID: 501
		EaseInOutCubic,
		// Token: 0x040001F6 RID: 502
		EaseInQuart,
		// Token: 0x040001F7 RID: 503
		EaseOutQuart,
		// Token: 0x040001F8 RID: 504
		EaseInOutQuart,
		// Token: 0x040001F9 RID: 505
		EaseInQuint,
		// Token: 0x040001FA RID: 506
		EaseOutQuint,
		// Token: 0x040001FB RID: 507
		EaseInOutQuint,
		// Token: 0x040001FC RID: 508
		EaseInSine,
		// Token: 0x040001FD RID: 509
		EaseOutSine,
		// Token: 0x040001FE RID: 510
		EaseInOutSine,
		// Token: 0x040001FF RID: 511
		EaseInExpo,
		// Token: 0x04000200 RID: 512
		EaseOutExpo,
		// Token: 0x04000201 RID: 513
		EaseInOutExpo,
		// Token: 0x04000202 RID: 514
		EaseInCirc,
		// Token: 0x04000203 RID: 515
		EaseOutCirc,
		// Token: 0x04000204 RID: 516
		EaseInOutCirc
	}

	// Token: 0x02000057 RID: 87
	// (Invoke) Token: 0x060001EC RID: 492
	public delegate Vector3 ToVector3<T>(T v);

	// Token: 0x02000058 RID: 88
	// (Invoke) Token: 0x060001F0 RID: 496
	public delegate float Function(float a, float b, float c, float d);
}
