using Leopotam.EcsLite;
using Sources.Types;
using UnityEngine;

namespace Sources.Ecs
{
    public class ShipMovement : IEcsRunSystem
    {
        private readonly EcsFilter _shipFilter;
        private readonly EcsPool<Transformable> _transformablePool;
        private readonly EcsPool<Ship> _shipPool;

        public ShipMovement(EcsWorld world)
        {
            _shipFilter = world.Filter<Transformable>().Inc<Ship>().End();
            
            _transformablePool = world.GetPool<Transformable>();
            _shipPool = world.GetPool<Ship>();
        }

        public void Run(IEcsSystems systems)
        {
            foreach (int entity in _shipFilter)
            {
                ref Transformable transformable = ref _transformablePool.Get(entity);
                ref Ship ship = ref _shipPool.Get(entity);

                Float2 nextPosition = transformable.Positon + AngleToVector(transformable.Rotation * -1) * Mathf.Clamp01(ship.MoveDirection.Y) * ship.ShipProperties.MovementSpeed * Time.deltaTime;

                transformable.Positon.X = Mathf.Repeat(nextPosition.X, 1);
                transformable.Positon.Y = Mathf.Repeat(nextPosition.Y, 1);

                float angle = ship.MoveDirection.X * ship.ShipProperties.RotationSpeed * Time.deltaTime;

                transformable.Rotation = Mathf.Repeat(transformable.Rotation - angle, 360);
            }
        }

        private Float2 AngleToVector(float angle)
        {
            return new Float2(Mathf.Sin(angle * Mathf.Deg2Rad), Mathf.Cos(angle * Mathf.Deg2Rad));
        }
    }
}