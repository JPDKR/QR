using iTextSharp.text;
using iTextSharp.text.pdf;

string outputFile = @"C:\Users\Julian Podbersich\Downloads\prueba.pdf";
string url = "https://www.metal-archives.com/bands/kreator/157";

Document doc = new(PageSize.A4);
PdfWriter.GetInstance(doc, new FileStream(outputFile, FileMode.Create));
doc.Open();
BarcodeQRCode barcodeQRCode = new(url, 1000, 1000, null);
Image codeQRImage = barcodeQRCode.GetImage();
codeQRImage.ScaleAbsolute(200, 200);
doc.Add(codeQRImage);
doc.Close();