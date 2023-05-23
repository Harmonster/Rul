
namespace Rul
{
    partial class Products
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
            this.PlCatalog = new System.Windows.Forms.Panel();
            this.TsMenu = new System.Windows.Forms.ToolStrip();
            this.TsCbSort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsCbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsTbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlCatalog
            // 
            this.PlCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlCatalog.Location = new System.Drawing.Point(0, 28);
            this.PlCatalog.Name = "PlCatalog";
            this.PlCatalog.Size = new System.Drawing.Size(800, 422);
            this.PlCatalog.TabIndex = 0;
            // 
            // TsMenu
            // 
            this.TsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCbSort,
            this.toolStripSeparator1,
            this.TsCbFilter,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.TsTbSearch,
            this.toolStripSeparator3});
            this.TsMenu.Location = new System.Drawing.Point(0, 0);
            this.TsMenu.Name = "TsMenu";
            this.TsMenu.Size = new System.Drawing.Size(800, 28);
            this.TsMenu.TabIndex = 1;
            this.TsMenu.Text = "toolStrip1";
            // 
            // TsCbSort
            // 
            this.TsCbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Стоимость по убыванию",
            "Стоимость по возрастанию"});
            this.TsCbSort.Name = "TsCbSort";
            this.TsCbSort.Size = new System.Drawing.Size(200, 28);
            this.TsCbSort.SelectedIndexChanged += new System.EventHandler(this.TsCbSort_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // TsCbFilter
            // 
            this.TsCbFilter.Items.AddRange(new object[] {
            "Все диапазоны",
            "0% - 9,99%",
            "10% - 14.99%",
            "15% и более"});
            this.TsCbFilter.Name = "TsCbFilter";
            this.TsCbFilter.Size = new System.Drawing.Size(200, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 25);
            this.toolStripLabel1.Text = "Поиск";
            // 
            // TsTbSearch
            // 
            this.TsTbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TsTbSearch.Name = "TsTbSearch";
            this.TsTbSearch.Size = new System.Drawing.Size(150, 28);
            this.TsTbSearch.TextChanged += new System.EventHandler(this.TsTbSearch_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlCatalog);
            this.Controls.Add(this.TsMenu);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.TsMenu.ResumeLayout(false);
            this.TsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlCatalog;
        private System.Windows.Forms.ToolStrip TsMenu;
        private System.Windows.Forms.ToolStripComboBox TsCbSort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox TsCbFilter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox TsTbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}