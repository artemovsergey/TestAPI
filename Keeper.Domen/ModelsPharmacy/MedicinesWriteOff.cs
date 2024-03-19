using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen.ModelsPharmacy;

public class MedicinesWriteOff
{
    public int MedicineId { get; set; }
    public int Quantity { get; set; }
    public string Reason { get; set; }
}
