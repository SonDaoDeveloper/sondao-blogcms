using MediatR;

namespace SonDaoBlog.Core.Events.RegisterSuccessed
{
    public class RegisterSuccessedEventHandler : INotificationHandler<RegisterSuccessedEvent>
    {
        public Task Handle(RegisterSuccessedEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
