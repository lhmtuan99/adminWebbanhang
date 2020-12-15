using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DAL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class ChooseProduct : Form
    {
        private ImageList imageList;
        private bool clickSearch = false;
        private string folder = DBConnection.folder_product;
        public ArrayList listProduct { get; set; }
        public int total { get; set; }
        public ChooseProduct()
        {
            InitializeComponent();
            LoadComboBoxType();
            LoadListView();
        }
        private void LoadComboBoxType()
        {
            ProductBLL productBLL = new ProductBLL();
            comboBoxType.DataSource = productBLL.GetAllType();
            comboBoxType.DisplayMember = "TypeName";
        }
        public ChooseProduct(ArrayList list)
        {
            this.listProduct = list;
            InitializeComponent();
            LoadListView();
        }
        private void LoadImage(DataTable dataTable)
        {
            imageList = new ImageList() { ImageSize = new Size(80, 80) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(folder + row.Field<string>("Image")));
            }
        }
        public void LoadListView()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
            if(clickSearch)
            {
                Types idtype = (Types)comboBoxType.SelectedItem;
                Company idcom = (Company)comboBoxBrand.SelectedItem;
                string text = txtSearch.Text;
                dataTable = productBLL.Search(idtype.Id, idcom.Id, text);
            }
            else
            {
                dataTable = productBLL.GetAllProduct();
            }
            
            LoadImage(dataTable);
            listViewProduct.Clear();
            listViewProduct.View = View.Details;
            listViewProduct.CheckBoxes = true;
            listViewProduct.FullRowSelect = true;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Image", 100);
            listViewProduct.Columns.Add("Product Name", 100);
            listViewProduct.Columns.Add("Category", 70);
            listViewProduct.Columns.Add("Company", 70);
            listViewProduct.Columns.Add("Amount");
            listViewProduct.Columns.Add("Price");
            listViewProduct.Columns.Add("Detail", 200);

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                if(listProduct != null)
                {
                    foreach(int a in listProduct)
                    {
                        if(int.Parse(lvitem.ImageKey) == a)
                        {
                            lvitem.Checked = true;
                            break;
                        }    
                    }    
                }    
                lvitem.SubItems.Add(row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("TypeName"));
                lvitem.SubItems.Add(row.Field<string>("CompanyName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString("0,0"));
                lvitem.SubItems.Add(row.Field<string>("Detail"));
                listViewProduct.Items.Add(lvitem);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ArrayList temp = new ArrayList();
            foreach(ListViewItem a in listViewProduct.CheckedItems)
            {
                temp.Add(int.Parse(a.ImageKey));
            }
            listProduct = temp;
        }

        private void ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int totaltemp = 0;
            foreach (ListViewItem a in listViewProduct.CheckedItems)
            {
                totaltemp += int.Parse(a.SubItems[5].Text.Replace(",",""));
            }
            total = totaltemp;
            txtTotal.Text = total.ToString("0,0");
            if (listViewProduct.CheckedItems.Count == 0)
            {
                btnOK.Enabled = false;
                return;
            }
            btnOK.Enabled = true;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Types types = (Types)comboBoxType.SelectedItem;
            comboBoxBrand.DataSource = productBLL.GetCompany(types.Id);
            comboBoxBrand.DisplayMember = "CompanyName";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickSearch = false;
            LoadListView();
        }
    }
}
