namespace ECommerce.Presentation
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            catBtn = new Button();
            cliBtn = new Button();
            proBtn = new Button();
            dashBtn = new Button();
            ordBtn = new Button();
            SuspendLayout();
            // 
            // catBtn
            // 
            catBtn.ForeColor = Color.Salmon;
            catBtn.Location = new Point(9, 266);
            catBtn.Name = "catBtn";
            catBtn.Size = new Size(97, 38);
            catBtn.TabIndex = 1;
            catBtn.Text = "Catogery";
            catBtn.UseVisualStyleBackColor = true;
            catBtn.Click += catBtn_Click;
            // 
            // cliBtn
            // 
            cliBtn.ForeColor = Color.Salmon;
            cliBtn.Location = new Point(9, 329);
            cliBtn.Name = "cliBtn";
            cliBtn.Size = new Size(97, 38);
            cliBtn.TabIndex = 3;
            cliBtn.Text = "Clients";
            cliBtn.UseVisualStyleBackColor = true;
            cliBtn.Click += cliBtn_Click;
            // 
            // proBtn
            // 
            proBtn.ForeColor = Color.Coral;
            proBtn.Location = new Point(9, 122);
            proBtn.Name = "proBtn";
            proBtn.Size = new Size(97, 41);
            proBtn.TabIndex = 0;
            proBtn.Text = "Product";
            proBtn.UseVisualStyleBackColor = true;
            proBtn.Click += proBtn_Click;
            // 
            // dashBtn
            // 
            dashBtn.ForeColor = Color.Salmon;
            dashBtn.Location = new Point(6, 46);
            dashBtn.Name = "dashBtn";
            dashBtn.Size = new Size(100, 41);
            dashBtn.TabIndex = 4;
            dashBtn.Text = "Home";
            dashBtn.UseVisualStyleBackColor = true;
            dashBtn.Click += dashBtn_Click;
            // 
            // ordBtn
            // 
            ordBtn.ForeColor = Color.Salmon;
            ordBtn.Location = new Point(9, 187);
            ordBtn.Name = "ordBtn";
            ordBtn.Size = new Size(97, 41);
            ordBtn.TabIndex = 2;
            ordBtn.Text = "Order";
            ordBtn.UseVisualStyleBackColor = true;
            ordBtn.Click += ordBtn_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(603, 412);
            Controls.Add(ordBtn);
            Controls.Add(cliBtn);
            Controls.Add(dashBtn);
            Controls.Add(catBtn);
            Controls.Add(proBtn);
            Name = "DashBoard";
            Text = "DashBoard";
            ResumeLayout(false);
        }

        #endregion
        private Button catBtn;
        private Button cliBtn;
        private Button proBtn;
        private Button dashBtn;
        private Button ordBtn;
    }
}
