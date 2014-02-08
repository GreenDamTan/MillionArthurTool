namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;
    using System.Xml;

    public class CardSet : DataTable
    {
        private List<carddeck> decklist;

        public CardSet()
        {
            base.Columns.Add("name");
            base.Columns.Add("cardsnum");
            base.Columns.Add("leader");
            base.Columns.Add("1-1");
            base.Columns.Add("1-2");
            base.Columns.Add("1-3");
            base.Columns.Add("2-1");
            base.Columns.Add("2-2");
            base.Columns.Add("2-3");
            base.Columns.Add("3-1");
            base.Columns.Add("3-2");
            base.Columns.Add("3-3");
            base.Columns.Add("4-1");
            base.Columns.Add("4-2");
            base.Columns.Add("4-3");
            this.decklist = new List<carddeck>();
            this.loadconfig();
        }

        public void AddDeck(carddeck newdeck)
        {
            this.decklist.Add(newdeck);
            string[] values = new string[15];
            values[0] = newdeck.name;
            values[1] = newdeck.cardids.Count.ToString();
            values[2] = newdeck.getLeader();
            for (int i = 0; i < ((newdeck.cardids.Count > 12) ? 12 : newdeck.cardids.Count); i++)
            {
                values[3 + i] = newdeck.cardids[i].ToString();
            }
            base.Rows.Add(values);
            this.saveconfig();
        }

        public carddeck getdeck(int index)
        {
            if ((index >= 0) && (index <= this.decklist.Count))
            {
                return this.decklist[index];
            }
            return null;
        }

        private void loadconfig()
        {
            this.decklist.Clear();
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load("cards.xml");
                if (document.InnerXml != "")
                {
                    int num = int.Parse(document.SelectSingleNode("cards").Attributes[0].InnerText);
                    for (int i = 0; i < num; i++)
                    {
                        carddeck carddeck3 = new carddeck(document.SelectSingleNode("cards").Attributes[(i * 3) + 1].InnerText, document.SelectSingleNode("cards").Attributes[(i * 3) + 2].InnerText) {
                            name = document.SelectSingleNode("cards").Attributes[(i * 3) + 3].InnerText
                        };
                        carddeck carddeck = carddeck3;
                        carddeck newdeck = carddeck;
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

        public void RemoveDeck(int index)
        {
            base.Rows.RemoveAt(index);
            this.decklist.RemoveAt(index);
            this.saveconfig();
        }

        public void saveconfig()
        {
            XmlTextWriter writer3 = new XmlTextWriter("cards.xml", Encoding.UTF8) {
                Formatting = Formatting.Indented
            };
            XmlTextWriter writer = writer3;
            XmlTextWriter writer2 = writer;
            writer2.WriteStartDocument();
            writer2.WriteComment("配置文件");
            writer2.WriteStartElement("cards");
            writer2.WriteStartAttribute("nums");
            writer2.WriteString(this.decklist.Count.ToString());
            writer2.WriteEndAttribute();
            int num = 1;
            foreach (carddeck carddeck in this.decklist)
            {
                writer2.WriteStartAttribute("deck" + num.ToString());
                writer2.WriteString(carddeck.ToString());
                writer2.WriteEndAttribute();
                writer2.WriteStartAttribute("leader" + num.ToString());
                writer2.WriteString(carddeck.getLeader().ToString());
                writer2.WriteEndAttribute();
                writer2.WriteStartAttribute("name" + num.ToString());
                writer2.WriteString(carddeck.name.ToString());
                writer2.WriteEndAttribute();
                num++;
            }
            writer2.WriteEndElement();
            writer2.WriteEndDocument();
            writer2.Close();
        }

        public void UpdateDeck(carddeck newdeck, int index)
        {
            this.decklist[index] = newdeck;
            base.Rows[index][0] = newdeck.name;
            base.Rows[index][1] = newdeck.cardids.Count.ToString();
            base.Rows[index][2] = newdeck.getLeader();
            for (int i = 0; i < 12; i++)
            {
                if (i < newdeck.cardids.Count)
                {
                    base.Rows[index][3 + i] = newdeck.cardids[i].ToString();
                }
                else
                {
                    base.Rows[index][3 + i] = "";
                }
            }
            this.saveconfig();
        }
    }
}

