using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class person
    {
        public int id;
        public Gender Type;

        public person() 
        {

        } 
        
        public person(int id) 
        {

        }

        public static bool operator==(person a , person b)
        {
            return a.id == b.id;
        } 
        
        public static bool operator!=(person a , person b)
        {
            return a.id != b.id;
        }

    }
}
