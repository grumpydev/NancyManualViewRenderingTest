namespace NancyManualViewRenderingTest
{
    using Nancy;

    public interface IViewRenderer
    {
        Response RenderView(NancyContext context, string viewName, object model = null);
    }
}