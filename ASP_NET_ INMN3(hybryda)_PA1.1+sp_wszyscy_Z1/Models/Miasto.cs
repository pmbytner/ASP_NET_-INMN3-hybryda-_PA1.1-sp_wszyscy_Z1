using System.ComponentModel.DataAnnotations;

namespace ASP_NET__INMN3_hybryda__PA1._1_sp_wszyscy_Z1.Models;

public class Miasto
{
    public int Id { get; set; }
    public string? Nazwa { get; set; }
    public decimal? Powierzchnia { get; set; }
    public ulong? Populacja { get; set; }
    public string? Państwo { get; set; }
    [Display(Name = "Data założenia")]
    [DataType(DataType.Date)]
    public DateTime? DataZałożenia { get; set; }
}
