namespace CsharpWithGitIgnore
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
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            dgvFound = new DataGridView();
            panel1 = new Panel();
            txtUser = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFound).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(26, 381);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 57);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(217, 401);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvFound
            // 
            dgvFound.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFound.Dock = DockStyle.Fill;
            dgvFound.Location = new Point(0, 0);
            dgvFound.Name = "dgvFound";
            dgvFound.RowTemplate.Height = 25;
            dgvFound.Size = new Size(417, 450);
            dgvFound.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(checkBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 450);
            panel1.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(26, 330);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(164, 23);
            txtUser.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvFound);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(383, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 450);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvFound).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private CheckBox checkBox1;
        private DataGridView dgvFound;
        private Panel panel1;
        private TextBox txtUser;
        private Panel panel2;
    }
}