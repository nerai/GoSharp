﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Go
{
    /// <summary>
    /// Represents a pair of board coordinates (x and y).
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// The X value of the coordinate.
        /// </summary>
        public int x;

        /// <summary>
        /// The Y value of the coordinate.
        /// </summary>
        public int y;

        /// <summary>
        /// Constructs a Point object from the specified coordinates.
        /// </summary>
        /// <param name="xx">The X coordinate.</param>
        /// <param name="yy">The Y coordinate.</param>
        public Point(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }

        public override int GetHashCode()
        {
            return (x << 5) + y;
        }
    }
}
