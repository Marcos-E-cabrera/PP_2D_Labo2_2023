using Biblioteca_Carniceria;
using Frm_Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Heladera : Form
    {
        #region CAMPOS
        private Vendedor vendedor;
        private Producto producto;
        private CN_Heladera cn_Heladera = new CN_Heladera();
        #endregion

        #region CONSTRUCTOR
        public Frm_Heladera()
        {
            InitializeComponent();
            cn_Heladera.stockEnCero += LlamarProveedores;
        }
        #endregion

        #region LOAD
        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            MostrarProductos();

            XML.Serializacion();
            Archivos.CrearArchivo_xml(XML.Deserializacion());
            JSON.Serializacion();
            Archivos.CrearArchivo_json(JSON.Deserializacion());

            cbxTipo.Items.Add("Vacuno");
            cbxTipo.Items.Add("Ternero");
            cbxTipo.Items.Add("Cerdo");
            cbxTipo.Items.Add("Cordero");
            cbxTipo.Items.Add("Pollo");
            cbxTipo.Items.Add("Procesado");

            cbxOrdenamiento.Items.Add("Nombre");
            cbxOrdenamiento.Items.Add("Precio");
            cbxOrdenamiento.Items.Add("Stock");
            cbxOrdenamiento.Items.Add("Detalle");

            cbxTipo.SelectedIndex = 0;
        }
        #endregion

        #region MOSTRAR
        public void MostrarProductos()
        {
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = CN_Heladera.ListHeladera;
        }
        #endregion

        #region METODOS DGV
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
        {
            return dgvHeladera.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public void DGV_GetProducto(int index, out Producto aux)
        {
            Producto p = new Producto();

            p.Corte = dgvHeladera[0, index].Value.ToString();
            p.Precio = Convert.ToInt32(dgvHeladera[1, index].Value);
            p.Stock = Convert.ToInt32(dgvHeladera[2, index].Value);
            p.Tipo = (eTipo)Convert.ToInt32(dgvHeladera[3, index].Value);

            aux = p;
        }

        public int DGV_GetID(int index)
        {
            Producto p = new Producto();
            int id;

            p.Id = Convert.ToInt32(dgvHeladera[4, index].Value);
            id = p.Id;

            return id;
        }

        /// <summary>
        /// Carga al DataGridView la nueva "Lista Heladera"
        /// </summary>
        /// <param name="l"></param>
        public void DGV_ActualizarDatos(List<Producto> l)
        {

            dgvHeladera.Refresh();
            dgvHeladera.DataSource = l;
            dgvHeladera.Columns[0].HeaderText = "Producto";
            dgvHeladera.Columns[1].HeaderText = "Precio x Kilo";
            dgvHeladera.Columns[2].HeaderText = "Stock";
            dgvHeladera.Columns[3].HeaderText = "Tipo de Carne";
        }

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvHeladera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvHeladera[0, dgvHeladera.CurrentRow.Index].Value.ToString();
            txtPrecio.Text = dgvHeladera[1, dgvHeladera.CurrentRow.Index].Value.ToString();
            txtStock.Text = dgvHeladera[2, dgvHeladera.CurrentRow.Index].Value.ToString();
            cbxTipo.Text = dgvHeladera[3, dgvHeladera.CurrentRow.Index].Value.ToString();
        }
        #endregion

        #region CRUD

        #region CREATED
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                eTipo tipoAux = (eTipo)Enum.Parse(typeof(eTipo), cbxTipo.Text);
                CD_Productos.Created(txtNombre.Text, float.Parse(txtPrecio.Text), int.Parse(txtStock.Text), tipoAux.ToString());
                MensajeDeOK("Se cargo el Producto correctamente", "CREATED PRODUCTO");
                MostrarProductos();
            }
            catch (Exception ex)
            {
                MensajeDeError("No se cargo el producto", "ERROR CREATED");
            }
        }
        #endregion

        #region ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = DGV_GetFila();
                int id = DGV_GetID(index);
                CD_Productos.Delate(id);

                MensajeDeOK("Se Elimino el Producto correctamente", "DELETE PRODUCTO");
                MostrarProductos();
            }
            catch (Exception ex)
            {
                MensajeDeError("No se Elimino el producto", "ERROR DELETE");
            }
        }

        #endregion

        #endregion

        #region REPONER
        private void btnReponer_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            int index;
            index = DGV_GetFila();
            DGV_GetProducto(index, out producto);

            switch (Vendedor.Reponer(producto, txtStock.Text))
            {
                case 0:
                    DGV_ActualizarDatos(CN_Heladera.CargarHeladera(index, producto));
                    break;
                case 1:
                    MensajeDeError("El stock no puede ser menor a 0 y no puede bajar el stock.", "Error [ 1 ]");
                    break;
                case 2:
                    MensajeDeError("El stock debe ser un número entero/ cantidad no Ingresada.", "Error [ 2 ]");
                    break;
            }
        }
        #endregion

        #region LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        #endregion

        #region ORDENAMIENTO
        private void cbxOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Heladera.OrdenarHeladera(cbxOrdenamiento.SelectedIndex);
            MostrarProductos();
        }
        #endregion

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            if ( CN_Heladera.ListHeladera.Exists(X => X.Stock == 0))
            {
                Producto producto = CN_Heladera.ListHeladera.Find(X => X.Stock == 0);

                cn_Heladera.CheckearHeladera(producto.Id, DatoCorrecto, DatoIncorrecto);
                MostrarProductos();
            }
            else
            {
                MensajeDeOK("No hace falta llamar Proveedores", "Falsa Alarma");
            }

        }

        public void DatoCorrecto()
        {
            MessageBox.Show("PRODUCTO REPUESTO");
        }

        public void DatoIncorrecto(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void LlamarProveedores()
        {
            MessageBox.Show("LLamando proveedores");
        }
    }
}
