
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen.ModelsPharmacy;

public class Invoice
{
    public int Id { get; set; }
    public DateTime DocumentDate { get; set; }
    public string Provider { get; set; }

    public IEnumerable<Medicines> Medicines { get; set; }
}
