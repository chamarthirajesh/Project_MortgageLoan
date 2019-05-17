using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Loan_Officer
    {
        string _officer_Id, _status;
        DateTime _dateOfApproveOrReject;
        string _customer_Id, _remarks;

        public string Officer_Id { get => _officer_Id; set => _officer_Id = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime DateOfApproveOrReject { get => _dateOfApproveOrReject; set => _dateOfApproveOrReject = value; }
        public string Customer_Id { get => _customer_Id; set => _customer_Id = value; }
        public string Remarks { get => _remarks; set => _remarks = value; }

    }
}