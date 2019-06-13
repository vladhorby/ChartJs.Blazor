using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.ChartJS.MixedChart
{
	public class RenderOptions
	{
		//	duration: 800,
		//	lazy: false,
		//	easing: 'easeOutBounce'
		public int Duration { get; set; } = 800;
		public bool Lazy { get; set; } = false;
		public string Easing { get; set; } = "easeOutBounce";
	}
}
