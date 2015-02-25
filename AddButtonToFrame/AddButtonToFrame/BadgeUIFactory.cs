using System;
using Microsoft.Internal.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Shell.Interop;

namespace Company.AddButtonToFrame
{
    public class BadgeUIFactory : WpfUIFactory
    {
        private BadgeUIFactory(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public static void Register(IServiceProvider serviceProvider)
        {
            if (serviceProvider != null)
            {
                IVsUIFactory pUiFactory = new BadgeUIFactory(serviceProvider);
                var asRegisterUiFactories =
                    (IVsRegisterUIFactories) serviceProvider.GetService(typeof (SVsUIFactory));

                Guid uiFactoryGuid = GuidList.guidUIFactory;
                asRegisterUiFactories.RegisterUIFactory(ref uiFactoryGuid, pUiFactory);
            }
        }

        protected override WpfUIFactoryElement[] GetFactoryElements()
        {
            return new[]
            {
                new WpfUIFactoryElement(GuidList.guidUIFactory, 100u, typeof (Badge))
            };
        }
    }
}
