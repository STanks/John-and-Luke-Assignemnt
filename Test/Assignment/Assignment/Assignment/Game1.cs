using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        public enum States
        {
            Menu,
            Game,
            GameOver,
            Pause,
            Instructions,
            Highscore,
        };

        public static Game GameInstance;

        public static States State;
        MenuState Menu;
        GameState Game;
        GameOverState GameOver;
        PauseState Pause;
        InstructionState Instructions;
        HighscoreState Highscore;

        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        public static ContentManager content;

        Texture2D Background;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 800;
            Content.RootDirectory = "Content";
            GameInstance = this;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            content = Content;
            IsMouseVisible = true;

            Background = Content.Load<Texture2D>("Background");

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Game = new GameState();
            Menu = new MenuState();
            Instructions = new InstructionState();
            GameOver = new GameOverState();
            Pause = new PauseState();
            Highscore = new HighscoreState();

            State = States.Menu;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        public static void Quit()
        {
            GameInstance.Exit();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            switch (State)
            {
                case States.Menu:
                    {
                        Menu.update();
                        break;
                    }

                case States.Game:
                    {
                        Game.update();
                        break;
                    }

                case States.GameOver:
                    {
                        GameOver.update();
                        break;
                    }

                case States.Pause:
                    {
                        Pause.update();
                        break;
                    }

                case States.Instructions:
                    {
                        Instructions.update();
                        break;
                    }

                case States.Highscore:
                    {
                        Highscore.update();
                        break;
                    }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            spriteBatch.Draw(Background, new Rectangle(0, 0, 1280, 800), Color.White);
            
            switch (State)
            {
                case States.Menu:
                    {
                        Menu.draw();
                        break;
                    }

                case States.Game:
                    {
                        Game.draw();
                        break;
                    }

                case States.GameOver:
                    {
                        GameOver.draw();
                        break;
                    }

                case States.Pause:
                    {
                        Pause.draw();
                        break;
                    }

                case States.Instructions:
                    {
                        Instructions.draw();
                        break;
                    }

                case States.Highscore:
                    {
                        Highscore.draw();
                        break;
                    }
            }
            
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
