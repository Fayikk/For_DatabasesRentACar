﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helper.GuidHelper
{
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString(); // Yüklediğimiz dosya için Guid.NewGuide ile eşsiz bir isim oluşturup stringe donüştürdük.
        }
    }
}
