
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace final2016
{
    class Tower : SimpleSprite
    {
        float _damage;
        public int towerHealth = 100;
        private HealthBar healthbar;

        public Tower(Game g, string SpriteName, Vector2 StartPosition) : base(g,SpriteName,StartPosition)
        {
            
            Active = true;
            healthbar = new HealthBar(g, StartPosition);
            healthbar.health = towerHealth;
        }

        public float Damage
        {
            get
            {
                return _damage;
            }

            set
            {
                _damage = value;
            }
        }

        public override void Update(GameTime gameTime)
        {
            healthbar.health = towerHealth;
        }

    }
    
}
