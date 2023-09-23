namespace WinFormsApp2
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
            number1 = new Button();
            number2 = new Button();
            number3 = new Button();
            number4 = new Button();
            number5 = new Button();
            number6 = new Button();
            number7 = new Button();
            number8 = new Button();
            number9 = new Button();
            plus = new Button();
            minus = new Button();
            divide = new Button();
            multiple = new Button();
            point = new Button();
            number0 = new Button();
            delete = new Button();
            equal = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // number1
            // 
            number1.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number1.Location = new Point(113, 89);
            number1.Name = "number1";
            number1.Size = new Size(100, 50);
            number1.TabIndex = 0;
            number1.Text = "1";
            number1.UseVisualStyleBackColor = true;
            number1.Click += number1_Click;
            // 
            // number2
            // 
            number2.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number2.Location = new Point(236, 89);
            number2.Name = "number2";
            number2.Size = new Size(100, 50);
            number2.TabIndex = 1;
            number2.Text = "2";
            number2.UseVisualStyleBackColor = true;
            number2.Click += number2_Click;
            // 
            // number3
            // 
            number3.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number3.Location = new Point(371, 89);
            number3.Name = "number3";
            number3.Size = new Size(100, 50);
            number3.TabIndex = 2;
            number3.Text = "3";
            number3.UseVisualStyleBackColor = true;
            number3.Click += number3_Click;
            // 
            // number4
            // 
            number4.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number4.Location = new Point(113, 172);
            number4.Name = "number4";
            number4.Size = new Size(100, 50);
            number4.TabIndex = 3;
            number4.Text = "4";
            number4.UseVisualStyleBackColor = true;
            number4.Click += number4_Click;
            // 
            // number5
            // 
            number5.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number5.Location = new Point(236, 172);
            number5.Name = "number5";
            number5.Size = new Size(100, 50);
            number5.TabIndex = 4;
            number5.Text = "5";
            number5.UseVisualStyleBackColor = true;
            number5.Click += number5_Click;
            // 
            // number6
            // 
            number6.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number6.Location = new Point(371, 172);
            number6.Name = "number6";
            number6.Size = new Size(100, 50);
            number6.TabIndex = 5;
            number6.Text = "6";
            number6.UseVisualStyleBackColor = true;
            number6.Click += number6_Click;
            // 
            // number7
            // 
            number7.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number7.Location = new Point(113, 244);
            number7.Name = "number7";
            number7.Size = new Size(100, 50);
            number7.TabIndex = 6;
            number7.Text = "7";
            number7.UseVisualStyleBackColor = true;
            number7.Click += number7_Click;
            // 
            // number8
            // 
            number8.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number8.Location = new Point(236, 244);
            number8.Name = "number8";
            number8.Size = new Size(100, 50);
            number8.TabIndex = 7;
            number8.Text = "8";
            number8.UseVisualStyleBackColor = true;
            number8.Click += number8_Click;
            // 
            // number9
            // 
            number9.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number9.Location = new Point(371, 244);
            number9.Name = "number9";
            number9.Size = new Size(100, 50);
            number9.TabIndex = 8;
            number9.Text = "9";
            number9.UseVisualStyleBackColor = true;
            number9.Click += number9_Click;
            // 
            // plus
            // 
            plus.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            plus.Location = new Point(579, 89);
            plus.Name = "plus";
            plus.Size = new Size(100, 50);
            plus.TabIndex = 9;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            minus.Location = new Point(579, 172);
            minus.Name = "minus";
            minus.Size = new Size(100, 50);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // divide
            // 
            divide.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            divide.Location = new Point(579, 244);
            divide.Name = "divide";
            divide.Size = new Size(100, 50);
            divide.TabIndex = 11;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // multiple
            // 
            multiple.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            multiple.Location = new Point(579, 321);
            multiple.Name = "multiple";
            multiple.Size = new Size(100, 50);
            multiple.TabIndex = 12;
            multiple.Text = "*";
            multiple.UseVisualStyleBackColor = true;
            multiple.Click += multiple_Click;
            // 
            // point
            // 
            point.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            point.Location = new Point(113, 321);
            point.Name = "point";
            point.Size = new Size(100, 50);
            point.TabIndex = 13;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += point_Click;
            // 
            // number0
            // 
            number0.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            number0.Location = new Point(236, 321);
            number0.Name = "number0";
            number0.Size = new Size(100, 50);
            number0.TabIndex = 14;
            number0.Text = "0";
            number0.UseVisualStyleBackColor = true;
            number0.Click += number0_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(371, 321);
            delete.Name = "delete";
            delete.Size = new Size(100, 50);
            delete.TabIndex = 15;
            delete.Text = "C";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // equal
            // 
            equal.Font = new Font("Square721 BT", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            equal.Location = new Point(236, 388);
            equal.Name = "equal";
            equal.Size = new Size(100, 50);
            equal.TabIndex = 16;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(730, 493);
            Controls.Add(textBox1);
            Controls.Add(equal);
            Controls.Add(delete);
            Controls.Add(number0);
            Controls.Add(point);
            Controls.Add(multiple);
            Controls.Add(divide);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(number9);
            Controls.Add(number8);
            Controls.Add(number7);
            Controls.Add(number6);
            Controls.Add(number5);
            Controls.Add(number4);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button number1;
        private Button number2;
        private Button number3;
        private Button number4;
        private Button number5;
        private Button number6;
        private Button number7;
        private Button number8;
        private Button number9;
        private Button plus;
        private Button minus;
        private Button divide;
        private Button multiple;
        private Button point;
        private Button number0;
        private Button delete;
        private Button equal;
        private TextBox textBox1;
    }
}