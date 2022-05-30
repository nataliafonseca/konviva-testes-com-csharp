﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class Media
    {
        public static string Simples(double n1, double n2)
        {
            if (n1 < 0 || n2 < 0)
            {
                throw new ArgumentException("Os valores devem ser positivos.");
            }

            var media = (n1 + n2) / 2;

            return media.ToString("F1");
        }

        public static string Simples(double n1, double n2, double n3)
        {
            if (n1 < 0 || n2 < 0 || n3 < 0)
            {
                throw new ArgumentException("Os valores devem ser positivos.");
            }

            var media = (n1 + n2 + n3) / 3;

            return media.ToString("F1");
        }
    }
}
