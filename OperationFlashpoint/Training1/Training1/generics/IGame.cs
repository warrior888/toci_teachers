namespace Training1.generics
{
    public interface IGame<TPlatform>
    {
        TPlatform GetPlatform();
    }
}