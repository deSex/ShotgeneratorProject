angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'generatorFactory', function ($scope, generatorFactory) {
    $scope.numOfPlayers = 0;

    console.log('inne i generatorOptionsController');
    $scope.$watch('numOfPlayers', function (newValue) {
        $scope.fields = [];
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
        generatorFactory.getUserId(1).success(function (result) {
            $scope.testValue = result;
        });
    }

}]);