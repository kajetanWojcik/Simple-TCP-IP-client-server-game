using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Client.ChatService;

namespace Client
{
    public partial class frmClient : Form
    {
        ReceiveClient rc = null;
        string myName;
        int i = 0;
        int x = 0;
        bool stop_dodawanie=false;
        int czas = 0;
        int czas_koniec;
        int odliczanie = 50;
        bool me_ready = false;
        bool you_ready = false;
       
        public frmClient()
        {
            InitializeComponent();
            this.FormClosing+=new FormClosingEventHandler(frmClient_FormClosing);
        }

        

        private void frmClient_FormClosing(object sender, EventArgs e)
        {
            rc.Stop(myName);
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            txtMsgs.Enabled = false;
            PictureBox1.Enabled = false;
            labelLose.Visible = false;
            labelWin.Visible = false;
            labelOdliczanie.Visible = false;
            buttonReady.Enabled = false;

        }

        void rc_ReceiveMsg(string sender, string msg)
        {
           

            x = Int32.Parse(msg);

            if (x > 32)
            {
                if (msg.Length > 0)
                    txtMsgs.Text += Environment.NewLine + sender + " GOTOWY !";

                you_ready = true;

                if (me_ready && you_ready)
                {
                    labelOdliczanie.Visible = true;

                    Timer MyTimerOdliczanie = new Timer();
                    MyTimerOdliczanie.Interval = (100);
                    MyTimerOdliczanie.Tick += new EventHandler(Odliczanie_Tick);

                    MyTimerOdliczanie.Start();
                }
            }
            else{
                if (msg.Length > 0)
                    txtMsgs.Text += Environment.NewLine + sender + ": " + msg;

                klik2.Text = msg;

                if (x == 32)
                {
                    stop_dodawanie = true;
                    labelLose.Visible = true;
                    
                }

                pictureBox2.Image = imageList2.Images[x];
            }
        }

        void rc_NewNames(object sender, List<string> names)
        {
            lstClients.Items.Clear();
            foreach (string name in names)
            {
                if (name!=myName)
                    lstClients.Items.Add(name);
            }
        }


        private void SendMessage(string str)
        {
            if (lstClients.Items.Count != 0)
            {
                if(str=="99")
                    txtMsgs.Text += Environment.NewLine + myName + " GOTOWY !";
                else
                    txtMsgs.Text += Environment.NewLine + myName + ": " + str;
                if (lstClients.SelectedItems.Count == 0)
                    rc.SendMessage(str, myName, lstClients.Items[0].ToString());
                else
                    if (!string.IsNullOrEmpty(lstClients.SelectedItem.ToString()))
                    rc.SendMessage(str, myName, lstClients.SelectedItem.ToString());



            }
        }

        /*private void SendMessage()
        {
            if (lstClients.Items.Count != 0)
            {

                txtMsgs.Text += Environment.NewLine + myName + ">" + klik.Text;
                if (lstClients.SelectedItems.Count == 0)
                    rc.SendMessage(klik.Text, myName, lstClients.Items[0].ToString());
                else
                    if (!string.IsNullOrEmpty(lstClients.SelectedItem.ToString()))
                    rc.SendMessage(klik.Text, myName, lstClients.SelectedItem.ToString());


            }
        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0)
            {
                txtMsgs.Enabled = true;
                //PictureBox1.Enabled = true;
                buttonReady.Enabled = true;

                myName = txtUserName.Text.Trim();

                rc = new ReceiveClient();
                rc.Start(rc, myName);

                rc.NewNames += new GotNames(rc_NewNames);
                rc.ReceiveMsg += new ReceviedMessage(rc_ReceiveMsg);

            }
            else
            {
                txtMsgs.Enabled = false;
                PictureBox1.Enabled = false;

            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (stop_dodawanie == false)
            {
                i++;
                if (i >= 32) {
                    i = 32;
                    labelWin.Visible = true;
                }
                PictureBox1.Image = imageList1.Images[i];

                klik.Text = i.ToString();

                SendMessage(klik.Text);
            }
             
        }


        private void buttonReady_Click(object sender, EventArgs e)
        {
            me_ready = true;
            SendMessage("99");

            if (me_ready && you_ready)
            {
                labelOdliczanie.Visible = true;

                Timer MyTimerOdliczanie = new Timer();
                MyTimerOdliczanie.Interval = (100);
                MyTimerOdliczanie.Tick += new EventHandler(Odliczanie_Tick);

                MyTimerOdliczanie.Start();
            }
            buttonReady.Enabled = false;

        }



        public void Odliczanie_Tick(object sender, EventArgs e)
        {
            odliczanie -= 1;
             labelOdliczanie.Text = (odliczanie / 10).ToString() + "." + (odliczanie % 10).ToString();

            if (odliczanie == 0)
            {
                txtMsgs.Text += Environment.NewLine + Environment.NewLine + " SIĘGNIJCIE CHMUR !!!" + Environment.NewLine;
                PictureBox1.Enabled = true;
                labelOdliczanie.Visible = false;

                Timer MyTimer = new Timer();
                MyTimer.Interval = (100);
                MyTimer.Tick += new EventHandler(MyTimer_Tick);

                MyTimer.Start();
            }
        }


        public void MyTimer_Tick(object sender, EventArgs e)
        {     
            if (!(x == 32 || i == 32))
                czas += 1;

            labelCzas.Text = (czas / 10).ToString() + "." + (czas % 10).ToString();
        }

        private void labelKlik_Click(object sender, EventArgs e)
        {

        }

        private void klik2_Click(object sender, EventArgs e)
        {

        }

        private void txtMsgs_TextChanged(object sender, EventArgs e)
        {
            txtMsgs.SelectionStart = txtMsgs.Text.Length;
            txtMsgs.ScrollToCaret();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelLose_Click(object sender, EventArgs e)
        {

        }
        private void klik_Click(object sender, EventArgs e)
        {

        }

        private void labelWin_Click(object sender, EventArgs e)
        {

        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCzas_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelOdliczanie_Click(object sender, EventArgs e)
        {

        }
    }
   
}
