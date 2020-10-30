namespace Tarea2_LeonardoMolina.Formularios
{
    partial class frmpromediodeestudiante
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LsbCondicion = new System.Windows.Forms.ListBox();
            this.LsbCalif = new System.Windows.Forms.ListBox();
            this.LsbEstudiantes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtCalificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblCalificacion = new System.Windows.Forms.Label();
            this.LblNombreE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Controls.Add(this.LsbCondicion);
            this.groupBox1.Controls.Add(this.LsbCalif);
            this.groupBox1.Controls.Add(this.LsbEstudiantes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnIngresar);
            this.groupBox1.Controls.Add(this.TxtCalificacion);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.LblCalificacion);
            this.groupBox1.Controls.Add(this.LblNombreE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiar.Location = new System.Drawing.Point(383, 449);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(114, 35);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Silver;
            this.BtnSalir.Location = new System.Drawing.Point(514, 449);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(114, 35);
            this.BtnSalir.TabIndex = 26;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LsbCondicion
            // 
            this.LsbCondicion.FormattingEnabled = true;
            this.LsbCondicion.ItemHeight = 21;
            this.LsbCondicion.Location = new System.Drawing.Point(430, 257);
            this.LsbCondicion.Name = "LsbCondicion";
            this.LsbCondicion.Size = new System.Drawing.Size(148, 151);
            this.LsbCondicion.TabIndex = 25;
            // 
            // LsbCalif
            // 
            this.LsbCalif.FormattingEnabled = true;
            this.LsbCalif.ItemHeight = 21;
            this.LsbCalif.Location = new System.Drawing.Point(275, 257);
            this.LsbCalif.Name = "LsbCalif";
            this.LsbCalif.Size = new System.Drawing.Size(149, 151);
            this.LsbCalif.TabIndex = 24;
            // 
            // LsbEstudiantes
            // 
            this.LsbEstudiantes.FormattingEnabled = true;
            this.LsbEstudiantes.ItemHeight = 21;
            this.LsbEstudiantes.Location = new System.Drawing.Point(16, 257);
            this.LsbEstudiantes.Name = "LsbEstudiantes";
            this.LsbEstudiantes.Size = new System.Drawing.Size(254, 151);
            this.LsbEstudiantes.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(430, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "CONDICIÓN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(276, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "CALIFICACIÓN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "NOMBRE DEL ESTUDIANTE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Blue;
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnIngresar.Location = new System.Drawing.Point(504, 137);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(114, 44);
            this.BtnIngresar.TabIndex = 19;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtCalificacion
            // 
            this.TxtCalificacion.Location = new System.Drawing.Point(363, 145);
            this.TxtCalificacion.Name = "TxtCalificacion";
            this.TxtCalificacion.Size = new System.Drawing.Size(120, 27);
            this.TxtCalificacion.TabIndex = 18;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(361, 100);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(235, 27);
            this.TxtNombre.TabIndex = 17;
            // 
            // LblCalificacion
            // 
            this.LblCalificacion.AutoSize = true;
            this.LblCalificacion.Location = new System.Drawing.Point(16, 148);
            this.LblCalificacion.Name = "LblCalificacion";
            this.LblCalificacion.Size = new System.Drawing.Size(314, 21);
            this.LblCalificacion.TabIndex = 16;
            this.LblCalificacion.Text = "Ingresar Calificación del Estudiante #1:";
            // 
            // LblNombreE
            // 
            this.LblNombreE.AutoSize = true;
            this.LblNombreE.Location = new System.Drawing.Point(16, 103);
            this.LblNombreE.Name = "LblNombreE";
            this.LblNombreE.Size = new System.Drawing.Size(285, 21);
            this.LblNombreE.TabIndex = 15;
            this.LblNombreE.Text = "Ingresar Nombre del Estudiante #1:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "Calcular el Promedio de 10 Estudiantes Si Aprobaron o Reprobaron:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmpromediodeestudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 521);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmpromediodeestudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promedio De Estudiante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LsbCondicion;
        private System.Windows.Forms.ListBox LsbCalif;
        private System.Windows.Forms.ListBox LsbEstudiantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtCalificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblCalificacion;
        private System.Windows.Forms.Label LblNombreE;
        private System.Windows.Forms.Label label1;
    }
}