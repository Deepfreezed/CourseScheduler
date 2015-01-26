//course-index.js
var module = angular.module("courseIndex", []);

module.config(function ($routeProvider) {
    $routeProvider.when("/", {
        controller: "courseController",
        templateUrl: "/templates/courseView.html"
    });

    $routeProvider.otherwise({ redirectTo: "/"});
});

module.controller("courseController", function ($scope, $http) {
    $scope.data = [];
    $scope.isBusy = true;

    var req = {
        method: 'GET',
        url: '/api/Course',
        cache: false,
    }

    $http(req)
        .success(function (data, status, headers, config) {
            //successful
            angular.copy(data, $scope.data);
        })       
        .error(function (data, status, headers, config) {
            //Error
            alert("could not load courses");
        })
        .then(function () {
            $scope.isBusy = false;
        })
});