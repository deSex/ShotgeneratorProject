'use strict';
shotgeneratorApp.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.loginData = {
        userName: "",
        password: ""
    };

    var _responseError = function (rejection) {
        if (rejection.status === 401) {
            $location.path ("/income");
        localStorageService.remove ("authorizationData");
        }
return $q.reject (rejection);
    };

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {

            $location.path('/customize');

        },
         function (err) {
             $scope.message = err.error_description;
         });
    };



}]);