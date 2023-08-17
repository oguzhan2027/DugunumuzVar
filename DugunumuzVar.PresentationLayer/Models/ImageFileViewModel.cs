using Microsoft.AspNetCore.Http;

namespace DugunumuzVar.PresentationLayer.Models
{
    public class ImageFileViewModel
    {
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
