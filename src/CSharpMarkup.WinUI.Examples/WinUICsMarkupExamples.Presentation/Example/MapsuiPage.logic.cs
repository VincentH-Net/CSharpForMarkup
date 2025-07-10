using Mapsui;
using Mapsui.Extensions;
using Mapsui.Projections;
using Mapsui.Tiling;
using MuiUI = Mapsui.UI.WinUI;

namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class MapsuiPage : BasePage<MapsuiViewModel>, IBuildUI
{
    public MapsuiPage() => BuildUI();

    void CenterOnLocation(MuiUI.MapControl control)
    {
        var map = new Map();
        map.Layers.Add(OpenStreetMap.CreateTileLayer());

        // Get the lon lat coordinates from somewhere (Mapsui can not help you there)
        var centerOfLondonOntario = new MPoint(-81.2497, 42.9837);
        // OSM uses spherical mercator coordinates. So transform the lon lat coordinates to spherical mercator
        var sphericalMercatorCoordinate = SphericalMercator.FromLonLat(centerOfLondonOntario.X, centerOfLondonOntario.Y).ToMPoint();
        // Set the center of the viewport to the coordinate. The UI will refresh automatically
        // Additionally you might want to set the resolution, this could depend on your specific purpose
        map.Navigator.CenterOnAndZoomTo(sphericalMercatorCoordinate, map.Navigator.Resolutions[9]);

        control.Map = map;
    }
}
