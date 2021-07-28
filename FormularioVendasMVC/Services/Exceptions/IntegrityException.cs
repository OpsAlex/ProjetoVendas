using System.Runtime.InteropServices;
using System;


namespace FormularioVendasMVC.Services.Execptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
