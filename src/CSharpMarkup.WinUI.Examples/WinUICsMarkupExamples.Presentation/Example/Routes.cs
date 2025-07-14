namespace WinUICsMarkupExamples.Presentation.Example;

public static class Routes
{
    public static void Register(IViewRegistry views, IRouteRegistry routes)
    {
        views.Register(
            new ViewMap(ViewModel: typeof(ShellViewModel)),
            new ViewMap<SearchPage, SearchViewModel>(),
            new ViewMap<LiveCharts2Page, LiveCharts2ViewModel>(),
            new ViewMap<ScottPlotPage, ScottPlotViewModel>(),
            new ViewMap<MapsuiPage, MapsuiViewModel>(),
            new ViewMap<FlutterPage, FlutterViewModel>()
        );

        routes.Register(
            new RouteMap("", View: views.FindByViewModel<ShellViewModel>(),
                Nested: new RouteMap[]
                {
                    new RouteMap("Search", View: views.FindByViewModel<SearchViewModel>(), IsDefault:true),
                    new RouteMap("LiveCharts", View: views.FindByViewModel<LiveCharts2ViewModel>()),
                    new RouteMap("ScottPlot", View: views.FindByViewModel<ScottPlotViewModel>()),
                    new RouteMap("Mapsui", View: views.FindByViewModel<MapsuiViewModel>()),
                    new RouteMap("Flutter", View: views.FindByViewModel<FlutterViewModel>())
                }
            )
        );
    }
}
