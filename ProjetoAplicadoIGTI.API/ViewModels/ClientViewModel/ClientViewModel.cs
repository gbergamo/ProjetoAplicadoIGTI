using System.Collections.Generic;

namespace ProjetoAplicadoIGTI.API.ViewModels
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public IEnumerable<AppointmentViewModel> Appointments { get; set; }
    }
}
