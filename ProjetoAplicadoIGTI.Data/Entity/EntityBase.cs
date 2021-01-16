using System;

namespace ProjetoAplicadoIGTI.Data.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
