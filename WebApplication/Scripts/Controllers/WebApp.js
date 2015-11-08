var WebApp = angular.module('WebApp', ['ngRoute']);

WebApp.controller('MenuController', MenuController);

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
        .otherwise({
            redirectTo: '/'
    });;
}

configFunction.$inject = ['$routeProvider'];

WebApp.config(configFunction);