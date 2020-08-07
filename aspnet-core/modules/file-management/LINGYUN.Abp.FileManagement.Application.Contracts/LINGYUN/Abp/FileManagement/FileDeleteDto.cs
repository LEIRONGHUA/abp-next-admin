﻿using System.ComponentModel.DataAnnotations;

namespace LINGYUN.Abp.FileManagement
{
    public class FileDeleteDto
    {
        [Required]
        [StringLength(255)]
        public string Path { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
