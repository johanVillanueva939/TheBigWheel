namespace theBigWheel
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAtras;
        private Button btnStock;
        private Button btnEmpleado;
        private Button btnFacturas;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAtras = new Button();
            btnStock = new Button();
            btnEmpleado = new Button();
            btnFacturas = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(0, 151, 178);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(18, 15);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(105, 38);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "ATRÁS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += BtnAtras_Click;
            // 
            // btnStock
            // 
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnStock.ForeColor = Color.FromArgb(0, 151, 178);
            btnStock.Location = new Point(475, 486);
            btnStock.Margin = new Padding(3, 2, 3, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(300, 115);
            btnStock.TabIndex = 2;
            btnStock.Text = "STOCK";
            btnStock.Click += btnStock_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnEmpleado.ForeColor = Color.FromArgb(0, 151, 178);
            btnEmpleado.Location = new Point(811, 486);
            btnEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(300, 115);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "EMPLEADO";
            // 
            // btnFacturas
            // 
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnFacturas.ForeColor = Color.FromArgb(0, 151, 178);
            btnFacturas.Location = new Point(1142, 486);
            btnFacturas.Margin = new Padding(3, 2, 3, 2);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(300, 115);
            btnFacturas.TabIndex = 4;
            btnFacturas.Text = "FACTURAS";
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(-36, 262);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1485, 136);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Configuración";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 824);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(btnStock);
            Controls.Add(btnEmpleado);
            Controls.Add(btnFacturas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Configuración";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }
    }
}