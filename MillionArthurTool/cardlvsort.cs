namespace MillionArthurTool
{
    using System;

    public class cardlvsort : IComparable<cardlvsort>
    {
        public int iAtack;
        public int icardid;
        public int iHp;
        public int ilv;
        public int ilvmax;
        public string iserialid = "";

        public int CompareTo(cardlvsort other)
        {
            if (other == null)
            {
                return 1;
            }
            int num = other.ilv - this.ilv;
            if (num == 0)
            {
                num = this.icardid - other.icardid;
            }
            return num;
        }

        public override string ToString()
        {
            return this.iserialid;
        }
    }
}

