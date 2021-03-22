
namespace Tarea8CrearRegistroConLogin.UI.Consultas
{
    partial class cUsuarios
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
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DatosDataGrid = new System.Windows.Forms.DataGridView();
            this.UsarFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterioTextBox.Location = new System.Drawing.Point(263, 70);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(604, 27);
            this.CriterioTextBox.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FechaHastaDateTimePicker);
            this.groupBox1.Controls.Add(this.FechaDesdeDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(263, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 58);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, -18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // FechaHastaDateTimePicker
            // 
            this.FechaHastaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHastaDateTimePicker.Location = new System.Drawing.Point(979, 20);
            this.FechaHastaDateTimePicker.Name = "FechaHastaDateTimePicker";
            this.FechaHastaDateTimePicker.Size = new System.Drawing.Size(127, 27);
            this.FechaHastaDateTimePicker.TabIndex = 1;
            // 
            // FechaDesdeDateTimePicker
            // 
            this.FechaDesdeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesdeDateTimePicker.Location = new System.Drawing.Point(63, 20);
            this.FechaDesdeDateTimePicker.Name = "FechaDesdeDateTimePicker";
            this.FechaDesdeDateTimePicker.Size = new System.Drawing.Size(526, 27);
            this.FechaDesdeDateTimePicker.TabIndex = 0;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Usuario Id",
            "Nombre Usuario",
            "Email ",
            "Rol"});
            this.FiltroComboBox.Location = new System.Drawing.Point(79, 70);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(162, 28);
            this.FiltroComboBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtro";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(30, 566);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(108, 37);
            this.ImprimirButton.TabIndex = 21;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(873, 17);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 81);
            this.BuscarButton.TabIndex = 20;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // DatosDataGrid
            // 
            this.DatosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGrid.Location = new System.Drawing.Point(30, 104);
            this.DatosDataGrid.Name = "DatosDataGrid";
            this.DatosDataGrid.RowHeadersWidth = 51;
            this.DatosDataGrid.RowTemplate.Height = 29;
            this.DatosDataGrid.Size = new System.Drawing.Size(937, 456);
            this.DatosDataGrid.TabIndex = 19;
            // 
            // UsarFechaCheckBox
            // 
            this.UsarFechaCheckBox.AutoSize = true;
            this.UsarFechaCheckBox.Location = new System.Drawing.Point(30, 32);
            this.UsarFechaCheckBox.Name = "UsarFechaCheckBox";
            this.UsarFechaCheckBox.Size = new System.Drawing.Size(167, 24);
            this.UsarFechaCheckBox.TabIndex = 18;
            this.UsarFechaCheckBox.Text = "Usar Filtro de Fechas";
            this.UsarFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 610);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DatosDataGrid);
            this.Controls.Add(this.UsarFechaCheckBox);
            this.Name = "cUsuarios";
            this.Text = "cUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaHastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaDesdeDateTimePicker;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView DatosDataGrid;
        private System.Windows.Forms.CheckBox UsarFechaCheckBox;
    }
}