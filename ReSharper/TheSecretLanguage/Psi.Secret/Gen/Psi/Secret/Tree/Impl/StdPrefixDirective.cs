//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.Secret.Parsing;
namespace JetBrains.ReSharper.Psi.Secret.Tree.Impl {
  internal partial class StdPrefixDirective : SecretCompositeElement, JetBrains.ReSharper.Psi.Secret.Tree.IStdPrefixDirective {
    internal StdPrefixDirective() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.Secret.Tree.Impl.ElementType.STD_PREFIX_DIRECTIVE; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.Secret.Tree.TreeNodeVisitor visitor) {
      visitor.VisitStdPrefixDirective(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.Secret.Tree.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitStdPrefixDirective(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.Secret.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitStdPrefixDirective(this, context);
    }
    public override string ToString() {
      return "IStdPrefixDirective";
    }
  }
}
