using Laba8.Models;

namespace Laba8.ViewModels.HomeViewModels
{
    public enum ShowStyles
    {
        List,
        Table
    }
    public record class ShowOrdersViewModel(IEnumerable<Order> Orders, ShowStyles ShowStyle);
}