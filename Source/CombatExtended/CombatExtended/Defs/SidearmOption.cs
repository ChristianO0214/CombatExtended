﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;
using UnityEngine;

namespace CombatExtended
{
    public class SidearmOption
    {
        FloatRange sidearmCount = FloatRange.One;
        FloatRange sidearmMoney = FloatRange.Zero;
        FloatRange magazineCount = FloatRange.Zero;
        List<string> weaponTags;
        float generateChance = 1;
    }
}
