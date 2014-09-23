﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Space3D
{
    static class Storage
    {
        public static void SavePath(string fullFileName, bool append, Path3D path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fullFileName, append, Encoding.GetEncoding("UTF-8")))
                {
                    sw.WriteLine(path.ToString());
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }

        public static List<Path3D> LoadPaths(string fullFileName)
        {
            try
            {
                List<Path3D> paths = new List<Path3D>();
                using (StreamReader sr = new StreamReader(fullFileName, Encoding.GetEncoding("UTF-8")))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Path3D points = new Path3D();
                        var lines = line.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var lin in lines)
                        {
                            points.Add(Point3D.DeSerialize(lin));
                        }
                        line = sr.ReadLine();
                        paths.Add(points);
                    }
                }
                return paths;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }
    }
}
