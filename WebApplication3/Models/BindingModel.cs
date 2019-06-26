using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class BindingModel
    { 
        public List<HeadRegistrationDetails> head { get; set; }
        public List<SpouseRegistreationDetails> spouse { get; set; }
        public List<ChildRegistrationDetails> Child { get; set; }
       
    }


}
