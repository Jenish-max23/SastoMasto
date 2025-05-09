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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver_Payment));
            this.sALESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet2 = new FastFood.Database2DataSet2();
            this.sALESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet1 = new FastFood.Database2DataSet1();
            this.sALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new FastFood.Database2DataSet();
            this.sALESTableAdapter = new FastFood.Database2DataSetTableAdapters.SALESTableAdapter();
            this.sALESTableAdapter1 = new FastFood.Database2DataSet1TableAdapters.SALESTableAdapter();
            this.sALESTableAdapter2 = new FastFood.Database2DataSet2TableAdapters.SALESTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sALESBindingSource2
            // 
            this.sALESBindingSource2.DataMember = "SALES";
            this.sALESBindingSource2.DataSource = this.database2DataSet2;
            // 
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sALESTableAdapter2
            // 
            this.sALESTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Report";
            // 
            // Driver_Payment
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Driver_Payment";
            this.Size = new System.Drawing.Size(760, 453);
            this.Load += new System.EventHandler(this.Driver_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
