$(document).ready(function () {
    var educationCount = 0;
    $("#addEducation").bind("click", function () {
        var index = educationCount;
        $("#education").append("<div class=\"form-group\">" +
            "<label>Degree</label>" +
            "<input type=\"text\" name=\"Educations[Model.Educations.Count + " + index + "].Degree\" class=\"form-control\" id=\"" + index + "\"/>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Specialization</label>" +
            "<input type=\"text\" name=\"Educations[Model.Educations.Count + " + index + "].Specialization\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>School</label>" +
            "<input type=\"text\" name=\"Educations[Model.Educations.Count + " + index + "].School\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"Educations[Model.Educations.Count + " + index + "].StartDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"Educations[Model.Educations.Count + " + index + "].EndDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        educationCount = educationCount + 1;
    });
    var workCount = 0;
    $("#addWorkExperience").bind("click", function () {
        var index = workCount;
        $("#work").append("<div class=\"form-group\">" +
            "<label>Job Title</label>" +
            "<input type=\"text\" name=\"WorkExperiences[Model.WorkExperiences.Count + " + index + "].JobTitle\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Company</label>" +
            "<input type=\"text\" name=\"WorkExperiences[Model.WorkExperiences.Count + " + index + "].Company\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Start Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[Model.WorkExperiences.Count + " + index + "].StartDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>End Date</label>" +
            "<input type=\"text\" name=\"WorkExperiences[Model.WorkExperiences.Count + " + index + "].EndDate\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Job Description</label>" +
            "<input type=\"text\" name=\"WorkExperiences[Model.WorkExperiences.Count + " + index + "].JobDescription\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        workCount = workCount + 1;
    });
    var otherCount = 0;
    $("#addAdditionalInformation").bind("click", function (e) {
        var index = otherCount;
        $("#other").append("<div class=\"form-group\">" +
            "<label>Title</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Title\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>" +
            "<div class=\"form-group\">" +
            "<label>Text Field</label>" +
            "<input type=\"text\" name=\"Properties[" + index + "].Text\" class=\"form-control\" id=\"" + index + "\"//>" +
            "</div>");
        otherCount = otherCount + 1;
    });
});