using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region STORED PROCEDURES
//CREATE PROCEDURE SP_ALL_DEPARTAMENTOS
//AS
//    SELECT * FROM dept;
//GO
//ALTER PROCEDURE SP_INSERT_DEPARTAMENTO
//    @numero INT,
//    @nombre NVARCHAR(50),
//    @localidad NVARCHAR(50)
//AS
//	--NO QUEREMOSLA LOCALIDAD DE TERUEL
//	if(@localidad = 'TERUEL')
//	BEGIN
//	PRINT 'TERUEL NO EXISTE'
//	end
//	else
//	begin
//    INSERT INTO dept (DEPT_NO, DNOMBRE, LOC)
//    VALUES (@numero, @nombre, @localidad);
//end
//GO
#endregion

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA; Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            //RECUPERAMOS EL EVENTO DE MENSAJES DE AL CONECION
            this.cn.InfoMessage += Cn_InfoMessage;

            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        public async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string id = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(id + " - " + nombre + " - " + localidad );
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

        }

        private  void btnInsertar_Click(object sender, EventArgs e)
            
        {
            this.lblMensaje.Text = "";
            int numero = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
             this.cn.OpenAsync();
            int insertados =  this.com.ExecuteNonQuery();
             this.cn.CloseAsync();
            this.com.Parameters.Clear();
            // this.LoadDepartamentos();
            MessageBox.Show("Departamentos insertados: " + insertados);
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
