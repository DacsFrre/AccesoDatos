using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.SQLAccess.ViewModel
{
    public class ContactVm
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public string ToString() {
            
            return string.Format("Id: {0}, Nombre: {1}, Edad: {2}", Id, Nombre, Edad);

        }
    }
}
