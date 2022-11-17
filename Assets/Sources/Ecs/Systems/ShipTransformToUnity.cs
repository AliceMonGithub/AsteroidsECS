using UnityEngine;
using Leopotam.EcsLite;
using Sources.Types;

namespace Sources.Ecs
{
    public class ShipTransformToUnity : IEcsRunSystem
    {
        private readonly EcsFilter _shipFilter;
        private readonly EcsPool<Transformable> _transformablePool;

        private readonly Camera _camera;

        public ShipTransformToUnity(EcsWorld world, Camera camera)
        {
            _shipFilter = world.Filter<Transformable>().Inc<Ship>().End();

            _transformablePool = world.GetPool<Transformable>();

            _camera = camera;
        }

        public void Run(IEcsSystems systems)
        {
            foreach (int entity in _shipFilter)
            {
                ref Transformable transformable = ref _transformablePool.Get(entity);

                transformable.Transform.position = GetWorldPosition(transformable.Positon.ToUnityVector2());
                transformable.Transform.eulerAngles = Vector3.forward * transformable.Rotation;
            }
        }

        private Vector3 GetWorldPosition(Vector3 position)
        {
            return _camera.ViewportToWorldPoint(position) * Vector2.one;
        }
    }
}
