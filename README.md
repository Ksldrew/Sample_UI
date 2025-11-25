# Van Gogh Detail Page – .NET MAUI (.NET 9)

## 1. Overview
This project implements a mobile UI page inspired by an art-gallery design for Vincent van Gogh.  
It is built using **.NET MAUI (.NET 9)** and focuses on modern mobile UI layout, responsive grids, and animated expandable text.

The page contains:
- Profile portrait with circular gold border  
- Artist name and biography  
- Expandable description section  
- Artwork statistics  
- A gallery of other Van Gogh paintings  
- Scrollable card-style layout  

The UI design closely follows the reference image provided in the assignment.

---

## 2. Technologies
- **.NET MAUI (.NET 9)**
- **XAML**
- **C#**
- **CommunityToolkit.Maui v12** (Expander)
- Android Emulator / Physical Android Device

---

## 3. Key UI Components

### **Profile Image**
A floating circular portrait positioned above the main card using:
- `Border`
- `StrokeThickness`
- `RoundRectangle` shape
- `AspectFill` image alignment

### **Expandable Description**
The biography section uses **MAUI CommunityToolkit Expander**, which provides:
- Collapsed: 2-line text with `TailTruncation` and **Read More**
- Expanded: full text with **Read More removed**
- Automatic show/hide using XAML `DataTrigger`
- Center-aligned text for consistency with the sample UI

### **Artwork Statistics Section**
Displayed using a 4-column equal-width grid:
```xml
<Grid ColumnDefinitions="*,*,*,*" />

