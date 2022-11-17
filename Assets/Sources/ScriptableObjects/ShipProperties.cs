using Sources.Ecs;
using Sources.Types;
using UnityEngine;

namespace Sources.ScriptableObjects
{
    [CreateAssetMenu]
    public class ShipProperties : ScriptableObject, IShip
    {
        [SerializeField] private Float2 _startPosition;
        [SerializeField] private float _startRotation;

        [Space]

        [SerializeField] private float _movementSpeed;
        [SerializeField] private float _rotationSpeed;

        [Space]

        [SerializeField] private float _movementSmooth;
        [SerializeField] private float _rotationSmooth;

        [Space]

        [SerializeField] private Transform _transform;

        public Float2 StartPosition => _startPosition;
        public float StartRotation => _startRotation;

        public float MovementSpeed => _movementSpeed;
        public float RotationSpeed => _rotationSpeed;

        public float MovementSmooth => _movementSmooth;
        public float RotationSmooth => _rotationSmooth;

        public Transform Transform => _transform;

        private void OnValidate()
        {
            _startPosition = new Float2(Mathf.Clamp01(_startPosition.X), Mathf.Clamp01(_startPosition.Y));
            _startRotation = Mathf.Clamp(_startRotation, 0, 360);

            _movementSpeed = Mathf.Clamp(_movementSpeed, 0, float.MaxValue);
            _rotationSpeed = Mathf.Clamp(_rotationSpeed, 0, float.MaxValue);

            _movementSmooth = Mathf.Clamp(_movementSmooth, 0, float.MaxValue);
            _rotationSmooth = Mathf.Clamp(_rotationSmooth, 0, float.MaxValue);
        }
    }
}