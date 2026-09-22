# Paint Drawing App

A Windows Forms desktop drawing application built with C# and .NET Framework 4.7.2.

> **Türkçe özet:** C# Windows Forms ile hazırlanmış; çizim, renk ve kalınlık seçimi, silgi, geri alma, temizleme, görsel açma ve kaydetme özellikleri bulunan masaüstü çizim uygulamasıdır.

## Features

- Draw on a white canvas with selectable brush sizes
- Choose a custom brush color
- Eraser, clear-canvas, and undo actions
- Open PNG, JPG, and BMP images as a canvas
- Save drawings explicitly as PNG, JPG, or BMP

## Run locally

1. Open `WindowsFormsApp1.sln` with Visual Studio on Windows.
2. Install the **.NET desktop development** workload if it is not already installed.
3. Build and run the `WindowsFormsApp1` project.

## Technical notes

- Target framework: .NET Framework 4.7.2
- UI technology: Windows Forms
- The portfolio version excludes Visual Studio caches and compiled binaries.

## Verification note

The source code has been reviewed and the prior compiled application is present in the original project folder. A fresh build in this environment is blocked by the legacy WinForms resource format and the absence of its required `System.Resources.Extensions` build dependency; build it with Visual Studio's .NET desktop workload before making the repository public.
