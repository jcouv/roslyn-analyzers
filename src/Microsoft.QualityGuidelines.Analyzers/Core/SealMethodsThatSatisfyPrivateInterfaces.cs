// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Collections.Immutable;
using Analyzer.Utilities;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Microsoft.QualityGuidelines.Analyzers
{
    /// <summary>
    /// CA2119: Seal methods that satisfy private interfaces
    /// </summary>
    public abstract class SealMethodsThatSatisfyPrivateInterfacesAnalyzer : DiagnosticAnalyzer
    {
        internal const string RuleId = "CA2119";

        private static readonly LocalizableString s_localizableTitle = new LocalizableResourceString(nameof(MicrosoftQualityGuidelinesAnalyzersResources.SealMethodsThatSatisfyPrivateInterfacesTitle), MicrosoftQualityGuidelinesAnalyzersResources.ResourceManager, typeof(MicrosoftQualityGuidelinesAnalyzersResources));

        private static readonly LocalizableString s_localizableMessage = new LocalizableResourceString(nameof(MicrosoftQualityGuidelinesAnalyzersResources.SealMethodsThatSatisfyPrivateInterfacesMessage), MicrosoftQualityGuidelinesAnalyzersResources.ResourceManager, typeof(MicrosoftQualityGuidelinesAnalyzersResources));
        private static readonly LocalizableString s_localizableDescription = new LocalizableResourceString(nameof(MicrosoftQualityGuidelinesAnalyzersResources.SealMethodsThatSatisfyPrivateInterfacesDescription), MicrosoftQualityGuidelinesAnalyzersResources.ResourceManager, typeof(MicrosoftQualityGuidelinesAnalyzersResources));

        internal static DiagnosticDescriptor Rule = new DiagnosticDescriptor(RuleId,
                                                                             s_localizableTitle,
                                                                             s_localizableMessage,
                                                                             DiagnosticCategory.Security,
                                                                             DiagnosticSeverity.Warning,
                                                                             isEnabledByDefault: false,
                                                                             description: s_localizableDescription,
                                                                             helpLinkUri: null,     // TODO: add MSDN url
                                                                             customTags: WellKnownDiagnosticTags.Telemetry);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

        public override void Initialize(AnalysisContext analysisContext)
        {
        }
    }
}