﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FrbaCommerce.ABM_Usuario;


namespace FrbaCommerce.Login
{
    public partial class login : FormGridTerminal
    {        
        public login()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(340, 140);
        }

        private void submitActions()
        {
            if (userTextbox.Text == "" || passTextBox.Text == "")
            {
                TG.ventanaEmergente("Campos incompletos");
                return;
            }
            int protocol = TG.procLogin(userTextbox.Text, passTextBox.Text);

            if (protocol == 1) TG.ventanaEmergente("Usuario NO Encontrado o pass incorrecto");// usuario no encontrado
            else if (protocol == 2) TG.ventanaEmergente("Usuario Inhabilitado!");
            else if (protocol == 3) TG.ventanaEmergente("Usuario NO Encontrado o pass incorrecto");// pass incorrecto
            else if (protocol == 4) TG.ventanaEmergente("Inhabilitado por poner mal el pass 3 veces!");
            else if (protocol == 5) TG.ventanaEmergente("No hay roles disponibles para este usuario");
            else if (primerIngreso(userTextbox.Text))
            {
                DatosUsuario.usuario = userTextbox.Text;
                FrbaCommerce.Login.cambioPass cambioDePass = new cambioPass(this, true);
                cambioDePass.Show();
                this.Visible = false;
            }
            else
            {
                DatosUsuario.usuario = userTextbox.Text;
                DatosUsuario.actualizarBanderasUsuario();
                FrbaCommerce.Login.selectorRol seleccionRol = new selectorRol(this);
                seleccionRol.Show();
                this.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validator validador = new Validator();
            if (!validador.validar_numerico(userTextbox.Text))
            {
                Control.Visible = true;
                userTextbox.BackColor = Color.FromArgb(255, 161, 161);
                return;
            }
            button1.Enabled = false;
            this.Refresh();
            submitActions();
            button1.Enabled = true;
        }

        private bool primerIngreso(string usuario)
        {           
           string comando = "select Primer_Ingreso from THE_GRID.Usuario where ID_User = "+ usuario;
           DataRow resultado = TG.realizarConsulta(comando).Rows[0];
           return Convert.ToBoolean(resultado["Primer_Ingreso"]);
        }

        private void userTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitActions();
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) submitActions();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Registro_de_Usuario(this)).Show();
            this.Visible = false;
        }

        private void login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true) DatosUsuario.resetearDatos();
        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {
            userTextbox.BackColor = Color.FromArgb(255, 255, 255);
            Control.Text = "";
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            Control.Text = "";
        }
    }
}

