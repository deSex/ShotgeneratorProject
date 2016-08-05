var app = angular.module('app', 'ngRoute']);

console.log("inne i app");
app.config(function ($routeProvider, $locationProvider) {

    console.log("inne i config");
    $routeProvider
    .when('/generator', {
        templateUrl: 'Views/Generator/generator.cshtml'
    })
    .when('home', {
        templateUrl: 'Views/Home/Index.cshtml'
    });
    $locationProvider.html5Mode(true);
});


