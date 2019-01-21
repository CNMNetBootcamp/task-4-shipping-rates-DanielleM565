//setup
double weight;
string shippingCost;

//input
    PUT "What is the package's weight in lbs?";
    GET weight;

//process
    if (weight <= 2)
	{
        shippingCost = "$2";
	} else if (weight > 2 && weight <= 6) 
    { 
        shippingCost = "$4"
    } else if (weight > 6 && weight <= 10)
	{
        shippngCost = "$6"
	} else
	{
        shipping cost = "$8"
	}

//output
PUT "The shipping cost for that package will be " + shippingCost