using System.ComponentModel.DataAnnotations.Schema;

namespace SrdReference.Models.Entities
{
    [Table("Alignment")]
    public class Alignment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public short Good { get; set; }

        public short Law { get; set; }

        public string Description { get; set; }

        public string Quote { get; set; }
    }
}