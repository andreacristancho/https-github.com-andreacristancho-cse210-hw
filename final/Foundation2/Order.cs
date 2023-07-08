using System;
//using System.Collections.Generic;

class Order

{
    private Customer _nameCustomer;
    //private double _totalPriceToOrder;
    
    private List<Product> _productsList;



    public Order (Customer nameCustomer,  List<Product> productsList)
    
    {
        _nameCustomer = nameCustomer;
        _productsList = productsList;
    }

   
    public double GetTotalPriceOrder()
    {
        double totalPriceOrder = 0;

        foreach (Product eachproduct in _productsList)
        {
            
            totalPriceOrder += eachproduct.GetPriceOfProduct();
             
        }   
            bool customerInUSA = _nameCustomer.CustomerInorOutUSA();
            if (customerInUSA == true)
            totalPriceOrder += 5;
            else
            totalPriceOrder+= 35;
               
        
        return totalPriceOrder;

    }

    // Llamo la función ForPckingLabel de Product que es tipo lista de strings y tiene como 
    //parámetros name e ID. Creo una lista vacía packingLabel y recorro _productsList que viene de Product
    //para tomar de allí cada producto y su ID.
    public List<string> GetPackingLabel()
    {
        List<string> packingLabel = new List<string>();

        foreach (Product product in _productsList)
        {
            
            string label = "Name: " + product.GetName() + " | ID: " + product.GetId();
            
            packingLabel.Add(label);
        }

        return packingLabel;
    }

    


    public string GetShippingLabel()
    {
        
        string shippingLabel_1 = "Name of Customer: "+ _nameCustomer.GetNameCustomer()+". ";
        string shippingLabel_2 = "Address: " + _nameCustomer._address.GetAddress()+". ";
              
        return shippingLabel_1 +"\n"+shippingLabel_2;
    }

}