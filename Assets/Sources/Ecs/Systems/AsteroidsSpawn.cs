using Leopotam.EcsLite;
using System.Collections.Generic;

namespace Sources.Ecs
{
    public class AsteroidsSpawn : IEcsRunSystem
    {
        private readonly IReadOnlyCollection<AsteroidTrajectory> _trajectories;

        private readonly IAsteroids _asteroidsProperties;

        public AsteroidsSpawn(IAsteroids asteroids, IReadOnlyCollection<AsteroidTrajectory> trajectories) 
        {
            _trajectories = trajectories;

            _asteroidsProperties = asteroids;
        }

        public void Run(IEcsSystems systems)
        {
        }
    }
}