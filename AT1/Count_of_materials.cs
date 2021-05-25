using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT1
{
    public partial class Count_of_materials : Form
    {
        int rowIndex = -1;
        SqlDataAdapter sqlDA;
        public Count_of_materials()
        {
            InitializeComponent();
        }
        private void ReloadGrid()
        {
            sqlDA = new SqlDataAdapter("SELECT Count_of_materials.id, Sizes.Name_of_Size, Materials.Name_of_Materials, Type_of_Service.Name_of_Service, Counts FROM Count_of_materials inner join Sizes on Count_of_materials.id_Size = Sizes.id inner join Materials on Count_of_materials.id_Material = Materials.id inner join Type_of_Service on Count_of_materials.id_Service = Type_of_Service.id", sqlconnect.sql_con);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Count_of_materials_Load(object sender, EventArgs e)
        {
            sqlconnect.connect_open();
            ReloadGrid();
            dataGridView1.Columns[0].Visible = false;
        }

        private void Foo_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlconnect.sqlconnect_close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form K1 = new K1();
            K1.Show();
            /* SqlDataAdapter adap = new SqlDataAdapter();
             //if ((textBox1.Text != "") && (comboBox1.SelectedIndex > -1) && (comboBox2.SelectedIndex > -1) && (comboBox3.SelectedIndex > -1))
             //{
                 //  if (emp == null)
                 // {
                 adap.InsertCommand = new SqlCommand("INSERT INTO Count_of_materials(id_Material, id_Service, id_Size, Counts) VALUES (@id_Material, @id_Service, @id_Size, @Counts)", sqlconnect.sql_con);
                 adap.InsertCommand.Parameters.Add(new SqlParameter("@id_Material", SqlDbType.VarChar));
                 adap.InsertCommand.Parameters.Add(new SqlParameter("@id_Service", SqlDbType.VarChar));
                 adap.InsertCommand.Parameters.Add(new SqlParameter("@id_Size", SqlDbType.VarChar));
                 adap.InsertCommand.Parameters.Add(new SqlParameter("@Counts", SqlDbType.Int));
                 adap.InsertCommand.Parameters["@id_Material"].Value = comboBox1.SelectedValue;
                 adap.InsertCommand.Parameters["@id_Service"].Value = comboBox2.SelectedValue;
                 adap.InsertCommand.Parameters["@id_Size"].Value = comboBox3.SelectedValue;
                 adap.InsertCommand.Parameters["@Counts"].Value = textBox1.Text;
                 //////adap.InsertCommand.ExecuteNonQuery();
                 // }
                 /*else
                 {
                     adap.UpdateCommand = new SqlCommand("UPDATE Employee SET First_Name = @First_Name, Second_Name = @Second_Name, Surname = @Surname, Position = @Position "
                     + "WHERE id = @id", sqlconnect.sql_con);
                     adap.UpdateCommand.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.VarChar));
                     adap.UpdateCommand.Parameters.Add(new SqlParameter("@Second_Name", SqlDbType.VarChar));
                     adap.UpdateCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.VarChar));
                     adap.UpdateCommand.Parameters.Add(new SqlParameter("@Position", SqlDbType.Int));
                     adap.UpdateCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));

                     adap.UpdateCommand.Parameters[1].Value = textBox2.Text;
                     adap.UpdateCommand.Parameters["@Surname"].Value = textBox3.Text;
                     adap.UpdateCommand.Parameters["@Position"].Value = comboBox1.SelectedValue;
                     adap.UpdateCommand.Parameters["@id"].Value = emp.id;
                     adap.UpdateCommand.ExecuteNonQuery();
                 };
                 this.Close();*/
            //} 


        }
       
    }
}
