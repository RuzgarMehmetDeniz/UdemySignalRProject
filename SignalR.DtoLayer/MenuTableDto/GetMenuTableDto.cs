using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.MenuTableDto
{
    public class GetMenuTableDto
    {
        public int MenuTableID { get; set; }
        public int Name { get; set; }
        public bool Status { get; set; }
    }
}
