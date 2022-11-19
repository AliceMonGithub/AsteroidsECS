using System;
using UnityEngine;

namespace Sources.Ecs
{
    public interface IAsteroids : IAsteroidsUnity
    {
        public float SpawnRate { get; }

        public float FlyingSpeed { get; }
    }

    [Serializable]
    public class AsteroidTrajectory
    {
        [SerializeField] private Transform _start;
        [SerializeField] private Transform _end;

        public Vector3 StartPosition => _start.position;
        public Vector3 EndPosition => _end.position;
    }
}
