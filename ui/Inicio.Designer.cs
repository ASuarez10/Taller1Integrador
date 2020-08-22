namespace Taller1Integrador
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonAbrir = new System.Windows.Forms.Button();
            this.botonGrafico = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // botonAbrir
            // 
            this.botonAbrir.Location = new System.Drawing.Point(60, 32);
            this.botonAbrir.Name = "botonAbrir";
            this.botonAbrir.Size = new System.Drawing.Size(82, 23);
            this.botonAbrir.TabIndex = 1;
            this.botonAbrir.Text = "Elegir archivo";
            this.botonAbrir.UseVisualStyleBackColor = true;
            this.botonAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonGrafico
            // 
            this.botonGrafico.Location = new System.Drawing.Point(713, 415);
            this.botonGrafico.Name = "botonGrafico";
            this.botonGrafico.Size = new System.Drawing.Size(75, 23);
            this.botonGrafico.TabIndex = 2;
            this.botonGrafico.Text = "Ver gráfico";
            this.botonGrafico.UseVisualStyleBackColor = true;
            this.botonGrafico.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Location = new System.Drawing.Point(60, 417);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cbbDepartamento.TabIndex = 3;
            this.cbbDepartamento.Text = "Departamento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(151, 37);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 13);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Ruta";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cbbDepartamento);
            this.Controls.Add(this.botonGrafico);
            this.Controls.Add(this.botonAbrir);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Colombia";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonAbrir;
        private System.Windows.Forms.Button botonGrafico;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
    }
}

