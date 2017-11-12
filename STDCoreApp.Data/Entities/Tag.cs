using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using STDCoreApp.Infrastructure.SharedKernel;

namespace STDCoreApp.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}
