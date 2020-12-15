using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AdminBanHang.BLL;
using AdminBanHang.DAL;
using AdminBanHang.DTO;

namespace AdminBanHang.GUI
{
    public partial class QuanlyProduct : Form
    {
        private ImageList imageList;
        private string path = "", fullpath = "";
        private bool flag = false, clickSearch = false;
        private int id = -1;
        public QuanlyProduct()
        {
            InitializeComponent();
            LoadListview();
            LoadComboType();
            LoadComboCompany();
        }

        private void LoadComboType()
        {
            ProductBLL productBLL = new ProductBLL();
            comboType.DataSource = productBLL.GetAllType();
            comboType.DisplayMember = "TypeName";
            comboSearchType.DataSource = productBLL.GetAllType();
            comboSearchType.DisplayMember = "TypeName";
        }
        private void LoadComboCompany()
        {
            ProductBLL productBLL = new ProductBLL();
            comboCategory.DataSource = productBLL.GetAllCompany();
            comboCategory.DisplayMember = "CompanyName";
            comboSearchCategory.DataSource = productBLL.GetAllCompany();
            comboSearchCategory.DisplayMember = "CompanyName";
        }

        private void comboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Types types = (Types)comboType.SelectedItem;
            //comboType.DataSource = productBLL.GetTypes(types.Id);
            comboType.DisplayMember = "TypeName";
        }

        private void comboSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Types types = (Types)comboSearchType.SelectedItem;
            //comboSearchType.DataSource = productBLL.GetTypes(types.Id);
            comboSearchType.DisplayMember = "TypeName";
        }
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Company company = (Company)comboCategory.SelectedItem;
            //comboCategory.DataSource = productBLL.GetCompany(company.Id);
            comboCategory.DisplayMember = "CompanyName";
        }

        private void comboSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Company company = (Company)comboCategory.SelectedItem;
            //comboSearchCategory.DataSource = productBLL.GetCompany(company.Id);
            comboSearchCategory.DisplayMember = "CompanyName";
        }
        private void LoadImage(DataTable dataTable)
        {
            imageList = new ImageList() { ImageSize = new Size(70, 70) };
            foreach (DataRow row in dataTable.Rows)
            {
                imageList.Images.Add(row.Field<int>("Id").ToString(), new Bitmap(DBConnection.folder_product + row.Field<string>("Image")));
            }
        }
        public void LoadListview()
        {
            ProductBLL productBLL = new ProductBLL();
            DataTable dataTable;
            if (clickSearch)
            {
                int typeid, comid;
                Types idtype = (Types)comboSearchType.SelectedItem;
                if (idtype == null) typeid = 0;
                else typeid = idtype.Id;
                Company idcate = (Company)comboSearchCategory.SelectedItem;
                if (idcate == null) comid = 0;
                else comid = idcate.Id;
                string text = txtSearch.Text;
                
                dataTable = productBLL.Search(typeid, comid, text);
            }
            else
            {
                dataTable = productBLL.GetAllProduct();
            }
            LoadImage(dataTable);
            listViewProduct.Clear();
            listViewProduct.View = View.Details;
            listViewProduct.FullRowSelect = true;
            listViewProduct.SmallImageList = imageList;

            listViewProduct.Columns.Add("Image", 70);
            listViewProduct.Columns.Add("Product name",100);
            listViewProduct.Columns.Add("Category",70);
            listViewProduct.Columns.Add("Company",70);
            listViewProduct.Columns.Add("Amount");
            listViewProduct.Columns.Add("Price");
            listViewProduct.Columns.Add("Detail",200);

            ListViewItem lvitem;
            foreach (DataRow row in dataTable.Rows)
            {
                lvitem = new ListViewItem();
                lvitem.ImageKey = row.Field<int>("Id").ToString();
                lvitem.SubItems.Add( row.Field<string>("Productname"));
                lvitem.SubItems.Add(row.Field<string>("TypeName"));
                lvitem.SubItems.Add(row.Field<string>("CompanyName"));
                lvitem.SubItems.Add(row.Field<int>("Amount").ToString());
                lvitem.SubItems.Add(row.Field<int>("Price").ToString());
                lvitem.SubItems.Add(row.Field<string>("Detail"));
                listViewProduct.Items.Add(lvitem);
            }    
        }
        private void Click_listview(object sender, EventArgs e)
        {
            txtProductname.Text = listViewProduct.SelectedItems[0].SubItems[1].Text;
            comboType.Text = listViewProduct.SelectedItems[0].SubItems[2].Text;
            comboCategory.Text = listViewProduct.SelectedItems[0].SubItems[3].Text;
            amount.Value = decimal.Parse(listViewProduct.SelectedItems[0].SubItems[4].Text);
            price.Value = decimal.Parse(listViewProduct.SelectedItems[0].SubItems[5].Text);
            txtDetail.Text = listViewProduct.SelectedItems[0].SubItems[6].Text;
            int idproduct = int.Parse(listViewProduct.SelectedItems[0].ImageKey);
            LoadPreviewImage(idproduct);
            id = idproduct;
        }
        private void LoadPreviewImage(int id)
        {
            ProductBLL productBLL = new ProductBLL();
            path = productBLL.pathImage(id);
            previewImage.Image = Image.FromFile(DBConnection.folder_product + path);
            previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNameImage.Text = path;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());
            
            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Company s = (Company)comboCategory.SelectedItem;
            product.companyid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            try
            {
                File.Copy(fullpath, DBConnection.folder_product + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            productBLL.AddProduct(product);
            LoadListview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());

            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Company s = (Company)comboCategory.SelectedItem;
            product.companyid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            if(flag) File.Copy(fullpath, DBConnection.folder_product + path);

            productBLL.EditProduct(product, id);
            LoadListview();
            flag = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productBLL.DeleteProduct(id);
            txtProductname.Text = "";
            txtDetail.Text = "";
            amount.Value = 0;
            price.Value = 0;
            lblNameImage.Text = "Chưa có ảnh";
            previewImage.Image = null;
            LoadListview();
            flag = false;
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"C:\Users\Admin\Documents\GitHub\adminBanHang\AdminBanHang\Resources\";
            openFileDialog.Filter = "Select Valid Document (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        fullpath = openFileDialog.FileName;
                        path = openFileDialog.SafeFileName;
                        previewImage.Image = Image.FromFile(fullpath);
                        previewImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblNameImage.Text = path;
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());

            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Company s = (Company)comboCategory.SelectedItem;
            product.companyid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            try
            {
                File.Copy(fullpath, DBConnection.folder_product + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            productBLL.AddProduct(product);
            LoadListview();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            Product product = new Product();
            product.productname = txtProductname.Text;
            product.detail = txtDetail.Text;
            product.price = int.Parse(price.Value.ToString());
            product.amount = int.Parse(amount.Value.ToString());

            /* Lấy Id từ commobox đưa vào cơ sở dữ liệu */
            Company s = (Company)comboCategory.SelectedItem;
            product.companyid = s.Id;

            /*Lấy Tên Ảnh đưa vào cơ sở dữ liệu*/
            product.image = path;
            if (flag) File.Copy(fullpath, DBConnection.folder_product + path);

            productBLL.EditProduct(product, id);
            LoadListview();
            flag = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            productBLL.DeleteProduct(id);
            txtProductname.Text = "";
            txtDetail.Text = "";
            amount.Value = 0;
            price.Value = 0;
            lblNameImage.Text = "Chưa có ảnh";
            previewImage.Image = null;
            LoadListview();
            flag = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clickSearch = true;
            LoadListview();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clickSearch = false;
            LoadListview();
        }
    }
}
