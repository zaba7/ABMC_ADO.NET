using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TpFinal
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos; //aqui se guardaran todos los articulos
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            Articulos_Negocio negocio = new Articulos_Negocio();
            listaArticulos = negocio.listar(); //recibo un origen de datos y lo modelo en la tabla
            dgv_Articulos.DataSource = listaArticulos;
            cargar_imagen(listaArticulos[0].ImagenUrl); //imagen x defecto 1er articulo
            ocultarColumnas();
        }
        public void ocultarColumnas()
        {
            dgv_Articulos.Columns["ImagenUrl"].Visible = false;
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo) dgv_Articulos.CurrentRow.DataBoundItem; //para  q no devuelva un object aclaro q es un articulo
            cargar_imagen(seleccionado.ImagenUrl);
        }
        private void cargar_imagen(string imagen) //cacheo la excepcion y copio el metodo en los demas
        {
            try
            {
                pictureBoxArticulos.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBoxArticulos.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form2 alta = new Form2();
            alta.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;

            Form2 modificar = new Form2(seleccionado);
            modificar.ShowDialog();
            cargar();   
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Articulos_Negocio negocio = new Articulos_Negocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?","Eliminando",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta== DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }                      
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltro.Text;

            if (filtro.Length >= 1)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgv_Articulos.DataSource = null;
            dgv_Articulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }  
}
