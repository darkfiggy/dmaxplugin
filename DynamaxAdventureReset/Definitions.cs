using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKHeX.Core;

namespace DynamaxAdventureReset
{

    public static class Definitions
    {

        /// <summary>
        /// Which pattern was drawn for which regi, this should match the given regi
        /// </summary>
        public static uint KRegielekiOrRegidragoPattern = 0xCF90B39A;

        /// <summary>
        /// Memory keys for the regis
        /// </summary>
        public static uint[] RegiKeys = new uint[]
        {
            0xEE3F84E6, //Regirock
            0xDAB3DD3A, //Regice
            0xEE1FD86E, //Registeel
            0xC4308A93, //Regigigas

            0x4F4AEC32, //Regieleki
            0x4F30F174 //Regidrago
        };
    }
}
