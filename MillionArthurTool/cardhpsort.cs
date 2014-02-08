namespace MillionArthurTool
{
    using System;

    public class cardhpsort : IComparable<cardhpsort>
    {
        public int iAtack;
        public int icardid;
        public int iHp;
        public int ilv;
        public int ilvmax;
        public string iserialid = "";

        public int CompareTo(cardhpsort other)
        {
            if (other == null)
            {
                return 1;
            }
            int num = other.iHp - this.iHp;
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

