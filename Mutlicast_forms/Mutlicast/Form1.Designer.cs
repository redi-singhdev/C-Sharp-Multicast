namespace Mutlicast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NetworkFiles = new System.Windows.Forms.Label();
            this.Browsebtn = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.Clients = new System.Windows.Forms.Label();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.Cancel4btn = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.Cancel1btn = new System.Windows.Forms.Button();
            this.SaveTobtn = new System.Windows.Forms.Button();
            this.SavingTo = new System.Windows.Forms.Label();
            this.WaitingFor = new System.Windows.Forms.Label();
            this.FN = new System.Windows.Forms.Label();
            this.SaveTo = new System.Windows.Forms.Label();
            this.Cancel2btn = new System.Windows.Forms.Button();
            this.RecievingBar = new System.Windows.Forms.ProgressBar();
            this.RF = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ClientsConnected = new System.Windows.Forms.Label();
            this.Cancel3btn = new System.Windows.Forms.Button();
            this.SendingBar = new System.Windows.Forms.ProgressBar();
            this.SF = new System.Windows.Forms.Label();
            this.SendingFile = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingPane = new System.Windows.Forms.TableLayoutPanel();
            this.Getbtn = new System.Windows.Forms.Button();
            this.SendFileSelect = new System.Windows.Forms.TableLayoutPanel();
            this.Recieving = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetFile = new System.Windows.Forms.TableLayoutPanel();
            this.OMGToooooooool = new System.Windows.Forms.ToolTip(this.components);
            this.SendingFile.SuspendLayout();
            this.StartingPane.SuspendLayout();
            this.SendFileSelect.SuspendLayout();
            this.Recieving.SuspendLayout();
            this.GetFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // NetworkFiles
            // 
            this.NetworkFiles.AutoSize = true;
            this.NetworkFiles.Location = new System.Drawing.Point(3, 32);
            this.NetworkFiles.Name = "NetworkFiles";
            this.NetworkFiles.Size = new System.Drawing.Size(129, 13);
            this.NetworkFiles.TabIndex = 2;
            this.NetworkFiles.Text = "Files available on network";
            // 
            // Browsebtn
            // 
            this.Browsebtn.Location = new System.Drawing.Point(3, 3);
            this.Browsebtn.Name = "Browsebtn";
            this.Browsebtn.Size = new System.Drawing.Size(75, 23);
            this.Browsebtn.TabIndex = 3;
            this.Browsebtn.Text = "Browse";
            this.OMGToooooooool.SetToolTip(this.Browsebtn, "Find A File to Upload");
            this.Browsebtn.UseVisualStyleBackColor = true;
            this.Browsebtn.Click += new System.EventHandler(this.BrowseUpload);
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Items.AddRange(new object[] {
            "StarCraft.iso",
            "BroodWar.iso"});
            this.FileList.Location = new System.Drawing.Point(3, 54);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(235, 95);
            this.FileList.TabIndex = 4;
            this.OMGToooooooool.SetToolTip(this.FileList, "Files Available");
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Items.AddRange(new object[] {
            "Tom - Laptop",
            "Adam - Laptop"});
            this.ClientList.Location = new System.Drawing.Point(3, 68);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(156, 95);
            this.ClientList.TabIndex = 13;
            this.OMGToooooooool.SetToolTip(this.ClientList, "People Connected");
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Location = new System.Drawing.Point(3, 47);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(93, 13);
            this.Clients.TabIndex = 12;
            this.Clients.Text = "Clients Connected";
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(3, 20);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(75, 23);
            this.Sendbtn.TabIndex = 11;
            this.Sendbtn.Text = "Send";
            this.OMGToooooooool.SetToolTip(this.Sendbtn, "Start Sending the file");
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel4btn
            // 
            this.Cancel4btn.Location = new System.Drawing.Point(3, 171);
            this.Cancel4btn.Name = "Cancel4btn";
            this.Cancel4btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel4btn.TabIndex = 10;
            this.Cancel4btn.Text = "Cancel";
            this.OMGToooooooool.SetToolTip(this.Cancel4btn, "Cancel");
            this.Cancel4btn.UseVisualStyleBackColor = true;
            this.Cancel4btn.Click += new System.EventHandler(this.CancelSelect);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(3, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(57, 13);
            this.FileName.TabIndex = 8;
            this.FileName.Text = "File Name:";
            // 
            // Cancel1btn
            // 
            this.Cancel1btn.Location = new System.Drawing.Point(3, 99);
            this.Cancel1btn.Name = "Cancel1btn";
            this.Cancel1btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel1btn.TabIndex = 21;
            this.Cancel1btn.Text = "Cancel";
            this.OMGToooooooool.SetToolTip(this.Cancel1btn, "Cancel");
            this.Cancel1btn.UseVisualStyleBackColor = true;
            this.Cancel1btn.Click += new System.EventHandler(this.CancelGet);
            // 
            // SaveTobtn
            // 
            this.SaveTobtn.Location = new System.Drawing.Point(3, 68);
            this.SaveTobtn.Name = "SaveTobtn";
            this.SaveTobtn.Size = new System.Drawing.Size(75, 23);
            this.SaveTobtn.TabIndex = 20;
            this.SaveTobtn.Text = "Save To...";
            this.OMGToooooooool.SetToolTip(this.SaveTobtn, "Choose A Place to Save the File");
            this.SaveTobtn.UseVisualStyleBackColor = true;
            this.SaveTobtn.Click += new System.EventHandler(this.RecieveDirectory);
            // 
            // SavingTo
            // 
            this.SavingTo.AutoSize = true;
            this.SavingTo.Location = new System.Drawing.Point(3, 45);
            this.SavingTo.Name = "SavingTo";
            this.SavingTo.Size = new System.Drawing.Size(59, 13);
            this.SavingTo.TabIndex = 18;
            this.SavingTo.Text = "Saving To:";
            // 
            // WaitingFor
            // 
            this.WaitingFor.AutoSize = true;
            this.WaitingFor.Location = new System.Drawing.Point(3, 23);
            this.WaitingFor.Name = "WaitingFor";
            this.WaitingFor.Size = new System.Drawing.Size(64, 13);
            this.WaitingFor.TabIndex = 16;
            this.WaitingFor.Text = "Waiting For:";
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Location = new System.Drawing.Point(3, 0);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(26, 13);
            this.FN.TabIndex = 14;
            this.FN.Text = "File:";
            // 
            // SaveTo
            // 
            this.SaveTo.AutoSize = true;
            this.SaveTo.Location = new System.Drawing.Point(3, 42);
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.Size = new System.Drawing.Size(55, 13);
            this.SaveTo.TabIndex = 25;
            this.SaveTo.Text = "Saving to:";
            // 
            // Cancel2btn
            // 
            this.Cancel2btn.Location = new System.Drawing.Point(3, 60);
            this.Cancel2btn.Name = "Cancel2btn";
            this.Cancel2btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel2btn.TabIndex = 24;
            this.Cancel2btn.Text = "Cancel";
            this.OMGToooooooool.SetToolTip(this.Cancel2btn, "Cancel");
            this.Cancel2btn.UseVisualStyleBackColor = true;
            this.Cancel2btn.Click += new System.EventHandler(this.CancelRecieve);
            // 
            // RecievingBar
            // 
            this.RecievingBar.Location = new System.Drawing.Point(3, 16);
            this.RecievingBar.Name = "RecievingBar";
            this.RecievingBar.Size = new System.Drawing.Size(203, 23);
            this.RecievingBar.TabIndex = 23;
            this.OMGToooooooool.SetToolTip(this.RecievingBar, "How Much Left to Recieve");
            // 
            // RF
            // 
            this.RF.AutoSize = true;
            this.RF.Location = new System.Drawing.Point(3, 0);
            this.RF.Name = "RF";
            this.RF.Size = new System.Drawing.Size(58, 13);
            this.RF.TabIndex = 22;
            this.RF.Text = "Recieving:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tom - Laptop",
            "Adam - Laptop"});
            this.listBox1.Location = new System.Drawing.Point(3, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 82);
            this.listBox1.TabIndex = 33;
            this.OMGToooooooool.SetToolTip(this.listBox1, "People Downloading the file");
            // 
            // ClientsConnected
            // 
            this.ClientsConnected.AutoSize = true;
            this.ClientsConnected.Location = new System.Drawing.Point(3, 44);
            this.ClientsConnected.Name = "ClientsConnected";
            this.ClientsConnected.Size = new System.Drawing.Size(96, 13);
            this.ClientsConnected.TabIndex = 32;
            this.ClientsConnected.Text = "Clients Connected:";
            // 
            // Cancel3btn
            // 
            this.Cancel3btn.Location = new System.Drawing.Point(3, 155);
            this.Cancel3btn.Name = "Cancel3btn";
            this.Cancel3btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel3btn.TabIndex = 31;
            this.Cancel3btn.Text = "Cancel";
            this.OMGToooooooool.SetToolTip(this.Cancel3btn, "Cancel");
            this.Cancel3btn.UseVisualStyleBackColor = true;
            this.Cancel3btn.Click += new System.EventHandler(this.CancelSending);
            // 
            // SendingBar
            // 
            this.SendingBar.Location = new System.Drawing.Point(3, 16);
            this.SendingBar.Name = "SendingBar";
            this.SendingBar.Size = new System.Drawing.Size(204, 23);
            this.SendingBar.TabIndex = 30;
            this.OMGToooooooool.SetToolTip(this.SendingBar, "How Much Left to Send");
            // 
            // SF
            // 
            this.SF.AutoSize = true;
            this.SF.Location = new System.Drawing.Point(3, 0);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(65, 13);
            this.SF.TabIndex = 29;
            this.SF.Text = "Sending File";
            // 
            // SendingFile
            // 
            this.SendingFile.AutoSize = true;
            this.SendingFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendingFile.ColumnCount = 1;
            this.SendingFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendingFile.Controls.Add(this.label3, 0, 5);
            this.SendingFile.Controls.Add(this.SF, 0, 0);
            this.SendingFile.Controls.Add(this.SendingBar, 0, 1);
            this.SendingFile.Controls.Add(this.Cancel3btn, 0, 4);
            this.SendingFile.Controls.Add(this.ClientsConnected, 0, 2);
            this.SendingFile.Controls.Add(this.listBox1, 0, 3);
            this.SendingFile.Location = new System.Drawing.Point(12, 223);
            this.SendingFile.Name = "SendingFile";
            this.SendingFile.RowCount = 6;
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SendingFile.Size = new System.Drawing.Size(210, 203);
            this.SendingFile.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "label3";
            // 
            // StartingPane
            // 
            this.StartingPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartingPane.ColumnCount = 2;
            this.StartingPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartingPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartingPane.Controls.Add(this.Getbtn, 0, 5);
            this.StartingPane.Controls.Add(this.FileList, 0, 4);
            this.StartingPane.Controls.Add(this.NetworkFiles, 0, 3);
            this.StartingPane.Controls.Add(this.Browsebtn, 0, 2);
            this.StartingPane.Location = new System.Drawing.Point(12, 12);
            this.StartingPane.Name = "StartingPane";
            this.StartingPane.RowCount = 7;
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StartingPane.Size = new System.Drawing.Size(241, 205);
            this.StartingPane.TabIndex = 37;
            // 
            // Getbtn
            // 
            this.Getbtn.Location = new System.Drawing.Point(3, 157);
            this.Getbtn.Name = "Getbtn";
            this.Getbtn.Size = new System.Drawing.Size(75, 23);
            this.Getbtn.TabIndex = 41;
            this.Getbtn.Text = "Get";
            this.OMGToooooooool.SetToolTip(this.Getbtn, "Start Downloading The Selected File");
            this.Getbtn.UseVisualStyleBackColor = true;
            this.Getbtn.Click += new System.EventHandler(this.Get_Click);
            // 
            // SendFileSelect
            // 
            this.SendFileSelect.AutoSize = true;
            this.SendFileSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendFileSelect.ColumnCount = 1;
            this.SendFileSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendFileSelect.Controls.Add(this.FileName, 0, 1);
            this.SendFileSelect.Controls.Add(this.Sendbtn, 0, 2);
            this.SendFileSelect.Controls.Add(this.Clients, 0, 3);
            this.SendFileSelect.Controls.Add(this.ClientList, 0, 4);
            this.SendFileSelect.Controls.Add(this.Cancel4btn, 0, 5);
            this.SendFileSelect.Location = new System.Drawing.Point(259, 12);
            this.SendFileSelect.Name = "SendFileSelect";
            this.SendFileSelect.RowCount = 6;
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SendFileSelect.Size = new System.Drawing.Size(162, 200);
            this.SendFileSelect.TabIndex = 38;
            // 
            // Recieving
            // 
            this.Recieving.AutoSize = true;
            this.Recieving.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Recieving.ColumnCount = 1;
            this.Recieving.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Recieving.Controls.Add(this.RecievingBar, 0, 1);
            this.Recieving.Controls.Add(this.RF, 0, 0);
            this.Recieving.Controls.Add(this.SaveTo, 0, 2);
            this.Recieving.Controls.Add(this.Cancel2btn, 0, 3);
            this.Recieving.Controls.Add(this.label1, 0, 4);
            this.Recieving.Controls.Add(this.label2, 0, 5);
            this.Recieving.Location = new System.Drawing.Point(228, 223);
            this.Recieving.Name = "Recieving";
            this.Recieving.RowCount = 6;
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Recieving.Size = new System.Drawing.Size(209, 131);
            this.Recieving.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // GetFile
            // 
            this.GetFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetFile.ColumnCount = 1;
            this.GetFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetFile.Controls.Add(this.FN, 0, 0);
            this.GetFile.Controls.Add(this.WaitingFor, 0, 1);
            this.GetFile.Controls.Add(this.SavingTo, 0, 2);
            this.GetFile.Controls.Add(this.SaveTobtn, 0, 3);
            this.GetFile.Controls.Add(this.Cancel1btn, 0, 4);
            this.GetFile.Location = new System.Drawing.Point(424, 12);
            this.GetFile.Name = "GetFile";
            this.GetFile.RowCount = 5;
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.GetFile.Size = new System.Drawing.Size(162, 127);
            this.GetFile.TabIndex = 40;
            // 
            // OMGToooooooool
            // 
            this.OMGToooooooool.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 439);
            this.Controls.Add(this.GetFile);
            this.Controls.Add(this.Recieving);
            this.Controls.Add(this.SendFileSelect);
            this.Controls.Add(this.StartingPane);
            this.Controls.Add(this.SendingFile);
            this.Name = "Form1";
            this.Text = "Multicasting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SendingFile.ResumeLayout(false);
            this.SendingFile.PerformLayout();
            this.StartingPane.ResumeLayout(false);
            this.StartingPane.PerformLayout();
            this.SendFileSelect.ResumeLayout(false);
            this.SendFileSelect.PerformLayout();
            this.Recieving.ResumeLayout(false);
            this.Recieving.PerformLayout();
            this.GetFile.ResumeLayout(false);
            this.GetFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NetworkFiles;
        private System.Windows.Forms.Button Browsebtn;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.Button Cancel4btn;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button Cancel1btn;
        private System.Windows.Forms.Button SaveTobtn;
        private System.Windows.Forms.Label SavingTo;
        private System.Windows.Forms.Label WaitingFor;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.Label SaveTo;
        private System.Windows.Forms.Button Cancel2btn;
        private System.Windows.Forms.ProgressBar RecievingBar;
        private System.Windows.Forms.Label RF;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ClientsConnected;
        private System.Windows.Forms.Button Cancel3btn;
        private System.Windows.Forms.ProgressBar SendingBar;
        private System.Windows.Forms.Label SF;
        private System.Windows.Forms.TableLayoutPanel SendingFile;
        private System.Windows.Forms.TableLayoutPanel StartingPane;
        private System.Windows.Forms.TableLayoutPanel SendFileSelect;
        private System.Windows.Forms.TableLayoutPanel Recieving;
        private System.Windows.Forms.TableLayoutPanel GetFile;
        private System.Windows.Forms.Button Getbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip OMGToooooooool;
    }
}

