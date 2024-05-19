using System.ComponentModel.DataAnnotations;

public class Color
{
  
   [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    
}