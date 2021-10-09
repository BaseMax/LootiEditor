        public static string KEY(string PATH)
        {
            if (PATH.Length > 16)
            {
                return null;
            }
            if (!File.Exists(@PATH))
            {
                File.Create(@PATH);
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 80; i++) Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Looti Editor - " + @PATH + "\n");
            for (int i = 0; i < 80; i++) Console.Write("_");
            Console.SetCursorPosition(0, 1);
            Console.Write("ESC for exit");
            Console.SetCursorPosition(0, 2);
            Console.BackgroundColor = ConsoleColor.Blue;
            int xint = Console.CursorLeft;
            int yint = Console.CursorTop;
            string open = File.ReadAllText(Directory.GetCurrentDirectory() + @PATH);
            Console.Write(open);
            for (; ; )
            {
                
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    
                    for(; ; )
                    {
                        File.AppendAllText(@PATH, " ");
                        Console.Write(" ");
                        xint = Console.CursorLeft;
                        if (xint == 0) break;
                    }

                }
                else if (input.Key == ConsoleKey.NumPad1)
                {
                    File.AppendAllText(@PATH, "1");
                }
                else if (input.Key == ConsoleKey.NumPad2)
                {
                    File.AppendAllText(@PATH, "2");
                }
                else if (input.Key == ConsoleKey.NumPad3)
                {
                    File.AppendAllText(@PATH, "3");
                }
                else if (input.Key == ConsoleKey.NumPad4)
                {
                    File.AppendAllText(@PATH, "4");
                }
                else if (input.Key == ConsoleKey.NumPad5)
                {
                    File.AppendAllText(@PATH, "5");
                }
                else if (input.Key == ConsoleKey.NumPad6)
                {
                    File.AppendAllText(@PATH, "6");
                }
                else if (input.Key == ConsoleKey.NumPad7)
                {
                    File.AppendAllText(@PATH, "7");
                }
                else if (input.Key == ConsoleKey.NumPad8)
                {
                    File.AppendAllText(@PATH, "8");
                }
                else if (input.Key == ConsoleKey.NumPad9)
                {
                    File.AppendAllText(@PATH, "9");
                }
                else if (input.Key == ConsoleKey.NumPad0)
                {
                    File.AppendAllText(@PATH, "0");
                }
                else if(input.KeyChar == '!')
                {
                    File.AppendAllText(@PATH, "!");
                }
                else if (input.KeyChar == '@')
                {
                    File.AppendAllText(@PATH, "@");
                }
                else if (input.KeyChar == '#')
                {
                    File.AppendAllText(@PATH, "#");
                }
                else if (input.KeyChar == '$')
                {
                    File.AppendAllText(@PATH, "$");
                }
                else if (input.KeyChar == '%')
                {
                    File.AppendAllText(@PATH, "%");
                }
                else if (input.KeyChar == '^')
                {
                    File.AppendAllText(@PATH, "^");
                }
                else if (input.KeyChar == '&')
                {
                    File.AppendAllText(@PATH, "&");
                }
                else if (input.KeyChar == '*')
                {
                    File.AppendAllText(@PATH, "*");
                }
                else if (input.KeyChar == '(')
                {
                    File.AppendAllText(@PATH, "(");
                }
                else if (input.KeyChar == ')')
                {
                    File.AppendAllText(@PATH, ")");
                }
                else if (input.KeyChar == '-')
                {
                    File.AppendAllText(@PATH, "-");
                }
                else if (input.KeyChar == '_')
                {
                    File.AppendAllText(@PATH, "_");
                }
                else if (input.KeyChar == '=')
                {
                    File.AppendAllText(@PATH, "=");
                }
                else if (input.KeyChar == '+')
                {
                    File.AppendAllText(@PATH, "+");
                }
                else if (input.KeyChar == '[')
                {
                    File.AppendAllText(@PATH, "[");
                }
                else if (input.KeyChar == ']')
                {
                    File.AppendAllText(@PATH, "]");
                }
                else if (input.KeyChar == '{')
                {
                    File.AppendAllText(@PATH, "{");
                }
                else if (input.KeyChar == '}')
                {
                    File.AppendAllText(@PATH, "}");
                }
                else if (input.KeyChar == ';')
                {
                    File.AppendAllText(@PATH, ";");
                }
                else if (input.KeyChar == ':')
                {
                    File.AppendAllText(@PATH, ":");
                }
                else if (input.KeyChar == '\'')
                {
                    File.AppendAllText(@PATH, "\"");
                }
                else if (input.KeyChar == ',')
                {
                    File.AppendAllText(@PATH, ",");
                }
                else if (input.KeyChar == '.')
                {
                    File.AppendAllText(@PATH, ".");
                }
                else if (input.KeyChar == '<')
                {
                    File.AppendAllText(@PATH, ">");
                }
                else if (input.KeyChar == '/')
                {
                    File.AppendAllText(@PATH, "/");
                }
                else if (input.KeyChar == '?')
                {
                    File.AppendAllText(@PATH, "?");
                }
                else if (input.KeyChar == '|')
                {
                    File.AppendAllText(@PATH, "|");
                }
                else if (input.KeyChar == '\\')
                {
                    File.AppendAllText(@PATH, "\\");
                }
                else if (input.KeyChar == '`')
                {
                    File.AppendAllText(@PATH, "`");
                }
                else if (input.KeyChar == '~')
                {
                    File.AppendAllText(@PATH, "~");
                }
                else if (input.Key == ConsoleKey.D1)
                {
                    File.AppendAllText(@PATH, "1");
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    File.AppendAllText(@PATH, "2");
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    File.AppendAllText(@PATH, "3");
                }
                else if (input.Key == ConsoleKey.D4)
                {
                    File.AppendAllText(@PATH, "4");
                }
                else if (input.Key == ConsoleKey.D5)
                {
                    File.AppendAllText(@PATH, "5");
                }
                else if (input.Key == ConsoleKey.D6)
                {
                    File.AppendAllText(@PATH, "6");
                }
                else if (input.Key == ConsoleKey.D7)
                {
                    File.AppendAllText(@PATH, "7");
                }
                else if (input.Key == ConsoleKey.D8)
                {
                    File.AppendAllText(@PATH, "8");
                }
                else if (input.Key == ConsoleKey.D9)
                {
                    File.AppendAllText(@PATH, "9");
                }
                else if (input.Key == ConsoleKey.D0)
                {
                    File.AppendAllText(@PATH, "0");
                }
                else if (input.Key == ConsoleKey.A)
                {
                    File.AppendAllText(@PATH, "A");
                }
                else if (input.Key == ConsoleKey.B)
                {
                    File.AppendAllText(@PATH, "B");
                }
                else if (input.Key == ConsoleKey.C)
                {
                    File.AppendAllText(@PATH, "C");
                }
                else if (input.Key == ConsoleKey.D)
                {
                    File.AppendAllText(@PATH, "D");
                }
                else if (input.Key == ConsoleKey.E)
                {
                    File.AppendAllText(@PATH, "E");
                }
                else if (input.Key == ConsoleKey.D)
                {
                    File.AppendAllText(@PATH, "D");
                }
                else if (input.Key == ConsoleKey.G)
                {
                    File.AppendAllText(@PATH, "G");
                }
                else if (input.Key == ConsoleKey.H)
                {
                    File.AppendAllText(@PATH, "H");
                }
                else if (input.Key == ConsoleKey.I)
                {
                    File.AppendAllText(@PATH, "I");
                }
                else if (input.Key == ConsoleKey.J)
                {
                    File.AppendAllText(@PATH, "J");
                }
                else if (input.Key == ConsoleKey.K)
                {
                    File.AppendAllText(@PATH, "K");
                }
                else if (input.Key == ConsoleKey.L)
                {
                    File.AppendAllText(@PATH, "L");
                }
                else if (input.Key == ConsoleKey.M)
                {
                    File.AppendAllText(@PATH, "M");
                }
                else if (input.Key == ConsoleKey.N)
                {
                    File.AppendAllText(@PATH, "N");
                }
                else if (input.Key == ConsoleKey.O)
                {
                    File.AppendAllText(@PATH, "O");
                }
                else if (input.Key == ConsoleKey.P)
                {
                    File.AppendAllText(@PATH, "P");
                }
                else if (input.Key == ConsoleKey.R)
                {
                    File.AppendAllText(@PATH, "R");
                }
                else if (input.Key == ConsoleKey.S)
                {
                    File.AppendAllText(@PATH, "S");
                }
                else if (input.Key == ConsoleKey.T)
                {
                    File.AppendAllText(@PATH, "T");
                }
                else if (input.Key == ConsoleKey.U)
                {
                    File.AppendAllText(@PATH, "U");
                }
                else if (input.Key == ConsoleKey.W)
                {
                    File.AppendAllText(@PATH, "W");
                }
                else if (input.Key == ConsoleKey.V)
                {
                    File.AppendAllText(@PATH, "V");
                }
                else if (input.Key == ConsoleKey.Y)
                {
                    File.AppendAllText(@PATH, "Y");
                }
                else if (input.Key == ConsoleKey.X)
                {
                    File.AppendAllText(@PATH, "X");
                }
                else if (input.Key == ConsoleKey.Q)
                {
                    File.AppendAllText(@PATH, "Q");
                }
                else if (input.Key == ConsoleKey.Z)
                {
                    File.AppendAllText(@PATH, "Z");
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Clear();
                    return null;
                }
                else if (input.Key == ConsoleKey.Tab)
                {
                    File.AppendAllText(@PATH, "   ");
                    Console.Write("   ");
                }
                else if (input.Key == ConsoleKey.Spacebar)
                {
                    File.AppendAllText(@PATH, " ");
                }
                else if (input.Key == ConsoleKey.Backspace )
                {
                    string back = File.ReadAllText(PATH);
                    if (back.Length != 0)
                    {
                        xint = Console.CursorLeft;
                        yint = Console.CursorTop;
                        int del = back.Length;
                        back = back.Remove(del - 1, 1);
                        File.Create(PATH);
                        File.AppendAllText(@PATH, back);

                        xint--;
                        Console.SetCursorPosition(xint, yint);
                        Console.Write(" ");
                        Console.SetCursorPosition(xint, yint);
                    }
                }

            }
        }
