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
    public partial class K : Form
    {
        Ka k;
        public K()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adap = new SqlDataAdapter();
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
            };*/
            this.Close();
            //} 
        }

        private void K_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDAMaterial = new SqlDataAdapter("SELECT id, Name_of_Materials FROM Materials", sqlconnect.sql_con);
            SqlDataAdapter sqlDAService = new SqlDataAdapter("SELECT id, Name_of_Service FROM Type_of_Service", sqlconnect.sql_con);
            SqlDataAdapter sqlDASize = new SqlDataAdapter("SELECT id, Name_of_Size FROM Sizes", sqlconnect.sql_con);
            DataTable dt = new DataTable();
            sqlDAMaterial.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name_of_materials";
            comboBox1.ValueMember = "id";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            if (k != null)
            {
                comboBox1.Text = k.id_material;
                comboBox2.Text = k.id_service;
                comboBox3.Text = k.id_size;
                textBox1.Text = k.counts;
                this.Text = "Изменение сотрудника";
            }
            else
            {
                comboBox1.SelectedIndex = -1;
                this.Text = "Добавление сотрудника";
            }
        }
    }
}
