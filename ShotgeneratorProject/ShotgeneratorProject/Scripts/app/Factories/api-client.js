angular.module('apiClient')
    .factory('saveUserSettings', ['$http', function ($http) {
        console.log('inne i apiClient');
        var urlBase = '/api/values';
        this.saveUserSettings = function (userSettingsList) {
            return $http.post('http://api.shotgenerator/api/account/register', userSettingsList);
        };

        this.saveGeneratorSettings = function (generatorSettings) {
            return $http.post('http://api.shotgenerator/api/generator/save', generatorSettings);
        }
    }]);


'use strict';
app.factory('generatorService', ['$http', function ($http) {

    var serviceBase = 'http://api.shotgenerator/';


    var _generatorSettings = function () {

        return $http.post(serviceBase + 'api/generator/customize').then(function (results) {
            return results;
        });
    };



}]);