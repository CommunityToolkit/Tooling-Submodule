// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.Tooling.SampleGen;

namespace CommunityToolkit.App.Shared.Helpers;

public static class IconHelper
{
    public static IconElement? GetCategoryIcon(ToolkitSampleCategory category)
    {
        IconElement? iconElement = null;
        switch (category)
        {
            case ToolkitSampleCategory.Layouts: iconElement = new FontIcon() { Glyph = "\uF58C" }; break;
            case ToolkitSampleCategory.Controls: iconElement = new FontIcon() { Glyph = "\ue73a" }; break;
            case ToolkitSampleCategory.Animations: iconElement = new FontIcon() { Glyph = "\ue945" }; break;
            case ToolkitSampleCategory.Extensions: iconElement = new FontIcon() { Glyph = "\ue95f" }; break;
            case ToolkitSampleCategory.Helpers: iconElement = new FontIcon() { Glyph = "\ue946" }; break;
            case ToolkitSampleCategory.Xaml: iconElement = new FontIcon() { Glyph = "\ue8af" }; break;
        }
        return iconElement;
    }

    public static string GetSubcategoryIcon(ToolkitSampleSubcategory subcategory)
    {
        string imagePath = string.Empty;
        switch (subcategory)
        {
            case ToolkitSampleSubcategory.None: imagePath = "ms-appx:///Assets/ControlIcons/Control.png"; break;
            case ToolkitSampleSubcategory.Behaviors: imagePath = "ms-appx:///Assets/ControlIcons/Input.png"; break;
            case ToolkitSampleSubcategory.Controls: imagePath = "ms-appx:///Assets/ControlIcons/Control.png"; break;
            case ToolkitSampleSubcategory.Converters: imagePath = "ms-appx:///Assets/ControlIcons/Input.png"; break;
            case ToolkitSampleSubcategory.Input: imagePath = "ms-appx:///Assets/ControlIcons/Input.png"; break;
            case ToolkitSampleSubcategory.Layout: imagePath = "ms-appx:///Assets/ControlIcons/Layout.png"; break;
            case ToolkitSampleSubcategory.Markup: imagePath = "ms-appx:///Assets/ControlIcons/Input.png"; break;
            case ToolkitSampleSubcategory.Math: imagePath = "ms-appx:///Assets/ControlIcons/Control.png"; break;
            case ToolkitSampleSubcategory.Media: imagePath = "ms-appx:///Assets/ControlIcons/Control.png"; break;
            case ToolkitSampleSubcategory.StatusAndInfo: imagePath = "ms-appx:///Assets/ControlIcons/Status.png"; break;
            case ToolkitSampleSubcategory.Triggers: imagePath = "ms-appx:///Assets/ControlIcons/Input.png"; break;
        }
        return imagePath;
    }

    public static string GetControlIcon(string? icon)
    { 
        return "ms-appx:///SourceAssets/" + icon!;
       // return "ms-appx:///Assets/ControlIcons/default.png";
        return "ms-appx:///SourceAssets/Animations/samples/Assets/icon.png";
        if (string.IsNullOrEmpty(icon))
        {
            return "ms-appx:///Assets/ControlIcons/default.png";
        }
        else
        {
            return icon!;
        }
    }
}
