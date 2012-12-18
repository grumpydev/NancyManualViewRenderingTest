﻿namespace NancyManualViewRenderingTest
{
    using System;
    using System.Linq;

    using Nancy;
    using Nancy.ViewEngines;

    public interface IViewRenderer
    {
        Response RenderView(NancyContext context, string viewName, object model = null);
    }

    class ViewRenderer : IViewRenderer
    {
        private readonly IViewFactory factory;

        public ViewRenderer(IViewLocationCache cache, IViewFactory factory)
        {
            this.factory = factory;
        }

        public Response RenderView(NancyContext context, string viewName, object model = null)
        {
            var viewContext = new ViewLocationContext { Context = context };

            return this.factory.RenderView(viewName, model, viewContext);
        }
    }
}