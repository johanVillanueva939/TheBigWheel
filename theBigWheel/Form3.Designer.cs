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
            btnAtras.Location = new Point(20, 20);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(120, 50);
            btnAtras.TabIndex = 0;
            btnAtras.Text = "ATRÁS";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += BtnAtras_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Stock";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMostrar
            // 
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMostrar.ForeColor = Color.FromArgb(0, 151, 178);
            btnMostrar.Location = new Point(150, 250);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(150, 75);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "MOSTRAR";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.FromArgb(0, 151, 178);
            btnAgregar.Location = new Point(325, 250);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 75);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.FromArgb(0, 151, 178);
            btnActualizar.Location = new Point(500, 250);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 75);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Name = "Form3";
            Text = "Stock";
            ResumeLayout(false);
        }

        
    }
}