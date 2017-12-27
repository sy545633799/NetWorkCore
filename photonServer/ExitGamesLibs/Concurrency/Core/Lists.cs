﻿using System;
using System.Collections.Generic;

namespace ExitGames.Concurrency.Core
{
    internal static class Lists
    {
        public static void Swap(ref List<Action> a, ref List<Action> b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}
