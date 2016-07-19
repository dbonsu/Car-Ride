(function () {
    'use strict';

    angular.module('carRide')
        .config(CarRide);

    CarRide.$inject = ['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider'];
    function CarRide($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider) {
        $urlRouterProvider.otherwise('/');

        $stateProvider
        .when();
    };
})()