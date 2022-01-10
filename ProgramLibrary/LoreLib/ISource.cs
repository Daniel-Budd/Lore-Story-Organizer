using System;
using System.Collections;
using System.Collections.Generic;
namespace ProgramLib.LoreLib
{
  public interface ISource
  {
    List<IMentionable> mentions { get; }
    void Mention(IMentionable target, string notes = "")
    {
      mentions.Add(target);
      target.AddMention(this, notes);
    }
  }
  public class LoreDatabase
  {
    // 
  }
}