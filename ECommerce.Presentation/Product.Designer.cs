namespace ECommerce.Presentation
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            productGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nametxt = new TextBox();
            descBtn = new TextBox();
            priBtn = new TextBox();
            catBtn = new TextBox();
            label5 = new Label();
            picBox = new PictureBox();
            addBtn = new Button();
            label6 = new Label();
            editBtn = new Button();
            delBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // productGrid
            // 
            productGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGrid.Location = new Point(127, 74);
            productGrid.Name = "productGrid";
            productGrid.Size = new Size(535, 237);
            productGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 334);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 390);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 2;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 339);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(313, 390);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 4;
            label4.Text = "Category";
            // 
            // nametxt
            // 
            nametxt.Location = new Point(157, 339);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(100, 23);
            nametxt.TabIndex = 5;
            // 
            // descBtn
            // 
            descBtn.Location = new Point(157, 390);
            descBtn.Name = "descBtn";
            descBtn.Size = new Size(100, 23);
            descBtn.TabIndex = 6;
            // 
            // priBtn
            // 
            priBtn.Location = new Point(424, 344);
            priBtn.Name = "priBtn";
            priBtn.Size = new Size(100, 23);
            priBtn.TabIndex = 7;
            // 
            // catBtn
            // 
            catBtn.Location = new Point(424, 395);
            catBtn.Name = "catBtn";
            catBtn.Size = new Size(100, 23);
            catBtn.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(550, 366);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 9;
            label5.Text = "image";
            // 
            // picBox
            // 
            picBox.BackgroundImageLayout = ImageLayout.Center;
            picBox.Image = (Image)resources.GetObject("picBox.Image");
            picBox.Location = new Point(644, 344);
            picBox.Name = "picBox";
            picBox.Size = new Size(100, 50);
            picBox.TabIndex = 10;
            picBox.TabStop = false;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(91, 425);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(110, 39);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(313, 20);
            label6.Name = "label6";
            label6.Size = new Size(175, 33);
            label6.TabIndex = 12;
            label6.Text = "Modify Products";
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(325, 425);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(106, 39);
            editBtn.TabIndex = 13;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(562, 425);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(100, 32);
            delBtn.TabIndex = 14;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 476);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(label6);
            Controls.Add(addBtn);
            Controls.Add(picBox);
            Controls.Add(label5);
            Controls.Add(catBtn);
            Controls.Add(priBtn);
            Controls.Add(descBtn);
            Controls.Add(nametxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productGrid);
            Name = "Product";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)productGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nametxt;
        private TextBox descBtn;
        private TextBox priBtn;
        private TextBox catBtn;
        private Label label5;
        private PictureBox picBox;
        private Button addBtn;
        private Label label6;
        private Button editBtn;
        private Button delBtn;
    }
}