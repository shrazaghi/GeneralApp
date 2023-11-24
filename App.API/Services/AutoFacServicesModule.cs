using App.Repository.Contexts;
using Autofac;

namespace GeneralApp.Services;

public class AutoFacServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<MessageNotifyService>().As<IMessageNotifyService>();
        builder.RegisterType<AppReadDbContext>().AsSelf();
        //builder.RegisterType<>
    }
}
