﻿using System;
using System.Collections.Generic;
using System.Text;
using Slipe.MTADefinitions;
using System.Numerics;
using Slipe.Shared.Elements;
using Slipe.Shared.Utilities;
using Slipe.Shared.Radar;

namespace Slipe.Server
{
    /// <summary>
    /// Class representing radar areas
    /// </summary>
    public class RadarArea : SharedRadarArea
    {
        /// <summary>
        /// Create a radar area from an MTA radar area element
        /// </summary>
        public RadarArea(MTAElement element) : base (element) { }

        /// <summary>
        /// Create a radar area from all the createRadarArea parameters
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimensions, Color color, Element visibleTo = null) : base (position, dimensions, color, visibleTo) { }

        /// <summary>
        /// Create a radar area only from dimensions
        /// </summary>
        public RadarArea(Vector2 position, Vector2 dimension) : base (position, dimension) { }
    }
}
