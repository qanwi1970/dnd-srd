﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SrdReference.Models.Entities.Interfaces;

namespace SrdReference.Models.Entities
{
    [Table("Item")]
    public class Item : IAuditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Subcategory { get; set; }

        public string SpecialAbility { get; set; }

        public string Aura { get; set; }

        public string CasterLevel { get; set; }

        public string Price { get; set; }

        public string ManifesterLevel { get; set; }

        public string Prerequisites { get; set; }

        public string Cost { get; set; }

        public string Weight { get; set; }

        public string FullText { get; set; }

        public string Reference { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool SeedData { get; set; }
    }
}
