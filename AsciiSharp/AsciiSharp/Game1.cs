using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using AsciiSharp.Art;

namespace AsciiSharp {
    public class Game1 : Game {
        public GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 FontSize;
        
        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            //$$$ Load last resolution when getting that far
            //UpdateSettings(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width/2, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height/2);
            UpdateSettings(800, 600);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize() {
            base.Initialize();
            GraphicsDevice.SamplerStates[0] = SamplerState.PointClamp;

        }

        protected override void LoadContent() {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //load fonts
            Fonts.default_8x14.font = Content.Load<SpriteFont>("Fonts/ConsoleFont_8x16");
            FontSize = Fonts.default_8x14.font.MeasureString("a");

        }

        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                Exit();
            }
            // TODO: Add your update logic here
            Buffer.Manager.Update(); //keep all visual elements updated and send them to the buffer before drawing
            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, null);
            for (int iX = 0; iX < Buffer.Settings.charAmtX; iX++) {
                for (int iY = 0; iY < Buffer.Settings.charAmtY; iY++) {
                    spriteBatch.DrawString(Fonts.default_8x14.font, Buffer.AsciiBuffer.buffer[iX, iY].ToString(), new Vector2(iX, iY), Color.Yellow);
                }
            }
            //FPS counter //spriteBatch.DrawString(defaultFont, (1 / gameTime.ElapsedGameTime.TotalSeconds).ToString(), new Vector2(0, 0), Color.Red);
            spriteBatch.End();
            base.Draw(gameTime);
        }
   
        public void UpdateSettings(int width, int height) {
            Buffer.Settings.charAmtX = (int)Math.Floor(width / FontSize.X);
            Buffer.Settings.charAmtY = (int)Math.Floor(height / FontSize.Y);

            graphics.PreferredBackBufferWidth = width;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = height;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            Buffer.AsciiBuffer.Update();
            
        }
    }
}
