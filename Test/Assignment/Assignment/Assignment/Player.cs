using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    class Player
    {
        Texture2D m_PlayerPistol;
        Texture2D m_PlayerRifle;

        Texture2D m_PlayerPistolLeft;
        Texture2D m_PlayerPistolRight;
        
        Texture2D m_PlayerRifleLeft;
        Texture2D m_PlayerRifleRight;

        Texture2D m_PlayerImage;

        Vector2 m_velocity;

        Rectangle m_PlayerPosition;

        float m_timer;

        Bullet_Manager m_ManagerReference;

        bool m_PlayerPistolEquiped;
        bool m_PlayerFacingLeft;
        bool m_hasJumped;
        bool m_falling;

        public Player(Bullet_Manager a_ManagerReference)
        {
            
            m_PlayerPistol = Game1.content.Load<Texture2D>("player pistol left");
            m_PlayerRifle = Game1.content.Load<Texture2D>("player rifle left");
            
            m_PlayerPistolLeft = Game1.content.Load<Texture2D>("player pistol left");
            m_PlayerPistolRight = Game1.content.Load<Texture2D>("player pistol right");
            
            m_PlayerRifleLeft = Game1.content.Load<Texture2D>("player rifle left");
            m_PlayerRifleRight = Game1.content.Load<Texture2D>("player rifle right");

            m_PlayerPistolEquiped = true;
            m_PlayerFacingLeft = true;
            m_hasJumped = false;
            m_falling = false;

            m_ManagerReference = a_ManagerReference;

            m_timer = 500;

            m_PlayerImage = m_PlayerPistol;
            m_PlayerPosition = new Rectangle(300, 725, 50, 41);
        }

        public void update()
        { 
        
        }

        public void draw()
        {
            Game1.spriteBatch.Draw(m_PlayerImage, m_PlayerPosition, Color.White);
        }

        public void PlayerMovement()
        {
           if ((Keyboard.GetState().IsKeyDown(Keys.Left))
               && m_PlayerPistolEquiped == true
               ||(Keyboard.GetState().IsKeyDown(Keys.A))
               && m_PlayerPistolEquiped == true)
           {
               m_PlayerPosition.X -= 7;
               m_PlayerPistol = m_PlayerPistolLeft;
               m_PlayerImage = m_PlayerPistol;
               m_PlayerFacingLeft = true;
           }
           else
           {
              if ((Keyboard.GetState().IsKeyDown(Keys.Left))
                 ||(Keyboard.GetState().IsKeyDown(Keys.A)))
               {
                  m_PlayerPosition.X -= 7;
                  m_PlayerRifle = m_PlayerRifleLeft;
                  m_PlayerImage = m_PlayerRifle;
                  m_PlayerFacingLeft = true;
               }
           }
   
           if ((Keyboard.GetState().IsKeyDown(Keys.Right))
               && m_PlayerPistolEquiped == true
              || (Keyboard.GetState().IsKeyDown(Keys.D))
               && m_PlayerPistolEquiped == true)
           {
               m_PlayerPosition.X += 7;
               m_PlayerPistol = m_PlayerPistolRight;
               m_PlayerImage = m_PlayerPistol;
               m_PlayerFacingLeft = false;
           }
           else
           {
               if ((Keyboard.GetState().IsKeyDown(Keys.Right))
               || (Keyboard.GetState().IsKeyDown(Keys.D)))
               {
                   m_PlayerPosition.X += 7;
                   m_PlayerRifle = m_PlayerRifleRight;
                   m_PlayerImage = m_PlayerRifle;
                   m_PlayerFacingLeft = false;
               }
           }

            if (m_PlayerPosition.X < 34)
            {
                m_PlayerPosition.X = 34;
            }

            if (m_PlayerPosition.X > 1196)
            {
                m_PlayerPosition.X = 1196;
            }

            if (m_PlayerPosition.Y > 800)
            {
                m_PlayerPosition.Y = -41;
            }

            m_PlayerPosition.X += (int)m_velocity.X;
            m_PlayerPosition.Y += (int)m_velocity.Y;

            if ((Keyboard.GetState().IsKeyDown(Keys.Up))
                && m_hasJumped==false
                && m_falling == false
                || (Keyboard.GetState().IsKeyDown(Keys.W))  
                && m_hasJumped == false
                && m_falling == false)
            {
                m_velocity.Y = -20;
                m_hasJumped = true;
                m_falling = true;
            }

            if (m_falling = true
                || m_hasJumped == true)
            { 
                int i = 1;
                m_velocity.Y += 1 *i;
            }
        }

        public void PlayerWeaponSwitch()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.D1)
                && m_PlayerFacingLeft == true)
            {
                m_PlayerImage = m_PlayerPistolLeft;
                m_PlayerPistolEquiped = true;
            }
            else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D1))
                {
                    m_PlayerImage = m_PlayerPistolRight;
                    m_PlayerPistolEquiped = true;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D2)
                && m_PlayerFacingLeft==true)
            {
                m_PlayerImage = m_PlayerRifleLeft;
                m_PlayerPistolEquiped = false;
            }
            else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D2))
                {
                    m_PlayerImage = m_PlayerRifleRight;
                    m_PlayerPistolEquiped = false;
                }
            }
        }

        public Rectangle rect
        {
            get { return m_PlayerPosition; }
        }

        public void NotFallingGround()
        {
            m_velocity.Y = 0;
            m_PlayerPosition.Y = 725;
            m_hasJumped = false;
            m_falling = false;
        }

        public void NotFallingMiddleBottom()
        {
            if (m_velocity.Y > 0)
            {
                m_velocity.Y = 0;
                m_PlayerPosition.Y = 537;
                m_hasJumped = false;
                m_falling = false;
            }
        }

        public void NotFallingMiddleLeftRight()
        {
            if (m_velocity.Y > 0)
            {
                m_velocity.Y = 0;
                m_PlayerPosition.Y = 374;
                m_hasJumped = false;
                m_falling = false;
            }
        }

        public void NotFallingMiddleTop()
        {
            if (m_velocity.Y > 0)
            {
                m_velocity.Y = 0;
                m_PlayerPosition.Y = 181;
                m_hasJumped = false;
                m_falling = false;
            }
        }

        public void PlayerShoot(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            { 
                
            }
        }
    }
}