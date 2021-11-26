using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.Class;

namespace PPE3
{
    public partial class FormMenu : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            List<Conteneur> lesConteneurs = Conteneur.FetchAll();
            listBoxConteneurs.DataSource = lesConteneurs;
        }

        #region FormMenu
        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMenu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        #endregion

        #region labelClose
        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Red;
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.BackColor = Color.Transparent;
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelClose_MouseDown(object sender, MouseEventArgs e)
        {
            labelClose.BackColor = Color.DarkRed;
        }

        private void labelClose_MouseUp(object sender, MouseEventArgs e)
        {
            labelClose.BackColor = Color.Red;
        }
        #endregion

        #region labelMinimize

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.FromArgb(75, Color.Gray);
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.BackColor = Color.Transparent;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        #endregion


        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                Conteneur c = Conteneur.getConteneurbyNum(1);
                string numContainer, dateAchat, typeContainer, dateDernierInsp, codeDeclaration, numInspection;
                numContainer = c.NumContainer;
                dateAchat = Convert.ToString(c.DateAchat);
                typeContainer = c.TypeContainer;
                dateDernierInsp = Convert.ToString(c.DateDernierInsp);
                codeDeclaration = Convert.ToString(c.CodeDeclaration);
                numInspection = Convert.ToString(c.NumInspection);
                MessageBox.Show("NumContainer : " + numContainer +
                    "\nDateAchat : " + dateAchat + "\nTypeContainer : " +
                    typeContainer + "\nDateDernièreInsp :" + dateDernierInsp +
                    "\nCodeDeclaration :" + codeDeclaration + "\nNumInspection :" + numInspection);
            }
            catch (Exception ec)
            {
                MessageBox.Show("oups");
            }
        }
    }
}
