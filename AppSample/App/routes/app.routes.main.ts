((): void => {
    'use strict';
    angular.module('app.routes').config(['$locationProvider', '$routeProvider', config]);

    function config($locationProvider: ng.ILocationProvider, $routeProvider: ng.route.IRouteProvider): void {
        $routeProvider
            .when('/Sample', {
                templateUrl: '/Sample/PageFactory/0'
            })
            .when('/Sample/Page1', {
                templateUrl: '/Sample/PageFactory/1'
            })
            .when('/Sample/Page2', {
                templateUrl: '/Sample/PageFactory/2'
            })
            .when('/Sample/Page3', {
                templateUrl: '/Sample/PageFactory/3'
            })
            .when('/Sample/Page4', {
                templateUrl: '/Sample/PageFactory/4'
            })
            .when('/Sample/Page5', {
                templateUrl: '/Sample/PageFactory/5'
            })
            .when('/Sample/Page6', {
                templateUrl: '/Sample/PageFactory/6'
            })
            .when('/Sample/Page7', {
                templateUrl: '/Sample/PageFactory/7'
            })
            .when('/Sample/Page8', {
                templateUrl: '/Sample/PageFactory/8'
            });
    }
})();