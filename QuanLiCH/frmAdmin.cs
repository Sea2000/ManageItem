using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DTO_1;

namespace QuanLiCH
{
    public partial class frmAdmin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
       

        public frmAdmin(DTO_1.Account loginAccount)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChillForm.Enabled = false;
            this.ControlBox = false;
        }
 
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender; 
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChillForm.Enabled = true;
                }    
            }    
        }
       
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)
            {
                 activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;  
            childForm.Dock = DockStyle.Fill;
            this.pnDesktopPane.Controls.Add(childForm);
            this.pnDesktopPane.Tag = childForm;
            childForm.BringToFront();
            try
            {
                childForm.Show();
            }
            catch { }
            lbTitleBar.Text = childForm.Text; 
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmStatistic(), sender);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmItems(), sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmCategory(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmAccount(), sender);
        }
        private void btnItemReturn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmItemReturn(), sender);
        }

        private void btnCloseChillForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
           //DisableButton();
            lbTitleBar.Text ="HOME" ;
            currentButton=null;
            btnCloseChillForm.Enabled = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState=FormWindowState.Maximized;
            }    
            else
            {
                this.WindowState=FormWindowState.Normal;
            }    

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }


    }
}
