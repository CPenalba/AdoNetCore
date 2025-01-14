using AdoNetCore.Models;
using AdoNetCore.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCore
{
    public partial class Form09CrudHospitales : Form
    {
        private RepositoryHospitales repo;
        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospitales =
            await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hos in hospitales)
            {
                this.lstHospitales.Items.Add(hos.IdHospital
                    + " - " + hos.Nombre + " - " + hos.Direccion + " - " + hos.Telefono + " - " + hos.NumCama);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCama = int.Parse(this.txtNumCama.Text);
            await this.repo.InsertHospitalAsync(id, nombre, direccion, telefono, numCama);
            this.LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int numCama = int.Parse(this.txtNumCama.Text);
            await this.repo.UpdateHospitakAsync(id, nombre, direccion, telefono, numCama);
            this.LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteHospitalAsync(id);
            this.LoadHospitales();
        }
    }
}
