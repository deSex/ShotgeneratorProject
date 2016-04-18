shotgeneratorControllers.controller('generatorOptionsController', ['$scope', function ($scope) {
    $scope.numOfPlayers = 0;

    $scope.$watch('numOfPlayers', function (newValue) {
        $scope.fields = [];
        for (var i = 0; i < newValue; i++) {
            $scope.fields.push(i);
        }
    });
}]);