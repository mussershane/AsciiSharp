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

	public class Window : Buffer.Types.Drawable {
        public Border border;
        public string title;
		public List<IWindowable> drawList {get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
		public int zLayer {get; set; }

        public Window(int _X, int _Y, int _width, int _height, int _zLayer, string _title) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
			title = _title;
        }
    }

    public class Button : IWindowable {
        public Border border;
        public string title;
		public int zLayer {get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

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
		public int zLayer {get; set; }
        public int X { get; set; }
        public int Y { get; set; }
		public int width { get; set; }
		public int height { get; set; }

        public Field(int _X, int _Y, int _zLayer) {
            X = _X;
            Y = _Y;
            zLayer = _zLayer;
        }
    }

    public class InputBox : IWindowable {
		public int zLayer {get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public InputBox(int _X, int _Y, int _width, int _height, int _zLayer) {
            X = _X;
            Y = _Y;
            width = _width;
            height = _height;
            zLayer = _zLayer;
        }
    }

    public class CheckBox : IWindowable {
		public int zLayer {get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
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
		int zLayer {get; set; }
		int width { get; set; }
		int height { get; set; }
		int X { get; set; }
		int Y { get; set; }
    }
}
