var app = angular.module("courseScheduler", []);

app.controller("courseIndexController", function ($scope, $http) {
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