angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'generatorFactory', function ($scope, generatorFactory) {


    $scope.numberOfPlayers = 0;
    $scope.user = {};
    console.log('inne i generatorOptionsController');
    $scope.$watch('playerQuantity', function (userInput) {
        $scope.userFields = [];
        $scope.players = [];
        for (var i = 0; i < userInput; i++) {

            console.log(userInput);
            if (i >= 30) {
                return;
            }
            else {
                $scope.userFields.push(userInput);
            }
        }
    });


    $scope.receiveUser = function () {
        console.log($scope.user);
        
        var temporaryUserInformation = $scope.user;
     

    };


}]);