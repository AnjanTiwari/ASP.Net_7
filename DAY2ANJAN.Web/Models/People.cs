using System.ComponentModel.DataAnnotations;

public class People{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string  City { get; set; }= string.Empty;
}