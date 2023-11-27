using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    internal class ConexaoBanco
    {
        private const string servidor = "localhost";
        private const string bancoDados = "projetofinal";
        private const string usuario = "root";
        private const string senha = "giovanna@123";

        //para criar as tabelas troca suas infos do banco acima.
        static public string bancoServidor = $"server={servidor}; user id={usuario}; database ={bancoDados}; password ={senha}";

    }
}
