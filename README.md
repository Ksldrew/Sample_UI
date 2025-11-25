# README – Van Gogh Detail Page (MAUI .NET 9)

## 1. Overview
This project is a mobile application UI built with **.NET MAUI (.NET 9)**.  
It displays detailed information about Vincent van Gogh, including:

- Profile image  
- Artist biography  
- Expandable description  
- Statistics section  
- Gallery of artwork items  

The design follows a modern card-style layout and is optimized for mobile display.

---

## 2. Technologies
- .NET MAUI (.NET 9)
- C#
- XAML
- CommunityToolkit.Maui (for Expander behavior)
- Android Emulator / Windows Machine

---

## 3. Key UI Components

### Profile Section
A round profile image with a golden-colored border floating above the main card.  
Implemented using:

- `Border`
- `Stroke`
- `RoundRectangle`
- `AspectFill` image

### Expandable Description
The biography uses **MAUI Toolkit Expander**:

- Collapsed: shows a **2-line truncated description** with `TailTruncation`
- Expanded: displays **full text** without “Read More”
- “Read More” disappears when expanded and reappears when collapsed
- All implemented using XAML `DataTrigger`s
- Text content is center-aligned

### Statistics Section
A four-column grid displaying:

- Record  
- Average  
- Popularity (%)  
- Number of items  

Implemented using:

```xml
<Grid ColumnDefinitions="*,*,*,*" />

