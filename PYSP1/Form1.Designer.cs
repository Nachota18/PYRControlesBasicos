namespace PYSP1
{
    partial class lolI
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
            this.chkVALO = new System.Windows.Forms.CheckBox();
            this.chkLOLSITO = new System.Windows.Forms.CheckBox();
            this.mrcSelecciondeSexo = new System.Windows.Forms.GroupBox();
            this.cmdTOCAAQUI = new System.Windows.Forms.Button();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.cboHistorial = new System.Windows.Forms.ComboBox();
            this.mrcSelecciondeSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkVALO
            // 
            this.chkVALO.AutoSize = true;
            this.chkVALO.Location = new System.Drawing.Point(23, 65);
            this.chkVALO.Name = "chkVALO";
            this.chkVALO.Size = new System.Drawing.Size(128, 43);
            this.chkVALO.TabIndex = 0;
            this.chkVALO.Text = "VALO";
            this.chkVALO.UseVisualStyleBackColor = true;
            // 
            // chkLOLSITO
            // 
            this.chkLOLSITO.AutoSize = true;
            this.chkLOLSITO.Location = new System.Drawing.Point(209, 65);
            this.chkLOLSITO.Name = "chkLOLSITO";
            this.chkLOLSITO.Size = new System.Drawing.Size(101, 43);
            this.chkLOLSITO.TabIndex = 0;
            this.chkLOLSITO.Text = "LOL";
            this.chkLOLSITO.UseVisualStyleBackColor = true;
            // 
            // mrcSelecciondeSexo
            // 
            this.mrcSelecciondeSexo.Controls.Add(this.chkLOLSITO);
            this.mrcSelecciondeSexo.Controls.Add(this.chkVALO);
            this.mrcSelecciondeSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcSelecciondeSexo.Location = new System.Drawing.Point(17, 47);
            this.mrcSelecciondeSexo.Name = "mrcSelecciondeSexo";
            this.mrcSelecciondeSexo.Size = new System.Drawing.Size(345, 118);
            this.mrcSelecciondeSexo.TabIndex = 1;
            this.mrcSelecciondeSexo.TabStop = false;
            this.mrcSelecciondeSexo.Text = "Seleccion de Droga";
            // 
            // cmdTOCAAQUI
            // 
            this.cmdTOCAAQUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTOCAAQUI.Location = new System.Drawing.Point(17, 204);
            this.cmdTOCAAQUI.Name = "cmdTOCAAQUI";
            this.cmdTOCAAQUI.Size = new System.Drawing.Size(294, 129);
            this.cmdTOCAAQUI.TabIndex = 2;
            this.cmdTOCAAQUI.Text = "TOCA AQUI";
            this.cmdTOCAAQUI.UseVisualStyleBackColor = true;
            this.cmdTOCAAQUI.Click += new System.EventHandler(this.cmdTOCAAQUI_Click);
            // 
            // lblEscribir
            // 
            this.lblEscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribir.Location = new System.Drawing.Point(413, 66);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(614, 210);
            this.lblEscribir.TabIndex = 3;
            this.lblEscribir.Click += new System.EventHandler(this.lblEscribir_Click);
            // 
            // cboHistorial
            // 
            this.cboHistorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHistorial.FormattingEnabled = true;
            this.cboHistorial.Location = new System.Drawing.Point(75, 364);
            this.cboHistorial.Name = "cboHistorial";
            this.cboHistorial.Size = new System.Drawing.Size(202, 21);
            this.cboHistorial.TabIndex = 4;
            this.cboHistorial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lolI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.cboHistorial);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.cmdTOCAAQUI);
            this.Controls.Add(this.mrcSelecciondeSexo);
            this.Name = "lolI";
            this.Text = "TOCAAQUI";
            this.Load += new System.EventHandler(this.lolI_Load);
            this.mrcSelecciondeSexo.ResumeLayout(false);
            this.mrcSelecciondeSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkVALO;
        private System.Windows.Forms.CheckBox chkLOLSITO;
        private System.Windows.Forms.GroupBox mrcSelecciondeSexo;
        private System.Windows.Forms.Button cmdTOCAAQUI;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.ComboBox cboHistorial;
    }
}

