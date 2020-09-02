<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkInfodatail.aspx.cs" Inherits="CXH.Web.WorkInfodatail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    作品ID：<label id="l1" runat="server"><%#Eval("Id") %></label>
    </div>
    <div>
    作品名称：<label id="l2" runat="server"><%#Eval("WorkName") %></label>
    </div>
    <div>
    作品图片：<label id="l3" runat="server"><%#Eval("WorkPicture") %></label>
    </div>
    <div>
    上传时间：<label id="l4" runat="server"><%#Eval("UploadTime") %></label>
    </div>
    <div>
    作品介绍：<label id="l5" runat="server"><%#Eval("WorkIntroduction") %></label>
    </div>
    <div>
    作品简介：<label id="l6" runat="server"><%#Eval("WorkVerify") %></label>
    </div>
    <div>
    作者：<label id="l7" runat="server"><%#Eval("UserName") %></label>
    </div>
     <div>
    活动名称：<label id="l8" runat="server"><%#Eval("ActivityName") %></label>
    </div>
    <div>
   推荐：<label id="l9" runat="server"><%#Eval("Recommend") %></label>
    </div>
    <div>
    推荐时间：<label id="l10" runat="server"><%#Eval("RecommendTime") %></label>
    </div>
        <asp:Button ID="Button1" runat="server" Text="返回" OnClick="Button1_Click" />
    </form>
</body>
</html>
