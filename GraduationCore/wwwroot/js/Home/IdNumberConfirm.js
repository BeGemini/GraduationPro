$(function(){
    $("#wholeTip").hide();
})
function CheckIdNumber(){
    var idNum=$("#idNumber").val();
    var idNumbRepeat=$("#idNumberRepeat").val();
    //判空
    if(idNum===""){
        $("#tipContent").html("请输入身份证号！");
        $("#wholeTip").show();
        return;
    }
    if(idNumbRepeat===""){
        $("#tipContent").html("请再次输入身份证号！");
        $("#wholeTip").show();
        return;
    }
    if(!$("#rdo_local").is(':checked')&&!$("#rdo_flocal").is(':checked')){
        $("#tipContent").html("请选择户籍类型！");
        $("#wholeTip").show();
        return;
    }
    //输入身份证相同
    if(idNum===idNumbRepeat){
        $.get("/Apply/RedirectToApplyPage",{idNumber:idNum,isLocal:$("#rdo_local").is(':checked')?1:0},function(data){
            if(data.status==1&&data.msg==""){
                $(location).attr('href', data.data);
            }
            else{
                $("#tipContent").html(data.msg);
                $("#wholeTip").show();
                return;
            }
        });
    }
    //输入身份证不同
    else{
        $("#tipContent").html("两次输入的身份证号不一致！");
        $("#wholeTip").show();
    }
}

function hideDiv(){
    $("#wholeTip").hide();
}