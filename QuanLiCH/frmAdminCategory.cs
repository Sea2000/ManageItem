using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DAO_1;
using QuanLiCH.DTO_1;

namespace QuanLiCH
{
    public partial class frmAdminCategory : Form
    {
        BindingSource categoryList = new BindingSource();
        public frmAdminCategory()
        {
            InitializeComponent();
            dtgCategory.DataSource = categoryList;
            AddCategoryBinding();
            LoadListCategory();
            LoadCategoryIntoCombobox(cbCategoryName);
        }
        void AddCategoryBinding()
        {
            tbIdCategory.DataBindings.Add(new Binding("Text", dtgCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetlistCategory();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "Name";
        }

        private void tbIdCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgCategory.SelectedCells.Count > 0)
                {
                    int id = (int)dtgCategory.SelectedCells[0].OwningRow.Cells["ID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbCategoryName.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbCategoryName.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbCategoryName.SelectedIndex = index;
                }
            }
            catch { }
        }

        
    }
}
