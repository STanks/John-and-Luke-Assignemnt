using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    class MenuState
    {
        Texture2D m_menu;
        Texture2D m_PlayButton;
        Texture2D m_PlayButtonIdle;
        Texture2D m_PlayButtonClick;
        Texture2D m_HelpButton;
        Texture2D m_HelpButtonIdle;
        Texture2D m_HelpButtonClick;
        Texture2D m_HighscoreButton;
        Texture2D m_HighscoreButtonIdle;
        Texture2D m_HighscoreButtonClick;
        Texture2D m_QuitButton;
        Texture2D m_QuitButtonIdle;
        Texture2D m_QuitButtonClick;
        public bool m_resetGame;

        public MenuState()
        {
            m_resetGame = false;
            m_menu = Game1.content.Load<Texture2D>("menu");
            
            m_PlayButton = Game1.content.Load<Texture2D>("play button");
            m_HelpButton = Game1.content.Load<Texture2D>("help button");
            m_HighscoreButton = Game1.content.Load<Texture2D>("highscore button");
            m_QuitButton = Game1.content.Load<Texture2D>("quit button");
           
            m_PlayButtonIdle = Game1.content.Load<Texture2D>("play button");
            m_HelpButtonIdle = Game1.content.Load<Texture2D>("help button");
            m_HighscoreButtonIdle = Game1.content.Load<Texture2D>("highscore button");
            m_QuitButtonIdle = Game1.content.Load<Texture2D>("quit button");
           
            m_PlayButtonClick = Game1.content.Load<Texture2D>("button play click");
            m_HelpButtonClick = Game1.content.Load<Texture2D>("button help click");
            m_HighscoreButtonClick = Game1.content.Load<Texture2D>("button highscore click");
            m_QuitButtonClick = Game1.content.Load<Texture2D>("button quit click");
        }

        public void update()
        {
            if (Mouse.GetState().X > 452
                && Mouse.GetState().X < 452 + 350
                && Mouse.GetState().Y > 291
                && Mouse.GetState().Y < 291 + 75)
            {
                m_PlayButton = m_PlayButtonClick;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    Game1.State = Game1.States.Game;
                }
            }
            else
            {
                m_PlayButton = m_PlayButtonIdle;
            }

            if (Mouse.GetState().X > 452
                && Mouse.GetState().X < 452 + 350
                && Mouse.GetState().Y > 386
                && Mouse.GetState().Y < 386 + 75)
            {
                m_HelpButton = m_HelpButtonClick;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    Game1.State = Game1.States.Instructions;
                }
            }
            else
            {
                m_HelpButton = m_HelpButtonIdle;
            }

            if (Mouse.GetState().X > 452
                && Mouse.GetState().X < 452 + 350
                && Mouse.GetState().Y > 481
                && Mouse.GetState().Y < 481 + 75)
            {
                m_HighscoreButton = m_HighscoreButtonClick;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    Game1.State = Game1.States.Highscore;
                }
            }
            else
            {
                m_HighscoreButton = m_HighscoreButtonIdle;
            }

            if (Mouse.GetState().X > 452
                && Mouse.GetState().X < 452 + 350
                && Mouse.GetState().Y > 577
                && Mouse.GetState().Y < 577 + 75)
            {
                m_QuitButton = m_QuitButtonClick;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    Game1.Quit();
            }
            else
            {
                m_QuitButton = m_QuitButtonIdle;
            }

        }

        public void draw()
        {
            Game1.spriteBatch.Draw(m_menu, new Rectangle(0, 0, 1280, 800), Color.White);
            Game1.spriteBatch.Draw(m_PlayButton, new Rectangle(452, 291, 350, 75), Color.White);
            Game1.spriteBatch.Draw(m_HelpButton, new Rectangle(452, 386, 350, 75), Color.White);
            Game1.spriteBatch.Draw(m_HighscoreButton, new Rectangle(452, 481, 350, 75), Color.White);
            Game1.spriteBatch.Draw(m_QuitButton, new Rectangle(452, 577, 350, 75), Color.White);
        }
    }
}
