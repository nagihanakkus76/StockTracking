using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.EntitiesLayer
{
    public class Processes : BaseEntity
    {

        public Product Product { get; set; }  
        public int ProductID { get; set; }  
        public User User { get; set; }  
        public int UserID { get; set; }  
        public ProcessType ProcessType { get; set; }
        public int ProcessTypeID { get; set; }
        
    }
}
