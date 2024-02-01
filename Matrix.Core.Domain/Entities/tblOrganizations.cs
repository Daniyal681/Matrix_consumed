using System.ComponentModel.DataAnnotations;

namespace Matrix.Core.Domain.Entities
{
    public class tblOrganizations
    {
        [Key]
        public int RecID { get; set; }
        public string OrganizationName { get; set; }
    }
}
