using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AB.Model.Adstract;

namespace AB.Model
{
    public class User: IEntityBase
    {
	    public Int32 Id { get; set; }
		public String Name { get; set; }
	    public String EMail { get; set; }
	    public String ImagePath { get; set; }
	    public String Biografy { get; set; }
    }
}
