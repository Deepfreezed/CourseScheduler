// home-index.js
var module = angular.module("homeIndex", ["ngRoute"]);

module.config(function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "homeController",
        templateUrl: "/templates/homeView.html"
    });

    $routeProvider.otherwise({ redirectTo: "/" });
});

module.controller("homeController", function ($scope) {
    $scope.name = "Janith C. Samarasekera";
    $scope.data = [
        {
            courseNum: "c1",
            courseName: "Course 1",
            teacher: "teach 1"
        },
        {
            courseNum: "c2",
            courseName: "Course 2",
            teacher: "teach 2"
        },
        {
            courseNum: "c3",
            courseName: "Course 3",
            teacher: "teach 3"
        },
    ];
});