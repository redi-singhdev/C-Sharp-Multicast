using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mutlicast
{
    public partial class Form1 : Form
    {
        bool changed = false;
        OpenFileDialog openDlg = new OpenFileDialog();

        Timer Clock;


        public Form1()
        {
            InitializeComponent();

            //hiders**************************8
            //sender
            HideEverything();
            Starting();

            ListViewItem test = new ListViewItem("bugger");
            test.SubItems.Add("poop");
            ClientList.Items.Add(test);
            Clock = new Timer();
         
            RecievingBar.Maximum = 100;
            RecievingBar.Minimum = 0;
            SendingBar.Maximum = 100;
            SendingBar.Minimum = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RecivingUpdater(object sender, EventArgs e)
        {
            if (RecievingBar.Value < 100)
                RecievingBar.Value += 1;
        }

        private void SendingUpdater(object sender, EventArgs e)
        {
            if (SendingBar.Value < 100)
                SendingBar.Value += 1;
        }

        //Button Functions********************************************
        private void button1_Click(object sender, EventArgs e)
        {
            string filename = (openDlg.ShowDialog() == DialogResult.OK) ? openDlg.FileName : null;
            if (filename != null)
            {
                StreamReader rend = new StreamReader(filename);
                TextBox.Text = rend.ReadToEnd();
                rend.Close();
                changed = false;
                Sender();
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            Sending();
        }

        public void HideEverything()
        {
            StartingPane.Hide();
            SendingFile.Hide();
            SendFileSelect.Hide();
            GetFile.Hide();
            Recieving.Hide();
        }

        //Form Modifiers*************************************************8
        private void Starting()
        {

            HideEverything();
            StartingPane.Show();
            Rectangle position = new Rectangle(5, 5, StartingPane.Width, StartingPane.Height);
            Rectangle windowsize = new Rectangle(400, 500, StartingPane.Width + 25, StartingPane.Height + 50);
            StartingPane.Bounds = position;
            this.Bounds = windowsize;
        }

        private void Sender()
        {
            HideEverything();
            SendFileSelect.Show();
            Rectangle position = new Rectangle(5, 5, SendFileSelect.Width, SendFileSelect.Height);
            Rectangle windowsize = new Rectangle(400, 500, SendFileSelect.Width + 25, SendFileSelect.Height + 50);
            SendFileSelect.Bounds = position;
            this.Bounds = windowsize;

        }

        private void Sending()
        {
            HideEverything();
            SendingFile.Show();
            Rectangle position = new Rectangle(5, 5, SendingFile.Width, SendingFile.Height);
            Rectangle windowsize = new Rectangle(400, 500, SendingFile.Width + 25, SendingFile.Height + 50);
            SendingFile.Bounds = position;
            this.Bounds = windowsize;

            Clock.Tick += new EventHandler(SendingUpdater);
            Clock.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sender();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Starting();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            HideEverything();
            GetFile.Show();
            Rectangle position = new Rectangle(5, 5, GetFile.Width, GetFile.Height);
            Rectangle windowsize = new Rectangle(400, 500, GetFile.Width + 25, GetFile.Height + 50);
            GetFile.Bounds = position;
            this.Bounds = windowsize;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HideEverything();
            string filename = (openDlg.ShowDialog() == DialogResult.OK) ? openDlg.FileName : null;
            if (filename != null)
            {
                StreamReader rend = new StreamReader(filename);
                TextBox.Text = rend.ReadToEnd();
                rend.Close();
                changed = false;
            }

            Recieving.Show();
            Rectangle position = new Rectangle(5, 5, Recieving.Width, Recieving.Height);
            Rectangle windowsize = new Rectangle(400, 500, Recieving.Width + 25, Recieving.Height + 50);
            Recieving.Bounds = position;
            this.Bounds = windowsize;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = (openDlg.ShowDialog() == DialogResult.OK) ? openDlg.FileName : null;
            if (filename != null)
            {
                StreamReader rend = new StreamReader(filename);
                TextBox.Text = rend.ReadToEnd();
                rend.Close();
                changed = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HideEverything();
            GetFile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Starting();
        }
    }
}
