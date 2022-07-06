using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Register : Form
    {
        private Regex validateEmailRegex = new Regex("^[A-Za-z0-9+_.-]+@(.+)$");

        private Regex validateTelefonRegex = new Regex("^[0-9-+s]+$");

        string conexiuneString;
        public Register()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD.accdb";
        }

        private void btInregistrare_Click(object sender, EventArgs e)
        {


            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand interogare = new OleDbCommand();

          

            try
            {   


                string nume = tbNume.Text;
                string email = tbEmail.Text;
                string telefon = tbTelefon.Text;
                string parola1 = tbParola1.Text;
                string parola2 = tbParola2.Text;

                errorProvider1.Clear();
                if (nume.Length < 3 || nume.Length > 20)
                    errorProvider1.SetError(tbNume, "Nume invalid!");
                else if (!validateEmailRegex.IsMatch(email))
                    errorProvider1.SetError(tbEmail, "Email invalid!");
                else if (!validateTelefonRegex.IsMatch(telefon))
                    errorProvider1.SetError(tbTelefon, "Telefon invalid!");
                else if (!String.Equals(parola1, parola2))
                    errorProvider1.SetError(tbParola2, "Parolele nu se potrivesc!");

                try
                {
                    conexiune.Open();
                    interogare.CommandText = "SELECT MAX(ID) FROM Clienti";
                    interogare.Connection = conexiune;
                    int id = Convert.ToInt32(interogare.ExecuteScalar());
                    interogare.CommandText = "INSERT INTO Clienti VALUES (?,?,?,?,?)";
                    interogare.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                    interogare.Parameters.Add("Nume", OleDbType.Char, 30).Value = nume;
                    interogare.Parameters.Add("Email", OleDbType.Char, 30).Value = email;
                    interogare.Parameters.Add("Telefon", OleDbType.Char, 30).Value = telefon;
                    interogare.Parameters.Add("Parola", OleDbType.Char, 30).Value = parola1;
                    interogare.ExecuteNonQuery();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
