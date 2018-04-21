$(function(){
    $("#wholeTip").hide();
})
function CheckIdNumber(){
    var idNum=$("#idNumber").val();
    var idNumbRepeat=$("#idNumberRepeat").val();
    //输入身份证相同
    if(idNum===idNumbRepeat){
        $.get("/Apply/RedirectToApplyPage",{idNumber:idNum},function(data){
            if(data.status==1&&data.msg==""){
                $(location).attr('href', data.data);
            }
            else{
                $("#tipContent").html(data.msg);
                $("#wholeTip").show();
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