﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;
using RogueSharp;
using TEXTGAMEAPI;
using TEXTGAMEAPI.Enemies;
using Entities;

namespace TextGame.Interfaces {
    public interface IDrawable {
        RLColor Color {
            get; set;
        }

        char Symbol {
            get; set;
        }

        int X {
            get; set;
        }

        int Y {
            get; set;
        }

        void Draw(RLConsole console, IMap map);
    }
}
