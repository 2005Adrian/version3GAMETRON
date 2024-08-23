using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1_TRONGAME
{
    public class Grid
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Grid? Arriba { get; set; } = null;
        public Grid? Abajo { get; set; } = null;
        public Grid? Izquierda { get; set; } = null;
        public Grid? Derecha { get; set; } = null;

        public Grid(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class TableroDeJuego
    {
        public Grid[,] Matriz { get; private set; }

        public TableroDeJuego(int filas, int columnas)
        {
            Matriz = new Grid[filas, columnas];
            CrearTablero(filas, columnas);
        }

        private void CrearTablero(int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Matriz[i, j] = new Grid(i, j);
                }
            }

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (i > 0) Matriz[i, j].Arriba = Matriz[i - 1, j];
                    if (i < filas - 1) Matriz[i, j].Abajo = Matriz[i + 1, j];
                    if (j > 0) Matriz[i, j].Izquierda = Matriz[i, j - 1];
                    if (j < columnas - 1) Matriz[i, j].Derecha = Matriz[i, j + 1];
                }
            }
        }

        public Grid ObtenerNodo(int fila, int columna)
        {
            if (fila >= 0 && fila < Matriz.GetLength(0) && columna >= 0 && columna < Matriz.GetLength(1))
            {
                return Matriz[fila, columna];
            }
            return null;
        }
    }
}

