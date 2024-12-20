using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogu_like
{
    internal class Weapon
    {
        static Random rnd = new Random();
        static string [] weaponNameList = new string[] {"phenix","curse dagger","giant killer","anigatana","lamer sieker","daedalus","pollaris","diamond sworld" };
        public string weaponName = weaponNameList[rnd.Next(0,8)];
        public int damage = rnd.Next(10, 61);
    }
}
