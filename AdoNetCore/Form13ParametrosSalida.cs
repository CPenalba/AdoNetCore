using AdoNetCore.Models;
using AdoNetCore.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
//CREATE PROCEDURE SP_ALL_DEPARTEMENTOS
//AS
//SELECT * FROM DEPT
//GO
//CREATE PROCEDURE SP_EMPLEADOS_DEPT_OUT
//(@nombre int OUT,
//@suma int OUT,
//@media int OUT,
//@personas int OUT)
//AS
//DECLARE @id int
//select @id = DEPT_NO from DEPT
//WHERE DNOMBRE=@nombre
//SELECT * FROM EMP WHERE DEPT_NO=@id
//SELECT @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO) from EMP
//WHERE DEPT_NO=@id
//go
#endregion

namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametrosOut repo;
      
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            List<string> departamentos =
           await this.repo.GetDepartamentosAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (string name in departamentos)
            {
                this.cmbDepartamentos.Items.Add(name);
            }

        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            EmpleadosModelOut model =
                await this.repo.GetEmpleadosModelAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSumaSalarial.Text = model.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }
    }
}
