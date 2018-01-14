using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiSharp.Buffer{
    public static class Manager {
		public static List<Types.Drawable> backgroundList = new List<Types.Drawable>();
		public static List<Types.Drawable> interactableList = new List<Types.Drawable>();
		public static List<Types.Drawable> playerList = new List<Types.Drawable>();
		public static List<Types.Drawable> guiList = new List<Types.Drawable>();
		
        public static void Draw() {
            DrawBackground(); //first
			DrawInteractables(); //second
			DrawPlayer(); //third
			DrawGUI(); //last (top-most)
        }

        private static void DrawGUI() {
			//GUI draws on top

			if(guiList.Count == 0 || guiList == null){
				return;
			}
			
			foreach(Types.Drawable curObj in guiList){
				AsciiBuffer.buffer[curObj.X, curObj.Y].character = curObj.character;
			}
        }

        private static void DrawPlayer() {
			//Player objects draw over Interactables/Background

			int prevLayer = 0; //the previous layer that was being drawn to in the current cell

			if(playerList.Count == 0 || playerList == null){
				return;
			}

			foreach(Types.Drawable curObj in playerList){
				prevLayer = AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer; //set previous layer to the layer that was in the existing cell

				if(AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer > prevLayer){
					//compare layers to see if the object should be drawn above 
					AsciiBuffer.buffer[curObj.X, curObj.Y].character = curObj.character;
				}
			}
        }

        private static void DrawInteractables() {
			//Interactables draw over the Background
			int prevLayer = 0; //the previous layer that was being drawn to in the current cell

			if(interactableList.Count == 0 || interactableList == null){
				return;
			}

			foreach(Types.Drawable curObj in guiList){
				if(AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer > prevLayer){
					AsciiBuffer.buffer[curObj.X, curObj.Y].character = curObj.character;
				}
				prevLayer = AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer; //set previous layer to the layer that was in the existing cell
			}
        }

        private static void DrawBackground() {
			//Background is always drawn first
			int prevLayer = 0; //the previous layer that was being drawn to in the current cell

			if(backgroundList.Count == 0 || backgroundList == null){
				return;
			}

			foreach(Types.Drawable curObj in guiList){
				if(AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer > prevLayer){
					AsciiBuffer.buffer[curObj.X, curObj.Y].character = curObj.character;
				}
				prevLayer = AsciiBuffer.buffer[curObj.X, curObj.Y].zLayer; //set previous layer to the layer that was in the existing cell
			}
        }
    }

    public static class AsciiBuffer {
        public static Types.Cell[,] buffer = new Types.Cell[Settings.charAmtX, Settings.charAmtY];

		static AsciiBuffer(){
			for (int iX = 0; iX < Settings.charAmtX; iX++) {
				for (int iY = 0; iY < Settings.charAmtY; iY++) {
					buffer[iX, iY] = new Types.Cell(iX, iY);
				}
			}
		}

        public static void Update() {
            buffer = new Types.Cell[Settings.charAmtX, Settings.charAmtY];
			for (int iX = 0; iX < Settings.charAmtX; iX++) {
				for (int iY = 0; iY < Settings.charAmtY; iY++) {
					buffer[iX, iY] = new Types.Cell(iX, iY);
				}
			}
        }

    }

    public static class Settings {
        public static int charAmtX;
        public static int charAmtY;

    }

    public static class Types {
		public abstract class Drawable : IComparable<Drawable>{
			public int X {get; set; }
			public int Y {get; set; }
			public int zLayer {get; set; }
			public char character {get; set; }
			
			public int CompareTo(Drawable _value){
				if(_value.zLayer < zLayer) {
					return -1;
				}
				if(_value.zLayer > zLayer) {
					return 1;
				}
				return 0;
			}
		}

        public class Cell {
            public int X { get; private set; }
            public int Y { get; private set; }
			public int zLayer {get; set; }
            public char character = ' ';


            public Cell(int _X, int _Y) {
                X = _X;
                Y = _Y;
				zLayer = 0; //default to 0
            }
        }
    }
}
