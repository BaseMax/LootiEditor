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
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 80; i++) Console.Write(" ");
            Console.SetCursorPosition(0, 0);
            Console.Write("Looti Editor - " + @PATH + "\n");
            Console.SetCursorPosition(49, 0);
            Console.Write("Github.com/BaseMax/LootiEditor/");
            for (int i = 0; i < 80; i++) Console.Write("_");
            Console.SetCursorPosition(0, 1);
            Console.Write("ESC for exit ___ F1 for save ");
            Console.SetCursorPosition(0, 2);
            Console.BackgroundColor = ConsoleColor.Blue;
            int xint = Console.CursorLeft;
            Console.ForegroundColor = ConsoleColor.Gray;
            int yint = Console.CursorTop;
            string old = File.ReadAllText(Directory.GetCurrentDirectory() + @PATH);
            string tosav= File.ReadAllText(Directory.GetCurrentDirectory() + @PATH);
            Console.Write(tosav);
            for (; ; )
            {
                
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.Enter)
                {
                    
                    for(; ; )
                    {
                        tosav += " ";
                        Console.Write(" ");
                        xint = Console.CursorLeft;
                        if (xint == 0) break;
                    }

                }
                else if (input.Key == ConsoleKey.NumPad1)
                {
                    tosav += "1";
                }
                else if (input.Key == ConsoleKey.NumPad2)
                {
                    tosav += "2";
                }
                else if (input.Key == ConsoleKey.NumPad3)
                {
                    tosav += "3";
                }
                else if (input.Key == ConsoleKey.NumPad4)
                {
                    tosav += "4";
                }
                else if (input.Key == ConsoleKey.NumPad5)
                {
                    tosav += "5";
                }
                else if (input.Key == ConsoleKey.NumPad6)
                {
                    tosav += "6";
                }
                else if (input.Key == ConsoleKey.NumPad7)
                {
                    tosav += "7";
                }
                else if (input.Key == ConsoleKey.NumPad8)
                {
                    tosav += "8";
                }
                else if (input.Key == ConsoleKey.NumPad9)
                {
                    tosav += "9";
                }
                else if (input.Key == ConsoleKey.NumPad0)
                {
                    tosav += "0";
                }
                else if(input.KeyChar == '!')
                {
                    tosav += "!";
                }
                else if (input.KeyChar == '@')
                {
                    tosav += "@";
                }
                else if (input.KeyChar == '#')
                {
                    tosav += "#";
                }
                else if (input.KeyChar == '$')
                {
                    tosav += "$";
                }
                else if (input.KeyChar == '%')
                {
                    tosav += "%";
                }
                else if (input.KeyChar == '^')
                {
                    tosav += "^";
                }
                else if (input.KeyChar == '&')
                {
                    tosav += "&";
                }
                else if (input.KeyChar == '*')
                {
                    tosav += "*";
                }
                else if (input.KeyChar == '(')
                {
                    tosav += "(";
                }
                else if (input.KeyChar == ')')
                {
                    tosav += ")";
                }
                else if (input.KeyChar == '-')
                {
                    tosav += "-";
                }
                else if (input.KeyChar == '_')
                {
                    tosav += "_";
                }
                else if (input.KeyChar == '=')
                {
                    tosav += "=";
                }
                else if (input.KeyChar == '+')
                {
                    tosav += "+";
                }
                else if (input.KeyChar == '[')
                {
                    tosav += "[";
                }
                else if (input.KeyChar == ']')
                {
                    tosav += "]";
                }
                else if (input.KeyChar == '{')
                {
                    tosav += "{";
                }
                else if (input.KeyChar == '}')
                {
                    tosav += "}";
                }
                else if (input.KeyChar == ';')
                {
                    tosav += ";";
                }
                else if (input.KeyChar == ':')
                {
                    tosav += ":";
                }
                else if (input.KeyChar == '\'')
                {
                    tosav += "\"";
                }
                else if (input.KeyChar == ',')
                {
                    tosav += ",";
                }
                else if (input.KeyChar == '.')
                {
                    tosav += ".";
                }
                else if (input.KeyChar == '<')
                {
                    tosav += ">";
                }
                else if (input.KeyChar == '/')
                {
                    tosav += "/";
                }
                else if (input.KeyChar == '?')
                {
                    tosav += "?";
                }
                else if (input.KeyChar == '|')
                {
                    tosav += "|";
                }
                else if (input.KeyChar == '\\')
                {
                    tosav += "\\";
                }
                else if (input.KeyChar == '`')
                {
                    tosav += "`";
                }
                else if (input.KeyChar == '~')
                {
                    tosav += "~";
                }
                else if (input.Key == ConsoleKey.D1)
                {
                    tosav += "1";
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    tosav += "2";
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    tosav += "3";
                }
                else if (input.Key == ConsoleKey.D4)
                {
                    tosav += "4";
                }
                else if (input.Key == ConsoleKey.D5)
                {
                    tosav += "5";
                }
                else if (input.Key == ConsoleKey.D6)
                {
                    tosav += "6";
                }
                else if (input.Key == ConsoleKey.D7)
                {
                    tosav += "7";
                }
                else if (input.Key == ConsoleKey.D8)
                {
                    tosav += "8";
                }
                else if (input.Key == ConsoleKey.D9)
                {
                    tosav += "9";
                }
                else if (input.Key == ConsoleKey.D0)
                {
                    tosav += "0";
                }
                else if (input.Key == ConsoleKey.A)
                {
                    tosav += "A";
                }
                else if (input.Key == ConsoleKey.B)
                {
                    tosav += "B";
                }
                else if (input.Key == ConsoleKey.C)
                {
                    tosav += "C";
                }
                else if (input.Key == ConsoleKey.D)
                {
                    tosav += "D";
                }
                else if (input.Key == ConsoleKey.E)
                {
                    tosav += "E";
                }
                else if (input.Key == ConsoleKey.D)
                {
                    tosav += "D";
                }
                else if (input.Key == ConsoleKey.G)
                {
                    tosav += "G";
                }
                else if (input.Key == ConsoleKey.H)
                {
                   tosav +="H";
                }
                else if (input.Key == ConsoleKey.I)
                {
                   tosav +="I";
                }
                else if (input.Key == ConsoleKey.J)
                {
                   tosav +="J";
                }
                else if (input.Key == ConsoleKey.K)
                {
                   tosav +="K";
                }
                else if (input.Key == ConsoleKey.L)
                {
                   tosav +="L";
                }
                else if (input.Key == ConsoleKey.M)
                {
                   tosav +="M";
                }
                else if (input.Key == ConsoleKey.N)
                {
                   tosav +="N";
                }
                else if (input.Key == ConsoleKey.O)
                {
                   tosav +="O";
                }
                else if (input.Key == ConsoleKey.P)
                {
                   tosav +="P";
                }
                else if (input.Key == ConsoleKey.R)
                {
                   tosav +="R";
                }
                else if (input.Key == ConsoleKey.S)
                {
                   tosav +="S";
                }
                else if (input.Key == ConsoleKey.T)
                {
                   tosav +="T";
                }
                else if (input.Key == ConsoleKey.U)
                {
                   tosav +="U";
                }
                else if (input.Key == ConsoleKey.W)
                {
                   tosav +="W";
                }
                else if (input.Key == ConsoleKey.V)
                {
                   tosav +="V";
                }
                else if (input.Key == ConsoleKey.Y)
                {
                   tosav +="Y";
                }
                else if (input.Key == ConsoleKey.X)
                {
                   tosav +="X";
                }
                else if (input.Key == ConsoleKey.Q)
                {
                   tosav +="Q";
                }
                else if (input.Key == ConsoleKey.Z)
                {
                   tosav +="Z";
                }
                else if (input.Key == ConsoleKey.Escape)
                {
                    bool shouldSave;
                    Console.SetCursorPosition(20, 13);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("[Do you want to save changes? Y/N ]");
                    string answer = Console.ReadKey().KeyChar.ToString();
                    if (answer.ToLower() == "y") shouldSave = true;
                    else shouldSave = false;
                    if (shouldSave==false)
                    {
                        File.Delete(@PATH);
                        File.AppendAllText(@PATH, old);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        return null;
                    }
                    else if (shouldSave==true)
                    {
                        File.Delete(@PATH);
                        File.AppendAllText(@PATH, tosav);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        return null;
                    }
                }
                else if (input.Key == ConsoleKey.F1)
                {
                    File.Delete(@PATH);
                    File.AppendAllText(@PATH, tosav);
                    old = tosav;
                }
                else if (input.Key == ConsoleKey.Tab)
                {
                    tosav +="   ";
                    Console.Write("   ");
                }
                else if (input.Key == ConsoleKey.Spacebar)
                {
                     tosav +=" ";
                }
                else if (input.Key == ConsoleKey.Backspace )
                {
                    string back = tosav;
                    if (back.Length != 0)
                    {
                        xint = Console.CursorLeft;
                        yint = Console.CursorTop;
                        int del = back.Length;
                        back = back.Remove(del - 1, 1);
                        File.Create(PATH);
                         tosav = back;

                        xint--;
                        Console.SetCursorPosition(xint, yint);
                        Console.Write(" ");
                        Console.SetCursorPosition(xint, yint);
                    }
                }

            }
        }
