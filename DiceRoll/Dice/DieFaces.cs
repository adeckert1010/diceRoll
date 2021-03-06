﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll.Dice
{
    class DieFaces
    {
        public static Dictionary<int, string> dieFaceDictionary = new Dictionary<int, string>()
            {

                { 1, @"╔════════════════════════╗
║                        ║
║                        ║
║                        ║
║                        ║
║          ████          ║
║          ████          ║
║                        ║
║                        ║
║                        ║
║                        ║
╚════════════════════════╝" },
                { 2, @"╔════════════════════════╗
║                        ║
║                ████    ║
║                ████    ║
║                        ║
║                        ║
║                        ║
║                        ║
║    ████                ║
║    ████                ║
║                        ║
╚════════════════════════╝" },
                { 3, @"╔════════════════════════╗
║                        ║
║                ████    ║
║                ████    ║
║                        ║
║          ████          ║
║          ████          ║
║                        ║
║    ████                ║
║    ████                ║
║                        ║
╚════════════════════════╝" },
                { 4, @"╔════════════════════════╗
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
║                        ║
║                        ║
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
╚════════════════════════╝"},
                { 5, @"╔════════════════════════╗
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
║          ████          ║
║          ████          ║
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
╚════════════════════════╝"},
                { 6, @"╔════════════════════════╗
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
║    ████        ████    ║
║    ████        ████    ║
║                        ║
╚════════════════════════╝"},
            {7, @"╔════════════════════════╗
║                        ║
║         _______        ║
║        |  ___  |       ║
║        |_/  / /        ║
║            / /         ║
║           / /          ║
║          /_/           ║
║                        ║
║                        ║
║                        ║
╚════════════════════════╝"}
            };
    }
}
