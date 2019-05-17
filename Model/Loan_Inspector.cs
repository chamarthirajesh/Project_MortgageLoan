using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Loan_Inspector
    {
        string _inspector_Id, _status;
        DateTime _dateOfApproveOrReject;
        string _customer_Id, _user_Id, _Remarks;

        public string Inspector_Id { get => _inspector_Id; set => _inspector_Id = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime DateOfApproveOrReject { get => _dateOfApproveOrReject; set => _dateOfApproveOrReject = value; }
        public string Customer_Id { get => _customer_Id; set => _customer_Id = value; }
        public string User_Id { get => _user_Id; set => _user_Id = value; }
        public string Remarks { get => _Remarks; set => _Remarks = value; }
    }
}