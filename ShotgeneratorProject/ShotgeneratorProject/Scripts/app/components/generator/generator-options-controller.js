angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'generatorFactory', function ($scope, generatorFactory) {


    $scope.numberOfPlayers = 0;
    $scope.user = {};
    console.log('inne i generatorOptionsController');
    $scope.$watch('playerQuantity', function (userInput) {
        $scope.players = [];

        for (var i = 0; i < userInput; i++) {
            if (i >= 30) { 
                return;
            }
            else {
                var player = { firstName: "", lastName: "" }
                $scope.players.push(player);
            }
        }
    });

    $scope.saveUserSettings = function () {
        console.log($scope.user);
        //$scope.user.userSettings.players = $scope.players;
        var userSettingsList = $scope.user;

        generatorFactory.saveUserSettings(userSettingsList)
        .then(function (response) {
            $scope.status = 'Saved user';
            window.location = "http://shotgeneratorn.local/Generator/Customize";

        }).catch(function (error) {
            $scope.status = 'Unable to save user..' + error.message;
        });

    };


}]);