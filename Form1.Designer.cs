
namespace DPRN3_U3_A3_JHRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmpEspecie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmpCantidad = new System.Windows.Forms.TextBox();
            this.cmpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(238, 336);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(94, 29);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Conectar";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE VENTA DE PLANTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Especie";
            // 
            // cmpEspecie
            // 
            this.cmpEspecie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpEspecie.Location = new System.Drawing.Point(238, 117);
            this.cmpEspecie.Name = "cmpEspecie";
            this.cmpEspecie.Size = new System.Drawing.Size(211, 27);
            this.cmpEspecie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // cmpCantidad
            // 
            this.cmpCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpCantidad.Location = new System.Drawing.Point(238, 275);
            this.cmpCantidad.Name = "cmpCantidad";
            this.cmpCantidad.Size = new System.Drawing.Size(211, 27);
            this.cmpCantidad.TabIndex = 6;
            // 
            // cmpFecha
            // 
            this.cmpFecha.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.cmpFecha.CustomFormat = "MMMM-yyyy";
            this.cmpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmpFecha.Location = new System.Drawing.Point(238, 201);
            this.cmpFecha.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.cmpFecha.MinDate = new System.DateTime(1980, 9, 14, 0, 0, 0, 0);
            this.cmpFecha.Name = "cmpFecha";
            this.cmpFecha.ShowUpDown = true;
            this.cmpFecha.Size = new System.Drawing.Size(211, 27);
            this.cmpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGuardar.Location = new System.Drawing.Point(355, 336);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 403);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmpFecha);
            this.Controls.Add(this.cmpCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmpEspecie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConexion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmpEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cmpCantidad;
        private System.Windows.Forms.DateTimePicker cmpFecha;
        private System.Windows.Forms.Button btnGuardar;
    }
}

