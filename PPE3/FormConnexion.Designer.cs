
namespace PPE3
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.checkBoxMdp = new System.Windows.Forms.CheckBox();
            this.radioButtonChef = new System.Windows.Forms.RadioButton();
            this.radioButtonDocker = new System.Windows.Forms.RadioButton();
            this.labelChef = new System.Windows.Forms.Label();
            this.labelDocker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(139, 301);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(148, 20);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelConnexion.Location = new System.Drawing.Point(102, 234);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(225, 22);
            this.labelConnexion.TabIndex = 2;
            this.labelConnexion.Text = "Connexion à votre compte";
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.Location = new System.Drawing.Point(139, 358);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(148, 20);
            this.textBoxMotDePasse.TabIndex = 3;
            this.textBoxMotDePasse.UseSystemPasswordChar = true;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(189, 275);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(48, 19);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMdp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMdp.Location = new System.Drawing.Point(166, 333);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(102, 19);
            this.labelMdp.TabIndex = 5;
            this.labelMdp.Text = "Mot de passe";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.BackColor = System.Drawing.Color.Azure;
            this.buttonConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnexion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConnexion.Location = new System.Drawing.Point(160, 475);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(117, 29);
            this.buttonConnexion.TabIndex = 6;
            this.buttonConnexion.Text = "CONNEXION";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(79, 405);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(285, 20);
            this.labelError.TabIndex = 8;
            this.labelError.Text = "Votre login ou mot de passe est incorrect";
            this.labelError.Visible = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::PPE3.Properties.Resources.franchi;
            this.pictureBoxClose.Location = new System.Drawing.Point(420, -2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PPE3.Properties.Resources.logo_tholdi___Copie;
            this.pictureBoxLogo.Location = new System.Drawing.Point(115, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(203, 219);
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseDown);
            this.pictureBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseMove);
            this.pictureBoxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogo_MouseUp);
            // 
            // checkBoxMdp
            // 
            this.checkBoxMdp.AutoSize = true;
            this.checkBoxMdp.Location = new System.Drawing.Point(139, 385);
            this.checkBoxMdp.Name = "checkBoxMdp";
            this.checkBoxMdp.Size = new System.Drawing.Size(128, 17);
            this.checkBoxMdp.TabIndex = 10;
            this.checkBoxMdp.Text = "Afficher mot de passe";
            this.checkBoxMdp.UseVisualStyleBackColor = true;
            this.checkBoxMdp.CheckedChanged += new System.EventHandler(this.checkBoxMdp_CheckedChanged);
            // 
            // radioButtonChef
            // 
            this.radioButtonChef.AutoSize = true;
            this.radioButtonChef.Location = new System.Drawing.Point(177, 428);
            this.radioButtonChef.Name = "radioButtonChef";
            this.radioButtonChef.Size = new System.Drawing.Size(14, 13);
            this.radioButtonChef.TabIndex = 11;
            this.radioButtonChef.TabStop = true;
            this.radioButtonChef.UseVisualStyleBackColor = true;
            this.radioButtonChef.CheckedChanged += new System.EventHandler(this.radioButtonChef_CheckedChanged);
            // 
            // radioButtonDocker
            // 
            this.radioButtonDocker.AutoSize = true;
            this.radioButtonDocker.Location = new System.Drawing.Point(240, 428);
            this.radioButtonDocker.Name = "radioButtonDocker";
            this.radioButtonDocker.Size = new System.Drawing.Size(14, 13);
            this.radioButtonDocker.TabIndex = 12;
            this.radioButtonDocker.TabStop = true;
            this.radioButtonDocker.UseVisualStyleBackColor = true;
            this.radioButtonDocker.CheckedChanged += new System.EventHandler(this.radioButtonDocker_CheckedChanged);
            // 
            // labelChef
            // 
            this.labelChef.AutoSize = true;
            this.labelChef.Location = new System.Drawing.Point(170, 444);
            this.labelChef.Name = "labelChef";
            this.labelChef.Size = new System.Drawing.Size(29, 13);
            this.labelChef.TabIndex = 14;
            this.labelChef.Text = "Chef";
            // 
            // labelDocker
            // 
            this.labelDocker.AutoSize = true;
            this.labelDocker.Location = new System.Drawing.Point(226, 444);
            this.labelDocker.Name = "labelDocker";
            this.labelDocker.Size = new System.Drawing.Size(42, 13);
            this.labelDocker.TabIndex = 15;
            this.labelDocker.Text = "Docker";
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(444, 516);
            this.Controls.Add(this.labelDocker);
            this.Controls.Add(this.labelChef);
            this.Controls.Add(this.radioButtonDocker);
            this.Controls.Add(this.radioButtonChef);
            this.Controls.Add(this.checkBoxMdp);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.labelConnexion);
            this.Controls.Add(this.textBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConnexion";
            this.Text = "Interface de Connexion";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormConnexion_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormConnexion_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormConnexion_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.CheckBox checkBoxMdp;
        private System.Windows.Forms.RadioButton radioButtonChef;
        private System.Windows.Forms.RadioButton radioButtonDocker;
        private System.Windows.Forms.Label labelChef;
        private System.Windows.Forms.Label labelDocker;
    }
}

