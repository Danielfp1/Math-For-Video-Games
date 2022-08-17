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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_GetNumber = new System.Windows.Forms.Button();
            this.textBox_Random = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_GetNumber
            // 
            this.button_GetNumber.Location = new System.Drawing.Point(202, 235);
            this.button_GetNumber.Name = "button_GetNumber";
            this.button_GetNumber.Size = new System.Drawing.Size(109, 30);
            this.button_GetNumber.TabIndex = 1;
            this.button_GetNumber.Text = "Gerar Número";
            this.button_GetNumber.UseVisualStyleBackColor = true;
            this.button_GetNumber.Click += new System.EventHandler(this.button_GetNumber_Click);
            // 
            // textBox_Random
            // 
            this.textBox_Random.Location = new System.Drawing.Point(418, 241);
            this.textBox_Random.Name = "textBox_Random";
            this.textBox_Random.Size = new System.Drawing.Size(98, 20);
            this.textBox_Random.TabIndex = 2;
            // 
            // Ch1Remainders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.textBox_Random);
            this.Controls.Add(this.button_GetNumber);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ch1Remainders";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_GetNumber;
        private System.Windows.Forms.TextBox textBox_Random;
    }
}