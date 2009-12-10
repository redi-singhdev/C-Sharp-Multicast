using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Multicast_test;

namespace Mutlicast
{
    public partial class Form1 : Form
    {
        OpenFileDialog openDlg = new OpenFileDialog();
        SaveFileDialog saveDlg = new SaveFileDialog();

        Timer Clock;
        Controller controller;

        int selected = 0;

        public Form1()
        {
            InitializeComponent();

            //hiders**************************8
            //sender
            HideEverything();

            Clock = new Timer();
            Clock.Interval = 500;

            RecievingBar.Maximum = 100;
            RecievingBar.Minimum = 0;
            SendingBar.Maximum = 100;
            SendingBar.Minimum = 0;

            controller = new Controller("224.1.1.1", 9001);

            Starting();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Timers *****************************************************
        private void RecivingUpdater(object sender, EventArgs e)
        {
            RecievingBar.Value = (int)(controller.GetPercent() * 100);
            if (controller.ReceiveChecker())
            {
                Clock.Tick -= new EventHandler(RecivingUpdater);
                Clock.Stop();
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Yous Got!");
            }
            label1.Text = controller.GetStats()[0].ToString();
            label2.Text = controller.GetStats()[1].ToString();
            
        }

        private void SendingUpdater(object sender, EventArgs e)
        {
            SendingBar.Value = (int)(controller.GetPercent() * 100);
            if (controller.SendChecker())
            {
                Clock.Tick -= new EventHandler(SendingUpdater);
                Clock.Stop();
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Dun Sending!!");
                SendingBar.Value = 100;
            }
            label3.Text = controller.GetStats()[1].ToString();
        }

        public void filesender(object sender, EventArgs e)
        {
            controller.SendFileInfo();
        }

        public void filesupdater(object sender, EventArgs e)
        {
            selected = FileList.SelectedIndex;
            FileList.Items.Clear();
            controller.UpdateFilesAvailable();
            List<List<string>> files = controller.GetFilesAvailable();
            foreach (List<string> file in files)
            {
                string everything = "1***" + file[2] +"***1";
                FileList.Items.Add(everything);
            }
            if (FileList.SelectedItem == null && FileList.Items.Count > 0)
                FileList.SelectedIndex = selected;

        }

        //Clear Everything************************************************
        public void HideEverything()
        {
            StartingPane.Hide();
            SendingFile.Hide();
            SendFileSelect.Hide();
            GetFile.Hide();
            Recieving.Hide();
        }

        //Button Functions********************************************
        private void BrowseUpload(object sender, EventArgs e)
        {
            string filename = (openDlg.ShowDialog() == DialogResult.OK) ? openDlg.FileName : null;
            if (filename != null)
            {
                StreamReader rend = new StreamReader(filename);
                if (!controller.SetReadFile(filename))
                    MessageBox.Show("Fail!");
                rend.Close();
            }
            Sender();
        }
        

        //Form Modifiers*****************************************************
        //**********************************************************
        private void Starting()
        {
            try
            {
                Clock.Tick += new EventHandler(filesupdater);
                Clock.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            HideEverything();
            StartingPane.Show();
            Rectangle position = new Rectangle(5, 5, StartingPane.Width, StartingPane.Height);
            Rectangle windowsize = new Rectangle(400, 500, StartingPane.Width + 25, StartingPane.Height + 50);
            StartingPane.Bounds = position;
            this.Bounds = windowsize;
        }

        //SENDERS************************************************************
        private void Send_Click(object sender, EventArgs e)
        {
            controller.StartSending();
            Sending();
        }
        
        private void Sender()
        {
            HideEverything();
            SendFileSelect.Show();
            Rectangle position = new Rectangle(5, 5, SendFileSelect.Width, SendFileSelect.Height);
            Rectangle windowsize = new Rectangle(400, 500, SendFileSelect.Width + 25, SendFileSelect.Height + 50);
            SendFileSelect.Bounds = position;
            this.Bounds = windowsize;

            Clock.Tick += new EventHandler(filesender);
            Clock.Start();
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

        //RECIEVING FILES****************************************************
        private void Get_Click(object sender, EventArgs e)
        {
            HideEverything();
            GetFile.Show();
            Rectangle position = new Rectangle(5, 5, GetFile.Width, GetFile.Height);
            Rectangle windowsize = new Rectangle(400, 500, GetFile.Width + 25, GetFile.Height + 50);
            GetFile.Bounds = position;
            this.Bounds = windowsize;
        }

        private void RecieveDirectory(object sender, EventArgs e)
        {
            HideEverything();
            string filename = (saveDlg.ShowDialog() == DialogResult.OK) ? saveDlg.FileName : null;
            if (filename != null)
            {
                controller.SetWriteFile(filename, 115);
            }

            Recieving.Show();
            Rectangle position = new Rectangle(5, 5, Recieving.Width, Recieving.Height);
            Rectangle windowsize = new Rectangle(400, 500, Recieving.Width + 25, Recieving.Height + 50);
            Recieving.Bounds = position;
            this.Bounds = windowsize;

            Clock.Tick += new EventHandler(RecivingUpdater);
            Clock.Start();
        }

        private void ChangeDirectory(object sender, EventArgs e)
        {
            string filename = (saveDlg.ShowDialog() == DialogResult.OK) ? saveDlg.FileName : null;
            if (filename != null)
            {
                StreamWriter writer = new StreamWriter(filename, true);
                this.Text = filename;
                writer.Close();
            }
        }


        //Cancels*********************************************************
        private void CancelSelect(object sender, EventArgs e)
        {
            Starting();
        }
        private void CancelSending(object sender, EventArgs e)
        {
            Sender();
            controller.reset_stats();
        }
        private void CancelRecieve(object sender, EventArgs e)
        {
            HideEverything();
            GetFile.Show();
        }
        private void CancelGet(object sender, EventArgs e)
        {
            Starting();
        }
    }
}
