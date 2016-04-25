angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'generatorFactory', function ($scope, generatorFactory) {
    $scope.numOfPlayers = 0;
    $scope.user = {};
    console.log('inne i generatorOptionsController');
    $scope.$watch('numOfPlayers', function (newValue) {
        $scope.fields = [];
        $scope.players = [];
        for (var i = 0; i < newValue; i++) {
         
            if (newValue > 30) {

                $scope.field.push(30);
            }
            else {
                $scope.fields.push(i);
            }
        }
    });


    $scope.receiveUser = function () {
        console.log($scope.user);
        //generatorFactory.getUserId(1).success(function (result) {
        //    $scope.testValue = result;
    };


}]);