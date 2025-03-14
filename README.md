# 🔒VeyonCTL - Take Control of Your Privacy

`VeyonCTL` is a simple .NET CLI tool designed to manage the `VeyonService` on Windows. With this tool, you can easily stop or disable the `VeyonService` to ensure you're not being spied on without your consent. ✋👀

---

## ⚠️ Important Notice

- **You need administrative privileges** to run this tool.  
  If you're not an admin on your computer, you won't be able to use `VeyonCTL`. Make sure to open the command prompt as an administrator.
- **Intended for ethical use**: If you’re using this tool, ensure you’re within your rights to manage the Veyon service on your device. Misuse of this tool is discouraged.

## 🛡️ Ethical Use Policy
`VeyonCTL` is intended for ethical use only. While it empowers users to control their privacy, misuse of this tool in environments where monitoring is legally or ethically justified is strongly discouraged. Always act responsibly. 🙌

## 🔧 Permissions Required
To use this tool: 
1. **Run the command prompt as an administrator**.  
   Without admin access, you won't be able to manage the Veyon service.
---

## 🌟 Features
- **Start** the `VeyonService` when you need it.
- **Stop** the service to prevent unwanted surveillance.
- **Enable** the service to allow Veyon to start automatically.
- **Disable** the service to prevent it from starting automatically.

---

## ❓ Why Use VeyonCTL?

[Veyon](https://github.com/veyon/veyon) is a powerful tool used in schools to monitor and manage classroom computers. While it can be helpful for educators, students may feel uncomfortable being monitored when it's not necessary. With `VeyonCTL`, you can manage the `VeyonService` on your terms:

- **Ensure privacy** during personal use of your computer.
- **Enable the service** when required in the classroom.
- **Disable it** when you want to guarantee no background monitoring.

---

## 📦 Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/veyonctl.git
   cd veyonctl
   ```

2. Build the project:
   ```bash
   dotnet publish -c Release -r win-x64 --self-contained
   ```

3. Add the build folder to your system PATH for easy access.

---

## 🏃 Usage
```bash
veyonctl <command>
```

### Commands:
- `start`   🚀 - Starts the `VeyonService` when it's needed.
- `stop`    🛑 - Stops the `VeyonService` to prevent monitoring.
- `enable`  🔓 - Enables the service (sets it to start automatically).
- `disable` 🔒 - Disables the service to stop it from starting at all.

### Examples:
Stop the service to ensure privacy:
```bash
veyonctl stop
```

Disable the service completely:
```bash
veyonctl disable
```

Re-enable the service when needed:
```bash
veyonctl enable
```

---

## 🔎 Why "VeyonCTL"?
It's short for **Veyon Controller**, putting you in control of when and how the `VeyonService` operates. 💻

🛠️🎩👨‍🦱
