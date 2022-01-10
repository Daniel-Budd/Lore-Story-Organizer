using System;
using static System.Console;

namespace ProgramLib
{
  public class ProgramConsole
  {
    public static void SetColor(ConsoleStyle style)
    {
      ForegroundColor = style.Foreground;
      BackgroundColor = style.Background;
    }
    public static void Print(string text)
    {
      Write(text);
    }
    public static void Print(object item)
    {
      Write(item.ToString());
    }
    public static void Print(string text, ConsoleStyle style)
    {
      SetColor(style);
      Write(text);
      ResetColor();
    }
    public static void Print(object item, ConsoleStyle style)
    {
      SetColor(style);
      Write(item.ToString());
      ResetColor();
    }
    public static void PrintAt(int x, int y, string text)
    {
      Goto(x,y);
      Write(text);
    }
    public static void PrintAt(int x, int y, object item)
    {
      Goto(x,y);
      Write(item.ToString());
    }
    public static void Goto(int x, int y)
    {
      SetCursorPosition(Math.Min(BufferWidth,x),Math.Min(y,BufferHeight));
    }
  }
}