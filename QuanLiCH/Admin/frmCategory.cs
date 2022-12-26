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

namespace QuanLiCH.Admin
{
    public partial class frmCategory : Form
    {
        BindingSource categoryList = new BindingSource();
        public frmCategory()
        {
            InitializeComponent();
            dtgCategory.DataSource = categoryList;
            AddCategoryBinding();
            LoadListCategory();
            LoadCategoryIntoCombobox(cbCategoryName);
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(135, 206, 250);
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryyColor;
                }
                lb1.ForeColor = ThemeColor.SecondaryyColor;
                
            }

        }
        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("text", dtgCategory.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
            cbCategoryName.DataBindings.Add(new Binding("Text", dtgCategory.DataSource, "NameCategory", true, DataSourceUpdateMode.Never));
        }

    

        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetlistCategory();
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "NameCategory";
        }


        private void txbCategoryID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgCategory.SelectedCells.Count > 0)
                {
                    int id = (int)dtgCategory.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    ItemCategory cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbCategoryName.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (ItemCategory item in cbCategoryName.Items)
                    {
                        if (item.CategoryID == cateogory.CategoryID)
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

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = cbCategoryName.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm loại thành công ");
                LoadListCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thực hiện");
            }

        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);

            string name = cbCategoryName.Text;

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công ");
                LoadListCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thực hiện");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryID.Text);


            if (MessageBox.Show(string.Format("Bạn có chắc thanh xóa dòng dữ liệu này"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)

            {
                if (CategoryDAO.Instance.DeleteCategory(id))
                {
                    MessageBox.Show("Xóa danh mục thành công ");
                    LoadListCategory();
                    if (deleteCategory != null)
                        deleteCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thực hiện");
                }
            }
        }
        private event EventHandler insertCategory;

        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private event EventHandler updateCategory;

        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private event EventHandler deleteCategory;

        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
    }
    
}
