﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space3D
{
    public class Path3D
    {
        private List<Point3D> paths;

        public Path3D(params Point3D[] points3D)
        {
            this.Paths = new List<Point3D>();
            foreach (var point3D in points3D)
            {
                this.Paths.Add(point3D);
            }
        }

        public List<Point3D> Paths
        {
            get { return this.paths; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.paths = value;
            }
        }

        public int Count
        {
            get { return this.Paths.Count; }
        }

        public Point3D this[int index]
        {
            get { return this.Paths[index]; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.Paths[index] = value;
            }
        }

        public void Add(Point3D point)
        {
            this.Paths.Add(point);
        }

        public override string ToString()
        {
            StringBuilder pathsString = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                pathsString.Append(this[i].ToString());
                if (i != this.Count - 1)
                {
                    pathsString.Append(", ");
                }
            }
            return pathsString.ToString();
        }
    }
}