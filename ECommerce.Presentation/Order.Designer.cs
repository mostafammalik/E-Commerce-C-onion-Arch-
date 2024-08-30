namespace ECommerce.Presentation
{
    partial class Order
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
            ordergrid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            state1 = new RadioButton();
            state2 = new RadioButton();
            state3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)ordergrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 33);
            label1.TabIndex = 0;
            label1.Text = "View orders";
            // 
            // ordergrid
            // 
            ordergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordergrid.Location = new Point(25, 152);
            ordergrid.Name = "ordergrid";
            ordergrid.Size = new Size(763, 296);
            ordergrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 2;
            label2.Text = "OrderID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 101);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 3;
            label3.Text = "Order Status";
            // 
            // state1
            // 
            state1.AutoSize = true;
            state1.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            state1.Location = new Point(265, 101);
            state1.Name = "state1";
            state1.Size = new Size(113, 32);
            state1.TabIndex = 4;
            state1.TabStop = true;
            state1.Text = "Processing";
            state1.UseVisualStyleBackColor = true;
            // 
            // state2
            // 
            state2.AutoSize = true;
            state2.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            state2.Location = new Point(423, 101);
            state2.Name = "state2";
            state2.Size = new Size(91, 32);
            state2.TabIndex = 5;
            state2.TabStop = true;
            state2.Text = "shipped";
            state2.UseVisualStyleBackColor = true;
            // 
            // state3
            // 
            state3.AutoSize = true;
            state3.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            state3.Location = new Point(561, 99);
            state3.Name = "state3";
            state3.Size = new Size(105, 32);
            state3.TabIndex = 6;
            state3.TabStop = true;
            state3.Text = "Delivered";
            state3.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(state3);
            Controls.Add(state2);
            Controls.Add(state1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ordergrid);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)ordergrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ordergrid;
        private Label label2;
        private Label label3;
        private RadioButton state1;
        private RadioButton state2;
        private RadioButton state3;
    }
}