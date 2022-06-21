# DomaiNesia DDNS Updater

This application is meant to be run as a Windows service. This service should periodically update DDNS pointing to the machine address.

---

## Usage

1. Create `appsettings.Production.json`
2. Use URL provided by DomaiNesia and put it in `DdnsUrl`
3. Publish using `dotnet publish --output [SERVICE PATH]`
4. Run `sc create [SERVICE NAME] binpath=[SERVICE PATH]` in Powershell / Windows Terminal