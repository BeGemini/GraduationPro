function insertStudents(){
    $.ajax({
        type:"POST",
        dataType:"json",
        url:"ApplyPage/InsertStudents",
        data:$("#form_stu").serialize(),
        success:function(data){
            
        }
    });
}