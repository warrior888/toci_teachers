namespace Toci.Training.Tournament
{
    public abstract class ShuffleBase<TToRandomize>
    {
        public abstract TToRandomize Shuffle(TToRandomize toRandomize);
    }
}