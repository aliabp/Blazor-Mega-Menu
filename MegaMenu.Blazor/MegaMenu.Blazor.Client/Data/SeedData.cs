using MegaMenu.Blazor.Client.Models;

namespace MegaMenu.Blazor.Client.Data;

public static class SeedData
{
    public static List<MenuItem> SeedMenuItems()
    {
        List<MenuItem> items = new List<MenuItem>();
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = true,
            Link = "https://google.com",
            Text = "Menu Title 1"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 1"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 2"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 3"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 4"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = true,
            Link = "https://google.com",
            Text = "Menu Title 2"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 5"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 6"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 7"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 0,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 8"
        });

        //

        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = true,
            Link = "https://google.com",
            Text = "Menu Title 3"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 9"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 10"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 11"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 12"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = true,
            Link = "https://google.com",
            Text = "Menu Title 4"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 13"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 14"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 1,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 15"
        });


        //

        items.Add(new MenuItem
        {
            ColumnIndex = 2,
            IsHeader = true,
            Link = "https://google.com",
            Text = "Menu Title 5"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 2,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 16"
        });
        items.Add(new MenuItem
        {
            ColumnIndex = 2,
            IsHeader = false,
            Link = "https://google.com",
            Text = "Menu Link 17"
        });
        return items;
    }
}
