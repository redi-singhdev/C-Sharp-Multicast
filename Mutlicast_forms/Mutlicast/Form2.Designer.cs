namespace Mutlicast
{
    partial class Form2
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
            this.FileName = new System.Windows.Forms.Label();
            this.NameFile = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Label();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(156, 140);
            this.TextBox.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(12, 172);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(57, 13);
            this.FileName.TabIndex = 1;
            this.FileName.Text = "File Name:";
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Location = new System.Drawing.Point(75, 172);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(67, 13);
            this.NameFile.TabIndex = 2;
            this.NameFile.Text = "NameFile.iso";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 202);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(93, 202);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Location = new System.Drawing.Point(12, 245);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(93, 13);
            this.Clients.TabIndex = 5;
            this.Clients.Text = "Clients Connected";
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.Items.AddRange(new object[] {
            "Tom - Laptop",
            "Adam - Laptop"});
            this.ClientList.Location = new System.Drawing.Point(12, 261);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(156, 95);
            this.ClientList.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 377);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.TextBox);
            this.Name = "Form2";
            this.Text = "Sending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label NameFile;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.ListBox ClientList;
    }
}