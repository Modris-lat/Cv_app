$(document).ready(function () {
    $(".addEducation").bind("click", function () {
        var index = $(".additionalEducation").length;
        $("#education").append(
            "<div class=\"form-group\" >" +
            "<span class=\"additionalEducation\">New</span>" +
            "<div class=\"form-group\">" +
            "<label>Degree</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].Degree\" class=\"form-control\"  />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Specialization</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].Specialization\" class=\"form-control\"  required/>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>School</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].School\" class=\"form-control\"  />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].StartDate\" class=\"form-control\"  />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].EndDate\" class=\"form-control\"  />" +
            "</div>" +
            "<input type=\"button\" class=\"removeNewElement\" value=\"Remove\" />" +
            "</div>");
    });

    $(".addWorkExperience").bind("click", function () {
        var index = $(".additionalWorkExperience").length;
        $("#work").append(
            "<div class=\"form-group\" >" +
            "<span class=\"additionalWorkExperience\">New</span>" +
            "<div class=\"form-group\">" +
            "<label>Job Title</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].JobTitle\" class=\"form-control\"  required/>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Company</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].Company\" class=\"form-control\"  />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].StartDate\" class=\"form-control\"  />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].EndDate\" class=\"form-control\" />" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Job Description</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].JobDescription\" class=\"form-control\"  style=\"width: 350px; height: 250px; text - align: justify\"/>" +
            "</div>" +
            "<input type=\"button\" class=\"removeNewElement\" value=\"Remove\" />" +
            "</div>");
    });

    $(".addAdditionalInformation").bind("click", function () {
        var index = $(".additionalInfo").length;
        $("#other").append(
            "<div class=\"form-group\" >" +
            "<span class='additionalInfo'>New</span>" +
            "<div class=\"form-group\"" +
            "<label>Title</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Title\" class=\"form-control\" required/>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Text Field</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Text\" class=\"form-control\" style=\"width: 350px; height: 250px; text - align: justify\" required/>" +
            "</div>" +
            "<input type=\"button\" class=\"removeNewElement\" value=\"Remove\" />" +
            "</div>");
    });
    $(".removeElement").bind("click", function() {
        $(this).parent().remove();
        $('.additionalInfo').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "Properties[" + index + "].Title");
            $(this).closest("div").children("div").last().children("input").attr("name", "Properties[" + index + "].Text");
        });
        $('.additionalWorkExperience').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "WorkExperiences[" + index + "].JobTitle");
            $(this).closest("div").children("div").eq(1).children("input").attr("name", "WorkExperiences[" + index + "].Company");
            $(this).closest("div").children("div").eq(2).children("input").attr("name", "WorkExperiences[" + index + "].StartDate");
            $(this).closest("div").children("div").eq(3).children("input").attr("name", "WorkExperiences[" + index + "].EndDate");
            $(this).closest("div").children("div").last().children("input").attr("name", "WorkExperiences[" + index + "].JobDescription");
        });
        $('.additionalEducation').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "Educations[" + index + "].Degree");
            $(this).closest("div").children("div").eq(1).children("input").attr("name", "Educations[" + index + "].Specialization");
            $(this).closest("div").children("div").eq(2).children("input").attr("name", "Educations[" + index + "].School");
            $(this).closest("div").children("div").eq(3).children("input").attr("name", "Educations[" + index + "].StartDate");
            $(this).closest("div").children("div").last().children("input").attr("name", "Educations[" + index + "].EndDate");
        });
    });
    $(".form-group").on("click", ".removeNewElement", function () {
        $(this).parent().remove();
        $('.additionalInfo').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "Properties[" + index + "].Title");
            $(this).closest("div").children("div").last().children("input").attr("name", "Properties[" + index + "].Text");
        });
        $('.additionalWorkExperience').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "WorkExperiences[" + index + "].JobTitle");
            $(this).closest("div").children("div").eq(1).children("input").attr("name", "WorkExperiences[" + index + "].Company");
            $(this).closest("div").children("div").eq(2).children("input").attr("name", "WorkExperiences[" + index + "].StartDate");
            $(this).closest("div").children("div").eq(3).children("input").attr("name", "WorkExperiences[" + index + "].EndDate");
            $(this).closest("div").children("div").last().children("input").attr("name", "WorkExperiences[" + index + "].JobDescription");
        });
        $('.additionalEducation').each(function (index) {
            $(this).closest("div").children("div").first().children("input").attr("name", "Educations[" + index + "].Degree");
            $(this).closest("div").children("div").eq(1).children("input").attr("name", "Educations[" + index + "].Specialization");
            $(this).closest("div").children("div").eq(2).children("input").attr("name", "Educations[" + index + "].School");
            $(this).closest("div").children("div").eq(3).children("input").attr("name", "Educations[" + index + "].StartDate");
            $(this).closest("div").children("div").last().children("input").attr("name", "Educations[" + index + "].EndDate");
        });
    });
});