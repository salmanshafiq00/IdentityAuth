// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#chk_0").click(function () {
        console.log("Hello");
        $("#TestConfigDetails_0__SubjectId").removeAttr('disabled');
        $("#TestConfigDetails_0__ResultGradeId").removeAttr('disabled');
    })
    $("#chk_1").click(function () {
        console.log("Hello");
        $("#TestConfigDetails_1__SubjectId").removeAttr('disabled');
        $("#TestConfigDetails_1__ResultGradeId").removeAttr('disabled');
    })
    $("#chk_2").click(function () {
        console.log("Hello");
        $("#TestConfigDetails_2__SubjectId").removeAttr('disabled');
        $("#TestConfigDetails_2__ResultGradeId").removeAttr('disabled');
    })
})