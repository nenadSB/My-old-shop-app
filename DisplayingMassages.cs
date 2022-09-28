using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DisplayingMassages

    {

        /// <summary>
        /// A repeating message
        /// If we want to buy again or 
        ///  close the market.
        /// </summary>
        public void DisplayRepeatMassage()
        {
            

            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("If you want to go back to our online Market  you should pick 1::");
            Console.WriteLine("If you want to close the onilne market just press ENTER::\n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            
         }

        /// <summary>
        /// Thank you message.
        /// A User doesn't want to buy anything else.
        /// </summary>
        public void EndingProgram()
        {
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("Thenk you for being our customer!!!\n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
        }

        /// <summary>
        /// A vendor entered the smaller amount.
        /// </summary>
        public void EnteredSmallerAmountOfMoney()
        {
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("You enterd smaller amount than you should!!");
            Console.WriteLine("Please try again.\n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
        }

        /// <summary>
        /// An error message. A vendor did something wrong.
        /// Repeating message.
        /// </summary>
        public void RpeatProgramMessage()
        {
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("thank you for your time and efort.");
            Console.WriteLine("There is an error!! You should try again.  Thank you!!! \n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
        }

        /// <summary>
        /// Asking for a name message
        /// </summary>
        public void ShowEnterAgainMessage()
        {
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("Please enter your  full name::\n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
        }

        /// <summary>
        /// The welcoming message.
        /// </summary>
        public void ShowWelcomeMessage()
        {
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
            Console.WriteLine("WELCOME TO OUR ONLINE MARKET. \n");
            Console.WriteLine("**************************************** ");
            Console.WriteLine("**************************************** \n");
        }

        public void LogIn()
        {
            ///<summary>
            ///A vendor inputs his/her user names;
            /// and password.
            /// </summary>
           
                
            List<string> storage = new List<string>();
            storage.Add("mojeIme1");
            storage.Add("petarPan2");
            storage.Add("myKnowlage3");
            storage.Add("someFlawors4");

            ///<summary>
            ///goto statement inside switch => default;
            /// </summary>
            startagain:

            Console.WriteLine("**************************************** ");
            Console.WriteLine("Please enter your user name::");
            string? myName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("**************************************** \n");
            Console.WriteLine($"Welcome to the online market:: {myName}");


            Console.WriteLine("**************************************** \n");
            Console.WriteLine($"You can enter the password::");
            string? password = Convert.ToString(Console.ReadLine());
            Console.WriteLine("**************************************** \n");

            switch (password)
            {
                case "mojeIme1":

                    Console.WriteLine($"You logged in! Welcome:: {myName}\n");

                    break;

                case "petarPan2":

                    Console.WriteLine($"You logged in! Welcome:: {myName}\n");

                    break;

                case "myKnowlage3":

                    Console.WriteLine($"You logged in! Welcome:: {myName}\n");

                    break;

                case "someFlawors4":

                    Console.WriteLine($"You logged in! Welcome:: {myName}\n");

                    break;

                default:

                    Console.WriteLine($"The passowrd for the user:: {myName} is not correct!!\n");
                    goto startagain;
                    

            }



        }
    }
}
