using System.Globalization;


namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayent { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayent, double tax)
        {
            BasicPayent = basicPayent;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayent + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayent.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: "
                + TotalPayment.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
