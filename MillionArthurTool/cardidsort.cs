namespace MillionArthurTool
{
    using System;

    public class cardidsort : IComparable<cardidsort>
    {
        public int iAtack;
        public int icardid;
        public int iHp;
        public int ilv;
        public int ilvmax;
        public string iserialid = "";

        public int CompareTo(cardidsort other)
        {
            if (other == null)
            {
                return 1;
            }
            int num = other.icardid - this.icardid;
            if (num == 0)
            {
                num = this.ilv - other.ilv;
            }
            return num;
        }

        public override string ToString()
        {
            return this.iserialid;
        }
    }
}

