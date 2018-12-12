// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using Microsoft.Xaml.Behaviors;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: CLSCompliant(true)]

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Behaviors.Input")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Behaviors.Layout")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Media.Effects")]

// TODO: JKuhne- the following seem to be quirks with the current build of VS
[module: SuppressMessage("Microsoft.MSInternal", "CA904:DeclareTypesInMicrosoftOrSystemNamespace",
    Scope = "namespace", Target = "XamlGeneratedNamespace")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "XamlGeneratedNamespace")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1824:MarkAssembliesWithNeutralResourcesLanguage")]
[assembly: System.Resources.NeutralResourcesLanguage("en", System.Resources.UltimateResourceFallbackLocation.MainAssembly)]

[assembly: XmlnsPrefix(@"http://schemas.microsoft.com/xaml/behaviors", "Interactions")]
[assembly: XmlnsDefinition(@"http://schemas.microsoft.com/xaml/behaviors", "Microsoft.Xaml.Behaviors")]
[assembly: XmlnsDefinition(@"http://schemas.microsoft.com/xaml/behaviors", "Microsoft.Xaml.Behaviors.Core")]
[assembly: XmlnsDefinition(@"http://schemas.microsoft.com/xaml/behaviors", "Microsoft.Xaml.Behaviors.Input")]
[assembly: XmlnsDefinition(@"http://schemas.microsoft.com/xaml/behaviors", "Microsoft.Xaml.Behaviors.Layout")]
[assembly: XmlnsDefinition(@"http://schemas.microsoft.com/xaml/behaviors", "Microsoft.Xaml.Behaviors.Media")]

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Xaml.Behaviors")]

[assembly: AssemblyKeyFile("Behaviors.snk")]
[assembly: InternalsVisibleTo("UnitTests, PublicKey='0024000004800000940000000602000000240000525341310004000001000100498b170c45b6574cbbef75e7c48850d2f243bb6efe64116ae4f88f67525f3465870e37aa01d974ad064d5347e3e126f87f5ecb365ddc3e4c21af19fcf0375b3212433057245a4a071ca16354ec8542b487d80eb202959f819ed657eab3874585364ffe0d29e0337245ce885c4d62f8d1906b0b40ab4311970c0a21f2cad7d7be")]
