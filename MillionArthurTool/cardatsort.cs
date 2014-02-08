namespace MillionArthurTool
{
    using System;

    public class cardatsort : IComparable<cardatsort>
    {
        public int iAtack;
        public int icardid;
        public int iHp;
        public int ilv;
        public int ilvmax;
        public string iserialid = "";

        public int CompareTo(cardatsort other)
        {
            if (other == null)
            {
                return 1;
            }
            int num = other.iAtack - this.iAtack;
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

