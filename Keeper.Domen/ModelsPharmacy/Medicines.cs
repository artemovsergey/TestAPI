using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper.Domen.ModelsPharmacy;

public class Medicines
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Image {  get; set; }
    public int Price { get; set; }
    public int StockQuantity { get; set; }
    public int OptimalQuantity { get; set; }
    public DateTime ExpirationDate { get; set; }

    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; }

    public IEnumerable<Issue> Issues { get; set; }  
}
