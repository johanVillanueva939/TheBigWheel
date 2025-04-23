namespace theBigWheel
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAtras;
        private Button btnMostrar;
        private Button btnAgregar;
        private Button btnActualizar;
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
            btnMostrar = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
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
            // btnMostrar
            // 
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMostrar.ForeColor = Color.FromArgb(0, 151, 178);
            btnMostrar.Location = new Point(453, 444);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(300, 115);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.FromArgb(0, 151, 178);
            btnAgregar.Location = new Point(809, 444);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(300, 115);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.FromArgb(0, 151, 178);
            btnActualizar.Location = new Point(1167, 444);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(300, 115);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(-12, 276);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1480, 82);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 824);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Stock";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }
    }
}