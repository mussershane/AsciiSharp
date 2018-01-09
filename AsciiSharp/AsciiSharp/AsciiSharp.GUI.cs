using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiSharp.GUI {
    public class Border {
        public char topLeft;
        public char topRight;
        public char botLeft;
        public char botRight;
        public char vert;
        public char horiz;
    }

    public class Window {
        public Border border;
        public string title;
        public int width { get; private set; }
        public int height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int zLayer; 

        public Window(int _X, int _Y, int _width, int _height, int _zLayer, string _title) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
        }
    }

    public class Button : IWindowable {
        public Border border;
        public string title;
        public int zLayer;
        public int width { get; private set; }
        public int height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Button(int _X, int _Y, int _width, int _height, int _zLayer) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
        }
    }

    public class Field : IWindowable {
        public string contents;
        public int zLayer;
        public int X { get; private set; }
        public int Y { get; private set; }

        public Field(int _X, int _Y, int _width, int _height, int _zLayer) {
            X = _X;
            Y = _Y;
            zLayer = _zLayer;
        }
    }

    public class InputBox : IWindowable {
        public int zLayer;
        public int width { get; private set; }
        public int height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }


        public InputBox(int _X, int _Y, int _width, int _height, int _zLayer) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
        }
    }

    public class CheckBox : IWindowable {
        public int zLayer;
        public int width { get; private set; }
        public int height { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public char check;
        public char nocheck;
        public bool isChecked;

        public CheckBox(int _X, int _Y, int _width, int _height, int _zLayer) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
        }
    }

    public interface IWindowable {

    }
}
