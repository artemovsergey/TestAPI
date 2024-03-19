using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen.ModelsPharmacy;

public class Issue
{
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public string? Purpose { get; set; }
    public int Quantity { get; set; }
    public string? Status { get; set; }

    public Medicines Medicines { get; set; }
}
