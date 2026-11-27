using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace bd001_Manter01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection nomeConexion;
     // MySqlConnection
     // SqlConnection
     // Sysyem.Data.OleDb.OleDbConnection nomeConexión (Si la librería no está importada)
        String stringConexion = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source= D:\\Daniel_Fernandez\\Desarrollo-de-Interfaces\\bd001_Manter01\\Negocio.mb";

        private void Form1_Load(object sender, EventArgs e)
        {
            nomeConexion = new OleDbConnection(stringConexion);
            nomeConexion.Open();
        }

        // private void btSalir_Click(object sender, EventArgs e)
        // {
        //    nomeConexion.Close();
        //    this.Close
        // }

        // private void btInsertar_Click(object sender, EventArgs e)
        // {
        //
        //    DialogResult Resposta;
        //    MessageBox.Show("Gardarase o rexistro na B.D, está vostede seguro?", "insertando rexistros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //
        //    if (Resposta == DialogResult.Yes)
        //    {
        //
        //    OleDbCommand comandoNonSelect;
        //    String cadenaSQL;
        //    cadenaSQL = string.Format(@"insert into Clientes (Apelido1, Apelido2, Nome)
        //                                values ('{0}','{1}','{2}')",
        //                                txbApellido1.Text,
        //                                txbApellido1.Text,
        //                                txbNombre.Text);
        //
        //    comandoNonSelect = new OleDbCommand(cadenaSQL, nomeConexion);
        //    comandoNonSelect.ExecuteNonQuery();
        //
        //    }
        //
        //    else
        //    {
        //       MessageBox.Show("operación cancelada");
        //    }
        //
        // }

    }
}
