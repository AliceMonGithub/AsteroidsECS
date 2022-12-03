using System;
using UnityEngine;

namespace Sources.Types
{
    [Serializable]
    public struct Float2
    {
        public static readonly Float2 Zero = new (0, 0);
        public static readonly Float2 Half = new (0.5f, 0.5f);
        public static readonly Float2 One = new (1, 1);

        public float X;
        public float Y;

        public Float2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public static Float2 Lerp(Float2 a, Float2 b, float time)
        {
            time = Mathf.Clamp01(time);

            return new Float2(a.X + (b.X - a.X) * time, a.Y + (b.Y - a.Y) * time);
        }

        public static Float2 operator +(Float2 first, Float2 second)
        {
            return new Float2(first.X + second.X, first.Y + second.Y);
        }

        public static Float2 operator -(Float2 first, Float2 second)
        {
            return new Float2(first.X - second.X, first.Y - second.Y);
        }

        public static Float2 operator *(Float2 first, float second)
        {
            return new Float2(first.X * second, first.Y * second);
        }

        public static Float2 operator /(Float2 first, float second)
        {
            return new Float2(first.X / second, first.Y / second);
        }
    }

    public static class Float2Extensions
    {
        public static Vector2 ToUnityVector2(this Float2 float2)
        {
            return new Vector2(float2.X, float2.Y);
        }
    }
}