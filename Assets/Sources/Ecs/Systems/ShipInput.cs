using Leopotam.EcsLite;
using Sources.Services;

namespace Sources.Ecs
{
    public class ShipInput : IEcsRunSystem
    {
        private readonly EcsFilter _shipFilter;
        private readonly EcsPool<Ship> _shipPool;

        private readonly MovementInput _input;

        public ShipInput(EcsWorld world, MovementInput input)
        {
            _shipFilter = world.Filter<Ship>().End();
            _shipPool = world.GetPool<Ship>();

            _input = input;
        }

        public void Run(IEcsSystems systems)
        {
            foreach (int entity in _shipFilter)
            {
                ref Ship ship = ref _shipPool.Get(entity);

                ship.MoveDirection = _input.Axis;
            }
        }
    }
}