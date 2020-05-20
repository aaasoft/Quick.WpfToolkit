/*************************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at http://xceed.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System.Windows;
using System.Windows.Markup;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]

[assembly: XmlnsPrefix( "http://schemas.xceed.com/wpf/xaml/avalondock", "xcad" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/avalondock", "Xceed.Wpf.AvalonDock" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/avalondock", "Xceed.Wpf.AvalonDock.Controls" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/avalondock", "Xceed.Wpf.AvalonDock.Converters" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/avalondock", "Xceed.Wpf.AvalonDock.Layout" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/avalondock", "Xceed.Wpf.AvalonDock.Themes" )]