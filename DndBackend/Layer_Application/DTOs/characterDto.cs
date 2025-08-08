//C:\Users\Laptop-JAB\Desktop\Learn\DnD\DndBackend\Layer_Application\DTOs\characterDto.cs
using Layer_Application.DTOs;

namespace Layer_Application.DTOs
{
    public class CreateCharacterRequest
    {
        public string CharacterName { get; set; } = null!;
        public int Level { get; set; }
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public int AlignmentId { get; set; }
        public Status_BaseDto StatusBase { get; set; } = null!;


    }
}
