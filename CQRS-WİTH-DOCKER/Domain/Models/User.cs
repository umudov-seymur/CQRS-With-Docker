using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CQRS_WİTH_DOCKER.Domain.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int Age { get; set; }
    }
}
