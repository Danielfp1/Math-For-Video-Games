
namespace Math_For_Video_Games
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel_SideMenu = new System.Windows.Forms.Panel();
            this.panel_Ch1Submenu = new System.Windows.Forms.Panel();
            this.button_RatesOfChange = new System.Windows.Forms.Button();
            this.button_Ch1Remainders = new System.Windows.Forms.Button();
            this.button_Ch1 = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_SideMenu.SuspendLayout();
            this.panel_Ch1Submenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SideMenu
            // 
            this.panel_SideMenu.AutoScroll = true;
            this.panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel_SideMenu.Controls.Add(this.panel_Ch1Submenu);
            this.panel_SideMenu.Controls.Add(this.button_Ch1);
            this.panel_SideMenu.Controls.Add(this.panel_Top);
            this.panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_SideMenu.Name = "panel_SideMenu";
            this.panel_SideMenu.Size = new System.Drawing.Size(250, 561);
            this.panel_SideMenu.TabIndex = 1;
            // 
            // panel_Ch1Submenu
            // 
            this.panel_Ch1Submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel_Ch1Submenu.Controls.Add(this.button_RatesOfChange);
            this.panel_Ch1Submenu.Controls.Add(this.button_Ch1Remainders);
            this.panel_Ch1Submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ch1Submenu.Location = new System.Drawing.Point(0, 109);
            this.panel_Ch1Submenu.Name = "panel_Ch1Submenu";
            this.panel_Ch1Submenu.Size = new System.Drawing.Size(250, 100);
            this.panel_Ch1Submenu.TabIndex = 2;
            // 
            // button_RatesOfChange
            // 
            this.button_RatesOfChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_RatesOfChange.FlatAppearance.BorderSize = 0;
            this.button_RatesOfChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            this.button_RatesOfChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(58)))), ((int)(((byte)(182)))));
            this.button_RatesOfChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RatesOfChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.button_RatesOfChange.Location = new System.Drawing.Point(0, 40);
            this.button_RatesOfChange.Name = "button_RatesOfChange";
            this.button_RatesOfChange.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_RatesOfChange.Size = new System.Drawing.Size(250, 40);
            this.button_RatesOfChange.TabIndex = 1;
            this.button_RatesOfChange.Text = "Rates of Change";
            this.button_RatesOfChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_RatesOfChange.UseVisualStyleBackColor = true;
            this.button_RatesOfChange.Click += new System.EventHandler(this.button_RatesOfChange_Click);
            // 
            // button_Ch1Remainders
            // 
            this.button_Ch1Remainders.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Ch1Remainders.FlatAppearance.BorderSize = 0;
            this.button_Ch1Remainders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            this.button_Ch1Remainders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(58)))), ((int)(((byte)(182)))));
            this.button_Ch1Remainders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ch1Remainders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.button_Ch1Remainders.Location = new System.Drawing.Point(0, 0);
            this.button_Ch1Remainders.Name = "button_Ch1Remainders";
            this.button_Ch1Remainders.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_Ch1Remainders.Size = new System.Drawing.Size(250, 40);
            this.button_Ch1Remainders.TabIndex = 0;
            this.button_Ch1Remainders.Text = "Remainders";
            this.button_Ch1Remainders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Ch1Remainders.UseVisualStyleBackColor = true;
            this.button_Ch1Remainders.Click += new System.EventHandler(this.button_Ch1Remainders_Click);
            // 
            // button_Ch1
            // 
            this.button_Ch1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Ch1.FlatAppearance.BorderSize = 0;
            this.button_Ch1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            this.button_Ch1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(58)))), ((int)(((byte)(182)))));
            this.button_Ch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.button_Ch1.Location = new System.Drawing.Point(0, 64);
            this.button_Ch1.Name = "button_Ch1";
            this.button_Ch1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_Ch1.Size = new System.Drawing.Size(250, 45);
            this.button_Ch1.TabIndex = 1;
            this.button_Ch1.Text = "Introduction and Arithmetic";
            this.button_Ch1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Ch1.UseVisualStyleBackColor = true;
            this.button_Ch1.Click += new System.EventHandler(this.button_Ch1_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(250, 64);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(250, 0);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(684, 561);
            this.panel_ChildForm.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_SideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Home";
            this.Text = "Math For Video Games";
            this.panel_SideMenu.ResumeLayout(false);
            this.panel_Ch1Submenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_SideMenu;
        private System.Windows.Forms.Panel panel_Ch1Submenu;
        private System.Windows.Forms.Button button_Ch1Remainders;
        private System.Windows.Forms.Button button_Ch1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Button button_RatesOfChange;
    }
}

