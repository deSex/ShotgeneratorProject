angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'generatorFactory', function ($scope, generatorFactory) {


    $scope.numberOfPlayers = 0;
    $scope.user = {};
    console.log('inne i generatorOptionsController');
    $scope.$watch('playerQuantity', function (userInput) {
        $scope.userFields = [];
        $scope.players = [];
        for (var i = 0; i < userInput; i++) {


            if (i >= 30) {
                return;
            }
            else {
                $scope.userFields.push(userInput);
            }
        }
    });

    $scope.saveTemporaryUserSettings = function () {
        console.log($scope.user);

        var temporaryUserInformation = $scope.user;
        generatorFactory.saveGeneratorSettings(temporaryUserInformation)
        .then(function (response) {
            $scope.status = 'Saved user';

        }, function (error) {
            $scope.status = 'Unable to save user..' + error.message;
        });
        console.log($scope.status);
    };


}]);