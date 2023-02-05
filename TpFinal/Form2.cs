using dominio;
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
using System.Xml.Linq;

namespace TpFinal
{
    public partial class Form2 : Form
    {
        private Articulo articulo = null;
        public Form2()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public Form2(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void btnCancelar01_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar01_Click(object sender, EventArgs e)
        {
            Articulos_Negocio negocio= new Articulos_Negocio();
            try
            {
                if (articulo==null)             
                    articulo = new Articulo();
                
                articulo.Codigo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cbo_cat.SelectedItem;
                articulo.Marca = (Marca)cbo_marca.SelectedItem;
                articulo.ImagenUrl = txt_url.Text;
                articulo.Precio = decimal.Parse(txt_precio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //carga combos desplegables
            Marcas_Categorias_Negocio marcas_cat_negocio = new Marcas_Categorias_Negocio();
            try
            {
                cbo_cat.DataSource = marcas_cat_negocio.listar_categorias();
                cbo_cat.ValueMember = "Id"; //clave
                cbo_cat.DisplayMember= "Descripcion"; //valor
                cbo_marca.DataSource = marcas_cat_negocio.listar_marcas();
                cbo_marca.ValueMember = "Id";
                cbo_marca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigoArticulo.Text = articulo.Codigo;
                    txtNombre.Text= articulo.Nombre;    
                    txtDescripcion.Text= articulo.Descripcion;
                    cargar_imagen(articulo.ImagenUrl);
                    txt_url.Text = articulo.ImagenUrl;
                    txt_precio.Text = articulo.Precio.ToString();
                    cbo_marca.SelectedValue = articulo.Marca.Id;
                    cbo_cat.SelectedValue = articulo.Categoria.Id;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_url_Leave(object sender, EventArgs e)
        {
            cargar_imagen(txt_url.Text);
        }
        private void cargar_imagen(string imagen) //cacheo la excepcion y copio el metodo en los demas
        {
            try
            {
                pictureBox2.Load(imagen);

            }
            catch (Exception ex)
            {

                pictureBox2.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png");
            }
        }
    }
}
 