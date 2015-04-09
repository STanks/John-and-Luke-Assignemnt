using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    class HUD
    {
        Texture2D m_hud;
        Texture2D m_Platform;
        Rectangle m_PlatformMiddleLeft;
        Rectangle m_PlatformMiddleRight;
        Rectangle m_PlatformMiddleTop;
        Rectangle m_PlatformMiddleBottom;
        Rectangle m_PlatformGroundLeft;
        Rectangle m_PlatformGroundRight;

        public HUD()
        {
            m_hud = Game1.content.Load<Texture2D>("hud");
            m_Platform = Game1.content.Load<Texture2D>("platform ground");
            m_PlatformGroundLeft = new Rectangle(0, 766, 550, 34);
            m_PlatformGroundRight = new Rectangle(729, 766, 550, 34);
            m_PlatformMiddleBottom = new Rectangle(390, 578, 500, 35);
            m_PlatformMiddleLeft = new Rectangle(35, 415, 500, 35);
            m_PlatformMiddleRight = new Rectangle(754, 415, 500, 35);
            m_PlatformMiddleTop = new Rectangle(390, 222, 500, 34);
        }

        public void update()
        {

        }

        public void draw()
        {
            Game1.spriteBatch.Draw(m_hud, new Rectangle(0, 0, 1280, 800), Color.White);
            Game1.spriteBatch.Draw(m_Platform, m_PlatformGroundLeft, Color.White);
            Game1.spriteBatch.Draw(m_Platform, m_PlatformGroundRight, Color.White);
            Game1.spriteBatch.Draw(m_Platform, m_PlatformMiddleBottom, Color.White);
            Game1.spriteBatch.Draw(m_Platform,m_PlatformMiddleLeft, Color.White);
            Game1.spriteBatch.Draw(m_Platform, m_PlatformMiddleRight, Color.White);
            Game1.spriteBatch.Draw(m_Platform, m_PlatformMiddleTop, Color.White);
        }

        public Rectangle RectGroundLeft
        {
            get { return m_PlatformGroundLeft; }
        }

        public Rectangle RectGroundRight
        {
            get { return m_PlatformGroundRight; }
        }

        public Rectangle RectMiddleBottom
        {
            get { return m_PlatformMiddleBottom; }
        }

        public Rectangle RectMiddleLeft
        {
            get { return m_PlatformMiddleLeft; }
        }

        public Rectangle RectMiddleRight
        {
            get { return m_PlatformMiddleRight; }
        }

        public Rectangle RectMiddleTop
        {
            get { return m_PlatformMiddleTop; }
        }
    }
}
