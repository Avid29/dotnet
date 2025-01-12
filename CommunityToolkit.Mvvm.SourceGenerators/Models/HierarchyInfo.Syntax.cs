// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file is ported and adapted from ComputeSharp (Sergio0694/ComputeSharp),
// more info in ThirdPartyNotices.txt in the root of the project.

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CommunityToolkit.Mvvm.SourceGenerators.Models;

/// <inheritdoc/>
partial record HierarchyInfo
{
    /// <summary>
    /// Creates a <see cref="CompilationUnitSyntax"/> instance wrapping the given members.
    /// </summary>
    /// <param name="memberDeclarations">The input <see cref="MemberDeclarationSyntax"/> instances to use.</param>
    /// <param name="baseList">The optional <see cref="BaseListSyntax"/> instance to add to generated types.</param>
    /// <returns>A <see cref="CompilationUnitSyntax"/> object wrapping <paramref name="memberDeclarations"/>.</returns>
    public CompilationUnitSyntax GetCompilationUnit(
        ImmutableArray<MemberDeclarationSyntax> memberDeclarations,
        BaseListSyntax? baseList = null)
    {
        // Create the partial type declaration with the given member declarations.
        // This code produces a class declaration as follows:
        //
        // partial class <TYPE_NAME>
        // {
        //     <MEMBERS>
        // }
        ClassDeclarationSyntax classDeclarationSyntax =
            ClassDeclaration(Names[0])
            .AddModifiers(Token(SyntaxKind.PartialKeyword))
            .AddMembers(memberDeclarations.ToArray());

        // Add the base list, if present
        if (baseList is not null)
        {
            classDeclarationSyntax = classDeclarationSyntax.WithBaseList(baseList);
        }

        TypeDeclarationSyntax typeDeclarationSyntax = classDeclarationSyntax;

        // Add all parent types in ascending order, if any
        foreach (string parentType in Names.AsSpan().Slice(1))
        {
            typeDeclarationSyntax =
                ClassDeclaration(parentType)
                .AddModifiers(Token(SyntaxKind.PartialKeyword))
                .AddMembers(typeDeclarationSyntax);
        }

        // Create the compilation unit with disabled warnings, target namespace and generated type.
        // This will produce code as follows:
        //
        // <auto-generated/>
        // #pragma warning disable
        // #nullable enable
        // namespace <NAMESPACE>
        // {
        //     <TYPE_HIERARCHY>
        // }
        return
            CompilationUnit().AddMembers(
            NamespaceDeclaration(IdentifierName(Namespace))
            .WithLeadingTrivia(TriviaList(
                Comment("// <auto-generated/>"),
                Trivia(PragmaWarningDirectiveTrivia(Token(SyntaxKind.DisableKeyword), true)),
                Trivia(NullableDirectiveTrivia(Token(SyntaxKind.EnableKeyword), true))))
            .AddMembers(typeDeclarationSyntax))
            .NormalizeWhitespace();
    }
}
