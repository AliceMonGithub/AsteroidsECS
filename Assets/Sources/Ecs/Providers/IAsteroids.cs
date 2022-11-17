namespace Sources.Ecs
{
    public interface IAsteroids : IAsteroidsUnity
    {
        public float SpawnRate { get; }

        public float FlyingSpeed { get; }
    }
}
