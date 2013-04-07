//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
namespace JetBrains.ReSharper.Psi.Secret.Tree.Impl {
  public abstract class ElementType {
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ERROR_ELEMENT = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ErrorElement.NODE_TYPE;
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType _SECRET_FILE = _SECRET_FILE_INTERNAL.INSTANCE;
    private class _SECRET_FILE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly _SECRET_FILE_INTERNAL INSTANCE = new _SECRET_FILE_INTERNAL ();
      _SECRET_FILE_INTERNAL() : base("_SECRET_FILE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new SecretFile();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ANONYMOUS_IDENTIFIER = ANONYMOUS_IDENTIFIER_INTERNAL.INSTANCE;
    private class ANONYMOUS_IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly ANONYMOUS_IDENTIFIER_INTERNAL INSTANCE = new ANONYMOUS_IDENTIFIER_INTERNAL ();
      ANONYMOUS_IDENTIFIER_INTERNAL() : base("ANONYMOUS_IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new AnonymousIdentifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FACT = FACT_INTERNAL.INSTANCE;
    private class FACT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FACT_INTERNAL INSTANCE = new FACT_INTERNAL ();
      FACT_INTERNAL() : base("FACT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Fact();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FACTS = FACTS_INTERNAL.INSTANCE;
    private class FACTS_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly FACTS_INTERNAL INSTANCE = new FACTS_INTERNAL ();
      FACTS_INTERNAL() : base("FACTS") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Facts();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IDENTIFIER = IDENTIFIER_INTERNAL.INSTANCE;
    private class IDENTIFIER_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly IDENTIFIER_INTERNAL INSTANCE = new IDENTIFIER_INTERNAL ();
      IDENTIFIER_INTERNAL() : base("IDENTIFIER") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Identifier();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LITERAL = LITERAL_INTERNAL.INSTANCE;
    private class LITERAL_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly LITERAL_INTERNAL INSTANCE = new LITERAL_INTERNAL ();
      LITERAL_INTERNAL() : base("LITERAL") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Literal();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LITERAL_KEYWORDS = LITERAL_KEYWORDS_INTERNAL.INSTANCE;
    private class LITERAL_KEYWORDS_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly LITERAL_KEYWORDS_INTERNAL INSTANCE = new LITERAL_KEYWORDS_INTERNAL ();
      LITERAL_KEYWORDS_INTERNAL() : base("LITERAL_KEYWORDS") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Literal_keywords();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT = OBJECT_INTERNAL.INSTANCE;
    private class OBJECT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly OBJECT_INTERNAL INSTANCE = new OBJECT_INTERNAL ();
      OBJECT_INTERNAL() : base("OBJECT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Object();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PREDICATE = PREDICATE_INTERNAL.INSTANCE;
    private class PREDICATE_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly PREDICATE_INTERNAL INSTANCE = new PREDICATE_INTERNAL ();
      PREDICATE_INTERNAL() : base("PREDICATE") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Predicate();
      }
    }
    public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType STATEMENT = STATEMENT_INTERNAL.INSTANCE;
    private class STATEMENT_INTERNAL : JetBrains.ReSharper.Psi.Secret.Tree.SecretCompositeNodeType
    {
      public static readonly STATEMENT_INTERNAL INSTANCE = new STATEMENT_INTERNAL ();
      STATEMENT_INTERNAL() : base("STATEMENT") {}
      public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create()
      {
         return new Statement();
      }
    }
  }
}
