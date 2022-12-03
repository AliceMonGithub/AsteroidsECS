using Leopotam.EcsLite;
using System.Collections.Generic;
using UnityEngine;

namespace Sources.Ecs
{
    public class AsteroidsSpawn : IEcsRunSystem
    {
        private readonly IReadOnlyCollection<AsteroidTrajectory> _trajectories;

        private readonly IAsteroids _asteroidsProperties;

        private float _delay;

        public AsteroidsSpawn(IAsteroids asteroids, IReadOnlyCollection<AsteroidTrajectory> trajectories) 
        {
            _trajectories = trajectories;

            _asteroidsProperties = asteroids;
        }

        public void Run(IEcsSystems systems)
        {
            _delay += Time.deltaTime;

            if (_asteroidsProperties.SpawnRate <= _delay)
            {
                Debug.Log("Asteroid");

                _delay = 0;
            }
        }
    }
}