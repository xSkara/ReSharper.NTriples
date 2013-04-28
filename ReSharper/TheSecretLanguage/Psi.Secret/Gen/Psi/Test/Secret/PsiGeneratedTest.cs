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
using System.IO;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.Secret.Impl.Tree
{
  public partial class PsiGeneratedGetterTestUtil : PsiGetterTestUtil
  {
      internal static void TestSecretFile (int level, JetBrains.ReSharper.Psi.Secret.Tree.ISecretFile param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Secret.Tree.ISentence> children = ((JetBrains.ReSharper.Psi.Secret.Tree.ISecretFile)param).Sentences;
        foreach (JetBrains.ReSharper.Psi.Secret.Tree.ISentence child in children)
        TestSentence (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.ISentence)child, "Sentences");
      }
    }
      internal static void TestAnonymousIdentifier (int level, JetBrains.ReSharper.Psi.Secret.Tree.IAnonymousIdentifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestAxisDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IAxisDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestCutStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.ICutStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestDataLiteral (int level, JetBrains.ReSharper.Psi.Secret.Tree.IDataLiteral param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestExpression (int level, JetBrains.ReSharper.Psi.Secret.Tree.IExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestExtensionDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IExtensionDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestFact (int level, JetBrains.ReSharper.Psi.Secret.Tree.IFact param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestFacts (int level, JetBrains.ReSharper.Psi.Secret.Tree.IFacts param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestForAllDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IForAllDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestForSomeDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IForSomeDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestFormula (int level, JetBrains.ReSharper.Psi.Secret.Tree.IFormula param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestFromStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IFromStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestFunctorStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IFunctorStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestHasExpression (int level, JetBrains.ReSharper.Psi.Secret.Tree.IHasExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestIdentifier (int level, JetBrains.ReSharper.Psi.Secret.Tree.IIdentifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestIfStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IIfStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestIsOfExpression (int level, JetBrains.ReSharper.Psi.Secret.Tree.IIsOfExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestKeywordStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IKeywordStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestList (int level, JetBrains.ReSharper.Psi.Secret.Tree.IList param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestLiteral (int level, JetBrains.ReSharper.Psi.Secret.Tree.ILiteral param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.Secret.Tree.IDataLiteral) TestDataLiteral (level, (JetBrains.ReSharper.Psi.Secret.Tree.IDataLiteral)param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestLiteral_keywords (int level, JetBrains.ReSharper.Psi.Secret.Tree.ILiteral_keywords param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      else throw new System.InvalidOperationException();
    }
      internal static void TestLocalName (int level, JetBrains.ReSharper.Psi.Secret.Tree.ILocalName param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestMeta (int level, JetBrains.ReSharper.Psi.Secret.Tree.IMeta param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestNotStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.INotStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestObjects (int level, JetBrains.ReSharper.Psi.Secret.Tree.IObjects param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestOrStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IOrStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestPredicate (int level, JetBrains.ReSharper.Psi.Secret.Tree.IPredicate param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestPrefix (int level, JetBrains.ReSharper.Psi.Secret.Tree.IPrefix param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestPrefixDeclaration (int level, JetBrains.ReSharper.Psi.Secret.Tree.IPrefixDeclaration param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.Secret.Tree.IPrefixDeclaration)param).Prefix;
        TestTokenNode (level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Prefix");
      }
      {
        JetBrains.ReSharper.Psi.Secret.Tree.IPrefixName child = ((JetBrains.ReSharper.Psi.Secret.Tree.IPrefixDeclaration)param).PrefixName;
        TestPrefixName (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.IPrefixName)child, "PrefixName");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.Secret.Tree.IPrefixDeclaration)param).UriString;
        TestTokenNode (level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "UriString");
      }
    }
      internal static void TestPrefixName (int level, JetBrains.ReSharper.Psi.Secret.Tree.IPrefixName param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestSentence (int level, JetBrains.ReSharper.Psi.Secret.Tree.ISentence param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Secret.Tree.IDirective child = ((JetBrains.ReSharper.Psi.Secret.Tree.ISentence)param).Directive;
        TestDirective (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.IDirective)child, "Directive");
      }
      {
        JetBrains.ReSharper.Psi.Secret.Tree.IStatement child = ((JetBrains.ReSharper.Psi.Secret.Tree.ISentence)param).Statement;
        TestStatement (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.IStatement)child, "Statement");
      }
    }
      internal static void TestSentences (int level, JetBrains.ReSharper.Psi.Secret.Tree.ISentences param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestSmartVar (int level, JetBrains.ReSharper.Psi.Secret.Tree.ISmartVar param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestStatement (int level, JetBrains.ReSharper.Psi.Secret.Tree.IStatement param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Secret.Tree.ISubject child = ((JetBrains.ReSharper.Psi.Secret.Tree.IStatement)param).Subject;
        TestSubject (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.ISubject)child, "Subject");
      }
    }
      internal static void TestSubject (int level, JetBrains.ReSharper.Psi.Secret.Tree.ISubject param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestUriIdentifier (int level, JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Secret.Tree.ILocalName child = ((JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifier)param).LocalName;
        TestLocalName (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.ILocalName)child, "LocalName");
      }
      {
        JetBrains.ReSharper.Psi.Secret.Tree.IPrefix child = ((JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifier)param).Prefix;
        TestPrefix (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.IPrefix)child, "Prefix");
      }
      {
        JetBrains.ReSharper.Psi.Secret.Tree.IUriString child = ((JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifier)param).UriStringElement;
        TestUriString (level + 1, (JetBrains.ReSharper.Psi.Secret.Tree.IUriString)child, "UriStringElement");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifier)param).UriString;
        TestTokenNode (level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "UriString");
      }
    }
      internal static void TestUriIdentifiers (int level, JetBrains.ReSharper.Psi.Secret.Tree.IUriIdentifiers param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestUriString (int level, JetBrains.ReSharper.Psi.Secret.Tree.IUriString param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.Secret.Tree.IUriString)param).Value;
        TestTokenNode (level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Value");
      }
    }
      internal static void TestUseExternalDirective (int level, JetBrains.ReSharper.Psi.Secret.Tree.IUseExternalDirective param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestVariableIdentifier (int level, JetBrains.ReSharper.Psi.Secret.Tree.IVariableIdentifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestVariables (int level, JetBrains.ReSharper.Psi.Secret.Tree.IVariables param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
    }
}
