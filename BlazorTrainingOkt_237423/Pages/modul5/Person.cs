using System.ComponentModel.DataAnnotations;

namespace BlazorTrainingOkt_237423.Pages.modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="Muss zwischen 2 und 10 lang sein")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(150,190,ErrorMessage ="Keine Achterbahn für Dich")]
        public int  Gross { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        public DateTime GebDat { get; set; }
    }
}
