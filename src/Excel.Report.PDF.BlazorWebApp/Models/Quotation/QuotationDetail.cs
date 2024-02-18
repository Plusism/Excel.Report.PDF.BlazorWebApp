namespace Excel.Report.PDF.BlazorWebApp.Models;

public class QuotationDetail
{
	public string Title { get; set; } = string.Empty;

	public string Detail { get; set; } = string.Empty;

	public decimal Price { get; set; }

	public decimal Discount { get; set; }

	public decimal Total => Price - Discount;
}
