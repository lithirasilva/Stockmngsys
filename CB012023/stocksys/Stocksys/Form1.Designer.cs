namespace Stocksys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtpassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            label1 = new Label();
            btnlog = new Button();
            SuspendLayout();
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.HighlightText;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(259, 257);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(242, 28);
            txtpassword.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(89, 257);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 181);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 21;
            label2.Text = "Username";
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.HighlightText;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(259, 187);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(242, 28);
            txtusername.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 48);
            label1.Name = "label1";
            label1.Size = new Size(167, 62);
            label1.TabIndex = 19;
            label1.Text = "LOGIN";
            // 
            // btnlog
            // 
            btnlog.BackColor = Color.FromArgb(255, 128, 128);
            btnlog.FlatStyle = FlatStyle.Popup;
            btnlog.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnlog.Location = new Point(239, 341);
            btnlog.Margin = new Padding(5);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(142, 50);
            btnlog.TabIndex = 18;
            btnlog.Text = "Login";
            btnlog.UseVisualStyleBackColor = false;
            btnlog.Click += btnlog_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(617, 450);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(btnlog);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpassword;
        private Label label3;
        private Label label2;
        private TextBox txtusername;
        private Label label1;
        private Button btnlog;
    }
}