using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TS3QueryLib.Core;
using TS3QueryLib.Core.Server;
using TS3QueryLib.Core.Common;
using TS3QueryLib.Core.Common.Responses;

namespace hamsterpajPostDownload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddToListBox(object oo)
        {
            Invoke(new MethodInvoker(
                           delegate { listBox1.Items.Add(oo); }
                           ));
        }
        private void SetAgeLabelString(Label label,int oo)
        {
            Invoke(new MethodInvoker(
                           delegate { label.Text=oo.ToString(); }
                           ));
        }
        int FindMyStringInList(ListBox lb, string searchString, int startIndex)
        {
            int count = 0;
            for (int i = startIndex; i < lb.Items.Count; ++i)
            {
                string lbString = lb.Items[i].ToString();
                if (lbString.Contains(searchString))
                {
                    Console.WriteLine(lbString);
                    count++;
                }
            }
            return count;
        }
        void Page_Load()
        {
            int pages = 0;
            int mainLoop = 1;
            int i = 3;
            int.TryParse(numPagesTextBox.Text, out pages);
            while (mainLoop <= pages)
            {
                string Url = "http://www.hamsterpaj.net/sex_och_sinne/sex/sex_sex?page="+mainLoop.ToString();
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(Url);
                while (i <= 32)
                {


                    //string metascore = doc.DocumentNode.SelectNodes("//*[@id=\"header_17136\"]")[0].InnerText;
                    //Console.WriteLine(metascore);
                    string metadata = doc.DocumentNode.SelectNodes("//*[@id=\"ui_content\"]/div[" + i.ToString() + "]/div/div/div[1]/div/div")[0].InnerText;
                    //Console.WriteLine(metadata);
                    AddToListBox(metadata);
                    i++;
                }
                i = 3;
                Console.WriteLine("page:"+mainLoop);
                mainLoop++;
            }
            SetAgeLabelString(Agelbl13,FindMyStringInList(listBox1,"13",0));
            SetAgeLabelString(Agelbl11, FindMyStringInList(listBox1, "11", 0));

        }
        private void GetPost_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Page_Load();
        }
        string randomPostSelect() {
            int i = listBox1.Items.Count;
            Random rnd = new Random();
            int s = rnd.Next(1,i);
            string item = listBox1.Items[s].ToString();
            return item;
        }
        private void TeamSpeak_Click(object sender, EventArgs e)
        {

            string targetHost = "194.103.0.12";
            ushort targetQueryPort = 10011;
            string login = "Marcus";
            string password = "FXuXk4xQ";
            using (QueryRunner queryRunner = new QueryRunner(new SyncTcpDispatcher(targetHost, targetQueryPort)))
            {
                SimpleResponse loginResponse = queryRunner.Login(login, password);
                if (loginResponse.IsErroneous)
                {
                    Console.WriteLine("error");
                    Console.WriteLine(loginResponse.ErrorMessage);
                }
                else
                {
                    SimpleResponse GlobalMessage = queryRunner.SendGlobalMessage(randomPostSelect());
                    if (!GlobalMessage.IsErroneous)
                    {
                        Console.WriteLine("message sent");
                    }
                    else
                    {
                        Console.WriteLine("message error");
                    }
                }
            }

        }
    }
}
