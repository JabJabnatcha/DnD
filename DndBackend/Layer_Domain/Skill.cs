using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities.Race;
using Layer_Domain.Entities.Class;
using Layer_Domain.Entities.Items; 
using Layer_Domain.Entities.Spells;

namespace Layer_Domain.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        // FK
        public int CharId { get; set; }
        public Character Character { get; set; } = null!;

        // Skill values
        public int Acrobatics { get; set; }
        public bool AcrobaticsProficient { get; set; }

        public int AnimalHandling { get; set; }
        public bool AnimalHandlingProficient { get; set; }

        public int Arcana { get; set; }
        public bool ArcanaProficient { get; set; }

        public int Athletics { get; set; }
        public bool AthleticsProficient { get; set; }

        public int Deception { get; set; }
        public bool DeceptionProficient { get; set; }

        public int History { get; set; }
        public bool HistoryProficient { get; set; }

        public int Insight { get; set; }
        public bool InsightProficient { get; set; }

        public int Intimidation { get; set; }
        public bool IntimidationProficient { get; set; }

        public int Investigation { get; set; }
        public bool InvestigationProficient { get; set; }

        public int Medicine { get; set; }
        public bool MedicineProficient { get; set; }

        public int Nature { get; set; }
        public bool NatureProficient { get; set; }

        public int Perception { get; set; }
        public bool PerceptionProficient { get; set; }

        public int Performance { get; set; }
        public bool PerformanceProficient { get; set; }

        public int Persuasion { get; set; }
        public bool PersuasionProficient { get; set; }

        public int Religion { get; set; }
        public bool ReligionProficient { get; set; }

        public int SleightOfHand { get; set; }
        public bool SleightOfHandProficient { get; set; }

        public int Stealth { get; set; }
        public bool StealthProficient { get; set; }

        public int Survival { get; set; }
        public bool SurvivalProficient { get; set; }
    }
    }

