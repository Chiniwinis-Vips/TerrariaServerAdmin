namespace TerrariaServerAdmin
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscarmapa = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.tb_admin = new System.Windows.Forms.TabControl();
            this.admin1 = new System.Windows.Forms.TabPage();
            this.tb_config = new System.Windows.Forms.TabPage();
            this.btn_start = new System.Windows.Forms.Button();
            this.ck_ignoreversion = new System.Windows.Forms.CheckBox();
            this.tb_admin.SuspendLayout();
            this.admin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idioma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mapa:";
            // 
            // txt_buscarmapa
            // 
            this.txt_buscarmapa.Location = new System.Drawing.Point(23, 31);
            this.txt_buscarmapa.Name = "txt_buscarmapa";
            this.txt_buscarmapa.ReadOnly = true;
            this.txt_buscarmapa.Size = new System.Drawing.Size(441, 20);
            this.txt_buscarmapa.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1:Inglés",
            "2:Alemán",
            "3:Italiano",
            "4:Francés",
            "5:Español"});
            this.comboBox1.Location = new System.Drawing.Point(23, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Buscar
            // 
            this.Buscar.Image = global::TerrariaServerAdmin.Properties.Resources.Airodump_Scan_Visualizer_copia;
            this.Buscar.Location = new System.Drawing.Point(470, 28);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(24, 24);
            this.Buscar.TabIndex = 3;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // tb_admin
            // 
            this.tb_admin.Controls.Add(this.admin1);
            this.tb_admin.Controls.Add(this.tb_config);
            this.tb_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_admin.Location = new System.Drawing.Point(0, 0);
            this.tb_admin.Name = "tb_admin";
            this.tb_admin.SelectedIndex = 0;
            this.tb_admin.Size = new System.Drawing.Size(516, 252);
            this.tb_admin.TabIndex = 5;
            // 
            // admin1
            // 
            this.admin1.Controls.Add(this.ck_ignoreversion);
            this.admin1.Controls.Add(this.btn_start);
            this.admin1.Controls.Add(this.txt_buscarmapa);
            this.admin1.Controls.Add(this.comboBox1);
            this.admin1.Controls.Add(this.label1);
            this.admin1.Controls.Add(this.Buscar);
            this.admin1.Controls.Add(this.label2);
            this.admin1.Location = new System.Drawing.Point(4, 22);
            this.admin1.Name = "admin1";
            this.admin1.Padding = new System.Windows.Forms.Padding(3);
            this.admin1.Size = new System.Drawing.Size(508, 226);
            this.admin1.TabIndex = 0;
            this.admin1.Text = "Admin";
            this.admin1.UseVisualStyleBackColor = true;
            // 
            // tb_config
            // 
            this.tb_config.Location = new System.Drawing.Point(4, 22);
            this.tb_config.Name = "tb_config";
            this.tb_config.Padding = new System.Windows.Forms.Padding(3);
            this.tb_config.Size = new System.Drawing.Size(508, 226);
            this.tb_config.TabIndex = 1;
            this.tb_config.Text = "Config";
            this.tb_config.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(430, 200);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "iniciar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // ck_ignoreversion
            // 
            this.ck_ignoreversion.AutoSize = true;
            this.ck_ignoreversion.Location = new System.Drawing.Point(23, 97);
            this.ck_ignoreversion.Name = "ck_ignoreversion";
            this.ck_ignoreversion.Size = new System.Drawing.Size(141, 17);
            this.ck_ignoreversion.TabIndex = 6;
            this.ck_ignoreversion.Text = "ignorar version de plugin";
            this.ck_ignoreversion.UseVisualStyleBackColor = true;
            this.ck_ignoreversion.CheckedChanged += new System.EventHandler(this.ck_ignoreversion_CheckedChanged);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 252);
            this.Controls.Add(this.tb_admin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerrariaServerAmin";
            this.tb_admin.ResumeLayout(false);
            this.admin1.ResumeLayout(false);
            this.admin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscarmapa;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tb_admin;
        private System.Windows.Forms.TabPage admin1;
        private System.Windows.Forms.TabPage tb_config;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox ck_ignoreversion;
    }
}

