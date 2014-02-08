namespace MillionArthurTool
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;

    public class Buff
    {
        public Buff(XmlNode actionnode)
        {
            this.name = actionnode.SelectSingleNode("combo_name").InnerText;
            this.ccards = actionnode.SelectSingleNode("combo_card_list_player").InnerText;
            this.type = int.Parse(actionnode.SelectSingleNode("combo_type").InnerText);
            this.hp = int.Parse(actionnode.SelectSingleNode("combo_hp_player").InnerText);
        }

        public override string ToString()
        {
            return string.Concat(new object[] { this.type, "|", this.name, "|", this.ccards, "|", this.hp, "\r\n" });
        }

        public string ccards { get; set; }

        public int hp { get; set; }

        public string name { get; set; }

        public int type { get; set; }
    }
}

