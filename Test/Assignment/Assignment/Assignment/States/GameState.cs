using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment
{
    class GameState
    {
        Player player;
        HUD hud;
        Collision_Manager CollisionManager;

        public GameState()
        {
            player = new Player();
            hud = new HUD();
            CollisionManager = new Collision_Manager(player, hud);
        }

        public void update()
        {
            player.PlayerMovement();
            player.PlayerWeaponSwitch();
            CollisionManager.update();
        }

        public void draw()
        {
            hud.draw();
            player.draw();
        }
    }
}
