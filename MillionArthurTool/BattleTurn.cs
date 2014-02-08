namespace MillionArthurTool
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml;

    public class BattleTurn
    {
        private string _str;
        public List<XmlNode> Turnxml;

        public BattleTurn(int hp1, int hp2)
        {
            this.playerHpStart = hp1;
            this.enemyHpStart = hp2;
            this.playerDamage = 0;
            this.Turnxml = new List<XmlNode>();
        }

        public void Do()
        {
            foreach (XmlNode node in this.Turnxml)
            {
                XmlNode node2 = node.SelectSingleNode("special_attack_damage");
                XmlNode node3 = node.SelectSingleNode("battle_job_skill");
                XmlNode node4 = node.SelectSingleNode("skill_card");
                XmlNode node5 = node.SelectSingleNode("attack_damage");
                if (node2 != null)
                {
                    this.superDamage = int.Parse(node2.InnerText);
                }
                else if (node3 != null)
                {
                    XmlNode node6 = node3.SelectSingleNode("enemy_damage");
                    XmlNode node7 = node3.SelectSingleNode("player_up_hp");
                    if (node6 != null)
                    {
                        this.SkillDamage = int.Parse(node6.InnerText);
                    }
                    if (node7 != null)
                    {
                        this.SkillHeal = int.Parse(node7.InnerText);
                    }
                }
                else if (node4 != null)
                {
                    this.iskillcard = int.Parse(node4.InnerText);
                    this.iskillid = int.Parse(node.SelectSingleNode("skill_id").InnerText);
                    XmlNode node8 = node.SelectSingleNode("skill_hp_player");
                    if (node8 != null)
                    {
                        this.playerHeal = int.Parse(node8.InnerText);
                    }
                }
                if (node5 != null)
                {
                    if (node.SelectSingleNode("action_player").InnerText == "0")
                    {
                        this.playerDamage += int.Parse(node5.InnerText);
                        continue;
                    }
                    this.EnemyDamega += int.Parse(node5.InnerText);
                }
            }
            this._str = this.doString();
        }

        private string doString()
        {
            int num;
            object[] objArray7;
            int num2 = 0;
            string str = "回合" + this.turn + ":\r\n";
            this.playerHpEnd = this.playerHpStart;
            this.enemyHpEnd = this.enemyHpStart;
            if (this.superDamage != 0)
            {
                object obj2 = str;
                objArray7 = new object[] { obj2, "你发动咖喱棒，造成伤害：", this.superDamage, ",", this.EnemyName, " HP", this.enemyHpEnd, "→", this.enemyHpEnd -= this.superDamage, "\r\n" };
                object[] objArray = objArray7;
                str = string.Concat(objArray);
            }
            if (this.SkillDamage != 0)
            {
                object obj3 = str;
                objArray7 = new object[] { obj3, "弓手怨念反弹伤害：", this.SkillDamage, ",", this.EnemyName, " HP", this.enemyHpEnd, "→", this.enemyHpEnd -= this.SkillDamage, "\r\n" };
                object[] objArray2 = objArray7;
                str = string.Concat(objArray2);
            }
            if (this.SkillHeal != 0)
            {
                object obj4 = str;
                objArray7 = new object[] { obj4, "风水奇迹的发动治疗", this.SkillHeal, ",HP", this.playerHpEnd, "→", this.playerHpEnd += this.SkillHeal, "\r\n" };
                object[] objArray3 = objArray7;
                str = string.Concat(objArray3);
            }
            if (this.iskillcard != 0)
            {
                string str2 = str;
                str = str2 + "card" + this.iskillcard.ToString() + "发动技能" + this.iskillid.ToString() + "\r\n";
            }
            if (this.playerHeal != 0)
            {
                object obj5 = str;
                objArray7 = new object[] { obj5, "治疗", this.playerHeal, ",HP", this.playerHpEnd, "→", this.playerHpEnd += this.playerHeal, "\r\n" };
                object[] objArray4 = objArray7;
                str = string.Concat(objArray4);
            }
            object obj6 = str;
            objArray7 = new object[] { obj6, "你怒操对方，造成伤害", this.playerDamage, ",", this.EnemyName, " HP", this.enemyHpEnd, "→", this.enemyHpEnd -= this.playerDamage, "\r\n" };
            object[] objArray5 = objArray7;
            object obj7 = string.Concat(objArray5);
            object[] objArray6 = new object[9];
            objArray6[0] = obj7;
            objArray6[1] = this.EnemyName;
            objArray6[2] = "对方菊花流的血";
            objArray6[3] = this.EnemyDamega;
            objArray6[4] = ",HP";
            objArray6[5] = this.playerHpEnd;
            objArray6[6] = "→";
            this.playerHpEnd = num = this.playerHpEnd - this.EnemyDamega;
            objArray6[7] = (num < 0) ? num2 : this.playerHpEnd;
            objArray6[8] = "\r\n";
            return string.Concat(objArray6);
        }

        public BattleTurn newTurn()
        {
            return new BattleTurn(this.playerHpEnd, this.enemyHpEnd) { EnemyName = this.EnemyName };
        }

        public override string ToString()
        {
            return this._str;
        }

        public int EnemyDamega { get; set; }

        public int enemyHpEnd { get; set; }

        public int enemyHpStart { get; set; }

        public string EnemyName { get; set; }

        public int iskillcard { get; set; }

        public int iskillid { get; set; }

        public int playerDamage { get; set; }

        public int playerHeal { get; set; }

        public int playerHpEnd { get; set; }

        public int playerHpStart { get; set; }

        public int SkillDamage { get; set; }

        public int SkillHeal { get; set; }

        public int superDamage { get; set; }

        public int turn { get; set; }
    }
}

