using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbLib
{
    public class Major
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }
        //override grabs the idividual data instead of the String of the object

        public override string ToString()
        {
            return $"{this.Id} | {this.Code} | {this.Description} | {this.MinSAT}";                            
        }
    }
}
