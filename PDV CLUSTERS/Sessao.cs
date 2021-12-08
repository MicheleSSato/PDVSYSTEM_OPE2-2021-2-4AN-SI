using System;

namespace PDV_CLUSTERS
{
    public class Sessao
    {
        private static string _login;
        private static string _nomeUsuario;

        public static String Login
        {
            get { return Sessao._login; }
            set { Sessao._login = value; }
        }

        public static String NomeUsuario
        {
            get { return Sessao._nomeUsuario; }
            set { Sessao._nomeUsuario = value; }
        }
    }
}
