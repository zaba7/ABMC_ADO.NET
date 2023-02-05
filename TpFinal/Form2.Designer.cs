namespace TpFinal
{
    partial class Form2
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
            this.btnCancelar01 = new System.Windows.Forms.Button();
            this.btnAceptar01 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.llbCodigo = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.llb_img = new System.Windows.Forms.Label();
            this.label_cat = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.cbo_marca = new System.Windows.Forms.ComboBox();
            this.cbo_cat = new System.Windows.Forms.ComboBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar01
            // 
            this.btnCancelar01.Location = new System.Drawing.Point(275, 286);
            this.btnCancelar01.Name = "btnCancelar01";
            this.btnCancelar01.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar01.TabIndex = 8;
            this.btnCancelar01.Text = "Cancelar";
            this.btnCancelar01.UseVisualStyleBackColor = true;
            this.btnCancelar01.Click += new System.EventHandler(this.btnCancelar01_Click);
            // 
            // btnAceptar01
            // 
            this.btnAceptar01.Location = new System.Drawing.Point(157, 286);
            this.btnAceptar01.Name = "btnAceptar01";
            this.btnAceptar01.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar01.TabIndex = 7;
            this.btnAceptar01.Text = "Aceptar";
            this.btnAceptar01.UseVisualStyleBackColor = true;
            this.btnAceptar01.Click += new System.EventHandler(this.btnAceptar01_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 114);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(38, 114);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 21;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(38, 84);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(50, 13);
            this.label_nombre.TabIndex = 19;
            this.label_nombre.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Location = new System.Drawing.Point(122, 49);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoArticulo.TabIndex = 0;
            // 
            // llbCodigo
            // 
            this.llbCodigo.AutoSize = true;
            this.llbCodigo.Location = new System.Drawing.Point(38, 52);
            this.llbCodigo.Name = "llbCodigo";
            this.llbCodigo.Size = new System.Drawing.Size(81, 13);
            this.llbCodigo.TabIndex = 39;
            this.llbCodigo.Text = "Codigo Articulo:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(38, 242);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 13);
            this.lbl_precio.TabIndex = 40;
            this.lbl_precio.Text = "Precio:";
            // 
            // llb_img
            // 
            this.llb_img.AutoSize = true;
            this.llb_img.Location = new System.Drawing.Point(38, 210);
            this.llb_img.Name = "llb_img";
            this.llb_img.Size = new System.Drawing.Size(61, 13);
            this.llb_img.TabIndex = 41;
            this.llb_img.Text = "Url Imagen:";
            // 
            // label_cat
            // 
            this.label_cat.AutoSize = true;
            this.label_cat.Location = new System.Drawing.Point(38, 179);
            this.label_cat.Name = "label_cat";
            this.label_cat.Size = new System.Drawing.Size(55, 13);
            this.label_cat.TabIndex = 42;
            this.label_cat.Text = "Categoria:";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(38, 146);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(40, 13);
            this.lblmarca.TabIndex = 43;
            this.lblmarca.Text = "Marca:";
            // 
            // cbo_marca
            // 
            this.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_marca.FormattingEnabled = true;
            this.cbo_marca.Location = new System.Drawing.Point(122, 146);
            this.cbo_marca.Name = "cbo_marca";
            this.cbo_marca.Size = new System.Drawing.Size(121, 21);
            this.cbo_marca.TabIndex = 3;
            // 
            // cbo_cat
            // 
            this.cbo_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cat.FormattingEnabled = true;
            this.cbo_cat.Location = new System.Drawing.Point(122, 179);
            this.cbo_cat.Name = "cbo_cat";
            this.cbo_cat.Size = new System.Drawing.Size(121, 21);
            this.cbo_cat.TabIndex = 4;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(122, 206);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(121, 20);
            this.txt_url.TabIndex = 5;
            this.txt_url.Leave += new System.EventHandler(this.txt_url_Leave);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(122, 239);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(121, 20);
            this.txt_precio.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(273, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.cbo_cat);
            this.Controls.Add(this.cbo_marca);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.label_cat);
            this.Controls.Add(this.llb_img);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.llbCodigo);
            this.Controls.Add(this.btnCancelar01);
            this.Controls.Add(this.btnAceptar01);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar01;
        private System.Windows.Forms.Button btnAceptar01;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label llbCodigo;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label llb_img;
        private System.Windows.Forms.Label label_cat;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.ComboBox cbo_marca;
        private System.Windows.Forms.ComboBox cbo_cat;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}