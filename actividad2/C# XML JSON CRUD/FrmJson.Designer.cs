namespace C__XML_JSON_CRUD
{
    partial class FrmJson
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
            this.ListBoxRecords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LblTitulo.Location = new System.Drawing.Point(155, 20);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(338, 25);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "CRUD para manejo de archivos JSON";
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
            this.TxtInput.Size = new System.Drawing.Size(550, 25);
            this.TxtInput.TabIndex = 5;
            // 
            // ListBoxRecords
            // 
            this.ListBoxRecords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ListBoxRecords.FormattingEnabled = true;
            this.ListBoxRecords.ItemHeight = 17;
            this.ListBoxRecords.Location = new System.Drawing.Point(50, 200);
            this.ListBoxRecords.Name = "ListBoxRecords";
            this.ListBoxRecords.Size = new System.Drawing.Size(550, 157);
            this.ListBoxRecords.TabIndex = 6;
            // 
            // FrmJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.ListBoxRecords);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmJson";
            this.Text = "CRUD JSON";
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
        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.ListBox ListBoxRecords;

    }
}