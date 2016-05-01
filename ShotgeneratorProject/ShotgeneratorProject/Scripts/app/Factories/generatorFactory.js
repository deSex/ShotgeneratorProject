angular.module('generator')
    .factory('generatorFactory', ['$http', function ($http) {
        console.log('inne i generatorFactory');
        var urlBase = '/api/values';

        return {
            saveGeneratorSettings: function (temporaryUser) {
                return $http.post('http://api.shotgeneratorn/api/values/users/', temporaryUser);
            }
        };
    }]);