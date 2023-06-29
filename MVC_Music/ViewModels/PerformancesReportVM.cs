using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Music.ViewModels
{
    public class PerformancesReportVM
    {
        public int ID {get;set;}

        [Display(Name = "Musician")]
        public string FormalName
        {
            get
            {
                return LastName + ", " + FirstName
                    + (string.IsNullOrEmpty(MiddleName) ? "" :
                        (" " + (char?)MiddleName[0] + ".").ToUpper());
            }
        }
      
        public string FirstName { get; set; }
  
        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Total Number of Performances")]
        public int TotalPerformances { get; set; }

        //[Display(Name = "Total Songs Performanced")]
        //public int TotalSongs { get; set; }

        [Display(Name = "Average Fee Paid")]
        [DataType(DataType.Currency)]
        public double AverageFee { get; set; }

        [Display(Name = "Highest Fee Paid")]
        [DataType(DataType.Currency)]
        public double HighestFee { get; set; }

        [Display(Name = "Lowest Fee Paid")]
        [DataType(DataType.Currency)]
        public double LowestFee { get; set; }
    }
}
