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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.DragHere = new System.Windows.Forms.Label();
            this.NetworkFiles = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.ListBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.Clients = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.RecievingBar = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SendingBar = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.SendingFile = new System.Windows.Forms.TableLayoutPanel();
            this.StartingPane = new System.Windows.Forms.TableLayoutPanel();
            this.Get = new System.Windows.Forms.Button();
            this.SendFileSelect = new System.Windows.Forms.TableLayoutPanel();
            this.Recieving = new System.Windows.Forms.TableLayoutPanel();
            this.GetFile = new System.Windows.Forms.TableLayoutPanel();
            this.SendingFile.SuspendLayout();
            this.StartingPane.SuspendLayout();
            this.SendFileSelect.SuspendLayout();
            this.Recieving.SuspendLayout();
            this.GetFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(3, 3);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(362, 135);
            this.TextBox.TabIndex = 0;
            // 
            // DragHere
            // 
            this.DragHere.AutoSize = true;
            this.DragHere.Location = new System.Drawing.Point(3, 141);
            this.DragHere.Name = "DragHere";
            this.DragHere.Size = new System.Drawing.Size(85, 13);
            this.DragHere.TabIndex = 1;
            this.DragHere.Text = "Drag file here or ";
            // 
            // NetworkFiles
            // 
            this.NetworkFiles.AutoSize = true;
            this.NetworkFiles.Location = new System.Drawing.Point(3, 193);
            this.NetworkFiles.Name = "NetworkFiles";
            this.NetworkFiles.Size = new System.Drawing.Size(129, 13);
            this.NetworkFiles.TabIndex = 2;
            this.NetworkFiles.Text = "Files available on network";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(3, 164);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.BrowseUpload);
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Items.AddRange(new object[] {
            "StarCraft.iso",
            "BroodWar.iso"});
            this.FileList.Location = new System.Drawing.Point(3, 215);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(362, 95);
            this.FileList.TabIndex = 4;
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Items.AddRange(new object[] {
            "Tom - Laptop",
            "Adam - Laptop"});
            this.ClientList.Location = new System.Drawing.Point(3, 202);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(156, 95);
            this.ClientList.TabIndex = 13;
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Location = new System.Drawing.Point(3, 181);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(93, 13);
            this.Clients.TabIndex = 12;
            this.Clients.Text = "Clients Connected";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(3, 154);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 11;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(3, 305);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelSelect);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(3, 134);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(57, 13);
            this.FileName.TabIndex = 8;
            this.FileName.Text = "File Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 128);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CancelGet);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Change...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RecieveDirectory);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Saving To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Waiting For:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "File:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Change...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeDirectory);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Saving to:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RecievingBar
            // 
            this.RecievingBar.Location = new System.Drawing.Point(3, 19);
            this.RecievingBar.Name = "RecievingBar";
            this.RecievingBar.Size = new System.Drawing.Size(203, 23);
            this.RecievingBar.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Recieving:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tom - Laptop",
            "Adam - Laptop"});
            this.listBox1.Location = new System.Drawing.Point(3, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 95);
            this.listBox1.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Clients Connected:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CancelSending);
            // 
            // SendingBar
            // 
            this.SendingBar.Location = new System.Drawing.Point(3, 21);
            this.SendingBar.Name = "SendingBar";
            this.SendingBar.Size = new System.Drawing.Size(204, 23);
            this.SendingBar.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Sending File";
            // 
            // SendingFile
            // 
            this.SendingFile.ColumnCount = 1;
            this.SendingFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendingFile.Controls.Add(this.label12, 0, 0);
            this.SendingFile.Controls.Add(this.SendingBar, 0, 1);
            this.SendingFile.Controls.Add(this.button5, 0, 4);
            this.SendingFile.Controls.Add(this.label11, 0, 2);
            this.SendingFile.Controls.Add(this.listBox1, 0, 3);
            this.SendingFile.Location = new System.Drawing.Point(12, 527);
            this.SendingFile.Name = "SendingFile";
            this.SendingFile.RowCount = 5;
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.SendingFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.SendingFile.Size = new System.Drawing.Size(224, 201);
            this.SendingFile.TabIndex = 36;
            // 
            // StartingPane
            // 
            this.StartingPane.ColumnCount = 2;
            this.StartingPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartingPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartingPane.Controls.Add(this.Get, 0, 5);
            this.StartingPane.Controls.Add(this.TextBox, 0, 0);
            this.StartingPane.Controls.Add(this.FileList, 0, 4);
            this.StartingPane.Controls.Add(this.DragHere, 0, 1);
            this.StartingPane.Controls.Add(this.NetworkFiles, 0, 3);
            this.StartingPane.Controls.Add(this.Browse, 0, 2);
            this.StartingPane.Location = new System.Drawing.Point(12, 12);
            this.StartingPane.Name = "StartingPane";
            this.StartingPane.RowCount = 6;
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.StartingPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.StartingPane.Size = new System.Drawing.Size(368, 346);
            this.StartingPane.TabIndex = 37;
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(3, 318);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(75, 23);
            this.Get.TabIndex = 41;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // SendFileSelect
            // 
            this.SendFileSelect.ColumnCount = 1;
            this.SendFileSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendFileSelect.Controls.Add(this.FileName, 0, 1);
            this.SendFileSelect.Controls.Add(this.Send, 0, 2);
            this.SendFileSelect.Controls.Add(this.Clients, 0, 3);
            this.SendFileSelect.Controls.Add(this.ClientList, 0, 4);
            this.SendFileSelect.Controls.Add(this.Cancel, 0, 5);
            this.SendFileSelect.Controls.Add(this.textBox1, 0, 0);
            this.SendFileSelect.Location = new System.Drawing.Point(401, 12);
            this.SendFileSelect.Name = "SendFileSelect";
            this.SendFileSelect.RowCount = 6;
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.SendFileSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SendFileSelect.Size = new System.Drawing.Size(164, 334);
            this.SendFileSelect.TabIndex = 38;
            // 
            // Recieving
            // 
            this.Recieving.ColumnCount = 1;
            this.Recieving.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Recieving.Controls.Add(this.RecievingBar, 0, 1);
            this.Recieving.Controls.Add(this.label10, 0, 0);
            this.Recieving.Controls.Add(this.label9, 0, 2);
            this.Recieving.Controls.Add(this.button3, 0, 3);
            this.Recieving.Controls.Add(this.button4, 0, 4);
            this.Recieving.Location = new System.Drawing.Point(252, 584);
            this.Recieving.Name = "Recieving";
            this.Recieving.RowCount = 5;
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.Recieving.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Recieving.Size = new System.Drawing.Size(209, 135);
            this.Recieving.TabIndex = 39;
            // 
            // GetFile
            // 
            this.GetFile.ColumnCount = 1;
            this.GetFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetFile.Controls.Add(this.label1, 0, 0);
            this.GetFile.Controls.Add(this.label3, 0, 1);
            this.GetFile.Controls.Add(this.label5, 0, 2);
            this.GetFile.Controls.Add(this.button1, 0, 3);
            this.GetFile.Controls.Add(this.button2, 0, 4);
            this.GetFile.Location = new System.Drawing.Point(505, 584);
            this.GetFile.Name = "GetFile";
            this.GetFile.RowCount = 5;
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.GetFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.GetFile.Size = new System.Drawing.Size(200, 127);
            this.GetFile.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 740);
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

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label DragHere;
        private System.Windows.Forms.Label NetworkFiles;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar RecievingBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar SendingBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel SendingFile;
        private System.Windows.Forms.TableLayoutPanel StartingPane;
        private System.Windows.Forms.TableLayoutPanel SendFileSelect;
        private System.Windows.Forms.TableLayoutPanel Recieving;
        private System.Windows.Forms.TableLayoutPanel GetFile;
        private System.Windows.Forms.Button Get;
    }
}

