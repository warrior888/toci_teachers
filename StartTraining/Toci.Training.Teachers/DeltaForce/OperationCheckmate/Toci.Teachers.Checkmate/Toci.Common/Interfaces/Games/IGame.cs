namespace Toci.Common.Interfaces.Games
{
    public interface IGame<TGameType> : IGameBase where TGameType : IGameType
    {
        bool Start();

        bool Stop();

        bool Remove();
    }
}