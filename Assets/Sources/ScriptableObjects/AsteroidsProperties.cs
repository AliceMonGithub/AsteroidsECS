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

        public float SpawnRate => throw new System.NotImplementedException();

        public float FlyingSpeed => throw new System.NotImplementedException();

        public IReadOnlyCollection<Transform> Prefabs => throw new System.NotImplementedException();
    }
}