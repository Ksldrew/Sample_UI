README – Van Gogh Detail Page (MAUI .NET 9)
1. Overview

This project is a mobile application UI built with .NET MAUI (.NET 9).
It displays detailed information about Vincent van Gogh, including:

Profile image

Artist biography

Expandable description

Statistics section

Gallery of artwork items

The design follows a modern card-style layout and is optimized for mobile display.

2. Technologies

.NET MAUI (.NET 9)

C#

XAML

CommunityToolkit.Maui (for Expander behavior)

Android Emulator / Windows Machine

3. Key UI Components
Profile Section

A rounded profile picture with a bordered circular frame placed above the main card.
Implemented using Border, Stroke, and RoundRectangle.

Expandable Description

The artist’s biography uses a Toolkit Expander to:

Show a truncated 2-line description in collapsed mode

Display full text when expanded

Hide the "Read More" label dynamically

Center-align the content for better aesthetics

All logic is handled in XAML using DataTriggers.

Statistics Section

A four-column grid that evenly distributes:

Record price

Average value

Popularity percentage

Number of items

This is implemented using Grid ColumnDefinitions="*,*,*,*" for equal width.

Artwork Gallery

The bottom section uses a CollectionView with a 2-column layout to show multiple artwork cards.
Each item includes:

Artwork image

Title

Price

4. File Structure
/Lab_Test
│── MainPage.xaml
│── MainPage.xaml.cs
│── App.xaml
│── App.xaml.cs
│── MauiProgram.cs
│── Resources/Images
      ├── vincent.jpg
      ├── artwork images
      ├── icon_back.png
      ├── icon_bookmark.png

5. How to Build & Run

Open the project in Visual Studio 2022 (Preview) with .NET 9 support.

Ensure the CommunityToolkit.Maui NuGet package is installed.

Place all images in:
Resources/Images/

Select an Android emulator or device.

Run the project.

6. UI Behavior Summary

The profile picture floats above the main card.

The description collapses and expands smoothly.

The layout scales automatically on different screen sizes.

The artwork grid is scrollable and responsive.

The top bar includes decorative back and bookmark icons.

7. Notes

The project uses no hardcoded element widths for grid layouts.

All UI features are implemented in XAML without requiring additional code-behind logic.

The layout follows the reference design closely, including alignment, spacing, and color scheme.
