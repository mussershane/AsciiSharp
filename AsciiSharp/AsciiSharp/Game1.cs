using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using AsciiSharp.Art;

namespace AsciiSharp {
    public class Game1 : Game {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Game1() {
            graphics = new GraphicsDeviceManager(this);
            //$$$ Load last resolution when getting that far
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width/2;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height/2;   // set this value to the desired height of your window
            graphics.ApplyChanges();

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

        }

        protected override void UnloadContent() {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime) {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)) {
                Exit();
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, null);
            for (int i = 250; i < 270; i++) {
                spriteBatch.DrawString(Fonts.default_8x14.font, (char)i + " ", new Vector2((i - 250) * 8, 50), Color.Yellow);
            }
            spriteBatch.DrawString(Fonts.default_8x14.font, "(" + Fonts.default_8x14.size.X.ToString() + ", " + Fonts.default_8x14.size.Y.ToString() + ")" + " [/]^_`abcdefg hello here we go!" + (char)219 + Glyphs.Block25 + Glyphs.Block50 + Glyphs.Block75 + Glyphs.Block100, new Vector2(0, 0), Color.Yellow);

            //FPS counter
            //spriteBatch.DrawString(defaultFont, (1 / gameTime.ElapsedGameTime.TotalSeconds).ToString(), new Vector2(0, 0), Color.Red);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
