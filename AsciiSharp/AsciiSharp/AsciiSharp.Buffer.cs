using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AsciiSharp.Buffer{
    public static class Manager {

        public static void Update() {
            UpdateGUI();
            UpdatePlayer();
            UpdateInteractables();
            UpdateBackground();
        }

        private static void UpdateGUI() {
            
        }

        private static void UpdatePlayer() {

        }

        private static void UpdateInteractables() {

        }

        private static void UpdateBackground() {

        }

    }

    public static class AsciiBuffer {
        public static Types.Cell[,] buffer = new Types.Cell[Settings.charAmtX, Settings.charAmtY];

        public static void Update() {
            buffer = new Types.Cell[Settings.charAmtX, Settings.charAmtY];
        }

    }

    public static class Settings {
        public static int charAmtX;
        public static int charAmtY;

    }

    public static class Types {
        public class Cell {
            public int X { get; private set; }
            public int Y { get; private set; }
            public char avatar;


            public Cell(int _X, int _Y) {
                X = _X;
                Y = _Y;
            }
        }
    }
}
