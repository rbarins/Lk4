$(document).ready(function(){
    $("#button-menu").click(function(){
        $("#menu").toggle(100);
    })
    //FINAL DO TOOGLE

    //CLICK CONTAINER 
    $("#container").click(function(){
        $("#menu").css({display: "none"});
        $("#button-menu").css({marginLeft: "2%"});
    });
    //CLICK CONTAINER
})