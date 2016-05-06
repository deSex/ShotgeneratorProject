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

    $scope.saveUserSettings = function () {
        console.log($scope.user);

        var userSettings = $scope.user;
        //generatorFactory.saveUserSettings(userSettings)
        //.then(function (response) {
        //    $scope.status = 'Saved user';

        //}, function (error) {
        //    $scope.status = 'Unable to save user..' + error.message;
        //});
      
    };


}]);