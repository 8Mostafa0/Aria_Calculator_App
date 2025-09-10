using System;

namespace Arian_project.Backend
{
    public class Installment_calculator
    {
        private Arian_project.Properties.Settings props = Properties.Settings.Default;
        public string installment_type()
        {
            return props.installment_method;
        }
        public decimal installment_method(decimal full_price,int months) {
            double intrest_rate = props.Installment_percent;
            intrest_rate /= 100;
            string installment_method = props.installment_method;
            switch (installment_method)
            {
                case "سالیانه":
                    return installment_annual_method(full_price, months, intrest_rate);
                case "ماهیانه":
                    return CalculateCompoundInterestPayment(full_price, months, intrest_rate);
            }
            return 0;
        }

        public decimal installment_annual_method(decimal full_price,int months, double intrest_rate) {
            decimal installment_price = (decimal)Math.Pow((double)full_price, intrest_rate);
            return installment_price/months;
        }

        static decimal CalculateCompoundInterestPayment(decimal full_price, int months, double intrest_rate)
        {
            decimal percent_price = (decimal)full_price* (decimal)intrest_rate;
            decimal full_percent = (decimal)percent_price*months;
            decimal full_isntallment = full_price + full_percent;
            decimal one_month_price = full_isntallment / months;
            return one_month_price;
        }

    }
}
