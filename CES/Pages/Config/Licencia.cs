using CES.DB.Metodos.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES.Pages.Config
{
    public partial class Licencia : MetroFramework.Forms.MetroForm
    {
        public Licencia()
        {
            InitializeComponent();
            OnLoad();
        }

        protected void OnLoad()
        {
            try
            {
                var dt = new dtoPropiedades
                {
                    operacion = "SelectByProp",
                    propiedad = "estatus"
                }.CRUD().dtResult;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["valor"] != DBNull.Value)
                    {
                        if (row["valor"].ToString() == "1")
                        {
                            lblEstatus.Text = "Activado";
                            lblEstatus.ForeColor = Color.Green;
                        }
                        else
                        {
                            lblEstatus.Text = "Versione demo disponible hasta: ";
                            lblEstatus.ForeColor = Color.Firebrick;

                            var dtVencimiento = new dtoPropiedades
                            {
                                operacion = "SelectByProp",
                                propiedad = "vencimiento"
                            }.CRUD().dtResult;

                            foreach (DataRow _row in dtVencimiento.Rows)
                            {
                                if (_row["valor"] != DBNull.Value)
                                {
                                    lblEstatus.Text = lblEstatus.Text + _row["valor"].ToString();
                                }
                            }
                        }
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    lblEstatus.Text = "Versione demo disponible hasta: ";
                    lblEstatus.ForeColor = Color.Firebrick;

                    var dtVencimiento = new dtoPropiedades
                    {
                        operacion = "SelectByProp",
                        propiedad = "vencimiento"
                    }.CRUD().dtResult;

                    foreach (DataRow _row in dt.Rows)
                    {
                        if (_row["valor"] != DBNull.Value)
                        {
                            lblEstatus.Text = lblEstatus.Text + _row["valor"].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKey.Text == "7cd18927-8725-4ee1-8a7a-5ae5457ee3b1")
                {
                    var dt = new dtoPropiedades
                    {
                        operacion = "Update",
                        propiedad = "estatus",
                        valor = "1",
                    }.CRUD().dtResult;



                    var result = new dtoPropiedades
                    {
                        operacion = "Insert",
                        propiedad = "FechaActivacion",
                        valor = DateTime.Now.ToString(),
                    }.CRUD().dtResult;

                    if (MessageBox.Show("Licencia aplicada correctamente", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                        Environment.Exit(1);
                    else
                        Environment.Exit(1);
                }
                MessageBox.Show("No. de Licencia incorrecto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
