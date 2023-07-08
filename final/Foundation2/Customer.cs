using System;


class Customer

{
    private string _nameCustomer;
    //private bool _inOrOutUSA;

    public Address _address;

    //private string Address address;


    public Customer (string nameCustomer, Address address)
    
    {
        _nameCustomer = nameCustomer;
        _address = address;

    }

    public string GetNameCustomer()
    {
        return _nameCustomer;
    }
    

    public bool CustomerInorOutUSA()
    {
        return _address.InorOutUSA();
    
    }

    public Address GetAddress()
    {
        return _address;
    }

}