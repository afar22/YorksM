﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YorksM
{
    internal class Usuarios
    {
        int id,id_tipo;
        string usuario, password, conPassword, nombre, apellido;

        // Metodos get y set
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
