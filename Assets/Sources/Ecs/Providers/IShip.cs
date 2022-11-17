using Sources.Types;

namespace Sources.Ecs
{
    public interface IShip : IShipUnity
    {
        public Float2 StartPosition { get; }
        public float StartRotation { get; }

        public float MovementSpeed { get; }
        public float RotationSpeed { get; }

        public float MovementSmooth { get; }
        public float RotationSmooth { get; }
    }
}