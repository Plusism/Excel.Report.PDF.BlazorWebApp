using Excel.Report.PDF.BlazorWebApp.Models;
using PdfSharp.Fonts;

namespace Microsoft.AspNetCore.Builder;

public static class PdfSharpExtensions
{
	public static void UsePdfSharp(this WebApplication app)
	{
		GlobalFontSettings.FontResolver = new AspNetFontResolver(app.Environment);
	}
}