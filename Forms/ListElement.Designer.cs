
namespace Rul.Forms
{
    partial class ListElement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbPhoto = new System.Windows.Forms.PictureBox();
            this.PlInfo = new System.Windows.Forms.Panel();
            this.LblProductPrice = new System.Windows.Forms.Label();
            this.LblProductManuf = new System.Windows.Forms.Label();
            this.LblProductDesc = new System.Windows.Forms.Label();
            this.LblProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDiscount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbPhoto)).BeginInit();
            this.PlInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbPhoto
            // 
            this.PbPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbPhoto.Location = new System.Drawing.Point(0, 0);
            this.PbPhoto.Name = "PbPhoto";
            this.PbPhoto.Size = new System.Drawing.Size(110, 110);
            this.PbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPhoto.TabIndex = 0;
            this.PbPhoto.TabStop = false;
            // 
            // PlInfo
            // 
            this.PlInfo.Controls.Add(this.LblProductPrice);
            this.PlInfo.Controls.Add(this.LblProductManuf);
            this.PlInfo.Controls.Add(this.LblProductDesc);
            this.PlInfo.Controls.Add(this.LblProductName);
            this.PlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlInfo.Location = new System.Drawing.Point(110, 0);
            this.PlInfo.Name = "PlInfo";
            this.PlInfo.Size = new System.Drawing.Size(350, 110);
            this.PlInfo.TabIndex = 1;
            // 
            // LblProductPrice
            // 
            this.LblProductPrice.AutoSize = true;
            this.LblProductPrice.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblProductPrice.Location = new System.Drawing.Point(11, 86);
            this.LblProductPrice.Name = "LblProductPrice";
            this.LblProductPrice.Size = new System.Drawing.Size(43, 19);
            this.LblProductPrice.TabIndex = 3;
            this.LblProductPrice.Text = "Цена";
            // 
            // LblProductManuf
            // 
            this.LblProductManuf.AutoSize = true;
            this.LblProductManuf.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblProductManuf.Location = new System.Drawing.Point(10, 57);
            this.LblProductManuf.Name = "LblProductManuf";
            this.LblProductManuf.Size = new System.Drawing.Size(115, 19);
            this.LblProductManuf.TabIndex = 2;
            this.LblProductManuf.Text = "Производитель";
            // 
            // LblProductDesc
            // 
            this.LblProductDesc.AutoSize = true;
            this.LblProductDesc.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblProductDesc.Location = new System.Drawing.Point(12, 30);
            this.LblProductDesc.Name = "LblProductDesc";
            this.LblProductDesc.Size = new System.Drawing.Size(77, 19);
            this.LblProductDesc.TabIndex = 1;
            this.LblProductDesc.Text = "Описание";
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblProductName.Location = new System.Drawing.Point(9, 7);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(111, 19);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Наименование";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(460, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 110);
            this.panel2.TabIndex = 2;
            // 
            // LblDiscount
            // 
            this.LblDiscount.AutoSize = true;
            this.LblDiscount.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblDiscount.Location = new System.Drawing.Point(29, 46);
            this.LblDiscount.Name = "LblDiscount";
            this.LblDiscount.Size = new System.Drawing.Size(55, 19);
            this.LblDiscount.TabIndex = 4;
            this.LblDiscount.Text = "Скидка";
            // 
            // ListElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 110);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PlInfo);
            this.Controls.Add(this.PbPhoto);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListElement";
            this.Text = "ListElement";
            ((System.ComponentModel.ISupportInitialize)(this.PbPhoto)).EndInit();
            this.PlInfo.ResumeLayout(false);
            this.PlInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbPhoto;
        private System.Windows.Forms.Panel PlInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblProductPrice;
        private System.Windows.Forms.Label LblProductManuf;
        private System.Windows.Forms.Label LblProductDesc;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.Label LblDiscount;
    }
}