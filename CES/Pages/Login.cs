using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.ActiveControl = txtUsuario;
            txtUsuario.Focus();
            txtPsw.Text = "jsancvil!1";
            txtUsuario.Text = "jsancvil";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtPsw.Text != "" && txtUsuario.Text != "")
            {
                var result = new DB.Metodos.config.dtoUsuarios
                {
                    operacion = "login",
                    usuario = txtUsuario.Text.Trim(),
                    psw = txtPsw.Text.Trim(),
                    activo = true
                }.CRUD();

                

                if (!bool.Parse(result.hasError.ToString()))
                {
                    if (result.dtResult.Rows.Count == 1)
                    {
                        foreach (DataRow row in result.dtResult.Rows)
                        {
                            LoginInfo.idUsuario = (int)row["idUsuario"];
                            LoginInfo.usuario = row["usuario"].ToString();
                            LoginInfo.correo = row["correo"].ToString();
                            LoginInfo.nombre = row["nombre"].ToString();
                            LoginInfo.psw = row["psw"].ToString();
                            LoginInfo.celular = row["celular"].ToString();
                            LoginInfo.telefono = row["telefono"].ToString();
                            LoginInfo.idRol = (int)row["idRol"];                            
                        }

                        Menu frm = new Menu();
                        frm.Closed += (s, args) => this.Close();
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();

                        this.Hide();
                    }
                    else
                        MessageBox.Show("Usuario y/o contraseña son incorrectas");
                }
                else
                    MessageBox.Show(result.messageError);

            }
            else
            {
                MessageBox.Show("Capture Usuario y contraseña");
            }
        }


    }
}
