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
using ReSharper.NTriples.Tree;
using ReSharper.NTriples.Parsing;
namespace ReSharper.NTriples.Impl.Tree {
  internal partial class Expression : NTriplesCompositeElement, ReSharper.NTriples.Tree.IExpression {
    public const short IDENTIFIER= ChildRole.LAST + 1;
    internal Expression() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return ReSharper.NTriples.Impl.Tree.ElementType.EXPRESSION; }
    }
    public override void Accept(ReSharper.NTriples.Tree.TreeNodeVisitor visitor) {
      visitor.VisitExpression(this);
    }
    public override void Accept<TContext>(ReSharper.NTriples.Tree.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitExpression(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(ReSharper.NTriples.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitExpression(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(ReSharper.NTriples.Impl.Tree.ElementType.IDENTIFIER, IDENTIFIER),
      }
    );
    public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public virtual JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<ReSharper.NTriples.Tree.IIdentifier> Identifiers {
      get { return FindListOfChildrenByRole<ReSharper.NTriples.Tree.IIdentifier>(IDENTIFIER); }
    }
    public virtual JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<ReSharper.NTriples.Tree.IIdentifier> IdentifiersEnumerable {
      get { return AsChildrenEnumerable<ReSharper.NTriples.Tree.IIdentifier>(IDENTIFIER); }
    }
    public override string ToString() {
      return "IExpression";
    }
  }
}
