using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CollisionExample.Collisions
{
    /// <summary>
    /// A bounding rectangle for collision detection
    /// </summary>
    public struct BoundingRectangle
    {
        /// <summary>
        /// The X of the top left of the rectangle.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y of the top left of the rectangle.
        /// </summary>
        public float Y;

        public float Width;

        public float Height;

        public float Left => X;

        public float Right => X + Width;

        public float Top => Y;

        public float Bottom => Y + Height;

        public BoundingRectangle(float x, float y, float width, float height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public BoundingRectangle(Vector2 position, float width, float height)
        {
            this.X = position.X;
            this.Y = position.Y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Checks if this rectangle collides an other.
        /// </summary>
        /// <param name="other">The other rectangle.</param>
        /// <returns>True if colliding, false otherwise.</returns>
        public bool CollidesWith(BoundingRectangle other) => CollisionHelper.Collides(this, other);

        /// <summary>
        /// Checks if this rectangle collides with a circle.
        /// </summary>
        /// <param name="other">The circle.</param>
        /// <returns>Returns true if colliding, false otherwise.</returns>
        public bool CollidesWith(BoundingCircle other) => CollisionHelper.Collides(this, other);
    }
}
