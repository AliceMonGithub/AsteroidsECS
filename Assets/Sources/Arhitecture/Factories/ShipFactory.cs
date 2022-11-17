using UnityEngine;

namespace Sources.Factories
{
    public class ShipFactory
    {
        private readonly Transform _prefab;

        public ShipFactory(Transform prefab)
        {
            _prefab = prefab;
        }

        public Transform Create()
        {
            return Object.Instantiate(_prefab);
        }
    }
}
