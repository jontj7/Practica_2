namespace ESFE.SysDesarrollo.UI
{
    partial class FrmMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtRDM = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnObtener = new System.Windows.Forms.Button();
            this.BtnOPN = new System.Windows.Forms.Button();
            this.BtnAct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registro de Marca";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(243, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(134, 20);
            this.TxtID.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(243, 94);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(134, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(243, 147);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(134, 20);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // TxtRDM
            // 
            this.TxtRDM.Location = new System.Drawing.Point(243, 212);
            this.TxtRDM.Name = "TxtRDM";
            this.TxtRDM.Size = new System.Drawing.Size(134, 20);
            this.TxtRDM.TabIndex = 7;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(16, 323);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Insertar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnObtener
            // 
            this.BtnObtener.Location = new System.Drawing.Point(112, 323);
            this.BtnObtener.Name = "BtnObtener";
            this.BtnObtener.Size = new System.Drawing.Size(144, 23);
            this.BtnObtener.TabIndex = 9;
            this.BtnObtener.Text = "Obtener Todos";
            this.BtnObtener.UseVisualStyleBackColor = true;
            this.BtnObtener.Click += new System.EventHandler(this.BtnObtener_Click);
            // 
            // BtnOPN
            // 
            this.BtnOPN.Location = new System.Drawing.Point(283, 323);
            this.BtnOPN.Name = "BtnOPN";
            this.BtnOPN.Size = new System.Drawing.Size(170, 23);
            this.BtnOPN.TabIndex = 10;
            this.BtnOPN.Text = "Buscar Por Nombre";
            this.BtnOPN.UseVisualStyleBackColor = true;
            this.BtnOPN.Click += new System.EventHandler(this.BtnOPN_Click);
            // 
            // BtnAct
            // 
            this.BtnAct.Location = new System.Drawing.Point(474, 323);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(102, 23);
            this.BtnAct.TabIndex = 11;
            this.BtnAct.Text = "Actualizar";
            this.BtnAct.UseVisualStyleBackColor = true;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(599, 323);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(111, 23);
            this.BtnBorrar.TabIndex = 13;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ESFE.SysDesarrollo.UI.Properties.Resources.ESFE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(426, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 259);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(723, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAct);
            this.Controls.Add(this.BtnOPN);
            this.Controls.Add(this.BtnObtener);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtRDM);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtRDM;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnObtener;
        private System.Windows.Forms.Button BtnOPN;
        private System.Windows.Forms.Button BtnAct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}