# BetterQuest — VR Game Platform for Meta Quest

> Full-stack platform for sideloading VR games on Meta Quest headsets: TCP server, WPF desktop client, admin panel, and landing page.

## Architecture

```
┌─────────────────┐     ┌──────────────┐     ┌─────────────────┐
│  Admin Client   │────▶│  TCP Server   │◀────│  User Client    │
│  (WPF/.NET)     │     │  (.NET 5)     │     │  (WPF/.NET)     │
└─────────────────┘     └──────┬───────┘     └────────┬────────┘
                               │                       │
                               ▼                       ▼
                        Game Library            ADB → Quest
```

## Tech Stack
- **Server:** C# / .NET 5, TCP socket, cross-platform (Win/Linux/ARM)
- **Client:** C# / WPF / .NET 5, ADB integration, scrcpy
- **Admin Client:** C# / WPF / .NET 5
- **Landing Page:** HTML/CSS

## Project Structure
```
├── server/          — TCP server for game library management
├── client/          — Desktop app for browsing & installing VR games
├── admin-client/    — Admin tool for managing game catalog
└── landing-page/    — Product website
```

## Features
- Browse and search VR game library
- One-click APK installation to Quest via ADB
- Screen casting via scrcpy integration
- Admin panel for catalog management
- Custom TCP protocol for client-server communication

---

# BetterQuest — VR-платформа для Meta Quest

> Полноценная платформа для сайдлоадинга VR-игр на шлемы Meta Quest: TCP-сервер, WPF-клиент, админ-панель и лендинг.

## Архитектура

```
┌─────────────────┐     ┌──────────────┐     ┌─────────────────┐
│  Админ-клиент   │────▶│  TCP-сервер   │◀────│  Клиент         │
│  (WPF/.NET)     │     │  (.NET 5)     │     │  (WPF/.NET)     │
└─────────────────┘     └──────┬───────┘     └────────┬────────┘
                               │                       │
                               ▼                       ▼
                      Библиотека игр          ADB → Quest
```

## Стек технологий
- **Сервер:** C# / .NET 5, TCP-сокеты, кроссплатформенный (Win/Linux/ARM)
- **Клиент:** C# / WPF / .NET 5, интеграция с ADB, scrcpy
- **Админ-клиент:** C# / WPF / .NET 5
- **Лендинг:** HTML/CSS

## Структура проекта
```
├── server/          — TCP-сервер для управления библиотекой игр
├── client/          — Десктопное приложение для просмотра и установки VR-игр
├── admin-client/    — Админ-панель для управления каталогом
└── landing-page/    — Сайт продукта
```

## Возможности
- Просмотр и поиск библиотеки VR-игр
- Установка APK на Quest в один клик через ADB
- Трансляция экрана через scrcpy
- Админ-панель для управления каталогом игр
- Собственный TCP-протокол для клиент-серверного взаимодействия
