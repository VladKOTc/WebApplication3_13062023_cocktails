using Microsoft.Data.SqlClient;

namespace WebApplication3_13062023_cocktails.Models
{
    public class Cocktail
    { 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
    }
}
