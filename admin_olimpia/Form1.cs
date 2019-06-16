using System;
using System.Windows.Forms;

namespace admin_olimpia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void actualizar_data_usuarios()
        {
            backbone_service2.ws_user my_ws = new backbone_service2.ws_user();
            data_Usuarios.DataSource  = my_ws.Get_users();
        }

        void actualizar_data_cuentasXclientes()
        {
            backbone_wcf.Service1Client my_ws = new backbone_wcf.Service1Client();
            data_clientes_CuentaXCliente.DataSource = my_ws.Get_Clients();
            data_cuentas_CuentaXCliente.DataSource = my_ws.Get_Transactions();
        }

        private void btnAgregar_Crear_Click(object sender, EventArgs e)
        {
            using (backbone_service2.ws_user my_ws = new backbone_service2.ws_user())
            {
                if (my_ws.Create_User(txtlog_Crear.Text, txtPass_Crear.Text))
                    MessageBox.Show("Usuario creado con exito");
                else
                    MessageBox.Show("Se presento un error al almacenar la información, consulte el log para obtener mas información");
            }
            actualizar_data_usuarios();
        }

        private void btnActualizar_Actualizar_Click(object sender, EventArgs e)
        {
            using (backbone_service2.ws_user my_ws = new backbone_service2.ws_user())
            {
                if (!my_ws.Is_Valid(txtLog_Actualizar.Text, txtPassAnt_Actualizar.Text))
                {
                    MessageBox.Show("El password o el login son invalidos");
                }
                else
                {
                    if (my_ws.Update_User(txtLog_Actualizar.Text, txtNuevoPass_Actualizar.Text))
                        MessageBox.Show("Password actualizado con exito");
                    else
                        MessageBox.Show("Se presento un  error al almacenar la información");
                    actualizar_data_usuarios();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizar_data_usuarios();
            actualizar_data_cuentasXclientes();
        }

        private void btnEli_Eliminar_Click(object sender, EventArgs e)
        {
            using (backbone_service2.ws_user my_ws = new backbone_service2.ws_user())
            {
                if (my_ws.Delete_User(txtLog_Eliminar.Text))
                    MessageBox.Show("Usuario eliminado con exito");
                else
                    MessageBox.Show("Se presento un error al almacenar la información, consulte el log para obtener mas información");
            }
            actualizar_data_usuarios();
        }

        private void btn_asignar_CuentaXCliente_Click(object sender, EventArgs e)
        {

        }

        private void data_clientes_CuentaXCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrecliente_CuentaXCliente.Text = data_clientes_CuentaXCliente.Rows[e.RowIndex].Cells[1].ToString();
            txtcorreocliente_CuentaXCliente.Text = data_clientes_CuentaXCliente.Rows[e.RowIndex].Cells[3].ToString();
        }

        private void data_cuentas_CuentaXCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnumerocuenta_CuentaXCliente.Text = data_cuentas_CuentaXCliente.Rows[e.RowIndex].Cells[1].ToString();
            txtsaldocuenta_CuentaXCliente.Text = data_cuentas_CuentaXCliente.Rows[e.RowIndex].Cells[3].ToString();
        }
    }
}
