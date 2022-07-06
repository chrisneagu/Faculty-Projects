using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        Portofoliu p;
        string conexiuneString;
        public Form1()
        {
            InitializeComponent();
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD.accdb";
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show(); //arata pagina de inregistrare 
        }

        private void btInainte_Click(object sender, EventArgs e)
        {

            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand interogare = new OleDbCommand();
            string camp = tbUser.Text;
            string parola = tbParola.Text;

            try
            {
                conexiune.Open();
                interogare.CommandText = "SELECT ID FROM Clienti WHERE (@camp=Nume OR @camp=Email OR @camp=Telefon) AND @parola=Parola";
                interogare.Connection = conexiune;
                interogare.Parameters.Add("@username", OleDbType.VarChar).Value = camp;
                interogare.Parameters.Add("@parola", OleDbType.VarChar).Value = parola;
                int ID = Convert.ToInt32(interogare.ExecuteScalar());

                if (ID > 0)
                {
                    interogare.CommandText = "SELECT Nume,Email,Telefon FROM Clienti WHERE ID=" + ID;
                   
                    OleDbDataReader reader = interogare.ExecuteReader();
                    reader.Read();
                    p = new Portofoliu(reader["Nume"].ToString(), reader["Email"].ToString(), reader["Telefon"].ToString());
                    reader.Close();
                    this.Hide();
                    Cont cont = new Cont(p);
                    cont.Closed += (s, args) => this.Close();
                    cont.Show();
                }
                else
                {
                    MessageBox.Show("Date Invalide!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }

           
        }
    }
}

