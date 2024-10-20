namespace C__XML_JSON_CRUD
{
    partial class FrmInicio
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
            this.BtnXML = new System.Windows.Forms.Button();
            this.BtnJson = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnXML
            // 
            this.BtnXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnXML.FlatAppearance.BorderSize = 0;
            this.BtnXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXML.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXML.ForeColor = System.Drawing.Color.White;
            this.BtnXML.Location = new System.Drawing.Point(31, 131);
            this.BtnXML.Name = "BtnXML";
            this.BtnXML.Size = new System.Drawing.Size(100, 40);
            this.BtnXML.TabIndex = 0;
            this.BtnXML.Text = "Manejo XML";
            this.BtnXML.UseVisualStyleBackColor = false;
            this.BtnXML.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // BtnJson
            // 
            this.BtnJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BtnJson.FlatAppearance.BorderSize = 0;
            this.BtnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJson.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJson.ForeColor = System.Drawing.Color.White;
            this.BtnJson.Location = new System.Drawing.Point(223, 131);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(100, 40);
            this.BtnJson.TabIndex = 1;
            this.BtnJson.Text = "Manejo JSON";
            this.BtnJson.UseVisualStyleBackColor = false;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LblTitulo.Location = new System.Drawing.Point(26, 26);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(297, 25);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Manejo de archivos XML y JSON";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.BtnXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BtnXML;
        private System.Windows.Forms.Button BtnJson;
        private System.Windows.Forms.Label LblTitulo;
    }
}

