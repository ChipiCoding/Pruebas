var App = angular.module('App', ['ngRoute', 'ngResource']);

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
        .when('/DocumentsTypes', {
            templateUrl: 'DocumentsTypes/index'
        })
        .otherwise({
            redirectTo: '/'
        });
}

configFunction.$inject = ['$routeProvider'];

App.config(configFunction);
