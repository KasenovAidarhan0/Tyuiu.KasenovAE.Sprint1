﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KasenovAE.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            string alphabet = "йцкенгшщзхъуфывапролджэёячсмитьбю";
            foreach (char s in value)
            {
                if (!alphabet.Contains(s))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
