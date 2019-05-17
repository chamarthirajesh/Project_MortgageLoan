using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Payment
    {
        string _loan_No, _customer_Id;
        float _amountPerMonth;

        public string Loan_No { get => _loan_No; set => _loan_No = value; }
        public string Customer_Id { get => _customer_Id; set => _customer_Id = value; }
        public float AmountPerMonth { get => _amountPerMonth; set => _amountPerMonth = value; }
    }
}