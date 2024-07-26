# my-gadgets (work in progress)

This is a simple application to manage personal home gadgets (laptop, phone, washing-machine...). It stores its brand, date of purchase, warranty, serial numbers, manuals...

## Objetives

The main objetive of this app is to play around with some technical concepts in a "real-world" app:
- Clean architecture
- DDD
- Automated testing
- CI/CD

Simplicity is one of the main design principles, but making sure the separation of concerns and maintainability is also optimized.

## Functional requirements

### Supported

- CRUD operations on a gadget (simple entity with no relations)

### Planned

- Basic details: name, notes, photo
- Manage list of brands
- Manage type of gadget
- Send alert when the warranty of a gadget is close to expire

## Non-functional requirements

### Supported

- Automatic migrations

### Planned

- Global exeption handling via `IExceptionHandler` (with HTTP status codes mapping)
- Validation of both DTOs and entities with fluent validation
- Serilog semantic logging
- GitHub actions to build + test
- Deploy to Azure via Docker repository, using settings per environment
- Unit of Work with multiple repositories