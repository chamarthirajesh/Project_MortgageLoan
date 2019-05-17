using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Authorizer
    {
        string _id, _status, _customer_Id, _user_Id;
        DateTime _dateOfApproveOrReject;
        long _loan_No;
        string _remarks;
        float _disbursed_Amount;
        int _tenure;

        public string Id { get => _id; set => _id = value; }
        public string Status { get => _status; set => _status = value; }
        public string Customer_Id { get => _customer_Id; set => _customer_Id = value; }
        public string User_Id { get => _user_Id; set => _user_Id = value; }
        public DateTime DateOfApproveOrReject { get => _dateOfApproveOrReject; set => _dateOfApproveOrReject = value; }
        public long Loan_No { get => _loan_No; set => _loan_No = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }
        public float Disbursed_Amount { get => _disbursed_Amount; set => _disbursed_Amount = value; }
        public int Tenure { get => _tenure; set => _tenure = value; }
    }
}