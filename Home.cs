using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_For_Video_Games
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panel_Ch1Submenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_Ch1Submenu.Visible)
            {
                panel_Ch1Submenu.Visible=false;
            }
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible=true;
            }
            else
            {
                subMenu.Visible=false;
            }
        }

        #region Submenu_Ch1
        private void button_Ch1_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Ch1Submenu);
        }

        private void button_Ch1Remainders_Click(object sender, EventArgs e)
        {
            
            openChildForm(new Ch1Remainders());
            hideSubmenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_ChildForm.Controls.Add(childForm);
            panel_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_RatesOfChange_Click(object sender, EventArgs e)
        {
            openChildForm(new Ch1RatesOfChange());
            hideSubmenu();
        }
    }
}
