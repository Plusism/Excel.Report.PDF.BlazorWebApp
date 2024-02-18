namespace Excel.Report.PDF.BlazorWebApp.Models;

public class Quotation
{
	public string Title { get; set; } = string.Empty;

	public string Client { get; set; } = string.Empty;

	public string PersonInCharge { get; set; } = string.Empty;

	public List<QuotationDetail> Details { get; } = new();

	public decimal Total => Details.Sum(x => x.Total);

	public decimal Tax => Total * (decimal)0.1;

	public decimal TotalInTax => Total + Tax;
}
