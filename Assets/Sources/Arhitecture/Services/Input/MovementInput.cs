using Sources.Types;

namespace Sources.Services
{
    public abstract class MovementInput : IInputService
    {
        protected string HorizontalAxis = "Horizontal";
        protected string VerticalAxis = "Vertical";

        public abstract Float2 Axis { get; }
    }
}
