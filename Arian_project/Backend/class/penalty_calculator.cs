

using System;

namespace Arian_project.Backend
{
    public class Penalty_calculator
    {
        
        private Arian_project.Properties.Settings props = Properties.Settings.Default;
        public string penalty_method()
        {
            return props.penalty_method;
        }

        public decimal calculate_penalty(int days,decimal installment_price,string method)
        {
            switch (method)
            {
                case "درصدی":return percent_penalty_method(days, installment_price);
                case "ثابت":return permanent_penalty_method(days);
            }
            return 0;
        }

        public decimal penalty_value(string method = "")
        {
            if(method == "") {
                method = penalty_method();
            }
            switch (method)
            {
                case "ثابت": return decimal.Parse(props.penalty_price);
                case "درصدی": return decimal.Parse(props.penalty_percent);
                default: return 0;
            }
        }

        public decimal penalty_per_day(decimal instllment_price, string method = "")
        {
            if(method == "")
            {
                method = penalty_method();
            }
            return calculate_penalty(1, instllment_price,method);
        }

        public decimal permanent_penalty_method(int days)
        {
            decimal penalty_per_day = decimal.Parse(props.penalty_price);
            return penalty_per_day * days;
        }

        public decimal percent_penalty_method(int days,decimal installment_price) {
            decimal penalty_percent = decimal.Parse(props.penalty_percent)/100;
            decimal penalty = (installment_price * penalty_percent) * days;
            return penalty;
        }
    }
}
