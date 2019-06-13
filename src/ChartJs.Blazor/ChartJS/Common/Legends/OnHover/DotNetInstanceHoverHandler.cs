﻿using ChartJs.Blazor.ChartJS.Common.Utils;
using Microsoft.JSInterop;

namespace ChartJs.Blazor.ChartJS.Common.Legends.OnHover
{
    public class DotNetInstanceHoverHandler : ILegendOnHoverHandler
    {
        public DotNetObjectRef<LegendItemOnHover> InstanceRef { get; }
        public string MethodName { get; }

        public delegate void LegendItemOnHover(object sender, object mouseMove);

        public DotNetInstanceHoverHandler(DotNetObjectRef<LegendItemOnHover> legendItemOnHoverHandler)
        {
            // Check for null
            ArgValidation.AssertNotNullOrEmpty(nameof(legendItemOnHoverHandler), legendItemOnHoverHandler);

            // Check for the method to be public and static
            ArgValidation.AssertIsPublic(legendItemOnHoverHandler.Value.Method);

            // Check for the JsInvokable attribute
            ArgValidation.AssertHasCustomAttribute(legendItemOnHoverHandler.Value.Method, typeof(JSInvokableAttribute));

            // The parameters and return type is taken care of by te delegate's definition

            InstanceRef = legendItemOnHoverHandler;
            MethodName = legendItemOnHoverHandler.Value.Method.Name;
        }
    }
}