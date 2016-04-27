angular.module('generator')
    .factory('generatorFactory', ['$http', function ($http) {
        console.log('inne i generatorFactory');


        return {
            getUserId: function (userId) {
                return $http.get("api.shotgenerator/api/generator/user/" + userId);
            }
        };
    }]);