namespace NancyManualViewRenderingTest
{
    using Nancy;

    public class TestModule : NancyModule
    {
        public TestModule(IViewRenderer viewRenderer)
        {
            Get["/"] = _ => viewRenderer.RenderView(this.Context, "TestView", new { Name = "Bob" })
                                        .WithContentType("text/plain");
        }
    }
}