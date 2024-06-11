namespace App.DTOs;

public class ReturnItemsDTO
{
    public string FirstName { get; set; } = string.Empty!;
    
    
    public string LastName { get; set; } = string.Empty!;

    public int CurrentWeight { get; set; }

    public int MaxWeight { get; set; }

    public ICollection<EqDTO> EqDtos { get; set; } = new HashSet<EqDTO>();

}


public class EqDTO
{
    public string Name { get; set; } = string.Empty!;


    public int Weight { get; set; }
    
    public int Amount { get; set; }

    
}