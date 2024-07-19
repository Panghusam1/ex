## ex 项目 README

### 项目简介
ex 是一个使用 WinUI 3 创建的 Windows 应用程序，它可以从指定的 CSV 文件中读取并复现用户的键盘和鼠标操作。通过解析 CSV 文件中的事件记录，应用程序能够模拟这些操作并重新执行它们。

### 项目结构

```
ex
├── Assets
├── Dependencies
├── exSetup
├── App.xaml
├── App.xaml.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
└── Package.appxmanifest
```

- **App.xaml**: 定义应用程序的根元素和资源。
- **App.xaml.cs**: 包含应用程序启动逻辑。
- **MainWindow.xaml**: 定义主窗口的 UI 布局。
- **MainWindow.xaml.cs**: 包含主窗口的逻辑代码，处理 CSV 文件的读取和事件的执行。
- **Package.appxmanifest**: 定义应用程序的包清单和元数据。

### 环境配置

1. **安装 .NET 6.0 SDK**
   请确保您已安装 .NET 6.0 SDK。您可以从 [官方链接](https://dotnet.microsoft.com/download/dotnet/6.0) 下载并安装。

2. **安装 Visual Studio 2022**
   请确保您已安装 Visual Studio 2022，并在安装时选择了包含 WinUI 3 开发的工作负载。

### 运行项目

1. **克隆项目**
   ```sh
   git clone <repository-url>
   cd ex
   ```

2. **打开项目**
   在 Visual Studio 2022 中打开 `ex.sln` 解决方案文件。

3. **配置 CSV 文件路径**
   在 `MainWindow.xaml.cs` 文件中，确保 CSV 文件路径正确：
   ```csharp
   string filePath = @"D:\jianting\key_mouse_events.csv";
   ```

4. **运行项目**
   按下 `F5` 键或点击 Visual Studio 中的 “启动” 按钮来运行应用程序。

### 功能实现

#### CSV 文件读取

通过 `LoadCommandsFromCsv` 方法读取 CSV 文件，并将每一行解析为 `CommandRecord` 对象。CSV 文件应包括以下字段：
- **事件类型（EventType）**：例如，KeyDown, KeyUp, MouseDown, MouseUp
- **时间戳（Timestamp）**：事件发生的时间
- **键码（KeyCode）**：键盘事件的虚拟键码
- **按键字符（KeyChar）**：键盘事件的字符
- **鼠标按钮（Button）**：鼠标事件的按钮类型（Left, Right, Middle）
- **鼠标位置（X, Y）**：鼠标事件的坐标

#### 事件执行

在 `ExecuteCommands` 方法中，通过逐步执行每个 `CommandRecord` 对象中的事件来模拟用户操作。使用 `Task.Delay` 方法来确保事件按时间顺序执行。

#### 调试和日志

通过在关键位置添加 `Debug.WriteLine` 输出日志信息，便于在开发和调试过程中跟踪程序执行流程和验证每个步骤的正确性。

### 日志示例

在 `MainWindow.xaml.cs` 文件中，我们添加了调试日志来输出每个读取的 CSV 行和执行的命令：
```csharp
Debug.WriteLine($"Reading line: {line}");
Debug.WriteLine($"Added command: {command.EventType}, {command.KeyCode}, {command.KeyChar}, {command.Button}, {command.X}, {command.Y}");
```

### 未来改进

- 支持更多类型的事件，例如滚轮事件。
- 提高事件执行的精确度，确保时序的准确性。
- 优化代码结构，提高可读性和可维护性。

### 贡献指南

如果您想为本项目做出贡献，请遵循以下步骤：

1. Fork 本仓库。
2. 创建一个新的分支：`git checkout -b feature/YourFeatureName`
3. 提交您的更改：`git commit -m 'Add some feature'`
4. 推送到分支：`git push origin feature/YourFeatureName`
5. 提交 Pull Request。

### 许可证

该项目遵循 MIT 许可证。详细信息请参见 LICENSE 文件。

### 联系方式

---

感谢您使用 ex 项目！希望该项目能对您的工作有所帮助。
