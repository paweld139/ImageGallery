﻿using Microsoft.AspNetCore.Http;

namespace ImageGallery.BLL.Models
{
    public class FileModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public required IFormFile File { get; set; }
    }
}
