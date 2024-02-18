using PdfSharp.Fonts;

namespace Excel.Report.PDF.BlazorWebApp.Models;

public class AspNetFontResolver(IWebHostEnvironment Environment) : IFontResolver
{
	//public byte[] GetFont(string faceName)
	//		//Implement so that you can get as many fonts as you need.
	//		=> faceName.EndsWith("#b") ? Resources.NotoSansJP_ExtraBold : Resources.NotoSansJP_Regular;

	public byte[] GetFont(string faceName) => faceName.EndsWith("#b")
		? ReadResource("NotoSansJP-ExtraBold.ttf")
		: ReadResource("NotoSansJP-Regular.ttf");

	private byte[] ReadResource(string file)
	{
		var path = Path.Combine(Environment.ContentRootPath, "Resources", file);
		var bs = File.ReadAllBytes(path);
		return bs;
	}

	public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
	{
		var faceName = familyName;
		if (isBold) faceName += "#b";
		return new FontResolverInfo(faceName);
	}
}
