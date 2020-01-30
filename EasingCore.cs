// EasingCore (https://github.com/setchi/EasingCore)
// Copyright (c) 2019 setchi
// Licensed under MIT (https://github.com/setchi/EasingCore/blob/master/LICENSE)

using UnityEngine;
using Unity.Mathematics;

namespace EasingCore
{
    public static class Ease
    {

		public static float Linear ( float t ) => t;

		public static float InBack ( float t ) => t*t*t - t * math.sin(t*math.PI);

		public static float OutBack ( float t ) => 1f - InBack(1f-t);

		public static float InOutBack ( float t ) =>
			t < 0.5f
			? 0.5f * InBack(2f*t)
			: 0.5f * OutBack(2f*t - 1f) + 0.5f;

		public static float InBounce ( float t ) => 1f - OutBounce(1f-t);

		public static float OutBounce ( float t ) =>
			t < 4f / 11.0f ?
				(121f * t * t) / 16.0f :
			t < 8f / 11.0f ?
				(363f / 40f * t * t) - (99f / 10f * t) + 17f / 5.0f :
			t < 9f / 10f ?
				(4356f / 361.0f * t * t) - (35442f / 1805.0f * t) + 16061f / 1805.0f :
				(54f / 5.0f * t * t) - (513f / 25.0f * t) + 268f / 25.0f;

		public static float InOutBounce ( float t ) =>
			t < 0.5f
			? 0.5f * InBounce(2f*t)
			: 0.5f * OutBounce(2f*t - 1f) + 0.5f;

		public static float InCirc ( float t ) => 1f - math.sqrt(1f - (t*t));

		public static float OutCirc ( float t ) => math.sqrt((2f - t) * t);

		public static float InOutCirc ( float t ) =>
			t < 0.5f
			? 0.5f * (1 - math.sqrt(1f - 4f * (t * t)))
			: 0.5f * (math.sqrt(-((2f * t) - 3f) * ((2f * t) - 1f)) + 1f);

		public static float InCubic ( float t ) => t*t*t;

		public static float OutCubic ( float t ) => InCubic(t - 1f) + 1f;

		public static float InOutCubic ( float t ) =>
			t < 0.5f
			? 4f * t*t*t
			: 0.5f * InCubic(2f * t - 2f) + 1f;

		public static float InElastic ( float t ) => math.sin(13f * (math.PI * 0.5f) * t) * math.pow(2f, 10f * (t - 1f));

		public static float OutElastic ( float t ) => math.sin(-13f * (math.PI * 0.5f) * (t + 1)) * math.pow(2f, -10f * t) + 1f;

		public static float InOutElastic ( float t ) =>
			t < 0.5f
			? 0.5f * math.sin(13f * (math.PI * 0.5f) * (2f * t)) * math.pow(2f, 10f * ((2f * t) - 1f))
			: 0.5f * (math.sin(-13f * (math.PI * 0.5f) * ((2f * t - 1f) + 1f)) * math.pow(2f, -10f * (2f * t - 1f)) + 2f);

		public static float InExpo ( float t ) => Mathf.Approximately(0f,t) ? t : math.pow(2f, 10f * (t - 1f));

		public static float OutExpo ( float t ) => Mathf.Approximately(1.0f, t) ? t : 1f - math.pow(2f, -10f * t);

		public static float InOutExpo ( float v ) =>
			Mathf.Approximately(0f, v) || Mathf.Approximately(1.0f, v)
				? v
				: v < 0.5f
					?  0.5f * math.pow(2f, (20f * v) - 10f)
					: -0.5f * math.pow(2f, (-20f * v) + 10f) + 1f;

		public static float InQuad ( float t ) => t*t;

		public static float OutQuad ( float t ) => -t * (t - 2f);

		public static float InOutQuad ( float t ) =>
			t < 0.5f
			?  2f * t*t
			: -2f * t*t + 4f * t - 1f;

		public static float InQuart ( float t ) => t*t*t*t;

		public static float OutQuart ( float t )
		{
			float u = t - 1f;
			return u*u*u * (1f - t) + 1f;
		}

		public static float InOutQuart ( float t ) =>
			t < 0.5f
			? 8f * InQuart(t)
			: -8f * InQuart(t - 1f) + 1f;

		public static float InQuint ( float t ) => t*t*t*t*t;

		public static float OutQuint ( float t ) => InQuint(t - 1f) + 1f;

		public static float InOutQuint ( float t ) =>
			t < 0.5f
			? 16f * InQuint(t)
			: 0.5f * InQuint(2f * t - 2f) + 1f;

		public static float InSine ( float t ) => math.sin((t - 1f) * (math.PI * 0.5f)) + 1f;

		public static float OutSine ( float t ) => math.sin(t * (math.PI * 0.5f));

		public static float InOutSine ( float t ) => 0.5f * (1f - math.cos(t * math.PI));

    }
}
