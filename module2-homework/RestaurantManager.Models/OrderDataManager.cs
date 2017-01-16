using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {       
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;
            //OnPropertyChanged("MenuItems");

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
            OnPropertyChanged("CurrentlySelectedMenuItems");
        }

        public List<MenuItem> MenuItems
        {
            get { return base.Repository.StandardMenuItems; }
            set {this.OnPropertyChanged();}
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get;
            set;
        }
    }
}
