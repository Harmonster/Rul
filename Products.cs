using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rul
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private string CheckPhotoPath(int i)
        {
            if (string.IsNullOrEmpty(Data.ProductDataTable.Rows[i]["ProductPhoto"].ToString()))
                return "Resources/picture.png";
            else
                return "Resources/" + Data.ProductDataTable.Rows[i]["ProductPhoto"];
        }
        private void Products_Load(object sender, EventArgs e)
        {
            TsCbFilter.SelectedIndex = 0;
            TsCbSort.SelectedIndex = 0;
            Database.GetProducts(Data.ProductDataTable);

            PlCatalog.AutoScroll = false;
            PlCatalog.HorizontalScroll.Enabled = false;
            PlCatalog.HorizontalScroll.Visible = false;
            PlCatalog.AutoScroll = true;

            ShowProductList(Data.ProductDataTable);
        }

        private void ShowProductList(DataTable dt)
        {
            string s;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Forms.ListElement form = new Forms.ListElement(
                                        dt.Rows[i]["ProductName"].ToString(),
                                        dt.Rows[i]["ProductDescription"].ToString(),
                                        dt.Rows[i]["ProductManufacturer"].ToString(),
                                        Convert.ToDecimal(dt.Rows[i]["ProductCost"]),
                                        Convert.ToInt32(dt.Rows[i]["ProductDiscountAmount"]),
                                        s = CheckPhotoPath(i)
                                        );
                form.TopLevel = false;
                form.Dock = DockStyle.Top;
                PlCatalog.Controls.Add(form);
                form.Show();
            }
        }

        private void TsCbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable SortedDataTable = new DataTable();
            SortedDataTable = Data.ProductDataTable;

            if (TsCbSort.SelectedIndex == 0)
            {
                PlCatalog.Controls.Clear();
                ShowProductList(Data.ProductDataTable);
            }
            else if (TsCbSort.SelectedIndex == 1)
            {
                DataView dv = SortedDataTable.DefaultView;
                dv.Sort = "ProductCost ASC";
                SortedDataTable = dv.ToTable();
                PlCatalog.Controls.Clear();
                ShowProductList(SortedDataTable);
            }
            else if (TsCbSort.SelectedIndex == 2)
            {
                DataView dv = SortedDataTable.DefaultView;
                dv.Sort = "ProductCost DESC";
                SortedDataTable = dv.ToTable();
                PlCatalog.Controls.Clear();
                ShowProductList(SortedDataTable);
            }
        }

        private void TsTbSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable SortedDataTable = new DataTable();
            SortedDataTable = Data.ProductDataTable;


        }
    }
}
