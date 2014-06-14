﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public class FormGrid : Form
    {
        protected FormGrid ventanaAnterior;
        protected FormGrid()
        {
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.Dock = DockStyle.Fill;

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            //this.ShowDialog();

        }

        private void ManejadorCierre(object sender, EventArgs e)
        {
            // Todas estas boludeces ocurren cuando se cierra un form de clase FromGrid
            TG.ventanaEmergente("NO ME CIERRO NADA");
        }

        protected void volverAtras()
        {
            this.ventanaAnterior.Show();
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormGrid
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "FormGrid";
            this.Load += new System.EventHandler(this.FormGrid_Load);
            this.ResumeLayout(false);

        }

        private void FormGrid_Load(object sender, EventArgs e)
        {

        }
    }

    public class FormGridTerminal : FormGrid
    {
        protected FormGridTerminal()
        {
            this.FormClosed += ManejadorCierre;
            this.ControlBox = true;
        }

        private void ManejadorCierre(object sender, EventArgs e)
        {
            //Si me cierran, cierro todo.
            System.Environment.Exit(0);
        }
    }
}