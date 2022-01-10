using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgramLib.LoreLib
{
  public interface IMentionable
  {
    List<Mention> references { get; }
    void AddReference(Mention m)
    {
      references.Add(m);
    }
  }
}