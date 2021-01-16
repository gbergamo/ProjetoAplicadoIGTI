using System.Collections.Generic;

namespace ProjetoAplicadoIGTI.API.ViewModels
{
    public class ProviderViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<AppointmentViewModel> Appointments { get; set; }
    }
}
