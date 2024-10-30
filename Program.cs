using System;

class Program
{
    static string[][] vuelos = new string[0][]; // matrix de vuelos

    static int cantidad = 0; // Cuantos vuelos vamos creando

    static int agrandar_matrix = 0; // agregar un nuevo vuelo

    static void Main()
    {
        Diseño_de_avion_saludar();

        int opcion_usuario = 0;

        do
        {
            opcion_usuario = Menu_de_Opciones();

            switch (opcion_usuario)
            {
                case 1:
                    Crear_vuelo_1();
                    break;

                case 2:
                    Reserva_asiento_2();
                    break;
                case 3:
                    Cancelar_reserva_3();
                    break;
                case 4:
                    Mostrar_estado_de_vuelo_4();
                    break;
            }

        } while (opcion_usuario != 0);

        Saludo_de_Despedida();

        Console.SetCursorPosition(38, 14);

        Thread.Sleep(3000);
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

    }

    /* FUNCIONES DE MARCOS Y DISEÑOS */

    static void Diseño_de_avion_saludar()
    {
        int ancho = 60;
        // Imprimir borde superior
        Console.WriteLine("\n     ┌" + new string('─', ancho - 2) + "┐");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                       :okOxoc:"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                           * * *"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                         :1x0XXK0kdlc:           :clc;;");
        Console.WriteLine("                           ;cokKNNNXKOxol:  :coxk0KXkc;");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                              :cd0KNNNNXK0kk0KNNNX0xc; ");
        Console.WriteLine("                                 :lx0XNNNNNNNNK0xo: ");
        Console.WriteLine("                                 :ldOXNNNNNNKxl: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                   ;colc: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("    ;cox0KNNXXNNNNNk:; ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                   ;ckK0kol");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("cok0XXKKOdodKNNNKo; ");
        Console.WriteLine("                    ;:o0XXKKKKOxolk  :l0NNNOc; ");
        Console.WriteLine("                    :coOKXNKdc       :l0NNKd; ");
        Console.WriteLine("                      :lllONOc       :l0NNOc; ");
        Console.WriteLine("                        :xXk::       :lKNXd: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                        ;col::       :l0N0l; ");
        Console.WriteLine("                          ::::       :lOOo: ");
        Console.WriteLine("                                       OO: ");
        Console.ResetColor();
        Console.WriteLine("\n        \"Bienvenidos a AERO EXPRESS tu mejor forma de viajar\" ");
        Console.WriteLine("\n                       Gracias por elegirnos");

        // Imprimir borde inferior
        Console.WriteLine("     └" + new string('─', ancho - 2) + "┘");

        Console.Write("\n\n\n\n      Presione cualquier tecla para continuar: ");
        Console.ReadKey();
        Console.Clear();

        // FINAL DEL SALUDO 
    }

    static void Saludo_de_Despedida()
    {
        Console.Clear();

        int ancho = 70; // Ancho del marco
        int alto = 23;  // Alto del marco

        // Dibujar la parte superior del marco
        Console.WriteLine("\n     ┌" + new string('─', ancho - 2) + "┐");

        // Dibujar los lados del marco
        for (int i = 0; i < alto - 2; i++)
        {
            Console.WriteLine("     │" + new string(' ', ancho - 2) + "│");
        }

        // Dibujar la parte inferior del marco
        Console.WriteLine("     └" + new string('─', ancho - 2) + "┘");

        Console.SetCursorPosition(25, 7);
        Console.Write("Muchas gracias por Elejirnos ");

        Console.SetCursorPosition(28, 11);
        Console.Write("¡¡¡ AERO");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(36, 13);
        Console.Write("* * *"); Console.ResetColor();

        Console.SetCursorPosition(38, 11);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("EXPRESS !!!"); Console.ResetColor();

    }
    static void Dibujar_Marco()
    {
        int ancho = 70; // Ancho del marco
        int alto = 23;  // Alto del marco

        // Dibujar la parte superior del marco
        Console.WriteLine("\n     ┌" + new string('─', ancho - 2) + "┐");

        // Dibujar los lados del marco
        for (int i = 0; i < alto - 2; i++)
        {
            Console.WriteLine("     │" + new string(' ', ancho - 2) + "│");
        }

        // Dibujar la parte inferior del marco
        Console.WriteLine("     └" + new string('─', ancho - 2) + "┘");
    }

    /*  FUNCIONES DE LAS OPCIONES   */

    static int Menu_de_Opciones()
    {
        Console.Clear();
        // Dimensiones del marco
        int ancho = 070;
        int alto = 23;

        // Menú de opciones
        string[] menu = {
            "                                                             * * *",
            "                       MENU DE OPCIONES","",
            "                1. Crear un vuelo ","",
            "                2. Reservar un asiento","",
            "                3. Cancelar una reserva","",
            "                4. Estado actual del vuelo","",
            "                (Ingrese 0 para salir.)","","","",
            "Ingresar opcion:"
        };

        // Dibujar la parte superior del marco
        Console.WriteLine("\n     ┌" + new string('─', ancho - 2) + "┐");

        // Dibujar los lados del marco y el menú
        for (int i = 0; i < alto - 2; i++)
        {
            if (i < menu.Length)
            {
                string linea = "     │ ";
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;  // Cambiar el color a AMARILLO
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;  // Cambiar el color a celeste
                }

                linea += menu[i];
                if (linea.Length < ancho + 4)
                    linea += new string(' ', ancho + 4 - linea.Length);
                linea += "│";
                Console.WriteLine(linea);

                Console.ResetColor();  // Restablecer el color por defecto
            }
            else
            {
                Console.WriteLine("     │" + new string(' ', ancho - 2) + "│");
            }
        }

        // Dibujar la parte inferior del marco
        Console.WriteLine("     └" + new string('─', ancho - 2) + "┘");

        // Solicitar al usuario que elija una opción y mostrarla dentro del marco
        Console.SetCursorPosition(24, menu.Length + 1);
        int usuario = int.Parse(Console.ReadLine());

        if (usuario > 4 || usuario < 0)
        {
            Console.SetCursorPosition(14, 19);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("    OPCION INCONRRECTA, INTENTE NUEVAMENTE.  "); Console.ResetColor();

            Thread.Sleep(1500);
        }

        Console.Clear();

        return usuario;
    }
    static void Crear_vuelo_1()
    {
        Dibujar_Marco();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(68, 2);
        Console.Write("* * *"); Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(23, 3);
        Console.Write("         CREAR VUELOS"); Console.ResetColor();

        if (vuelos.Length == 0)
        {
            cantidad++;

            vuelos = new string[cantidad][];

            Console.SetCursorPosition(13, 6);
            Console.Write("(*) Destino: ");
            vuelos[0] = new string[61];

            vuelos[0][0] = Console.ReadLine();

            for (int lugares = 1; lugares <= 60; lugares++)
            {
                vuelos[0][lugares] = "0";
            }

            Console.SetCursorPosition(12, 6);
            Console.Write("                                                              ");//borrar el vuelo que puso el usuario

            Console.SetCursorPosition(16, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" Vuelo a ¡¡¡ {vuelos[0][0]} !!! creado correctamente "); Console.ResetColor();

            Console.SetCursorPosition(10, 17);
            Console.Write("            Precione tecla para continuar... ");

            Console.ReadKey();
            return;
        }
        cantidad++;

        agrandar_matrix++;

        Array.Resize(ref vuelos, cantidad);
        vuelos[agrandar_matrix] = new string[61];

        Console.SetCursorPosition(13, 6);
        Console.Write("(*) Destino: ");
        vuelos[agrandar_matrix] = new string[61];

        vuelos[agrandar_matrix][0] = Console.ReadLine();

        for (int lugares = 1; lugares <= 60; lugares++)
        {
            vuelos[agrandar_matrix][lugares] = "0";
        }

        Console.SetCursorPosition(12, 6);
        Console.Write("                                                              ");//borrar el vuelo que puso el usuario

        Console.SetCursorPosition(16, 9);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($" Vuelo a ¡¡¡ {vuelos[agrandar_matrix][0]} !!! creado correctamente "); Console.ResetColor();

        Console.SetCursorPosition(10, 17);
        Console.Write("            Precione tecla para continuar... ");

        Console.ReadKey();

    }
    static void Reserva_asiento_2()
    {
        bool salir = false;

        do
        {
            Console.Clear();
            Dibujar_Marco();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(68, 2);
            Console.Write("* * *"); Console.ResetColor();

            if (vuelos.Length == 0)
            {
                Console.SetCursorPosition(17, 9);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("          NO HAY VUELOS CREADOS  "); Console.ResetColor();

                Console.SetCursorPosition(17, 14);
                Console.Write("     Precione tecla para continuar... ");
                Console.ReadKey(); // volver a menu despues de errar 3 veces
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(23, 3);
            Console.Write("       RESERVA DE ASIENTOS "); Console.ResetColor();

            int p = 6;  // variable para la posicion de vuelos (setcursorposition , adentro del for)
            int posicion = 1; // posicion de los vuelos cuando ve el usuario

            Console.SetCursorPosition(23, 6);
            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.SetCursorPosition(23, p);
                Console.Write($"{posicion}) {vuelos[i][0]}");

                posicion++;
                p++;
            }
            p = p + 1;

            Console.SetCursorPosition(23, p);
            Console.Write($"   (Ingrese 0 para salir.) ");
            p = p + 3;

            Console.SetCursorPosition(23, p);
            Console.Write($"       Elegir vuelo: ");
            int vuelo_elegido = int.Parse(Console.ReadLine());

            vuelo_elegido = vuelo_elegido - 1;

            if (vuelo_elegido == -1)
            {
                salir = true;
                return;
            }
            p = p + 2;

            posicion = posicion - 1;

            if (vuelo_elegido >= posicion)
            {
                Console.SetCursorPosition(14, p);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("      OPCION INCONRRECTA, INTENTE NUEVAMENTE... "); Console.ResetColor();

                Thread.Sleep(1500);
            }
            else
            {
                bool salir_mapa = false;
                do
                {
                    Ver_los_Asientos(vuelo_elegido, posicion, p);

                    Console.SetCursorPosition(25, 19);
                    Console.Write("(");
                    Console.SetCursorPosition(26, 19);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Asientos disponibles"); Console.ResetColor();
                    Console.SetCursorPosition(47, 19);
                    Console.Write("/");
                    Console.SetCursorPosition(49, 19);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Asientos vendidos"); Console.ResetColor();
                    Console.SetCursorPosition(66, 19);
                    Console.Write(")");

                    Console.SetCursorPosition(44, 21);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(vuelos[vuelo_elegido][0]); Console.ResetColor();

                    Console.SetCursorPosition(29, 23);
                    Console.Write("Asiento (0 volver): ");
                    int elegir_asiento = int.Parse(Console.ReadLine());

                    if (elegir_asiento > 60)
                    {
                        Console.SetCursorPosition(14, 22);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("             ASIENTO INCONRRECTO, INTENTE NUEVAMENTE... "); Console.ResetColor();

                        Thread.Sleep(1500);

                        Console.Clear();
                    }
                    else if (elegir_asiento == 0)
                    {
                        salir_mapa = true;
                    }
                    else
                    {
                        if (vuelos[vuelo_elegido][elegir_asiento] == "0")
                        {
                            Console.SetCursorPosition(34, 22);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("      ASIENTO ADQUIRIDO "); Console.ResetColor();
                            Thread.Sleep(1500);


                            vuelos[vuelo_elegido][elegir_asiento] = "1";
                        }
                        else
                        {
                            Console.SetCursorPosition(34, 22);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("      ASIENTO  VENDIDO "); Console.ResetColor();
                            Thread.Sleep(1500);
                        }
                        Console.Clear();
                    }

                } while (salir_mapa != true);

            }

        } while (salir != true);

        static void Ver_los_Asientos(int n, int t, int q)
        {
            if (n >= t)
            {
                return; // si no volvemos entra en la matrix y se rompe ya que es un numero mayor al rango
            }
            Console.Clear();

            Dibujar_Marco_Mapa_Avion_2();

            Butacas(n);

            static void Dibujar_Marco_Mapa_Avion_2()
            {
                int ancho = 95;
                int alto = 26;

                // Dibujar la parte superior del marco
                Console.WriteLine(" ┌" + new string('─', ancho - 2) + "┐");

                // Dibujar los lados del marco
                for (int i = 0; i < alto - 2; i++)
                {
                    Console.WriteLine(" │" + new string(' ', ancho - 2) + "│");
                }

                // Dibujar la parte inferior del marco
                Console.WriteLine(" └" + new string('─', ancho - 2) + "┘");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(89, 1);
                Console.Write("* * *"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(23, 2);
                Console.Write("                 MAPA DE ASIENTOS"); Console.ResetColor();

                Console.SetCursorPosition(13, 5);
                Console.Write("┌====================================================================┐");

                Console.SetCursorPosition(16, 4);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(16, 13);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(2, 10);
                Console.Write(" Delantera                                                                        Trasera");

                Console.SetCursorPosition(16, 8);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(16, 17);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(13, 16);
                Console.Write("└====================================================================┘");

            }

            static void Butacas(int f)
            {
                /*               PRIMERAS DOCE              */

                if (vuelos[f][1] == "0")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[01]"); Console.ResetColor();
                }
                else if (vuelos[f][1] == "1")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[01]"); Console.ResetColor();
                }

                if (vuelos[f][2] == "0")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[02]"); Console.ResetColor();
                }
                else if (vuelos[f][2] == "1")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[02]"); Console.ResetColor();
                }

                if (vuelos[f][3] == "0")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[03]"); Console.ResetColor();
                }
                else if (vuelos[f][3] == "1")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[03]"); Console.ResetColor();
                }

                if (vuelos[f][4] == "0")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[04]"); Console.ResetColor();
                }
                else if (vuelos[f][4] == "1")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[04]"); Console.ResetColor();
                }

                if (vuelos[f][5] == "0")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[05]"); Console.ResetColor();
                }
                else if (vuelos[f][5] == "1")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[05]"); Console.ResetColor();
                }

                if (vuelos[f][6] == "0")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[06]"); Console.ResetColor();
                }
                else if (vuelos[f][6] == "1")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[06]"); Console.ResetColor();
                }

                if (vuelos[f][7] == "0")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[07]"); Console.ResetColor();
                }
                else if (vuelos[f][7] == "1")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[07]"); Console.ResetColor();
                }

                if (vuelos[f][8] == "0")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[08]"); Console.ResetColor();
                }
                else if (vuelos[f][8] == "1")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[08]"); Console.ResetColor();
                }

                if (vuelos[f][9] == "0")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[09]"); Console.ResetColor();
                }
                else if (vuelos[f][9] == "1")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[09]"); Console.ResetColor();
                }


                if (vuelos[f][10] == "0")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[10]"); Console.ResetColor();
                }
                else if (vuelos[f][10] == "1")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[10]"); Console.ResetColor();
                }

                if (vuelos[f][11] == "0")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[11]"); Console.ResetColor();
                }
                else if (vuelos[f][11] == "1")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[11]"); Console.ResetColor();
                }

                if (vuelos[f][12] == "0")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[12]"); Console.ResetColor();
                }
                else if (vuelos[f][12] == "1")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[12]"); Console.ResetColor();
                }

                /*                 FIN PRIMERAS DOCE              */

                /*                 SEGUNDA DOCE              */

                if (vuelos[f][13] == "0")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[13]"); Console.ResetColor();
                }
                else if (vuelos[f][13] == "1")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[13]"); Console.ResetColor();
                }

                if (vuelos[f][14] == "0")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[14]"); Console.ResetColor();
                }
                else if (vuelos[f][14] == "1")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[14]"); Console.ResetColor();
                }

                if (vuelos[f][15] == "0")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[15]"); Console.ResetColor();
                }
                else if (vuelos[f][15] == "1")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[15]"); Console.ResetColor();
                }

                if (vuelos[f][16] == "0")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[16]"); Console.ResetColor();
                }
                else if (vuelos[f][16] == "1")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[16]"); Console.ResetColor();
                }

                if (vuelos[f][17] == "0")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[17]"); Console.ResetColor();
                }
                else if (vuelos[f][17] == "1")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[17]"); Console.ResetColor();
                }

                if (vuelos[f][18] == "0")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[18]"); Console.ResetColor();
                }
                else if (vuelos[f][18] == "1")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[18]"); Console.ResetColor();
                }

                if (vuelos[f][19] == "0")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[19]"); Console.ResetColor();
                }
                else if (vuelos[f][19] == "1")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[19]"); Console.ResetColor();
                }

                if (vuelos[f][20] == "0")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[20]"); Console.ResetColor();
                }
                else if (vuelos[f][20] == "1")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[20]"); Console.ResetColor();
                }

                if (vuelos[f][21] == "0")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[21]"); Console.ResetColor();
                }
                else if (vuelos[f][21] == "1")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[21]"); Console.ResetColor();
                }

                if (vuelos[f][22] == "0")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[22]"); Console.ResetColor();
                }
                else if (vuelos[f][22] == "1")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[22]"); Console.ResetColor();
                }

                if (vuelos[f][23] == "0")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[23]"); Console.ResetColor();
                }
                else if (vuelos[f][23] == "1")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[23]"); Console.ResetColor();
                }

                if (vuelos[f][24] == "0")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[24]"); Console.ResetColor();
                }
                else if (vuelos[f][24] == "1")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[24]"); Console.ResetColor();
                }

                /*                 FIN SEGUNDA DOCE              */

                /*                 TERCERA DOCE              */

                if (vuelos[f][25] == "0")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[25]"); Console.ResetColor();
                }
                else if (vuelos[f][25] == "1")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[25]"); Console.ResetColor();
                }

                if (vuelos[f][26] == "0")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[26]"); Console.ResetColor();
                }
                else if (vuelos[f][26] == "1")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[26]"); Console.ResetColor();
                }

                if (vuelos[f][27] == "0")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[27]"); Console.ResetColor();
                }
                else if (vuelos[f][27] == "1")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[27]"); Console.ResetColor();
                }

                if (vuelos[f][28] == "0")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[28]"); Console.ResetColor();
                }
                else if (vuelos[f][28] == "1")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[28]"); Console.ResetColor();
                }

                if (vuelos[f][29] == "0")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[29]"); Console.ResetColor();
                }
                else if (vuelos[f][29] == "1")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[29]"); Console.ResetColor();
                }

                if (vuelos[f][30] == "0")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[30]"); Console.ResetColor();
                }
                else if (vuelos[f][30] == "1")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[30]"); Console.ResetColor();
                }

                if (vuelos[f][31] == "0")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[31]"); Console.ResetColor();
                }
                else if (vuelos[f][31] == "1")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[31]"); Console.ResetColor();
                }

                if (vuelos[f][32] == "0")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[32]"); Console.ResetColor();
                }
                else if (vuelos[f][32] == "1")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[32]"); Console.ResetColor();
                }

                if (vuelos[f][33] == "0")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[33]"); Console.ResetColor();
                }
                else if (vuelos[f][33] == "1")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[33]"); Console.ResetColor();
                }

                if (vuelos[f][34] == "0")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[34]"); Console.ResetColor();
                }
                else if (vuelos[f][34] == "1")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[34]"); Console.ResetColor();
                }

                if (vuelos[f][35] == "0")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[35]"); Console.ResetColor();
                }
                else if (vuelos[f][35] == "1")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[35]"); Console.ResetColor();
                }

                if (vuelos[f][36] == "0")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[36]"); Console.ResetColor();
                }
                else if (vuelos[f][36] == "1")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[36]"); Console.ResetColor();
                }

                /*                 FIN TERCERA DOCE              */

                /*                 CUARTA DOCE              */

                if (vuelos[f][37] == "0")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[37]"); Console.ResetColor();
                }
                else if (vuelos[f][37] == "1")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[37]"); Console.ResetColor();
                }

                if (vuelos[f][38] == "0")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[38]"); Console.ResetColor();
                }
                else if (vuelos[f][38] == "1")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[38]"); Console.ResetColor();
                }

                if (vuelos[f][39] == "0")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[39]"); Console.ResetColor();
                }
                else if (vuelos[f][39] == "1")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[39]"); Console.ResetColor();
                }

                if (vuelos[f][40] == "0")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[40]"); Console.ResetColor();
                }
                else if (vuelos[f][40] == "1")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[40]"); Console.ResetColor();
                }

                if (vuelos[f][41] == "0")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[41]"); Console.ResetColor();
                }
                else if (vuelos[f][41] == "1")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[41]"); Console.ResetColor();
                }

                if (vuelos[f][42] == "0")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[42]"); Console.ResetColor();
                }
                else if (vuelos[f][42] == "1")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[42]"); Console.ResetColor();
                }

                if (vuelos[f][43] == "0")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[43]"); Console.ResetColor();
                }
                else if (vuelos[f][43] == "1")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[43]"); Console.ResetColor();
                }

                if (vuelos[f][44] == "0")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[44]"); Console.ResetColor();
                }
                else if (vuelos[f][44] == "1")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[44]"); Console.ResetColor();
                }

                if (vuelos[f][45] == "0")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[45]"); Console.ResetColor();
                }
                else if (vuelos[f][45] == "1")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[45]"); Console.ResetColor();
                }

                if (vuelos[f][46] == "0")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[46]"); Console.ResetColor();
                }
                else if (vuelos[f][46] == "1")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[46]"); Console.ResetColor();
                }

                if (vuelos[f][47] == "0")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[47]"); Console.ResetColor();
                }
                else if (vuelos[f][47] == "1")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[47]"); Console.ResetColor();
                }

                if (vuelos[f][48] == "0")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[48]"); Console.ResetColor();
                }
                else if (vuelos[f][48] == "1")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[48]"); Console.ResetColor();
                }

                /*                 FIN CUARTA DOCE              */

                /*                 QUINTA DOCE              */

                if (vuelos[f][49] == "0")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[49]"); Console.ResetColor();
                }
                else if (vuelos[f][49] == "1")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[49]"); Console.ResetColor();
                }

                if (vuelos[f][50] == "0")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[50]"); Console.ResetColor();
                }
                else if (vuelos[f][50] == "1")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[50]"); Console.ResetColor();
                }

                if (vuelos[f][51] == "0")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[51]"); Console.ResetColor();
                }
                else if (vuelos[f][51] == "1")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[51]"); Console.ResetColor();
                }

                if (vuelos[f][52] == "0")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[52]"); Console.ResetColor();
                }
                else if (vuelos[f][52] == "1")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[52]"); Console.ResetColor();
                }

                if (vuelos[f][53] == "0")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[53]"); Console.ResetColor();
                }
                else if (vuelos[f][53] == "1")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[53]"); Console.ResetColor();
                }

                if (vuelos[f][54] == "0")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[54]"); Console.ResetColor();
                }
                else if (vuelos[f][54] == "1")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[54]"); Console.ResetColor();
                }

                if (vuelos[f][55] == "0")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[55]"); Console.ResetColor();
                }
                else if (vuelos[f][55] == "1")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[55]"); Console.ResetColor();
                }

                if (vuelos[f][56] == "0")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[56]"); Console.ResetColor();
                }
                else if (vuelos[f][56] == "1")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[56]"); Console.ResetColor();
                }

                if (vuelos[f][57] == "0")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[57]"); Console.ResetColor();
                }
                else if (vuelos[f][57] == "1")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[57]"); Console.ResetColor();
                }

                if (vuelos[f][58] == "0")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[58]"); Console.ResetColor();
                }
                else if (vuelos[f][58] == "1")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[58]"); Console.ResetColor();
                }

                if (vuelos[f][59] == "0")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[59]"); Console.ResetColor();
                }
                else if (vuelos[f][59] == "1")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[59]"); Console.ResetColor();
                }

                if (vuelos[f][60] == "0")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[60]"); Console.ResetColor();
                }
                else if (vuelos[f][60] == "1")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[60]"); Console.ResetColor();
                }
            }
        }
    }
    static void Cancelar_reserva_3()
    {
        bool salir = false;

        do
        {
            Console.Clear();
            Dibujar_Marco();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(68, 2);
            Console.Write("* * *"); Console.ResetColor();

            if (vuelos.Length == 0)
            {

                Console.SetCursorPosition(17, 9);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("          NO HAY VUELOS CREADOS  "); Console.ResetColor();

                Console.SetCursorPosition(17, 14);
                Console.Write("     Precione tecla para continuar... ");
                Console.ReadKey(); // volver a menu despues de errar 3 veces

                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(23, 3);
            Console.Write("       CANCELAR  ASIENTOS "); Console.ResetColor();

            int p = 6;  // variable para la posicion de vuelos (setcursorposition , adentro del for)
            int posicion = 1; // posicion de los vuelos cuando ve el usuario

            Console.SetCursorPosition(23, 6);
            for (int i = 0; i < vuelos.Length; i++)
            {

                Console.SetCursorPosition(23, p);
                Console.Write($"{posicion}) {vuelos[i][0]}");

                posicion++;
                p++;
            }
            p = p + 1;
            Console.SetCursorPosition(23, p);
            Console.Write($"   (Ingrese 0 para salir.) ");
            p = p + 3;

            Console.SetCursorPosition(23, p);
            Console.Write($"       Elegir vuelo: ");
            int vuelo_elegido = int.Parse(Console.ReadLine());

            vuelo_elegido = vuelo_elegido - 1;

            if (vuelo_elegido == -1)
            {
                salir = true;
                return;
            }
            p = p + 2;

            posicion = posicion - 1;

            if (vuelo_elegido >= posicion)
            {
                Console.SetCursorPosition(14, p);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("      OPCION INCONRRECTA, INTENTE NUEVAMENTE... "); Console.ResetColor();

                Thread.Sleep(1500);
            }
            else
            {

                bool salir_mapa = false;

                do
                {
                    Ver_los_Asientos(vuelo_elegido, posicion, p);

                    Console.SetCursorPosition(39, 19);
                    Console.Write("(");
                    Console.SetCursorPosition(40, 19);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("ASIENTOS VENDIDOS"); Console.ResetColor();
                    Console.SetCursorPosition(57, 19);
                    Console.Write(")");

                    Console.SetCursorPosition(44, 21);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(vuelos[vuelo_elegido][0]); Console.ResetColor();

                    Console.SetCursorPosition(29, 23);
                    Console.Write("Asiento (0 volver): ");
                    int elegir_asiento = int.Parse(Console.ReadLine());

                    if (elegir_asiento > 60)
                    {
                        Console.SetCursorPosition(14, 22);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("             ASIENTO INCONRRECTO, INTENTE NUEVAMENTE... "); Console.ResetColor();

                        Thread.Sleep(1500);

                        Console.Clear();
                    }
                    else if (elegir_asiento == 0)
                    {
                        salir_mapa = true;
                    }
                    else
                    {
                        if (vuelos[vuelo_elegido][elegir_asiento] == "1")
                        {
                            Console.SetCursorPosition(34, 22);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("      ASIENTO CANCELADO "); Console.ResetColor();
                            Thread.Sleep(1500);


                            vuelos[vuelo_elegido][elegir_asiento] = "0";
                        }
                        else
                        {
                            Console.SetCursorPosition(34, 22);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("     ASIENTO NO VENDIDO "); Console.ResetColor();
                            Thread.Sleep(1500);
                        }



                        Console.Clear();
                    }






                } while (salir_mapa != true);

            }





        } while (salir != true);





        static void Ver_los_Asientos(int n, int t, int q)
        {
            if (n >= t)
            {
                return;
            }

            Console.Clear();

            Dibujar_Marco_Mapa_Avion_2();

            Butacas(n);

            static void Dibujar_Marco_Mapa_Avion_2()
            {

                int ancho = 95;
                int alto = 26;

                // Dibujar la parte superior del marco
                Console.WriteLine(" ┌" + new string('─', ancho - 2) + "┐");

                // Dibujar los lados del marco
                for (int i = 0; i < alto - 2; i++)
                {
                    Console.WriteLine(" │" + new string(' ', ancho - 2) + "│");
                }

                // Dibujar la parte inferior del marco
                Console.WriteLine(" └" + new string('─', ancho - 2) + "┘");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(89, 1);
                Console.Write("* * *"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(23, 2);
                Console.Write("                 MAPA DE ASIENTOS"); Console.ResetColor();

                Console.SetCursorPosition(13, 5);
                Console.Write("┌====================================================================┐");

                Console.SetCursorPosition(16, 4);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(16, 13);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(2, 10);
                Console.Write(" Delantera                                                                        Trasera");

                Console.SetCursorPosition(16, 8);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(16, 17);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(13, 16);
                Console.Write("└====================================================================┘");


            }

            static void Butacas(int f)
            {
                /*               PRIMERAS DOCE              */

                if (vuelos[f][1] == "0")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.Write("[01]");
                }
                else if (vuelos[f][1] == "1")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[01]"); Console.ResetColor();
                }

                if (vuelos[f][2] == "0")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.Write("[02]");
                }
                else if (vuelos[f][2] == "1")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[02]"); Console.ResetColor();
                }

                if (vuelos[f][3] == "0")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.Write("[03]");
                }
                else if (vuelos[f][3] == "1")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[03]"); Console.ResetColor();
                }

                if (vuelos[f][4] == "0")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.Write("[04]");
                }
                else if (vuelos[f][4] == "1")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[04]"); Console.ResetColor();
                }

                if (vuelos[f][5] == "0")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.Write("[05]");
                }
                else if (vuelos[f][5] == "1")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[05]"); Console.ResetColor();
                }

                if (vuelos[f][6] == "0")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.Write("[06]");
                }
                else if (vuelos[f][6] == "1")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[06]"); Console.ResetColor();
                }

                if (vuelos[f][7] == "0")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.Write("[07]");
                }
                else if (vuelos[f][7] == "1")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[07]"); Console.ResetColor();
                }

                if (vuelos[f][8] == "0")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.Write("[08]");
                }
                else if (vuelos[f][8] == "1")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[08]"); Console.ResetColor();
                }

                if (vuelos[f][9] == "0")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.Write("[09]");
                }
                else if (vuelos[f][9] == "1")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[09]"); Console.ResetColor();
                }


                if (vuelos[f][10] == "0")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.Write("[10]");
                }
                else if (vuelos[f][10] == "1")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[10]"); Console.ResetColor();
                }

                if (vuelos[f][11] == "0")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.Write("[11]");
                }
                else if (vuelos[f][11] == "1")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[11]"); Console.ResetColor();
                }

                if (vuelos[f][12] == "0")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.Write("[12]");
                }
                else if (vuelos[f][12] == "1")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[12]"); Console.ResetColor();
                }

                /*                 FIN PRIMERAS DOCE              */

                /*                 SEGUNDA DOCE              */

                if (vuelos[f][13] == "0")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.Write("[13]");
                }
                else if (vuelos[f][13] == "1")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[13]"); Console.ResetColor();
                }

                if (vuelos[f][14] == "0")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.Write("[14]");
                }
                else if (vuelos[f][14] == "1")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[14]"); Console.ResetColor();
                }

                if (vuelos[f][15] == "0")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.Write("[15]");
                }
                else if (vuelos[f][15] == "1")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[15]"); Console.ResetColor();
                }

                if (vuelos[f][16] == "0")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.Write("[16]");
                }
                else if (vuelos[f][16] == "1")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[16]"); Console.ResetColor();
                }

                if (vuelos[f][17] == "0")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.Write("[17]");
                }
                else if (vuelos[f][17] == "1")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[17]"); Console.ResetColor();
                }

                if (vuelos[f][18] == "0")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.Write("[18]");
                }
                else if (vuelos[f][18] == "1")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[18]"); Console.ResetColor();
                }

                if (vuelos[f][19] == "0")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.Write("[19]");
                }
                else if (vuelos[f][19] == "1")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[19]"); Console.ResetColor();
                }

                if (vuelos[f][20] == "0")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.Write("[20]");
                }
                else if (vuelos[f][20] == "1")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[20]"); Console.ResetColor();
                }

                if (vuelos[f][21] == "0")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.Write("[21]");
                }
                else if (vuelos[f][21] == "1")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[21]"); Console.ResetColor();
                }

                if (vuelos[f][22] == "0")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.Write("[22]");
                }
                else if (vuelos[f][22] == "1")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[22]"); Console.ResetColor();
                }

                if (vuelos[f][23] == "0")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.Write("[23]");
                }
                else if (vuelos[f][23] == "1")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[23]"); Console.ResetColor();
                }

                if (vuelos[f][24] == "0")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.Write("[24]");
                }
                else if (vuelos[f][24] == "1")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[24]"); Console.ResetColor();
                }

                /*                 FIN SEGUNDA DOCE              */

                /*                 TERCERA DOCE              */

                if (vuelos[f][25] == "0")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.Write("[25]");
                }
                else if (vuelos[f][25] == "1")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[25]"); Console.ResetColor();
                }

                if (vuelos[f][26] == "0")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.Write("[26]");
                }
                else if (vuelos[f][26] == "1")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[26]"); Console.ResetColor();
                }

                if (vuelos[f][27] == "0")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.Write("[27]");
                }
                else if (vuelos[f][27] == "1")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[27]"); Console.ResetColor();
                }

                if (vuelos[f][28] == "0")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.Write("[28]");
                }
                else if (vuelos[f][28] == "1")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[28]"); Console.ResetColor();
                }

                if (vuelos[f][29] == "0")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.Write("[29]");
                }
                else if (vuelos[f][29] == "1")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[29]"); Console.ResetColor();
                }

                if (vuelos[f][30] == "0")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.Write("[30]");
                }
                else if (vuelos[f][30] == "1")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[30]"); Console.ResetColor();
                }

                if (vuelos[f][31] == "0")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.Write("[31]");
                }
                else if (vuelos[f][31] == "1")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[31]"); Console.ResetColor();
                }

                if (vuelos[f][32] == "0")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.Write("[32]");
                }
                else if (vuelos[f][32] == "1")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[32]"); Console.ResetColor();
                }

                if (vuelos[f][33] == "0")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.Write("[33]");
                }
                else if (vuelos[f][33] == "1")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[33]"); Console.ResetColor();
                }

                if (vuelos[f][34] == "0")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.Write("[34]");
                }
                else if (vuelos[f][34] == "1")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[34]"); Console.ResetColor();
                }

                if (vuelos[f][35] == "0")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.Write("[35]");
                }
                else if (vuelos[f][35] == "1")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[35]"); Console.ResetColor();
                }

                if (vuelos[f][36] == "0")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.Write("[36]");
                }
                else if (vuelos[f][36] == "1")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[36]"); Console.ResetColor();
                }

                /*                 FIN TERCERA DOCE              */

                /*                 CUARTA DOCE              */

                if (vuelos[f][37] == "0")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.Write("[37]");
                }
                else if (vuelos[f][37] == "1")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[37]"); Console.ResetColor();
                }

                if (vuelos[f][38] == "0")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.Write("[38]");
                }
                else if (vuelos[f][38] == "1")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[38]"); Console.ResetColor();
                }

                if (vuelos[f][39] == "0")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.Write("[39]");
                }
                else if (vuelos[f][39] == "1")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[39]"); Console.ResetColor();
                }

                if (vuelos[f][40] == "0")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.Write("[40]");
                }
                else if (vuelos[f][40] == "1")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[40]"); Console.ResetColor();
                }

                if (vuelos[f][41] == "0")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.Write("[41]");
                }
                else if (vuelos[f][41] == "1")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[41]"); Console.ResetColor();
                }

                if (vuelos[f][42] == "0")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.Write("[42]");
                }
                else if (vuelos[f][42] == "1")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[42]"); Console.ResetColor();
                }

                if (vuelos[f][43] == "0")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.Write("[43]");
                }
                else if (vuelos[f][43] == "1")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[43]"); Console.ResetColor();
                }

                if (vuelos[f][44] == "0")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.Write("[44]");
                }
                else if (vuelos[f][44] == "1")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[44]"); Console.ResetColor();
                }

                if (vuelos[f][45] == "0")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.Write("[45]");
                }
                else if (vuelos[f][45] == "1")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[45]"); Console.ResetColor();
                }

                if (vuelos[f][46] == "0")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.Write("[46]");
                }
                else if (vuelos[f][46] == "1")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[46]"); Console.ResetColor();
                }

                if (vuelos[f][47] == "0")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.Write("[47]");
                }
                else if (vuelos[f][47] == "1")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[47]"); Console.ResetColor();
                }

                if (vuelos[f][48] == "0")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.Write("[48]");
                }
                else if (vuelos[f][48] == "1")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[48]"); Console.ResetColor();
                }

                /*                 FIN CUARTA DOCE              */

                /*                 QUINTA DOCE              */

                if (vuelos[f][49] == "0")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.Write("[49]");
                }
                else if (vuelos[f][49] == "1")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[49]"); Console.ResetColor();
                }

                if (vuelos[f][50] == "0")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.Write("[50]");
                }
                else if (vuelos[f][50] == "1")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[50]"); Console.ResetColor();
                }

                if (vuelos[f][51] == "0")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.Write("[51]");
                }
                else if (vuelos[f][51] == "1")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[51]"); Console.ResetColor();
                }

                if (vuelos[f][52] == "0")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.Write("[52]");
                }
                else if (vuelos[f][52] == "1")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[52]"); Console.ResetColor();
                }

                if (vuelos[f][53] == "0")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.Write("[53]");
                }
                else if (vuelos[f][53] == "1")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[53]"); Console.ResetColor();
                }

                if (vuelos[f][54] == "0")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.Write("[54]");
                }
                else if (vuelos[f][54] == "1")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[54]"); Console.ResetColor();
                }

                if (vuelos[f][55] == "0")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.Write("[55]");
                }
                else if (vuelos[f][55] == "1")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[55]"); Console.ResetColor();
                }

                if (vuelos[f][56] == "0")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.Write("[56]");
                }
                else if (vuelos[f][56] == "1")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[56]"); Console.ResetColor();
                }

                if (vuelos[f][57] == "0")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.Write("[57]");
                }
                else if (vuelos[f][57] == "1")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[57]"); Console.ResetColor();
                }

                if (vuelos[f][58] == "0")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.Write("[58]");
                }
                else if (vuelos[f][58] == "1")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[58]"); Console.ResetColor();
                }

                if (vuelos[f][59] == "0")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.Write("[59]");
                }
                else if (vuelos[f][59] == "1")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[59]"); Console.ResetColor();
                }

                if (vuelos[f][60] == "0")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.Write("[60]");
                }
                else if (vuelos[f][60] == "1")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[60]"); Console.ResetColor();
                }


            }

        }

    }
    static void Mostrar_estado_de_vuelo_4()
    {
        bool salir = false;

        do
        {
            Console.Clear();
            Dibujar_Marco();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(68, 2);
            Console.Write("* * *"); Console.ResetColor();

            if (vuelos.Length == 0)
            {
                Console.SetCursorPosition(17, 9);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("          NO HAY VUELOS CREADOS  "); Console.ResetColor();

                Console.SetCursorPosition(17, 14);
                Console.Write("     Precione tecla para continuar... ");
                Console.ReadKey(); // volver a menu despues de errar 3 veces
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(23, 3);
            Console.Write("          ESTADO DE VUELO "); Console.ResetColor();

            int p = 6;  // variable para la posicion de vuelos (setcursorposition , adentro del for)
            int posicion = 1; // posicion de los vuelos cuando ve el usuario

            Console.SetCursorPosition(23, 6);
            for (int i = 0; i < vuelos.Length; i++)
            {
                Console.SetCursorPosition(23, p);
                Console.Write($"{posicion}) {vuelos[i][0]}");

                posicion++;
                p++;
            }
            p = p + 1;

            Console.SetCursorPosition(23, p);
            Console.Write($"   (Ingrese 0 para salir.) ");
            p = p + 3;

            Console.SetCursorPosition(23, p);
            Console.Write($"       Elegir vuelo: ");
            int vuelo_elegido = int.Parse(Console.ReadLine());

            vuelo_elegido = vuelo_elegido - 1;

            if (vuelo_elegido == -1)
            {
                salir = true;
                return;
            }
            p = p + 2;

            posicion = posicion - 1;

            if (vuelo_elegido >= posicion)
            {
                Console.SetCursorPosition(14, p);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("      OPCION INCONRRECTA, INTENTE NUEVAMENTE... "); Console.ResetColor();

                Thread.Sleep(1500);
            }
            else
            {
                int asientos_no_vendidos = 0;
                int asientos_vendidos = 0;

                for (int contar = 0; contar < 61; contar++)
                {

                    if (vuelos[vuelo_elegido][contar] == "0")
                    {
                        asientos_no_vendidos++;
                    }
                    if (vuelos[vuelo_elegido][contar] == "1")
                    {
                        asientos_vendidos++;
                    }

                }

                Ver_los_Asientos(vuelo_elegido, posicion, p);

                Console.SetCursorPosition(24, 19);
                Console.Write("(");
                Console.SetCursorPosition(25, 19);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Asientos vendidos {asientos_vendidos} "); Console.ResetColor();

                Console.SetCursorPosition(46, 19);
                Console.Write("/");
                Console.SetCursorPosition(48, 19);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Asientos no vendidos {asientos_no_vendidos}"); Console.ResetColor();
                Console.SetCursorPosition(71, 19);
                Console.Write(")");

                Console.SetCursorPosition(44, 21);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(vuelos[vuelo_elegido][0]); Console.ResetColor();

                Console.SetCursorPosition(29, 23);
                Console.Write("    Precione tecla para volver...  ");

                Console.ReadKey();

            }

        } while (salir != true);

        static void Ver_los_Asientos(int n, int t, int q)
        {
            if (n >= t)
            {
                return; // si no volvemos entra en la matrix y se rompe ya que es un numero mayor al rango
            }
            Console.Clear();

            Dibujar_Marco_Mapa_Avion_2();

            Butacas(n);

            static void Dibujar_Marco_Mapa_Avion_2()
            {
                int ancho = 95;
                int alto = 26;

                // Dibujar la parte superior del marco
                Console.WriteLine(" ┌" + new string('─', ancho - 2) + "┐");

                // Dibujar los lados del marco
                for (int i = 0; i < alto - 2; i++)
                {
                    Console.WriteLine(" │" + new string(' ', ancho - 2) + "│");
                }

                // Dibujar la parte inferior del marco
                Console.WriteLine(" └" + new string('─', ancho - 2) + "┘");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(89, 1);
                Console.Write("* * *"); Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(23, 2);
                Console.Write("                 MAPA DE ASIENTOS"); Console.ResetColor();

                Console.SetCursorPosition(13, 5);
                Console.Write("┌====================================================================┐");

                Console.SetCursorPosition(16, 4);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(16, 13);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(2, 10);
                Console.Write(" Delantera                                                                        Trasera");

                Console.SetCursorPosition(16, 8);
                Console.Write("pasillo                     pasillo                     pasillo");

                Console.SetCursorPosition(16, 17);
                Console.Write("ventana                     ventana                     ventana");

                Console.SetCursorPosition(13, 16);
                Console.Write("└====================================================================┘");

            }

            static void Butacas(int f)
            {
                /*               PRIMERAS DOCE              */

                if (vuelos[f][1] == "1")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[01]"); Console.ResetColor();
                }
                else if (vuelos[f][1] == "0")
                {
                    Console.SetCursorPosition(14, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[01]"); Console.ResetColor();
                }

                if (vuelos[f][2] == "1")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[02]"); Console.ResetColor();
                }
                else if (vuelos[f][2] == "0")
                {
                    Console.SetCursorPosition(14, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[02]"); Console.ResetColor();
                }

                if (vuelos[f][3] == "1")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[03]"); Console.ResetColor();
                }
                else if (vuelos[f][3] == "0")
                {
                    Console.SetCursorPosition(14, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[03]"); Console.ResetColor();
                }

                if (vuelos[f][4] == "1")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[04]"); Console.ResetColor();
                }
                else if (vuelos[f][4] == "0")
                {
                    Console.SetCursorPosition(14, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[04]"); Console.ResetColor();
                }

                if (vuelos[f][5] == "1")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[05]"); Console.ResetColor();
                }
                else if (vuelos[f][5] == "0")
                {
                    Console.SetCursorPosition(18, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[05]"); Console.ResetColor();
                }

                if (vuelos[f][6] == "1")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[06]"); Console.ResetColor();
                }
                else if (vuelos[f][6] == "0")
                {
                    Console.SetCursorPosition(18, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[06]"); Console.ResetColor();
                }

                if (vuelos[f][7] == "1")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[07]"); Console.ResetColor();
                }
                else if (vuelos[f][7] == "0")
                {
                    Console.SetCursorPosition(18, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[07]"); Console.ResetColor();
                }

                if (vuelos[f][8] == "1")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[08]"); Console.ResetColor();
                }
                else if (vuelos[f][8] == "0")
                {
                    Console.SetCursorPosition(18, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[08]"); Console.ResetColor();
                }

                if (vuelos[f][9] == "1")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[09]"); Console.ResetColor();
                }
                else if (vuelos[f][9] == "0")
                {
                    Console.SetCursorPosition(22, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[09]"); Console.ResetColor();
                }


                if (vuelos[f][10] == "1")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[10]"); Console.ResetColor();
                }
                else if (vuelos[f][10] == "0")
                {
                    Console.SetCursorPosition(22, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[10]"); Console.ResetColor();
                }

                if (vuelos[f][11] == "1")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[11]"); Console.ResetColor();
                }
                else if (vuelos[f][11] == "0")
                {
                    Console.SetCursorPosition(22, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[11]"); Console.ResetColor();
                }

                if (vuelos[f][12] == "1")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[12]"); Console.ResetColor();
                }
                else if (vuelos[f][12] == "0")
                {
                    Console.SetCursorPosition(22, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[12]"); Console.ResetColor();
                }

                /*                 FIN PRIMERAS DOCE              */

                /*                 SEGUNDA DOCE              */

                if (vuelos[f][13] == "1")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[13]"); Console.ResetColor();
                }
                else if (vuelos[f][13] == "0")
                {
                    Console.SetCursorPosition(28, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[13]"); Console.ResetColor();
                }

                if (vuelos[f][14] == "1")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[14]"); Console.ResetColor();
                }
                else if (vuelos[f][14] == "0")
                {
                    Console.SetCursorPosition(28, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[14]"); Console.ResetColor();
                }

                if (vuelos[f][15] == "1")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[15]"); Console.ResetColor();
                }
                else if (vuelos[f][15] == "0")
                {
                    Console.SetCursorPosition(28, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[15]"); Console.ResetColor();
                }

                if (vuelos[f][16] == "1")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[16]"); Console.ResetColor();
                }
                else if (vuelos[f][16] == "0")
                {
                    Console.SetCursorPosition(28, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[16]"); Console.ResetColor();
                }

                if (vuelos[f][17] == "1")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[17]"); Console.ResetColor();
                }
                else if (vuelos[f][17] == "0")
                {
                    Console.SetCursorPosition(32, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[17]"); Console.ResetColor();
                }

                if (vuelos[f][18] == "1")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[18]"); Console.ResetColor();
                }
                else if (vuelos[f][18] == "0")
                {
                    Console.SetCursorPosition(32, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[18]"); Console.ResetColor();
                }

                if (vuelos[f][19] == "1")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[19]"); Console.ResetColor();
                }
                else if (vuelos[f][19] == "0")
                {
                    Console.SetCursorPosition(32, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[19]"); Console.ResetColor();
                }

                if (vuelos[f][20] == "1")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[20]"); Console.ResetColor();
                }
                else if (vuelos[f][20] == "0")
                {
                    Console.SetCursorPosition(32, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[20]"); Console.ResetColor();
                }

                if (vuelos[f][21] == "1")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[21]"); Console.ResetColor();
                }
                else if (vuelos[f][21] == "0")
                {
                    Console.SetCursorPosition(36, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[21]"); Console.ResetColor();
                }

                if (vuelos[f][22] == "1")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[22]"); Console.ResetColor();
                }
                else if (vuelos[f][22] == "0")
                {
                    Console.SetCursorPosition(36, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[22]"); Console.ResetColor();
                }

                if (vuelos[f][23] == "1")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[23]"); Console.ResetColor();
                }
                else if (vuelos[f][23] == "0")
                {
                    Console.SetCursorPosition(36, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[23]"); Console.ResetColor();
                }

                if (vuelos[f][24] == "1")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[24]"); Console.ResetColor();
                }
                else if (vuelos[f][24] == "0")
                {
                    Console.SetCursorPosition(36, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[24]"); Console.ResetColor();
                }

                /*                 FIN SEGUNDA DOCE              */

                /*                 TERCERA DOCE              */

                if (vuelos[f][25] == "1")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[25]"); Console.ResetColor();
                }
                else if (vuelos[f][25] == "0")
                {
                    Console.SetCursorPosition(42, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[25]"); Console.ResetColor();
                }

                if (vuelos[f][26] == "1")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[26]"); Console.ResetColor();
                }
                else if (vuelos[f][26] == "0")
                {
                    Console.SetCursorPosition(42, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[26]"); Console.ResetColor();
                }

                if (vuelos[f][27] == "1")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[27]"); Console.ResetColor();
                }
                else if (vuelos[f][27] == "0")
                {
                    Console.SetCursorPosition(42, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[27]"); Console.ResetColor();
                }

                if (vuelos[f][28] == "1")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[28]"); Console.ResetColor();
                }
                else if (vuelos[f][28] == "0")
                {
                    Console.SetCursorPosition(42, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[28]"); Console.ResetColor();
                }

                if (vuelos[f][29] == "1")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[29]"); Console.ResetColor();
                }
                else if (vuelos[f][29] == "0")
                {
                    Console.SetCursorPosition(46, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[29]"); Console.ResetColor();
                }

                if (vuelos[f][30] == "1")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[30]"); Console.ResetColor();
                }
                else if (vuelos[f][30] == "0")
                {
                    Console.SetCursorPosition(46, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[30]"); Console.ResetColor();
                }

                if (vuelos[f][31] == "1")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[31]"); Console.ResetColor();
                }
                else if (vuelos[f][31] == "0")
                {
                    Console.SetCursorPosition(46, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[31]"); Console.ResetColor();
                }

                if (vuelos[f][32] == "1")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[32]"); Console.ResetColor();
                }
                else if (vuelos[f][32] == "0")
                {
                    Console.SetCursorPosition(46, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[32]"); Console.ResetColor();
                }

                if (vuelos[f][33] == "1")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[33]"); Console.ResetColor();
                }
                else if (vuelos[f][33] == "0")
                {
                    Console.SetCursorPosition(50, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[33]"); Console.ResetColor();
                }

                if (vuelos[f][34] == "1")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[34]"); Console.ResetColor();
                }
                else if (vuelos[f][34] == "0")
                {
                    Console.SetCursorPosition(50, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[34]"); Console.ResetColor();
                }

                if (vuelos[f][35] == "1")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[35]"); Console.ResetColor();
                }
                else if (vuelos[f][35] == "0")
                {
                    Console.SetCursorPosition(50, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[35]"); Console.ResetColor();
                }

                if (vuelos[f][36] == "1")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[36]"); Console.ResetColor();
                }
                else if (vuelos[f][36] == "0")
                {
                    Console.SetCursorPosition(50, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[36]"); Console.ResetColor();
                }

                /*                 FIN TERCERA DOCE              */

                /*                 CUARTA DOCE              */

                if (vuelos[f][37] == "1")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[37]"); Console.ResetColor();
                }
                else if (vuelos[f][37] == "0")
                {
                    Console.SetCursorPosition(56, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[37]"); Console.ResetColor();
                }

                if (vuelos[f][38] == "1")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[38]"); Console.ResetColor();
                }
                else if (vuelos[f][38] == "0")
                {
                    Console.SetCursorPosition(56, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[38]"); Console.ResetColor();
                }

                if (vuelos[f][39] == "1")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[39]"); Console.ResetColor();
                }
                else if (vuelos[f][39] == "0")
                {
                    Console.SetCursorPosition(56, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[39]"); Console.ResetColor();
                }

                if (vuelos[f][40] == "1")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[40]"); Console.ResetColor();
                }
                else if (vuelos[f][40] == "0")
                {
                    Console.SetCursorPosition(56, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[40]"); Console.ResetColor();
                }

                if (vuelos[f][41] == "1")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[41]"); Console.ResetColor();
                }
                else if (vuelos[f][41] == "0")
                {
                    Console.SetCursorPosition(60, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[41]"); Console.ResetColor();
                }

                if (vuelos[f][42] == "1")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[42]"); Console.ResetColor();
                }
                else if (vuelos[f][42] == "0")
                {
                    Console.SetCursorPosition(60, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[42]"); Console.ResetColor();
                }

                if (vuelos[f][43] == "1")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[43]"); Console.ResetColor();
                }
                else if (vuelos[f][43] == "0")
                {
                    Console.SetCursorPosition(60, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[43]"); Console.ResetColor();
                }

                if (vuelos[f][44] == "1")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[44]"); Console.ResetColor();
                }
                else if (vuelos[f][44] == "0")
                {
                    Console.SetCursorPosition(60, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[44]"); Console.ResetColor();
                }

                if (vuelos[f][45] == "1")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[45]"); Console.ResetColor();
                }
                else if (vuelos[f][45] == "0")
                {
                    Console.SetCursorPosition(64, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[45]"); Console.ResetColor();
                }

                if (vuelos[f][46] == "1")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[46]"); Console.ResetColor();
                }
                else if (vuelos[f][46] == "0")
                {
                    Console.SetCursorPosition(64, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[46]"); Console.ResetColor();
                }

                if (vuelos[f][47] == "1")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[47]"); Console.ResetColor();
                }
                else if (vuelos[f][47] == "0")
                {
                    Console.SetCursorPosition(64, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[47]"); Console.ResetColor();
                }

                if (vuelos[f][48] == "1")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[48]"); Console.ResetColor();
                }
                else if (vuelos[f][48] == "0")
                {
                    Console.SetCursorPosition(64, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[48]"); Console.ResetColor();
                }

                /*                 FIN CUARTA DOCE              */

                /*                 QUINTA DOCE              */

                if (vuelos[f][49] == "1")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[49]"); Console.ResetColor();
                }
                else if (vuelos[f][49] == "0")
                {
                    Console.SetCursorPosition(70, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[49]"); Console.ResetColor();
                }

                if (vuelos[f][50] == "1")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[50]"); Console.ResetColor();
                }
                else if (vuelos[f][50] == "0")
                {
                    Console.SetCursorPosition(70, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[50]"); Console.ResetColor();
                }

                if (vuelos[f][51] == "1")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[51]"); Console.ResetColor();
                }
                else if (vuelos[f][51] == "0")
                {
                    Console.SetCursorPosition(70, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[51]"); Console.ResetColor();
                }

                if (vuelos[f][52] == "1")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[52]"); Console.ResetColor();
                }
                else if (vuelos[f][52] == "0")
                {
                    Console.SetCursorPosition(70, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[52]"); Console.ResetColor();
                }

                if (vuelos[f][53] == "1")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[53]"); Console.ResetColor();
                }
                else if (vuelos[f][53] == "0")
                {
                    Console.SetCursorPosition(74, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[53]"); Console.ResetColor();
                }

                if (vuelos[f][54] == "1")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[54]"); Console.ResetColor();
                }
                else if (vuelos[f][54] == "0")
                {
                    Console.SetCursorPosition(74, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[54]"); Console.ResetColor();
                }

                if (vuelos[f][55] == "1")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[55]"); Console.ResetColor();
                }
                else if (vuelos[f][55] == "0")
                {
                    Console.SetCursorPosition(74, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[55]"); Console.ResetColor();
                }

                if (vuelos[f][56] == "1")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[56]"); Console.ResetColor();
                }
                else if (vuelos[f][56] == "0")
                {
                    Console.SetCursorPosition(74, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[56]"); Console.ResetColor();
                }

                if (vuelos[f][57] == "1")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[57]"); Console.ResetColor();
                }
                else if (vuelos[f][57] == "0")
                {
                    Console.SetCursorPosition(78, 6);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[57]"); Console.ResetColor();
                }

                if (vuelos[f][58] == "1")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[58]"); Console.ResetColor();
                }
                else if (vuelos[f][58] == "0")
                {
                    Console.SetCursorPosition(78, 10);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[58]"); Console.ResetColor();
                }

                if (vuelos[f][59] == "1")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[59]"); Console.ResetColor();
                }
                else if (vuelos[f][59] == "0")
                {
                    Console.SetCursorPosition(78, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[59]"); Console.ResetColor();
                }

                if (vuelos[f][60] == "1")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[60]"); Console.ResetColor();
                }
                else if (vuelos[f][60] == "0")
                {
                    Console.SetCursorPosition(78, 15);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[60]"); Console.ResetColor();
                }
            }
        }
    }


}