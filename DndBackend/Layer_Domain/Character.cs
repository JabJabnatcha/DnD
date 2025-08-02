namespace Layer_Domain.Entities
{
    public class Character
{
    public int CharacterId { get; private set; }
    public string charracter_name { get; private set; }=null!;
    
    public int RaceId { get; private set; }
    public int ClassId { get; private set; }
    public int Level { get; private set; }
    
    public StatusBase StatusBase { get; private set; } = null!;
}
}
