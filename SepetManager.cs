﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepetinize eklendi: " + product.Ad);
        }
    }
}
