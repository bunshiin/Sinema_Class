using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Class
{
    internal class Sinema
    {
        public int koltuk;
        public int sayi;
        public int bakiye;
        public bool indirimİptal, indirimBilet;
        public void biletSat()
        {
            if (indirimİptal == true)
            {
                bakiye = bakiye + 50;
                koltuk = koltuk + 1;
            }
            else
            {
                bakiye = bakiye + 100;
                koltuk = koltuk - 1;
            }

        }
        public void biletİptalEt()
        {
            if (indirimİptal == true)
            {
                bakiye = bakiye - 50;
                koltuk = koltuk + 1;
            }
            else
            {
                bakiye = bakiye - 100;
                koltuk = koltuk + 1;
            }

        }
        public void boskoltukLar()
        {
            System.Windows.Forms.MessageBox.Show(koltuk.ToString());
        }
        public void bakiyeOgren()
        {
            System.Windows.Forms.MessageBox.Show(bakiye.ToString());
        }
    }
}

