using Sources.Ecs;
using System.Collections.Generic;
using UnityEngine;

namespace Sources.ScriptableObjects
{
    [CreateAssetMenu]
    public class AsteroidsProperties : ScriptableObject, IAsteroids
    {
        [SerializeField] private float _spawnRate;
        [SerializeField] private float _flyingSpeed;

        [Space]

        [SerializeField] private Transform[] _prefabs;

        public float SpawnRate => _spawnRate;

        public float FlyingSpeed => _flyingSpeed;

        public IReadOnlyCollection<Transform> Prefabs => _prefabs;
    }
}