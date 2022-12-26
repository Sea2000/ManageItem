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
    public partial class frmItems : Form
    {
        BindingSource itemList = new BindingSource();
        public frmItems()
        {
            InitializeComponent();
            LoadTheme();
            dtgvItems.DataSource = itemList;
            LoadListItems();
            LoadCategoryIntoCombobox(cbItemsCategory);
            AddFoodBinding();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn= (Button)btns;
                    btn.BackColor = Color.FromArgb(135, 206, 250);
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryyColor;
                }
                lb1.ForeColor=ThemeColor.SecondaryyColor;
                
            }
        }
        List<Items> SearchItemByName(string name)
        {
            List<Items> listFood = ItemsDAO.Instance.SearchitemByName(name);

            return listFood;
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "NameCategory";
        }

        void AddFoodBinding()
        {
            txtItemsName.DataBindings.Add(new Binding("Text", dtgvItems.DataSource, "NameItem", true, DataSourceUpdateMode.Never));
            txtItemsID.DataBindings.Add(new Binding("Text", dtgvItems.DataSource, "ItemID", true, DataSourceUpdateMode.Never));
            nmEntryPriceItem.DataBindings.Add(new Binding("Value", dtgvItems.DataSource, "EntryPriceItem", true, DataSourceUpdateMode.Never));
            nmExportPriceItem.DataBindings.Add(new Binding("Value", dtgvItems.DataSource, "ExportPriceItem", true, DataSourceUpdateMode.Never));
            nmItemsQuantity.DataBindings.Add(new Binding("Value", dtgvItems.DataSource, "QuantityItem", true, DataSourceUpdateMode.Never));
            cbUnit.DataBindings.Add(new Binding("Text", dtgvItems.DataSource, "Unit", true, DataSourceUpdateMode.Never));
            txtnote.DataBindings.Add(new Binding("Text", dtgvItems.DataSource, "Note", true, DataSourceUpdateMode.Never));
           // cbItemsCategory.DataBindings.Add(new Binding("Text", dtgvItems.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
        }

        void LoadListItems()
        {
            itemList.DataSource = ItemsDAO.Instance.GetListitem();
          
        }

        private void btnSreachFood_Click(object sender, EventArgs e)
        {
            itemList.DataSource = SearchItemByName(txbSreachFoodName.Text);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListItems();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtItemsName.Text;
            int categoryID = (cbItemsCategory.SelectedItem as ItemCategory).CategoryID;
            float priceEntry = (float)nmEntryPriceItem.Value;
            float priceExport = (float)nmExportPriceItem.Value;
            int quantity = (int)nmItemsQuantity.Value;
            string unit = (string)cbUnit.Text;
            string note = (string)txtnote.Text;

            if (ItemsDAO.Instance.Insertitem( name,  priceEntry, priceExport, quantity,unit,note, categoryID))
            {
                MessageBox.Show("Add Item Successfully");
                LoadListItems();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("There was an error adding Item");
            }

        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = txtItemsName.Text;
            int categoryID = (cbItemsCategory.SelectedItem as ItemCategory).CategoryID;
            float priceentry = (float)nmEntryPriceItem.Value;
            float priceexport = (float)nmExportPriceItem.Value;

            int quantity = (int)nmItemsQuantity.Value;
            string unit = (string)cbUnit.Text;
            string note = txtnote.Text;
            int id = Convert.ToInt32(txtItemsID.Text);

            if (ItemsDAO.Instance.Updateitem(id, name, categoryID, priceentry,priceexport,quantity,unit, note))
            {
                MessageBox.Show("Edit the Item successfully");
                LoadListItems();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("There was an error when update the item");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtItemsID.Text);

            if (MessageBox.Show(string.Format("Are you sure you want to delete this line?"), "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)

            {
                if (ItemsDAO.Instance.Deleteitem(id))
                {
                    MessageBox.Show("Delete item successfully");
                    LoadListItems();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("There was an error deleting the item");
                }
            }
               
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvItems.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvItems.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    ItemCategory cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbItemsCategory.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (ItemCategory item in cbItemsCategory.Items)
                    {
                        if (item.CategoryID == cateogory.CategoryID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbItemsCategory.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void btnSreachFood_Click_1(object sender, EventArgs e)
        {
            itemList.DataSource = SearchItemByName(txbSreachFoodName.Text);
        }

        private void dtgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
