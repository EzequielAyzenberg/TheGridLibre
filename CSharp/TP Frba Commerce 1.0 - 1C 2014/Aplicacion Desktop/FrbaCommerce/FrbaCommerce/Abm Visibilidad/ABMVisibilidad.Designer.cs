﻿namespace FrbaCommerce.Abm_Visibilidad
{
    partial class ABMVisibilidad
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonCrearVisibilidad = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonInhabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(469, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botonCrearVisibilidad
            // 
            this.botonCrearVisibilidad.Location = new System.Drawing.Point(345, 22);
            this.botonCrearVisibilidad.Name = "botonCrearVisibilidad";
            this.botonCrearVisibilidad.Size = new System.Drawing.Size(136, 23);
            this.botonCrearVisibilidad.TabIndex = 1;
            this.botonCrearVisibilidad.Text = "Nueva Visibilidad";
            this.botonCrearVisibilidad.UseVisualStyleBackColor = true;
            this.botonCrearVisibilidad.Click += new System.EventHandler(this.botonCrearVisibilidad_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Enabled = false;
            this.botonModificar.Location = new System.Drawing.Point(203, 22);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(136, 23);
            this.botonModificar.TabIndex = 2;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(406, 344);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 3;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonInhabilitar
            // 
            this.botonInhabilitar.Enabled = false;
            this.botonInhabilitar.Location = new System.Drawing.Point(61, 22);
            this.botonInhabilitar.Name = "botonInhabilitar";
            this.botonInhabilitar.Size = new System.Drawing.Size(136, 23);
            this.botonInhabilitar.TabIndex = 4;
            this.botonInhabilitar.Text = "Inhabilitar Visibilidad";
            this.botonInhabilitar.UseVisualStyleBackColor = true;
            this.botonInhabilitar.Click += new System.EventHandler(this.botonInhabilitar_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 379);
            this.Controls.Add(this.botonInhabilitar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonCrearVisibilidad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ABMVisibilidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            this.EnabledChanged += new System.EventHandler(this.ABMVisibilidad_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonCrearVisibilidad;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonInhabilitar;
    }
}