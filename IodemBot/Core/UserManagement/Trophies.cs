﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IodemBot.Core.UserManagement
{
    public class TrophyCase
    {
        public List<Trophy> trophies { get; set; } = new List<Trophy>();
    }

    public class Trophy
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public DateTime ObtainedOn { get; set; }
    }
}