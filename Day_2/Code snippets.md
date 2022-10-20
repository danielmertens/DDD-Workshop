# Code snippets

## Persistence

```
public class AggregateEntity
{
    public string AggregateId { get; set; } = string.Empty;

    public int CurrentVersion { get; set; }

    public byte[] TimeStamp { get; set; } = Array.Empty<byte>();
}

public class AggregateEntityTypeConfiguration : IEntityTypeConfiguration<AggregateEntity>
{
    public void Configure(EntityTypeBuilder<AggregateEntity> builder)
    {
        builder.HasKey(x => x.AggregateId);

        builder.Property(x => x.AggregateId)
            .HasMaxLength(200);

        builder.Property(x => x.TimeStamp).IsRowVersion();
    }
}

public class EventEntity
{
    public Guid Id { get; set; }

    public string AggregateId { get; set; } = string.Empty;

    public int Version { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.Now;

    public string MessageType { get; set; } = string.Empty;

    public string EventData { get; set; } = string.Empty;
}

public void Configure(EntityTypeBuilder<EventEntity> builder)
    {
        builder.HasKey(x => x.Id);
    }
```

## Messaging

Run the docker compose file.

Required nuget packages:

- Rebus.RabbitMq
- Rebus.ServiceProvider

```
builder.Services.AddRebus(configure => configure
    .Transport(t => t.UseRabbitMq("amqp://localhost", "QueueName"))
    .Serialization(s => s.UseSystemJson()),
    onCreated: async bus =>
        {
            await bus.Subscribe<DomainMessage>();
        }
    );

builder.Services.AddScoped<IHandleMessages<DomainMessage>, Consumer>();

public class Consumer : IHandleMessages<DomainMessage>
    {
        public Task Handle(DomainMessage message)
        {
            // Do something
            return Task.CompletedTask;
        }
    }
```