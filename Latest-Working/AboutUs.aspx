<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
    <style>
    img 
    {
        float: left;
        margin-top: 8px;
    }
    h5
    {
        margin:0;
    }
    #sidePara
    {
        padding:15px;
    }
</style>

    <h3>About us</h3>
    <br />
    <p>
    Tenderloin tongue t-bone ball tip salami sausage bresaola chuck. Ribeye andouille doner, bacon sausage tenderloin pork loin. Drumstick t-bone sausage cupim frankfurter fatback flank. Pork belly tongue pig sirloin, prosciutto rump pork loin burgdoggen.
        <img src="https://ya-webdesign.com/images/rick-and-morty-icon-circle-png-1.png" alt="rick and morty" style="width:180px;height:180px;margin-right:15px;">
        Jerky sausage pig ground round tail pancetta meatball burgdoggen t-bone sirloin.
        <br />
        <br />
        Bacon ipsum dolor amet boudin sirloin ribeye, shank andouille corned beef bresaola drumstick tongue chicken burgdoggen. Leberkas tri-tip shankle hamburger corned beef bacon. Tongue beef pork chop shankle ribeye burgdoggen. Alcatra burgdoggen picanha rump buffalo.
        <br />
        <br />
        Pork belly tongue pig sirloin, prosciutto rump pork loin burgdoggen. Jerky sausage pig ground round tail pancetta meatball burgdoggen t-bone sirloin.
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphSideContent" Runat="Server">
    <h5 id="sidePara">Rick & Morty</h5>
    <p id="sidePara">After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.
    </p>
</asp:Content>

