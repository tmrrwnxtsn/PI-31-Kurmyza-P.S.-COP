using System.ComponentModel;

namespace FurnitureFactoryDatabaseImplement.ViewModels
{
    public class OrganizationTypeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
