namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Xml;

    public class BattleLog
    {
        private string _str;
        private string _text;
        private object _value;
        public List<Buff> combolist;
        private List<int> EnemyDamagelist;
        private int EnemyHP_Final;
        private int EnemyHP_MAX;
        private int EnemyHP_Start;
        private string EnemyName;
        private List<int> hpbufflist;
        private int iTurn;
        private int JobDamage;
        private int JobDamageID;
        private int JobHp_up;
        private List<int> PlayerDamaglist;
        private List<int> PlayerHeallist;
        private int PlayerHP_Buffed;
        private int PlayerHP_Final;
        private int PlayerHP_Start;
        private int SuperDamage;
        private List<BattleTurn> TurnList;

        public BattleLog(XmlNode battlenode, int lv, int c1, int c2)
        {
            this.EnemyLv = lv;
            this.HpContribution = c1;
            this.AtkContribution = c2;
            this.hpbufflist = new List<int>();
            this.PlayerDamaglist = new List<int>();
            this.EnemyDamagelist = new List<int>();
            this.PlayerHeallist = new List<int>();
            this.TurnList = new List<BattleTurn>();
            this.combolist = new List<Buff>();
            this.SuperDamage = 0;
            this.JobHp_up = 0;
            this.JobDamage = 0;
            XmlNodeList list = battlenode.SelectNodes("battle_player_list");
            XmlNodeList list2 = battlenode.SelectNodes("battle_action_list");
            this.PlayerHP_Start = int.Parse(list[0].SelectSingleNode("hp").InnerText);
            this.EnemyHP_Start = int.Parse(list[1].SelectSingleNode("hp").InnerText);
            this.EnemyHP_MAX = int.Parse(list[1].SelectSingleNode("maxhp").InnerText);
            this.EnemyName = list[1].SelectSingleNode("name").InnerText;
            int num = 0;
            BattleTurn turn4 = new BattleTurn(this.PlayerHP_Start, this.EnemyHP_Start) {
                EnemyName = this.EnemyName
            };
            BattleTurn turn = turn4;
            BattleTurn item = turn;
            foreach (XmlNode node in list2)
            {
                XmlNode node2 = node.SelectSingleNode("turn");
                XmlNode node3 = node.SelectSingleNode("battle_exit");
                if (node3 != null)
                {
                    if (!(node3.InnerText == "1"))
                    {
                        continue;
                    }
                    break;
                }
                if (node2 != null)
                {
                    num = int.Parse(node2.InnerText);
                    if (num != 1)
                    {
                        item.Do();
                        this.PlayerDamaglist.Add(item.playerDamage);
                        this.EnemyDamagelist.Add(item.EnemyDamega);
                        if (item.playerHeal != 0)
                        {
                            this.PlayerHeallist.Add(item.playerHeal);
                        }
                        this.TurnList.Add(item);
                        item = item.newTurn();
                        item.turn = num;
                    }
                    else
                    {
                        item.enemyHpStart = this.EnemyHP_Start - this.JobDamage;
                        this.PlayerHP_Buffed = (this.PlayerHP_Start + ((IEnumerable<int>) this.hpbufflist).Sum()) + this.JobHp_up;
                        item.playerHpStart = this.PlayerHP_Buffed;
                        item.turn = num;
                    }
                    continue;
                }
                if (num == 0)
                {
                    XmlNode node4 = node.SelectSingleNode("battle_job_skill");
                    XmlNode node5 = node.SelectSingleNode("combo_name");
                    if (node4 != null)
                    {
                        XmlNode node6 = node4.SelectSingleNode("enemy_damage");
                        XmlNode node7 = node4.SelectSingleNode("player_up_hp");
                        if (node6 != null)
                        {
                            this.JobDamage = int.Parse(node6.InnerText);
                            this.JobDamageID = int.Parse(node4.SelectSingleNode("job_skill_id").InnerText);
                        }
                        else if (node7 != null)
                        {
                            this.JobHp_up = int.Parse(node7.InnerText);
                        }
                    }
                    else if (node5 != null)
                    {
                        Buff buff = new Buff(node);
                        if (buff.hp != 0)
                        {
                            this.hpbufflist.Add(buff.hp);
                        }
                        this.combolist.Add(buff);
                    }
                    continue;
                }
                XmlNode node8 = node.SelectSingleNode("special_attack_damage");
                if (node8 != null)
                {
                    this.SuperDamage = int.Parse(node8.InnerText);
                }
                item.Turnxml.Add(node);
            }
            item.Do();
            this.PlayerDamaglist.Add(item.playerDamage);
            this.EnemyDamagelist.Add(item.EnemyDamega);
            if (item.playerHeal != 0)
            {
                this.PlayerHeallist.Add(item.playerHeal);
            }
            this.PlayerHP_Final = item.playerHpEnd;
            this.EnemyHP_Final = item.enemyHpEnd;
            this.iTurn = item.turn;
            this.TurnList.Add(item);
            this._str = string.Concat(new object[] { this.EnemyName, " lv", this.EnemyLv, " HP:", this.EnemyHP_Start, "/", this.EnemyHP_MAX, "\r\n\r\n" });
            this._str = this._str + "发动combo：\r\n";
            foreach (Buff buff2 in this.combolist)
            {
                this._str = this._str + buff2.ToString();
            }
            if (this.JobHp_up != 0)
            {
                object obj2 = this._str;
                this._str = string.Concat(new object[] { obj2, "弓手buff HP ", this.JobHp_up, "上升\r\n" });
            }
            object obj3 = this._str;
            this._str = string.Concat(new object[] { obj3, "HP:", this.PlayerHP_Start, "→", this.PlayerHP_Buffed });
            this._str = this._str + "\r\n";
            object obj4 = this._str;
            this._str = string.Concat(new object[] { obj4, "职业技能ID:", this.JobDamageID, "发动，造成伤害", this.JobDamage, ",", this.EnemyName, " HP", this.EnemyHP_Start, "→", this.EnemyHP_Start - this.JobDamage, "\r\n\r\n" });
            foreach (BattleTurn turn3 in this.TurnList)
            {
                this._str = this._str + turn3.ToString();
            }
            this._str = this._str + "\r\n";
            object obj5 = this._str;
            this._str = string.Concat(new object[] { obj5, "你总共造成伤害：", this.EnemyHP_Start - this.EnemyHP_Final, " 攻击贡献：", this.AtkContribution, ",剩余hp:", this.PlayerHP_Final, "/", this.PlayerHP_Buffed, " 剩余HP贡献：", this.HpContribution, "\r\n" });
            if (this.itemcount != 0)
            {
                this._str = this._str + "获得收集道具：" + this.itemcount;
            }
            this._value = this._str;
            this._text = string.Concat(new object[] { this.EnemyName, " lv", this.EnemyLv, " 攻击贡献：", this.AtkContribution, " 剩余贡献：", this.HpContribution });
        }

        public override string ToString()
        {
            return this._text;
        }

        public int AtkContribution { get; set; }

        public int EnemyLv { get; set; }

        public int HpContribution { get; set; }

        public int itemcount { get; set; }

        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        public object Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}

