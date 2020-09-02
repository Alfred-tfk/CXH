<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAdd.aspx.cs" Inherits="CXH.Web.UserAdd" %>

<html class="x-admin-sm">
    
    <head>
        <meta charset="UTF-8">
        <title>欢迎页面-X-admin2.2</title>
        <meta name="renderer" content="webkit">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <meta name="viewport" content="width=device-width,user-scalable=yes, minimum-scale=0.4, initial-scale=0.8,target-densitydpi=low-dpi" />
        <link rel="stylesheet" href="./css/font.css">
        <link rel="stylesheet" href="./css/xadmin.css">
        <script type="text/javascript" src="./lib/layui/layui.js" charset="utf-8"></script>
        <script type="text/javascript" src="./js/xadmin.js"></script>
        <!-- 让IE8/9支持媒体查询，从而兼容栅格 -->
        <!--[if lt IE 9]>
            <script src="https://cdn.staticfile.org/html5shiv/r29/html5.min.js"></script>
            <script src="https://cdn.staticfile.org/respond.js/1.4.2/respond.min.js"></script>
        <![endif]-->
        <style type="text/css">
            .gly{
                width:90px;
                position:absolute;
                left:125px;
            }
        </style>
    </head>
    <body>
        <div class="layui-fluid">
            <div class="layui-row">
                <form class="layui-form" runat="server">
                  <div class="layui-form-item">
                      <label for="username" class="layui-form-label">
                          用户名
                      </label>
                      <div class="layui-input-inline">
                          <input type="text" name="username" required="" lay-verify="required" id="username" runat="server"
                          autocomplete="off" class="layui-input">
                      </div>                     
                  </div>
                  <div class="layui-form-item">
                      <label for="phone" class="layui-form-label">
                          密码
                      </label>
                      <div class="layui-input-inline">
                          <input type="password"  required="" id="password"
                          autocomplete="off" class="layui-input" runat="server">
                      </div>
                      
                  </div>
                  <div class="layui-form-item">
                      <label for="L_email" class="layui-form-label">
                          QQ
                      </label>
                       <div class="layui-input-inline">
                          <input type="text" id="qq" name="qq" required="" 
                          autocomplete="off" class="layui-input" runat="server">
                      </div>
                      
                  </div>
                  <div class="layui-form-item">
                      <label class="layui-form-label">用户邮箱</label>
                      <div class="layui-input-inline">
                          <input type="text" id="email" name="email" required="" lay-verify="email"
                          autocomplete="off" class="layui-input" runat="server">
                      </div>
                      
                  </div>
                  <div class="layui-form-item">
                      <label for="L_pass" class="layui-form-label">
                          用户类型
                      </label>        
                      <div  class="gly">                                 
                      <asp:DropDownList ID="DropDownList1" runat="server" >
                          <asp:ListItem>普通用户</asp:ListItem>
                          <asp:ListItem>会员</asp:ListItem>
                          <asp:ListItem>管理员</asp:ListItem>
                      </asp:DropDownList></div>  
                                            
                  </div>
                  <div class="layui-form-item">
                      <label for="L_repass" class="layui-form-label">
                          确认添加
                      </label>
                      <asp:Button ID="Button1"  Text="添加" class="layui-btn" runat="server" OnClick="Button1_Click1"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <label>结果：</label><label id="jg" runat="server"></label>
                  </div>
                  
    
              </form>
            </div>
        </div>
        <script>layui.use(['form', 'layer'],
            function () {
                $ = layui.jquery;
                var form = layui.form,
                layer = layui.layer;

                //自定义验证规则
                form.verify({
                    nikename: function (value) {
                        if (value.length < 5) {
                            return '昵称至少得5个字符啊';
                        }
                    },
                    pass: [/(.+){6,12}$/, '密码必须6到12位'],
                    repass: function (value) {
                        if ($('#L_pass').val() != $('#L_repass').val()) {
                            return '两次密码不一致';
                        }
                    }
                });

                //监听提交
                form.on('submit(add)',
                function (data) {
                    console.log(data);
                    //发异步，把数据提交给php
                    layer.alert("增加成功", {
                        icon: 6
                    },
                    function () {
                        //关闭当前frame
                        xadmin.close();

                        // 可以对父窗口进行刷新 
                        xadmin.father_reload();
                    });
                    return false;
                });

            });</script>
        <script>var _hmt = _hmt || []; (function () {
    var hm = document.createElement("script");
    hm.src = "https://hm.baidu.com/hm.js?b393d153aeb26b46e9431fabaf0f6190";
    var s = document.getElementsByTagName("script")[0];
    s.parentNode.insertBefore(hm, s);
})();</script>
    </body>

</html>
