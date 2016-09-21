using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Spiral
{
    public static class MapLoader
    {
        public static IEnumerable<Obstacle> GetObstaclesFromRow (string src, int row)
        {
            return src
                .ToArray()
                .Select((c, col) => Tuple.Create<char, int>(c, col))
                .Where(tuple => tuple.Item1 == '#')
                .Select(tuple => new Obstacle(row, tuple.Item2));
        }

        public static IEnumerable<Obstacle> GetObstacles (string[] src)
        {
            var obstacles = new List<Obstacle>();
            for (int i = 0; i < src.Length; i++)
            {
                obstacles = obstacles.Concat(GetObstaclesFromRow(src[i], i)).ToList();
            }
            return obstacles;
        }

        public static IEnumerable<Monster> GetMonstersFromRow (string src, int row)
        {
            return src
                .ToArray()
                .Select((c, col) => Tuple.Create<char, int>(c, col))
                .Where(tuple => tuple.Item1 == 'M')
                .Select(tuple => new Monster(row, tuple.Item2));
        }
        
        public static IEnumerable<Monster> GetMonsters (string[] src)
        {
            var monsters = new List<Monster>();
            for (int i = 0; i < src.Length; i++)
            {
                monsters = monsters.Concat(GetMonstersFromRow(src[i], i)).ToList();
            }
            return monsters;
        }

        public static string[] LoadMap (int level)
        {
            return File.ReadAllLines("map" + level);
        }
    }
}
