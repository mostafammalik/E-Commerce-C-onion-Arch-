namespace ECommerce.Presentation
{
    partial class Category
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            addBtn = new Button();
            editBtn = new Button();
            delBtn = new Button();
            label2 = new Label();
            catBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 0;
            label1.Text = "Category";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(602, 228);
            dataGridView1.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(47, 375);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(116, 36);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(331, 375);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(114, 36);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // delBtn
            // 
            delBtn.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(591, 375);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(108, 36);
            delBtn.TabIndex = 4;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(165, 309);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 5;
            label2.Text = "category name";
            label2.Click += label2_Click;
            // 
            // catBox
            // 
            catBox.Location = new Point(331, 314);
            catBox.Name = "catBox";
            catBox.Size = new Size(100, 23);
            catBox.TabIndex = 6;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(catBox);
            Controls.Add(label2);
            Controls.Add(delBtn);
            Controls.Add(editBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button addBtn;
        private Button editBtn;
        private Button delBtn;
        private Label label2;
        private TextBox catBox;
    }
}