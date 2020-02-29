
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("manufacturer")]
public class Manufacturer
{
    [Column("manufacturer_id")]
    [Key]
    public long ManufacturerId {get; set;}
    [Column("name")]
    public string Name {get; set;}
    [Column("street1")]
    public string Street1 {get; set;}
    [Column("street2")]
    public string Street2 {get; set;}
    [Column("city")]
    public string City {get; set;}
    [Column("state")]
    public string State {get; set;}
    [Column("zip_code")]
    public string ZipCode {get; set;}
    
    [Column("product_id")]
    public long ProductId { get; set; }
    public Product Product { get; set; }
}