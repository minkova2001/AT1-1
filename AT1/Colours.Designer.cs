
namespace AT1
{
    partial class Colours
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atelieDataSet = new AT1.AtelieDataSet();
            this.coloursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coloursTableAdapter = new AT1.AtelieDataSetTableAdapters.ColoursTableAdapter();
            this.fKOrdersColourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new AT1.AtelieDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atelieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersColourBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // atelieDataSet
            // 
            this.atelieDataSet.DataSetName = "AtelieDataSet";
            this.atelieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloursBindingSource
            // 
            this.coloursBindingSource.DataMember = "Colours";
            this.coloursBindingSource.DataSource = this.atelieDataSet;
            // 
            // coloursTableAdapter
            // 
            this.coloursTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrdersColourBindingSource
            // 
            this.fKOrdersColourBindingSource.DataMember = "FK_Orders_Colour";
            this.fKOrdersColourBindingSource.DataSource = this.coloursBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Colours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Colours";
            this.Text = "Colours";
            this.Load += new System.EventHandler(this.Colours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atelieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersColourBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AtelieDataSet atelieDataSet;
        private System.Windows.Forms.BindingSource coloursBindingSource;
        private AtelieDataSetTableAdapters.ColoursTableAdapter coloursTableAdapter;
        private System.Windows.Forms.BindingSource fKOrdersColourBindingSource;
        private AtelieDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}