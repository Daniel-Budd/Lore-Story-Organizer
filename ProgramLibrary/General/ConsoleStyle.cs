using System;
using static System.Console;
using static ProgramLib.ProgramConsole;
namespace ProgramLib
{
  public struct ConsoleStyle
  {
    public ConsoleColor Foreground;
    public ConsoleColor Background;
    public ConsoleStyle(ConsoleColor fG, ConsoleColor bG = ConsoleColor.Black)
    {
      Foreground = fG;
      Background = bG;
    }
    public void Setup()
    {
      SetColor(this);
    }
    public void Deconstruct(out ConsoleColor foreground, out ConsoleColor background)
    {
      foreground = Foreground;
      background = Background;
    }
  }
}