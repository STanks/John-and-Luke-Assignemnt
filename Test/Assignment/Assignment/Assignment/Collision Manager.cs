using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class Collision_Manager
    {
        Player m_playerRef;
        HUD m_hudRef;

        public Collision_Manager(Player a_playerRef, HUD a_hudRef)
        {
            m_hudRef = a_hudRef;
            m_playerRef = a_playerRef;
        }

        public void update()
        {
            if (m_playerRef.rect.Intersects(m_hudRef.RectGroundLeft))
            {
                m_playerRef.NotFallingGround();
            }

            if (m_playerRef.rect.Intersects(m_hudRef.RectGroundRight))
            {
                m_playerRef.NotFallingGround();
            }

            if (m_playerRef.rect.Intersects(m_hudRef.RectMiddleBottom))
            {
                m_playerRef.NotFallingMiddleBottom();
            }

            if (m_playerRef.rect.Intersects(m_hudRef.RectMiddleLeft))
            {
                m_playerRef.NotFallingMiddleLeftRight();
            }

            if (m_playerRef.rect.Intersects(m_hudRef.RectMiddleRight))
            {
                m_playerRef.NotFallingMiddleLeftRight();
            }

            if (m_playerRef.rect.Intersects(m_hudRef.RectMiddleTop))
            {
                m_playerRef.NotFallingMiddleTop();
            }
        }
    }
}
