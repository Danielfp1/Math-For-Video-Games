namespace Math_For_Video_Games
{
    partial class Ch1Remainders
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
            this.button_GetNumber = new System.Windows.Forms.Button();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.textBox_Denominador = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.textBox_Remainder = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_GetNumber
            // 
            this.button_GetNumber.Location = new System.Drawing.Point(279, 257);
            this.button_GetNumber.Name = "button_GetNumber";
            this.button_GetNumber.Size = new System.Drawing.Size(114, 30);
            this.button_GetNumber.TabIndex = 1;
            this.button_GetNumber.Text = "Get another number";
            this.button_GetNumber.UseVisualStyleBackColor = true;
            this.button_GetNumber.Click += new System.EventHandler(this.button_GetNumber_Click);
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(331, 96);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(39, 20);
            this.textBox_Num.TabIndex = 2;
            // 
            // textBox_Denominador
            // 
            this.textBox_Denominador.Location = new System.Drawing.Point(331, 134);
            this.textBox_Denominador.Name = "textBox_Denominador";
            this.textBox_Denominador.Size = new System.Drawing.Size(39, 20);
            this.textBox_Denominador.TabIndex = 3;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(331, 181);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(39, 20);
            this.textBox_Result.TabIndex = 4;
            // 
            // textBox_Remainder
            // 
            this.textBox_Remainder.Location = new System.Drawing.Point(331, 220);
            this.textBox_Remainder.Name = "textBox_Remainder";
            this.textBox_Remainder.Size = new System.Drawing.Size(39, 20);
            this.textBox_Remainder.TabIndex = 5;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(311, 302);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(46, 33);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Turn Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Turn Timer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "On currently turn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seconds";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Seconds";
            // 
            // Ch1Remainders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.textBox_Remainder);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Denominador);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.button_GetNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ch1Remainders";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_GetNumber;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.TextBox textBox_Denominador;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.TextBox textBox_Remainder;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}