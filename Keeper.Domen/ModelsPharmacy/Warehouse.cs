using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen.ModelsPharmacy;

public class Warehouse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<Medicines> Medicines { get; set; }  
}
