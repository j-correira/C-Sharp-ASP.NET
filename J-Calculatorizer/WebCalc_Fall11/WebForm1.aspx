<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>J - Calculatorizer</title>


 <style>


body
{
    font-family: Tahoma, Verdana, Segoe, sans-serif;
}

.wrap 
{
  margin: auto;
  width: 40%;
  padding: 10px;
}

#centerForm 
{
  margin: auto;
  width: 100%;
  padding: 10px;
}

#centerCenter
{
    margin:0 auto;
    width:183px;
    height: 347px;
    border: 2px solid #2e3131;
    border-radius: 20px 20px 20px 20px;
    padding: 22px;


}

#txtLCD
{
    width: 179px;
    background-color:#f5f6fa;
    margin-bottom: 5px;
}

.buttons
{
    border-radius: 14px;
    font-size:15px;
    color: white;
    width: 40px;
    padding: 10px;
    margin: 1px;
    text-align: center;
    text-decoration: none;
    background-color: #95a5a6;
    display: inline-block;
    font-weight: bold;
}
.buttons.operator
{
    border-radius: 14px;
    color: white;
    padding: 10px;
    text-align: center;
    text-decoration: none;
    background-color: #e67e22;
    display: inline-block;
}

.buttons.memory
{
    border-radius: 14px;
    font-size: 11px;
    color: #2e3131;
    padding: 10px;
    text-align: center;
    text-decoration: none;
    background-color: #ecf0f1;
    display: inline-block;
}

#btn0
{
    width: 86px;
}

#btnClear
{
    width: 177px;
    background-color: #e74c3c;
    margin-top: 2px;
}

#results
{
    margin:0 auto;
    width:max-content;
    height: 20px;
}

H3
{
    display: inline;
    padding: 0px;
    margin: 0px;
    color:#2e3131;

}

hr
{
    width: 100%;
    margin-top:14px;
    margin-bottom: 16px;
}



</style>

</head>
<body>
<div class="wrap">

    <div id="centerForm">

    <div id="centerCenter">
    <form id="form1" runat="server">
        <asp:TextBox ID="txtLCD" placeholder="              ! Calculator !" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnMS" class="buttons memory"  runat="server" Text="MS" OnClick="btnMS_Click" />
        <asp:Button ID="btnMR" class="buttons memory"  runat="server" Text="MR" OnClick="btnMR_Click" />
        <asp:Button ID="btnMC" class="buttons memory"  runat="server" Text="MC" OnClick="btnMC_Click" />
        <asp:Button ID="btnDivide" class="buttons operator"  runat="server" Text="/" OnClick="btnDivide_Click" />
        <br />
        <asp:Button ID="btn7" class="buttons"  runat="server" Text="7" OnClick="Numbers_Click" />
        <asp:Button ID="btn8" class="buttons"  runat="server" Text="8" OnClick="Numbers_Click" />
        <asp:Button ID="btn9" class="buttons"  runat="server" Text="9" OnClick="Numbers_Click" />
        <asp:Button ID="btnMultiply" class="buttons operator"  runat="server" Text="*" OnClick="btnMultiply_Click" />
        <br />
        <asp:Button ID="btn4" class="buttons"  runat="server" Text="4" OnClick="Numbers_Click" />
        <asp:Button ID="btn5" class="buttons"  runat="server" Text="5" OnClick="Numbers_Click" />
        <asp:Button ID="btn6" class="buttons"  runat="server" Text="6" OnClick="Numbers_Click" />
        <asp:Button ID="btnMinus" class="buttons operator"  runat="server" Text="-" OnClick="btnMinus_Click" />
        <br />
        <asp:Button ID="btn1" class="buttons" runat="server" Text="1" OnClick="Numbers_Click" />
        <asp:Button ID="btn2" class="buttons"  runat="server" Text="2" OnClick="Numbers_Click" />
        <asp:Button ID="btn3" class="buttons"  runat="server" Text="3" OnClick="Numbers_Click" />
        <asp:Button ID="btnPlus" class="buttons operator"  runat="server" Text="+" OnClick="btnPlus_Click" />
        <br />
        <asp:Button ID="btn0" class="buttons"  runat="server" Text="0" OnClick="Numbers_Click" />
        <asp:Button ID="btnDecimal" class="buttons"  runat="server" Text="." OnClick="Numbers_Click" />
        <asp:Button ID="btnEquals" class="buttons operator"  runat="server" Text="=" OnClick="btnEquals_Click" />
        <br />
        <asp:Button ID="btnClear" class="buttons"  runat="server" Text="Clear" OnClick="btnClear_Click" />
        <br />
        <hr>
        <div id="results">
            <h3>[</h3>
            <asp:Label ID="lblNum1" runat="server"></asp:Label>
            <asp:Label ID="lblOperator" runat="server"></asp:Label>
            <asp:Label ID="lblNum2" runat="server"></asp:Label>
            <asp:Label ID="lblEqual" runat="server"></asp:Label>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <h3>]</h3>
        </div>
    </form>
    <div id="results"><h3>Memory: </h3><asp:Label ID="lblMemory" runat="server"></asp:Label></div>
    </div><!-- close centerCenter -->

    </div><!-- close center form -->
    </div><!-- close wrap -->

</body>
</html>