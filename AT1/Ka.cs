using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1
{
    class Ka
    {
      
        public int id;
        public string id_material;
        public string id_service;
        public string id_size;
        public string counts;



        public Ka(int id, string id_material, string id_service, string id_size, string counts)
        {
            this.id = id;
            this.id_material = id_material;
            this.id_service = id_service;
            this.id_size = id_size;
            this.counts = counts;
        }
    }
}
