using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

        
        public int FlavorId { get; set; }
        public int TreatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> Flavors { get; set; }
    }
}