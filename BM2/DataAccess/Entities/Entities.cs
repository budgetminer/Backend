using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BM2.DataAccess.Entities {
    // Vanaf hier nieuw

    public abstract class Seq {
        [Key] public int id { get; set; }
    }

    public class Customer : Seq {
        [Required]  public string cuName { get; set; }
                    //List<Team> Teams { get; set; }
    }

    public class Team : Seq {
        [Required]                  public string tmName { get; set; } 
                                    public string tmLocation { get; set; }
                                    public string tmMission { get; set; }
                                    public string tmBudgetowner { get; set; }

        public Customer Customer { get; set; }
        public List<Level> Levels { get; set; }
    }
    
    public class Level : Seq {

        [Required]                  public string lvName { get; set; }
                                    public string lvGrade { get; set; }
                                    public string lvBudgetowner { get; set; }
        public Customer Customer { get; set; }
        public Team Team { get; set; }
    }

    public class Headcount : Seq { 
                                    public string hcBudgetowner { get; set; }
        [Required]                  public string hcYear { get; set; }
                                    public string hcNofte { get; set; }
                                    public string hcFtegr { get; set; }
                                    public string HcFtecost { get; set; }
                                    public string hcFteextern { get; set; }
        public Customer Customer { get; set; }
        public Team Team { get; set; }
        public Level Level { get; set; }
    }
}
