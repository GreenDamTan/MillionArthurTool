namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class carddeck
    {
        public List<int> cardids;
        private string deckstring;
        private string leaderstring;
        public string name;

        public carddeck(string[] dec, string leader = "")
        {
            int length = dec.Length;
            string str = "";
            this.cardids = new List<int>();
            str = dec[0];
            try
            {
                this.cardids.Add(int.Parse(dec[0]));
            }
            catch (Exception)
            {
            }
            for (int i = 1; i < length; i++)
            {
                str = str + "," + dec[i];
                try
                {
                    this.cardids.Add(int.Parse(dec[i]));
                }
                catch (Exception)
                {
                }
            }
            for (int j = length; j < 12; j++)
            {
                str = str + ",empty";
            }
            if (leader == null)
            {
                List<int> cardids = this.cardids;
                cardids.Sort();
                this.leaderstring = cardids[cardids.Count - 1].ToString();
            }
            else
            {
                this.leaderstring = leader;
            }
            this.deckstring = str;
            this.name = "名無しカードセート";
        }

        public carddeck(string dec, string leader = "")
        {
            string[] strArray = dec.Split(new char[] { ',' });
            this.deckstring = dec;
            this.cardids = new List<int>();
            foreach (string str in strArray)
            {
                if (str != "empty")
                {
                    try
                    {
                        this.cardids.Add(int.Parse(str));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            if (leader == null)
            {
                List<int> cardids = this.cardids;
                cardids.Sort();
                this.leaderstring = cardids[cardids.Count - 1].ToString();
            }
            else
            {
                this.leaderstring = leader;
            }
            this.name = "名無しカードセート";
        }

        public string getLeader()
        {
            return this.leaderstring;
        }

        public override string ToString()
        {
            return this.deckstring;
        }
    }
}

