# Unity 3D Tool Development

## 📌 Overview  
This Unity project provides a **basic 3D tool** that allows users to **spawn, select, and manipulate objects** in a scene while integrating camera navigation and an interactive UI panel.

## 📂 Project Structure  
📁 `Assets/` – Contains all project files  
- 📂 `Scripts/` – C# scripts used in the project  
  - `ObjectSpawner.cs` – Handles object spawning  
  - `ObjectSelection.cs` – Handles object selection & highlighting  
  - `PropertyPanelController.cs` – UI panel for modifying object properties  
  - `CameraController.cs` – Camera movement, rotation, and zoom  
- 📂 `Prefabs/` – Pre-configured 3D object prefabs (Cube, Sphere, Capsule, Cylinder)  
- 📂 `UI/` – Canvas and UI elements  

## 🎮 Controls  

### Camera Controls  
- 🎥 **Zoom In/Out** → Scroll **Up/Down**  
- 🎥 **Rotate Camera** → Hold **Right Mouse Button** + Move Mouse  
- 🎥 **Pan Camera** → Hold **Middle Mouse Button** + Move Mouse  
- 🎥 **Focus on Selected Object** → Press **"L" Key**  

### Object Spawning  
- 🛠 Click UI buttons (**Cube, Sphere, Capsule, Cylinder**) to **spawn objects** in the scene.  

### Object Selection & Manipulation  
- 🖱 **Left Click** → Select an object (highlights in yellow)  
- 🎨 **Property Panel** → Modify X, Y, Z position in UI  

