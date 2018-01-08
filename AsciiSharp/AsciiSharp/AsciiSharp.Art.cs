using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiSharp.Art {
    public static class Fonts {
        public static Font default_8x14 = new Font();

    }

    public class Font {
        public Vector2 size { get; private set; }

        public SpriteFont font {
            get { return _font; }
            set { _font = value;
                  size = _font.MeasureString("A"); }
        }

        private SpriteFont _font;

        public Font() {
            size = new Vector2(0,0);
            _font = null;
        }

    }

    public static class Glyphs {
        public const char House = (char)127;
        public const char Cent = (char)155;
        public const char Pound = (char)156;
        public const char Yen = (char)157;
        public const char Peseta = (char)158;
        public const char Florin = (char)159;
        public const char SuperScript_A = (char)166;
        public const char Degree = (char)167;
        public const char InvertedQuestion = (char)168;
        public const char Half = (char)171;
        public const char Quarter = (char)172;
        public const char InvertedExlamation = (char)173;
        public const char DblArrowsLeft = (char)174;
        public const char DblArrowsRight = (char)175;
        public const char Block25 = (char)176;
        public const char Block50 = (char)177;
        public const char Block75 = (char)178;
        public const char Block100 = (char)219;

        //thin line
        public const char Wire_Vert = (char)179;
        public const char Wire_Horiz = (char)196;
        public const char Wire_TopLeft = (char)191;
        public const char Wire_TopRight = (char)218;
        public const char Wire_BotLeft = (char)217;
        public const char Wire_BotRight = (char)192;
        public const char Wire_BotHoriz = (char)193;
        public const char Wire_TopHoriz = (char)194;
        public const char Wire_VertRight = (char)195;
        public const char Wire_VertLeft = (char)180;
        public const char Wire_Cross = (char)197;

        //large pipe 
        public const char Pipe_Horiz = (char)205;
        public const char Pipe_Vert = (char)186;
        public const char Pipe_TopLeft = (char)187;
        public const char Pipe_TopRight = (char)201;
        public const char Pipe_BotLeft = (char)188;
        public const char Pipe_BotRight = (char)200;
        public const char Pipe_BotHoriz = (char)202;
        public const char Pipe_TopHoriz = (char)203;
        public const char Pipe_VertRight = (char)204;
        public const char Pipe_VertLeft = (char)185;
        public const char Pipe_Cross = (char)206;
        
    }
}
