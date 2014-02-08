namespace MillionArthurTool
{
    using System;

    public class playerrank : IComparable<playerrank>
    {
        public int ilv;
        public int irank;
        public string logintime = "";
        public string name = "";
        public int point;

        public int CompareTo(playerrank other)
        {
            if (other == null)
            {
                return 1;
            }
            int num = other.point - this.point;
            if (num == 0)
            {
                num = this.ilv - other.ilv;
            }
            return num;
        }

        public override string ToString()
        {
            return string.Format("{0}，等级：{1}，贡献：{2}，排名：{3}，最后登录：{4}\r\n", new object[] { this.name, this.ilv, this.point, this.irank, this.logintime });
        }
    }
}

