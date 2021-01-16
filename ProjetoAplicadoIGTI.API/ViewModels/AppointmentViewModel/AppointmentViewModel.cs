using System;

namespace ProjetoAplicadoIGTI.API.ViewModels
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientId { get; set; }
        public ClientViewModel Client { get; set; }
        public int ProviderId { get; set; }
        public ProviderViewModel Provider { get; set; }
    }
}
