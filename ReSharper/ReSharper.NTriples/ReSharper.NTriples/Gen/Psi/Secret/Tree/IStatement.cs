//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace ReSharper.NTriples.Tree {
  public partial interface IStatement : ReSharper.NTriples.Tree.ISecretTreeNode {
    ReSharper.NTriples.Tree.IFacts FactsElement { get; }
  
    ReSharper.NTriples.Tree.ISubject Subject { get; }
  
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<ReSharper.NTriples.Tree.IFact> Facts { get; }
    JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<ReSharper.NTriples.Tree.IFact> FactsEnumerable { get; }
    ReSharper.NTriples.Tree.IFacts SetFactsElement (ReSharper.NTriples.Tree.IFacts param);
  
    ReSharper.NTriples.Tree.ISubject SetSubject (ReSharper.NTriples.Tree.ISubject param);
  
  }
}
