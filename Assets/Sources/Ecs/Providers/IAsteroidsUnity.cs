using System.Collections.Generic;
using UnityEngine;

namespace Sources.Ecs
{
    public interface IAsteroidsUnity
    {
        public IReadOnlyCollection<Transform> Prefabs { get; }
    }
}
