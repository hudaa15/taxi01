using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi02
{
    class taksi
    {
        public string namadriver { get; set; }
        public bool lagikerja { get; set; }
        public int penumpang { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine(" Nama Supir      : {0} ", namadriver);
            if (lagikerja == true) 
            {
                Console.WriteLine(" Sedang mengantar penumpang ", lagikerja);
            }
            else
            {
                Console.WriteLine(" Sedang tidak mengantar penumpang ", lagikerja);
            }

            Console.WriteLine(" Jumlah penumpang  : {0}\n ", penumpang);
        }

        public void angkutpenumpang()
        {
            Console.WriteLine(" {0} Sedang menjemput penumpang ", namadriver);
        }

        public void turunpenumpang()
        {
            Console.WriteLine(" {0} Selesai menjemput penumpang\n ", namadriver);
        }

    }


}
