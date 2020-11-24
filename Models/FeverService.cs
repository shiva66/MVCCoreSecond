using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssinment2.Models
{
    public class FeverService
    {
        static int feverTemp= 37;

        string feverString;
        static void fever(string feverString, int temp, int feverTemp)
        {
            if (temp > feverTemp)
            {
                feverString = "You have fever";
                
            }
            else
            {
                feverString = "You don´t have a fever";
            }
            
        }

        //static List<Fever> feverList = new List<Fever>() 
        //{
        //    new Fever() { Temp = 37},


        //};

        //public void Add(int temp)
        //{
        //    feverList.Add(new Fever() { Temp = temp });
        //}

        //public List<Fever> All()
        //{
        //    return feverList;
        //}

  
    }
}
