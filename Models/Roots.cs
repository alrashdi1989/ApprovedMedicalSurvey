using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
  public  class Roots
    {
        public  List<Governorate> governorates { get; set; }
        public   List<Users> Users { get; set; }

        public  List<Village> villages { get; set; }

        public  List<Willayat> willayat { get; set; }

        public List<OperationOrder> operationOrders { get; set; }
    }
}
