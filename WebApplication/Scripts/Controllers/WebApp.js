var WebApp = angular.module('WebApp', ['ngRoute']);

WebApp.controller('MenuController', MenuController);
//WebApp.controller('PruebaController', PruebaController);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/optionOne', {
            templateUrl: 'Menu/one'
        })
        .when('/optionTwo', {
            templateUrl: 'Menu/two'
        })
        .when('/optionThree', {
            templateUrl: 'Menu/three'
        })
        .when('/Prueba', {
            templateUrl: 'Menu/Prueba'
        })
        .otherwise({
            redirectTo: '/'
        });
}

configFunction.$inject = ['$routeProvider'];

WebApp.config(configFunction);