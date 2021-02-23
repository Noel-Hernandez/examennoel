// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//this function loads the website

//this function loads the website
$(document).ready(function () {

    //LoadData();
    LoadDataNationality();
    LoadDataMajor();
});


function Add() {
    // var e = document.getElementById("nationalities");

    var student = {

        name: $('#name').val(),
        email: $('#email').val(),
        password: $('#password').val(),
        age: $('age').val(),
        //nationality_id: $("#nationalities :selected").val();

    };

    $.ajax({
        url: "/Home/Insert",
        data: JSON.stringify(student),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            document.getElementById('name').value = '';
            document.getElementById('email').value = '';
            document.getElementById('password').value = '';
            document.getElementById('age').value = '';
            document.getElementById('nationalities') = '';
            document.getElementById('major') = '';
            document.getElementById('enterSucess').style.color = "#10D894";
            document.getElementById('enterSucess').textContent = "Success Registry. Please check your mail";
            document.getElementById('enterSucess').style.visibility = "visible";
            $('#enterSucess').fadeOut(7000);

        },
        error: function (errorMessage) {
            document.getElementById('enterSucess').style.color = "#E72E1F";
            document.getElementById('enterSucess').textContent = "¡There was an error, try again later!";
            document.getElementById('enterSucess').style.visibility = "visible";
            $('#enterSucess').fadeOut(7000);
        }

    });
}

function LoadDataNationality() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Home/GetNationality",
            data: "{}",
            success: function (data) {
                var s = '<option value="-1">Please Select a Nationality</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].id + '">' + data[i].name + '</option>';
                }
                $("#nationalities").html(s);
            }
        });
    });
}
function LoadDataMajor() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Home/GetMajor",
            data: "{}",
            success: function (data) {
                var s = '<option value="-1">Please Select a Major</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].id + '">' + data[i].name + '</option>';
                }
                $("#major").html(s);
            }
        });
    });
}
function LoadData() {

}

function Delete(id) {





}


function AddContact() {

    var contact = {

        nameContact: $('#nameContact').val(),
        emailContact: $('#emailContact').val(),
        informationContact: $('#informationContact').val()

    };

    $.ajax({
        url: "/Home/InsertData1",
        data: JSON.stringify(contact),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            document.getElementById('nameContact').value = '';
            document.getElementById('emailContact').value = '';
            document.getElementById('informationContact').value = '';
            //se recibe el result del back-end 
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });


}

