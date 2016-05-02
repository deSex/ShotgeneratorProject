angular.module('generator')
    .factory('generatorFactory', ['$http', function ($http) {
        console.log('inne i generatorFactory');


        return {
            saveTemporaryUser: function (temporaryUser) {
                return $http.get("api.shotgenerator/api/values/user/save" + temporaryUser);
            }
        };
    }]);