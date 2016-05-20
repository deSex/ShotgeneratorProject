angular.module('generator')
.controller('generatorController', ['$scope', 'generatorFactory'], function($scope,generatorFactory) {

    $scope.getUser = function () {
        generatorFactory.getCurrentUser
    }
})