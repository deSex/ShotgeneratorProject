angular.module('generator')
.controller('generatorOptionsController', ['$scope', 'apiClient', function ($scope, apiClient) {


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

    $scope.saveGeneratorSettings = function() {
        var generatorSettings = $scope.generator;

        if (generatorSettings != 'undefined') {

                //$scope.user.userSettings.players = $scope.players;
          

                apiClient.saveGeneratorSettings(generatorSettings)
                .then(function (response) {
                    $scope.status = 'Saved generatorsettings';
                    window.location = "http://shotgeneratorn.local/Generator/Customize";

                }).catch(function (error) {
                    $scope.status = 'Unable to save user..' + error.message;
                });

            
        }
    }



}]);