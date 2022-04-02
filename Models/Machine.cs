using System.Collections.Generic;

namespace Factory.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    public int MachineId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get;}
  }
}