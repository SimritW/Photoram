using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Photosphere.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] Image { get; set; }
        
        [Required]
        public string FileName { get; set; }
        [Required]
        public string FileType { get; set; }
        
        
        public string Manufacturer { get; set; }
        
        public string Model { get; set; }

        public string ExposureTime { get; set; }

        public string FStop { get; set; }

        public string FocalLength { get; set; }
        
        public string MaxAperture { get; set; }

        public string ExposureBias { get; set; }


        public string Width { get; set; }

        public string Height { get; set; }

        public string AffectedFocalLength { get; set; }

        public bool Favourite { get; set; }

        public string Comments { get; set; }


    }
}
