namespace ecommercetp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosMI_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
>>>>>>> ec7010f (Modulo tiendas funcionando y conectado al menu)
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is UsuariosForm)
                {
                    hijo.Activate();
                    return;
                }
            }

            UsuariosForm form = new UsuariosForm();
            form.MdiParent = this;
            form.Show();
<<<<<<< HEAD

        }
    }
}
=======
        }

        private void tiendasMI_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren)
            {
                if (hijo is FormTiendas)
                {
                    hijo.Activate();
                    return;
                }
            }

            FormTiendas form = new FormTiendas();
            form.MdiParent = this;
            form.Show();
        }
    } // <--- Esta llave cierra la Clase
} // <--- Esta llave cierra el Namespace
>>>>>>> ec7010f (Modulo tiendas funcionando y conectado al menu)
