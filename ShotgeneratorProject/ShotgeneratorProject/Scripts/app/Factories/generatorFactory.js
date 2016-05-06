angular.module('generator')
    .factory('generatorFactory', ['$http', function ($http) {
        console.log('inne i generatorFactory');
        var urlBase = '/api/values';

        return {
            saveUserSettings: function (userSettings) {
                return $http.post('http://api.shotgenerator/api/generator/usersettings', userSettings);
            }
        };
    }]);