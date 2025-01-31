<div align="center">

<img width="320px" alt="logo" src="./~Docs/Resources/glu-logo.svg">

<a name="readme-top"></a>

# GLU - Input Wrapper

A simple input wrapper that allows the new Input Manager to be used with prompt based interaction

<picture><img alt="Static Badge" src="https://img.shields.io/badge/Unity%20-%206.0%20-%20grey?style=for-the-badge&logo=unity"></picture>

<p>
  <a href="#key-features">Key Features</a> •
  <a href="#getting-started">Getting Started</a> •
  <a href="#documentation">Documentation</a>
</p>

</div>

## Key Features
This wrapper was created to allow first-year students to use unity's new input system without needing to look out for common pitfalls. 

The wrapper is designed to support Keyboard and Mouse as well as Gamepad interaction. Gamepads are limited to a single input device for the sake of simplicity.
All input is handled in a polling-based method, allowing the user to use these methods in Update loops like the legacy input system.

## Getting Started
To install this project, you use the [latest release](https://github.com/JVerkerk-GLU/Input-Wrapper/releases) package as provided within this repository.

## Documentation
The different types of Input devices are described in the following files, including the available properties and methods.

- [Gamepad](./~Docs/gamepad.md)
- [Keyboard](./~Docs/keyboard.md)
- [Mouse](./~Docs/mouse.md)