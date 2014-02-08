namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Xml;

    public class cardchose : DataTable
    {
        private List<cardsetnum> decklist = new List<cardsetnum>();

        public cardchose()
        {
            base.Columns.Add("卡组号");
            base.Columns[0].DataType = typeof(int);
            base.Columns.Add("≥");
            base.Columns.Add("cost");
            base.Columns[2].DataType = typeof(int);
            this.loadconfig();
        }

        public void AddDeck(cardsetnum newdeck)
        {
            string[] values = new string[] { newdeck.num.ToString(), newdeck.limited.ToString(), newdeck.cost.ToString() };
            base.Rows.Add(values);
            this.decklist.Add(newdeck);
        }

        public int[] getDeckNum(int iLv)
        {
            int[] numArray = new int[] { this.ibase3cardnum, this.ibase3cardcost };
            foreach (cardchose.cardsetnum cardsetnum in this.decklist)
            {
                if (iLv >= cardsetnum.limited)
                {
                    numArray[0] = cardsetnum.num;
                    numArray[1] = cardsetnum.cost;
                }
            }
            return numArray;
        }

        private void loadconfig()
        {
            this.decklist.Clear();
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load("cardschange.xml");
                if (document.InnerXml != "")
                {
                    int num = int.Parse(document.SelectSingleNode("cardschange").Attributes[0].InnerText);
                    this.ifullcardnum = int.Parse(document.SelectSingleNode("cardschange").Attributes[1].InnerText);
                    this.ibase3cardnum = int.Parse(document.SelectSingleNode("cardschange").Attributes[3].InnerText);
                    this.isubcardnum = int.Parse(document.SelectSingleNode("cardschange").Attributes[5].InnerText);
                    this.iwolfmusumecardnum = int.Parse(document.SelectSingleNode("cardschange").Attributes[7].InnerText);
                    this.ifullcardcost = int.Parse(document.SelectSingleNode("cardschange").Attributes[2].InnerText);
                    this.ibase3cardcost = int.Parse(document.SelectSingleNode("cardschange").Attributes[4].InnerText);
                    this.isubcardcost = int.Parse(document.SelectSingleNode("cardschange").Attributes[6].InnerText);
                    this.iwolfmusumecardcost = int.Parse(document.SelectSingleNode("cardschange").Attributes[8].InnerText);
                    string[] values = new string[] { this.ibase3cardnum.ToString(), "基础", this.ibase3cardcost.ToString() };
                    base.Rows.Add(values);
                    values[0] = this.ifullcardnum.ToString();
                    values[1] = "全卡";
                    values[2] = this.ifullcardcost.ToString();
                    base.Rows.Add(values);
                    values[0] = this.iwolfmusumecardnum.ToString();
                    values[1] = "狼娘";
                    values[2] = this.iwolfmusumecardcost.ToString();
                    base.Rows.Add(values);
                    values[0] = this.isubcardnum.ToString();
                    values[1] = "外敌";
                    values[2] = this.isubcardcost.ToString();
                    base.Rows.Add(values);
                    for (int i = 0; i < num; i++)
                    {
                        cardsetnum newdeck = new cardsetnum(document.SelectSingleNode("cardschange").Attributes[(i * 3) + 9].InnerText, document.SelectSingleNode("cardschange").Attributes[(i * 3) + 10].InnerText, document.SelectSingleNode("cardschange").Attributes[(i * 3) + 11].InnerText);
                        this.AddDeck(newdeck);
                    }
                }
                else
                {
                    this.saveconfig();
                }
            }
            catch (Exception)
            {
                this.saveconfig();
            }
        }

        public void saveconfig()
        {
            try
            {
                this.ifullcardnum = (int) base.Rows[1][0];
                this.ibase3cardnum = (int) base.Rows[0][0];
                this.isubcardnum = (int) base.Rows[3][0];
                this.iwolfmusumecardnum = (int) base.Rows[2][0];
                this.ifullcardcost = (int) base.Rows[1][2];
                this.ibase3cardcost = (int) base.Rows[0][2];
                this.isubcardcost = (int) base.Rows[3][2];
                this.iwolfmusumecardcost = (int) base.Rows[2][2];
                this.decklist.Clear();
                for (int i = 4; i < base.Rows.Count; i++)
                {
                    cardsetnum item = new cardsetnum(base.Rows[i][0].ToString(), base.Rows[i][1].ToString(), base.Rows[i][2].ToString());
                    this.decklist.Add(item);
                }
                this.decklist.Sort();
            }
            catch (Exception)
            {
            }
            XmlTextWriter writer3 = new XmlTextWriter("cardschange.xml", Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            XmlTextWriter writer = writer3;
            XmlTextWriter writer2 = writer;
            writer2.WriteStartDocument();
            writer2.WriteComment("配置文件");
            writer2.WriteStartElement("cardschange");
            writer2.WriteStartAttribute("nums");
            writer2.WriteString(this.decklist.Count.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("a0");
            writer2.WriteString(this.ifullcardnum.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("b0");
            writer2.WriteString(this.ifullcardcost.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("a1");
            writer2.WriteString(this.ibase3cardnum.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("b1");
            writer2.WriteString(this.ibase3cardcost.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("a2");
            writer2.WriteString(this.isubcardnum.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("b2");
            writer2.WriteString(this.isubcardcost.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("a3");
            writer2.WriteString(this.iwolfmusumecardnum.ToString());
            writer2.WriteEndAttribute();
            writer2.WriteStartAttribute("b3");
            writer2.WriteString(this.iwolfmusumecardcost.ToString());
            writer2.WriteEndAttribute();
            int num2 = 1;
            foreach (cardsetnum cardsetnum2 in this.decklist)
            {
                writer2.WriteStartAttribute("num" + num2.ToString());
                writer2.WriteString(cardsetnum2.num.ToString());
                writer2.WriteEndAttribute();
                writer2.WriteStartAttribute("limited" + num2.ToString());
                writer2.WriteString(cardsetnum2.limited.ToString());
                writer2.WriteEndAttribute();
                writer2.WriteStartAttribute("cost" + num2.ToString());
                writer2.WriteString(cardsetnum2.cost.ToString());
                writer2.WriteEndAttribute();
                num2++;
            }
            writer2.WriteEndElement();
            writer2.WriteEndDocument();
            writer2.Close();
        }

        public int ibase3cardcost { get; set; }

        public int ibase3cardnum { get; set; }

        public int ifullcardcost { get; set; }

        public int ifullcardnum { get; set; }

        public int isubcardcost { get; set; }

        public int isubcardnum { get; set; }

        public int iwolfmusumecardcost { get; set; }

        public int iwolfmusumecardnum { get; set; }

        public class cardsetnum : IComparable<cardchose.cardsetnum>
        {
            public cardsetnum(string snum, string slimited, string scost)
            {
                this.num = 0;
                this.limited = 0;
                try
                {
                    this.num = int.Parse(snum);
                }
                catch (Exception)
                {
                }
                try
                {
                    this.limited = int.Parse(slimited);
                }
                catch (Exception)
                {
                }
                try
                {
                    this.cost = int.Parse(scost);
                }
                catch (Exception)
                {
                }
            }

            public int CompareTo(cardchose.cardsetnum other)
            {
                if (other == null)
                {
                    return 1;
                }
                int num = this.limited - other.limited;
                if (num == 0)
                {
                    num -= other.num;
                }
                return num;
            }

            public int cost { get; set; }

            public int limited { get; set; }

            public int num { get; set; }
        }
    }
}

