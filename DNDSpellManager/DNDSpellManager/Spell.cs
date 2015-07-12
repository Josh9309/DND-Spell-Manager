using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDSpellManager
{
    class Spell
    {
        #region Attributes
        //attributes
        string spellName;
        int lvl;
        string type;
        string duration;
        int range;
        int castTime;
        string description;
        #endregion 

        #region Properties

        #endregion

        #region Constructor
        //constructor
        public Spell(string name, int level, string spelltype, string spDuration, int spRange, int spCastTime, string descript)
        {
            spellName = name;
            lvl = level;
            type = spelltype;
            duration = spDuration;
            range = spRange;
            castTime = spCastTime;
            description = descript;
        }
        #endregion

        #region Methods
        public string GetInfo()
        {
            return description;
        }
        #endregion methods

    }
}
