var shotgeneratorApp = angular.module('shotgeneratorApp', [
    'ngRoute', 'angular-loading-bar','apiClient'
]);
console.log('inne i shotgeneratorApp');



shotgeneratorApp.config(function ($routeProvider) {

    console.log("inne i config");
    $routeProvider.when("/customize",
        {
            controller: "generator-options-controller",
            templateUrl: "/views/generator/customize.cshtml"
        });

    $routeProvider.when("/generator",
        {
            controller: "generator-controller",
            templateUrl: "/views/generator/index..cshtml"
        });

    $routeProvider.otherwise({ redirectTo: "/home" });
    
    $httpProvider.interceptors.push('authInterceptorService');

    
})

