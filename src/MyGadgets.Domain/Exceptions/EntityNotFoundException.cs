namespace MyGadgets.Domain.Exceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException()
    {
    }

    public EntityNotFoundException(string message)
        : base(message)
    {
    }

    public EntityNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }

    public EntityNotFoundException(string type, int id)
        : base($"Entity of {nameof(Type)}={type} and {nameof(Id)}={id} not found")
    {
        Type = type;
        Id = id;
    }

    public string? Type { get; set; }
    public int Id { get; set; }
}

