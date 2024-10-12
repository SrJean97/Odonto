using System.ComponentModel.DataAnnotations;

namespace Odonto.Shared.DTOs.ServicesDTO
{
    public class ServiceRequestDto
    {
        //Se definiran las propiedades necesarias para registrar un servicio

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public int UserCreate {  get; set; }
    }
}
