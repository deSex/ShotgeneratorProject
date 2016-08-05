
'use strict';
angular.module('app', ['ngRoute'])
.config(function ($routeProvider, $locationProvider) {
    $routeProvider
    .when('generator', {
        templateUrl: 'Views/Generator/generator.cshtml'
    })
    .when('home', {
        templateUrl: 'Views/Home/Index.cshtml'
    });
    $locationProvider.html5Mode(true);
});


