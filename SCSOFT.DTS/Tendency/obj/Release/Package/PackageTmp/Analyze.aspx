<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analyze.aspx.cs" Inherits="Tendency.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="res/js/jquery-1.8.3.min.js"></script>
    <script src="res/js/highcharts.js"></script> 
    <script>
        $(function () {
            $('#container').highcharts({
                title: {
                    text: '监测因子浓度变化',
                    x: -20 //center
                },
                subtitle: {
                    text: '单因子',
                    x: -20
                },
                xAxis: {
                    categories: [<%=categories%>],
                    labels: {
                        rotation: 0,
                        style: {
                            fontSize: '12px',
                            fontFamily: '宋体',
                            writingMode: 'tb-rl'    //文字竖排样式
                        }
                    }
                },
                yAxis: {
                    title: {
                        text: '毫克/升'
                    },
                    plotLines: [{
                        value: 0,
                        width: 1,
                        color: '#808080'
                    }]
                },
                tooltip: {
                    valueSuffix: 'mg/L'
                },
                legend: {
                    layout: 'vertical',
                    align: 'right',
                    verticalAlign: 'middle',
                    borderWidth: 0
                },
                series: [<%=series%>]
            });
        });

    </script>
</head>
<body>
    <form runat="server" id="form1">
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="流量" Value="fd_value2"></asp:ListItem>
            <asp:ListItem Text="化学需氧量" Value="fd_value13"></asp:ListItem>
            <asp:ListItem Text="氨氮" Value="fd_value8"></asp:ListItem>
            <asp:ListItem Text="pH" Value="fd_value3"></asp:ListItem>
            <asp:ListItem Text="溶解氧" Value="fd_value5"></asp:ListItem>
            <asp:ListItem Text="高锰酸盐指数" Value="fd_value6"></asp:ListItem>
            <asp:ListItem Text="生化需氧量" Value="fd_value7"></asp:ListItem>

            <asp:ListItem Text="总磷" Value="fd_value15"></asp:ListItem>
            <asp:ListItem Text="铜" Value="fd_value16"></asp:ListItem>
            <asp:ListItem Text="锌" Value="fd_value17"></asp:ListItem>
            <asp:ListItem Text="氟化物" Value="fd_value18"></asp:ListItem>
            <asp:ListItem Text="硒" Value="fd_value19"></asp:ListItem>
            <asp:ListItem Text="砷" Value="fd_value20"></asp:ListItem>
            <asp:ListItem Text="汞" Value="fd_value11"></asp:ListItem>
            <asp:ListItem Text="镉" Value="fd_value21"></asp:ListItem>
            <asp:ListItem Text="六价铬" Value="fd_value22"></asp:ListItem>
            <asp:ListItem Text="铅" Value="fd_value12"></asp:ListItem>
            <asp:ListItem Text="氰化物" Value="fd_value23"></asp:ListItem>
            <asp:ListItem Text="挥发酚" Value="fd_value10"></asp:ListItem>
            <asp:ListItem Text="石油类" Value="fd_value9"></asp:ListItem>
            <asp:ListItem Text="阴离子表面活性剂" Value="fd_value24"></asp:ListItem>
            <asp:ListItem Text="硫化物" Value="fd_value25"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <div id="container" style="min-width: 4000px; height: 400px; overflow: auto;"></div>
    </form>

</body>
</html>
