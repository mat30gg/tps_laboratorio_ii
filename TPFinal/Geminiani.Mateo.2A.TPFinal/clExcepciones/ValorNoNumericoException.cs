using System;

namespace clExcepciones
{
    public class ValorNoNumericoException : Exception
    {
        public override string Message
        {
            get
            {
                return "Se esperaba un valor numerico" + base.Message;
            }
        }
    }
}
