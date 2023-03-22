namespace AAS_System
{
    partial class AASMain
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
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewTransBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.Color.LightGray;
            this.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerBtn.Location = new System.Drawing.Point(229, 166);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(350, 70);
            this.AddCustomerBtn.TabIndex = 0;
            this.AddCustomerBtn.Text = "Add New Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(224, 107);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(102, 25);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = "Welcome";
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.LightGray;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(354, 105);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(169, 27);
            this.NameTxt.TabIndex = 2;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.LightGray;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.Location = new System.Drawing.Point(229, 256);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(350, 70);
            this.ViewBtn.TabIndex = 3;
            this.ViewBtn.Text = "View Customers";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.LightGray;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(229, 429);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(350, 70);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ViewTransBtn
            // 
            this.ViewTransBtn.BackColor = System.Drawing.Color.LightGray;
            this.ViewTransBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTransBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTransBtn.Location = new System.Drawing.Point(229, 343);
            this.ViewTransBtn.Name = "ViewTransBtn";
            this.ViewTransBtn.Size = new System.Drawing.Size(350, 70);
            this.ViewTransBtn.TabIndex = 5;
            this.ViewTransBtn.Text = "View Transactions";
            this.ViewTransBtn.UseVisualStyleBackColor = false;
            this.ViewTransBtn.Click += new System.EventHandler(this.ViewTransBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "AAS DASHBOARD";
            // 
            // AASMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewTransBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.AddCustomerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AASMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AASMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewTransBtn;
        private System.Windows.Forms.Label label1;
    }
}