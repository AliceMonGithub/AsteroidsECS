using Sources.Types;
using UnityEngine;

namespace Sources.Services
{
    public class KeyboardInput : MovementInput
    {
        public override Float2 Axis => GetAxis();

        private Float2 GetAxis()
        {
            return new Float2(Input.GetAxisRaw(HorizontalAxis), Input.GetAxisRaw(VerticalAxis));
        }
    }
}
