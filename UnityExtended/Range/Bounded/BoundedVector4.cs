﻿using System;
using UnityEngine;

namespace UnityExtended
{
    /// <summary>
    /// Class for bounded Vector4.
    /// </summary>
    [Serializable]
    public class BoundedVector4 : BoundedVector<Vector4>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public BoundedVector4(Vector4 start, Vector4 end) : base(start, end) { }

        /// <summary>
        /// 
        /// </summary>
        public override Vector4 Direction { get { return max - min; } }

        /// <summary>
        /// 
        /// </summary>
        public override float Distance { get { return Direction.magnitude; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override Vector4 Lerp(float t)
        {
            return Vector4.Lerp(min, max, t);
        }
    }
}
