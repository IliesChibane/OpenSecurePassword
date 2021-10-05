
namespace PasswordManagerDesktopApp
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.ConnectButon = new RJCodeAdvance.RJControls.RJButton();
            this.NameText = new RJCodeAdvance.RJControls.RJTextBox();
            this.MasterCodeText = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButon
            // 
            this.ConnectButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ConnectButon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ConnectButon.BorderColor = System.Drawing.Color.White;
            this.ConnectButon.BorderRadius = 10;
            this.ConnectButon.BorderSize = 2;
            this.ConnectButon.FlatAppearance.BorderSize = 0;
            this.ConnectButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnectButon.ForeColor = System.Drawing.Color.White;
            this.ConnectButon.Location = new System.Drawing.Point(252, 336);
            this.ConnectButon.Name = "ConnectButon";
            this.ConnectButon.Size = new System.Drawing.Size(150, 40);
            this.ConnectButon.TabIndex = 0;
            this.ConnectButon.Text = "Connect";
            this.ConnectButon.TextColor = System.Drawing.Color.White;
            this.ConnectButon.UseVisualStyleBackColor = false;
            this.ConnectButon.Click += new System.EventHandler(this.ConnectButon_Click);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.Control;
            this.NameText.BorderColor = System.Drawing.Color.Black;
            this.NameText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.NameText.BorderRadius = 0;
            this.NameText.BorderSize = 2;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NameText.Location = new System.Drawing.Point(201, 142);
            this.NameText.Margin = new System.Windows.Forms.Padding(4);
            this.NameText.Multiline = false;
            this.NameText.Name = "NameText";
            this.NameText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.NameText.PasswordChar = false;
            this.NameText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.NameText.PlaceholderText = "";
            this.NameText.Size = new System.Drawing.Size(250, 32);
            this.NameText.TabIndex = 1;
            this.NameText.Texts = "";
            this.NameText.UnderlinedStyle = true;
            // 
            // MasterCodeText
            // 
            this.MasterCodeText.BackColor = System.Drawing.SystemColors.Control;
            this.MasterCodeText.BorderColor = System.Drawing.Color.Black;
            this.MasterCodeText.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MasterCodeText.BorderRadius = 0;
            this.MasterCodeText.BorderSize = 2;
            this.MasterCodeText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MasterCodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MasterCodeText.Location = new System.Drawing.Point(201, 254);
            this.MasterCodeText.Margin = new System.Windows.Forms.Padding(4);
            this.MasterCodeText.Multiline = false;
            this.MasterCodeText.Name = "MasterCodeText";
            this.MasterCodeText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MasterCodeText.PasswordChar = true;
            this.MasterCodeText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MasterCodeText.PlaceholderText = "";
            this.MasterCodeText.Size = new System.Drawing.Size(250, 32);
            this.MasterCodeText.TabIndex = 2;
            this.MasterCodeText.Texts = "";
            this.MasterCodeText.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "MasterCode";
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(364, 327);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 25);
            this.error.TabIndex = 5;
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 353);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(80, 40);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "exit";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 88);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password Manager";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(645, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MasterCodeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ConnectButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton ConnectButon;
        private RJCodeAdvance.RJControls.RJTextBox NameText;
        private RJCodeAdvance.RJControls.RJTextBox MasterCodeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

