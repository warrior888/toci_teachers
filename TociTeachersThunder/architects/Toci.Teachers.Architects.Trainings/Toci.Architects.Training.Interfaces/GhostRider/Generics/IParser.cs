namespace Toci.Architects.Training.Interfaces.GhostRider.Generics
{
                            // excel, plik txt
    public interface IParser<TParseInput, TParseResult>
    {
        TParseResult Parse(TParseInput input);
    }
}