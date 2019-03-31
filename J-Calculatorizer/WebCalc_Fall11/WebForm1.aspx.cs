﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



/*
(x) 1)   Place one textbox (LCD) on the page to hold the two values to be added, subtracted, multiplied, etc.

(-) 2)   Place two labels to the right of the LCD textbox.  One to let us know if something is stored in memory (“M”), the other to let us know the last math operation that occurred (+, -, *, /)

(x) 3)    Place buttons on the page for each number, each math operation, memory feature, and equals sign.

(-) 4)   When a number button is clicked, either concatenate it to the existing number within the LCD or clear the LCD and place the number within the cleared LCD.

(-) 5)   When math operator button is clicked, store the current LCD value and operation within variables and clear the LCD.

(-) 6)   When the Equals sign is pressed, store the LCD value within another variable, then perform the calculation, and display results within LCD.

(-) 7)   BONUS (10 points) Employ MS, MR, MC buttons to Store, Restore, and Clear the memory variable.


*/

public partial class _Default : System.Web.UI.Page
{



    protected void Page_Load(object sender, EventArgs e)
    {

    }


    //operator functions
    protected void btnPlus_Click(object sender, EventArgs e)
    {
        lblNum1.Text = txtLCD.Text;
        txtLCD.Text = "";
        lblOperator.Text = "+";
    }

    protected void btnMinus_Click(object sender, EventArgs e)
    {
        lblNum1.Text = txtLCD.Text;
        txtLCD.Text = "";
        lblOperator.Text = "-";
    }

    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        lblNum1.Text = txtLCD.Text;
        txtLCD.Text = "";
        lblOperator.Text = "*";
    }

    protected void btnDivide_Click(object sender, EventArgs e)
    {
        lblNum1.Text = txtLCD.Text;
        txtLCD.Text = "";
        lblOperator.Text = "/";
    }

    protected void btnEquals_Click(object sender, EventArgs e)
    {
        lblNum2.Text = txtLCD.Text;
        lblEqual.Text = "=";
        txtLCD.Text = "";

        double num1, num2, result = 0;

        num1 = Convert.ToDouble(lblNum1.Text);
        num2 = Convert.ToDouble(lblNum2.Text);

        //perform appropriate equation based on the operator
        switch (lblOperator.Text)
        {

            case "+":
                result = num1 + num2;
                break;

            case "-":
                result = num1 - num2;
                break;

            case "*":
                result = num1 * num2;
                break;

            case "/":
                result = num1 / num2;
                break;

            case "%":
                result = num1 % num2;
                break;
        }//end switch

        //output result to LCD & Label
        lblResult.Text = result.ToString();
        txtLCD.Text = result.ToString();

    }//end = function


    //memory function
    protected void btnMS_Click(object sender, EventArgs e)
    {

    }

    protected void btnMR_Click(object sender, EventArgs e)
    {

    }

    protected void btnMC_Click(object sender, EventArgs e)
    {

    }


    //number buttons
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtLCD.Text = "";
        lblNum1.Text = "";
        lblNum2.Text = "";
        lblEqual.Text = "";
        lblOperator.Text = "";
        lblResult.Text = "";
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "1";
    }

    protected void btn2_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "2";
    }

    protected void btn3_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "3";
    }

    protected void btn4_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "4";
    }

    protected void btn5_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "5";
    }

    protected void btn6_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "6";
    }

    protected void btn7_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "7";
    }

    protected void btn8_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "8";
    }

    protected void btn9_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "9";
    }

    protected void btn0_Click(object sender, EventArgs e)
    {
        txtLCD.Text += "0";
    }

    protected void btnDecimal_Click(object sender, EventArgs e)
    {
        txtLCD.Text += ".";
    }
}