using System;


namespace FormularioVendasMVC.Services.Execptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
            
        }
    }
}
