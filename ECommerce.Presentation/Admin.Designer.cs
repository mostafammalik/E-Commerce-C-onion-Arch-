namespace E_Commerce.Preserntations
{
    partial class Admin
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
            panel1 = new Panel();
            catBtn = new Button();
            ordBtn = new Button();
            proBtn = new Button();
            dashBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Salmon;
            panel1.Controls.Add(catBtn);
            panel1.Controls.Add(ordBtn);
            panel1.Controls.Add(proBtn);
            panel1.Controls.Add(dashBtn);
            panel1.Location = new Point(12, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 379);
            panel1.TabIndex = 0;
            // 
            // catBtn
            // 
            catBtn.ForeColor = Color.Salmon;
            catBtn.Location = new Point(17, 270);
            catBtn.Name = "catBtn";
            catBtn.Size = new Size(93, 40);
            catBtn.TabIndex = 3;
            catBtn.Text = "Category";
            catBtn.UseVisualStyleBackColor = true;
            // 
            // ordBtn
            // 
            ordBtn.ForeColor = Color.Salmon;
            ordBtn.Location = new Point(17, 175);
            ordBtn.Name = "ordBtn";
            ordBtn.Size = new Size(93, 39);
            ordBtn.TabIndex = 2;
            ordBtn.Text = "Order";
            ordBtn.UseVisualStyleBackColor = true;
            // 
            // proBtn
            // 
            proBtn.ForeColor = Color.Salmon;
            proBtn.Location = new Point(17, 106);
            proBtn.Name = "proBtn";
            proBtn.Size = new Size(93, 36);
            proBtn.TabIndex = 1;
            proBtn.Text = "Product";
            proBtn.UseVisualStyleBackColor = true;
            // 
            // dashBtn
            // 
            dashBtn.ForeColor = Color.Salmon;
            dashBtn.Location = new Point(17, 23);
            dashBtn.Name = "dashBtn";
            dashBtn.Size = new Size(93, 38);
            dashBtn.TabIndex = 0;
            dashBtn.Text = "Home";
            dashBtn.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Product";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button catBtn;
        private Button ordBtn;
        private Button proBtn;
        private Button dashBtn;
    }
}