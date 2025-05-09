using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class Driver_Payment : UserControl
    {

        public Driver_Payment()
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sALESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet1 = new FastFood.Database2DataSet1();
            this.sALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new FastFood.Database2DataSet();
            this.sALESTableAdapter = new FastFood.Database2DataSetTableAdapters.SALESTableAdapter();
            this.sALESTableAdapter1 = new FastFood.Database2DataSet1TableAdapters.SALESTableAdapter();
            this.database2DataSet2 = new FastFood.Database2DataSet2();
            this.sALESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sALESTableAdapter2 = new FastFood.Database2DataSet2TableAdapters.SALESTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Product,
            this.Rate,
            this.Total,
            this.iDDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sALESBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(119, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sALESBindingSource1
            // 
            this.sALESBindingSource1.DataMember = "SALES";
            this.sALESBindingSource1.DataSource = this.database2DataSet1;
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALESBindingSource
            // 
            this.sALESBindingSource.DataMember = "SALES";
            this.sALESBindingSource.DataSource = this.database2DataSet;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALESTableAdapter
            // 
            this.sALESTableAdapter.ClearBeforeFill = true;
            // 
            // sALESTableAdapter1
            // 
            this.sALESTableAdapter1.ClearBeforeFill = true;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALESBindingSource2
            // 
            this.sALESBindingSource2.DataMember = "SALES";
            this.sALESBindingSource2.DataSource = this.database2DataSet2;
            // 
            // sALESTableAdapter2
            // 
            this.sALESTableAdapter2.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Driver_Payment
            // 
            this.Controls.Add(this.dataGridView1);
            this.Name = "Driver_Payment";
            this.Size = new System.Drawing.Size(760, 453);
            this.Load += new System.EventHandler(this.Driver_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        private void Driver_Payment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sALESTableAdapter.FillBy(this.database2DataSet.SALES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
