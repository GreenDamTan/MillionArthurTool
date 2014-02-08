namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.InteropServices;
    using System.Xml;

    public class cards : DataTable
    {
        public string DIR = @"D:\full_thumbnail_chara\card_full_max\";
        public List<string> PngList = new List<string>();

        public cards()
        {
            base.Columns.Add("serialid");
            base.Columns.Add("cardid");
            base.Columns.Add("lv");
            base.Columns.Add("hp");
            base.Columns.Add("atk");
        }

        public void update(XmlNodeList Cards, int tpyesort = 1)
        {
            base.Rows.Clear();
            this.PngList.Clear();
            switch (tpyesort)
            {
                case 1:
                {
                    List<cardlvsort> list = new List<cardlvsort>();
                    foreach (XmlNode node in Cards)
                    {
                        cardlvsort cardlvsort3 = new cardlvsort {
                            iserialid = node.SelectSingleNode("serial_id").InnerText,
                            ilv = int.Parse(node.SelectSingleNode("lv").InnerText),
                            icardid = int.Parse(node.SelectSingleNode("master_card_id").InnerText),
                            ilvmax = int.Parse(node.SelectSingleNode("lv_max").InnerText),
                            iHp = int.Parse(node.SelectSingleNode("hp").InnerText),
                            iAtack = int.Parse(node.SelectSingleNode("power").InnerText)
                        };
                        cardlvsort cardlvsort = cardlvsort3;
                        cardlvsort item = cardlvsort;
                        list.Add(item);
                    }
                    list.Sort();
                    foreach (cardlvsort cardlvsort4 in list)
                    {
                        string[] values = new string[] { cardlvsort4.iserialid, cardlvsort4.icardid.ToString(), cardlvsort4.ilv + "/" + cardlvsort4.ilvmax, cardlvsort4.iHp.ToString(), cardlvsort4.iAtack.ToString() };
                        string str = string.Concat(new object[] { this.DIR, "full_thumbnail_chara_", cardlvsort4.icardid + 0x1388, ".png" });
                        this.PngList.Add(str);
                        base.Rows.Add(values);
                    }
                    break;
                }
                case 2:
                {
                    List<cardidsort> list2 = new List<cardidsort>();
                    foreach (XmlNode node2 in Cards)
                    {
                        cardidsort cardidsort3 = new cardidsort {
                            iserialid = node2.SelectSingleNode("serial_id").InnerText,
                            ilv = int.Parse(node2.SelectSingleNode("lv").InnerText),
                            icardid = int.Parse(node2.SelectSingleNode("master_card_id").InnerText),
                            ilvmax = int.Parse(node2.SelectSingleNode("lv_max").InnerText),
                            iHp = int.Parse(node2.SelectSingleNode("hp").InnerText),
                            iAtack = int.Parse(node2.SelectSingleNode("power").InnerText)
                        };
                        cardidsort cardidsort = cardidsort3;
                        cardidsort cardidsort2 = cardidsort;
                        list2.Add(cardidsort2);
                    }
                    list2.Sort();
                    foreach (cardidsort cardidsort4 in list2)
                    {
                        string[] strArray2 = new string[] { cardidsort4.iserialid, cardidsort4.icardid.ToString(), cardidsort4.ilv + "/" + cardidsort4.ilvmax, cardidsort4.iHp.ToString(), cardidsort4.iAtack.ToString() };
                        string str2 = string.Concat(new object[] { this.DIR, "full_thumbnail_chara_", cardidsort4.icardid + 0x1388, ".png" });
                        this.PngList.Add(str2);
                        base.Rows.Add(strArray2);
                    }
                    break;
                }
                case 3:
                {
                    List<cardhpsort> list3 = new List<cardhpsort>();
                    foreach (XmlNode node3 in Cards)
                    {
                        cardhpsort cardhpsort3 = new cardhpsort {
                            iserialid = node3.SelectSingleNode("serial_id").InnerText,
                            ilv = int.Parse(node3.SelectSingleNode("lv").InnerText),
                            icardid = int.Parse(node3.SelectSingleNode("master_card_id").InnerText),
                            ilvmax = int.Parse(node3.SelectSingleNode("lv_max").InnerText),
                            iHp = int.Parse(node3.SelectSingleNode("hp").InnerText),
                            iAtack = int.Parse(node3.SelectSingleNode("power").InnerText)
                        };
                        cardhpsort cardhpsort = cardhpsort3;
                        cardhpsort cardhpsort2 = cardhpsort;
                        list3.Add(cardhpsort2);
                    }
                    list3.Sort();
                    foreach (cardhpsort cardhpsort4 in list3)
                    {
                        string[] strArray3 = new string[] { cardhpsort4.iserialid, cardhpsort4.icardid.ToString(), cardhpsort4.ilv + "/" + cardhpsort4.ilvmax, cardhpsort4.iHp.ToString(), cardhpsort4.iAtack.ToString() };
                        string str3 = string.Concat(new object[] { this.DIR, "full_thumbnail_chara_", cardhpsort4.icardid + 0x1388, ".png" });
                        this.PngList.Add(str3);
                        base.Rows.Add(strArray3);
                    }
                    break;
                }
                case 4:
                {
                    List<cardatsort> list4 = new List<cardatsort>();
                    foreach (XmlNode node4 in Cards)
                    {
                        cardatsort cardatsort3 = new cardatsort {
                            iserialid = node4.SelectSingleNode("serial_id").InnerText,
                            ilv = int.Parse(node4.SelectSingleNode("lv").InnerText),
                            icardid = int.Parse(node4.SelectSingleNode("master_card_id").InnerText),
                            ilvmax = int.Parse(node4.SelectSingleNode("lv_max").InnerText),
                            iHp = int.Parse(node4.SelectSingleNode("hp").InnerText),
                            iAtack = int.Parse(node4.SelectSingleNode("power").InnerText)
                        };
                        cardatsort cardatsort = cardatsort3;
                        cardatsort cardatsort2 = cardatsort;
                        list4.Add(cardatsort2);
                    }
                    list4.Sort();
                    foreach (cardatsort cardatsort4 in list4)
                    {
                        string[] strArray4 = new string[] { cardatsort4.iserialid, cardatsort4.icardid.ToString(), cardatsort4.ilv + "/" + cardatsort4.ilvmax, cardatsort4.iHp.ToString(), cardatsort4.iAtack.ToString() };
                        string str4 = string.Concat(new object[] { this.DIR, "full_thumbnail_chara_", cardatsort4.icardid + 0x1388, ".png" });
                        this.PngList.Add(str4);
                        base.Rows.Add(strArray4);
                    }
                    break;
                }
            }
        }
    }
}

