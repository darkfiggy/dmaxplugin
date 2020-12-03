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

        public static Dictionary<string, uint> memkeys_FootprintPercentage = new Dictionary<string, uint>() 
        {
                { "Cobalion", 0x4D50B655},
                { "Terrakion", 0x771E4c88},
                { "Virizion", 0xAD67A297}
        };

        public static Dictionary<string, uint> memkeys_SwordsofJustice = new Dictionary<string, uint>()
        {
                { "Cobalion", 0xBB305227},
                { "Terrakion", 0x750C83A4},
                { "Virizion", 0x1A27DF2C},
                { "Keldeo", 0xA097DE31}
        };

        public static Dictionary<string, uint> memkeys_Regis = new Dictionary<string, uint>()
        {
                { "Regirock", 0xEE3F84E6},
                { "Regice", 0xDAB3DD3A},
                { "Registeel", 0xEE1FD86E},
                { "Regigigas", 0xC4308A93},
                { "Regieleki", 0x4F4AEC32},
                { "Regidrago", 0x4F30F174}
        };


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

        public static uint[] NationalDexEntries = new uint[]
{
            144, //Articuno
            145, //Zapdos
            156, //Moltres
            150, //Mewtwo
            243, //Raikou
            244, //Entei
            245, //Suicune
            249, //Lugia
            250, //Ho-oh
            380, //Latias
            381, //Latios
            382, //Kyogre
            383, //Groudon
            384, //Rayquaza
            480, //Uxie
            481, //Mesprit
            482, //Azelf
            483, //Dialga
            484, //Palkia
            485, //Heatran
            487, //Giratina
            488, //Cresselia
            641, //Tornadus
            642, //Thundurus
            643, //Reshiram
            644, //Zekrom
            645, //Landorus
            646, //Kyurem
            716, //Xerneas
            717, //Yveltal
            718, //Zygarde
            785, //Tapu Koko
            786, //Tapu Lele
            787, //Tapu Bulu
            788, //Tapu Fini
            791, //Solgaleo
            792, //Lunala
            793, //Nihilego
            794, //Buzzwole
            795, //Pheromosa
            796, //Xurkitree
            797, //Celesteela
            798, //Kartana
            799, //Guzzlord
            800, //Necrozma
            805, //Stakataka
            806, //Blacephalon
};
    }
}
