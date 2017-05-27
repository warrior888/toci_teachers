using System.Collections.Generic;

namespace Toci.Architects.Training.GhostRider.BasicGenerics
{
    public class PostCodeParser<TPostCode>
    {
        public TPostCode PostCode { get; }

        public virtual void ParsePostCode(TPostCode posrtCodesSource)
        {
            
        }
    }

    public class Results
    {
        public void Example()
        {
            PostCodeParser<TextFilePostCode> textfile = new PostCodeParser<TextFilePostCode>();
            PostCodeParser<ExcelPostCode> excel = new PostCodeParser<ExcelPostCode>();
            //excel.PostCode.Sheets;
            //textfile.PostCode.Delimiter;
        }
    }

    public class ExcelPostCode : PostCodeBase
    {
        public List<string> Sheets { get; set; }
    }

    public class TextFilePostCode : PostCodeBase
    {
        public string Delimiter { get; set; }
    }

    public abstract class PostCodeBase
    {
        public string FileName { get; set; }
    }

    
}