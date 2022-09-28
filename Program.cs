// See https://aka.ms/new-console-template for more information
using Practice;
class Program : DisplayingMassages

{
     
    
    public static void Main(string[] args)
    {
        ///<summary>
        /// The object is created
        /// </summary>
        
        DisplayingMassages extended = new DisplayingMassages();
    

        const double PDV = 20;
        string? vendor;
        double shoes = 24000;
        double Tshirts = 17800;
        double shirts = 38570;
        double pants = 25572;
        double toys = 107000;
        double hats = 12000;
        double yourFullPrice;





        ///<summary>
        /// goto statement, which is not recomendet to be used.
        /// </summary>

        extended.LogIn();



        extended.ShowEnterAgainMessage();
        vendor = Convert.ToString(Console.ReadLine());

        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");
        Console.WriteLine($"Vendors name is:: \t {vendor}  \n");
        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");

        Console.WriteLine("Please enter your card:: ");
        string? billNumber =Convert.ToString(Console.ReadLine());
        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");
        Console.WriteLine($"This is your card number:: \t  {billNumber}  \n");
        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");

        
        Console.WriteLine("Welcome to our online Market. <Hello>");
        Console.WriteLine("From this point you can pick and choose things you would like to buy::\n");

        ///<summary>
        ///goto statements
        /// </summary>
        beggingingOfTheProgram:
        repeat:
        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");
        Console.WriteLine($"1 - shoes.    Total price is: {shoes}");
        Console.WriteLine($"2 - T-shirts. Total price is: {Tshirts}");
        Console.WriteLine($"3 - shirts.   Total price is: {shirts}");
        Console.WriteLine($"4 - pants.    Total price is: {pants}");
        Console.WriteLine($"5 - toys.     Total price is: {toys}");
        Console.WriteLine($"6 - hats.     Total price is: {hats}\n");
        Console.WriteLine("**************************************** ");
        Console.WriteLine("**************************************** \n");



        int inputFromUser = Convert.ToInt32(Console.ReadLine());
    
        switch (inputFromUser)
        {
            case 1:
                Console.WriteLine("**************************************** ");
                Console.WriteLine("**************************************** \n");
                Console.WriteLine("You choose shoes. The price of shoes is: " + shoes);
                Console.WriteLine("Please enter the Price of the product shoes:: \n");
                Console.WriteLine("**************************************** ");
                Console.WriteLine("**************************************** \n");
                double priceOfProduct = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("**************************************** ");
                Console.WriteLine("**************************************** \n");

                Console.WriteLine($"The amount you entered:: {priceOfProduct}  \n");

                if (priceOfProduct < shoes)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct == shoes)
                {
                    double pricePDV = priceOfProduct * PDV / 100;
                    yourFullPrice = shoes - pricePDV;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice}");


                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }
                else
                {
                    double pricePDV = priceOfProduct * PDV / 100;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");

                    double realPrice =  shoes - priceOfProduct;
                    yourFullPrice = realPrice - pricePDV;

                    Console.WriteLine($"Your change is::\t {realPrice}\n");             
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");
                 

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }

                break;
            
            case 2:

                Console.WriteLine("You choose T-shirts. The price of T-shirt is: " + Tshirts);
                Console.WriteLine("Please enter the Price of the product T-shirts:: \n");
                double priceOfProduct2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("**************************************** \n");
              
                Console.WriteLine($"The amount you entered:: {priceOfProduct2}  \n");

                if (priceOfProduct2 < Tshirts)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct2 == Tshirts)
                {
                    double pricePDV = priceOfProduct2 * PDV / 100;
                    yourFullPrice = Tshirts - pricePDV;

                    Console.WriteLine($"PDV::\t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }
                else
                {
                    double pricePDV = priceOfProduct2 * PDV / 100;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");

                    double realPrice = priceOfProduct2 - Tshirts;
                    yourFullPrice = realPrice - pricePDV;

                    Console.WriteLine($"Your change is::\t {realPrice} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");


                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }

                break;

            case 3:

                Console.WriteLine("You choose shirts. The price of shirts is: " + shirts);
                Console.WriteLine("Please enter the Price of the product shirts:: \n");
                double priceOfProduct3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("**************************************** \n");
               
                Console.WriteLine($"The amount you entered:: {priceOfProduct3}  \n");

                if (priceOfProduct3 < shirts)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct3 == shirts)
                {
                    double pricePDV = priceOfProduct3 * PDV / 100;
                    yourFullPrice = shirts - pricePDV;

                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }

                }
                else
                {
                    double pricePDV = priceOfProduct3 * PDV / 100;
                    Console.WriteLine($"PDV::\t\t\t  {pricePDV} \n");

                    double realPrice = pricePDV - shirts;
                    yourFullPrice = realPrice - pricePDV;

                    Console.WriteLine($"Your change is::\t {realPrice} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");


                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }

                break;

            case 4:

                Console.WriteLine("You choose pants. The price of pants is: " + pants);
                Console.WriteLine("Please enter the Price of the product pants:: \n");
                double priceOfProduct4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("**************************************** \n");
                
                Console.WriteLine($"The amount you entered:: {priceOfProduct4}  \n");

                if (priceOfProduct4 < pants)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct4 == pants)
                {
                    double pricePDV = priceOfProduct4 * PDV / 100;
                    yourFullPrice = pants - pricePDV;

                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }

                }
                else
                {
                    double pricePDV = priceOfProduct4 * PDV / 100;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");

                    double realPrice = priceOfProduct4 - pants;
                    yourFullPrice = realPrice - pricePDV;
                    
                    Console.WriteLine($"Your change is::\t {realPrice} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }

                break;

            case 5:

                Console.WriteLine("You choose toys. The price of toys is: " + toys);
                Console.WriteLine("Please enter the Price of the product toys:: \n");
                double priceOfProduct5 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("**************************************** \n");
              
                Console.WriteLine($"The amount you entered:: {priceOfProduct5}  \n");

                if (priceOfProduct5 < shoes)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct5 == shoes)
                {
                    double pricePDV = priceOfProduct5 * PDV / 100;
                    yourFullPrice = shoes - pricePDV;

                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit **** \n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }

                }
                else
                {
                    double pricePDV = priceOfProduct5 * PDV / 100;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");

                    double realPrice = priceOfProduct5 - toys;
                    yourFullPrice = realPrice - pricePDV;

                    Console.WriteLine($"Your change is::\t {realPrice} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");
                    

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit **** \n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }

                }

                break;

            case 6:

                Console.WriteLine("You choose hats. The price of hats is: " + hats);
                Console.WriteLine("Please enter the Price of the product hats:: \n");
                double priceOfProduct6 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("**************************************** \n");

                Console.WriteLine($"The amount you entered:: {priceOfProduct6}  \n");

                if (priceOfProduct6 < shoes)
                {
                    extended.EnteredSmallerAmountOfMoney();
                    goto repeat;
                }
                else if (priceOfProduct6 == shoes)
                {
                    double pricePDV = priceOfProduct6 * PDV / 100;
                    yourFullPrice = shoes - pricePDV;

                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");

                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit **** \n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }
                }
                else
                {
                    double pricePDV = priceOfProduct6 * PDV / 100;
                    Console.WriteLine($"PDV:: \t\t\t  {pricePDV} \n");

                    double realPrice = priceOfProduct6 - hats;
                    yourFullPrice = realPrice - pricePDV;

                    Console.WriteLine($"Your change is::\t {realPrice} \n");
                    Console.WriteLine($"Your change with PDV is:: {yourFullPrice} \n");



                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");
                    Console.WriteLine($"Vendors name:: {vendor} \n");
                    Console.WriteLine("**** Thank you for you visit ****\n");
                    Console.WriteLine("**************************************** ");
                    Console.WriteLine("**************************************** \n");

                    extended.DisplayRepeatMassage();
                    string? num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        goto beggingingOfTheProgram;
                    }
                    else
                    {

                        extended.EndingProgram();
                    }


                }

                break;

            default:
                extended.DisplayRepeatMassage();
                goto repeat;



        }
        

        





    }
}
