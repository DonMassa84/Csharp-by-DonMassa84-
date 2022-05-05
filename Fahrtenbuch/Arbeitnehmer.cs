using System;

namespace clArbeitnehmer
{
    class Arbeitnehmer
    {
        protected string zuName;
        protected string vorName;
        protected string polKz;
        protected decimal kmStandBeg;
        protected decimal kmStandEnd;
        protected string aufzBeg;
        protected string aufzEnd;

        public string ZuName { get => zuName; set => zuName = value; }
        public string VorName { get => vorName; set => vorName = value; }
        public string PolKz { get => polKz; set => polKz = value; }
        public decimal KmStandBeg { get => kmStandBeg; set => kmStandBeg = value; }
        public decimal KmStandEnd { get => kmStandEnd; set => kmStandEnd = value; }
        public string AufzBeg { get => aufzBeg; set => aufzBeg = value; }
        public string AufzEnd { get => aufzEnd; set => aufzEnd = value; }
    }
}