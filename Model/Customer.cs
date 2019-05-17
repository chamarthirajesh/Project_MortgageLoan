using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Customer
    {
        string _customer_Id, _first_Name, _last_Name, _gender;
        int _age;
        long _mobile_No;
        string _email_Id, _state, _city, _street;
        int _pinCode;
        long _aadharCard_No;
        string _aadharCard_Upload, _panCard_No, _employment_Type, _name_Of_Organisation, _property_Document, _property_State, _property_City, _property_Street, _property_PlotNo;
        int _property_PinCode;
        string _bank_Name;
        long _account_No;
        string _IFSC, _paySlip;
        DateTime _applied_Date;
        int _loanDuration;
        string _status;
        long _desired_Amount;
        float _annual_Income;

        public string Customer_Id { get => _customer_Id; set => _customer_Id = value; }
        public string First_Name { get => _first_Name; set => _first_Name = value; }
        public string Last_Name { get => _last_Name; set => _last_Name = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int Age { get => _age; set => _age = value; }
        public long Mobile_No { get => _mobile_No; set => _mobile_No = value; }
        public string Email_Id { get => _email_Id; set => _email_Id = value; }
        public string State { get => _state; set => _state = value; }
        public string City { get => _city; set => _city = value; }
        public string Street { get => _street; set => _street = value; }
        public int PinCode { get => _pinCode; set => _pinCode = value; }
        public long AadharCard_No { get => _aadharCard_No; set => _aadharCard_No = value; }
        public string AadharCard_Upload { get => _aadharCard_Upload; set => _aadharCard_Upload = value; }
        public string PanCard_No { get => _panCard_No; set => _panCard_No = value; }
        public string Employment_Type { get => _employment_Type; set => _employment_Type = value; }
        public string Name_Of_Organisation { get => _name_Of_Organisation; set => _name_Of_Organisation = value; }
        public string Property_Document { get => _property_Document; set => _property_Document = value; }
        public string Property_State { get => _property_State; set => _property_State = value; }
        public string Property_City { get => _property_City; set => _property_City = value; }
        public string Property_Street { get => _property_Street; set => _property_Street = value; }
        public string Property_PlotNo { get => _property_PlotNo; set => _property_PlotNo = value; }
        public int Property_PinCode { get => _property_PinCode; set => _property_PinCode = value; }
        public string Bank_Name { get => _bank_Name; set => _bank_Name = value; }
        public long Account_No { get => _account_No; set => _account_No = value; }
        public string IFSC { get => _IFSC; set => _IFSC = value; }
        public string PaySlip { get => _paySlip; set => _paySlip = value; }
        public DateTime Applied_Date { get => _applied_Date; set => _applied_Date = value; }
        public int LoanDuration { get => _loanDuration; set => _loanDuration = value; }
        public string Status { get => _status; set => _status = value; }
        public long Desired_Amount { get => _desired_Amount; set => _desired_Amount = value; }
        public float Annual_Income { get => _annual_Income; set => _annual_Income = value; }
    }
}