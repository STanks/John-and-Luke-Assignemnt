using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    class Bullet_Manager
    {
        List<Player_Bullet> m_PlayerBulletList;

        public Bullet_Manager()
        { 
            m_PlayerBulletList=new List<Player_Bullet>();
        }

        public void update()
        {
            for (int i = 0; i < m_PlayerBulletList.Count; i++)
            {
                m_PlayerBulletList[i].update();
            }
        }

        public void draw()
        {
            for (int i = 0; i < m_PlayerBulletList.Count; i++)
            {
                m_PlayerBulletList[i].draw();
            }            
        }

        public List<Player_Bullet> PlayerList
        {
            get { return m_PlayerBulletList; }
        }
    }
}
