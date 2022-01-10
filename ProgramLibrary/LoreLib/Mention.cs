using System;

namespace ProgramLib.LoreLib
{
  public struct Mention
  {
    public ISource source;
    public string notes;
    public Mention(ISource src, string extraInformation = "")
    {
      source = src;
      notes = extraInformation;
    }
    public static implicit operator (ISource source, string notes)(Mention m) => (m.source, m.notes);
    public static explicit operator Mention((ISource source, string notes) m) => new Mention(m.source, m.notes);
    public void Deconstruct(out ISource source,  out string notes)
    {
      source = this.source;
      notes = this.notes;
    }
  }
}