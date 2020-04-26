﻿using System.Collections.Generic;

namespace Game3d
{
    /**
    * The grid of nodes we use to find path
    */
    public class Grid
    {
        public Node[,] nodes;
        int gridSizeX, gridSizeY;

        /**
        * Create a new grid with tile prices.
        * width: grid width.
        * height: grid height.
        * tiles_costs: 2d array of floats, representing the cost of every tile.
        *               0.0f = unwalkable tile.
        *               1.0f = normal tile.
        */
        public Grid(int width, int height, float[][] tiles_costs)
        {
            gridSizeX = width;
            gridSizeY = height;
            nodes = new Node[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    nodes[y,x] = new Node(tiles_costs[y][x], x,y);

                } 
            }
        }   

        /**
        * Create a new grid of just walkable / unwalkable.
        * width: grid width.
        * height: grid height.
        * walkable_tiles: the tilemap. true for walkable, false for blocking.
        */
        public Grid(int width, int height, bool[,] walkable_tiles)
        {
            gridSizeX = width;
            gridSizeY = height;
            nodes = new Node[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    nodes[y,x] = new Node(walkable_tiles[y,x] ? 1.0f : 0.0f, x, y);
                }
            }
        }

        public List<Node> GetNeighbours(Node node)
        {
            List<Node> neighbours = new List<Node>();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    if (x == 0 && y == 0)
                        continue;

                    int checkX = node.gridX + x;
                    int checkY = node.gridY + y;

                    if (checkX >= 0 && checkX < gridSizeX && checkY >= 0 && checkY < gridSizeY)
                    {
                        neighbours.Add(nodes[checkY, checkX]);
                    }
                }
            }

            return neighbours;
        }
    }
}
