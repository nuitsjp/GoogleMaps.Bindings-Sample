using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;

namespace SamplesApp.ViewModels
{
    public class MoveToRegionPageViewModel
    {
        public MoveToRegionRequest MoveToRegionRequest { get; } = new MoveToRegionRequest();

        public ICommand MoveToTokyoCommand => new Command(() =>
        {
            MoveToRegionRequest.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(35.681298, 139.766247),
                    Distance.FromKilometers(2)));
        });
    }
}