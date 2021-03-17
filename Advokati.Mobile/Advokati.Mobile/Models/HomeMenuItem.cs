using System;
using System.Collections.Generic;
using System.Text;

namespace Advokati.Mobile.Models
{
    public enum MenuItemType
    {

        Browse,
        About,
        UserProfil,
        Predmeti,
        Rocista,
        Sastanci,
        RadniSati,
        OdjaviSe,
        PretragaPredmeta,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
