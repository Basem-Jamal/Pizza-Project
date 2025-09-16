namespace Pizza___Poject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            totalPrice = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            labTopping = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 53);
            label1.Name = "label1";
            label1.Size = new Size(372, 65);
            label1.TabIndex = 0;
            label1.Text = "Make Your Pizza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 1;
            label2.Text = "Order Summary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(198, 46);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 2;
            label3.Text = "Size:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 46);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 3;
            label4.Text = "Toppings:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(309, 46);
            label5.Name = "label5";
            label5.Size = new Size(122, 30);
            label5.TabIndex = 4;
            label5.Text = "Crust Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.Location = new Point(487, 46);
            label6.Name = "label6";
            label6.Size = new Size(148, 30);
            label6.TabIndex = 5;
            label6.Text = "Where To Eat:";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPrice.Location = new Point(1033, 532);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(108, 45);
            totalPrice.TabIndex = 6;
            totalPrice.Text = "Prices";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label8.Location = new Point(906, 532);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 7;
            label8.Text = "Total Price:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(labTopping);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(831, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // labTopping
            // 
            labTopping.AutoSize = true;
            labTopping.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTopping.Location = new Point(6, 107);
            labTopping.Name = "labTopping";
            labTopping.Size = new Size(117, 30);
            labTopping.TabIndex = 6;
            labTopping.Text = "no Topping";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(163, 107);
            label7.Name = "label7";
            label7.Size = new Size(117, 30);
            label7.TabIndex = 7;
            label7.Text = "no Topping";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(314, 107);
            label9.Name = "label9";
            label9.Size = new Size(117, 30);
            label9.TabIndex = 8;
            label9.Text = "no Topping";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(500, 107);
            label10.Name = "label10";
            label10.Size = new Size(117, 30);
            label10.TabIndex = 9;
            label10.Text = "no Topping";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 15.75F);
            groupBox2.Location = new Point(44, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(183, 268);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Size";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semilight", 15.75F);
            radioButton1.Location = new Point(23, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Small";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semilight", 15.75F);
            radioButton2.Location = new Point(20, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 34);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Meduim";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semilight", 15.75F);
            radioButton3.Location = new Point(20, 196);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 34);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Larg";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 862);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(totalPrice);
            Controls.Add(label8);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label totalPrice;
        private Label label8;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label labTopping;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
