namespace Training1
{
    public abstract class Sex  // ??????
    {
        protected bool IsAnAction; //  ????? 
        // internal private protected public
    }

    public class Male : Sex
    {
        public int Penis { get; set; }
    }

    public abstract class Blowjob
    {
        private Sex SexInAction { get; set; }

        public abstract bool IsInAction();
    }

    public class UnrecognizedBlowjob : Blowjob
    {
        public override bool IsInAction()
        {
            return false;
        }
    }

    public class ForcedBlowjob : UnrecognizedBlowjob
    {
        private bool IsJudoAndKarateFigther;

        public override bool IsInAction()
        {
            if (IsJudoAndKarateFigther)
            {
                return false;
            }

            return base.IsInAction();
        }
    }

    public class UnexpectedBlowjob : Blowjob
    {
        public override bool IsInAction()
        {
            return true;
        }
    }

    public class Violence
    {
        public void TheyWerePunishedForMadonaBlowJobForcing()
        {
            Blowjob bj = new UnexpectedBlowjob();
            bj.IsInAction();
        }
    }
}