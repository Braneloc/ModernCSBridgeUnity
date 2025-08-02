# Modern CS Bridge for Unity

A lightweight toolkit that bridges older Unity runtimes to modern C# language features.

## Installation

`Unity Editor → Window ▸ Package Manager →
 ➕ Add package from Git URL
https://github.com/Braneloc/ModernCSBridgeUnity.git
`

_Unity downloads the package and recompiles scripts automatically._

## Features

* Full usage of C# 10 for Unity
* Support for records and init-only setters.

## Problems this project solves

* Unity compiles C# projects in “9.0” mode by default. New syntax such as record, init setters, and enhanced switch expressions may fail to compile or show IDE errors.
* System.Runtime.CompilerServices.IsExternalInit is missing in Unity’s .NET Standard 2.1 runtime, causing CS0518 when you compile records or use init.

## Usage

* Every time Unity regenerates its C# project files, the bridge bumps the _LangVersion_ element to latest (currently C# 10 in Unity 6.2+). No manual action required.

* Manual stub generation  
Right‑click any folder in the Project window and choose either menu path:  
Create ▸ Support Code ▸ IsExternalInit  
Create ▸ Scripting ▸ IsExternalInit    
_If IsExternalInit.cs already exists in that folder, the command overwrites it in place.
The stub is wrapped in #if !NET8_0_OR_GREATER, so it compiles away automatically once Unity moves to a .NET 8‑based runtime that includes the real type._

![](https://avatars.githubusercontent.com/u/9757397?s=96&v=4)