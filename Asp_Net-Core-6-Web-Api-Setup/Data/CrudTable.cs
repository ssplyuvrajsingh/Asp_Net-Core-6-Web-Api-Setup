using System.ComponentModel.DataAnnotations.Schema;

namespace Asp_Net_Core_6_Web_Api_Setup.Data
{
    [Table("CrudTable")]
    public class CrudTable
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserEmail { get; set; }
    }
}
