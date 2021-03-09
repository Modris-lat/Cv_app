$(document).ready(function () {
    $(".addEducation").bind("click", function () {
        var index = $(".additionalEducation").length;
        $("#education").append(
            "<div class=\"form-group\" >" +
            "<span class=\"additionalEducation\">###########</span>" +
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
            "<span class=\"additionalWorkExperience\">###########</span>" +
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
            "<span class='additionalInfo'>###########</span>" +
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
    });
    $(".form-group").on("click", ".removeNewElement", function () {
        $(this).parent().remove();
    });
});