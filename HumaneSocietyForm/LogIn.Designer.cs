namespace HumaneSocietyForm
{
    partial class LogIn
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
            this.EmployeeLogIn = new System.Windows.Forms.RadioButton();
            this.AdopteeLogIn = new System.Windows.Forms.RadioButton();
            this.userName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NewAccount = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.LogUserIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeLogIn
            // 
            this.EmployeeLogIn.AutoSize = true;
            this.EmployeeLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLogIn.Location = new System.Drawing.Point(114, 89);
            this.EmployeeLogIn.Name = "EmployeeLogIn";
            this.EmployeeLogIn.Size = new System.Drawing.Size(125, 29);
            this.EmployeeLogIn.TabIndex = 0;
            this.EmployeeLogIn.TabStop = true;
            this.EmployeeLogIn.Text = "Employee\r\n";
            this.EmployeeLogIn.UseVisualStyleBackColor = true;
            // 
            // AdopteeLogIn
            // 
            this.AdopteeLogIn.AutoSize = true;
            this.AdopteeLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdopteeLogIn.Location = new System.Drawing.Point(836, 94);
            this.AdopteeLogIn.Name = "AdopteeLogIn";
            this.AdopteeLogIn.Size = new System.Drawing.Size(110, 29);
            this.AdopteeLogIn.TabIndex = 1;
            this.AdopteeLogIn.TabStop = true;
            this.AdopteeLogIn.Text = "Adoptee";
            this.AdopteeLogIn.UseVisualStyleBackColor = true;
            this.AdopteeLogIn.CheckedChanged += new System.EventHandler(this.AdopteeLogIn_CheckedChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(348, 217);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(380, 20);
            this.userName.TabIndex = 2;
            this.userName.Text = "User Name";
            this.userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(348, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(380, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Password";
            // 
            // NewAccount
            // 
            this.NewAccount.Location = new System.Drawing.Point(472, 89);
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(147, 33);
            this.NewAccount.TabIndex = 4;
            this.NewAccount.Text = "New Account";
            this.NewAccount.UseVisualStyleBackColor = true;
            this.NewAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(106, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(840, 44);
            this.Title.TabIndex = 5;
            this.Title.Text = "Welcome to the Humane Society please log in.";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // LogUserIn
            // 
            this.LogUserIn.Location = new System.Drawing.Point(472, 374);
            this.LogUserIn.Name = "LogUserIn";
            this.LogUserIn.Size = new System.Drawing.Size(147, 33);
            this.LogUserIn.TabIndex = 6;
            this.LogUserIn.Text = "Log In";
            this.LogUserIn.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 454);
            this.Controls.Add(this.LogUserIn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.NewAccount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.AdopteeLogIn);
            this.Controls.Add(this.EmployeeLogIn);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EmployeeLogIn;
        private System.Windows.Forms.RadioButton AdopteeLogIn;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NewAccount;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LogUserIn;
    }
}

