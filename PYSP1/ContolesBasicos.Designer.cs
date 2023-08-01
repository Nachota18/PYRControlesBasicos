namespace PYSP1
{
    partial class frmControlesBasicos
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
            this.txtTextoqueAparece = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.mrcAderezo = new System.Windows.Forms.GroupBox();
            this.lblTextodeColor = new System.Windows.Forms.Label();
            this.chkPicante = new System.Windows.Forms.CheckBox();
            this.chkMayonesa = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.cboAdicional = new System.Windows.Forms.ComboBox();
            this.lblAderezo = new System.Windows.Forms.Label();
            this.lblEjeY = new System.Windows.Forms.Label();
            this.lblEjeX = new System.Windows.Forms.Label();
            this.mrcAderezo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextoqueAparece
            // 
            this.txtTextoqueAparece.Location = new System.Drawing.Point(57, 51);
            this.txtTextoqueAparece.Name = "txtTextoqueAparece";
            this.txtTextoqueAparece.Size = new System.Drawing.Size(333, 20);
            this.txtTextoqueAparece.TabIndex = 0;
            this.txtTextoqueAparece.TextChanged += new System.EventHandler(this.txtTextoqueAparece_TextChanged);
            // 
            // optRojo
            // 
            this.optRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRojo.Location = new System.Drawing.Point(57, 93);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(91, 111);
            this.optRojo.TabIndex = 1;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            this.optRojo.CheckedChanged += new System.EventHandler(this.optRojo_CheckedChanged);
            // 
            // optAzul
            // 
            this.optAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAzul.Location = new System.Drawing.Point(302, 86);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(88, 118);
            this.optAzul.TabIndex = 1;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            this.optAzul.CheckedChanged += new System.EventHandler(this.optAzul_CheckedChanged);
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAsignar.Location = new System.Drawing.Point(141, 220);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(134, 42);
            this.cmdAsignar.TabIndex = 2;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // mrcAderezo
            // 
            this.mrcAderezo.Controls.Add(this.chkKetchup);
            this.mrcAderezo.Controls.Add(this.chkMayonesa);
            this.mrcAderezo.Controls.Add(this.chkPicante);
            this.mrcAderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAderezo.Location = new System.Drawing.Point(625, 51);
            this.mrcAderezo.Name = "mrcAderezo";
            this.mrcAderezo.Size = new System.Drawing.Size(271, 197);
            this.mrcAderezo.TabIndex = 3;
            this.mrcAderezo.TabStop = false;
            this.mrcAderezo.Text = "Aderezo";
            // 
            // lblTextodeColor
            // 
            this.lblTextodeColor.AutoSize = true;
            this.lblTextodeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextodeColor.Location = new System.Drawing.Point(118, 343);
            this.lblTextodeColor.Name = "lblTextodeColor";
            this.lblTextodeColor.Size = new System.Drawing.Size(0, 31);
            this.lblTextodeColor.TabIndex = 4;
            this.lblTextodeColor.Click += new System.EventHandler(this.lblTextodeColor_Click);
            // 
            // chkPicante
            // 
            this.chkPicante.AutoSize = true;
            this.chkPicante.Location = new System.Drawing.Point(22, 37);
            this.chkPicante.Name = "chkPicante";
            this.chkPicante.Size = new System.Drawing.Size(103, 29);
            this.chkPicante.TabIndex = 0;
            this.chkPicante.Text = "Picante";
            this.chkPicante.UseVisualStyleBackColor = true;
            this.chkPicante.CheckedChanged += new System.EventHandler(this.chkPicante_CheckedChanged);
            // 
            // chkMayonesa
            // 
            this.chkMayonesa.AutoSize = true;
            this.chkMayonesa.Location = new System.Drawing.Point(22, 91);
            this.chkMayonesa.Name = "chkMayonesa";
            this.chkMayonesa.Size = new System.Drawing.Size(131, 29);
            this.chkMayonesa.TabIndex = 0;
            this.chkMayonesa.Text = "Mayonesa";
            this.chkMayonesa.UseVisualStyleBackColor = true;
            this.chkMayonesa.CheckedChanged += new System.EventHandler(this.chkMayonesa_CheckedChanged);
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(22, 144);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(110, 29);
            this.chkKetchup.TabIndex = 0;
            this.chkKetchup.Text = "Ketchup";
            this.chkKetchup.UseVisualStyleBackColor = true;
            this.chkKetchup.CheckedChanged += new System.EventHandler(this.chkKetchup_CheckedChanged);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionar.Location = new System.Drawing.Point(679, 254);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(145, 33);
            this.cmdSeleccionar.TabIndex = 2;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cboAdicional
            // 
            this.cboAdicional.FormattingEnabled = true;
            this.cboAdicional.Location = new System.Drawing.Point(625, 366);
            this.cboAdicional.Name = "cboAdicional";
            this.cboAdicional.Size = new System.Drawing.Size(271, 21);
            this.cboAdicional.TabIndex = 5;
            this.cboAdicional.SelectedIndexChanged += new System.EventHandler(this.cboAdicional_SelectedIndexChanged);
            // 
            // lblAderezo
            // 
            this.lblAderezo.AutoSize = true;
            this.lblAderezo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAderezo.Location = new System.Drawing.Point(659, 310);
            this.lblAderezo.Name = "lblAderezo";
            this.lblAderezo.Size = new System.Drawing.Size(0, 25);
            this.lblAderezo.TabIndex = 4;
            this.lblAderezo.Click += new System.EventHandler(this.lblTextodeColor_Click);
            // 
            // lblEjeY
            // 
            this.lblEjeY.AutoSize = true;
            this.lblEjeY.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEjeY.Location = new System.Drawing.Point(518, 58);
            this.lblEjeY.Name = "lblEjeY";
            this.lblEjeY.Size = new System.Drawing.Size(14, 13);
            this.lblEjeY.TabIndex = 6;
            this.lblEjeY.Text = "Y";
            // 
            // lblEjeX
            // 
            this.lblEjeX.AutoSize = true;
            this.lblEjeX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEjeX.Location = new System.Drawing.Point(518, 86);
            this.lblEjeX.Name = "lblEjeX";
            this.lblEjeX.Size = new System.Drawing.Size(14, 13);
            this.lblEjeX.TabIndex = 6;
            this.lblEjeX.Text = "X";
            // 
            // frmControlesBasicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.lblEjeX);
            this.Controls.Add(this.lblEjeY);
            this.Controls.Add(this.cboAdicional);
            this.Controls.Add(this.lblAderezo);
            this.Controls.Add(this.lblTextodeColor);
            this.Controls.Add(this.mrcAderezo);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtTextoqueAparece);
            this.Name = "frmControlesBasicos";
            this.Text = "Controles basicos";
            this.Load += new System.EventHandler(this.lolI_Load);
            this.mrcAderezo.ResumeLayout(false);
            this.mrcAderezo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoqueAparece;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.GroupBox mrcAderezo;
        private System.Windows.Forms.Label lblTextodeColor;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkMayonesa;
        private System.Windows.Forms.CheckBox chkPicante;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.ComboBox cboAdicional;
        private System.Windows.Forms.Label lblAderezo;
        private System.Windows.Forms.Label lblEjeY;
        private System.Windows.Forms.Label lblEjeX;
    }
}

