namespace MillionArthurTool
{
    using MillionArthurTool.Properties;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Net.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml;

    public class Form1 : Form
    {
        private Log actionlog;
        private cards allcards;
        private int AP;
        private string AreaName = "";
        private XmlDocument areaxml;
        private EventHandler<EventArgs> _AttackEvent;
        private EventHandler<EventArgs> _AttackEventEx;
        private Thread AttackThread;
        private bool bActNoLimit;
        private string baseKey;
        private bool bAting;
        private bool bAtoBuild = true;
        private bool bAttack;
        private bool bAttackSub;
        private List<BattleLog> Battles;
        private DataTable Battletable;
        private bool bAutoChange;
        private bool bAutojob;
        private bool bBonus;
        private int BC;
        private bool bgetTickt;
        private bool bliqu = true;
        private bool bLogin;
        private bool blogining;
        private string bname;
        private bool bNoLimitedBC;
        private bool bSub;
        private bool bThreadAttack;
        private bool bThreadEx;
        private bool bThreadExplore;
        private bool bThreadMain;
        private bool bThreadRank;
        private bool bThreadRigist;
        private Button button1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button2;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private bool bWinner;
        private bool bxiap;
        private string card3;
        private string card6;
        private int[] cardc = new int[2];
        private cardchose CardChose;
        private string cardFull;
        private XmlNodeList cardlist;
        private string cardMaid;
        private string cardMr;
        private CardSet cardset;
        private string cardSUB;
        private string cardwolf;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private IContainer components = null;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private string DefaultUserAgent = "Million/250 (aalgt; aalgt; 4.1.2) sumsung/aalgt/aalgt:4.1.2/JZ254K/E410LKLJME2:user/release-keys GooglePlay";
        private DateTime dtnew;
        private DateTime dtOld;
        private double dWin;
        private EventHandler<EventArgs> _ExploreEvent;
        private Thread ExploreThread;
        private Thread ExThread;
        private List<int> fairylist = new List<int>();
        private DateTime guildfairytime = DateTime.Now;
        private int hp;
        private int hp_max;
        private int iAreaID;
        private int ibuyCount;
        private int iCardNum;
        private int ichose;
        private int iContribution;
        private int iContribution2;
        private int iGuildID;
        private int iGuildItemCount;
        private int iJobID;
        private int ilowap = 1;
        private int imaicount;
        private int inowcard = -1;
        private int iNowUserid;
        private int ioldre;
        private int iPartyid;
        private int iSellPrice = 600;
        private int iServer;
        private int iSubBossID;
        private int itestjob = 1;
        private int iTIME;
        private int iuserLevel;
        private string key0;
        private string key11;
        private string key12;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private string labelgrk;
        private string labelgzg;
        private string labelxrg;
        private string labelxrk;
        private string labelxzg;
        private string labelzrg;
        private string labelzrk;
        private string labelzzg;
        private Label lbBCAP;
        private ListBox listBox1;
        private ListBox listBox2;
        private BingdingText logbind;
        private EventHandler<EventArgs> _LoginEvent;
        private int LoginType = 1;
        private string lr3;
        private string lr6;
        private string lrMaid;
        private string lrSUB;
        private string lrwolf;
        private int lv;
        private Thread MainThread;
        private EventHandler<EventArgs> _MapsEvent;
        private int master_boss_id;
        private int MaxAP;
        private int MaxBc;
        private int nowFairyID;
        private int oldlv;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private List<playerrank> ranklist = new List<playerrank>();
        private Thread RankThread;
        private rewardbox Rewardbox;
        private EventHandler<EventArgs> _RewardsEvent;
        private Thread RigistThread;
        private int serial_id;
        private DateTime subTime = DateTime.Now;
        private string szActionLog = "";
        private string szCharName = "";
        private string szcookie;
        private string szCookie;
        private string szFloor = "1";
        private string szhost = "web.million-arthurs.com";
        private string szhostport = "web.million-arthurs.com";
        private string szSkill = "dummy";
        private Thread tdgettickt;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBoxLog;
        private System.Windows.Forms.Timer timer1;
        private Label label10;
        private List<string> userlist = new List<string>();

        public event EventHandler<EventArgs> AttackEvent
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> attackEvent = this._AttackEvent;
                do
                {
                    handler2 = attackEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    attackEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._AttackEvent, handler3, handler2);
                }
                while (attackEvent != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> attackEvent = this._AttackEvent;
                do
                {
                    handler2 = attackEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    attackEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._AttackEvent, handler3, handler2);
                }
                while (attackEvent != handler2);
            }
        }

        public event EventHandler<EventArgs> AttackEventEx
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> attackEventEx = this._AttackEventEx;
                do
                {
                    handler2 = attackEventEx;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    attackEventEx = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._AttackEventEx, handler3, handler2);
                }
                while (attackEventEx != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> attackEventEx = this._AttackEventEx;
                do
                {
                    handler2 = attackEventEx;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    attackEventEx = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._AttackEventEx, handler3, handler2);
                }
                while (attackEventEx != handler2);
            }
        }

        public event EventHandler<EventArgs> ExploreEvent
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> exploreEvent = this._ExploreEvent;
                do
                {
                    handler2 = exploreEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    exploreEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._ExploreEvent, handler3, handler2);
                }
                while (exploreEvent != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> exploreEvent = this._ExploreEvent;
                do
                {
                    handler2 = exploreEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    exploreEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._ExploreEvent, handler3, handler2);
                }
                while (exploreEvent != handler2);
            }
        }

        public event EventHandler<EventArgs> LoginEvent
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> loginEvent = this._LoginEvent;
                do
                {
                    handler2 = loginEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    loginEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._LoginEvent, handler3, handler2);
                }
                while (loginEvent != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> loginEvent = this._LoginEvent;
                do
                {
                    handler2 = loginEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    loginEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._LoginEvent, handler3, handler2);
                }
                while (loginEvent != handler2);
            }
        }

        public event EventHandler<EventArgs> MapsEvent
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> mapsEvent = this._MapsEvent;
                do
                {
                    handler2 = mapsEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    mapsEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._MapsEvent, handler3, handler2);
                }
                while (mapsEvent != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> mapsEvent = this._MapsEvent;
                do
                {
                    handler2 = mapsEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    mapsEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._MapsEvent, handler3, handler2);
                }
                while (mapsEvent != handler2);
            }
        }

        public event EventHandler<EventArgs> RewardsEvent
        {
            add
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> rewardsEvent = this._RewardsEvent;
                do
                {
                    handler2 = rewardsEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Combine(handler2, value);
                    rewardsEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._RewardsEvent, handler3, handler2);
                }
                while (rewardsEvent != handler2);
            }
            remove
            {
                EventHandler<EventArgs> handler2;
                EventHandler<EventArgs> rewardsEvent = this._RewardsEvent;
                do
                {
                    handler2 = rewardsEvent;
                    EventHandler<EventArgs> handler3 = (EventHandler<EventArgs>) Delegate.Remove(handler2, value);
                    rewardsEvent = Interlocked.CompareExchange<EventHandler<EventArgs>>(ref this._RewardsEvent, handler3, handler2);
                }
                while (rewardsEvent != handler2);
            }
        }

        public Form1()
        {
            this.InitializeComponent();
            this.bExplore = false;
            this.iMasterBossID = 0;
            this._AttackEvent += new EventHandler<EventArgs>(this.AttackMethod);
            this._AttackEventEx += new EventHandler<EventArgs>(this.AttackMethodEx);
            this._ExploreEvent += new EventHandler<EventArgs>(this.ExploreMethod);
            this._LoginEvent += new EventHandler<EventArgs>(this.LoginMethod);
            this._MapsEvent += new EventHandler<EventArgs>(this.MapsMethod);
            this._RewardsEvent += new EventHandler<EventArgs>(this.RewardsMethod);
            this.actionlog = Log.instance;
            this.GetApple();
            this.timer1.Interval = 0x3e8;
            this.timer1.Start();
            if (this.iServer == 1)
            {
                this.key0 = this.baseKey;
            }
            else
            {
                this.key0 = this.baseKey + "0000000000000000";
            }
        }

        private int alowuser(int iuser)
        {
            string url = "http://" + this.szhostport + "/connect/app/friend/approve_friend?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("dialog", this.Encrypt("1", this.key12));
            parameters.Add("user_id", this.Encrypt(iuser.ToString(), this.key12));
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return -1;
            }
            if (document != null)
            {
                if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                {
                    string str2 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + str2;
                    return -1;
                }
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            }
            return 0;
        }

        private void AttackMethod(object sender, EventArgs e)
        {
            this.bAting = true;
            if (this.iServer == 0)
            {
                this.getGuildFairyIfo();
                try
                {
                    int.Parse(this.textBox5.Text);
                }
                catch (Exception)
                {
                }
            }
            else if (this.iServer == 1)
            {
                int num = 2;
                try
                {
                    num = int.Parse(this.textBox5.Text);
                }
                catch (Exception)
                {
                }
                if (this.BC >= num)
                {
                    this.getFairyIfo();
                }
                else if (this.radioButton4.Checked)
                {
                    this.useitem(2);
                    if (this.BC > num)
                    {
                        this.getFairyIfo();
                    }
                }
                else if (this.radioButton5.Checked)
                {
                    this.useitem(0x6f);
                    if (this.BC > num)
                    {
                        this.getFairyIfo();
                    }
                }
                else
                {
                    this.getapbc();
                }
            }
            this.bAting = false;
        }

        private void AttackMethodEx(object sender, EventArgs e)
        {
            int num = 0;
            this.bAting = true;
            int num2 = 2;
            try
            {
                num2 = int.Parse(this.textBox5.Text);
            }
            catch (Exception)
            {
            }
            num = this.getGuidIFO();
            switch (num)
            {
                case 1:
                    num = this.getGuidIFO();
                    break;

                case 2:
                    num = this.getGuidIFO();
                    break;
            }
            if (num == 2)
            {
                this.bAting = false;
            }
            else
            {
                if (this.oldlv != this.lv)
                {
                    this.cardc = this.CardChose.getDeckNum(this.lv);
                    this.oldlv = this.lv;
                }
                if (this.bBonus)
                {
                    if (this.bSub)
                    {
                        this.bAttackSub = false;
                        this.ChangeCard(this.CardChose.isubcardnum);
                        int num3 = this.serial_id;
                        Thread.Sleep(0x3a98);
                        if ((this.getGuidIFO() != 2) && (num3 == this.serial_id))
                        {
                            this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                        }
                    }
                    else
                    {
                        this.bAttackSub = false;
                        this.ChangeCard(this.CardChose.ifullcardnum);
                        int num4 = this.serial_id;
                        Thread.Sleep(0x3a98);
                        num = this.getGuidIFO();
                        if (((num != 1) && (num != 2)) && (num4 == this.serial_id))
                        {
                            this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                        }
                    }
                }
                else if (this.bSub)
                {
                    if (this.BC > num2)
                    {
                        if (!((num == 2) || this.bAttackSub))
                        {
                            this.ChangeCard(this.CardChose.iwolfmusumecardnum);
                            this.changejob(2);
                            this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                            this.bAttackSub = true;
                            this.subTime = DateTime.Now;
                            this.changejob(this.bAutojob ? this.iJobID : this.ichose);
                        }
                        else if ((num != 2) && this.bAttackSub)
                        {
                            TimeSpan span = (TimeSpan) (DateTime.Now - this.subTime);
                            if ((span.TotalMinutes >= 2.0) && (this.BC > this.CardChose.ibase3cardcost))
                            {
                                this.ChangeCard(this.CardChose.ibase3cardnum);
                                this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                            }
                        }
                    }
                }
                else
                {
                    this.bAttackSub = false;
                    if ((num != 2) && (this.BC > this.cardc[1]))
                    {
                        this.ChangeCard(this.cardc[0]);
                        this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                    }
                }
                this.bAting = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MainThread = new Thread(new ThreadStart(this.threadMain));
            this.MainThread.Start();
            this.EnableLoint(false);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/friend/add_friend?cyt=1";
        Label_0069:;
            try
            {
                int num = int.Parse(this.textBox9.Text);
                parameters.Clear();
                parameters.Add("dialog", this.Encrypt("1", this.key12));
                parameters.Add("user_id", this.Encrypt(num.ToString(), this.key12));
                this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0069;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.cardset.AddDeck(this.getdeck());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
            if (rowIndex >= 0)
            {
                this.cardset.UpdateDeck(this.getdeck(), rowIndex);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
            if (rowIndex >= 0)
            {
                this.cardset.RemoveDeck(rowIndex);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = this.dataGridView2.SelectedCells;
            if (selectedCells.Count >= 1)
            {
                int rowIndex = selectedCells[0].RowIndex;
                string str = this.allcards.Rows[rowIndex][0].ToString();
                this.textBox8.Text = str;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.threadOpen)).Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.threadGet)).Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.allcards.update(this.cardlist, this.comboBox4.SelectedIndex + 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.threadsellselect)).Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!this.bThreadEx)
            {
                this.bThreadEx = true;
                this.ExThread = new Thread(new ThreadStart(this.ThreadEX));
                this.ExThread.Start();
                this.button19.Text = "停止";
            }
            else
            {
                this.bThreadEx = false;
                Thread.Sleep(0x3e8);
                this.ExThread.Abort();
                this.button19.Text = "挂机";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bLogin = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
            this.button10.Enabled = false;
            this.button11.Enabled = false;
            this.button12.Enabled = false;
            this.button13.Enabled = false;
            this.button14.Enabled = false;
            this.button15.Enabled = false;
            this.button16.Enabled = false;
            this.button17.Enabled = false;
            this.button18.Enabled = false;
            this.button20.Enabled = false;
            this.button21.Enabled = false;
            this.button22.Enabled = false;
            this.button23.Enabled = false;
            this.button24.Enabled = false;
            this.button25.Enabled = false;
            this.radioButton8.Enabled = true;
            
            this.closeThread();
            this.EnableLoint(true);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (this.listBox2.Items.Count >= 1)
            {
                string[] dec = new string[this.listBox2.Items.Count];
                int index = 0;
                foreach (object obj2 in this.listBox2.Items)
                {
                    dec[index] = obj2.ToString();
                    index++;
                }
                if (this.textBox8.Text != "")
                {
                    carddeck newdeck = new carddeck(dec, this.textBox8.Text);
                    this.cardset.AddDeck(newdeck);
                }
                else
                {
                    carddeck carddeck2 = new carddeck(dec, null);
                    this.cardset.AddDeck(carddeck2);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = this.dataGridView2.SelectedCells;
            if (selectedCells.Count >= 1)
            {
                foreach (DataGridViewCell cell in selectedCells)
                {
                    int rowIndex = cell.RowIndex;
                    this.listBox2.Items.Add(this.allcards.Rows[rowIndex][0]);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.threadCompound)).Start();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (((this.listBox2.Items != null) && (this.listBox2.Items.Count > 0)) && (this.listBox2.SelectedItem != null))
            {
                this.listBox2.Items.Remove(this.listBox2.SelectedItem);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getFairyRewards)).Start();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!this.bgetTickt)
            {
                this.bgetTickt = true;
                this.tdgettickt = new Thread(new ThreadStart(this.ThreadGetTickt));
                this.tdgettickt.Start();
                this.button25.Text = "停止取卷";
            }
            else
            {
                this.bgetTickt = false;
                Thread.Sleep(0x3e8);
                this.tdgettickt.Abort();
                this.button25.Text = "连续取卷";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this._MapsEvent.BeginInvoke(null, EventArgs.Empty, null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.partyrank)).Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this._RewardsEvent.BeginInvoke(null, EventArgs.Empty, null, null);
            this.button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.UpdateJob();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (!this.bThreadExplore)
            {
                this.bThreadExplore = true;
                this.ExploreThread = new Thread(new ThreadStart(this.threadExplore));
                this.ExploreThread.Start();
                this.button6.Text = "停止跑图";
            }
            else
            {
                this.bThreadExplore = false;
                Thread.Sleep(0x3e8);
                this.ExploreThread.Abort();
                this.button6.Text = "挂机跑图";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this._ExploreEvent.BeginInvoke(null, EventArgs.Empty, null, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!this.bThreadAttack)
            {
                this.bThreadAttack = true;
                this.AttackThread = new Thread(new ThreadStart(this.threadAttack));
                this.AttackThread.Start();
                this.button8.Text = "停止攻击";
            }
            else
            {
                this.bThreadAttack = false;
                Thread.Sleep(0x3e8);
                this.AttackThread.Abort();
                this.button8.Text = "连续攻击";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.setbc();
        }

        private void buy(int iProduct, int icount)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            string url = "http://" + this.szhostport + "/connect/app/gacha/buy?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0066:;
            try
            {
                parameters.Clear();
                parameters.Add("auto_build", this.Encrypt("0", this.key12));
                parameters.Add("bulk", this.Encrypt("0", this.key12));
                parameters.Add("product_id", this.Encrypt(iProduct.ToString(), this.key12));
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0066;
            }
            if (document != null)
            {
                if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                {
                    this.ibuyCount = 0;
                }
                else
                {
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    this.szCharName = node.SelectSingleNode("name").InnerText + "挂机ing";
                    XmlNode node2 = node.SelectSingleNode("bc");
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                    string str = "";
                    XmlNodeList list = null;
                    int num = 0;
                    list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                    string str3 = "抽卡：ID:" + list[0].ChildNodes[1].InnerText + "\r\n";
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + str3;
                    string str5 = "";
                    if (this.ibuyCount <= icount)
                    {
                        this.ibuyCount++;
                        if (list.Count < 190)
                        {
                            this.buy(iProduct, icount);
                        }
                    }
                    else
                    {
                        foreach (XmlNode node4 in list)
                        {
                            int num2 = int.Parse(node4.SelectSingleNode("lv").InnerText);
                            int num3 = int.Parse(node4.SelectSingleNode("lv_max").InnerText);
                            int num4 = int.Parse(node4.SelectSingleNode("sale_price").InnerText);
                            int num5 = int.Parse(node4.SelectSingleNode("hp").InnerText);
                            int num6 = int.Parse(node4.SelectSingleNode("power").InnerText);
                            int num7 = int.Parse(node4.SelectSingleNode("holography").InnerText);
                            if (num2 == 1)
                            {
                                if (((num5 > 1) || (num6 > 1)) && (((num7 == 0) && (num3 < 50)) && (num4 < this.iSellPrice)))
                                {
                                    if (num == 0)
                                    {
                                        str = str + node4.SelectSingleNode("serial_id").InnerText;
                                    }
                                    else
                                    {
                                        str = str + "," + node4.SelectSingleNode("serial_id").InnerText;
                                    }
                                    object obj2 = str5;
                                    str5 = string.Concat(new object[] { obj2, "ID:", node4.ChildNodes[1].InnerText, " lv:", num2, "/", num3, "  atk/hp:", num6, "/", num5, "\r\n" });
                                    num++;
                                }
                            }
                            else if ((num3 < 50) && (num2 < 30))
                            {
                                if (num == 0)
                                {
                                    str = str + node4.SelectSingleNode("serial_id").InnerText;
                                }
                                else
                                {
                                    str = str + "," + node4.SelectSingleNode("serial_id").InnerText;
                                }
                                object obj3 = str5;
                                str5 = string.Concat(new object[] { obj3, "ID:", node4.ChildNodes[1].InnerText, " lv:", num2, "//", num3, "  atk/hp:", num6, "//", num5, "\r\n" });
                                num++;
                            }
                            if (num == 30)
                            {
                                this.actionlog.Text = this.actionlog.Text + str5 + "\r\n";
                                if (-1 == this.sellcard(str))
                                {
                                    this.ibuyCount = 0;
                                    return;
                                }
                                num = 0;
                                str = "";
                                str5 = "卖：\r\n";
                            }
                        }
                        if (str != "")
                        {
                            this.actionlog.Text = this.actionlog.Text + str5;
                            if (-1 == this.sellcard(str))
                            {
                                this.ibuyCount = 0;
                                return;
                            }
                        }
                        this.ibuyCount = 0;
                        this.buy(iProduct, icount);
                    }
                }
            }
        }

        private void ChangeCard(int inum)
        {
            if (this.inowcard == inum)
            {
                return;
            }
            carddeck carddeck = this.cardset.getdeck(inum);
            if (carddeck == null)
            {
                return;
            }
            string toEstr = carddeck.ToString();
            string str2 = carddeck.getLeader();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("C", this.Encrypt(toEstr, this.key12));
            parameters.Add("lr", this.Encrypt(str2, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/cardselect/savedeckcard?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_00EC:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00EC;
            }
            this.inowcard = inum;
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            string text = this.actionlog.Text;
            this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]换卡：" + carddeck.name + "\r\n";
            this.actionlog.WriteInfo("换卡：" + carddeck.name + "\r\n");
        }

        private void ChangeCard(int inum, int scardnum)
        {
            if (this.inowcard == inum)
            {
                return;
            }
            carddeck carddeck = this.cardset.getdeck(inum);
            if (carddeck == null)
            {
                return;
            }
            string toEstr = carddeck.ToString();
            string str2 = carddeck.getLeader();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("C", this.Encrypt(toEstr, this.key12));
            parameters.Add("lr", this.Encrypt(str2, this.key12));
            parameters.Add("no", this.Encrypt(scardnum.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/cardselect/savedeckcard?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_010C:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_010C;
            }
            this.inowcard = inum;
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            string text = this.actionlog.Text;
            this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]换卡：" + carddeck.name + "\r\n";
            this.actionlog.WriteInfo(string.Concat(new object[] { "换卡：", scardnum, "-", carddeck.name, "\r\n" }));
        }

        private void ChangeCard(string szcard, string szleader)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("C", this.Encrypt(szcard, this.key12));
            parameters.Add("lr", this.Encrypt(szleader, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/cardselect/savedeckcard?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_009F:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_009F;
            }
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            string text = this.actionlog.Text;
            this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]换卡：" + szleader + "\r\n";
            this.actionlog.WriteInfo("换卡：" + szleader + "\r\n");
        }

        private int changejob(int i)
        {
            string str;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("jid", this.Encrypt(i.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/job/change_job?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            switch (i)
            {
                case 1:
                    str = "士兵|" + this.lv;
                    break;

                case 2:
                    str = "武斗|" + this.lv;
                    break;

                case 3:
                    str = "操纵|" + this.lv;
                    break;

                case 4:
                    str = "弓手|" + this.lv;
                    break;

                case 5:
                    str = "(推荐)风水|" + this.lv;
                    break;

                case 6:
                    str = "曜魔|" + this.lv;
                    break;

                case 7:
                    str = "会长|" + this.lv;
                    break;

                case 8:
                    str = "妹妹|" + this.lv;
                    break;

                case 9:
                    str = "雀鬼|" + this.lv;
                    break;

                default:
                    str = "??|" + this.lv;
                    break;
            }
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return -2;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                this.actionlog.Text = this.actionlog.Text + "更换职业：" + str + "\r\n";
            }
            return 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.bxiap = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.bAutoChange = this.checkBox2.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.bAutojob = this.checkBox4.Checked;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        private void closeThread()
        {
            if (this.bThreadAttack)
            {
                this.bThreadAttack = false;
                Thread.Sleep(0x3e8);
                this.AttackThread.Abort();
            }
            if (this.bThreadMain)
            {
                this.bThreadMain = false;
                Thread.Sleep(0x3e8);
                this.MainThread.Abort();
            }
            if (this.bThreadRank)
            {
                this.bThreadRank = false;
                Thread.Sleep(0x3e8);
                this.RankThread.Abort();
            }
            if (this.bThreadExplore)
            {
                this.bThreadExplore = false;
                Thread.Sleep(0x3e8);
                this.ExploreThread.Abort();
            }
            if (this.bThreadRigist)
            {
                this.bNoLimitedBC = false;
                Thread.Sleep(0x3e8);
                this.RigistThread.Abort();
            }
            if (this.bThreadEx)
            {
                this.bThreadEx = false;
                Thread.Sleep(0x3e8);
                this.ExThread.Abort();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.comboBox1.Items != null) && (this.comboBox1.Items.Count > 0)) && (this.comboBox1.SelectedItem != null))
            {
                string text = ((ComboBoxItem) this.comboBox1.SelectedItem).Text;
                object obj2 = ((ComboBoxItem) this.comboBox1.SelectedItem).Value;
                this.AreaName = text;
                this.iAreaID = (int) obj2;
                this.GetFloorIfo();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.comboBox2.Items != null) && (this.comboBox2.Items.Count > 0)) && (this.comboBox2.SelectedItem != null))
            {
                string text = ((ComboBoxItem) this.comboBox2.SelectedItem).Text;
                object obj2 = ((ComboBoxItem) this.comboBox2.SelectedItem).Value;
                this.changejob((int) obj2);
                this.ichose = (int) obj2;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.comboBox3.Items != null) && (this.comboBox3.Items.Count > 0)) && (this.comboBox3.SelectedItem != null))
            {
                string text = ((ComboBoxItem) this.comboBox3.SelectedItem).Text;
                this.szFloor = ((ComboBoxItem) this.comboBox3.SelectedItem).Value.ToString();
            }
        }

        private void compound(string szbase, string dogfood)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("add_serial_id", this.Encrypt(dogfood, this.key12));
            parameters.Add("base_serial_id", this.Encrypt(szbase, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/compound/buildup/compound?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_009F:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_009F;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node != null)
                {
                    XmlNodeList list = null;
                    try
                    {
                        list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                        if (list != null)
                        {
                            this.cardlist = list;
                        }
                        foreach (XmlNode node2 in list)
                        {
                            string innerText = node2.SelectSingleNode("serial_id").InnerText;
                            if (innerText == szbase)
                            {
                                int num = int.Parse(node2.SelectSingleNode("lv").InnerText);
                                int num2 = int.Parse(node2.SelectSingleNode("lv_max").InnerText);
                                int num3 = int.Parse(node2.SelectSingleNode("hp").InnerText);
                                int num4 = int.Parse(node2.SelectSingleNode("power").InnerText);
                                int.Parse(node2.SelectSingleNode("holography").InnerText);
                                object text = this.actionlog.Text;
                                this.actionlog.Text = string.Concat(new object[] { text, "合成成功：", innerText, " lv:", num, "/", num2, " HP:", num3, " ATK:", num4, "\r\n" });
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        public XmlDocument CreatePostHttpResponse(string url, IDictionary<string, string> parameters, int? timeout, string userAgent, Encoding requestEncoding, CookieCollection cookies)
        {
            Encoding encoding;
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }
            if (requestEncoding == null)
            {
                encoding = Encoding.Default;
            }
            else
            {
                encoding = requestEncoding;
            }
            HttpWebRequest request = null;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(Form1.CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version11;
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ServicePoint.Expect100Continue = false;
            if (!string.IsNullOrEmpty(userAgent))
            {
                request.UserAgent = userAgent;
            }
            else
            {
                request.UserAgent = this.DefaultUserAgent;
            }
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            request.KeepAlive = true;
            if (timeout.HasValue)
            {
                request.Timeout = timeout.Value;
            }
            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            request.Expect = null;
            StringBuilder builder = new StringBuilder();
            if ((parameters != null) && (parameters.Count != 0))
            {
                int num = 0;
                foreach (string str in parameters.Keys)
                {
                    string str2 = parameters[str].Replace("=", "%3D").Replace("+", "%2B").Replace("/", "%2F");
                    if (str2.Substring(str2.Length - 3) != "%0A")
                    {
                        if (num > 0)
                        {
                            builder.AppendFormat("&{0}={1}%0A", str, str2);
                        }
                        else
                        {
                            builder.AppendFormat("{0}={1}%0A", str, str2);
                        }
                    }
                    else if (num > 0)
                    {
                        builder.AppendFormat("&{0}={1}", str, str2);
                    }
                    else
                    {
                        builder.AppendFormat("{0}={1}", str, str2);
                    }
                    num++;
                }
            }
            byte[] bytes = encoding.GetBytes(builder.ToString());
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream responseStream = response.GetResponseStream();
            int contentLength = (int) response.ContentLength;
            bytes = null;
            int count = 0x64000;
            if (contentLength < 0)
            {
                bytes = new byte[count];
                MemoryStream stream3 = new MemoryStream();
                for (int i = responseStream.Read(bytes, 0, count); i > 0; i = responseStream.Read(bytes, 0, count))
                {
                    stream3.Write(bytes, 0, i);
                }
                bytes = stream3.ToArray();
                stream3.Close();
            }
            else
            {
                bytes = new byte[contentLength];
                int offset = 0;
                while (contentLength > 0)
                {
                    int num6 = responseStream.Read(bytes, offset, contentLength);
                    offset += num6;
                    contentLength -= num6;
                }
            }
            response.Close();
            XmlDocument document = null;
            int length = bytes.Length;
            try
            {
                document = new XmlDocument();
                int num8 = (this.iServer == 0) ? 0x590 : 0x440;
                if ((length == num8) && (url != ("http://" + this.szhostport + "/connect/app/friend/remove_friend?cyt=1")))
                {
                    this.actionlog.Text = this.actionlog.Text + "掉线\r\n";
                    if ((this.LoginType == 0) && !this.blogining)
                    {
                        this.actionlog.Text = this.actionlog.Text + "自动重连\r\n";
                        this.blogining = true;
                        if (!this.Login())
                        {
                            this.actionlog.Text = this.actionlog.Text + "失败\r\n";
                        }
                        Thread.Sleep(0x1388);
                        this.blogining = false;
                    }
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            if ((((url == ("http://" + this.szhostport + "/connect/app/mainmenu?cyt=1")) || (url == ("http://" + this.szhostport + "/connect/app/regist?cyt=1"))) || ((url == ("http://" + this.szhostport + "/connect/app/tutorial/next?cyt=1")) || (url == ("http://" + this.szhostport + "/connect/app/tutorial/save_character?cyt=1")))) || ((url == ("http://" + this.szhostport + "/connect/app/login?cyt=1")) || (length == 0x580)))
            {
                document.LoadXml(this.Decrypt(bytes, this.key0));
                return document;
            }
            if ((url == ("http://" + this.szhostport + "/connect/app/friend/remove_friend?cyt=1")) || (url == ("http://" + this.szhostport + "/connect/app/friend/add_friend?cyt=1")))
            {
                document.LoadXml(this.Decrypt(bytes, this.key11));
                return document;
            }
            document.LoadXml(this.Decrypt(bytes, this.key12));
            return document;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                carddeck carddeck = this.cardset.getdeck(e.RowIndex);
                this.actionlog.Text = this.actionlog.Text + "开始换卡:" + carddeck.name + "\r\n";
                this.ChangeCard(carddeck.ToString(), carddeck.getLeader());
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (columnIndex == 0)
            {
                carddeck newdeck = this.cardset.getdeck(rowIndex);
                newdeck.name = this.cardset.Rows[rowIndex][0].ToString();
                this.cardset.UpdateDeck(newdeck, rowIndex);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if ((rowIndex >= 0) && (rowIndex < this.allcards.Rows.Count))
                {
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox1.Image = new Bitmap(this.allcards.PngList[rowIndex]);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                if ((rowIndex >= 0) && (rowIndex < this.allcards.Rows.Count))
                {
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox1.Image = new Bitmap(this.allcards.PngList[rowIndex]);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.CardChose.saveconfig();
            this.cardc = this.CardChose.getDeckNum(this.lv);
        }

        private void dataGridView4_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        public string Decrypt(string toDstr, string key)
        {
            byte[] toDstrArray = Convert.FromBase64String(toDstr);
            return this.Decrypt(toDstrArray, key);
        }

        public string Decrypt(byte[] toDstrArray, string key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.ECB,
                Key = bytes
            };
            AesManaged managed = managed2;
            int blockSize = managed.BlockSize;
            ICryptoTransform transform = managed.CreateDecryptor();
            try
            {
                byte[] buffer2 = transform.TransformFinalBlock(toDstrArray, 0, toDstrArray.Length);
                return Encoding.UTF8.GetString(buffer2);
            }
            catch (CryptographicException exception)
            {
                return exception.Message;
            }
        }

        public string Decrypt2(string toDstr, string key)
        {
            byte[] toDstrArray = Convert.FromBase64String(toDstr);
            return this.Decrypt(toDstrArray, key);
        }

        public byte[] DecryptB(byte[] toDstrArray, string key, int i)
        {
            byte[] buffer = null;
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged {
                Padding = PaddingMode.None,
                Mode = CipherMode.ECB,
                Key = bytes
            };
            ICryptoTransform transform = managed2.CreateDecryptor();
            try
            {
                buffer = transform.TransformFinalBlock(toDstrArray, 0, i);
            }
            catch (CryptographicException exception)
            {
                string message = exception.Message;
            }
            return buffer;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void EnableLoint(bool blogin)
        {
            if (!blogin)
            {
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.button1.Enabled = false;
                this.button2.Enabled = true;
                this.radioButton8.Enabled = false;
                
            }
            else
            {
                this.textBox1.Enabled = true;
                this.radioButton1.Enabled = true;
                this.radioButton2.Enabled = true;
                this.textBox2.Enabled = this.radioButton1.Checked;
                this.textBox3.Enabled = this.radioButton2.Checked;
                this.LoginType = this.radioButton1.Checked ? 0 : 1;
                this.button2.Enabled = false;
                this.button1.Enabled = true;
                this.radioButton8.Enabled = true;
                
            }
        }

        public string Encrypt(byte[] toEstrArray, string key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged {
                Padding = PaddingMode.None,
                Mode = CipherMode.ECB,
                Key = bytes
            };
            ICryptoTransform transform = managed2.CreateEncryptor();
            try
            {
                byte[] inArray = transform.TransformFinalBlock(toEstrArray, 0, toEstrArray.Length);
                return Convert.ToBase64String(inArray, 0, inArray.Length);
            }
            catch (CryptographicException exception)
            {
                return exception.Message;
            }
        }

        public string Encrypt(string toEstr, string key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(toEstr);
            byte[] buffer2 = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.ECB,
                Key = buffer2
            };
            ICryptoTransform transform = managed2.CreateEncryptor();
            try
            {
                byte[] inArray = transform.TransformFinalBlock(bytes, 0, bytes.Length);
                return Convert.ToBase64String(inArray, 0, inArray.Length);
            }
            catch (CryptographicException exception)
            {
                return exception.Message;
            }
        }

        private int explore()
        {
            int num = -1;
            int num2 = 0;
            if (this.iAreaID == 0)
            {
                this.GetAreaIfo();
            }
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string str = this.bAtoBuild ? "1" : "0";
            parameters.Add("area_id", this.Encrypt(this.iAreaID.ToString(), this.key12));
            parameters.Add("auto_build", this.Encrypt(str.ToString(), this.key12));
            parameters.Add("floor_id", this.Encrypt(this.szFloor, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/exploration/guild_explore?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0106:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0106;
            }
            if (document != null)
            {
                document.Save("explore.xml");
                string message = "移动：";
                try
                {
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("exploration_area");
                    if (node != null)
                    {
                        if (this.bliqu)
                        {
                            XmlNodeList list = node.SelectSingleNode("area_info_list").SelectNodes("area_info");
                            this.iAreaID = int.Parse(list[0].SelectSingleNode("id").InnerText);
                            this.AreaName = list[0].SelectSingleNode("name").InnerText;
                            if (!this.bAutoChange)
                            {
                                foreach (XmlNode node2 in list)
                                {
                                    int num3 = int.Parse(node2.SelectSingleNode("id").InnerText);
                                    if ((this.iAreaID / 100) == (num3 / 100))
                                    {
                                        this.iAreaID = num3;
                                        this.AreaName = node2.SelectSingleNode("name").InnerText;
                                    }
                                }
                            }
                            this.szFloor = "1";
                            message = message + "里表区切换 ; ";
                            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                            {
                                message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                            }
                            string str4 = this.actionlog.Text;
                            this.actionlog.Text = str4 + "[" + DateTime.Now.ToString() + "]" + message;
                            this.actionlog.WriteInfo(message);
                        }
                        return num2;
                    }
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        string str5 = this.actionlog.Text;
                        this.actionlog.Text = str5 + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                        return num2;
                    }
                    num = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("event_type").InnerText);
                    switch (num)
                    {
                        case 1:
                        case 0x16:
                            this.actionlog.Text = this.actionlog.Text + "发现妖精\r\n";
                            this.bExplore = false;
                            break;
                    }
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node3 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    this.szCharName = node3.SelectSingleNode("name").InnerText;
                    XmlNode node4 = node3.SelectSingleNode("bc");
                    int aP = this.AP;
                    int bC = this.BC;
                    this.BC = int.Parse(node4.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node4.SelectSingleNode("max").InnerText);
                    XmlNode node5 = node3.SelectSingleNode("ap");
                    this.AP = int.Parse(node5.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node5.SelectSingleNode("max").InnerText);
                    int num6 = int.Parse(node3.SelectSingleNode("town_level").InnerText);
                    if (this.iuserLevel != num6)
                    {
                        this.iuserLevel = num6;
                        object obj2 = this.actionlog.Text;
                        this.actionlog.Text = string.Concat(new object[] { obj2, "升级：Lv", this.iuserLevel, "\r\n" });
                        this.bxiap = true;
                    }
                    int num7 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("progress").InnerText);
                    XmlNode node6 = node3.SelectSingleNode("owner_card_list");
                    if (node6 != null)
                    {
                        XmlNodeList list2 = node6.SelectNodes("user_card");
                        if (list2.Count != 0)
                        {
                            this.cardlist = list2;
                        }
                    }
                    XmlNode node7 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("guild_fairy_state");
                    if (node7 != null)
                    {
                        num2 = int.Parse(node7.SelectSingleNode("fairy_state").InnerText);
                    }
                    object obj3 = message;
                    message = string.Concat(new object[] { obj3, this.AreaName, "|", this.szFloor, "|", this.ilowap, "|", num7, "-" });
                    message = message + "事件ID:" + num.ToString();
                    string str6 = message;
                    message = str6 + "  AP:" + aP.ToString() + "-" + this.AP.ToString() + " BC:" + bC.ToString() + "-" + this.BC.ToString() + "\r\n";
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                    if (num7 != 100)
                    {
                        return num2;
                    }
                    XmlNode node8 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("next_floor");
                    if ((node8 != null) && (this.comboBox3.SelectedIndex == (this.comboBox3.Items.Count - 1)))
                    {
                        this.GetFloorIfo();
                        this.comboBox3.SelectedIndex = this.comboBox3.Items.Count - 2;
                    }
                    if (!this.bAutoChange)
                    {
                        return num2;
                    }
                    if (node8 != null)
                    {
                        this.comboBox3.SelectedIndex = this.comboBox3.Items.Count - 1;
                        return num2;
                    }
                    this.GetAreaIfo();
                }
                catch (Exception exception)
                {
                    message = message + exception.Message + "\r\n";
                    string str8 = this.actionlog.Text;
                    this.actionlog.Text = str8 + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
            }
            return num2;
        }

        private int explore_1()
        {
            int num = -1;
            int num2 = 0;
            if (this.iAreaID == 0)
            {
                this.GetAreaIfo();
            }
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            this.bAtoBuild = this.checkBox7.Checked;
            string str = this.bAtoBuild ? "1" : "0";
            parameters.Add("area_id", this.Encrypt(this.iAreaID.ToString(), this.key12));
            parameters.Add("auto_build", this.Encrypt(str.ToString(), this.key12));
            parameters.Add("floor_id", this.Encrypt(this.szFloor, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/exploration/explore?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0117:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0117;
            }
            if (document != null)
            {
                string message = "移动：";
                try
                {
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("exploration_area");
                    document.Save("explore1.xml");
                    if (node != null)
                    {
                        if (this.bliqu)
                        {
                            XmlNodeList list = node.SelectSingleNode("area_info_list").SelectNodes("area_info");
                            this.iAreaID = int.Parse(list[0].SelectSingleNode("id").InnerText);
                            this.AreaName = list[0].SelectSingleNode("name").InnerText;
                            if (!this.bAutoChange)
                            {
                                foreach (XmlNode node2 in list)
                                {
                                    int num3 = int.Parse(node2.SelectSingleNode("id").InnerText);
                                    if ((this.iAreaID / 100) == (num3 / 100))
                                    {
                                        this.iAreaID = num3;
                                        this.AreaName = node2.SelectSingleNode("name").InnerText;
                                    }
                                }
                            }
                            this.szFloor = "1";
                            message = message + "里表区切换 ; ";
                            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                            {
                                message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                            }
                            string str4 = this.actionlog.Text;
                            this.actionlog.Text = str4 + "[" + DateTime.Now.ToString() + "]" + message;
                            this.actionlog.WriteInfo(message);
                        }
                        return num2;
                    }
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        string str5 = this.actionlog.Text;
                        this.actionlog.Text = str5 + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                        return num2;
                    }
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node3 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    this.szCharName = node3.SelectSingleNode("name").InnerText;
                    XmlNode node4 = node3.SelectSingleNode("bc");
                    int aP = this.AP;
                    int bC = this.BC;
                    this.BC = int.Parse(node4.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node4.SelectSingleNode("max").InnerText);
                    XmlNode node5 = node3.SelectSingleNode("ap");
                    this.AP = int.Parse(node5.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node5.SelectSingleNode("max").InnerText);
                    num = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("event_type").InnerText);
                    int num6 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("progress").InnerText);
                    XmlNode node6 = node3.SelectSingleNode("owner_card_list");
                    if (node6 != null)
                    {
                        XmlNodeList list2 = node6.SelectNodes("user_card");
                        if (list2.Count != 0)
                        {
                            this.cardlist = list2;
                        }
                    }
                    XmlNode node7 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("guild_fairy_state");
                    if (node7 != null)
                    {
                        num2 = int.Parse(node7.SelectSingleNode("fairy_state").InnerText);
                    }
                    object obj2 = message;
                    message = string.Concat(new object[] { obj2, this.AreaName, "|", this.szFloor, "|", this.ilowap, "|", num6, "-" });
                    string str6 = "";
                    if (num == 1)
                    {
                        this.bExplore = false;
                        XmlNode node8 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("fairy");
                        this.iMasterBossID = int.Parse(node8.SelectSingleNode("serial_id").InnerText);
                        str6 = "lv" + node8.SelectSingleNode("lv").InnerText + node8.SelectSingleNode("name").InnerText + " HP:" + node8.SelectSingleNode("hp").InnerText;
                    }
                    switch (num)
                    {
                        case 12:
                            message = message + "AP回复";
                            break;

                        case 13:
                            message = message + "BC回复";
                            break;

                        case 15:
                            message = message + "合成卡片";
                            break;

                        case 0x13:
                            message = message + "发现道具";
                            break;

                        case 1:
                            message = message + "发现妖精" + str6;
                            break;

                        case 3:
                            message = message + "发现卡片";
                            break;

                        case 6:
                            message = message + "AP不足";
                            break;

                        default:
                            message = message + "事件ID:" + num.ToString();
                            break;
                    }
                    string str7 = message;
                    message = str7 + "  AP:" + aP.ToString() + "-" + this.AP.ToString() + " BC:" + bC.ToString() + "-" + this.BC.ToString() + "\r\n";
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                    if (num6 != 100)
                    {
                        return num;
                    }
                    XmlNode node9 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("explore").SelectSingleNode("next_floor");
                    if ((node9 != null) && (this.comboBox3.SelectedIndex == (this.comboBox3.Items.Count - 1)))
                    {
                        this.GetFloorIfo();
                        this.comboBox3.SelectedIndex = this.comboBox3.Items.Count - 2;
                    }
                    if (!this.bAutoChange)
                    {
                        return num;
                    }
                    if (node9 != null)
                    {
                        this.comboBox3.SelectedIndex = this.comboBox3.Items.Count - 1;
                        return num;
                    }
                    this.GetAreaIfo();
                }
                catch (Exception exception)
                {
                    message = message + exception.Message + "\r\n";
                    string str9 = this.actionlog.Text;
                    this.actionlog.Text = str9 + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
            }
            return num;
        }

        private void ExploreMethod(object sender, EventArgs e)
        {
            this.button7.Enabled = false;
            int num = this.getapbc();
            while (num == 3)
            {
                this.getapbc();
            }
            if (this.AP >= this.ilowap)
            {
                do
                {
                    if (this.AP < this.ilowap)
                    {
                        break;
                    }
                }
                while (3 != this.explore());
            }
            else if (this.radioButton7.Checked)
            {
                this.useitem(1);
                do
                {
                    if (this.AP < this.ilowap)
                    {
                        break;
                    }
                }
                while (3 != this.explore());
            }
            else if (this.radioButton6.Checked)
            {
                this.useitem(0x65);
                while ((this.AP >= this.ilowap) && (3 != this.explore()))
                {
                }
            }
            this.button7.Enabled = true;
        }

        private int fairybattle(int iU, int iS)
        {
            int num = -1;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("serial_id", this.Encrypt(iS.ToString(), this.key12));
            parameters.Add("user_id", this.Encrypt(iU.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/exploration/fairybattle?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return num;
            }
            this.bWinner = false;
            if (document != null)
            {
                string message = "战斗：";
                try
                {
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        string szActionLog = this.szActionLog;
                        szActionLog = szActionLog + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                        return 0x3e9;
                    }
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    XmlNode node2 = node.SelectSingleNode("bc");
                    int bC = this.BC;
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                    string str4 = message;
                    message = str4 + " BC:" + bC.ToString() + "->" + this.BC.ToString() + " ";
                    int num3 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("before_exp").InnerText);
                    int num4 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("after_exp").InnerText);
                    this.bWinner = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("winner").InnerText) == 1;
                    num = 0;
                    BattleLog item = new BattleLog(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_battle"), this.lv, 0, 0);
                    this.Battles.Add(item);
                    this.listBox1.Items.Add(item);
                    this.listBox1.DisplayMember = "Text";
                    this.listBox1.ValueMember = "Value";
                    if (this.bWinner)
                    {
                        message = message + "-战斗胜利-";
                    }
                    string str5 = message;
                    message = str5 + "经验" + num3.ToString() + "->" + num4.ToString();
                    XmlNode node4 = null;
                    try
                    {
                        node4 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("special_item");
                    }
                    catch (Exception)
                    {
                        message = message + "\r\n";
                    }
                    if (node4 != null)
                    {
                        try
                        {
                            int num5 = int.Parse(node4.SelectSingleNode("before_count").InnerText);
                            int num6 = int.Parse(node4.SelectSingleNode("after_count").InnerText);
                            string str6 = message;
                            string[] strArray = new string[] { str6, "收集道具：", (num6 - num5).ToString(), "->", num6.ToString(), "\r\n" };
                            message = string.Concat(strArray);
                        }
                        catch (Exception)
                        {
                            message = message + "\r\n";
                        }
                    }
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
                catch (Exception exception)
                {
                    message = message + exception.Message + "\r\n";
                    string str8 = this.szActionLog;
                    this.szActionLog = str8 + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
            }
            return num;
        }

        private void fairytop(int iuser, int iserial)
        {
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("serial_id", this.Encrypt(iserial.ToString(), this.key12));
            parameters.Add("user_id", this.Encrypt(iuser.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/private_fairy/private_fairy_top?cyt=1";
            XmlDocument document = null;
        Label_00AA:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00AA;
            }
            try
            {
                document.Save("fairytop.xml");
            }
            catch (Exception)
            {
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.closeThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.userlist.Add("ayaseuz");
            this.userlist.Add("ayasuez161");
            this.userlist.Add("lllpla1");
            this.userlist.Add("lllpla2");
            this.userlist.Add("lllpla3");
            this.userlist.Add("lllpla4");
            this.userlist.Add("lllpla5");
            this.userlist.Add("lllpla6");
            this.userlist.Add("lllpla7");
            this.userlist.Add("lllpla8");
            this.userlist.Add("lllpla9");
            this.userlist.Add("13516610800");
            this.userlist.Add("85990");
            this.userlist.Add("85991");
            this.userlist.Add("85992");
            this.userlist.Add("85993");
            this.userlist.Add("85994");
            this.userlist.Add("85995");
            this.userlist.Add("85996");
            this.userlist.Add("85997");
            this.userlist.Add("85998");
            this.userlist.Add("85999");
            this.userlist.Add("85988");
            this.userlist.Add("85989");
            this.userlist.Add("coleka");
            this.userlist.Add("robin0857");
            this.userlist.Add("1047535054");
            this.userlist.Add("hanshang426");
            this.userlist.Add("hanshang742");
            this.userlist.Add("kuangsan963");
            this.userlist.Add("FATDN");
            this.userlist.Add("kasame");
            this.userlist.Add("hentaisama997");
            this.userlist.Add("cqfcry0305");
            this.userlist.Add("SherlockSSH");
            this.userlist.Add("xxooorange");
            this.cardset = new CardSet();
            this.allcards = new cards();
            this.Rewardbox = new rewardbox();
            this.CardChose = new cardchose();
            this.Battles = new List<BattleLog>();
            this.textBoxLog.DataBindings.Add("Text", this.actionlog, "Text", false, DataSourceUpdateMode.OnPropertyChanged);
            this.logbind.DataBindings.Add("str", this.actionlog, "Text", false, DataSourceUpdateMode.OnPropertyChanged);
            this.dataGridView1.DataSource = this.cardset;
            this.dataGridView2.DataSource = this.allcards;
            this.dataGridView3.DataSource = this.Rewardbox;
            this.dataGridView4.DataSource = this.CardChose;
            this.dataGridView1.Columns[0].ReadOnly = false;
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                if (i > 0)
                {
                    this.dataGridView1.Columns[i].ReadOnly = true;
                }
                this.dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int j = 0; j < this.dataGridView2.Columns.Count; j++)
            {
                this.dataGridView2.Columns[j].SortMode = DataGridViewColumnSortMode.NotSortable;
                this.dataGridView2.Columns[j].ReadOnly = true;
                this.dataGridView2.Columns[j].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int k = 0; k < this.dataGridView3.Columns.Count; k++)
            {
                this.dataGridView3.Columns[k].ReadOnly = true;
                this.dataGridView3.Columns[k].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            for (int m = 0; m < this.dataGridView4.Columns.Count; m++)
            {
                this.dataGridView4.Columns[m].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.dataGridView4.Columns[m].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private int getapbc()
        {
            if (this.iAreaID == 0)
            {
                this.GetAreaIfo();
            }
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string str = "1";
            parameters.Add("area_id", this.Encrypt(this.iAreaID.ToString(), this.key12));
            parameters.Add("check", this.Encrypt(str.ToString(), this.key12));
            parameters.Add("floor_id", this.Encrypt(this.szFloor.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/exploration/get_floor?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_00F4:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00F4;
            }
            if (document == null)
            {
                return 0;
            }
            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
            {
                return 0;
            }
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
            this.szCharName = node.SelectSingleNode("name").InnerText;
            XmlNode node2 = node.SelectSingleNode("bc");
            this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
            this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
            XmlNode node3 = node.SelectSingleNode("ap");
            this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
            this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
            XmlNode node4 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("get_floor");
            this.ilowap = int.Parse(node4.SelectSingleNode("floor_info").SelectSingleNode("cost").InnerText);
            this.AreaName = node4.SelectSingleNode("area_name").InnerText;
            XmlNode node5 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("guild_fairy_state");
            int num = 0;
            if (node5 != null)
            {
                num = int.Parse(node5.SelectSingleNode("fairy_state").InnerText);
            }
            return num;
        }

        private void GetApple()
        {
            if (this.iServer == 1)
            {
                this.baseKey = "rBwj1MIAivVN222b";
            }
            else
            {
                this.baseKey = "uH9JF2cHf6OppaC1";
            }
        }

        private void GetAreaIfo()
        {
            string url = "http://" + this.szhostport + "/connect/app/exploration/area?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            this.actionlog.Text = this.actionlog.Text + "更新地图~啊呜\r\n";
        Label_006B:;
            try
            {
                document = this.CreatePostHttpResponse(url, null, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_006B;
            }
            this.areaxml = document;
            if (document != null)
            {
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("exploration_area").SelectSingleNode("area_info_list");
                this.comboBox1.Items.Clear();
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    if (node2.SelectSingleNode("area_type").InnerText == "0")
                    {
                        break;
                    }
                    int num = int.Parse(node2.SelectSingleNode("id").InnerText);
                    ComboBoxItem item2 = new ComboBoxItem {
                        Value = num,
                        Text = node2.SelectSingleNode("name").InnerText
                    };
                    ComboBoxItem item = item2;
                    this.comboBox1.Items.Add(item);
                }
                if (this.comboBox1.Items.Count > 0)
                {
                    this.comboBox1.SelectedIndex = 0;
                }
            }
            this.actionlog.Text = this.actionlog.Text + "更新成功(∩_∩)\r\n";
        }

        private carddeck getdeck()
        {
            carddeck carddeck = null;
            string url = "http://" + this.szhostport + "/connect/app/roundtable/edit?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("move", this.Encrypt("1", this.key12));
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return null;
            }
            if (document == null)
            {
                return carddeck;
            }
            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
            {
                return null;
            }
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            return new carddeck(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("roundtable_edit").SelectSingleNode("deck").SelectSingleNode("deck_cards").InnerText, document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("roundtable_edit").SelectSingleNode("deck").SelectSingleNode("leader_card").InnerText);
        }

        private void getFairyFloor(int iuser, int ifairy)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("check", this.Encrypt("1", this.key12));
            parameters.Add("serial_id", this.Encrypt(ifairy.ToString(), this.key12));
            parameters.Add("user_id", this.Encrypt(iuser.ToString(), this.key12));
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/exploration/fairy_floor?cyt=1";
            XmlDocument document = null;
        Label_00C7:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00C7;
            }
            try
            {
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("fairy_floor").SelectSingleNode("explore").SelectSingleNode("fairy");
                this.hp = int.Parse(node.SelectSingleNode("hp").InnerText);
                this.lv = int.Parse(node.SelectSingleNode("lv").InnerText);
                this.hp_max = int.Parse(node.SelectSingleNode("hp_max").InnerText);
            }
            catch (Exception)
            {
            }
        }

        private int getFairyIfo()
        {
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/menu/fairyselect?cyt=1";
            XmlDocument document = null;
        Label_004A:;
            try
            {
                document = this.CreatePostHttpResponse(url, null, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_004A;
            }
            try
            {
                document.Save("fairy.xml");
                XmlNodeList list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("fairy_select").SelectNodes("fairy_event");
                bool flag = true;
                foreach (XmlNode node in list)
                {
                    string innerText = node.SelectSingleNode("user").SelectSingleNode("name").InnerText;
                    int iuser = int.Parse(node.SelectSingleNode("user").SelectSingleNode("id").InnerText);
                    string str3 = node.SelectSingleNode("fairy").SelectSingleNode("name").InnerText;
                    int ifairy = int.Parse(node.SelectSingleNode("fairy").SelectSingleNode("serial_id").InnerText);
                    int num3 = int.Parse(node.SelectSingleNode("fairy").SelectSingleNode("lv").InnerText);
                    bool flag2 = int.Parse(node.SelectSingleNode("put_down").InnerText) == 1;
                    if ((iuser == this.iNowUserid) && flag2)
                    {
                        flag = false;
                    }
                    if (flag2)
                    {
                        if (!this.bExplore)
                        {
                            if ((this.BC > (this.MaxBc - 10)) && (iuser == this.iNowUserid))
                            {
                                this.getFairyFloor(iuser, ifairy);
                                this.ChangeCard(this.CardChose.ibase3cardnum);
                                string text = this.actionlog.Text;
                                this.actionlog.Text = text + "攻击：" + innerText + "-lv" + num3.ToString() + str3 + "\r\n";
                                this.lv = num3;
                                if (0x3e9 == this.fairybattle(iuser, ifairy))
                                {
                                    break;
                                }
                            }
                            else if (!this.fairylist.Contains(ifairy))
                            {
                                this.ChangeCard(this.CardChose.iwolfmusumecardnum);
                                string str5 = this.actionlog.Text;
                                this.actionlog.Text = str5 + "攻击：" + innerText + "-lv" + num3.ToString() + str3 + "\r\n";
                                this.lv = num3;
                                if (0x3e9 == this.fairybattle(iuser, ifairy))
                                {
                                    break;
                                }
                                this.fairylist.Add(ifairy);
                                if (this.fairylist.Count > 30)
                                {
                                    this.fairylist.RemoveAt(0);
                                }
                                Thread.Sleep(0x2710);
                            }
                        }
                        else if ((this.BC > this.CardChose.ibase3cardcost) || (this.BC == this.MaxBc))
                        {
                            this.getFairyFloor(iuser, ifairy);
                            if ((this.hp < 0xea60) && (this.hp != 0))
                            {
                                this.ChangeCard(this.CardChose.ibase3cardnum);
                                string str6 = this.actionlog.Text;
                                this.actionlog.Text = str6 + "攻击：" + innerText + "-lv" + num3.ToString() + str3 + "\r\n";
                                this.lv = num3;
                                if (0x3e9 == this.fairybattle(iuser, ifairy))
                                {
                                    break;
                                }
                                this.fairylist.Add(ifairy);
                                if (this.fairylist.Count > 30)
                                {
                                    this.fairylist.RemoveAt(0);
                                }
                                Thread.Sleep(0x2710);
                            }
                            else if (!this.fairylist.Contains(ifairy))
                            {
                                this.ChangeCard(this.CardChose.iwolfmusumecardnum);
                                string str7 = this.actionlog.Text;
                                this.actionlog.Text = str7 + "攻击：" + innerText + "-lv" + num3.ToString() + str3 + "\r\n";
                                this.lv = num3;
                                if (0x3e9 == this.fairybattle(iuser, ifairy))
                                {
                                    break;
                                }
                                this.fairylist.Add(ifairy);
                                if (this.fairylist.Count > 30)
                                {
                                    this.fairylist.RemoveAt(0);
                                }
                                Thread.Sleep(0x2710);
                            }
                        }
                        else if (!this.fairylist.Contains(ifairy))
                        {
                            this.ChangeCard(this.CardChose.iwolfmusumecardnum);
                            string str8 = this.actionlog.Text;
                            this.actionlog.Text = str8 + "攻击：" + innerText + "-lv" + num3.ToString() + str3 + "\r\n";
                            this.lv = num3;
                            if (0x3e9 == this.fairybattle(iuser, ifairy))
                            {
                                break;
                            }
                            this.fairylist.Add(ifairy);
                            if (this.fairylist.Count > 30)
                            {
                                this.fairylist.RemoveAt(0);
                            }
                            Thread.Sleep(0x2710);
                        }
                    }
                }
                this.bExplore = flag;
            }
            catch (Exception)
            {
                this.serial_id = 0;
            }
            return -1;
        }

        private void getFairyRewards()
        {
            this.button24.Enabled = false;
            this.iNowUserid = this.getuserid();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/menu/fairyrewards?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0086:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0086;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node == null)
                {
                    this.button24.Enabled = true;
                    return;
                }
                this.szCharName = node.SelectSingleNode("name").InnerText;
                XmlNode node2 = node.SelectSingleNode("bc");
                this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                XmlNode node3 = node.SelectSingleNode("ap");
                this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                XmlNodeList list = null;
                this.cardlist = list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                object text = this.actionlog.Text;
                this.actionlog.Text = string.Concat(new object[] { text, "获取妖精奖励 ，总卡：", list.Count, "\r\n" });
            }
            this.button24.Enabled = true;
        }

        private void GetFloorIfo()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("area_id", this.Encrypt(this.iAreaID.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/exploration/floor?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            this.actionlog.Text = this.actionlog.Text + "更新层数\r\n";
        Label_00B1:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00B1;
            }
            this.areaxml = document;
            if (document != null)
            {
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("exploration_floor").SelectSingleNode("floor_info_list");
                this.comboBox3.Items.Clear();
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    try
                    {
                        int num = int.Parse(node2.SelectSingleNode("id").InnerText);
                        int num2 = int.Parse(node2.SelectSingleNode("cost").InnerText);
                        int num3 = int.Parse(node2.SelectSingleNode("progress").InnerText);
                        ComboBoxItem item2 = new ComboBoxItem {
                            Value = num,
                            Text = "区域" + num.ToString() + "|" + num2.ToString() + "|" + num3.ToString()
                        };
                        ComboBoxItem item = item2;
                        this.comboBox3.Items.Add(item);
                    }
                    catch (Exception)
                    {
                    }
                }
                if (this.comboBox3.Items.Count > 0)
                {
                    this.comboBox3.SelectedIndex = 0;
                }
            }
        }

        private int getGuidIFO()
        {
            int num = -1;
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/guild/guild_top?cyt=1";
            XmlDocument document = null;
        Label_004D:;
            try
            {
                document = this.CreatePostHttpResponse(url, null, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_004D;
            }
            try
            {
                document.Save("guild.xml");
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body");
                string name = node.ChildNodes[0].Name;
                if ((name == "guild_top") || (name == "guild_defeat_event"))
                {
                    XmlNode node2 = node.SelectSingleNode(name).SelectSingleNode("guild_top_update");
                    XmlNode node3 = node2.SelectSingleNode("guild_reward_list");
                    if ((node3 != null) && (name == "guild_top"))
                    {
                        this.bBonus = true;
                        string str3 = "";
                        switch (int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_type").InnerText))
                        {
                            case 0x2775:
                                str3 = "白金箱";
                                break;

                            case 0x2776:
                                str3 = "金箱";
                                break;

                            case 0x2777:
                                str3 = "银箱";
                                break;

                            case 0x2778:
                                str3 = "铜箱";
                                break;

                            case 0x2779:
                                str3 = "木箱";
                                break;
                        }
                        int num2 = int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_num").InnerText);
                        string str4 = this.actionlog.Text;
                        this.actionlog.Text = str4 + "[" + DateTime.Now.ToString() + "]发现强敌：获得" + str3 + "*" + num2.ToString() + "\r\n";
                        this.actionlog.WriteInfo("发现强敌：获得" + str3 + "*" + num2.ToString() + "\r\n");
                    }
                    else if (name == "guild_defeat_event")
                    {
                        node3 = node.SelectSingleNode(name).SelectSingleNode("guild_reward_list");
                        string str5 = "";
                        switch (int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_type").InnerText))
                        {
                            case 0x2775:
                                str5 = "白金箱";
                                break;

                            case 0x2776:
                                str5 = "金箱";
                                break;

                            case 0x2777:
                                str5 = "银箱";
                                break;

                            case 0x2778:
                                str5 = "铜箱";
                                break;

                            case 0x2779:
                                str5 = "木箱";
                                break;
                        }
                        int num3 = int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_num").InnerText);
                        this.actionlog.Text = this.actionlog.Text + ((string.Concat(new object[] { "[", DateTime.Now.ToString(), "]", node3 }) != null) ? ("强敌扑街，获得" + str5 + "*" + num3.ToString() + "\r\n") : "强敌扑街\r\n");
                        this.actionlog.WriteInfo((node3 != null) ? ("强敌扑街，获得" + str5 + "*" + num3.ToString() + "\r\n") : "强敌扑街\r\n");
                    }
                    else
                    {
                        this.bBonus = false;
                    }
                    XmlNode node4 = node2.SelectSingleNode("fairy");
                    XmlNode node5 = node2.SelectSingleNode("guild_fairy_weak");
                    if ((node5 != null) && this.bAutojob)
                    {
                        int i = int.Parse(node5.SelectSingleNode("id").InnerText);
                        if ((i != this.iJobID) && (-2 != this.changejob(i)))
                        {
                            this.iJobID = i;
                        }
                    }
                    node2.SelectNodes("guild_log");
                    this.serial_id = int.Parse(node4.SelectSingleNode("serial_id").InnerText);
                    this.lv = int.Parse(node4.SelectSingleNode("lv").InnerText);
                    this.hp = int.Parse(node4.SelectSingleNode("hp").InnerText);
                    this.hp_max = int.Parse(node4.SelectSingleNode("hp_max").InnerText);
                    this.bname = node4.SelectSingleNode("name").InnerText;
                    XmlNode node6 = node2.SelectSingleNode("force_gauge");
                    if (node6 != null)
                    {
                        int num5 = int.Parse(node6.SelectSingleNode("own").InnerText);
                        int num6 = int.Parse(node6.SelectSingleNode("rival").InnerText);
                        int num7 = int.Parse(node6.SelectSingleNode("total").InnerText);
                        this.dWin = (((double) (num5 - num6)) / ((double) num7)) / 2.0;
                    }
                    this.iGuildID = int.Parse(node4.SelectSingleNode("discoverer_id").InnerText);
                    int num8 = int.Parse(node4.SelectSingleNode("time_limit").InnerText);
                    object text = this.actionlog.Text;
                    this.actionlog.Text = string.Concat(new object[] { text, "刷新boss：", this.bname, "__Lv:", this.lv, "__HP", this.hp, "/", this.hp_max, "\r\n" });
                    num = 0;
                    if (int.Parse(node4.SelectSingleNode("master_boss_id").InnerText) == this.iSubBossID)
                    {
                        this.bSub = true;
                        if (((num8 > 0x1ba8) && (DateTime.Now.Hour <= 0x17)) && (DateTime.Now.Hour >= 1))
                        {
                            num = 3;
                        }
                    }
                    else if ((this.iSubBossID == 0) && (this.hp_max < 0xf4240))
                    {
                        this.iSubBossID = int.Parse(node4.SelectSingleNode("master_boss_id").InnerText);
                        this.bSub = true;
                        if (((num8 > 0x1ba8) && (DateTime.Now.Hour <= 0x17)) && (DateTime.Now.Hour >= 1))
                        {
                            num = 3;
                        }
                    }
                    else
                    {
                        this.bSub = false;
                        num = 3;
                    }
                    if (name == "guild_defeat_event")
                    {
                        this.serial_id = 0;
                        num = 4;
                    }
                    return num;
                }
                string str6 = name;
                if (str6 != null)
                {
                    if (!(str6 == "guild_fairy_event"))
                    {
                        if (str6 != "guild_top_no_fairy")
                        {
                            return num;
                        }
                        goto Label_0837;
                    }
                    num = 1;
                    this.actionlog.Text = this.actionlog.Text + "强敌出现\r\n";
                }
                return num;
            Label_0837:
                num = 2;
                this.master_boss_id = int.Parse(node.SelectSingleNode("guild_top_no_fairy").SelectSingleNode("guild_boss").SelectSingleNode("master_boss_id").InnerText);
                this.iSubBossID = int.Parse(node.SelectSingleNode("guild_top_no_fairy").SelectSingleNode("guild_boss").SelectSingleNode("sub_boss_id").InnerText);
                this.hp = 0;
                this.serial_id = 0;
            }
            catch (Exception)
            {
                this.serial_id = 0;
            }
            return num;
        }

        private int getGuildFairyIfo()
        {
            if ((DateTime.Now.Hour < 1) || (DateTime.Now.Hour > 3))
            {
                this.guildEvent();
            }
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/private_fairy/private_fairy_select?cyt=1";
            XmlDocument document = null;
        Label_0082:;
            try
            {
                document = this.CreatePostHttpResponse(url, null, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0082;
            }
            try
            {
                document.Save("fairy.xml");
                XmlNodeList list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("fairy_select").SelectNodes("fairy_event");
                bool flag = true;
                foreach (XmlNode node in list)
                {
                    int iuser = int.Parse(node.SelectSingleNode("fairy").SelectSingleNode("discoverer_id").InnerText);
                    string innerText = node.SelectSingleNode("fairy").SelectSingleNode("name").InnerText;
                    int item = int.Parse(node.SelectSingleNode("fairy").SelectSingleNode("serial_id").InnerText);
                    int num3 = int.Parse(node.SelectSingleNode("fairy").SelectSingleNode("lv").InnerText);
                    bool flag2 = (int.Parse(node.SelectSingleNode("put_down").InnerText) == 1) || (int.Parse(node.SelectSingleNode("put_down").InnerText) == 4);
                    if ((iuser == this.iNowUserid) && flag2)
                    {
                        flag = false;
                    }
                    if (flag2 && (!this.fairylist.Contains(item) || (this.BC == this.MaxBc)))
                    {
                        object text = this.actionlog.Text;
                        this.actionlog.Text = string.Concat(new object[] { text, "攻击：", iuser, "-lv", num3.ToString(), innerText, "\r\n" });
                        this.lv = num3;
                        if (iuser == this.iNowUserid)
                        {
                            this.ChangeCard(this.CardChose.iwolfmusumecardnum, 0);
                            this.fairytop(iuser, item);
                            if (0x3e9 == this.guildfairybattle(iuser, item))
                            {
                                flag = false;
                                break;
                            }
                            this.fairylist.Add(item);
                            if (this.fairylist.Count > 30)
                            {
                                this.fairylist.RemoveAt(0);
                            }
                            Thread.Sleep(0x2710);
                        }
                        else
                        {
                            this.ChangeCard(this.CardChose.ifullcardnum, 0);
                            this.fairytop(iuser, item);
                            if (0x3e9 == this.guildfairybattle(iuser, item))
                            {
                                flag = false;
                                break;
                            }
                            this.fairylist.Add(item);
                            if (this.fairylist.Count > 30)
                            {
                                this.fairylist.RemoveAt(0);
                            }
                            Thread.Sleep(0x2710);
                        }
                    }
                }
                this.bExplore = flag;
            }
            catch (Exception)
            {
                this.serial_id = 0;
            }
            return -1;
        }

        private void getGuildFairyRewards()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/private_fairy/private_fairy_rewards?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_006D:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_006D;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node != null)
                {
                    this.szCharName = node.SelectSingleNode("name").InnerText;
                    XmlNode node2 = node.SelectSingleNode("bc");
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                }
            }
        }

        private int getRankINFO()
        {
            int num = -1;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/guild/guild_info?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return -1;
            }
            if (document == null)
            {
                return -1;
            }
            if (document != null)
            {
                try
                {
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        return num;
                    }
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("guild_info");
                    this.labelgrk = node.SelectSingleNode("user_rank").InnerText;
                    this.labelgzg = node.SelectSingleNode("user_hunting_point").InnerText;
                    this.labelzzg = node.SelectSingleNode("guild_hunting_point").SelectSingleNode("own_guild_point").InnerText;
                    this.labelzrg = node.SelectSingleNode("guild_hunting_point").SelectSingleNode("own_guild_dairy_point").InnerText;
                    this.labelzrk = node.SelectSingleNode("own_guild_rank").InnerText;
                    this.labelxzg = node.SelectSingleNode("guild_hunting_point").SelectSingleNode("rival_guild_point").InnerText;
                    this.labelxrg = node.SelectSingleNode("guild_hunting_point").SelectSingleNode("rival_guild_dairy_point").InnerText;
                    this.labelxrk = node.SelectSingleNode("rival_guild_rank").InnerText;
                }
                catch (Exception)
                {
                }
            }
            return num;
        }

        private int getRewards(string strr)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("notice_id", this.Encrypt(strr, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/menu/get_rewards?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0086:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0086;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node == null)
                {
                    return -1;
                }
                this.szCharName = node.SelectSingleNode("name").InnerText;
                XmlNode node2 = node.SelectSingleNode("bc");
                this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                XmlNode node3 = node.SelectSingleNode("ap");
                this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                string str = "";
                XmlNodeList list = null;
                int num = 0;
                list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                if ((list != null) && (list.Count != 0))
                {
                    this.cardlist = list;
                    object text = this.actionlog.Text;
                    this.actionlog.Text = string.Concat(new object[] { text, "收箱-卡数:", list.Count, "\r\n" });
                }
                string str3 = "卖：\r\n";
                foreach (XmlNode node4 in list)
                {
                    int num2 = int.Parse(node4.SelectSingleNode("lv").InnerText);
                    int num3 = int.Parse(node4.SelectSingleNode("lv_max").InnerText);
                    int num4 = int.Parse(node4.SelectSingleNode("sale_price").InnerText);
                    int num5 = int.Parse(node4.SelectSingleNode("hp").InnerText);
                    int num6 = int.Parse(node4.SelectSingleNode("power").InnerText);
                    int num7 = int.Parse(node4.SelectSingleNode("holography").InnerText);
                    if (num2 == 1)
                    {
                        if (((num5 > 1) || (num6 > 1)) && (((num7 == 0) && (num3 < 50)) && (num4 < this.iSellPrice)))
                        {
                            if (num == 0)
                            {
                                str = str + node4.SelectSingleNode("serial_id").InnerText;
                            }
                            else
                            {
                                str = str + "," + node4.SelectSingleNode("serial_id").InnerText;
                            }
                            object obj3 = str3;
                            str3 = string.Concat(new object[] { obj3, "ID:", node4.ChildNodes[1].InnerText, " lv:", num2, "/", num3, "  atk/hp:", num6, "/", num5, "\r\n" });
                            num++;
                        }
                    }
                    else if ((num3 < 50) && (num2 < 30))
                    {
                        if (num == 0)
                        {
                            str = str + node4.SelectSingleNode("serial_id").InnerText;
                        }
                        else
                        {
                            str = str + "," + node4.SelectSingleNode("serial_id").InnerText;
                        }
                        object obj4 = str3;
                        str3 = string.Concat(new object[] { obj4, "ID:", node4.ChildNodes[1].InnerText, " lv:", num2, "//", num3, "  atk/hp:", num6, "//", num5, "\r\n" });
                        num++;
                    }
                    if (num == 30)
                    {
                        this.actionlog.Text = this.actionlog.Text + str3 + "\r\n";
                        if (-1 == this.sellcard(str))
                        {
                            return -1;
                        }
                        num = 0;
                        str = "";
                        str3 = "卖：\r\n";
                    }
                }
                if (str != "")
                {
                    this.actionlog.Text = this.actionlog.Text + str3;
                    if (-1 == this.sellcard(str))
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }

        private int getRewardsAll()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/menu/rewardbox?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_006D:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_006D;
            }
            if (document == null)
            {
                return -1;
            }
            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
            {
                return -1;
            }
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            XmlNodeList list = null;
            try
            {
                list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("rewardbox_list").SelectNodes("rewardbox");
            }
            catch (Exception)
            {
                return -1;
            }
            if (list == null)
            {
                return -1;
            }
            if (list.Count == 0)
            {
                return -1;
            }
            string strr = "";
            int num = 0;
            object text = this.actionlog.Text;
            this.actionlog.Text = string.Concat(new object[] { text, "礼物箱", list.Count, "\r\n" });
            foreach (XmlNode node in list)
            {
                if (num == 0)
                {
                    strr = strr + node.SelectSingleNode("id").InnerText;
                }
                else
                {
                    strr = strr + "," + node.SelectSingleNode("id").InnerText;
                }
                num++;
            }
            return this.getRewards(strr);
        }

        private int getRewardsNoSell(string strr)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("notice_id", this.Encrypt(strr, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/menu/get_rewards?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0086:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0086;
            }
            if (document != null)
            {
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node == null)
                {
                    return -1;
                }
                this.szCharName = node.SelectSingleNode("name").InnerText;
                XmlNode node2 = node.SelectSingleNode("bc");
                this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                XmlNode node3 = node.SelectSingleNode("ap");
                this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                XmlNodeList list = null;
                try
                {
                    XmlNodeList list2 = node.SelectNodes("itemlist");
                    if (list2 != null)
                    {
                        foreach (XmlNode node4 in list2)
                        {
                            if (int.Parse(node4.SelectSingleNode("item_id").InnerText) == 0xca)
                            {
                                this.iGuildItemCount = int.Parse(node4.SelectSingleNode("num").InnerText);
                                object text = this.actionlog.Text;
                                this.actionlog.Text = string.Concat(new object[] { text, "收箱-卷数：", this.iGuildItemCount, "\r\n" });
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                try
                {
                    list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                    if ((list != null) && (list.Count != 0))
                    {
                        this.cardlist = list;
                        object obj3 = this.actionlog.Text;
                        this.actionlog.Text = string.Concat(new object[] { obj3, "收箱-卡数:", list.Count, "\r\n" });
                    }
                }
                catch (Exception)
                {
                }
            }
            return 0;
        }

        private int geturerrank(int iUser)
        {
            int num = 0;
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/ranking/ranking_next?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            if (this.iNowUserid == 0)
            {
                this.iNowUserid = this.getuserid();
            }
            parameters.Add("from", this.Encrypt(iUser.ToString(), this.key12));
            parameters.Add("ranktype_id", this.Encrypt("4", this.key12));
            XmlDocument document = null;
        Label_00D0:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00D0;
            }
            if (document != null)
            {
                num = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("ranking").SelectSingleNode("user_list").SelectNodes("user")[0].SelectSingleNode("rank").InnerText) - 1;
            }
            return num;
        }

        private int getuserid()
        {
            int num = 0;
            string url = "http://" + this.szhostport + "/connect/app/mainmenu?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return 0;
            }
            if (document != null)
            {
                if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                {
                    return 0;
                }
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                if (node == null)
                {
                    return 0;
                }
                this.szCharName = node.SelectSingleNode("name").InnerText;
                XmlNode node2 = node.SelectSingleNode("bc");
                this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                XmlNode node3 = node.SelectSingleNode("ap");
                this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                num = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("login").SelectSingleNode("user_id").InnerText);
                if (num == 0)
                {
                    this.iPartyid = int.Parse(node.SelectSingleNode("party_id").InnerText);
                }
                this.iuserLevel = int.Parse(node.SelectSingleNode("town_level").InnerText);
                string text = this.actionlog.Text;
                this.actionlog.Text = text + "进♂去了\r\ncookie:" + this.szCookie + "|用户:" + this.iNowUserid.ToString() + "|名字:" + this.szCharName + "\r\n";
            }
            return num;
        }

        private int getXSparty()
        {
            int iid = 0;
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/guild/guild_member_list?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            if (this.iNowUserid == 0)
            {
                this.iNowUserid = this.getuserid();
            }
            parameters.Add("guild_member_type", this.Encrypt("1", this.key12));
            XmlDocument document = null;
        Label_00B0:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00B0;
            }
            if (document != null)
            {
                XmlNodeList list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("guild_member_list").SelectSingleNode("guild_party_list").SelectNodes("ex_party");
                int num2 = 0;
                string innerText = "";
                string str3 = "";
                foreach (XmlNode node in list)
                {
                    int num3 = int.Parse(node.SelectSingleNode("hunting_point").InnerText);
                    if (num3 > num2)
                    {
                        num2 = num3;
                        innerText = node.SelectSingleNode("party").SelectSingleNode("name").InnerText;
                        str3 = node.SelectSingleNode("party").SelectSingleNode("leader").SelectSingleNode("name").InnerText;
                        iid = int.Parse(node.SelectSingleNode("party").SelectSingleNode("id").InnerText);
                    }
                }
                string str4 = string.Concat(new object[] { "可恶的对面团：", innerText, "，对面的头头：", str3, "贡献：", num2, "/", this.labelxzg, " | ", this.labelxrg, " | ", this.labelxrk, "\r\n\r\n" });
                this.actionlog.Text = this.actionlog.Text + str4;
                this.partyrank(iid);
            }
            return iid;
        }

        private int GuildBattle(int iG, int iS, string SK = "dummy")
        {
            int num = -1;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("guild_id", this.Encrypt(iG.ToString(), this.key12));
            parameters.Add("serial_id", this.Encrypt(iS.ToString(), this.key12));
            parameters.Add("spp_skill_serial", this.Encrypt(SK, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/fairy/guild_fairy_battle?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return num;
            }
            this.bWinner = false;
            if (document != null)
            {
                string text;
                document.Save("guildbattle.xml");
                string message = "战斗：";
                try
                {
                    if (((this.iJobID == 0) && (this.itestjob < 9)) && (-2 != this.changejob(this.itestjob)))
                    {
                        this.itestjob++;
                    }
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        text = this.actionlog.Text;
                        this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                        return 0x3e9;
                    }
                    this.dtOld = DateTime.Now;
                    this.bBonus = false;
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    if (node == null)
                    {
                        node = document.SelectSingleNode("response").SelectSingleNode("body");
                        string name = node.ChildNodes[0].Name;
                        if ((name == "guild_top") || (name == "guild_defeat_event"))
                        {
                            XmlNode node2 = node.SelectSingleNode(name).SelectSingleNode("guild_top_update");
                            XmlNode node3 = node2.SelectSingleNode("guild_reward_list");
                            if ((node3 != null) && (name == "guild_top"))
                            {
                                this.bBonus = true;
                                string str5 = "";
                                switch (int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_type").InnerText))
                                {
                                    case 0x2775:
                                        str5 = "白金箱";
                                        break;

                                    case 0x2776:
                                        str5 = "金箱";
                                        break;

                                    case 0x2777:
                                        str5 = "银箱";
                                        break;

                                    case 0x2778:
                                        str5 = "铜箱";
                                        break;

                                    case 0x2779:
                                        str5 = "木箱";
                                        break;
                                }
                                int num2 = int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_num").InnerText);
                                string str6 = this.actionlog.Text;
                                this.actionlog.Text = str6 + "[" + DateTime.Now.ToString() + "]发现强敌：获得" + str5 + "*" + num2.ToString() + "\r\n";
                                this.actionlog.WriteInfo("发现强敌：获得" + str5 + "*" + num2.ToString() + "\r\n");
                            }
                            else if (name == "guild_defeat_event")
                            {
                                node3 = node.SelectSingleNode(name).SelectSingleNode("guild_reward_list");
                                if (node3.SelectSingleNode("reward_box_list") != null)
                                {
                                    string str7 = "";
                                    switch (int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_type").InnerText))
                                    {
                                        case 0x2775:
                                            str7 = "白金箱";
                                            break;

                                        case 0x2776:
                                            str7 = "金箱";
                                            break;

                                        case 0x2777:
                                            str7 = "银箱";
                                            break;

                                        case 0x2778:
                                            str7 = "铜箱";
                                            break;

                                        case 0x2779:
                                            str7 = "木箱";
                                            break;
                                    }
                                    int num3 = int.Parse(node3.SelectSingleNode("reward_box_list").SelectSingleNode("box_num").InnerText);
                                    this.actionlog.Text = this.actionlog.Text + ((string.Concat(new object[] { "[", DateTime.Now.ToString(), "]", node3 }) != null) ? ("强敌扑街，获得" + str7 + "*" + num3.ToString() + "\r\n") : "强敌扑街\r\n");
                                    this.actionlog.WriteInfo((node3 != null) ? ("强敌扑街，获得" + str7 + "*" + num3.ToString() + "\r\n") : "强敌扑街\r\n");
                                    this.serial_id = 0;
                                }
                                else
                                {
                                    this.actionlog.Text = this.actionlog.Text + "[" + DateTime.Now.ToString() + "]强敌扑街\r\n";
                                    this.actionlog.WriteInfo("强敌扑街\r\n");
                                }
                            }
                            else
                            {
                                message = message + "新怪\r\n";
                                this.bBonus = false;
                            }
                            XmlNode node4 = node2.SelectSingleNode("fairy");
                            XmlNode node5 = node2.SelectSingleNode("guild_fairy_weak");
                            if ((node5 != null) && this.bAutojob)
                            {
                                int i = int.Parse(node5.SelectSingleNode("id").InnerText);
                                if ((i != this.iJobID) && (-2 != this.changejob(i)))
                                {
                                    this.iJobID = i;
                                }
                            }
                            node2.SelectNodes("guild_log");
                            this.serial_id = int.Parse(node4.SelectSingleNode("serial_id").InnerText);
                            this.lv = int.Parse(node4.SelectSingleNode("lv").InnerText);
                            this.hp = int.Parse(node4.SelectSingleNode("hp").InnerText);
                            this.hp_max = int.Parse(node4.SelectSingleNode("hp_max").InnerText);
                            this.bname = node4.SelectSingleNode("name").InnerText;
                            XmlNode node6 = node2.SelectSingleNode("force_gauge");
                            if (node6 != null)
                            {
                                int num5 = int.Parse(node6.SelectSingleNode("own").InnerText);
                                int num6 = int.Parse(node6.SelectSingleNode("rival").InnerText);
                                int num7 = int.Parse(node6.SelectSingleNode("total").InnerText);
                                this.dWin = (((double) (num5 - num6)) / ((double) num7)) / 2.0;
                            }
                            this.iGuildID = int.Parse(node4.SelectSingleNode("discoverer_id").InnerText);
                            int num8 = int.Parse(node4.SelectSingleNode("time_limit").InnerText);
                            if (node4.SelectSingleNode("master_boss_id") != null)
                            {
                                num = 0;
                                if ((int.Parse(node4.SelectSingleNode("master_boss_id").InnerText) == this.iSubBossID) && (num8 > 0x1ba8))
                                {
                                    num = 3;
                                }
                            }
                            else if (num8 > 0x1ba8)
                            {
                                num = 3;
                            }
                            if (name == "guild_defeat_event")
                            {
                                this.serial_id = 0;
                                num = 2;
                            }
                            return num;
                        }
                        string str8 = name;
                        switch (str8)
                        {
                            case null:
                                return num;

                            case "guild_fairy_event":
                                return 1;

                            default:
                                if (str8 == "guild_top_no_fairy")
                                {
                                    num = 2;
                                    this.iSubBossID = int.Parse(node.SelectSingleNode("guild_top_no_fairy").SelectSingleNode("guild_boss").SelectSingleNode("sub_boss_id").InnerText);
                                    this.hp = 0;
                                    this.serial_id = 0;
                                }
                                return num;
                        }
                    }
                    XmlNode node7 = node.SelectSingleNode("bc");
                    XmlNodeList list = node.SelectNodes("itemlist");
                    if (list != null)
                    {
                        foreach (XmlNode node8 in list)
                        {
                            if (int.Parse(node8.SelectSingleNode("item_id").InnerText) == 0xca)
                            {
                                this.iGuildItemCount = int.Parse(node8.SelectSingleNode("num").InnerText);
                            }
                        }
                    }
                    int bC = this.BC;
                    this.BC = int.Parse(node7.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node7.SelectSingleNode("max").InnerText);
                    XmlNode node9 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node9.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node9.SelectSingleNode("max").InnerText);
                    string str9 = message;
                    message = str9 + " BC:" + bC.ToString() + "-" + this.BC.ToString() + " ";
                    this.iContribution = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("own_fairy_battle_result").SelectSingleNode("contribution_info").SelectSingleNode("hp_contribution").InnerText);
                    this.iContribution2 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("own_fairy_battle_result").SelectSingleNode("contribution_info").SelectSingleNode("battle_contribution").InnerText);
                    this.bWinner = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("own_fairy_battle_result").SelectSingleNode("winner").InnerText) == 1;
                    num = 0;
                    BattleLog item = new BattleLog(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_battle"), this.lv, this.iContribution, this.iContribution2);
                    this.Battles.Add(item);
                    this.listBox1.Items.Add(item);
                    this.listBox1.DisplayMember = "Text";
                    this.listBox1.ValueMember = "Value";
                    if (this.bWinner)
                    {
                        message = message + "-战斗胜利-";
                    }
                    string str10 = message;
                    message = str10 + "贡献：残血" + this.iContribution.ToString() + "战斗" + this.iContribution2.ToString();
                    XmlNodeList list2 = null;
                    try
                    {
                        list2 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("own_fairy_battle_result").SelectNodes("guild_reward_list");
                    }
                    catch (Exception)
                    {
                    }
                    if (list2 != null)
                    {
                        try
                        {
                            int num10 = int.Parse(list2[0].SelectSingleNode("special_item").SelectSingleNode("before_count").InnerText);
                            int num11 = int.Parse(list2[0].SelectSingleNode("special_item").SelectSingleNode("after_count").InnerText);
                            text = message;
                            string[] strArray = new string[] { text, "收集道具：", (num11 - num10).ToString(), "/", num11.ToString(), "\r\n" };
                            message = string.Concat(strArray);
                        }
                        catch (Exception)
                        {
                            message = message + "\r\n";
                        }
                        if (list2.Count > 1)
                        {
                            string str11 = "";
                            switch (int.Parse(list2[1].SelectSingleNode("reward_box_list").SelectSingleNode("box_type").InnerText))
                            {
                                case 0x2775:
                                    str11 = "白金箱";
                                    break;

                                case 0x2776:
                                    str11 = "金箱";
                                    break;

                                case 0x2777:
                                    str11 = "银箱";
                                    break;

                                case 0x2778:
                                    str11 = "铜箱";
                                    break;

                                case 0x2779:
                                    str11 = "木箱";
                                    break;
                            }
                            int num12 = int.Parse(list2[1].SelectSingleNode("reward_box_list").SelectSingleNode("box_num").InnerText);
                            text = message;
                            message = text + "杀死强敌：获得" + str11 + "*" + num12.ToString() + "\r\n";
                            this.serial_id = 0;
                        }
                    }
                    text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
                catch (Exception exception)
                {
                    message = message + exception.Message + "\r\n";
                    text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
            }
            return num;
        }

        private void guildEvent()
        {
            if (this.checkBox3.Checked)
            {
                while (this.iGuildItemCount > 10)
                {
                    int num = this.getGuidIFO();
                    while ((num == 4) || (num == 1))
                    {
                        num = this.getGuidIFO();
                    }
                    if (num == 2)
                    {
                        break;
                    }
                    this.ChangeCard(this.CardChose.isubcardnum, 0);
                    for (TimeSpan span = (TimeSpan) (DateTime.Now - this.guildfairytime); span.TotalSeconds < 10.0; span = (TimeSpan) (DateTime.Now - this.guildfairytime))
                    {
                        Thread.Sleep(0x2710);
                    }
                    this.GuildBattle(this.iGuildID, this.serial_id, "dummy");
                }
            }
        }

        private int guildfairybattle(int iU, int iS)
        {
            int num = -1;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("no", this.Encrypt("0", this.key12));
            parameters.Add("serial_id", this.Encrypt(iS.ToString(), this.key12));
            parameters.Add("user_id", this.Encrypt(iU.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/private_fairy/private_fairy_battle?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                return num;
            }
            this.guildfairytime = DateTime.Now;
            this.bWinner = false;
            if (document != null)
            {
                document.Save("fairybattle.xml");
                string message = "战斗：";
                try
                {
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        message = message + document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        string szActionLog = this.szActionLog;
                        szActionLog = szActionLog + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                        return 0x3e9;
                    }
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    XmlNode node2 = node.SelectSingleNode("bc");
                    int bC = this.BC;
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                    string str4 = message;
                    message = str4 + " BC:" + bC.ToString() + "->" + this.BC.ToString() + " ";
                    try
                    {
                        int num3 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("before_exp").InnerText);
                        int num4 = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("after_exp").InnerText);
                        this.bWinner = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("winner").InnerText) == 1;
                        string str5 = message;
                        message = str5 + "经验" + num3.ToString() + "->" + num4.ToString();
                        num = 0;
                        XmlNodeList list = node.SelectNodes("itemlist");
                        if (list != null)
                        {
                            foreach (XmlNode node4 in list)
                            {
                                if (int.Parse(node4.SelectSingleNode("item_id").InnerText) == 0xca)
                                {
                                    this.iGuildItemCount = int.Parse(node4.SelectSingleNode("num").InnerText);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        BattleLog item = new BattleLog(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_battle"), this.lv, 0, 0);
                        this.Battles.Add(item);
                        this.listBox1.Items.Add(item);
                        this.listBox1.DisplayMember = "Text";
                        this.listBox1.ValueMember = "Value";
                    }
                    catch (Exception)
                    {
                    }
                    if (this.bWinner)
                    {
                        message = message + "-战斗胜利-";
                    }
                    XmlNode node5 = null;
                    XmlNodeList list2 = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                    int num5 = 0;
                    string str = "";
                    if ((list2 != null) && (list2.Count > 200))
                    {
                        this.cardlist = list2;
                        object obj2 = this.actionlog.Text;
                        this.actionlog.Text = string.Concat(new object[] { obj2, "得到卡数:", list2.Count, "\r\n" });
                        try
                        {
                            this.iSellPrice = int.Parse(this.textBox4.Text);
                        }
                        catch (Exception)
                        {
                        }
                        string str7 = "卖：\r\n";
                        foreach (XmlNode node6 in list2)
                        {
                            int num6 = int.Parse(node6.SelectSingleNode("lv").InnerText);
                            int num7 = int.Parse(node6.SelectSingleNode("lv_max").InnerText);
                            int num8 = int.Parse(node6.SelectSingleNode("sale_price").InnerText);
                            int num9 = int.Parse(node6.SelectSingleNode("hp").InnerText);
                            int num10 = int.Parse(node6.SelectSingleNode("power").InnerText);
                            int num11 = int.Parse(node6.SelectSingleNode("holography").InnerText);
                            if (num6 == 1)
                            {
                                if (((num9 > 1) || (num10 > 1)) && (((num11 == 0) && (num7 < 50)) && (num8 < this.iSellPrice)))
                                {
                                    if (num5 == 0)
                                    {
                                        str = str + node6.SelectSingleNode("serial_id").InnerText;
                                    }
                                    else
                                    {
                                        str = str + "," + node6.SelectSingleNode("serial_id").InnerText;
                                    }
                                    object obj3 = str7;
                                    str7 = string.Concat(new object[] { obj3, "ID:", node6.ChildNodes[1].InnerText, " lv:", num6, "/", num7, "  atk/hp:", num10, "/", num9, "\r\n" });
                                    num5++;
                                }
                            }
                            else if ((num7 < 50) && (num6 < 30))
                            {
                                if (num5 == 0)
                                {
                                    str = str + node6.SelectSingleNode("serial_id").InnerText;
                                }
                                else
                                {
                                    str = str + "," + node6.SelectSingleNode("serial_id").InnerText;
                                }
                                object obj4 = str7;
                                str7 = string.Concat(new object[] { obj4, "ID:", node6.ChildNodes[1].InnerText, " lv:", num6, "//", num7, "  atk/hp:", num10, "//", num9, "\r\n" });
                                num5++;
                            }
                            if (num5 == 30)
                            {
                                this.actionlog.Text = this.actionlog.Text + str7 + "\r\n";
                                this.sellcard(str);
                                num5 = 0;
                                str = "";
                                str7 = "卖：\r\n";
                            }
                        }
                        if (str != "")
                        {
                            this.actionlog.Text = this.actionlog.Text + str7;
                            this.sellcard(str);
                        }
                    }
                    try
                    {
                        node5 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("battle_result").SelectSingleNode("special_item");
                    }
                    catch (Exception)
                    {
                        message = message + "\r\n";
                    }
                    if (node5 != null)
                    {
                        try
                        {
                            int num12 = int.Parse(node5.SelectSingleNode("before_count").InnerText);
                            int num13 = int.Parse(node5.SelectSingleNode("after_count").InnerText);
                            string str8 = message;
                            string[] strArray = new string[] { str8, "收集道具：", (num13 - num12).ToString(), "->", num13.ToString(), "\r\n" };
                            message = string.Concat(strArray);
                        }
                        catch (Exception)
                        {
                            message = message + "\r\n";
                        }
                    }
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
                catch (Exception exception)
                {
                    message = message + exception.Message + "\r\n";
                    string str10 = this.szActionLog;
                    this.szActionLog = str10 + "[" + DateTime.Now.ToString() + "]" + message;
                    this.actionlog.WriteInfo(message);
                }
            }
            return num;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lbBCAP = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button17 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button18 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button23 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.logbind = new MillionArthurTool.BingdingText();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = 'H';
            this.textBox2.Size = new System.Drawing.Size(87, 21);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "cookie";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 75);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 21);
            this.textBox3.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 46);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 78);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(189, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "进♀去";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(189, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "出♂来";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(11, 105);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(628, 268);
            this.textBoxLog.TabIndex = 10;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(435, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(355, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "更新地图";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(355, 72);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "团内贡献";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(355, 39);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 14;
            this.button5.Text = "开箱卖卡";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(493, 46);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 21);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "3300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(435, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "价格<=";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(631, 76);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 20);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "职业";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(603, 12);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(811, 72);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 20;
            this.button6.Text = "挂机跑图";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(891, 72);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 32);
            this.button7.TabIndex = 21;
            this.button7.Text = "抢免BC(小心ban)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "BC>=";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(789, 44);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 21);
            this.textBox5.TabIndex = 23;
            this.textBox5.Text = "2";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(731, 72);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 32);
            this.button8.TabIndex = 22;
            this.button8.Text = "连续攻击";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(859, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "AP>=";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(903, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(63, 21);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "120";
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(432, 72);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 27;
            this.button9.Text = "分配";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(509, 78);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 20);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "BC/AP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox2.Location = new System.Drawing.Point(731, 12);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 20);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "自动换区";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton3.Location = new System.Drawing.Point(3, 2);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 20);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "无药";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton4.Location = new System.Drawing.Point(3, 22);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 20);
            this.radioButton4.TabIndex = 31;
            this.radioButton4.Text = "红茶";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton5.Location = new System.Drawing.Point(3, 42);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(46, 20);
            this.radioButton5.TabIndex = 32;
            this.radioButton5.Text = "红管";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton6.Location = new System.Drawing.Point(3, 78);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(46, 20);
            this.radioButton6.TabIndex = 33;
            this.radioButton6.Text = "绿管";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton7.Location = new System.Drawing.Point(3, 59);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 20);
            this.radioButton7.TabIndex = 34;
            this.radioButton7.Text = "绿茶";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton7);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton6);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.panel1.Location = new System.Drawing.Point(271, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 102);
            this.panel1.TabIndex = 35;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(811, 2);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(60, 20);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.Text = "干外敌";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lbBCAP
            // 
            this.lbBCAP.AutoSize = true;
            this.lbBCAP.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbBCAP.Location = new System.Drawing.Point(579, 48);
            this.lbBCAP.Name = "lbBCAP";
            this.lbBCAP.Size = new System.Drawing.Size(0, 16);
            this.lbBCAP.TabIndex = 37;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.Location = new System.Drawing.Point(1075, 676);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 32);
            this.button10.TabIndex = 38;
            this.button10.Text = "申请好友";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(811, 675);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 22);
            this.button11.TabIndex = 41;
            this.button11.Text = "加入";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(897, 675);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 22);
            this.button12.TabIndex = 42;
            this.button12.Text = "更新数据";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(983, 675);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 22);
            this.button13.TabIndex = 43;
            this.button13.Text = "移除";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox4.Location = new System.Drawing.Point(891, 2);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 20);
            this.checkBox4.TabIndex = 44;
            this.checkBox4.Text = "换弱点(断操纵)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button14
            // 
            this.button14.Enabled = false;
            this.button14.Location = new System.Drawing.Point(563, 415);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(33, 24);
            this.button14.TabIndex = 46;
            this.button14.Text = "→";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button15.Location = new System.Drawing.Point(657, 105);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 32);
            this.button15.TabIndex = 48;
            this.button15.Text = "读取箱子";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button16.Location = new System.Drawing.Point(733, 105);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 32);
            this.button16.TabIndex = 49;
            this.button16.Text = "拿走里面";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(656, 142);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(302, 232);
            this.dataGridView3.TabIndex = 47;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(198, 387);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(354, 284);
            this.dataGridView2.TabIndex = 45;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(753, 387);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(312, 284);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button17.Location = new System.Drawing.Point(319, 676);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 32);
            this.button17.TabIndex = 50;
            this.button17.Text = "拉取数据";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "lv",
            "id",
            "hp",
            "atk"});
            this.comboBox4.Location = new System.Drawing.Point(395, 682);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(109, 20);
            this.comboBox4.TabIndex = 51;
            // 
            // button18
            // 
            this.button18.Enabled = false;
            this.button18.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button18.Location = new System.Drawing.Point(245, 676);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(70, 32);
            this.button18.TabIndex = 52;
            this.button18.Text = "卖掉";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1075, 387);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 27;
            this.dataGridView4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView4.Size = new System.Drawing.Size(177, 284);
            this.dataGridView4.TabIndex = 53;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellValueChanged);
            this.dataGridView4.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView4_RowsAdded);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(990, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 52);
            this.listBox1.TabIndex = 54;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(981, 118);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(281, 256);
            this.textBox7.TabIndex = 55;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(981, 702);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 56;
            this.button19.Text = "挂机";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Visible = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 240);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox5.Location = new System.Drawing.Point(808, 112);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 20);
            this.checkBox5.TabIndex = 58;
            this.checkBox5.Text = "满BC停跑图";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(603, 414);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(105, 21);
            this.textBox8.TabIndex = 59;
            // 
            // button20
            // 
            this.button20.Enabled = false;
            this.button20.Location = new System.Drawing.Point(714, 472);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(33, 24);
            this.button20.TabIndex = 60;
            this.button20.Text = "→";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(563, 472);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(33, 24);
            this.button21.TabIndex = 61;
            this.button21.Text = "→";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Location = new System.Drawing.Point(606, 675);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(93, 31);
            this.button22.TabIndex = 63;
            this.button22.Text = "compound";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(602, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "base/leader";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(603, 472);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(105, 148);
            this.listBox2.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(602, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "dogfood/cardset";
            // 
            // button23
            // 
            this.button23.Enabled = false;
            this.button23.Location = new System.Drawing.Point(615, 646);
            this.button23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 22);
            this.button23.TabIndex = 67;
            this.button23.Text = "remove";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.panel2.Location = new System.Drawing.Point(11, 632);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 76);
            this.panel2.TabIndex = 36;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Checked = true;
            this.radioButton8.Font = new System.Drawing.Font("微软雅黑", 6.8F);
            this.radioButton8.Location = new System.Drawing.Point(17, 14);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(46, 20);
            this.radioButton8.TabIndex = 30;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "日服";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox6.Location = new System.Drawing.Point(891, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(49, 20);
            this.checkBox6.TabIndex = 69;
            this.checkBox6.Text = "放妖";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox7.Location = new System.Drawing.Point(811, 24);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(71, 20);
            this.checkBox7.TabIndex = 68;
            this.checkBox7.Text = "自动合成";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            // 
            // button24
            // 
            this.button24.Enabled = false;
            this.button24.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button24.Location = new System.Drawing.Point(355, 73);
            this.button24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 32);
            this.button24.TabIndex = 70;
            this.button24.Text = "妖精奖励";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Visible = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.Enabled = false;
            this.button25.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button25.Location = new System.Drawing.Point(891, 106);
            this.button25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(70, 32);
            this.button25.TabIndex = 71;
            this.button25.Text = "连续取卷";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // logbind
            // 
            this.logbind.Location = new System.Drawing.Point(0, 0);
            this.logbind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logbind.Name = "logbind";
            this.logbind.Size = new System.Drawing.Size(0, 0);
            this.logbind.str = null;
            this.logbind.TabIndex = 39;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1156, 681);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(94, 21);
            this.textBox9.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(12, 728);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1022, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "当前版本的本工具为debug版,各种崩溃.对应日服GP250版扩散性MA 如果更新找咱吧! 编译时间20140206 维护QQ群321460857 现在是初版 王" +
                "师傅为何弃坑 本程序授权有时间限制学习丧病，虽然不知道干嘛的";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 744);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.lbBCAP);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logbind);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "扩散♂性♀ma,我神马也不知道的说";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((this.listBox1.Items != null) && (this.listBox1.Items.Count > 0)) && (this.listBox1.SelectedItem != null))
            {
                BattleLog selectedItem = (BattleLog) this.listBox1.SelectedItem;
                this.textBox7.Text = selectedItem.Value.ToString();
            }
        }

        private bool Login()
        {
            bool flag = false;
            string text = this.textBox1.Text;
            if (this.LoginType != 0)
            {
                this.selectKey(text);
                this.szCookie = this.textBox3.Text;
                this.iNowUserid = this.getuserid();
                if (this.iNowUserid != 0)
                {
                    return true;
                }
                this.actionlog.Text = this.actionlog.Text + "user/cookie不匹配或者cookie失效\r\n";
                return flag;
            }
            this.selectKey(text);
            string toEstr = this.textBox2.Text;
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", "") {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            string url = "http://" + this.szhostport + "/connect/app/login?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("login_id", this.Encrypt(text, this.key0));
            parameters.Add("password", this.Encrypt(toEstr, this.key0));
            XmlDocument document = null;
        Label_0135:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0135;
            }
            if (document == null)
            {
                return flag;
            }
            if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
            {
                string message = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                string str5 = this.actionlog.Text;
                this.actionlog.Text = str5 + "[" + DateTime.Now.ToString() + "]" + message;
                this.actionlog.WriteInfo(message);
                return flag;
            }
            this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
            XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
            this.szCharName = node.SelectSingleNode("name").InnerText;
            XmlNode node2 = node.SelectSingleNode("bc");
            this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
            this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
            XmlNode node3 = node.SelectSingleNode("ap");
            this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
            this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
            this.cardlist = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
            if (this.iServer == 0)
            {
                this.iPartyid = int.Parse(node.SelectSingleNode("party_id").InnerText);
            }
            this.iuserLevel = int.Parse(node.SelectSingleNode("town_level").InnerText);
            try
            {
                XmlNode node4 = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("login").SelectSingleNode("user_id");
                this.iNowUserid = int.Parse(node4.InnerText);
            }
            catch (Exception)
            {
                this.iNowUserid = this.getuserid();
            }
            string str6 = this.actionlog.Text;
            this.actionlog.Text = str6 + "登录成功\r\ncookie:" + this.szCookie + "|user:" + this.iNowUserid.ToString() + "|name:" + this.szCharName + "\r\n";
            return true;
        }

        private void LoginMethod(object sender, EventArgs e)
        {
            this.EnableLoint(!this.bLogin);
        }

        private void MapsMethod(object sender, EventArgs e)
        {
            this.GetAreaIfo();
        }

        private void MessageBox(string p)
        {
            throw new NotImplementedException();
        }

        private void partyrank()
        {
            this.button4.Enabled = false;
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/party/party_only_member_list?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("pid", this.Encrypt(this.iPartyid.ToString(), this.key12));
            XmlDocument document = null;
        Label_009E:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_009E;
            }
            if (document != null)
            {
                FileStream stream = new FileStream("团排名输出.txt", FileMode.OpenOrCreate);
                this.ranklist.Clear();
                XmlNodeList list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("party_member_list").SelectNodes("member");
                int num = 0;
                foreach (XmlNode node in list)
                {
                    playerrank item = new playerrank();
                    int iUser = int.Parse(node.SelectSingleNode("id").InnerText);
                    item.name = node.SelectSingleNode("name").InnerText;
                    num += item.point = int.Parse(node.SelectSingleNode("guild_hunting_point").InnerText);
                    item.ilv = int.Parse(node.SelectSingleNode("town_level").InnerText);
                    item.logintime = node.SelectSingleNode("last_login").InnerText;
                    item.irank = this.geturerrank(iUser);
                    this.ranklist.Add(item);
                }
                this.getRankINFO();
                string str2 = "团贡 ：" + num.ToString() + "/" + this.labelzzg + "，日贡：" + this.labelzrg + "，团排：" + this.labelzrk + "\r\n";
                this.ranklist.Sort();
                foreach (playerrank playerrank2 in this.ranklist)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(playerrank2.ToString());
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Flush();
                    this.actionlog.Text = this.actionlog.Text + playerrank2.ToString() + "\r\n";
                }
                this.actionlog.Text = this.actionlog.Text + str2;
                stream.Close();
                this.getXSparty();
            }
            this.button4.Enabled = true;
        }

        private void partyrank(int iid)
        {
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            string url = "http://" + this.szhostport + "/connect/app/party/party_only_member_list?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("pid", this.Encrypt(iid.ToString(), this.key12));
            XmlDocument document = null;
        Label_008D:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_008D;
            }
            if (document != null)
            {
                this.ranklist.Clear();
                XmlNodeList list = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("party_member_list").SelectNodes("member");
                int num = 0;
                foreach (XmlNode node in list)
                {
                    playerrank item = new playerrank();
                    int iUser = int.Parse(node.SelectSingleNode("id").InnerText);
                    item.name = node.SelectSingleNode("name").InnerText;
                    num += item.point = int.Parse(node.SelectSingleNode("guild_hunting_point").InnerText);
                    item.ilv = int.Parse(node.SelectSingleNode("town_level").InnerText);
                    item.logintime = node.SelectSingleNode("last_login").InnerText;
                    item.irank = this.geturerrank(iUser);
                    this.ranklist.Add(item);
                }
                this.ranklist.Sort();
                foreach (playerrank playerrank2 in this.ranklist)
                {
                    this.actionlog.Text = this.actionlog.Text + playerrank2.ToString() + "\r\n";
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Enabled = this.radioButton1.Checked;
            this.textBox3.Enabled = this.radioButton2.Checked;
            this.LoginType = this.radioButton1.Checked ? 0 : 1;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox2.Enabled = this.radioButton1.Checked;
            this.textBox3.Enabled = this.radioButton2.Checked;
            this.LoginType = this.radioButton1.Checked ? 0 : 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.SwitchSever(0);
        }

        private void RewardsMethod(object sender, EventArgs e)
        {
            try
            {
                this.iSellPrice = int.Parse(this.textBox4.Text);
            }
            catch (Exception)
            {
            }
            try
            {
                while (-1 != this.getRewardsAll())
                {
                }
            }
            catch (Exception exception)
            {
                string text = this.actionlog.Text;
                this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + exception.Message + "\r\n";
                this.actionlog.WriteInfo(exception.Message + "\r\n");
            }
            this.button5.Enabled = true;
        }

        private void selectKey(string userName)
        {
            if (this.iServer == 1)
            {
                this.key12 = this.baseKey;
            }
            else
            {
                this.key12 = this.baseKey + userName;
                for (int i = this.key12.Length; i < 0x20; i++)
                {
                    this.key12 = this.key12 + "0";
                }
            }
        }

        private int sellcard(string str)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("serial_id", this.Encrypt(str, this.key12));
            string url = "http://" + this.szhostport + "/connect/app/trunk/sell?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_0086:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_0086;
            }
            if (document != null)
            {
                if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) == 0x1f40)
                {
                    return 0;
                }
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                this.szCharName = node.SelectSingleNode("name").InnerText;
                XmlNode node2 = node.SelectSingleNode("bc");
                this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                XmlNode node3 = node.SelectSingleNode("ap");
                this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                XmlNodeList list = node.SelectSingleNode("owner_card_list").SelectNodes("user_card");
                if ((list != null) && (list.Count != 0))
                {
                    this.cardlist = list;
                    object text = this.actionlog.Text;
                    this.actionlog.Text = string.Concat(new object[] { text, "卖卡成功-卡数:", list.Count, "\r\n\r\n" });
                }
                if (list.Count >= 190)
                {
                    return -1;
                }
            }
            return 0;
        }

        private void setbc()
        {
            string url = "http://" + this.szhostport + "/connect/app/town/pointsetting?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            if (this.bxiap)
            {
                parameters.Add("ap", this.Encrypt("3", this.key12));
                parameters.Add("bc", this.Encrypt("0", this.key12));
            }
            else
            {
                parameters.Add("ap", this.Encrypt("0", this.key12));
                parameters.Add("bc", this.Encrypt("3", this.key12));
            }
            XmlDocument document = null;
        Label_00FA:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_00FA;
            }
            if (document != null)
            {
                if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                {
                    string str2 = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                    string text = this.actionlog.Text;
                    this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + str2;
                }
                else
                {
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    this.szCharName = node.SelectSingleNode("name").InnerText + "正在挂机";
                    XmlNode node2 = node.SelectSingleNode("bc");
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                }
            }
        }

        private void SwitchSever(int iType)
        {
            if (iType == 1)
            {
                this.iServer = 1;
                this.GetApple();
                this.szhost = "game1-CBT.ma.sdo.com";
                this.szhostport = "game1-CBT.ma.sdo.com:10001";
                this.DefaultUserAgent = "Million/100 (c1lgt; c1lgt; 4.1.2) samsung/c1lgt/c1lgt:4.1.2/JZO54K/E210LKLJLL7:user/release-keys GooglePlay";
                this.button4.Visible = false;
                this.button7.Visible = false;
                this.button9.Visible = false;
                this.checkBox1.Visible = false;
                this.checkBox5.Visible = false;
                this.checkBox3.Visible = false;
                this.checkBox4.Visible = false;
                this.comboBox2.Visible = false;
                this.button24.Visible = true;
                this.label5.Visible = false;
                this.checkBox6.Visible = true;
                this.checkBox7.Visible = true;
                this.Text = "扩散性百万变态狂";
                this.key0 = this.baseKey;
            }
            else
            {
                this.iServer = 0;
                this.GetApple();
                this.key0 = this.baseKey + "0000000000000000";
                this.DefaultUserAgent = "Million/250 (aalgt; aalgt; 4.1.2) sumsung/aalgt/aalgt:4.1.2/JZ254K/E410LKLJME2:user/release-keys GooglePlay";
                this.szhost = "web.million-arthurs.com";
                this.szhostport = "web.million-arthurs.com";
                this.comboBox2.Visible = true;
                this.label5.Visible = true;
                this.button4.Visible = true;
                this.button7.Visible = true;
                this.button9.Visible = true;
                this.checkBox1.Visible = true;
                this.checkBox5.Visible = true;
                this.checkBox3.Visible = true;
                this.checkBox4.Visible = true;
                this.checkBox6.Visible = false;
                this.checkBox7.Visible = false;
                this.button24.Visible = false;
                this.Text = "拡散性MA,我还是什么也不知道的说";
            }
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            this.textBoxLog.SelectionStart = this.textBoxLog.Text.Length;
            this.textBoxLog.ScrollToCaret();
        }

        private void threadAttack()
        {
            while (this.bThreadAttack)
            {
                if (!this.bAting)
                {
                    this._AttackEvent.BeginInvoke(null, EventArgs.Empty, null, null);
                }
                Thread.Sleep(0x2ee0);
            }
        }

        private void threadAttackEX()
        {
            while (this.bThreadAttack)
            {
                if (!this.bAting)
                {
                    this._AttackEventEx.BeginInvoke(null, EventArgs.Empty, null, null);
                }
                Thread.Sleep(0x2ee0);
            }
        }

        private void threadBuy71()
        {
            this.button10.Enabled = false;
            try
            {
                this.iSellPrice = int.Parse(this.textBox4.Text);
            }
            catch (Exception)
            {
            }
            try
            {
                string str;
            Label_002F:
                str = "http://" + this.szhostport + "/connect/web/event_mahjong_do?tile=500";
                CookieCollection cookies = new CookieCollection();
                Cookie cookie2 = new Cookie("S", this.szCookie) {
                    Domain = this.szhost
                };
                Cookie cookie = cookie2;
                cookies.Add(cookie);
                Cookie cookie3 = new Cookie("_ga", "GA1.2.2058947360.1373369155") {
                    Domain = this.szhost
                };
                cookie = cookie3;
                cookies.Add(cookie);
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("", "");
                IDictionary<string, string> parameters = dictionary;
                parameters.Clear();
                try
                {
                    this.CreatePostHttpResponse(str, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                    goto Label_002F;
                }
                catch (Exception)
                {
                    goto Label_002F;
                }
            }
            catch (Exception)
            {
            }
            this.button10.Enabled = true;
        }

        public void threadCompound()
        {
            this.button22.Enabled = false;
            if ((this.listBox2.Items.Count >= 1) && (this.textBox8.Text != ""))
            {
                string dogfood = "";
                int num = 0;
                foreach (object obj2 in this.listBox2.Items)
                {
                    if (num == 0)
                    {
                        dogfood = dogfood + obj2.ToString();
                    }
                    else
                    {
                        dogfood = dogfood + "," + obj2.ToString();
                    }
                    num++;
                    if (num == 30)
                    {
                        this.compound(this.textBox8.Text, dogfood);
                        num = 0;
                        dogfood = "";
                    }
                }
                if (dogfood != "")
                {
                    this.compound(this.textBox8.Text, dogfood);
                }
                this.allcards.update(this.cardlist, this.comboBox4.SelectedIndex + 1);
                this.listBox2.Items.Clear();
                this.button22.Enabled = true;
            }
        }

        private void ThreadEX()
        {
            int num = this.getapbc();
            int num2 = 0;
            this.dtOld = DateTime.Now;
            while (this.bThreadEx)
            {
                if ((DateTime.Now.Hour > 0) && (DateTime.Now.Hour < 4))
                {
                    this.itestjob = 1;
                    this.iJobID = 0;
                    this.serial_id = 0;
                    Thread.Sleep(0x3e8);
                }
                else
                {
                    try
                    {
                        num2 = int.Parse(this.textBox6.Text);
                    }
                    catch (Exception)
                    {
                    }
                    if (num != 3)
                    {
                        this.ioldre = 0;
                        if (this.AP >= this.ilowap)
                        {
                            num = this.explore();
                        }
                        else
                        {
                            num = this.getapbc();
                        }
                    }
                    else if ((this.AP >= this.ilowap) && (this.AP >= num2))
                    {
                        num = this.explore();
                    }
                    else if (this.radioButton7.Checked)
                    {
                        this.useitem(1);
                        if ((this.AP >= this.ilowap) && (this.AP >= num2))
                        {
                            num = this.explore();
                        }
                        else
                        {
                            num = this.getapbc();
                        }
                    }
                    else if (this.radioButton6.Checked)
                    {
                        this.useitem(0x65);
                        if ((this.AP >= this.ilowap) && (this.AP >= num2))
                        {
                            num = this.explore();
                        }
                        else
                        {
                            num = this.getapbc();
                        }
                    }
                    else
                    {
                        num = this.getapbc();
                    }
                    if (num == 0x41)
                    {
                        while (this.bAting)
                        {
                            Thread.Sleep(0x3e8);
                        }
                        this.ioldre = 1;
                        this._AttackEventEx.BeginInvoke(null, EventArgs.Empty, null, null);
                        num = 3;
                    }
                    else if (num == 3)
                    {
                        if (!(this.bAting || ((this.BC <= this.cardc[1]) && (this.ioldre != 0))))
                        {
                            TimeSpan span = (TimeSpan) (DateTime.Now - this.dtOld);
                            if (span.TotalSeconds > 15.0)
                            {
                                this.ioldre = 1;
                                this._AttackEventEx.BeginInvoke(null, EventArgs.Empty, null, null);
                                continue;
                            }
                        }
                        if (!(this.bAting || ((this.BC >= this.cardc[1]) && (this.ioldre != 0))))
                        {
                            TimeSpan span2 = (TimeSpan) (DateTime.Now - this.dtOld);
                            if (span2.TotalSeconds > 15.0)
                            {
                                if (this.radioButton4.Checked)
                                {
                                    this.useitem(2);
                                    this._AttackEventEx.BeginInvoke(null, EventArgs.Empty, null, null);
                                    continue;
                                }
                                if (this.radioButton5.Checked)
                                {
                                    this.useitem(0x6f);
                                    this._AttackEventEx.BeginInvoke(null, EventArgs.Empty, null, null);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void threadExplore()
        {
            if (this.iServer != 1)
            {
                this.getapbc();
                int num = 0;
                while (this.bThreadExplore)
                {
                    try
                    {
                        num = int.Parse(this.textBox6.Text);
                    }
                    catch (Exception)
                    {
                    }
                    if (!(this.bExplore || (this.AP == this.MaxAP)))
                    {
                        Thread.Sleep(0x3a98);
                        this.getapbc();
                    }
                    else if ((this.AP >= this.ilowap) && (this.AP >= num))
                    {
                        this.explore();
                    }
                    else if (this.radioButton7.Checked)
                    {
                        this.useitem(1);
                        if ((this.AP >= this.ilowap) && (this.AP >= num))
                        {
                            this.explore();
                        }
                    }
                    else if (this.radioButton6.Checked)
                    {
                        this.useitem(0x65);
                        if ((this.AP >= this.ilowap) && (this.AP >= num))
                        {
                            this.explore();
                        }
                    }
                    else
                    {
                        Thread.Sleep(0x2bf20);
                        this.getapbc();
                    }
                }
            }
            else
            {
                this.getapbc();
                int num2 = 0;
                while (this.bThreadExplore)
                {
                    try
                    {
                        num2 = int.Parse(this.textBox6.Text);
                    }
                    catch (Exception)
                    {
                    }
                    if ((!this.bExplore ^ !this.checkBox6.Checked) && (this.AP != this.MaxAP))
                    {
                        Thread.Sleep(0x3e8);
                        this.getapbc();
                    }
                    else
                    {
                        if ((this.AP >= this.ilowap) && (this.AP >= num2))
                        {
                            this.explore_1();
                            continue;
                        }
                        if (this.radioButton7.Checked)
                        {
                            this.useitem(1);
                            if ((this.AP >= this.ilowap) && (this.AP >= num2))
                            {
                                this.explore_1();
                            }
                            continue;
                        }
                        if (this.radioButton6.Checked)
                        {
                            this.useitem(0x65);
                            if ((this.AP >= this.ilowap) && (this.AP >= num2))
                            {
                                this.explore_1();
                            }
                            continue;
                        }
                        Thread.Sleep(0xea60);
                        this.getapbc();
                    }
                }
            }
        }

        public void threadGet()
        {
            this.button16.Enabled = false;
            DataGridViewSelectedCellCollection selectedCells = this.dataGridView3.SelectedCells;
            if (selectedCells.Count >= 1)
            {
                string strr = "";
                int num = 0;
                foreach (DataGridViewCell cell in selectedCells)
                {
                    if (num == 0)
                    {
                        strr = strr + cell.Value.ToString();
                    }
                    else
                    {
                        strr = strr + "," + cell.Value.ToString();
                    }
                    num++;
                    if (num == 20)
                    {
                        this.getRewardsNoSell(strr);
                        num = 0;
                        strr = "";
                    }
                }
                if (strr != "")
                {
                    this.getRewardsNoSell(strr);
                }
                this.button16.Enabled = true;
            }
        }

        private void ThreadGetTickt()
        {
            while (this.bgetTickt)
            {
                if (this.iGuildItemCount < 15)
                {
                    this.getGuildFairyRewards();
                    Thread.Sleep(0xea60);
                }
                else
                {
                    Thread.Sleep(0xea60);
                }
            }
        }

        private void threadMain()
        {
            this.actionlog.Text = this.actionlog.Text + "这个东西对应gooleplay版250,开始登陆,邮箱更新找我GreenDamTan@github\r\n";
            this.radioButton8.Enabled = false;
            
            if (!this.Login())
            {
                this._LoginEvent.BeginInvoke(null, EventArgs.Empty, null, null);
            }
            else
            {
                this.bThreadMain = true;
                this.bLogin = true;
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                this.button5.Enabled = true;
                this.button7.Enabled = true;
                this.button9.Enabled = true;
                this.button10.Enabled = true;
                this.button11.Enabled = true;
                this.button12.Enabled = true;
                this.button13.Enabled = true;
                this.button14.Enabled = true;
                this.button15.Enabled = true;
                this.button16.Enabled = true;
                this.button17.Enabled = true;
                this.button18.Enabled = true;
                this.button20.Enabled = true;
                this.button21.Enabled = true;
                this.button22.Enabled = true;
                this.button23.Enabled = true;
                this.button24.Enabled = true;
                this.button25.Enabled = true;
                this.GetAreaIfo();
                this.button6.Enabled = true;
                if (this.iServer == 0)
                {
                    this.UpdateJob();
                }
                this.button8.Enabled = true;
            }
        }

        public void threadOpen()
        {
            this.button15.Enabled = false;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            string url = "http://" + this.szhostport + "/connect/app/menu/rewardbox?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_007A:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_007A;
            }
            if (document != null)
            {
                int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText);
                this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                XmlNodeList box = null;
                try
                {
                    box = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("rewardbox_list").SelectNodes("rewardbox");
                }
                catch (Exception)
                {
                    this.button15.Enabled = true;
                    return;
                }
                if (box == null)
                {
                    this.button15.Enabled = true;
                    return;
                }
                this.Rewardbox.update(box);
            }
            this.button15.Enabled = true;
        }

        private void threadRank()
        {
            while (this.bThreadRank)
            {
                this.getRankINFO();
                Thread.Sleep(0x7530);
            }
        }

        private void ThreadRigist()
        {
            this.bThreadRigist = true;
            if (this.bNoLimitedBC)
            {
                while (this.iNowUserid == 0)
                {
                    this.iNowUserid = this.getuserid();
                }
                while (this.bNoLimitedBC)
                {
                    try
                    {
                        string toEstr = "";
                        byte[] buffer = Guid.NewGuid().ToByteArray();
                        if (toEstr == "")
                        {
                            for (int k = 9; k < buffer.Length; k++)
                            {
                                toEstr = toEstr + Convert.ToString(buffer[k], 0x10);
                            }
                        }
                        string str2 = toEstr;
                        this.szcookie = "";
                        try
                        {
                            this.key11 = this.baseKey + str2.Substring(0, 0x10);
                        }
                        catch (Exception)
                        {
                            this.key11 = this.baseKey + str2;
                        }
                        for (int i = this.key11.Length; i < 0x20; i++)
                        {
                            this.key11 = this.key11 + "0";
                        }
                        CookieCollection cookies = new CookieCollection();
                        Cookie cookie2 = new Cookie("S", this.szcookie) {
                            Domain = this.szhost
                        };
                        Cookie cookie = cookie2;
                        cookies.Add(cookie);
                        string url = "http://" + this.szhostport + "/connect/app/regist?cyt=1";
                        Dictionary<string, string> dictionary = new Dictionary<string, string>();
                        dictionary.Add("", "");
                        IDictionary<string, string> parameters = dictionary;
                        parameters.Clear();
                        parameters.Add("login_id", this.Encrypt(str2, this.key0));
                        parameters.Add("password", this.Encrypt(toEstr, this.key0));
                        string str4 = "";
                        for (int j = 8; j < buffer.Length; j++)
                        {
                            str4 = str4 + Convert.ToString(buffer[j], 0x10);
                        }
                        parameters.Add("param", this.Encrypt(str4, this.key0));
                        XmlDocument document = null;
                    Label_0208:;
                        try
                        {
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            goto Label_0208;
                        }
                        if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                        {
                            continue;
                        }
                        this.szcookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                        int num4 = 100;
                        Cookie cookie3 = new Cookie("S", this.szcookie) {
                            Domain = this.szhost
                        };
                        cookie = cookie3;
                        cookies.Add(cookie);
                        num4 = 100;
                        string str5 = "教程" + num4.ToString();
                        url = "http://" + this.szhostport + "/connect/app/tutorial/next?cyt=1";
                        parameters.Clear();
                        parameters.Add("S", this.Encrypt(this.szcookie, this.key0));
                        parameters.Add("step", this.Encrypt(num4.ToString(), this.key0));
                        try
                        {
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                        num4 = 0x1b71;
                        string str6 = "教程" + num4.ToString();
                        url = "http://" + this.szhostport + "/connect/app/tutorial/next?cyt=1";
                        parameters.Clear();
                        parameters.Add("S", this.Encrypt(this.szcookie, this.key0));
                        parameters.Add("step", this.Encrypt(num4.ToString(), this.key0));
                        try
                        {
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                        string str7 = "教程" + 0x1f40.ToString() + "教程完成";
                        parameters.Clear();
                        parameters.Add("S", this.Encrypt(this.szcookie, this.key0));
                        parameters.Add("step", this.Encrypt("8000", this.key0));
                        try
                        {
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                        if (document == null)
                        {
                            continue;
                        }
                        this.szcookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                        int iuser = int.Parse(document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("login").SelectSingleNode("user_id").InnerText);
                        Cookie cookie4 = new Cookie("S", this.szcookie) {
                            Domain = this.szhost
                        };
                        cookie = cookie4;
                        cookies.Add(cookie);
                        url = "http://" + this.szhostport + "/connect/app/friend/add_friend?cyt=1";
                    Label_0569:;
                        try
                        {
                            parameters.Clear();
                            parameters.Add("dialog", this.Encrypt("1", this.key11));
                            parameters.Add("user_id", this.Encrypt(this.iNowUserid.ToString(), this.key11));
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            goto Label_0569;
                        }
                        this.alowuser(iuser);
                        this.setbc();
                        Cookie cookie5 = new Cookie("S", this.szcookie) {
                            Domain = this.szhost
                        };
                        cookie = cookie5;
                        cookies.Add(cookie);
                        int num6 = 0;
                        url = "http://" + this.szhostport + "/connect/app/friend/remove_friend?cyt=1";
                    Label_0637:;
                        try
                        {
                            parameters.Clear();
                            parameters.Add("dialog", this.Encrypt("1", this.key11));
                            parameters.Add("user_id", this.Encrypt(this.iNowUserid.ToString(), this.key11));
                            document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
                        }
                        catch (Exception)
                        {
                            num6++;
                            if (num6 <= 5)
                            {
                                goto Label_0637;
                            }
                        }
                        this.bActNoLimit = false;
                        continue;
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
            this.bThreadRigist = true;
        }

        public void threadsellselect()
        {
            this.button18.Enabled = false;
            DataGridViewSelectedCellCollection selectedCells = this.dataGridView2.SelectedCells;
            if (selectedCells.Count >= 1)
            {
                string str = "";
                int num = 0;
                foreach (DataGridViewCell cell in selectedCells)
                {
                    if (num == 0)
                    {
                        str = str + cell.Value.ToString();
                    }
                    else
                    {
                        str = str + "," + cell.Value.ToString();
                    }
                    num++;
                    if (num == 30)
                    {
                        this.sellcard(str);
                        num = 0;
                        str = "";
                    }
                }
                if (str != "")
                {
                    this.sellcard(str);
                }
                this.allcards.update(this.cardlist, this.comboBox4.SelectedIndex + 1);
                this.button18.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.iTIME++;
            this.lbBCAP.Text = string.Concat(new object[] { "BC:", this.BC, "/", this.MaxBc, "AP:", this.AP, "/" });
        }

        private void UpdateJob()
        {
            string url = "http://" + this.szhostport + "/connect/app/job/job_top?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
            this.actionlog.Text = this.actionlog.Text + "更新职业\r\n";
        Label_006B:;
            try
            {
                document = this.CreatePostHttpResponse(url, null, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_006B;
            }
            this.areaxml = document;
            if (document != null)
            {
                XmlNode node = document.SelectSingleNode("response").SelectSingleNode("body").SelectSingleNode("job_top");
                XmlNodeList list = node.SelectNodes("job_states");
                this.iJobID = int.Parse(node.SelectSingleNode("equipping_job_id").InnerText);
                this.comboBox2.Items.Clear();
                int num = 0;
                foreach (XmlNode node2 in list)
                {
                    string str2;
                    int num2 = int.Parse(node2.SelectSingleNode("job_id").InnerText);
                    int num3 = int.Parse(node2.SelectSingleNode("job_lv").InnerText);
                    switch (num2)
                    {
                        case 1:
                            str2 = "士兵|" + num3;
                            break;

                        case 2:
                            str2 = "武斗|" + num3;
                            break;

                        case 3:
                            str2 = "操纵|" + num3;
                            break;

                        case 4:
                            str2 = "弓手|" + num3;
                            break;

                        case 5:
                            str2 = "(推荐)风水|" + num3;
                            break;

                        case 6:
                            str2 = "曜魔|" + num3;
                            break;

                        case 7:
                            str2 = "会长|" + num3;
                            break;

                        case 8:
                            str2 = "妹妹|" + num3;
                            break;

                        default:
                            str2 = "??|" + num3;
                            break;
                    }
                    this.actionlog.Text = this.actionlog.Text + str2 + "、";
                    ComboBoxItem item2 = new ComboBoxItem {
                        Value = num2,
                        Text = str2
                    };
                    ComboBoxItem item = item2;
                    this.comboBox2.Items.Add(item);
                    if (num2 == this.iJobID)
                    {
                        this.comboBox2.SelectedIndex = num;
                    }
                    num++;
                }
                this.actionlog.Text = this.actionlog.Text + "\r\n";
            }
        }

        private void useitem(int iD)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("item_id", this.Encrypt(iD.ToString(), this.key12));
            string url = "http://" + this.szhostport + "/connect/app/item/use?cyt=1";
            CookieCollection cookies = new CookieCollection();
            Cookie cookie2 = new Cookie("S", this.szCookie) {
                Domain = this.szhost
            };
            Cookie cookie = cookie2;
            cookies.Add(cookie);
            XmlDocument document = null;
        Label_008C:;
            try
            {
                document = this.CreatePostHttpResponse(url, parameters, 0xc350, string.Empty, Encoding.Default, cookies);
            }
            catch (Exception)
            {
                goto Label_008C;
            }
            if (document != null)
            {
                try
                {
                    if (int.Parse(document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("code").InnerText) != 0)
                    {
                        string message = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("error").SelectSingleNode("message").InnerText + "\r\n";
                        string text = this.actionlog.Text;
                        this.actionlog.Text = text + "[" + DateTime.Now.ToString() + "]" + message;
                        this.actionlog.WriteInfo(message);
                    }
                    this.szCookie = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("session_id").InnerText;
                    XmlNode node = document.SelectSingleNode("response").SelectSingleNode("header").SelectSingleNode("your_data");
                    this.szCharName = node.SelectSingleNode("name").InnerText;
                    XmlNode node2 = node.SelectSingleNode("bc");
                    this.BC = int.Parse(node2.SelectSingleNode("current").InnerText);
                    this.MaxBc = int.Parse(node2.SelectSingleNode("max").InnerText);
                    XmlNode node3 = node.SelectSingleNode("ap");
                    this.AP = int.Parse(node3.SelectSingleNode("current").InnerText);
                    this.MaxAP = int.Parse(node3.SelectSingleNode("max").InnerText);
                }
                catch (Exception exception)
                {
                    string str4 = this.actionlog.Text;
                    this.actionlog.Text = str4 + "[" + DateTime.Now.ToString() + "]" + exception.Message + "\r\n";
                    this.actionlog.WriteInfo(exception.Message + "\r\n");
                }
            }
        }

        public bool bExplore { get; set; }

        public int iMasterBossID { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

