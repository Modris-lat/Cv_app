$(document).ready(function () {
    var count1 = 0;
    $("#addEducation").bind("click", function () {
        var index = count1;
        $("#education").append("<div class=\"form-group\">" +
            "<label>Degree</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].Degree\" class=\"form-control\" id=\"" + index + "\"/>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Specialization</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].Specialization\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>School</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].School\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].StartDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"Educations[" + index + "].EndDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        count1 = count1 + 1;
    });
    var count2 = 0;
    $("#addWorkExperience").bind("click", function () {
        var index = count2;
        $("#work").append("<div class=\"form-group\">" +
            "<label>Job Title</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].JobTitle\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Company</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].Company\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].StartDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].EndDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Job Description</label>" +
            "<input type=\"text\" name=\"WorkExperiences[" + index + "].JobDescription\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        count2 = count2 + 1;
    });
    var count3 = 0;
    $("#addAdditionalInformation").bind("click", function () {
        var index = count3;
        $("#other").append("<div class=\"form-group\">" +
            "<label>Title</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Title\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Text Field</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Text\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        count3 = count3 + 1;
    });
});