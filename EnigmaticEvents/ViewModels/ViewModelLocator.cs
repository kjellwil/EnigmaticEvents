using EnigmaticEvents.Interfaces;
using EnigmaticEvents.Services;
using Microsoft.Practices.Unity;

namespace EnigmaticEvents.ViewModels
{
    public class ViewModelLocator
    {
        public IUnityContainer _container = new UnityContainer();

        public ViewModelLocator()
        {
            _container.RegisterType<IProvideEventData, EventProvider>();
            _container.RegisterType<EventViewModel>();
        }

        public EventViewModel EventViewModel
        {
            get
            {
                return _container.Resolve<EventViewModel>();
            }
        }
    }
}
