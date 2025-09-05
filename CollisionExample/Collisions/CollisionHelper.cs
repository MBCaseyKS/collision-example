using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollisionExample.Collisions
{
    public static class CollisionHelper
    {
        /// <summary>
        /// Checks if two bounding circles collide.
        /// </summary>
        /// <param name="a">The first circle.</param>
        /// <param name="b">The second circle.</param>
        /// <returns>True for collision, false for not.</returns>
        public static bool Collides(BoundingCircle a, BoundingCircle b)
        {
            return Math.Pow(a.Radius + b.Radius, 2) >= 
                Math.Pow(a.Center.X - b.Center.X, 2) + 
                Math.Pow(a.Center.Y - b.Center.Y, 2);
        }

        /// <summary>
        /// Checks if two bounding rectangles collide.
        /// </summary>
        /// <param name="a">The first rectangle.</param>
        /// <param name="b">The second rectangle.</param>
        /// <returns>True for collision, false for not.</returns>
        public static bool Collides(BoundingRectangle a, BoundingRectangle b)
        {
            return !(a.Right < b.Left || 
                a.Left > b.Right || 
                a.Top > b.Bottom || 
                a.Bottom < b.Top);
        }

        /// <summary>
        /// Checks if a BoundingCircle collides with a BoundingRectangle.
        /// </summary>
        /// <param name="c">The bounding circle.</param>
        /// <param name="r">The bounding rectangle.</param>
        /// <returns>True for collision, false for not.</returns>
        public static bool Collides(BoundingCircle c, BoundingRectangle r)
        {
            float nearestX = MathHelper.Clamp(c.Center.X, r.Left, r.Right);
            float nearestY = MathHelper.Clamp(c.Center.Y, r.Top, r.Bottom);
            return Math.Pow(c.Radius, 2) >=
                Math.Pow(c.Center.X - nearestX, 2) +
                Math.Pow(c.Center.Y - nearestY, 2);
        }

        /// <summary>
        /// Checks if a BoundingCircle collides with a BoundingRectangle.
        /// </summary>
        /// <param name="c">The bounding circle.</param>
        /// <param name="r">The bounding rectangle.</param>
        /// <returns>True for collision, false for not.</returns>
        public static bool Collides(BoundingRectangle r, BoundingCircle c) => Collides(c, r);
    }
}
