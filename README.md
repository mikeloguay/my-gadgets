# my-gadgets (work in progress)

This is a simple application to manage personal home gadgets (laptop, phone, washing-machine...). It stores its brand, date of purchase, warranty, serial numbers, manuals...

Inspired by:
- Clean Architecture book by Uncle Bob
- https://github.com/ardalis/CleanArchitecture
- https://github.com/devmentors/PackIT
- ...

## Objetives

The main objetive of this app is to play around with some technical concepts in a "real-world" app:
- Clean architecture
- DDD
- Automated testing
- CI/CD

Simplicity is one of the main design principles, but making sure the separation of concerns and maintainability is also optimized.

## Issues

To check what is supported now and will be in the future, please check https://github.com/mikeloguay/my-gadgets/issues

## Build

```sh
dotnet build src/MyGadgets.sln
```

## Test

```sh
dotnet test src/MyGadgets.sln
```

## Run

```sh
dotnet run --project src/MyGadgets.Api/MyGadgets.Api.csproj
```