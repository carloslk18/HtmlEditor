using System;

namespace HtmlEditor{

public class Menu{

    public static void Show(){
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        DrawScreen();
        WriteOptions();

        var option = short.Parse(Console.ReadLine());
        HandleMenuOption(option);
    }

    public static void DrawScreen(){

        Console.Write("+");
        for (int i = 0; i<=30; i++){
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 10; lines++){
            Console.Write("|");
            for (int i = 0; i<=30; i++){
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i<=30; i++){
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void WriteOptions(){
        Console.SetCursorPosition(3,1);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3,2);
        Console.WriteLine("============");
        Console.SetCursorPosition(3,4);
        Console.WriteLine("Select an option below");
        Console.SetCursorPosition(3,5);
        Console.WriteLine("1 - New File");
        Console.SetCursorPosition(3,6);
        Console.WriteLine("2 - Open File");
        Console.SetCursorPosition(3,7);
        Console.WriteLine("0 - Exit");
        Console.SetCursorPosition(3,8);
        Console.WriteLine("Option: ");

    }

    public static void HandleMenuOption(short option){

        switch (option){
            case 1: {
                Editor.Show();
                Console.WriteLine("Editor");
            break;
            } 
            

            case 2: 
            Console.WriteLine("View");
            break;

            case 0: {
                Console.Clear();
                Environment.Exit(0);
                break;
            }

            default: Show();
            break;
        }
    }
}
}