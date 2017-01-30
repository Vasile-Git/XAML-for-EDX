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