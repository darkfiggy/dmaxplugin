﻿using System;
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

        public static uint Playtime = 0x8CBBFD90;

        public static readonly Dictionary<string, uint> memkeys_FootprintPercentage = new Dictionary<string, uint>()
        {
                { "Cobalion", 0x4D50B655},
                { "Terrakion", 0x771E4c88},
                { "Virizion", 0xAD67A297}
        };

        public static readonly Dictionary<string, uint> memkeys_SwordsofJustice = new Dictionary<string, uint>()
        {
                { "Cobalion", 0xBB305227},
                { "Terrakion", 0x750C83A4},
                { "Virizion", 0x1A27DF2C},
                { "Keldeo", 0xA097DE31}
        };

        public static readonly Dictionary<string, uint> memkeys_Regis = new Dictionary<string, uint>()
        {
                { "Regirock", 0xEE3F84E6},
                { "Regice", 0xDAB3DD3A},
                { "Registeel", 0xEE1FD86E},
                { "Regigigas", 0xC4308A93},
                { "Regieleki", 0x4F4AEC32},
                { "Regidrago", 0x4F30F174}
        };

        public static readonly Dictionary<string, uint> memkeys_Birds = new Dictionary<string, uint>()
        {
            { "Galarian Articuno", 0x4CAB7DA6},
            { "Galarian Zapdos", 0x284CBECF},
            { "Galarian Moltres", 0xF1E493AA},
        };

        public static readonly Dictionary<string, uint> memkeys_CrownTundra_Misc = new Dictionary<string, uint>()
        {
            { "z_wr0301_i0401_COSMOG", 0x52F6F77F}
        };

        public static readonly Dictionary<string, uint> memkeys_MaxLairMisc = new Dictionary<string, uint>()
        {
            { "KMaxLairDisconnectStreak", 0x8EAEB8FF},
            { "KMaxLairEndlessStreak", 0x7F4B4B10},

            { "KMaxLairSpeciesID1Noted", 0x6F669A35},
            { "KMaxLairSpeciesID2Noted", 0x6F66951C},
            { "KMaxLairSpeciesID3Noted", 0x6F6696CF},

            { "KMaxLairPeoniaSpeciesHint", 0xF26B9151},

            { "KMaxLairRentalChoiceSeed", 0x0D74AA40},
        };

        public static readonly List<string> mlex_Sword = new List<string>()
        { "Ho-oh",
          "Latios",
          "Groudon",
          "Dialga",
          "Tornadus",
          "Reshiram",
          "Xerneas"
        };

        public static readonly List<string> mlex_Shield = new List<string>()
        { "Lugia",
          "Latias",
          "Kyogre",
          "Palkia",
          "Thundurus",
          "Zekrom",
          "Yveltal"
        };
        public static readonly Dictionary<string, uint> NationalDex = new Dictionary<string, uint>()
        {
            { "None", 0},
            { "Articuno", 144},
            { "Zapdos", 145},
            { "Moltres", 156},
            { "Mewtwo", 150},
            { "Raikou", 243},
            { "Entei", 244},
            { "Suicune", 245},
            { "Lugia", 249},
            { "Ho-oh", 250},
            { "Latias", 380},
            { "Latios", 381},
            { "Kyogre", 382},
            { "Groundon", 383},
            { "Rayquaza", 384},
            { "Uxie", 480},
            { "Mesprit", 481},
            { "Azelf", 482},
            { "Dialga", 483},
            { "Palkia", 484},
            { "Heatran", 485},
            { "Giratina", 487},
            { "Cresselia", 488},
            { "Tornadus", 641},
            { "Thundurus", 642},
            { "Reshiram", 643},
            { "Zekrom", 644},
            { "Landorus", 645},
            { "Kryurem", 646},
            { "Xerneas", 716},
            { "Yveltal", 717},
            { "Zygarde", 718},
            { "Tapu Koko", 785},
            { "Tapu Lele", 786},
            { "Tapu Bulu", 787},
            { "Tapu Fini", 788},
            { "Solgaleo", 791},
            { "Lunala", 792},
            { "Nihilego", 793},
            { "Buzzwole", 794 },
            { "Pheromosa", 795 },
            { "Xurkitree", 796 },
            { "Celesteela", 797 },
            { "Kartana", 798 },
            { "Guzzlord", 799 },
            { "Necrozma", 800 },
            { "Stakataka", 805 },
            { "Blacephalon", 806 }
        };


    }
}
