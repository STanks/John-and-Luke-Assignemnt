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
        public bool m_resetGame;

        public MenuState()
        {
            m_resetGame = false;
        }

        public void update()
        {
            if (Mouse.GetState().X > 441
                && Mouse.GetState().X < 441 + 400
                && Mouse.GetState().Y > 360
                && Mouse.GetState().Y < 360 + 95)
            {
                //play_button_idle = play_button_click;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    //GameAndMenuState = GameAndMenu.GameState;
                }
            }
            else
            {
                //play_button_idle = play_button;
            }

            if (Mouse.GetState().X > 441
                && Mouse.GetState().X < 441 + 400
                && Mouse.GetState().Y > 587
                && Mouse.GetState().Y < 587 + 95)
            {
                //quit_button_idle = quit_button_click;
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                    Game1.Quit();
            }
            else
            {
                //quit_button_idle = quit_button;
            }
        }

        public void draw()
        { 
                    
        }
    }
}
