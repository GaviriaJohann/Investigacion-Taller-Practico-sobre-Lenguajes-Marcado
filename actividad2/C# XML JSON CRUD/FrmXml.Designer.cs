namespace C__XML_JSON_CRUD
{
    partial class FrmXml
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtRol = new System.Windows.Forms.TextBox();
            this.TxtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.ListBoxRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LblTitulo.Location = new System.Drawing.Point(160, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(330, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "CRUD para manejo de archivos XML";
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnCreate.ForeColor = System.Drawing.Color.White;
            this.BtnCreate.Location = new System.Drawing.Point(50, 75);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(100, 40);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Crear";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnRead.FlatAppearance.BorderSize = 0;
            this.BtnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRead.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnRead.ForeColor = System.Drawing.Color.White;
            this.BtnRead.Location = new System.Drawing.Point(200, 75);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(100, 40);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "Leer";
            this.BtnRead.UseVisualStyleBackColor = false;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(350, 75);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 40);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Actualizar";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(500, 75);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 40);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtInput.Location = new System.Drawing.Point(50, 150);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(154, 25);
            this.TxtInput.TabIndex = 5;
            this.TxtInput.Text = "Nombre";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDocumento.Location = new System.Drawing.Point(246, 150);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(154, 25);
            this.TxtDocumento.TabIndex = 6;
            this.TxtDocumento.Text = "Documento";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDireccion.Location = new System.Drawing.Point(446, 150);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(154, 25);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.Text = "Direccion";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtTelefono.Location = new System.Drawing.Point(50, 211);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(154, 25);
            this.TxtTelefono.TabIndex = 8;
            this.TxtTelefono.Text = "Telefono";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtEmail.Location = new System.Drawing.Point(246, 211);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(154, 25);
            this.TxtEmail.TabIndex = 9;
            this.TxtEmail.Text = "Email";
            // 
            // TxtRol
            // 
            this.TxtRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtRol.Location = new System.Drawing.Point(446, 211);
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.Size = new System.Drawing.Size(154, 25);
            this.TxtRol.TabIndex = 10;
            this.TxtRol.Text = "Rol";
            // 
            // TxtDatosAdicionales
            // 
            this.TxtDatosAdicionales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDatosAdicionales.Location = new System.Drawing.Point(50, 268);
            this.TxtDatosAdicionales.Multiline = true;
            this.TxtDatosAdicionales.Name = "TxtDatosAdicionales";
            this.TxtDatosAdicionales.Size = new System.Drawing.Size(550, 60);
            this.TxtDatosAdicionales.TabIndex = 11;
            this.TxtDatosAdicionales.Text = "Datos Adicionales";
            // 
            // ListBoxRecords
            // 
            this.ListBoxRecords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListBoxRecords.FormattingEnabled = true;
            this.ListBoxRecords.ItemHeight = 17;
            this.ListBoxRecords.Location = new System.Drawing.Point(50, 363);
            this.ListBoxRecords.Name = "ListBoxRecords";
            this.ListBoxRecords.Size = new System.Drawing.Size(550, 157);
            this.ListBoxRecords.TabIndex = 12;
            // 
            // FrmXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 553);
            this.Controls.Add(this.ListBoxRecords);
            this.Controls.Add(this.TxtDatosAdicionales);
            this.Controls.Add(this.TxtRol);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmXml";
            this.Text = "CRUD XML";
            this.Load += new System.EventHandler(this.FrmXml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        # endregion

        // Declaración de los controles
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtInput; // Nombre
        private System.Windows.Forms.TextBox TxtDocumento; // Documento
        private System.Windows.Forms.TextBox TxtDireccion; // Dirección
        private System.Windows.Forms.TextBox TxtTelefono; // Teléfono
        private System.Windows.Forms.TextBox TxtEmail; // Email
        private System.Windows.Forms.TextBox TxtRol; // Rol
        private System.Windows.Forms.TextBox TxtDatosAdicionales; // Datos Adicionales
        private System.Windows.Forms.ListBox ListBoxRecords;

    }
}