using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form1 : Form
    {
        double num1, num2, answ,balance,trans,deposit;
        int number,target, count;
        string name;
        private Customer nCus; // decalre instance of Customer Class
        public Form1()
        {
            InitializeComponent();
        }
        //*******************************************Week1********************************************************
        /* Week 1 – Lab exercises
         
        1	Create a Windows application that can be used to input a user’s name. Include an appropriate label indicator for the name and a textbook for the input entry.
        A button labelled Submit should retrieve and display the value entered on another label positioned near the bottom of the form. The font color for the text for the
        label object should be yellow. Change the background color of the form to an appropriate use to use with your yellow text. Change the Font property to a font of your 
        choice. The size of the font for all objects except the Button should be at least 14 points. The Button font should be 16 points. Add a title caption of “Name Retrieval App” to the form. 
        Initially clear the text from the label that will display your final answer. When the Submit button is pressed, retrieve the name and concatenate that value with a Congratulatory message.  For example, you might display, “Congratulations, Brenda Lewis, you retrieved the data!” if your name was Brenda Lewis. Position the button so it is in the center of the form. Align the other controls so they are aesthetically pleasing.  Be sure to change the default names of all controls involved in program statements.
        
        2	Create a Windows application that can be used to change the form color. Your form background color should initially be blue. Provide at least two buttons with two different color
        choices and a Reset option. Change the font style and size on the buttons. Align the buttons so that they are in the center of the form. The color choice buttons should be the same size.
        Add event handlers for the buttons so that when the user clicks the but-ton, the form changes color, and a message box is displayed alerting the user as to what color the form is.
        Be sure to name any controls used in program statements prior to registering your event. Change the default title bar text.
        Hint: This exercise may require you to do some research. You may want to review the code placed in the .Designer.cs file after you set the form’s initial color.
        
        3	Create a Windows application that contains two textboxes and three buttons.  The textboxes should be used to allow the user to input two positive numeric values.
        The buttons should be labeled Add and Multiply and Reset. Create event-handler methods that retrieve the values, perform the calculations, and display the result of the
        calculations on a label.  The result label should initially be set to be invisible with a font color of yellow. If invalid data is entered, change the font color to red
        on the result label and display a message saying “Value must be numeric and > 0.” When the final answer is displayed, the font color should be yellow. Additional labels
        will be needed for the textboxes captions. Do not allow non-numeric characters to be entered. Invoke the TryParse()method  to  retrieve  the  values.  
        All controls involved in program statements should be named. Right justify values in the textbox.
        
        4	Create a Windows application that can be used to determine distance traveled given speed and time. Provide textboxes for time and speed and a but-ton to calculate
        the distance. Be sure that only numeric data is able to be entered into the textboxes. Experiment with the controls’ properties. Spend time with your design so that 
        your GUI is very user friendly and looks nice.
        
        5	Create a Windows application that functions like a banking account register. The graphical user interface should initially allow the user to input the account name,
        number, and initial balance. Ensure that the full name is entered for the customer and that only numeric values are entered for number fields when the Create Account
        button is selected. Separate the business logic from the presentation layer by creating a Customer class. Include a deposit to and withdraw from methods in the Customer
        class to keep the balance updated.  After an object of the Customer class is instantiated, provide textbox objects on your GUI for withdrawals and deposits.
        A second button should be available to update the account for withdrawal and deposit transactions showing the new balance.
        
        6	Create the higher/lower guessing game using a GUI. Allow users to keep guessing until they guess the number.  Keep a count of the number of guesses. Choose
        two colors for your game: one should be used to indicate that the value the users guessed is higher than the target; the other is used to indicate that the value the
        users guessed is lower than the target. With each new guess, show the guess count and change the form color based on whether the guess is higher than the target or 
        lower.  When they hit the target, display a message on a label indicating the number of guesses it took. Provide a reset button to enable the user to re-start the 
        game without re-running your application. Tie the guess button to the enter key and the reset button to the cancel key. Several approaches can be used to seed the
        target: One is to generate a random number by constructing an object of the Random class. For example, the following stores a random whole number between 0 and 100 
        in target:
        Random r = new Random( );
        int target = r.next(0, 101);

         */
        private void bTsubmit_Click(object sender, EventArgs e)  //Week Exercise 1
        {
            lBretriveName.Text = tBname.Text;
        }

        private void metroButton1_Click(object sender, EventArgs e)  //Week Exercise 1
        {

            tPweek1.BackColor = System.Drawing.Color.Aqua;
            MessageBox.Show("Color is set to Agua");
        }

        private void bTdivision_Click(object sender, EventArgs e) //Week Exercise 2
        {
            if ((tBnum1.Text == "" || tBnum2.Text == ""))
            {
                lBanswer.Text = "Value must be numeric and > 0.";
                lBanswer.ForeColor = System.Drawing.Color.Red;
                lBanswer.Visible = true;
            }
            if (tBnum1.Text != "" || tBnum2.Text != "")
            {
                if (double.TryParse(tBnum1.Text, out num1) == false)
                {
                    lBanswer.Text = "Value must be numeric and > 0.";
                    lBanswer.Visible = true;
                    lBanswer.ForeColor = System.Drawing.Color.Red;
                }
                if (double.TryParse(tBnum2.Text, out num2) == false)
                {
                    lBanswer.Text = "Value must be numeric and > 0.";
                    lBanswer.Visible = true;
                    lBanswer.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    answ = num1 - num2;


                    lBanswer.Text = answ.ToString();
                    lBanswer.ForeColor = System.Drawing.Color.Black;
                    lBanswer.Visible = true;

                }
            }
        }

        private void bTreset_Click(object sender, EventArgs e)  //Week Exercise 2
        {
            tBnum1.Text = "0";
            tBnum2.Text = "0";
            lBanswer.Text = "";
        }

        private void tBspeed_KeyPress(object sender, KeyPressEventArgs e)  //Week Exercise 3
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8) // 8 is backspace key: So only numbers and backspase will be accepted in textbox
            {
                e.Handled = true;
                lBerrorSppedandTime.Text = "Please enetr a valid value";
            }
        }

        private void bTdistance_Click(object sender, EventArgs e) //Week Exercise 4
        {
            double speed ,time;
            speed = double.Parse(tBspeed.Text);
            time = double.Parse(tBtime.Text);
            double answer = speed * time;
            lBdistance.Text = answer.ToString()+"km";
        }

        private void btUptade_Click(object sender, EventArgs e)  //Week Exercise 5
        {
            if (tBwithdrow.Text=="" || tBdeposit.Text == "")
            {
                lbBannkError.Text = "Please Enter amount you wish to Deposit or Withdraw";
            }
            if (lbBannkInfo.Text == "")
            {
                lbBannkError.Text = "Please create account first ";
            }
            if (tBwithdrow.Text != "")
            {
                if (tBdeposit.Text != "")
                {
                    balance = Deposit();// update balance value 
                    balance = Transfer();// using update value from Deposit() and subtruct value ;
                    

                    lbBannkInfo.Text = "\nName on Account:" + tBaccName.Text +
                            "\nAccount Number:" + tBaccNumber.Text.ToString() +
                            "\nBalance on Account:" + balance.ToString() + "$";
                }
                if (tBdeposit.Text == "")
                {
                    balance = Transfer();

                    lbBannkInfo.Text = "\nName on Account:" + tBaccName.Text +
                            "\nAccount Number:" + tBaccNumber.Text.ToString() +
                            "\nBalance on Account:" + balance.ToString() + "$";
                }
                
            }
            else if (tBdeposit.Text !="")
            {
                balance = Deposit();

                lbBannkInfo.Text = "\nName on Account:" + tBaccName.Text +
                        "\nAccount Number:" + tBaccNumber.Text.ToString() +
                        "\nBalance on Account:" + balance.ToString() + "$";

            }
           
            
        }

        private void btResetGAme_Click(object sender, EventArgs e) //Week Exercise 6
        {
            Random r = new Random();
            target = r.Next(0, 11);
            lbNumberGuess.Text = "";
            lbGuessError.Text = "";
            lbWin.Text = "";
            tPweek1.BackColor = System.Drawing.Color.Transparent;

        }

        private void tBguess_TextChanged(object sender, EventArgs e) // Will change color when entering integres to TextForm,  //Week Exercise 6
        {
            if (tBguess.Text == "")
            {
                lbGuessError.Text = "PLease Enter Number From 0-10";
            }
            if (tBguess.Text != "")
            {
                count++;
                lbNumberGuess.Text = "Number of tries:"+count.ToString();
                int num = int.Parse(tBguess.Text);
                if (num < target)
                {
                    tPweek1.BackColor = System.Drawing.Color.Red;
                }
                else if (num > target)
                {
                    tPweek1.BackColor = System.Drawing.Color.Yellow;
                }
                else if (num == target)
                {
                    tPweek1.BackColor = System.Drawing.Color.Green;
                    lbWin.Text = "Winner!";
                }

            }
            
        }

        private void btAccRegistr_Click(object sender, EventArgs e) //Week Exercise 5
        {
            nCus = new Customer();
            number = nCus.Account = int.Parse(tBaccNumber.Text);
            name = nCus.Name = tBaccName.Text;
            balance = nCus.Balance = double.Parse(tBaccBalance.Text);
            lbBannkInfo.Text = nCus.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)  //Week Exercise 6
        {
            Random r = new Random();
             target = r.Next(0, 11);

        }

        private void bTadd_Click(object sender, EventArgs e)  //Week Exercise 3
        {
            if ((tBnum1.Text == "" || tBnum2.Text == ""))
            {
                lBanswer.Text = "Value must be numeric and > 0.";
                lBanswer.ForeColor = System.Drawing.Color.Red;
                lBanswer.Visible = true;
            }
           if(tBnum1.Text != "" || tBnum2.Text != "")
            { 
               if(double.TryParse(tBnum1.Text, out num1) == false)
                {
                    lBanswer.Text = "Value must be numeric and > 0.";
                    lBanswer.Visible = true;
                    lBanswer.ForeColor = System.Drawing.Color.Red;
                }
                if (double.TryParse(tBnum2.Text, out num2) == false)
                 {
                        lBanswer.Text = "Value must be numeric and > 0.";
                        lBanswer.Visible = true;
                        lBanswer.ForeColor = System.Drawing.Color.Red;
                 }
                else
                 {
                        answ = num1 + num2;

                        
                        lBanswer.Text = answ.ToString();
                        lBanswer.ForeColor = System.Drawing.Color.Black;
                        lBanswer.Visible = true;

                 }
            }
            //lBanswer.Text = Addition().ToString(); if we need to use Method and not varible
        }


        /* Metod for addition and while loop for checking double values 
        public double Addition()
        {
            double num1, num2;
            while (double.TryParse(tBnum1.Text, out num1) == false)
            {
                lBanswer.Text = "Value must be numeric and > 0.";
                lBanswer.Visible = true;
                lBanswer.ForeColor = System.Drawing.Color.Red;
            }
            while (double.TryParse(tBnum1.Text, out num2) == false)
            {
                lBanswer.Text = "Value must be numeric and > 0.";
                lBanswer.Visible = true;
                lBanswer.ForeColor = System.Drawing.Color.Red;
            }
            return num1 + num2;        
        }
        */
        public double Transfer()  //Week Exercise 5
        {
            trans = double.Parse(tBwithdrow.Text);
            if (balance == 0 || balance < trans)
            {
                lbBannkError.Text = "Amount exceed the balance";
            }
            else 
            {
                balance = balance - trans;
            }

            return balance;
        }
        public double Deposit()  //Week Exercise 5
        {
           
            deposit = double.Parse(tBdeposit.Text);
            
                balance = balance + deposit;
            

            return balance;
        }

        /* Will tie buttons to button Click for last Exercise Week 1 , Key down function for form 
           private void Form1_KeyDown(object sender, KeyEventArgs e) 
            {
                if (e.KeyCode == Keys.Enter){
                    button.PerformClick();
                }
            }
         */

        //*******************************************Week2********************************************************
        /*Week 2 – Lab exercises         
        1    Create a Windows application that can be used as a sign-up sheet for ski equipment for the Flyers Sports Club. The club has ski equipment that it makes
        available to members at a minimal charge. In an attempt to determine what type of equipment members might need for an upcoming trip, they have asked you to
        design and implement an equipment- needs form. Include CheckBox objects that allow users to select the type of gear they will need to purchase for the trip. 
        Include selections of snow gloves, skis, goggles, earmuffs, and other items you feel are appropriate. Include at least one picture image on your application.
        After all selections are made, display a message indicating what items have been selected. You will probably want to include menu options to display and clear
        the order for the next user. Also include an option that enables the user to exit the application.

        2   Create an order form that allows bags to be purchased. There are six different types: full decorative, beaded, pirate design, fringed, leather, and plain. 
        Create a ListBox object for the different styles. Include a ComboBox for quantity. Quantities up to 10 should be provided. After the user makes a selection, 
        display a message indicating which selection was made. Include an option to clear selections. Provide appropriate error messages when selections are not made.
        Add to the application by including a control that allows the user to determine the type of shipping they desire. Include a set of radio buttons that contain 
        shipping options of overnight, three day, and standard. Add the price for each bag to the listbox selection as follows: full decorative—$50.00; beaded—$45.00;
        pirate design—$40.00; fringed—$25.00; leather—$80.00; and plain—$20.00. Display the items in the listbox in sort order. Using methods of the string class, 
        retrieve the price from the listbox. Display in a Windows dialog message box the total cost for the purchase. Include the selection, quantity, and shipping 
        charge. The shipping charges are based on the total purchase. The following per- centages are used: overnight—10%, three day—7%, and standard—5%.
            
        3   The computer club is selling T-shirts. Create an attractive user interface that allows users to select sizes (S, M, L, and XL) and quantity. Which controls
        would be most appropriate? Remember, the fewer keystrokes required of the user the better. Provide a menu labeled “Process”. Display the selections made by
        the user from a Process menu option under a “Display Order” option. Include an option to exit the application from the Process menu option.    Add to your 
        solution by including two more sizes, XSmall and XXLarge. Add statements that process the order by calculating the total cost. Each shirt is $16 except the
        XSmall and XXLarge; their specialty prices are $20.00 each. Include an “Add to Cart” option from the “Process” menu that enables the user to add multiple 
        selections to the order. Allow users to purchase different sizes on the same order. The “Display Order” option should be modified so that it displays the
        total cost for each selection and the final cost for the order. Include an additional “Help” menu option that displays instructions to the user indicating
        that they can make multiple size selections on a single order.
           
        4   Create a Windows application for purchasing floor covering. Allow the length and width (feet and inches) of a room to be entered. Be sure to include program 
        statements that will keep your program from crashing if they enter nonnumeric characters for the room dimensions. Using the tab control, provide selections
        such as Hardwood, Carpet, and Laminate. On each tab allow the user to select a type and price. Have a control that displays different types along with the
        prices of floor covering. Include, for example, options like Oak, Maple, Walnut, and Cherry Hardwood floors with prices such as $34.95 per square yard for
        Oak and $41.95 per square yard for Cherry. After the users enter their room dimensions and select the floor covering and price, display the total cost to
        cover the room. Include an option to clear selections. Place both the type of floor covering and the price in a single control, such as a ComboBox, and use 
        string manipulation techniques to strip the price out of the string.
         */

    }
}
