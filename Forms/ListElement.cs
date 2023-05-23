using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rul.Forms
{
    public partial class ListElement : Form
    {
        public ListElement(string productName, string productDescription, string productManufacturer, decimal productPrice, int productDiscount, string productPhotoName)
        {
            InitializeComponent();
            PbPhoto.Image = Image.FromFile(productPhotoName);
            LblProductName.Text = productName;
            LblProductDesc.Text = productDescription;
            LblProductManuf.Text = productManufacturer;
            LblProductPrice.Text = productPrice.ToString();
            LblDiscount.Text = productDiscount.ToString();
        }
    }
}
