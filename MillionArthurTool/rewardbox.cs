namespace MillionArthurTool
{
    using System;
    using System.Data;
    using System.Xml;

    public class rewardbox : DataTable
    {
        public rewardbox()
        {
            base.Columns.Add("serial_id");
            base.Columns.Add("name");
            base.Columns.Add("type");
            base.Columns.Add("content");
        }

        public void update(XmlNodeList box)
        {
            base.Rows.Clear();
            foreach (XmlNode node in box)
            {
                string str;
                int num3;
                string[] values = new string[4];
                values[0] = node.SelectSingleNode("id").InnerText;
                int num = int.Parse(node.SelectSingleNode("type").InnerText);
                values[3] = node.SelectSingleNode("content").InnerText;
                switch (num)
                {
                    case 2:
                        values[1] = node.SelectSingleNode("title").InnerText + "(" + node.SelectSingleNode("get_num").InnerText + ")";
                        values[2] = "道具";
                        goto Label_023B;

                    case 3:
                        values[1] = node.SelectSingleNode("title").InnerText + "(" + node.SelectSingleNode("point").InnerText + ")";
                        values[2] = "钱";
                        goto Label_023B;

                    case 4:
                        values[1] = node.SelectSingleNode("title").InnerText + "(" + node.SelectSingleNode("point").InnerText + ")";
                        values[2] = "基友点";
                        goto Label_023B;

                    case 7:
                    {
                        str = "";
                        int num2 = int.Parse(node.SelectSingleNode("treasure_box").SelectSingleNode("box_type").InnerText);
                        num3 = int.Parse(node.SelectSingleNode("treasure_box").SelectSingleNode("get_num").InnerText);
                        switch (num2)
                        {
                            case 0x2777:
                                goto Label_01C6;

                            case 0x2778:
                                goto Label_01CE;

                            case 0x2779:
                                goto Label_01D6;
                        }
                        goto Label_01DE;
                    }
                    default:
                        values[1] = node.SelectSingleNode("title").InnerText;
                        values[2] = num.ToString();
                        goto Label_023B;
                }
                str = "金箱";
                goto Label_01DE;
            Label_01C6:
                str = "银箱";
                goto Label_01DE;
            Label_01CE:
                str = "铜箱";
                goto Label_01DE;
            Label_01D6:
                str = "木箱";
            Label_01DE:;
                values[1] = string.Concat(new object[] { str, "(", num3, ")" });
                values[2] = "箱子";
            Label_023B:
                base.Rows.Add(values);
            }
        }
    }
}

