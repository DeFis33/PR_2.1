namespace PR2._2
{
    partial class Info
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
            this.btnBack = new System.Windows.Forms.Button();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.developer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(67, 145);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(228, 49);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // emailLink
            // 
            this.emailLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.emailLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLink.AutoSize = true;
            this.emailLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLink.LinkColor = System.Drawing.Color.MediumSpringGreen;
            this.emailLink.Location = new System.Drawing.Point(45, 112);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(178, 20);
            this.emailLink.TabIndex = 11;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "https://vk.com/nee_gear";
            this.emailLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(11, 112);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(34, 20);
            this.email.TabIndex = 10;
            this.email.Text = "VK:";
            // 
            // specialization
            // 
            this.specialization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialization.AutoSize = true;
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialization.ForeColor = System.Drawing.Color.White;
            this.specialization.Location = new System.Drawing.Point(10, 64);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(347, 40);
            this.specialization.TabIndex = 9;
            this.specialization.Text = "Специальность: Информационные системы \r\nи программирование";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(32, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 24);
            this.title.TabIndex = 8;
            this.title.Text = "Программа \"Мое приложение\"";
            // 
            // developer
            // 
            this.developer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.developer.AutoSize = true;
            this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer.ForeColor = System.Drawing.Color.White;
            this.developer.Location = new System.Drawing.Point(10, 38);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(192, 20);
            this.developer.TabIndex = 7;
            this.developer.Text = "Разработал: Пирогов Д.";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(361, 205);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.emailLink);
            this.Controls.Add(this.email);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.title);
            this.Controls.Add(this.developer);
            this.MaximumSize = new System.Drawing.Size(377, 244);
            this.MinimumSize = new System.Drawing.Size(377, 244);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label developer;
    }
}