using System;
using RestaurantManager.Models;

namespace RestaurantManager.UniversalWindows
{
    public sealed class MessageDialogService : IMessageService
    {
        public async void ShowDialog(string message)
        {
            await new Windows.UI.Popups.MessageDialog(message).ShowAsync();
        }
    }
}

/* INSTRUCTIONS

1. Animate the two Button controls on MainPage.xaml
- The controls should slide in from the outside edges and arrive in their normal locations at 
    the same time (duration)
- The animation should be invoked on the MainPage's Loaded event
2. Add a ProgressRing indicator to the ExpeditePage and OrderPage that is shown whenever the 
    ViewModel class or any class derived from ViewModel is actively loading data.
- Implement this using IsLoading properties on the ViewModel base class
- You should not need to change the OrderViewModel or ExpediteViewModel classes to accomplish this
- Data-bind the ProgressRing control's IsActive property to the IsLoading property of the current DataContext
- Ensure that the loading indicator only shows when the data is initially loaded, data is persisted 
    as you navigate between subsequent pages.
    */