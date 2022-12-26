using System;
using System.Collections.Generic;
using System.ComponentModel;
 using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using QuanLiCH.DAO_1;
using QuanLiCH.DTO_1;
using static QuanLiCH.fAccoutProfile1;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace QuanLiCH

{

    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            timer1.Start();
            LoadTable();
            LoadCategory();
            LoadCategoryIntoCombobox(cbSearhCategoryName);
            cbSearhCategoryName.SelectedIndex = -1;
        }

        #region Methor
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnlStripMenuItem.Text += ":  Hello  " + LoginAccount.DisplayName + " ";

        }
        void LoadCategory()
        {
            List<ItemCategory> listCategory = CategoryDAO.Instance.GetlistCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Items> listFood = ItemsDAO.Instance.GetitemByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Items> tablelist = TableDAO.Instance.LoadFoodList();
            foreach (Items item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.NameItem + Environment.NewLine + "price: " + item.ExportPriceItem + Environment.NewLine + "SL còn: " + item.QuantityItem;

                btn.Click += Btn_Click;
                btn.Tag = item;

                flpTable.Controls.Add(btn);
            }

        }

        void ShowBill(int id)
        {

            //lsvBill.Items.Clear();
            List<QuanLiCH.DTO_1.Menu> listBillInfo = MenuDAO.Instance.GetlistMenuByItems();

            float totalPrice = 0;

            foreach (QuanLiCH.DTO_1.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ItemName.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN"); // tạo culture ở vn

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTotalPrice.Text = totalPrice.ToString("c", culture);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            int foodid = ((sender as Button).Tag as Items).ItemID; // Tạo id Table
            lsvBill.Tag = (sender as Button).Tag;
            //ShowBill(foodid); 
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            fLogin f = new fLogin();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccoutProfile1 f = new fAccoutProfile1(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;

            f.ShowDialog();
        }

        private void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnlStripMenuItem.Text = "Account Information (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAdmin f = new frmAdmin(loginAccount);
            Admin.frmItems food = new Admin.frmItems();
            food.InsertFood += f_InsertFood;
            food.DeleteFood += f_DeleteFood;
            food.UpdateFood += f_UpdateFood;
            Admin.frmCategory category = new Admin.frmCategory();
            category.InsertCategory += f_InsertCategory;
            category.UpdateCategory += f_UpdateCategory;
            category.DeleteCategory += f_DeleteCategory;

            f.ShowDialog();
        }

        private void f_DeleteCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void f_UpdateCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_InsertCategory(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);

            LoadTable();
        }

        private void f_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void f_InsertFood(object sender, EventArgs e)
        {

            LoadFoodListByCategoryID((cbCategory.SelectedItem as ItemCategory).CategoryID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            ItemCategory selected = cb.SelectedItem as ItemCategory;

            id = selected.CategoryID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

            Items product = lsvBill.Tag as Items;

            float price = 0;
            float quantity = 0;

            if (product == null)
            {
                MessageBox.Show("Please select the product");
                return;
            }

            if (nmitemquantity.Value > 0)
            {
                lsvBill.Items.Clear();

                List<Items> itemlist = ItemsDAO.Instance.GetitemByID(product.ItemID);
                foreach (Items item in itemlist)
                {
                    price = item.ExportPriceItem;
                }

                int idBill = BillDAO.Instance.getitemshowtemp(product.ItemID);
                int ItemID = product.ItemID;
                float discount = (float)nmDisCount.Value;
                float count = (float)nmitemquantity.Value;
                float totalPrice = price * count;
                float finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

                // Get StatisticID
                //int StatisticID = StatisticDAO.Instance.GetMaxIDStatistic();


                //trừ SL đã mua
                BillDAO.Instance.deleteSLdamua(ItemID, count);

                // Lấy SL còn
                List<Items> foodlist1 = ItemsDAO.Instance.GetitemByID(product.ItemID);
                foreach (Items item in foodlist1)
                {
                    quantity = (int)item.QuantityItem;
                }

                if (quantity >= 0)
                {
                    if (idBill == -1)
                    {
                        BillDAO.Instance.InserBillTemp(ItemID, finalTotalPrice, price, count, StatisticDAO.Instance.GetMaxIDStatistic());
                        // BillDAO.Instance.InserBill(ItemID, finalTotalPrice, price, count, StatisticDAO.Instance.GetMaxIDStatistic());
                    }
                    else
                    {
                        BillDAO.Instance.UpdateQuantityBillTemp(ItemID, finalTotalPrice, count);
                        //BillInfoDAO.Instance.InserBillInfo(idBill, ItemID, count);
                    }

                    ShowBill(product.ItemID);
                    LoadTable();
                    // BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                }
                else
                {
                    MessageBox.Show("Products Not In Stock");
                    BillDAO.Instance.PlusSLDamua(ItemID, count);
                    LoadTable();
                }
            }
            else
            {
                MessageBox.Show("Invalid Purchase Quantity");
            }

        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Items items = lsvBill.Tag as Items;
            int idBill = BillDAO.Instance.getitemshowtemp(items.ItemID);
            int idAccount = (LoginAccount as Account).AccountID;



            float totalprice = 0;
            if (idBill != -1)
            {
                List<BillTemp> billlist = BillTempDAO.Instance.GetlistBilltemp();
                //List<BillTemp> billTempList = BillTempDAO.Instance.GetListBillTemp(idBill);
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn "), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    int numberbill = BillDAO.Instance.Getnumberbill();

                    //   int idbillmax = BillDAO.Instance.GetMaxIDBill(); 
                    foreach (BillTemp item in billlist)
                    {
                        int indexidstatistic = BillDAO.Instance.GetMaxIDStatistic();
                        //tao id moi cho bang statistic
                        StatisticDAO.Instance.InsertIDstatistic(indexidstatistic);
                        totalprice += item.TotalPriceBillTemp;
                        BillDAO.Instance.CheckOut(item.ItemIdTemp, item.QuantityTemp, item.PriceTemp, item.DiscountTemp, item.TotalPriceBillTemp, indexidstatistic, numberbill);
                        BillDAO.Instance.UpdateStatistic(indexidstatistic, item.TotalPriceBillTemp, numberbill, idAccount);

                    }
                    MessageBox.Show("Tổng Số Tiền Phải Thanh Toán là :" + totalprice + "\n Nhân viên: " + LoginAccount.DisplayName);
                    //LoadTable();
                    BillDAO.Instance.Deletedulieushowtemp();

                    lsvBill.Items.Clear();
                    txbTotalPrice.Text = "0";
                    nmitemquantity.Value = 0;
                }

            }

        }
        #endregion

        private void btnRename_Click(object sender, EventArgs e)
        {
            fAccoutProfile1 f = new fAccoutProfile1(loginAccount);
            /*            this.Hide();*/
            f.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            fLogin f = new fLogin();
            f.ShowDialog();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lsvBill.Items.Clear();
            txbTotalPrice.Text = "0";
            //BillDAO.Instance.Deletedulieubillinfo();                   
            BillDAO.Instance.Deletedulieushowtemp();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadTable();
            cbSearhCategoryName.SelectedIndex = -1;
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            List<Items> tablelist = ItemsDAO.Instance.SearchitemByName(txbSearchItem.Text);
            foreach (Items item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.NameItem + Environment.NewLine + "price: " + item.ExportPriceItem + Environment.NewLine + "SL còn: " + item.QuantityItem + Environment.NewLine + "ID :" + item.ItemID;

                btn.Click += Btn_Click;
                btn.Tag = item;

                flpTable.Controls.Add(btn);
            }
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "NameCategory";

        }

        private void cbSearchItems_click(object sender, EventArgs e)
        {
            if (cbSearhCategoryName.SelectedValue == null)
            {
                LoadTable();
            }
            else
            {
                int categoryID = (cbSearhCategoryName.SelectedItem as ItemCategory).CategoryID;
                flpTable.Controls.Clear();
                List<Items> tablelist = ItemsDAO.Instance.GetitemByCategoryID(categoryID);
                foreach (Items item in tablelist)
                {
                    Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                    btn.Text = item.NameItem + Environment.NewLine + "price: " + item.ExportPriceItem + Environment.NewLine + "SL còn: " + item.QuantityItem + Environment.NewLine + "ID :" + item.ItemID;

                    btn.Click += Btn_Click;
                    btn.Tag = item;

                    flpTable.Controls.Add(btn);

                }
            }

        }
        private void btnItemReturn_Click(object sender, EventArgs e)
        {
            Items product = lsvBill.Tag as Items;
            float price = 0;

            if (product == null)
            {
                MessageBox.Show("Please select the product");
                return;
            }

            if (mnCountItemReturn.Value > 0)
            {
                lsvBill.Items.Clear();

                List<Items> itemlist = ItemsDAO.Instance.GetitemByID(product.ItemID);
                foreach (Items item in itemlist)
                {
                    price = item.ExportPriceItem;
                }
                int idBill = BillDAO.Instance.getitemshowtemp(product.ItemID);
                int ItemID = product.ItemID;
                float count = (float)mnCountItemReturn.Value;
                float totalPrice = price * count;

                BillDAO.Instance.InserBillTemp(ItemID, totalPrice, price, count, StatisticDAO.Instance.GetMaxIDStatistic());

                ShowBill(product.ItemID);
                LoadTable();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Items items = lsvBill.Tag as Items;
            int idBill = BillDAO.Instance.getitemshowtemp(items.ItemID);

            float totalprice = 0;
            if (idBill != -1)
            {
                List<BillTemp> billlist = BillTempDAO.Instance.GetlistBilltemp();
                if (MessageBox.Show(string.Format("Bạn có chắc hoàn trả món hàng này"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    foreach (BillTemp item in billlist)
                    {
                        totalprice += item.TotalPriceBillTemp;
                        ItemReturnDAO.Instance.InserItemReturn(item.QuantityTemp, item.ItemIdTemp, item.TotalPriceBillTemp);
                        ItemsDAO.Instance.InsertquantityItems(item.QuantityTemp, item.ItemIdTemp);
                      
                    }
                    MessageBox.Show("Tổng Số Tiền Phải Hoàn Lại Là :" + totalprice + "\n Nhân viên: " + LoginAccount.DisplayName);
                    BillDAO.Instance.Deletedulieushowtemp();

                    lsvBill.Items.Clear();
                    txbTotalPrice.Text = "0";
                    mnCountItemReturn.Value = 0;
                }
            }
            LoadTable();
        }
    }
}
