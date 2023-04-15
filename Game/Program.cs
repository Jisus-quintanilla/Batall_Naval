int[,] tablero = new int[10, 10];

void paso1_crear_tablero()
{
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int j = 0; j < tablero.GetLength(1); j++)
        {
            tablero[i, j] = 0;
        }
    }
}

void paso2_colocar_barco()
{
    //se pone barcos pos fija
    int Min = 0;
    int Max = 9;
    Random aleatorio = new Random();

    for (int i = 0; i < 7; i++)
    {
        int resul;
        int resul1;
        resul = aleatorio.Next(Min, Max);
        resul1 = aleatorio.Next(Min, Max);
        
        tablero[resul, resul1] = 1;
        
    }
    
    
}

void paso3_imprimir_tablero()
{
    int col = 0;
    Console.Write("\n\t  0 1 2 3 4 5 6 7 8 9\n");

    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        Console.Write("\t");
        Console.Write(col + "|");
        col++;
        for (int j = 0; j < tablero.GetLength(1); j++)
        {
            String carcter_imprimir;// = (tablero[i, j] ==0 ? "-": "*");

            switch (tablero[i, j])
            {

                case 0:
                    carcter_imprimir = "^";
                    break;

                case 1:
                    carcter_imprimir = "B";

                    break;

                case 2:
                    carcter_imprimir = "*";
                    break;

                case -1:
                    carcter_imprimir = "X";
                    break;

                default:
                    carcter_imprimir = "*";
                    break;
            }

            Console.Write(carcter_imprimir + " ");
        }
        Console.WriteLine();
    }

}

void Barco()
{
    Console.WriteLine("____________█");
    Console.WriteLine("____________██");
    Console.WriteLine("____________█_██");
    Console.WriteLine("____________███");
    Console.WriteLine("____________██_▒");
    Console.WriteLine("___________███_▒▒");
    Console.WriteLine("___________█_█_▒▒▒");
    Console.WriteLine("__________██_█_▒▒▒▒");
    Console.WriteLine("_________███_█_▒▒▒▒▒");
    Console.WriteLine("________████_█_▒▒▒▒▒▒");
    Console.WriteLine("_______█████_█_▒▒▒▒▒▒▒");
    Console.WriteLine("_____███████_█_▒▒▒▒▒▒▒▒");
    Console.WriteLine("____████████_█_▒▒▒▒▒▒▒▒▒");
    Console.WriteLine("_ █_████████_ █_▒▒▒▒▒▒▒▒");
    Console.WriteLine("__██_█_______██____██___█");
    Console.WriteLine("__ ████████████████_███");
    Console.WriteLine("___ ███████████████████");
}

void Gato()
{
Console.WriteLine("──────▄▀▄─────▄▀▄");
Console.WriteLine("─────▄█░░▀▀▀▀▀░░█▄");
Console.WriteLine("─▄▄──█░░░░░░░░░░░█──▄▄");
Console.WriteLine("█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█");

}

void paso4_ingreso_cordenadas()
{
    int Barcos = 7;
    int fila, columna = 0;
    Console.Clear();
    Console.WriteLine("Bienvenido a Re:creator");
    Barco();
    Console.WriteLine("Barcos: "+Barcos+"\n");

    paso3_imprimir_tablero();
    Console.WriteLine("\n\n");

    bool Rep = true;
    do
    {
        Console.WriteLine("ingresa la Fila: ");
        fila = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ingresa la Columna: ");
        columna = Convert.ToInt32(Console.ReadLine());

 

        if (fila > 9 || columna > 9)
        {
            Console.WriteLine("Marcaste fuera del tablero");

        }
        else
        {
            if (tablero[fila, columna] == 1)
            {
                Console.Beep();
                tablero[fila, columna] = -2; //le dio
                Barcos = Barcos - 1;

            }
            else
            {
                tablero[fila, columna] = -1;// Falló
            }
        }
        Console.Clear();
        Barco();
        Console.WriteLine("Barcos: " + Barcos + "\n");
        paso3_imprimir_tablero();
        Console.WriteLine("\n\n");

        if(Barcos == 0)
        {
            Rep = false;
        }
    } while (Rep);
    Gato();
    Console.WriteLine("Felicidades has ganado");
}


paso1_crear_tablero();
paso2_colocar_barco();
paso3_imprimir_tablero();
paso4_ingreso_cordenadas();