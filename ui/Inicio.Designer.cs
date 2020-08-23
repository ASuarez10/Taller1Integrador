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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonAbrir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbbDepartamento = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.region,
            this.codDep,
            this.departamento,
            this.codMun,
            this.municipio});
            this.dtgv.Location = new System.Drawing.Point(12, 53);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(543, 335);
            this.dtgv.TabIndex = 0;
            // 
            // region
            // 
            this.region.HeaderText = "Región";
            this.region.Name = "region";
            // 
            // codDep
            // 
            this.codDep.HeaderText = "Código DANE del departamento";
            this.codDep.Name = "codDep";
            // 
            // departamento
            // 
            this.departamento.HeaderText = "Departamento";
            this.departamento.Name = "departamento";
            // 
            // codMun
            // 
            this.codMun.HeaderText = "Código DANE del municipio";
            this.codMun.Name = "codMun";
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Municipio";
            this.municipio.Name = "municipio";
            // 
            // botonAbrir
            // 
            this.botonAbrir.Location = new System.Drawing.Point(12, 24);
            this.botonAbrir.Name = "botonAbrir";
            this.botonAbrir.Size = new System.Drawing.Size(82, 23);
            this.botonAbrir.TabIndex = 1;
            this.botonAbrir.Text = "Elegir archivo";
            this.botonAbrir.UseVisualStyleBackColor = true;
            this.botonAbrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbDepartamento
            // 
            this.cbbDepartamento.FormattingEnabled = true;
            this.cbbDepartamento.Items.AddRange(new object[] {
            "\"Archipielago de San Andrés, Providencia y Santa Catalina\"",
            "Amazonas",
            "Antioquia",
            "Arauca",
            "Atlántico",
            "Bogotá D.C.",
            "Bolívar",
            "Boyacá",
            "Caldas",
            "Caquetá",
            "Casanare",
            "Cauca",
            "Cesar",
            "Chocó",
            "Córdoba",
            "Cundinamarca",
            "Guainía",
            "Guaviare",
            "Huila",
            "La Guajira",
            "Magdalena",
            "Meta",
            "Nariño",
            "Norte de Santander",
            "Putumayo",
            "Quindío",
            "Risaralda",
            "Santander",
            "Sucre",
            "Tolima",
            "Valle del Cauca",
            "Vaupés",
            "Vichada"});
            this.cbbDepartamento.Location = new System.Drawing.Point(12, 406);
            this.cbbDepartamento.Name = "cbbDepartamento";
            this.cbbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cbbDepartamento.Sorted = true;
            this.cbbDepartamento.TabIndex = 3;
            this.cbbDepartamento.Text = "Departamento";
            this.cbbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbbDepartamento_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(110, 29);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(30, 13);
            this.lblRuta.TabIndex = 4;
            this.lblRuta.Text = "Ruta";
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(571, 53);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series2";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(312, 335);
            this.grafica.TabIndex = 5;
            this.grafica.Text = "chart1";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.cbbDepartamento);
            this.Controls.Add(this.botonAbrir);
            this.Controls.Add(this.dtgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de Colombia";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button botonAbrir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbbDepartamento;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMun;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
    }
}

