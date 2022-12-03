using Sources.Ecs;
using Sources.Types;
using System.Collections.Generic;
using UnityEngine;

namespace Sources.ScriptableObjects
{
    [CreateAssetMenu]
    public class AsteroidsProperties : ScriptableObject, IAsteroids
    {
        [SerializeField] private float _spawnRate;
        [SerializeField] private Float2 _flyingSpeed;

        [Space]

        [SerializeField] private Transform[] _prefabs;

        public float SpawnRate => _spawnRate;

        public Float2 FlyingSpeed => _flyingSpeed;

        public IReadOnlyCollection<Transform> Prefabs => _prefabs;
    }
}