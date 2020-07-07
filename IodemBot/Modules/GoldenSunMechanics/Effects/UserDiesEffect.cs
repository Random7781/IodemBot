﻿using IodemBot.Modules.ColossoBattles;
using System.Collections.Generic;

namespace IodemBot.Modules.GoldenSunMechanics
{
    internal class UserDiesEffect : Effect
    {
        public override string Type { get; } = "UserDies";

        public UserDiesEffect()
        {
            ActivationTime = TimeToActivate.beforeDamge;
        }

        public override List<string> Apply(ColossoFighter User, ColossoFighter Target)
        {
            if (!User.IsAlive)
            {
                return new List<string>();
            }

            User.Kill();
            return new List<string>() { $"{User.Name} goes down from exhaustion." };
        }

        public override string ToString()
        {
            return $"User takes itself down";
        }
    }
}