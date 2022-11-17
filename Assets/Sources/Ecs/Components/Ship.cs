using Sources.Types;
using UnityEngine;

namespace Sources.Ecs
{
    public struct Ship
    {
        public IShip ShipProperties;

        public Float2 MoveDirection;
    }
}
