using Leopotam.EcsLite;
using Sources.Factories;

namespace Sources.Ecs
{
    public class ShipInit : IEcsInitSystem
    {
        private readonly IShip _ship;

        private readonly ShipFactory _shipFactory;

        public ShipInit(IShip ship, ShipFactory shipFactory)
        {
            _ship = ship;

            _shipFactory = shipFactory;
        }

        public void Init(IEcsSystems systems)
        {
            EcsWorld world = systems.GetWorld();

            int shipEntity = world.NewEntity();

            EcsPool<Ship> shipPool = world.GetPool<Ship>();
            EcsPool<Transformable> transformablePool = world.GetPool<Transformable>();

            ref Ship ship = ref shipPool.Add(shipEntity);
            ref Transformable transformable = ref transformablePool.Add(shipEntity);

            ship.ShipProperties = _ship;

            transformable.Transform = _shipFactory.Create();

            transformable.Positon = ship.ShipProperties.StartPosition;
            transformable.Rotation = ship.ShipProperties.StartRotation;
        }
    }
}
