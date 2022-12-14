using UnityEngine;
using Leopotam.EcsLite;
using Sources.ScriptableObjects;
using Sources.Factories;
using Sources.Services;

namespace Sources.Ecs
{
    public sealed class GameBootstrapper : MonoBehaviour
    {
        [SerializeField] private AsteroidTrajectory[] _trajectories;

        [Space]

        [SerializeField] private ShipProperties _shipProperties;
        [SerializeField] private AsteroidsProperties _asteroidsProperties;

        [Space]

        [SerializeField] private Camera _camera;
        
        private EcsWorld _world;

        private EcsSystems _initSystems;
        private EcsSystems _updateSystems;

        private MovementInput _input = new KeyboardInput();

        private void Awake()
        {
            _world = new EcsWorld();

            _initSystems = new EcsSystems(_world);
            _updateSystems = new EcsSystems(_world);

            _initSystems
                .Add(new ShipInit(_shipProperties, new ShipFactory(_shipProperties.Transform)))
                .Init();

            _initSystems.Destroy();
            _initSystems = null;

            _updateSystems
                .Add(new ShipInput(_world, _input))
                .Add(new ShipMovement(_world))
                .Add(new ShipTransform(_world, _camera))
                .Add(new AsteroidsSpawn(_asteroidsProperties, _trajectories))
                .Init();
        }

        private void Update()
        {
            _updateSystems.Run();
        }

        private void OnDestroy()
        {
            _updateSystems.Destroy();
            _updateSystems = null;

            _world.Destroy();
            _world = null;
        }
    }
}