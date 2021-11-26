using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using PPE3.Class;

namespace PPE3
{    
    public partial class FormConnexion : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        MySqlConnection connection = Utilitaires.GetDBConnection();
        private bool buttonDockerChecked = false;
        private bool buttonChefChecked = false;

        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormConnexion_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormConnexion_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "jber")
            {
                if (textBoxMotDePasse.Text == "azerty")
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("gg");
                    } catch(Exception ec)
                    {
                        MessageBox.Show("oudesh");
                        Console.WriteLine(ec);
                    }
                    if (buttonChefChecked) {
                        MessageBox.Show("Vous êtes un chef"); 
                        Form f = new FormMenu();
                        f.Show();
                        this.Hide();
                    }
                    else if (buttonDockerChecked) {
                        MessageBox.Show("Vous êtes un docker");
                        Form f = new FormMenu();
                        f.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Veuillez cochez UNE CASE");
                    }
                }
                else
                {
                    labelError.Visible = true;
                }
            }
        }

        private void pictureBoxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonChef_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonChefChecked)
            {
                buttonChefChecked = false;
            }
            else
            {
                buttonChefChecked = true;
            }
        }

        private void radioButtonDocker_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonDockerChecked)
            {
                buttonDockerChecked = false;
            }
            else
            {
                buttonDockerChecked = true;
            }
        }

        private void checkBoxMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxMotDePasse.UseSystemPasswordChar)
            {
                textBoxMotDePasse.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxMotDePasse.UseSystemPasswordChar = true;
            }
        }
        
    }
}
