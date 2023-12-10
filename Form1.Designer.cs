using System.Windows.Forms;

namespace lab2SH
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.textField1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(195, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите аргумент х";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CheckBox.Location = new System.Drawing.Point(246, 292);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(119, 28);
            this.CheckBox.TabIndex = 1;
            this.CheckBox.Text = "Удвоение";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(54, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton1.Location = new System.Drawing.Point(54, 240);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(95, 28);
            this.RadioButton1.TabIndex = 3;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "x*sin(X)";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton2.Location = new System.Drawing.Point(255, 240);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(95, 28);
            this.RadioButton2.TabIndex = 4;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "sqrt(x)/x";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.RadioButton3.Location = new System.Drawing.Point(461, 240);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(78, 28);
            this.RadioButton3.TabIndex = 5;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "x^2+3";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // textField1
            // 
            this.textField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textField1.Location = new System.Drawing.Point(54, 107);
            this.textField1.Name = "textField1";
            this.textField1.Size = new System.Drawing.Size(481, 29);
            this.textField1.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label.Location = new System.Drawing.Point(210, 382);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 24);
            this.label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textField1);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.TextBox textField1;
        private System.Windows.Forms.Label label;

       
        
    }

}

