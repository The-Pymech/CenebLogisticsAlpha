using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Domain.ViewModels.DisplayModels.Lists
{
    public class LocationListModel : GeneralDataClassViewmodel
    {


        public int Id { get; set; }


        public string Address { get; set; }


        public string Description { get; set; }
    }
}
